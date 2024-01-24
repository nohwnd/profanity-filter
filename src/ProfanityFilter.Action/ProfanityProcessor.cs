﻿// Copyright (c) David Pine. All rights reserved.
// Licensed under the MIT License.

namespace ProfanityFilter.Action;

internal sealed class ProfanityProcessor(
    CustomGitHubClient client,
    IProfaneContentCensorService profaneContentCensor,
    ICoreService core)
{
    public async Task ProcessProfanityAsync()
    {
        var success = true;

        try
        {
            if (TryGetContext(out var context) is false)
            {
                return;
            }

            var isIssueComment = context.Payload?.Comment is not null;
            var isIssue = context.Payload?.Issue is not null;
            var isPullRequest = context.Payload?.PullRequest is not null;

            Func<long, Label?, Task> handler = (isIssueComment, isIssue, isPullRequest) switch
            {
                (true, _, _) => HandleIssueCommentAsync,
                (_, true, _) => HandleIssueAsync,
                (_, _, true) => HandlePullRequestAsync,

                _ => throw new Exception(
                    "The profanity filter GitHub Action only works with issues or pull requests.")
            };

            var label = isIssueComment ? null : await client.GetLabelAsync();
            if (label is null && isIssueComment is false)
            {
                core.Warning("""
                    The expected label isn't present, a label with the following name is would have been applied if found.
                        'profane content 🤬'
                    """);
            }

            var numberOrId = (context.Payload?.Comment?.Id
                ?? context.Payload?.Issue?.Number
                ?? context.Payload?.PullRequest?.Number
                ?? 0L)!;

            await handler(numberOrId, label ?? null);
        }
        catch (Exception ex)
        {
            success = false;

            core.SetFailed(ex.ToString());
            Env.Exit(Env.ExitCode);
        }
        finally
        {
            if (success)
            {
                core.Info("Profanity filter completed successfully.");
                Env.Exit(0);
            }
        }
    }

    private bool TryGetContext([NotNullWhen(true)] out Context? context)
    {
        try
        {
            context = Context.Current;
            core.Info(context.ToString() ?? "Unknown context");

            var isValidAction = context.Action switch
            {
                "profanity-filter" or
                "opened" or "reopened" or
                "created" or "edited" => true,

                _ when (context.Action ?? "").StartsWith("__run") => true,

                _ => false
            };

            if (isValidAction is false)
            {
                core.Warning($"The action '{context.Action}' is not supported.");

                return false;
            }

            var isValidActor = context.Actor switch
            {
                "bot" or
                "dependabot" or "dependabot[bot]" or
                "github-actions" or "github-actions[bot]" => false,

                _ => true
            };

            if (isValidActor is false)
            {
                core.Info($"Ignored as {context.Actor} triggered this...");

                return false;
            }

            return true;
        }
        catch (Exception ex)
        {
            core.Error($"""
                Error attempting to get the context:
                  {ex}
                """);
        }

        context = null;
        return false;
    }

    private async Task HandleIssueCommentAsync(long issueCommentId, Label? label)
    {
        // We don't apply labels to issue comments, discard it...
        _ = label;

        core.StartGroup($"Evaluating issue comment id #{issueCommentId} for profanity");

        try
        {
            var issueComment = await client.GetIssueCommentAsync(issueCommentId);
            if (issueComment is null)
            {
                core.Error($"Unable to get issue comment with id: {issueCommentId}");
                return;
            }

            var replacementType = GetInputReplacementType();

            var (text, isFiltered) = await TryApplyFilterAsync(issueComment.Body ?? "", replacementType);

            if (isFiltered)
            {
                await client.UpdateIssueCommentAsync(issueCommentId, text);
            }
        }
        finally
        {
            core.EndGroup();
        }
    }

    private async Task HandleIssueAsync(long issueNumber, Label? label)
    {
        core.StartGroup($"Evaluating issue #{issueNumber} for profanity");

        try
        {
            var issue = await client.GetIssueAsync((int)issueNumber);
            if (issue is null)
            {
                core.Error($"Unable to get issue with number: {issueNumber}");
                return;
            }

            var replacementType = GetInputReplacementType();

            var filterResult = await ApplyProfanityFilterAsync(
                issue.Title ?? "", issue.Body ?? "", replacementType);

            if (filterResult.IsFiltered)
            {
                var issueUpdate = new IssueUpdate
                {
                    Body = filterResult.Body,
                    Title = new()
                    {
                        String = filterResult.Title
                    }
                };

                if (label is not null and { Name.Length: > 0 })
                {
                    if (issueUpdate.Labels is not null)
                    {
                        issueUpdate.Labels.Add(label.Name);
                    }
                    else
                    {
                        issueUpdate.Labels = [label.Name];
                    }
                }

                await client.UpdateIssueAsync(issue.Number.GetValueOrDefault(), issueUpdate);

                await client.AddReactionAsync(
                    issue.Id.GetValueOrDefault(), ReactionContent.Confused);
            }
        }
        finally
        {
            core.EndGroup();
        }
    }

    private async Task HandlePullRequestAsync(long pullRequestNumber, Label? label)
    {
        core.StartGroup($"Evaluating pull request #{pullRequestNumber} for profanity");

        try
        {
            var pullRequest = await client.GetPullRequestAsync((int)pullRequestNumber);
            if (pullRequest is null)
            {
                core.Error($"Unable to get PR with number: {pullRequestNumber}");
                return;
            }

            var replacementType = GetInputReplacementType();

            var filterResult = await ApplyProfanityFilterAsync(
                pullRequest.Title ?? "", pullRequest.Body ?? "", replacementType);

            if (filterResult.IsFiltered)
            {
                var issueUpdate = new PullRequestUpdate
                {
                    Body = filterResult.Body,
                    Title = filterResult.Title
                };

                await client.UpdatePullRequestAsync(
                    pullRequest.Number.GetValueOrDefault(), issueUpdate, label?.Name);

                await client.AddReactionAsync(
                    pullRequest.Id.GetValueOrDefault(), ReactionContent.Confused);
            }
        }
        finally
        {
            core.EndGroup();
        }
    }

    private async ValueTask<FilterResult> ApplyProfanityFilterAsync(
        string title, string body, ReplacementType replacementType)
    {
        if (string.IsNullOrWhiteSpace(title) &&
            string.IsNullOrWhiteSpace(body))
        {
            return FilterResult.NotFiltered;
        }

        var (resultingTitle, isTitleFiltered) = await TryApplyFilterAsync(title, replacementType);
        var (resultingBody, isBodyFiltered) = await TryApplyFilterAsync(body, replacementType);

        return new FilterResult(
            resultingTitle,
            isTitleFiltered,
            resultingBody,
            isBodyFiltered);
    }

    private async ValueTask<(string text, bool isFiltered)> TryApplyFilterAsync(
        string text, ReplacementType replacementType)
    {
        var filterText = await profaneContentCensor.ContainsProfanityAsync(text);
        var resultingText =
            filterText
                ? await profaneContentCensor.CensorProfanityAsync(text, replacementType)
                : text;

        if (filterText)
        {
            core.Info($"""
                Original text: {text}
                Filtered text: {resultingText}
                """);
        }

        return (resultingText, filterText);
    }

    private ReplacementType GetInputReplacementType() =>
        core.GetInput("replacement-type") is string value &&
        Enum.TryParse<ReplacementType>(value, out var type)
            ? type
            : ReplacementType.Asterisk;
}
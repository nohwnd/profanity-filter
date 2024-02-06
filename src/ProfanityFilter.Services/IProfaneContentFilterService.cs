﻿// Copyright (c) David Pine. All rights reserved.
// Licensed under the MIT License.

namespace ProfanityFilter.Services;

/// <summary>
/// Defines methods for checking and filtering profane content.
/// </summary>
public interface IProfaneContentFilterService
{
    /// <summary>
    /// Filters any profanity in the specified content.
    /// </summary>
    /// <param name="content">The content to filter.</param>
    /// <param name="parameters">The parameters to employ when filtering content.</param>
    /// <returns>A <see cref="ValueTask{TResult}"/> representing the asynchronous 
    /// operation, containing the filtered content.</returns>
    ValueTask<FilterResult> FilterProfanityAsync(
        string content,
        FilterParameters parameters);
}

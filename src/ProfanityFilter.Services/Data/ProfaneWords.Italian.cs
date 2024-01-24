﻿// Copyright (c) David Pine. All rights reserved.
// Licensed under the MIT License.

namespace ProfanityFilter.Services.Data;

internal static partial class ProfaneWords
{
    //internal static readonly string[] ItalianSwearWords =
    //[
    //    "a fanabla",
    //    "a pecorina",
    //    "abcdiet",
    //    "accidenti",
    //    "accidenti ",
    //    "affanculo",
    //    "alla cazzo di cane",
    //    "alla pecorina",
    //    "allupato",
    //    "amico del cazzo",
    //    "ammucchiata",
    //    "anabootcampdiet",
    //    "anale",
    //    "andare a puttane",
    //    "arrapato",
    //    "arrusa",
    //    "arruso",
    //    "assatanato",
    //    "avere la faccia come il culo",
    //    "avere un culo così grande",
    //    "bacha ma culo",
    //    "bafangu chooch",
    //    "bagasce",
    //    "bagascia",
    //    "bagascione",
    //    "bagassa",
    //    "bagnarsi",
    //    "baldracca",
    //    "baldraccacce",
    //    "baldraccaccia",
    //    "baldracche",
    //    "baldraccona",
    //    "baldraccone",
    //    "balle",
    //    "bariledimerda",
    //    "bastardacce",
    //    "bastardacci",
    //    "bastardaccia",
    //    "bastardaccio",
    //    "bastardamadonna",
    //    "bastarde",
    //    "bastardi",
    //    "bastardo",
    //    "bastardona",
    //    "bastardone",
    //    "bastardoni",
    //    "battere",
    //    "battona",
    //    "battone",
    //    "bbwpit",
    //    "belino",
    //    "biga",
    //    "bimbominkia",
    //    "bocchinara",
    //    "bocchinare",
    //    "bocchinari",
    //    "bocchinaro",
    //    "bocchini",
    //    "bocchino",
    //    "bofilo",
    //    "boiata",
    //    "bordello",
    //    "brinca",
    //    "brutto cornuto",
    //    "brutto figlio di puttana bastardo",
    //    "brutto stronzo",
    //    "bucaiolo",
    //    "budellodidio",
    //    "budiùlo",
    //    "buona donna",
    //    "busone",
    //    "bustadipiscio",
    //    "cacaminchia",
    //    "cacare",
    //    "cacasotto",
    //    "cacata",
    //    "cacca",
    //    "caciocappella",
    //    "cadavere",
    //    "cagacazzo",
    //    "cagaminchia",
    //    "cagare",
    //    "cagasotto",
    //    "cagata",
    //    "cagna",
    //    "cammello",
    //    "canacciodidio",
    //    "canagliadidio",
    //    "caned'allah",
    //    "caned'eva",
    //    "canedidio",
    //    "cappella",
    //    "carciofo",
    //    "carità",
    //    "carogna",
    //    "caronya",
    //    "casci",
    //    "cavolate",
    //    "cavolo",
    //    "cazzacci",
    //    "cazzaccio",
    //    "cazzaro",
    //    "cazzata",
    //    "cazzate",
    //    "cazzetti",
    //    "cazzetto",
    //    "cazzi",
    //    "cazzimma",
    //    "cazzissimo",
    //    "cazzo",
    //    "cazzo di merda",
    //    "cazzo in culo",
    //    "cazzo madre di dio",
    //    "cazzo si",
    //    "cazzona",
    //    "cazzone",
    //    "cazzoni",
    //    "cazzuta",
    //    "cazzute",
    //    "cazzuti",
    //    "cazzutissimo",
    //    "cazzuto",
    //    "ce l’hai piccolo",
    //    "ce un cibirut",
    //    "cesso",
    //    "che cavolo",
    //    "che cavolo.",
    //    "che cazzo",
    //    "che cazzo fai?",
    //    "che cazzo ne so",
    //    "che culo",
    //    "che due coglioni",
    //    "che due palle",
    //    "che palle",
    //    "che te pozzino ammazza",
    //    "checca",
    //    "checche",
    //    "chi cazzo sei tu?",
    //    "chiappa",
    //    "chiavare",
    //    "chiavata",
    //    "chiavate",
    //    "chiavatona",
    //    "chiavatone",
    //    "chissenefrega",
    //    "chissenefrega?",
    //    "ci sei cascato come una pirla",
    //    "ciolla",
    //    "ciolle",
    //    "ciornia",
    //    "ciospo",
    //    "ciucciamelo",
    //    "ciucciami il cazzo",
    //    "ciucciapalle",
    //    "cogliona",
    //    "coglionaggine",
    //    "coglionare",
    //    "coglionata",
    //    "coglionate",
    //    "coglionatore",
    //    "coglionatrice",
    //    "coglionatura",
    //    "coglionature",
    //    "coglionazzi",
    //    "coglionazzo",
    //    "coglioncelli",
    //    "coglioncello",
    //    "coglioncini",
    //    "coglioncino",
    //    "coglione",
    //    "coglioneria",
    //    "coglionerie",
    //    "coglioni",
    //    "col cavolo",
    //    "coprofago",
    //    "coprofilo",
    //    "cornuti",
    //    "cornuto",
    //    "cornutoilpapa",
    //    "cozza",
    //    "cozzo",
    //    "credoana",
    //    "cretinetti",
    //    "cretino",
    //    "cristod'undio",
    //    "cristodecapitato",
    //    "cristoincroce",
    //    "culattina",
    //    "culattone",
    //    "culattoni",
    //    "culi",
    //    "culo",
    //    "culona",
    //    "culone",
    //    "curnut",
    //    "dare un calcio nel culo a qualcuno",
    //    "deficiente",
    //    "di merda",
    //    "dietaabc",
    //    "dietaana",
    //    "dietaanabootcamp",
    //    "dietabootcamp",
    //    "dietadell'abc",
    //    "dio bastardo",
    //    "dio boia",
    //    "dio cane",
    //    "dio cangurello",
    //    "dio dannato",
    //    "dio fa",
    //    "dio Fottuto",
    //    "dio infame",
    //    "dio lupo",
    //    "dio maiale",
    //    "dio merda",
    //    "dio merdoso",
    //    "dio mona",
    //    "dio poj",
    //    "dio povero",
    //    "dio santo",
    //    "dio schifoso",
    //    "dio serpente",
    //    "dio sorcio",
    //    "dio stronzo",
    //    "dio verme",
    //    "dio zozzo",
    //    "diobastardo",
    //    "diobestia",
    //    "diobestiazza",
    //    "dioboia",
    //    "diocan",
    //    "diocane",
    //    "diocannaiolo",
    //    "diocapra",
    //    "diocoglione",
    //    "diocomunista",
    //    "diocrasto",
    //    "diocristo",
    //    "dioculattone",
    //    "diofarabutto",
    //    "diofascista",
    //    "diofinocchio",
    //    "dioflagellato",
    //    "dioimpestato",
    //    "dioimpiccato",
    //    "dioladro",
    //    "diolebbroso",
    //    "diolobotomizzato",
    //    "diolurido",
    //    "diomaiale",
    //    "diomaledetto",
    //    "diomerda",
    //    "diominchione",
    //    "dionegro",
    //    "dioporco",
    //    "diopoveraccio",
    //    "diopovero",
    //    "diorotto",
    //    "diorottoinculo",
    //    "diorutto",
    //    "diosbudellato",
    //    "dioschifoso",
    //    "dioseppellito",
    //    "dioserpente",
    //    "diostracane",
    //    "diostramerda",
    //    "diostronzo",
    //    "diosventrato",
    //    "dioverme",
    //    "ditalini",
    //    "ditalino",
    //    "dito al",
    //    "dove cazzo vai?",
    //    "duro",
    //    "e che cazzo",
    //    "essere un culo",
    //    "fa cagare",
    //    "fa schifo",
    //    "faccia a culo",
    //    "faccia di culo",
    //    "faccia di merda",
    //    "facciadaculo",
    //    "facciadimerda",
    //    "fanculo",
    //    "fare una sega",
    //    "fare unaŠ",
    //    "fatti i cazzi tuoi",
    //    "fatti una pugnetta",
    //    "fava",
    //    "femminuccia",
    //    "fica",
    //    "ficata",
    //    "ficate",
    //    "fiche",
    //    "fichetta",
    //    "fichette",
    //    "fichetti",
    //    "fichetto",
    //    "ficona",
    //    "ficone",
    //    "figa",
    //    "figata",
    //    "figate",
    //    "fighe",
    //    "fighetta",
    //    "fighette",
    //    "fighetti",
    //    "fighetto",
    //    "figliadicane",
    //    "figliadimignotta",
    //    "figliadiputtana",
    //    "figliaditroia",
    //    "figlidicani",
    //    "figlidimignotta",
    //    "figlidiputtana",
    //    "figliditroia",
    //    "figliedicani",
    //    "figliedimignotta",
    //    "figliediputtana",
    //    "figlieditroia",
    //    "figlio di buona donna",
    //    "figlio di mignotta",
    //    "figlio di puttana",
    //    "figlio di troia",
    //    "figlio un cane",
    //    "figliodicane",
    //    "figliodimignotta",
    //    "figliodiputtana",
    //    "figlioditroia",
    //    "figona",
    //    "figone",
    //    "figoni",
    //    "figura di merda",
    //    "finocchi",
    //    "finocchio",
    //    "fongoul",
    //    "formaggio",
    //    "fottere",
    //    "fottersi",
    //    "fottiti",
    //    "fottuta",
    //    "fottute",
    //    "fottuti",
    //    "fottutissima",
    //    "fottutissime",
    //    "fottutissimi",
    //    "fottutissimo",
    //    "fottuto",
    //    "fracicone",
    //    "frega un cazzo",
    //    "fregna",
    //    "frocetto",
    //    "froci",
    //    "frociara",
    //    "frociaro",
    //    "frociarola",
    //    "frociarolo",
    //    "frocio",
    //    "frocione",
    //    "frocioni",
    //    "frocissimo",
    //    "froscio",
    //    "fucker",
    //    "fumato il cervello",
    //    "fuori come un balcone",
    //    "garibaldi",
    //    "gesùcristaccio",
    //    "gesùesorcizzato",
    //    "gesùhandicappato",
    //    "gesùimpasticcato",
    //    "gesùmalandato",
    //    "gesùradioattivo",
    //    "gesùsieropositivo",
    //    "gesùstordito",
    //    "gesùzozzo",
    //    "gnocca",
    //    "gnocche",
    //    "goldone",
    //    "gran’ disgraziato",
    //    "grilletto",
    //    "guanto",
    //    "guardone",
    //    "heyyyyy",
    //    "i coglioni",
    //    "incazzare",
    //    "incazzarsi",
    //    "incazzata",
    //    "incazzate",
    //    "incazzati",
    //    "incazzatissima",
    //    "incazzatissime",
    //    "incazzatissimi",
    //    "incazzatissimo",
    //    "incazzato",
    //    "incazzato nero",
    //    "incoglionirsi",
    //    "inculare",
    //    "inculata",
    //    "inculate",
    //    "infrociato",
    //    "ingoio",
    //    "intro culo di mammata",
    //    "ir budello di tu ma’",
    //    "l'arte bolognese",
    //    "latrin",
    //    "leccacazzi",
    //    "leccaculi",
    //    "leccaculo",
    //    "leccafica",
    //    "leccafiga",
    //    "leccafighe",
    //    "leccami il culo",
    //    "leccami la figa",
    //    "leccapalle",
    //    "lecchino",
    //    "levati dai coglioni",
    //    "li mortacci tua",
    //    "lofare",
    //    "loffa",
    //    "loffare",
    //    "lui è proprio un bischero",
    //    "lui è un coglione",
    //    "lumaca",
    //    "ma’ va te ne a fanculo",
    //    "Madonna",
    //    "Madonna avvelenata",
    //    "Madonna bastarda",
    //    "Madonna bocchinara",
    //    "Madonna impalata",
    //    "Madonna infiammata",
    //    "Madonna maiala",
    //    "Madonna mignotta",
    //    "Madonna puttana",
    //    "madonna santa",
    //    "Madonna schifosa",
    //    "Madonna strega",
    //    "Madonna svergognata",
    //    "Madonna troia",
    //    "Madonna zoccola",
    //    "madonnaassassinata",
    //    "madonnacane",
    //    "madonnaimpestata",
    //    "madonnaisterica",
    //    "madonnalurida",
    //    "madonnamaiala",
    //    "madonnamongoloide",
    //    "madonnanegra",
    //    "madonnaputtana",
    //    "madonnaschiava",
    //    "madonnastregaccia",
    //    "madonnasudicia",
    //    "madonnasuicida",
    //    "madonnasurgelata",
    //    "madonnatroia",
    //    "madonnaviolentata",
    //    "mafankulo",
    //    "maiala",
    //    "manache",
    //    "mangia la minchia",
    //    "mangia merda",
    //    "mangia merde e morte",
    //    "manico",
    //    "mannaggia",
    //    "mannaggia tua",
    //    "mannaggiacristo",
    //    "mannaggiadio",
    //    "mannaggiailbattesimo",
    //    "mannaggiailclero",
    //    "mannaggiaisanti",
    //    "mannaggial'arcangelo",
    //    "mannaggialabibbia",
    //    "mannaggialadiocesi",
    //    "mannaggialamadonna",
    //    "mannaggialaputtana",
    //    "mannaggiapadrepio",
    //    "mannaggiasangiuseppe",
    //    "merda",
    //    "merdacce",
    //    "merdaccia",
    //    "merdamalcagata",
    //    "merdata",
    //    "merdate",
    //    "merde",
    //    "merdina",
    //    "merdine",
    //    "merdolina",
    //    "merdoline",
    //    "merdona",
    //    "merdone",
    //    "merdosa",
    //    "merdose",
    //    "merdosi",
    //    "merdoso",
    //    "mezza sega",
    //    "mezzasega",
    //    "mezzeseghe",
    //    "mi stai facendo incazzare",
    //    "micio",
    //    "mignotta",
    //    "mignotte",
    //    "minchia",
    //    "minchiadura",
    //    "minchiaduro",
    //    "minchiata",
    //    "minchiate",
    //    "minchie",
    //    "minchione",
    //    "minchioni",
    //    "miserabili pezzo di merda",
    //    "mona",
    //    "mone",
    //    "mongoloide",
    //    "monta",
    //    "montare",
    //    "mortacci tua",
    //    "mussa",
    //    "nave scuola",
    //    "negra",
    //    "negraccia",
    //    "negraccio",
    //    "negro",
    //    "negrona",
    //    "negrone",
    //    "nel culo",
    //    "nerchia",
    //    "nessuno mi unfungulo",
    //    "non hai capito una sega",
    //    "non me ne importa",
    //    "non mi rompere i coglioni",
    //    "nudo",
    //    "oddio",
    //    "padulo",
    //    "palle",
    //    "palloso",
    //    "patacca",
    //    "patonza",
    //    "patonze",
    //    "pecorina",
    //    "perché cazzo non mi rispondi?",
    //    "pesce",
    //    "pezzo di merda",
    //    "picio",
    //    "pigliacazzi",
    //    "pigliainculo",
    //    "pincare",
    //    "pinnolone",
    //    "pipa",
    //    "pipì",
    //    "pippone",
    //    "pirla",
    //    "pisciare",
    //    "pisciasotto",
    //    "pisciata",
    //    "pisciatina",
    //    "pisciato",
    //    "pisciatona",
    //    "piscio",
    //    "pisciona",
    //    "piscione",
    //    "piscioni",
    //    "pisello",
    //    "pistola",
    //    "pistolotto",
    //    "pomiciare",
    //    "pompa",
    //    "pompinara",
    //    "pompinare",
    //    "pompinari",
    //    "pompinaro",
    //    "pompini",
    //    "pompino",
    //    "porca",
    //    "porca madonna",
    //    "porca miseria",
    //    "porca paletta",
    //    "porca puttana",
    //    "porca troia",
    //    "porca vacca",
    //    "porcamadonna",
    //    "porcaputtana",
    //    "porco",
    //    "porco cane",
    //    "porco dio",
    //    "porco due",
    //    "porco giuda",
    //    "porco Iddio",
    //    "porco zio",
    //    "porcodidio",
    //    "porcodio",
    //    "porcoilclero",
    //    "porcoilsignore",
    //    "posso leccare il tua figa?",
    //    "potta",
    //    "prendere per il culo",
    //    "prete",
    //    "pro-ana",
    //    "pro-anoressia",
    //    "pro-bulimia",
    //    "pro-ed",
    //    "pro-ednos",
    //    "pro-mia",
    //    "proana",
    //    "proanoressia",
    //    "probulimia",
    //    "proed",
    //    "proednos",
    //    "promia",
    //    "pugnetta",
    //    "pugnette",
    //    "puppa",
    //    "puppamela",
    //    "puppamelo",
    //    "puppami",
    //    "puppare",
    //    "puppe",
    //    "puttana",
    //    "puttana la Madonna",
    //    "puttanacce",
    //    "puttanaccia",
    //    "puttanaeva",
    //    "puttanaio",
    //    "puttanamadonna",
    //    "puttanata",
    //    "puttanate",
    //    "puttane",
    //    "puttanella",
    //    "puttanelle",
    //    "puttaniere",
    //    "puttanieri",
    //    "puttano",
    //    "puttanona",
    //    "puttanone",
    //    "quaglia",
    //    "quando cazzo torni?",
    //    "raspone",
    //    "rasponi",
    //    "recchione",
    //    "regina",
    //    "ricchione",
    //    "ricchioni",
    //    "rincoglionire",
    //    "rincoglionito",
    //    "rizzacazzi",
    //    "rizzarsi",
    //    "rompere i miei coglioni",
    //    "rompere il culo a qualcuno",
    //    "rompiballe",
    //    "rompicazzi",
    //    "rompicazzo",
    //    "rompicoglioni",
    //    "rompipalle",
    //    "rotta in culo",
    //    "rottinculo",
    //    "rotto nel culo",
    //    "ruffiano",
    //    "santo cazzo madre di cristo",
    //    "sbattere",
    //    "sbattersi",
    //    "sbocchinare",
    //    "sbocchinato",
    //    "sbocchiniamolo",
    //    "sbora",
    //    "sborra",
    //    "sborrare",
    //    "sborrata",
    //    "sborrate",
    //    "sborrato",
    //    "sborratona",
    //    "sborro",
    //    "sborrone",
    //    "sbrodolata",
    //    "sburra",
    //    "sburrare",
    //    "sburro",
    //    "scassacazzo",
    //    "scassacoglioni",
    //    "scassaminchia",
    //    "scazzare",
    //    "scazzata",
    //    "scazzate",
    //    "scazzati",
    //    "scazzato",
    //    "schifoso",
    //    "scopare",
    //    "scopata",
    //    "scopate",
    //    "scoregge",
    //    "scoreggia",
    //    "scorreggiare",
    //    "scungio",
    //    "secchione",
    //    "sega",
    //    "segaiolo",
    //    "segars",
    //    "seghe",
    //    "segone",
    //    "sei diventato pazza?",
    //    "sei diventato pazzo?",
    //    "sei duro come il muro",
    //    "sei impazzita?",
    //    "sei impazzito?",
    //    "sei pazza?",
    //    "sei pazzo?",
    //    "sei scemo",
    //    "sei stupido",
    //    "sei un cretino",
    //    "sei un deficiente",
    //    "sei un idiota",
    //    "sei un rompicoglioni",
    //    "sei una sfigata",
    //    "sei una testa di cazzo",
    //    "sei uno stronzo",
    //    "sembri un peni",
    //    "sfacim e merde",
    //    "sfiga",
    //    "sfigati",
    //    "sfigato",
    //    "signorebastardo",
    //    "slinguare",
    //    "slinguata",
    //    "smandrappata",
    //    "smerdare",
    //    "soccia",
    //    "socmel",
    //    "sorca",
    //    "spagnola",
    //    "spompinare",
    //    "spompinata",
    //    "spompinato",
    //    "spompiniamolo",
    //    "sputtanare",
    //    "sta puttana",
    //    "sti cazza",
    //    "sticchio",
    //    "stronza",
    //    "stronzata",
    //    "stronzate",
    //    "stronzetta",
    //    "stronzette",
    //    "stronzetti",
    //    "stronzetto",
    //    "stronzi",
    //    "stronzina",
    //    "stronzine",
    //    "stronzini",
    //    "stronzino",
    //    "stronzino/a",
    //    "stronzo",
    //    "stronzo/a",
    //    "stronzoli",
    //    "stronzolo",
    //    "stronzomalcagato",
    //    "stronzona",
    //    "stronzone",
    //    "stronzoni",
    //    "strunzo",
    //    "suca!",
    //    "succhiacazzi",
    //    "succhiamelo",
    //    "succhiami",
    //    "succhiaminchia",
    //    "succhiapalle",
    //    "succhione",
    //    "sveltina",
    //    "sverginare",
    //    "tarzanelli",
    //    "tarzanello",
    //    "tenere qualcuno per le palle",
    //    "terrone",
    //    "testa di cazzo",
    //    "testa di cazzo.",
    //    "testa di minchia",
    //    "tetta",
    //    "tette",
    //    "tettina",
    //    "tettine",
    //    "tettona",
    //    "tettone",
    //    "thinspiration",
    //    "thinspo",
    //    "ti ammazzo",
    //    "ti corro in culo",
    //    "ti sei bevuto",
    //    "tirare",
    //    "topa",
    //    "troia",
    //    "troiacce",
    //    "troiaccia",
    //    "troiamadonna",
    //    "troie",
    //    "troietta",
    //    "troiette",
    //    "troio",
    //    "troiona",
    //    "troioncella",
    //    "troioncelle",
    //    "troione",
    //    "trombare",
    //    "trombata",
    //    "trombatona",
    //    "tu ma’ piscia in piedi",
    //    "tu piezza di merda",
    //    "tua mamma bocchinara",
    //    "uccello",
    //    "un pompino",
    //    "va’ a cacare",
    //    "va’ a farti fottere",
    //    "vacca",
    //    "vaccamadonna",
    //    "vada a bordo",
    //    "vaffanculo",
    //    "vaffanculo a chi t'è morto",
    //    "vaffonculo",
    //    "vai a cacare",
    //    "vai a cagare",
    //    "vai a farti fottere",
    //    "vai a farti fottere, puttana",
    //    "vai a quel paese",
    //    "Vai a vendere il culo",
    //    "vai all’inferno",
    //    "vangare",
    //    "vattela a pigliare in culo",
    //    "venire",
    //    "zinne",
    //    "zio cantante",
    //    "zoccola",
    //    "zoccole",
    //    "zuia",
    //];
}

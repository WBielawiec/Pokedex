using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Pokedex
{
    public class PokemonList
    {
        public static string[] listaPokemonow = new [] {
            "Bulbasaur",
            "Ivysaur",
            "Venusaur",
            "Charmander",
            "Charmeleon",
            "Charizard",
            "Squirtle",
            "Wartortle",
            "Blastoise",
            "Caterpie",
            "Metapod",
            "Butterfree",
            "Weedle",
            "Kakuna",
            "Beedrill",
            "Pidgey",
            "Pidgeotto",
            "Pidgeot",
            "Rattata",
            "Raticate",
            "Spearow",
            "Fearow",
            "Ekans",
            "Arbok",
            "Pikachu",
            "Raichu",
            "Sandshrew",
            "Sandslash",
            "Nidoran",
            "Nidorina  ",
            "Nidoqueen ",
            "Nidoran‚",
            "Nidorino",
            "Nidoking",
            "Clefairy",
            "Clefable",
            "Vulpix",
            "Ninetales",
            "Jigglypuff",
            "Wigglytuff",
            "Zubat",
            "Golbat",
            "Oddish",
            "Gloom",
            "Vileplume",
            "Paras",
            "Parasect",
            "Venonat",
            "Venomoth",
            "Diglett",
            "Dugtrio",
            "Meowth",
            "Persian",
            "Psyduck",
            "Golduck",
            "Mankey",
            "Primeape",
            "Growlithe",
            "Arcanine",
            "Poliwag",
            "Poliwhirl",
            "Poliwrath",
            "Abra",
            "Kadabra",
            "Alakazam",
            "Machop",
            "Machoke",
            "Machamp",
            "Bellsprout",
            "Weepinbell",
            "Victreebel",
            "Tentacool",
            "Tentacruel",
            "Geodude",
            "Graveler",
            "Golem",
            "Ponyta",
            "Rapidash",
            "Slowpoke",
            "Slowbro",
            "Magnemite",
            "Magneton",
            "Farfetch'd",
            "Doduo",
            "Dodrio",
            "Seel",
            "Dewgong",
            "Grimer",
            "Muk",
            "Shellder",
            "Cloyster",
            "Gastly",
            "Haunter",
            "Gengar",
            "Onix",
            "Drowzee",
            "Hypno",
            "Krabby",
            "Kingler",
            "Voltorb",
            "Electrode",
            "Exeggcute",
            "Exeggutor",
            "Cubone",
            "Marowak",
            "Hitmonlee",
            "Hitmonchan",
            "Lickitung",
            "Koffing",
            "Weezing",
            "Rhyhorn",
            "Rhydon",
            "Chansey",
            "Tangela",
            "Kangaskhan",
            "Horsea",
            "Seadra",
            "Goldeen",
            "Seaking",
            "Staryu",
            "Starmie",
            "Mr.Mime",
            "Scyther",
            "Jynx",
            "Electabuzz",
            "Magmar",
            "Pinsir",
            "Tauros",
            "Magikarp",
            "Gyarados",
            "Lapras",
            "Ditto",
            "Eevee",
            "Vaporeon",
            "Jolteon",
            "Flareon",
            "Porygon",
            "Omanyte",
            "Omastar",
            "Kabuto",
            "Kabutops",
            "Aerodactyl",
            "Snorlax",
            "Articuno",
            "Zapdos",
            "Moltres",
            "Dratini",
            "Dragonair",
            "Dragonite",
            "Mewtwo",
            "Mew",
        };


        public static void showPokemon(int pokenumber, int x, int y)
        {
            if (pokenumber == 1)
            {
                Console.SetCursorPosition(x, y); Console.Write("                                           /\n");
                Console.SetCursorPosition(x, y + 1); Console.Write("                        _,.------....___,.' ',.-.\n");
                Console.SetCursorPosition(x, y + 2); Console.Write("                     ,-'          _,.--\"        |\n");
                Console.SetCursorPosition(x, y + 3); Console.Write("                   ,'         _.-'              .\n");
                Console.SetCursorPosition(x, y + 4); Console.Write("                  /   ,     ,'                   `\n");
                Console.SetCursorPosition(x, y + 5); Console.Write("                 .   /     /                     ``.\n");
                Console.SetCursorPosition(x, y + 6); Console.Write("                 |  |     .                       \\.\\\n");
                Console.SetCursorPosition(x, y + 7); Console.Write("       ____      |___._.  |       __               \\ `.\n");
                Console.SetCursorPosition(x, y + 8); Console.Write("     .'    `---\"\"       ``\"-.--\"'`  \\               .  \\\n");
                Console.SetCursorPosition(x, y + 9); Console.Write("    .  ,            __               `              |   .\n");
                Console.SetCursorPosition(x, y + 10); Console.Write("    `,'         ,-\"'  .               \\             |    L\n");
                Console.SetCursorPosition(x, y + 11); Console.Write("   ,'          '    _.'                -._          /    |\n");
                Console.SetCursorPosition(x, y + 12); Console.Write("  ,`-.    ,\".   `--'                      >.      ,'     |\n");
                Console.SetCursorPosition(x, y + 13); Console.Write(" . .'\\'   `-'       __    ,  ,-.         /  `.__.-      ,'\n");
                Console.SetCursorPosition(x, y + 14); Console.Write(" ||){, .           ,'  ;  /  / \\ `        `.    .      .'/\n");
                Console.SetCursorPosition(x, y + 15); Console.Write(" j|){D  \\          `--'  ' ,'_  . .         `.__, \\   , /\n");
                Console.SetCursorPosition(x, y + 16); Console.Write("/ L){_  |                 .  \"' ){_;                `.'.'\n");
                Console.SetCursorPosition(x, y + 17); Console.Write(".    \"\"'                  \"\"\"\"\"'                    V\n");
                Console.SetCursorPosition(x, y + 18); Console.Write(" `.                                 .    `.   _,..  `\n");
                Console.SetCursorPosition(x, y + 19); Console.Write("   `,_   .    .                _,-'/    .. `,'   __  `\n");
                Console.SetCursorPosition(x, y + 20); Console.Write("    ) \\`._        ___....----\"'  ,'   .'  \\ |   '  \\  .\n");
                Console.SetCursorPosition(x, y + 21); Console.Write("   /   `. \"`-.--\"'         _,' ,'     `---' |    `./  |\n");
                Console.SetCursorPosition(x, y + 22); Console.Write("  .   _  `\"\"'--.._____..--\"   ,             '         |\n");
                Console.SetCursorPosition(x, y + 23); Console.Write("  | .\" `. `-.                /-.           /          ,\n");
                Console.SetCursorPosition(x, y + 24); Console.Write("  | `._.'    `,_            ;  /         ,'          .\n");
                Console.SetCursorPosition(x, y + 25); Console.Write(" .'          /| `-.        . ,'         ,           ,\n");
                Console.SetCursorPosition(x, y + 26); Console.Write(" '-.__ __ _,','    '`-..___;-...__   ,.'\\ ____.___.'\n");
                Console.SetCursorPosition(x, y + 27); Console.Write(" `\"^--'..'   '-`-^-'\"--    `-^-'`.''\"\"\"\"\"`.,^.`.--' \n");
                Console.SetCursorPosition(x, y + 28); Console.Write("\n");
            }

            else if (pokenumber == 2)
            {
                Console.SetCursorPosition(x, y); Console.Write("                               ,'\"`.,./.\n");
                Console.SetCursorPosition(x, y + 1); Console.Write("                             ,'        Y',\"..\n");
                Console.SetCursorPosition(x, y + 2); Console.Write("                           ,'           \\  | \\\n");
                Console.SetCursorPosition(x, y + 3); Console.Write("                          /              . |  `\n");
                Console.SetCursorPosition(x, y + 4); Console.Write("                         /               | |   \\\n");
                Console.SetCursorPosition(x, y + 5); Console.Write("            __          .                | |    .\n");
                Console.SetCursorPosition(x, y + 6); Console.Write("       _   \\  `. ---.   |                | j    |\n");
                Console.SetCursorPosition(x, y + 7); Console.Write("      / `-._\\   `Y   \\  |                |.     |\n");
                Console.SetCursorPosition(x, y + 8); Console.Write("     _`.    ``    \\   \\ |..              '      |,-'\"\"7,....\n");
                Console.SetCursorPosition(x, y + 9); Console.Write("     l     '-.     . , `|  | , |`. , ,  /,     ,'    '/   ,'_,.-.\n");
                Console.SetCursorPosition(x, y + 10); Console.Write("     `-..     `-.  ){ ){     |/ `   ' \"\\,' | _  /          '-'    /___\n");
                Console.SetCursorPosition(x, y + 11); Console.Write("      \\\"\"' __.,.-`.){ ){        /   /._    l'.,'\n");
                Console.SetCursorPosition(x, y + 12); Console.Write("       `--,   _.-' `\".           /__ `'-.' '         .\n");
                Console.SetCursorPosition(x, y + 13); Console.Write("       ,---..._,.--\"\"\"\"\"\"\"--.__..----,-.'   .  /    .'   ,.--\n");
                Console.SetCursorPosition(x, y + 14); Console.Write("       |                          ,'){| /    | /     ;.,-'--      ,.-\n");
                Console.SetCursorPosition(x, y + 15); Console.Write("       |     .---.              .'  ){|'     |/ ,.-='\"-.`\"`' _   -.'\n");
                Console.SetCursorPosition(x, y + 16); Console.Write("       /    \\    /               `. ){|--.  _L,\"---.._        \"----'\n");
                Console.SetCursorPosition(x, y + 17); Console.Write("     ,' `.   \\ ,'           _,     `''   ``.-'       `-  -..___,'\n");
                Console.SetCursorPosition(x, y + 18); Console.Write("    . ,.  .   `   __     .-'  _.-           `.     .__    \\\n");
                Console.SetCursorPosition(x, y + 19); Console.Write("    |. |`        \"  ;   !   ,.  |             `.    `.`'---'\n");
                Console.SetCursorPosition(x, y + 20); Console.Write("    ,| |C\\       ` /    | ,' |(]|            -. |-..--`\n");
                Console.SetCursorPosition(x, y + 21); Console.Write("   /  \"'--'       '      /___|__]        `.  `- |`.\n");
                Console.SetCursorPosition(x, y + 22); Console.Write("  .       ,'                   ,   /       .    `. \\\n");
                Console.SetCursorPosition(x, y + 23); Console.Write("    \\                      .,-'  ,'         .     `-.\n");
                Console.SetCursorPosition(x, y + 24); Console.Write("     x---..`.  -'  __..--'\"/\"\"\"\"\"  ,-.      |   |   |\n");
                Console.SetCursorPosition(x, y + 25); Console.Write("    / \\--._'-.,.--'     _`-    _. ' /       |     -.|\n");
                Console.SetCursorPosition(x, y + 26); Console.Write("   ,   .   `-..__ ...--'  _,.-' | `   ,.-.  ;   /  '|\n");
                Console.SetCursorPosition(x, y + 27); Console.Write("  .  _,'         '\"-----\"\"      |    `   | /  ,'    ;\n");
                Console.SetCursorPosition(x, y + 28); Console.Write("  |-'  .-.    `._               |     `._// ,'     /\n");
                Console.SetCursorPosition(x, y + 29); Console.Write(" _|    `-'   _,' \"`--.._________|        `,'    _ /.\n");
                Console.SetCursorPosition(x, y + 30); Console.Write("  |-'  .-.    `._               |     `._// ,'     /\n");
                Console.SetCursorPosition(x, y + 31); Console.Write("//\\   ,-._.'\"/\\__,.   _,\"     /_\\__/`. /'.-.'.-/_,`-' \n");
                Console.SetCursorPosition(x, y + 32); Console.Write("  |-'  .-.    `._               |     `._// ,'     /\n");
                Console.SetCursorPosition(x, y + 33); Console.Write("`-\"`\"' v'    `\"  `-`-\"              `-'`-`  `'\n");
            }

            else if (pokenumber == 3)
            {
                Console.SetCursorPosition(x, y); Console.Write("                           _._       _,._\n");
                Console.SetCursorPosition(x, y + 1); Console.Write("                        _.'   `. ' .'   _`.\n");
                Console.SetCursorPosition(x, y + 2); Console.Write("                ,\"\"\"/`\"\"-.-.,/. ` V'\\-,`.,--/\"\"\".\"-..\n");
                Console.SetCursorPosition(x, y + 3); Console.Write("              ,'    `...,' . ,\\-----._|     `.   /   \\\n");
                Console.SetCursorPosition(x, y + 4); Console.Write("             `.            .`  -'`\"\" .._   ){> `-'   `.\n");
                Console.SetCursorPosition(x, y + 5); Console.Write("            ,'  ,-.  _,.-'| `..___ ,'   |'-..__   .._ L\n");
                Console.SetCursorPosition(x, y + 6); Console.Write("           .    \\_ -'   `-'     ..      `.-' `.`-.'_ .|\n");
                Console.SetCursorPosition(x, y + 7); Console.Write("           |   ,',-,--..  ,--../  `.  .-.    , `-.  ``.\n");
                Console.SetCursorPosition(x, y + 8); Console.Write("           `.,' ,  |   |  `.  /'/,,.\\/  |    \\|   |\n");
                Console.SetCursorPosition(x, y + 9); Console.Write("                `  `---'    `j   .   \\  .     '   j\n");
                Console.SetCursorPosition(x, y + 10); Console.Write("              ,__`\"        ,'|`'\\_/`.'\\'        |\\-'-, _,.\n");
                Console.SetCursorPosition(x, y + 11); Console.Write("       .--...`-. `-`. /    '- ..      _,    /\\ ,' .--\"'  ,'\".\n");
                Console.SetCursorPosition(x, y + 12); Console.Write("     _'-\"\"-    --  _`'-.../ __ '.'`-^,_`-\"\"\"\"---....__  ' _,-`\n");
                Console.SetCursorPosition(x, y + 13); Console.Write("   _.----`  _..--.'        |  \"`-..-\" __|'\"'         .\"\"-. \"\"'--.._\n");
                Console.SetCursorPosition(x, y + 14); Console.Write("  /        '    /     ,  _.+-.'  ||._'   \"\"\"\". .          `     .__\\\n");
                Console.SetCursorPosition(x, y + 15); Console.Write(" `---    /        /  / j'       _/|..`  -. `-`\\ \\   \\  \\   `.  \\ `-..\n");
                Console.SetCursorPosition(x, y + 16); Console.Write(",\" _.-' /    /` ./  /`_|_,-\"   ','|       `. | -'`._,   L  \\ .  `.   |\n");
                Console.SetCursorPosition(x, y + 17); Console.Write("`\"' /  /  / ,__...-----| _.,  ,'            `|----.._`-.|' |. .` ..  .\n");
                Console.SetCursorPosition(x, y + 18); Console.Write("   /  '| /.,/   \\--.._ `-,' ,          .  '`.'  __,., '  ''``._ \\ \\`,'\n");
                Console.SetCursorPosition(x, y + 19); Console.Write("  /_,'---  ,     \\`._,-` \\ //  / . \\    `._,  -`,  / / _   |   `-L -\n");
                Console.SetCursorPosition(x, y + 20); Console.Write("   /       `.     ,  ..._ ' `_/ '| |\\ `._'       '-.'   `.,'     |\n");
                Console.SetCursorPosition(x, y + 21); Console.Write("  '         /    /  ..   `.  `./ | ; `.'    ,\"\" ,.  `.    \\      |\n");
                Console.SetCursorPosition(x, y + 22); Console.Write("   `.     ,'   ,'   | |\\  |       \"        |  ,'\\ |   \\    `    ,L\n");
                Console.SetCursorPosition(x, y + 23); Console.Write("   /|`.  /    '     | `-| '                  /`-' |    L    `._/  \\\n");
                Console.SetCursorPosition(x, y + 24); Console.Write("  / | .`|    |  .   `._.'                   `.__,'   .  |     |  (`\n");
                Console.SetCursorPosition(x, y + 25); Console.Write(" '-\"\"-'_|    `. `.__,._____     .    _,        ____ ,-  j     \".-'\"'\n");
                Console.SetCursorPosition(x, y + 26); Console.Write("        \\      `-.  \\/.    `\"--.._    _,.---'\"\"\\/  \"_,.'     /-'\n");
                Console.SetCursorPosition(x, y + 27); Console.Write("         )        `-._ '-.        `--\"      _.-'.-\"\"        `.\n");
                Console.SetCursorPosition(x, y + 28); Console.Write("        ./            `,. `\".._________...\"\"_.-\"`.          _j\n");
                Console.SetCursorPosition(x, y + 29); Console.Write("       /_\\.__,\"\".   ,.'  \"`-...________.---\"     .\".   ,.  / \\\n");
                Console.SetCursorPosition(x, y + 30); Console.Write("              \\_/\"\"\"-'                           `-'--(_,`\"`-` \n");
            }

            else if (pokenumber == 4)
            {
                Console.SetCursorPosition(x, y); Console.Write("              _.--\"\"`-..\n");
                Console.SetCursorPosition(x, y + 1); Console.Write("            ,'          `.\n");
                Console.SetCursorPosition(x, y + 2); Console.Write("          ,'          __  `.\n");
                Console.SetCursorPosition(x, y + 3); Console.Write("         /|          \" __   \\\n");
                Console.SetCursorPosition(x, y + 4); Console.Write("        , |           / |.   .\n");
                Console.SetCursorPosition(x, y + 5); Console.Write("        |,'          !_.'|   |\n");
                Console.SetCursorPosition(x, y + 6); Console.Write("      ,'             '   |   |\n");
                Console.SetCursorPosition(x, y + 7); Console.Write("     /              |`--'|   |\n");
                Console.SetCursorPosition(x, y + 8); Console.Write("    |                `---'   |\n");
                Console.SetCursorPosition(x, y + 9); Console.Write("     .   ,                   |                       ,\".\n");
                Console.SetCursorPosition(x, y + 10); Console.Write("      ._     '           _'  |                    , ' \\ `\n");
                Console.SetCursorPosition(x, y + 11); Console.Write("  `.. `.`-...___,...---\"\"    |       __,.        ,`\"   L,|\n");
                Console.SetCursorPosition(x, y + 12); Console.Write("  |, `- .`._        _,-,.'   .  __.-'-. /        .   ,    \\\n");
                Console.SetCursorPosition(x, y + 13); Console.Write("-){..     `. `-..--_.,.<       `\"      / `.        `-/ |   .\n");
                Console.SetCursorPosition(x, y + 14); Console.Write("  `,         \"\"\"\"'     `.              ,'         |   |  ',,\n");
                Console.SetCursorPosition(x, y + 15); Console.Write("    `.      '            '            /          '    |'. |/\n");
                Console.SetCursorPosition(x, y + 16); Console.Write("      `.   |              \\       _,-'           |       ''\n");
                Console.SetCursorPosition(x, y + 17); Console.Write("        `._'               \\   '\"\\                .      |\n");
                Console.SetCursorPosition(x, y + 18); Console.Write("           |                '     \\                `._  ,'\n");
                Console.SetCursorPosition(x, y + 19); Console.Write("           |                 '     \\                 .'|\n");
                Console.SetCursorPosition(x, y + 20); Console.Write("           |                 .      \\                | |\n");
                Console.SetCursorPosition(x, y + 21); Console.Write("           |                 |       L              ,' |\n");
                Console.SetCursorPosition(x, y + 22); Console.Write("           `                 |       |             /   '\n");
                Console.SetCursorPosition(x, y + 23); Console.Write("            \\                |       |           ,'   /\n");
                Console.SetCursorPosition(x, y + 24); Console.Write("          ,' \\               |  _.._ ,-..___,..-'    ,'\n");
                Console.SetCursorPosition(x, y + 25); Console.Write("         /     .             .      `!             ,j'\n");
                Console.SetCursorPosition(x, y + 26); Console.Write("        /       `.          /        .           .'/\n");
                Console.SetCursorPosition(x, y + 27); Console.Write("       .          `.       /         |        _.'.'\n");
                Console.SetCursorPosition(x, y + 28); Console.Write("        `.          7`'---'          |------\"'_.'\n");
                Console.SetCursorPosition(x, y + 29); Console.Write("       _,.`,_     _'                ,''-----\"'\n");
                Console.SetCursorPosition(x, y + 30); Console.Write("   _,-_    '       `.     .'      ,\\\n");
                Console.SetCursorPosition(x, y + 31); Console.Write("   -\" /`.         _,'     | _  _  _.|\n");
                Console.SetCursorPosition(x, y + 32); Console.Write("    \"\"--'---\"\"\"\"\"'        `' '! |! /\n");
                Console.SetCursorPosition(x, y + 33); Console.Write("                            `\" \" -' \n");
            }


            else if (pokenumber == 5)
            {
                Console.SetCursorPosition(x, y); Console.Write("                      ,-'`\\\n");
                Console.SetCursorPosition(x, y + 1); Console.Write("                  _,\"'    j\n");
                Console.SetCursorPosition(x, y + 2); Console.Write("           __....+       /               .\n");
                Console.SetCursorPosition(x, y + 3); Console.Write("       ,-'\"             /               ; `-._.'.\n");
                Console.SetCursorPosition(x, y + 4); Console.Write("      /                (              ,'       .'\n");
                Console.SetCursorPosition(x, y + 5); Console.Write("     |            _.    \\             \\   ---._ `-.\n");
                Console.SetCursorPosition(x, y + 6); Console.Write("     ,|    ,   _.'  Y    \\             `- ,'   \\   `.`.\n");
                Console.SetCursorPosition(x, y + 7); Console.Write("     l'    \\ ,'._,\\ `.    .              /       ,--. l\n");
                Console.SetCursorPosition(x, y + 8); Console.Write("  .,-        `._  |  |    |              \\       _   l .\n");
                Console.SetCursorPosition(x, y + 9); Console.Write(" /              `\"--'    /              .'       ``. |  )\n");
                Console.SetCursorPosition(x, y + 10); Console.Write(".\\    ,                 |                .        \\ `. '\n");
                Console.SetCursorPosition(x, y + 11); Console.Write("`.                .     |                '._  __   ;. \\'\n");
                Console.SetCursorPosition(x, y + 12); Console.Write("  `-..--------...'       \\                  `'  `-\"'.  \\\n");
                Console.SetCursorPosition(x, y + 13); Console.Write("      `......___          `._                        |  \\\n");
                Console.SetCursorPosition(x, y + 14); Console.Write("               /`            `..                     |   .\n");
                Console.SetCursorPosition(x, y + 15); Console.Write("              /|                `-.                  |    L\n");
                Console.SetCursorPosition(x, y + 16); Console.Write("             / |               \\   `._               .    |\n");
                Console.SetCursorPosition(x, y + 17); Console.Write("           ,'  |,-\"-.   .       .     `.            /     |\n");
                Console.SetCursorPosition(x, y + 18); Console.Write("         ,'    |     '   \\      |       `.         /      |\n");
                Console.SetCursorPosition(x, y + 19); Console.Write("       ,'     /|       \\  .     |         .       /       |\n");
                Console.SetCursorPosition(x, y + 20); Console.Write("     ,'      / |        \\  .    +          \\    ,'       .'\n");
                Console.SetCursorPosition(x, y + 21); Console.Write("    .       .  |         \\ |     \\          \\_,'        / j\n");
                Console.SetCursorPosition(x, y + 22); Console.Write("    |       |  L          `|      .          `        ,' '\n");
                Console.SetCursorPosition(x, y + 23); Console.Write("    |    _. |   \\          /      |           .     .' ,'\n");
                Console.SetCursorPosition(x, y + 24); Console.Write("    |   /  `|    \\        .       |  /        |   ,' .'\n");
                Console.SetCursorPosition(x, y + 25); Console.Write("    |   ,-..\\     -.     ,        | /         |,.' ,'\n");
                Console.SetCursorPosition(x, y + 26); Console.Write("    `. |___,`    /  `.   /`.       '          |  .'\n");
                Console.SetCursorPosition(x, y + 27); Console.Write("      '-`-'     j     ` /.\"7-..../|          ,`-'\n");
                Console.SetCursorPosition(x, y + 28); Console.Write("                |        .'  / _/_|          .\n");
                Console.SetCursorPosition(x, y + 29); Console.Write("                `,       `\"'/\"'    \\          `.\n");
                Console.SetCursorPosition(x, y + 30); Console.Write("                  `,       '.       `.         |\n");
                Console.SetCursorPosition(x, y + 31); Console.Write("             __,.-'         `.        \\'       |\n");
                Console.SetCursorPosition(x, y + 32); Console.Write("            /_,-'\\          ,'        |        _.\n");
                Console.SetCursorPosition(x, y + 33); Console.Write("             |___.---.   ,-'        .-'){,-\"`\\,' .\n");
                Console.SetCursorPosition(x, y + 34); Console.Write("                  L,.--\"'           '-' |  ,' `-.\\\n");
                Console.SetCursorPosition(x, y + 35); Console.Write("                                        `.' \n");
            }

            else if (pokenumber == 6)
            {
                Console.SetCursorPosition(x, y); Console.Write("                 .\"-,.__\n");
                Console.SetCursorPosition(x, y + 1); Console.Write("                 `.     `.  ,\n");
                Console.SetCursorPosition(x, y + 2); Console.Write("              .--'  .._,'\"-' `.\n");
                Console.SetCursorPosition(x, y + 3); Console.Write("             .    .'         `'\n");
                Console.SetCursorPosition(x, y + 4); Console.Write("             `.   /          ,'\n");
                Console.SetCursorPosition(x, y + 5); Console.Write("               `  '--.   ,-\"'\n");
                Console.SetCursorPosition(x, y + 6); Console.Write("                `\"`   |  \\\n");
                Console.SetCursorPosition(x, y + 7); Console.Write("                   -. \\, |\n");
                Console.SetCursorPosition(x, y + 8); Console.Write("                    `--Y.'      ___.\n");
                Console.SetCursorPosition(x, y + 9); Console.Write("                         \\     L._, \\\n");
                Console.SetCursorPosition(x, y + 10); Console.Write("               _.,        `.   <  <\\                _\n");
                Console.SetCursorPosition(x, y + 11); Console.Write("             ,' '           `, `.   | \\            ( `\n");
                Console.SetCursorPosition(x, y + 12); Console.Write("          ../, `.            `  |    .\\`.           \\ \\_\n");
                Console.SetCursorPosition(x, y + 13); Console.Write("         ,' ,..  .           _.,'    ||\\l            )  '\".\n");
                Console.SetCursorPosition(x, y + 14); Console.Write("        , ,'   \\           ,'.-.`-._,'  |           .  _._`.\n");
                Console.SetCursorPosition(x, y + 15); Console.Write("      ,' /      \\ \\        `' ' `--/   | \\          / /   ..\\\n");
                Console.SetCursorPosition(x, y + 16); Console.Write("    .'  /        \\ .         |\\__ - _ ,'` `        / /     `.`.\n");
                Console.SetCursorPosition(x, y + 17); Console.Write("    |  '          ..         `-...-\"  |  `-'      / /        . `.\n");
                Console.SetCursorPosition(x, y + 18); Console.Write("    | /           |L__           |    |          / /          `. `.\n");
                Console.SetCursorPosition(x, y + 19); Console.Write("   , /            .   .          |    |         / /             ` `\n");
                Console.SetCursorPosition(x, y + 20); Console.Write("  / /          ,. ,`._ `-_       |    |  _   ,-' /               ` \\\n");
                Console.SetCursorPosition(x, y + 21); Console.Write(" / .           \\\"`_/. `-_ \\_,.  ,'    +-' `-'  _,        ..,-.    \\`.\n");
                Console.SetCursorPosition(x, y + 22); Console.Write(".  '         .-f    ,'   `    '.       \\__.---'     _   .'   '     \\ \\\n");
                Console.SetCursorPosition(x, y + 23); Console.Write("' /          `.'    l     .' /          \\..      ,_|/   `.  ,'`     L`\n");
                Console.SetCursorPosition(x, y + 24); Console.Write("|'      _.-\"\"` `.    \\ _,'  `            \\ `.___`.'\"`-.  , |   |    | \\\n");
                Console.SetCursorPosition(x, y + 25); Console.Write("||    ,'      `. `.   '       _,...._        `  |    `/ '  |   '     .|\n");
                Console.SetCursorPosition(x, y + 26); Console.Write("||  ,'          `. ;.,.---' ,'       `.   `.. `-'  .-' /_ .'    ;_   ||\n");
                Console.SetCursorPosition(x, y + 27); Console.Write("|| '              V      / /           `   | `   ,'   ,' '.    !  `. ||\n");
                Console.SetCursorPosition(x, y + 28); Console.Write("||/            _,-------7 '              . |  `-'    l         /    `||\n");
                Console.SetCursorPosition(x, y + 29); Console.Write(". |          ,' .-   ,' ||               | .-.        `.      .'     ||\n");
                Console.SetCursorPosition(x, y + 30); Console.Write(" `'        ,'    `\".'    |               |    `.        '. -.'       `'\n");
                Console.SetCursorPosition(x, y + 31); Console.Write("          /      ,'      |               |,'    \\-.._,.'/'\n");
                Console.SetCursorPosition(x, y + 32); Console.Write("          .     /        .               .       \\    .''\n");
                Console.SetCursorPosition(x, y + 33); Console.Write("        .`.    |         `.             /         ){_,'.'\n");
                Console.SetCursorPosition(x, y + 34); Console.Write("          \\ `...\\   _     ,'-.        .'         /_.-'\n");
                Console.SetCursorPosition(x, y + 35); Console.Write("           `-.__ `,  `'   .  _.>----''.  _  __  /\n");
                Console.SetCursorPosition(x, y + 36); Console.Write("                .'        /\"'          |  \"'   '_\n");
                Console.SetCursorPosition(x, y + 37); Console.Write("               /_|.-'\\ ,\".             '.'`__'-( \\\n");
                Console.SetCursorPosition(x, y + 38); Console.Write("                 / ,\"'\"\\,'               `/  `-.|\" \n");
            }

            else if (pokenumber == 7)
            {
                Console.SetCursorPosition(x, y); Console.Write("               _,........__\n");
                Console.SetCursorPosition(x, y + 1); Console.Write("            ,-'            \"`-.\n");
                Console.SetCursorPosition(x, y + 2); Console.Write("          ,'                   `-.\n");
                Console.SetCursorPosition(x, y + 3); Console.Write("        ,'                        \\\n");
                Console.SetCursorPosition(x, y + 4); Console.Write("      ,'                           .\n");
                Console.SetCursorPosition(x, y + 5); Console.Write("      .'\\               ,\"\".       `\n");
                Console.SetCursorPosition(x, y + 6); Console.Write("     ._.'|             / |  `       \\\n");
                Console.SetCursorPosition(x, y + 7); Console.Write("     |   |            `-.'  ||       `.\n");
                Console.SetCursorPosition(x, y + 8); Console.Write("     |   |            '-._,'||       | \\\n");
                Console.SetCursorPosition(x, y + 9); Console.Write("     .`.,'             `..,'.'       , |`-.\n");
                Console.SetCursorPosition(x, y + 10); Console.Write("     l                       .'`.  _/  |   `.\n");
                Console.SetCursorPosition(x, y + 11); Console.Write("     `-.._'-   ,          _ _'   -\" \\  .     `\n");
                Console.SetCursorPosition(x, y + 12); Console.Write("`.\"\"\"\"\"'-.`-...,---------','         `. `....__.\n");
                Console.SetCursorPosition(x, y + 13); Console.Write(".'        `\"-..___      __,'\\          \\  \\     \\\n");
                Console.SetCursorPosition(x, y + 14); Console.Write("\\_ .          |   `\"\"\"\"'    `.           . \\     \\\n");
                Console.SetCursorPosition(x, y + 15); Console.Write("  `.          |              `.          |  .     L\n");
                Console.SetCursorPosition(x, y + 16); Console.Write("    `.        |`--...________.'.        j   |     |\n");
                Console.SetCursorPosition(x, y + 17); Console.Write("      `._    .'      |          `.     .|   ,     |\n");
                Console.SetCursorPosition(x, y + 18); Console.Write("         `--,\\       .            `7\"\"' |  ,      |\n");
                Console.SetCursorPosition(x, y + 19); Console.Write("            ` `      `            /     |  |      |    _,-'\"\"\"`-.\n");
                Console.SetCursorPosition(x, y + 20); Console.Write("             \\ `.     .          /      |  '      |  ,'          `.\n");
                Console.SetCursorPosition(x, y + 21); Console.Write("              \\  v.__  .        '       .   \\    /| /              \\\n");
                Console.SetCursorPosition(x, y + 22); Console.Write("               \\/    `\"\"\\\"\"\"\"\"\"\"`.       \\   \\  /.''                |\n");
                Console.SetCursorPosition(x, y + 23); Console.Write("                `        .        `._ ___,j.  `/ .-       ,---.     |\n");
                Console.SetCursorPosition(x, y + 24); Console.Write("                ,`-.      \\         .\"     `.  |/        j     `    |\n");
                Console.SetCursorPosition(x, y + 25); Console.Write("               /    `.     \\       /         \\ /         |     /    j\n");
                Console.SetCursorPosition(x, y + 26); Console.Write("              |       `-.   7-.._ .          |\"          '         /\n");
                Console.SetCursorPosition(x, y + 27); Console.Write("              |          `./_    `|          |            .     _,'\n");
                Console.SetCursorPosition(x, y + 28); Console.Write("              `.           / `----|          |-............`---'\n");
                Console.SetCursorPosition(x, y + 29); Console.Write("                \\          \\      |          |\n");
                Console.SetCursorPosition(x, y + 30); Console.Write("               ,'           )     `.         |\n");
                Console.SetCursorPosition(x, y + 31); Console.Write("                7____,,..--'      /          |\n");
                Console.SetCursorPosition(x, y + 32); Console.Write("                                  `---.__,--.'\n");
            }

            else if (pokenumber == 8)
            {
                Console.SetCursorPosition(x, y); Console.Write("     __                                _.--'\"7\n");
                Console.SetCursorPosition(x, y + 1); Console.Write("    `. `--._                        ,-'_,-  ,'\n");
                Console.SetCursorPosition(x, y + 2); Console.Write("     ,'  `-.`-.                   /' .'    ,|\n");
                Console.SetCursorPosition(x, y + 3); Console.Write("     `.     `. `-     __...___   /  /     - j\n");
                Console.SetCursorPosition(x, y + 4); Console.Write("       `.     `  `.-\"\"        \" .  /       /\n");
                Console.SetCursorPosition(x, y + 5); Console.Write("         \\     /                ` /       /\n");
                Console.SetCursorPosition(x, y + 6); Console.Write("          \\   /                         ,'\n");
                Console.SetCursorPosition(x, y + 7); Console.Write("          '._'_               ,-'       |\n");
                Console.SetCursorPosition(x, y + 8); Console.Write("             | \\            ,|  |   ...-'\n");
                Console.SetCursorPosition(x, y + 9); Console.Write("             || `         ,|_|  |   | `             _..__\n");
                Console.SetCursorPosition(x, y + 10); Console.Write("            /|| |          | |  |   |  \\  _,_    .-\"     `-.\n");
                Console.SetCursorPosition(x, y + 11); Console.Write("           | '.-'          |_|_,' __!  | /|  |  /           \\\n");
                Console.SetCursorPosition(x, y + 12); Console.Write("   ,-...___ .=                  ._..'  /`.| ,`,.      _,.._ |\n");
                Console.SetCursorPosition(x, y + 13); Console.Write("  |   |,.. \\     '  `'        ____,  ,' `--','  |    /      |\n");
                Console.SetCursorPosition(x, y + 14); Console.Write(" ,`-..'  _)  .`-..___,---'_...._/  .'      '-...'   |      /\n");
                Console.SetCursorPosition(x, y + 15); Console.Write("'.__' \"\"'      `.,------'\"'      ,/            ,     `.._.' `.\n");
                Console.SetCursorPosition(x, y + 16); Console.Write("  `.             | `--........,-'.            .         \\     \\\n");
                Console.SetCursorPosition(x, y + 17); Console.Write("    `-.          .   '.,--\"\"     |           ,'\\        |      .\n");
                Console.SetCursorPosition(x, y + 18); Console.Write("       `.       /     |          L          ,\\  .       |  .,---.\n");
                Console.SetCursorPosition(x, y + 19); Console.Write("         `._   '      |           \\        /  .  L      | /   __ `.\n");
                Console.SetCursorPosition(x, y + 20); Console.Write("            `-.       |            `._   ,    l   .    j |   '  `. .\n");
                Console.SetCursorPosition(x, y + 21); Console.Write("              |       |               `\"' |  .    |   /  '      .' |\n");
                Console.SetCursorPosition(x, y + 22); Console.Write("              |       |                   j  |    |  /  , `.__,'   |\n");
                Console.SetCursorPosition(x, y + 23); Console.Write("              `.      L                 _.   `    j ,'-'           |\n");
                Console.SetCursorPosition(x, y + 24); Console.Write("               |`\"---..\\._______,...,--' |   |   /|'      /        j\n");
                Console.SetCursorPosition(x, y + 25); Console.Write("               '       |                 |   .  / |      '        /\n");
                Console.SetCursorPosition(x, y + 26); Console.Write("                .      .              ____L   \\'  j    -',       /\n");
                Console.SetCursorPosition(x, y + 27); Console.Write("               / `.     .          _,\"     \\   | /  ,-','      ,'\n");
                Console.SetCursorPosition(x, y + 28); Console.Write("              /    `.  ,'`-._     /         \\  i'.,'_,'      .'\n");
                Console.SetCursorPosition(x, y + 29); Console.Write("             .       `.      `-..'             |_,-'      _.'\n");
                Console.SetCursorPosition(x, y + 30); Console.Write("             |         `._      |            ''/      _,-'\n");
                Console.SetCursorPosition(x, y + 31); Console.Write("             |            '-..._\\             `__,.--'\n");
                Console.SetCursorPosition(x, y + 32); Console.Write("            ,'           ,' `-.._`.            .\n");
                Console.SetCursorPosition(x, y + 33); Console.Write("           `.    __      |       \"'`.          |\n");
                Console.SetCursorPosition(x, y + 34); Console.Write("             `-\"'  `\"\"\"\"'            7         `.\n");
                Console.SetCursorPosition(x, y + 35); Console.Write("                                    `---'--.,'\"`' \n");
            }

            else if (pokenumber == 9)
            {
                Console.SetCursorPosition(x, y); Console.Write("                       _\n");
                Console.SetCursorPosition(x, y + 1); Console.Write("            _,..-\"\"\"--' `,.-\".\n");
                Console.SetCursorPosition(x, y + 2); Console.Write("          ,'      __.. --',  |\n");
                Console.SetCursorPosition(x, y + 3); Console.Write("        _/   _.-\"' |    .' | |       ____\n");
                Console.SetCursorPosition(x, y + 4); Console.Write("  ,.-\"\"'    `-\"+.._|     `.' | `-..,',--.`.\n");
                Console.SetCursorPosition(x, y + 5); Console.Write(" |   ,.                      '    j 7    l \\__\n");
                Console.SetCursorPosition(x, y + 6); Console.Write(" |.-'                            /| |    j||  .\n");
                Console.SetCursorPosition(x, y + 7); Console.Write(" `.                   |         / L`.`\"\"','|\\  \\\n");
                Console.SetCursorPosition(x, y + 8); Console.Write("   `.,----..._       ,'`\"'-.  ,'   \\ `\"\"'  | |  l\n");
                Console.SetCursorPosition(x, y + 9); Console.Write("     Y        `-----'       v'    ,'`,.__..' |   .\n");
                Console.SetCursorPosition(x, y + 10); Console.Write("      `.                   /     /   /     `.|   |\n");
                Console.SetCursorPosition(x, y + 11); Console.Write("        `.                /     l   j       ,^.  |L\n");
                Console.SetCursorPosition(x, y + 12); Console.Write("          `._            L       +. |._   .' \\|  | \\\n");
                Console.SetCursorPosition(x, y + 13); Console.Write("            .`--...__,..-'\"\"'-._  l L  \"\"\"    |  |  \\\n");
                Console.SetCursorPosition(x, y + 14); Console.Write("          .'  ,`-......L_       \\  \\ \\     _.'  ,'.  l\n");
                Console.SetCursorPosition(x, y + 15); Console.Write("       ,-\"`. / ,-.---.'  `.      \\  L..--\"'  _.-^.|   l\n");
                Console.SetCursorPosition(x, y + 16); Console.Write(" .-\"\".'\"`.  Y  `._'   '    `.     | | _,.--'\"     |   |\n");
                Console.SetCursorPosition(x, y + 17); Console.Write("  `._'   |  |,-'|      l     `.   | |\"..          |   l\n");
                Console.SetCursorPosition(x, y + 18); Console.Write("  ,'.    |  |`._'      |      `.  | |_,...---\"\"\"\"\"`    L\n");
                Console.SetCursorPosition(x, y + 19); Console.Write(" /   |   j _|-' `.     L       | j ,|              |   |\n");
                Console.SetCursorPosition(x, y + 20); Console.Write("`--,\"._,-+' /`---^..../._____,.L',' `.             |\\  |\n");
                Console.SetCursorPosition(x, y + 21); Console.Write("   |,'      L                   |     `-.          | \\j\n");
                Console.SetCursorPosition(x, y + 22); Console.Write("            .                    \\       `,        |  |\n");
                Console.SetCursorPosition(x, y + 23); Console.Write("             \\                __`.Y._      -.     j   |\n");
                Console.SetCursorPosition(x, y + 24); Console.Write("              \\           _.,'       `._     \\    |  j\n");
                Console.SetCursorPosition(x, y + 25); Console.Write("              ,-\"`-----\"\"\"\"'           |`.    \\  7   |\n");
                Console.SetCursorPosition(x, y + 26); Console.Write("             /  `.        '            |  \\    \\ /   |\n");
                Console.SetCursorPosition(x, y + 27); Console.Write("            |     `      /             |   \\    Y    |\n");
                Console.SetCursorPosition(x, y + 28); Console.Write("            |      \\    .             ,'    |   L_.-')\n");
                Console.SetCursorPosition(x, y + 29); Console.Write("             L      `.  |            /      ]     _.-^._\n");
                Console.SetCursorPosition(x, y + 30); Console.Write("              \\   ,'  `-7         ,-'      / |  ,'      `-._\n");
                Console.SetCursorPosition(x, y + 31); Console.Write("             _,`._       `.   _,-'        ,',^.-            `.\n");
                Console.SetCursorPosition(x, y + 32); Console.Write("          ,-'     v....  _.`\"',          _){'--....._______,.-'\n");
                Console.SetCursorPosition(x, y + 33); Console.Write("        ._______./     /',,-'\"'`'--.  ,-'  `.\n");
                Console.SetCursorPosition(x, y + 34); Console.Write("                 \"\"\"\"\"`.,'         _\\`----...' \n");
                Console.SetCursorPosition(x, y + 35); Console.Write("                        --------\"\"'\n");
                Console.SetCursorPosition(x, y + 36); Console.Write("\n");
                Console.SetCursorPosition(x, y + 37); Console.Write("\n");
            }

            else if (pokenumber == 10)
            {
                Console.SetCursorPosition(x, y); Console.Write("                   _,........_\n");
                Console.SetCursorPosition(x, y + 1); Console.Write("               _.-'    ___    `-._\n");
                Console.SetCursorPosition(x, y + 2); Console.Write("            ,-'      ,'   \\       `.\n");
                Console.SetCursorPosition(x, y + 3); Console.Write(" _,...    ,'      ,-'     |  ,\"\"\"){`._.\n");
                Console.SetCursorPosition(x, y + 4); Console.Write("/     `--+.   _,.'      _.',',|\"|  ` \\`\n");
                Console.SetCursorPosition(x, y + 5); Console.Write("\\_         `\"'     _,-\"'  | / `-'   l L\\\n");
                Console.SetCursorPosition(x, y + 6); Console.Write("  `\"---.._      ,-\"       | l       | | |\n");
                Console.SetCursorPosition(x, y + 7); Console.Write("      /   `.   |          ' `.     ,' ; |\n");
                Console.SetCursorPosition(x, y + 8); Console.Write("     j     |   |           `._`\"\"\"' ,'  |__\n");
                Console.SetCursorPosition(x, y + 9); Console.Write("     |      `--'____          `----'    .' `.\n");
                Console.SetCursorPosition(x, y + 10); Console.Write("     |    _,-\"\"\"    `-.                 |    \\\n");
                Console.SetCursorPosition(x, y + 11); Console.Write("     l   /             `.               F     l\n");
                Console.SetCursorPosition(x, y + 12); Console.Write("      `./     __..._     `.           ,'      |\n");
                Console.SetCursorPosition(x, y + 13); Console.Write("        |  ,-\"      `.    | ._     _.'        |\n");
                Console.SetCursorPosition(x, y + 14); Console.Write("        . j           \\   j   /`\"\"\"      __   |          ,\"`.\n");
                Console.SetCursorPosition(x, y + 15); Console.Write("         `|           | _,.__ |        ,'  `. |          |   |\n");
                Console.SetCursorPosition(x, y + 16); Console.Write("          `-._       /-'     `L       .     , '          |   |\n");
                Console.SetCursorPosition(x, y + 17); Console.Write("              F-...-'          `      |    , /           |   |\n");
                Console.SetCursorPosition(x, y + 18); Console.Write("              |            ,----.     `...' /            |   |\n");
                Console.SetCursorPosition(x, y + 19); Console.Write("              .--.        j      l        ,'             |   j\n");
                Console.SetCursorPosition(x, y + 20); Console.Write("             j    L       |      |'-...--<               .  /\n");
                Console.SetCursorPosition(x, y + 21); Console.Write("             `     |       . __,,_    ..  |               \\/\n");
                Console.SetCursorPosition(x, y + 22); Console.Write("              `-..'.._  __,-'     \\  |  |/`._           ,'`\n");
                Console.SetCursorPosition(x, y + 23); Console.Write("                  |   \"\"       .--`. `--,  ,-`..____..,'   |\n");
                Console.SetCursorPosition(x, y + 24); Console.Write("                   L          /     \\ _.  |   | \\  .-.\\    j\n");
                Console.SetCursorPosition(x, y + 25); Console.Write("                  .'._        l     .\\    `---' |  |  || ,'\n");
                Console.SetCursorPosition(x, y + 26); Console.Write("                   .  `..____,-.._.'  `._       |  `--;\"I'\n");
                Console.SetCursorPosition(x, y + 27); Console.Write("                    `--\"' `.            ,`-..._/__,.-1,'\n");
                Console.SetCursorPosition(x, y + 28); Console.Write("                            `-.__  __,.'     ,' ,' _-'\n");
                Console.SetCursorPosition(x, y + 29); Console.Write("                                 `'...___..`'--^--' \n");
            }

            else if (pokenumber == 11)
            {
                Console.SetCursorPosition(x, y); Console.Write("                                   ,--..\n");
                Console.SetCursorPosition(x, y + 1); Console.Write("                                  /     `.\n");
                Console.SetCursorPosition(x, y + 2); Console.Write("                                 /|       `.\n");
                Console.SetCursorPosition(x, y + 3); Console.Write("                                / |        |\n");
                Console.SetCursorPosition(x, y + 4); Console.Write("                               /  j        |\n");
                Console.SetCursorPosition(x, y + 5); Console.Write("                              /  |         `\n");
                Console.SetCursorPosition(x, y + 6); Console.Write("                             '  ,'          \\\n");
                Console.SetCursorPosition(x, y + 7); Console.Write("                           ,'                L\n");
                Console.SetCursorPosition(x, y + 8); Console.Write("                          /                  +\n");
                Console.SetCursorPosition(x, y + 9); Console.Write("                        .){.                   .      `\n");
                Console.SetCursorPosition(x, y + 10); Console.Write("                     ,\"`.  `.       ,..-._    +\n");
                Console.SetCursorPosition(x, y + 11); Console.Write("                     |  |`.  L     '   _.'`.   .\n");
                Console.SetCursorPosition(x, y + 12); Console.Write("                     j  `.,\\ '    | ,.' |  +.  +\n");
                Console.SetCursorPosition(x, y + 13); Console.Write("                    '`.    |,'    |\" `\"\"   / `, .\n");
                Console.SetCursorPosition(x, y + 14); Console.Write("                   |   `\"\"'/      `-.____.'    \\|\n");
                Console.SetCursorPosition(x, y + 15); Console.Write("                 ,'|     ,'                     Y\n");
                Console.SetCursorPosition(x, y + 16); Console.Write("                /  |    /                      '|\n");
                Console.SetCursorPosition(x, y + 17); Console.Write("               /   |  ,'                     ,' +\n");
                Console.SetCursorPosition(x, y + 18); Console.Write("              /    \\-'                      /    `\n");
                Console.SetCursorPosition(x, y + 19); Console.Write("             /    /                       ,'      `\n");
                Console.SetCursorPosition(x, y + 20); Console.Write("            .     ,`'-.                 ,'         L\n");
                Console.SetCursorPosition(x, y + 21); Console.Write("             \\   /     \\               /            .\n");
                Console.SetCursorPosition(x, y + 22); Console.Write("                /      `               \\            |\n");
                Console.SetCursorPosition(x, y + 23); Console.Write("              `/          _,            `          ,'\n");
                Console.SetCursorPosition(x, y + 24); Console.Write("               |                         `       ,'\n");
                Console.SetCursorPosition(x, y + 25); Console.Write("               |           \"'             `.   ,'\n");
                Console.SetCursorPosition(x, y + 26); Console.Write("               j         -\"'               |`-'\n");
                Console.SetCursorPosition(x, y + 27); Console.Write("              /                           /'/\n");
                Console.SetCursorPosition(x, y + 28); Console.Write("             /           ,               / /\n");
                Console.SetCursorPosition(x, y + 29); Console.Write("            /            '              j /\n");
                Console.SetCursorPosition(x, y + 30); Console.Write("          .' ___                        '/\n");
                Console.SetCursorPosition(x, y + 31); Console.Write("          |-'   `\"`-.                  '/\n");
                Console.SetCursorPosition(x, y + 32); Console.Write("          '          \\                .'\n");
                Console.SetCursorPosition(x, y + 33); Console.Write("        ,\"            l          _,.-'\n");
                Console.SetCursorPosition(x, y + 34); Console.Write("       ,---..         |L     _.-'\n");
                Console.SetCursorPosition(x, y + 35); Console.Write("     ,'      `.      / |  ,-'\n");
                Console.SetCursorPosition(x, y + 36); Console.Write("    /          `  _,'  ;-'\n");
                Console.SetCursorPosition(x, y + 37); Console.Write("  ,'--.       ,-`|  ,-'\n");
                Console.SetCursorPosition(x, y + 38); Console.Write(" /     L   _,'  _|-'\n");
                Console.SetCursorPosition(x, y + 39); Console.Write("(       \\-' _,-'\n");
                Console.SetCursorPosition(x, y + 40); Console.Write(" `......^.-' \n");
                Console.SetCursorPosition(x, y + 41); Console.Write("\n");
            }

            else if (pokenumber == 12)
            {
                Console.SetCursorPosition(x, y); Console.Write("       ,-.                                            ___.._\n");
                Console.SetCursorPosition(x, y + 1); Console.Write(" _     `. `.                                    _,-\"\"\"      ',._\n");
                Console.SetCursorPosition(x, y + 2); Console.Write("`.`.      `.\\                                _,'         _..-'  `.\n");
                Console.SetCursorPosition(x, y + 3); Console.Write("  `._\\       `.                            ,'         _,'_,.-'-.  \\\n");
                Console.SetCursorPosition(x, y + 4); Console.Write("      `.       `.                        ,'        ,-',-\"       \\  .\n");
                Console.SetCursorPosition(x, y + 5); Console.Write("        `.       \\                      /  _,----\"',-'           L  L\n");
                Console.SetCursorPosition(x, y + 6); Console.Write("          `.      \\                   ,' _.--\"-.  [              |  |\n");
                Console.SetCursorPosition(x, y + 7); Console.Write("            `.     .                 / ,'       | |     _..---../   |\n");
                Console.SetCursorPosition(x, y + 8); Console.Write("              .     L               / /         | j ,.-'        `   |\n");
                Console.SetCursorPosition(x, y + 9); Console.Write("               \\    .              ' /          j ,'             |  |\n");
                Console.SetCursorPosition(x, y + 10); Console.Write("                \\    .            ' /          ' /               |  |\n");
                Console.SetCursorPosition(x, y + 11); Console.Write("                 \\   l           / /          /,'                j  '\n");
                Console.SetCursorPosition(x, y + 12); Console.Write("                  L__L._        / /          +'      __,........'  j\n");
                Console.SetCursorPosition(x, y + 13); Console.Write("                ,'   '  \"`.    / /         .' _,.--'\"           \\  |\n");
                Console.SetCursorPosition(x, y + 14); Console.Write("               /,\"\"-.      `. ' '        _/.-'                  | F\n");
                Console.SetCursorPosition(x, y + 15); Console.Write("              /|   / l       . /       ,'                       | |\n");
                Console.SetCursorPosition(x, y + 16); Console.Write("             | |  /  |       ]'      ,'                         | |\n");
                Console.SetCursorPosition(x, y + 17); Console.Write("            ,._\\\"'   |       |     ,'-'\"\"\"\"\"\"\"\"\"\"\"\"\"'----.._    / |\n");
                Console.SetCursorPosition(x, y + 18); Console.Write("            |  \\`.._,'       F  _,'                         `--'  |\n");
                Console.SetCursorPosition(x, y + 19); Console.Write("            `..'           _/ ,){_____                         L   |\n");
                Console.SetCursorPosition(x, y + 20); Console.Write("              `..          .-'       `'--.._                   | j\n");
                Console.SetCursorPosition(x, y + 21); Console.Write("            _,. /,---.       \\              `--..              | |\n");
                Console.SetCursorPosition(x, y + 22); Console.Write("           F  <j-.'   `       ._                 `\"-._        j  '\n");
                Console.SetCursorPosition(x, y + 23); Console.Write("           |  <|`,.    |       `L._                   `..   _, ,'\n");
                Console.SetCursorPosition(x, y + 24); Console.Write("           `..<|`.___,'        |.  `-.                   Y\"' _.\n");
                Console.SetCursorPosition(x, y + 25); Console.Write("              `L               | `.   `-.._____________,',.-'\n");
                Console.SetCursorPosition(x, y + 26); Console.Write("                `.            .Y   \\      `\"\".\"\"\"\"\".  .\"'\n");
                Console.SetCursorPosition(x, y + 27); Console.Write("                  `.        ,' |\\   `.        `+-._ \\  |\n");
                Console.SetCursorPosition(x, y + 28); Console.Write("                    `,--. -'   | .    `.       `   `.| |\n");
                Console.SetCursorPosition(x, y + 29); Console.Write("                    /    //    |  \\    ``-..___/     | |\n");
                Console.SetCursorPosition(x, y + 30); Console.Write("                   j    .l     |   .    F   \\   `   F  |\n");
                Console.SetCursorPosition(x, y + 31); Console.Write("                   |    ||     |    `   `    .   ` ,  /\n");
                Console.SetCursorPosition(x, y + 32); Console.Write("                   |    ||    F      `-.|     . _,' _'\n");
                Console.SetCursorPosition(x, y + 33); Console.Write("                   |   / |    |       `._`-----'  ,'\n");
                Console.SetCursorPosition(x, y + 34); Console.Write("                   |  /  |   /           `-------'\n");
                Console.SetCursorPosition(x, y + 35); Console.Write("                   l /   \\_,'\n");
                Console.SetCursorPosition(x, y + 36); Console.Write("                    \" \n");
            }

            else if (pokenumber == 13)
            {
                Console.SetCursorPosition(x, y); Console.Write("               ,`.\n");
                Console.SetCursorPosition(x, y + 1); Console.Write("               L  \\\n");
                Console.SetCursorPosition(x, y + 2); Console.Write("              ,    \\\n");
                Console.SetCursorPosition(x, y + 3); Console.Write("             j      \\\n");
                Console.SetCursorPosition(x, y + 4); Console.Write("             ,       \\\n");
                Console.SetCursorPosition(x, y + 5); Console.Write("            j         `\n");
                Console.SetCursorPosition(x, y + 6); Console.Write("            ,          .__\n");
                Console.SetCursorPosition(x, y + 7); Console.Write("         ,-'Y          `  `-.\n");
                Console.SetCursorPosition(x, y + 8); Console.Write("      .-'    `..___..-'      `-.\n");
                Console.SetCursorPosition(x, y + 9); Console.Write("     /__           ,-.          \\\n");
                Console.SetCursorPosition(x, y + 10); Console.Write("    /(__)         `   '          `.\n");
                Console.SetCursorPosition(x, y + 11); Console.Write("   |               `\"'             L\n");
                Console.SetCursorPosition(x, y + 12); Console.Write("   `.------._                      |\n");
                Console.SetCursorPosition(x, y + 13); Console.Write(" ,'          `                     |\n");
                Console.SetCursorPosition(x, y + 14); Console.Write("F             |                    |\n");
                Console.SetCursorPosition(x, y + 15); Console.Write("|             |                    |\n");
                Console.SetCursorPosition(x, y + 16); Console.Write("`._         ,'                     j\n");
                Console.SetCursorPosition(x, y + 17); Console.Write("   `+------'                      /\n");
                Console.SetCursorPosition(x, y + 18); Console.Write("     \\                           /                         |`._\n");
                Console.SetCursorPosition(x, y + 19); Console.Write("      `.                       ,'                          |   \\\n");
                Console.SetCursorPosition(x, y + 20); Console.Write("        `._                _,-'                            |    \\\n");
                Console.SetCursorPosition(x, y + 21); Console.Write("           `-,.________,.-'   `.                           |     L\n");
                Console.SetCursorPosition(x, y + 22); Console.Write("            /                   '                          |     |\n");
                Console.SetCursorPosition(x, y + 23); Console.Write("           /             _,._   |                          ,`---,'\n");
                Console.SetCursorPosition(x, y + 24); Console.Write("         ,'|            /    .  j                        .'      `.\n");
                Console.SetCursorPosition(x, y + 25); Console.Write("         . L            '    | ,                      ,-'\"'`-..   |\n");
                Console.SetCursorPosition(x, y + 26); Console.Write("          .,\\            `--' / `.               ___./       ,.' ,'\n");
                Console.SetCursorPosition(x, y + 27); Console.Write("             \\              ,'    \\__         ,-'     \"-.    | |'\n");
                Console.SetCursorPosition(x, y + 28); Console.Write("              `-._______,.-'  __   | `'-._.,- ._        _`   `\"Y\n");
                Console.SetCursorPosition(x, y + 29); Console.Write("                |           .\"  \\  |     \\      `.    ,'  \\   ,'\n");
                Console.SetCursorPosition(x, y + 30); Console.Write("                |           '    | ;      .       .   `._./.-'\n");
                Console.SetCursorPosition(x, y + 31); Console.Write("                7.           `'\"' / `.--. |   _.. |      j\n");
                Console.SetCursorPosition(x, y + 32); Console.Write("                `.__       `   _-'   |   |j  /   ||     .'\n");
                Console.SetCursorPosition(x, y + 33); Console.Write("                    `-...,_..-'      `--'/   `._, ^----'\n");
                Console.SetCursorPosition(x, y + 34); Console.Write("                         .\\            _'       ,'\n");
                Console.SetCursorPosition(x, y + 35); Console.Write("               `         `._-.______,.'`.___,.-'\n");
                Console.SetCursorPosition(x, y + 36); Console.Write("\n");
            }

            else if (pokenumber == 14)
            {
                Console.SetCursorPosition(x, y); Console.Write("           _,--'\"\"\"\"\"\"---.._\n");
                Console.SetCursorPosition(x, y + 1); Console.Write("         ,'                 `._\n");
                Console.SetCursorPosition(x, y + 2); Console.Write("       ,'                      `.\n");
                Console.SetCursorPosition(x, y + 3); Console.Write("     ,'                          \\\n");
                Console.SetCursorPosition(x, y + 4); Console.Write("    .                             \\\n");
                Console.SetCursorPosition(x, y + 5); Console.Write("  ,'.                  ,-`.        \\\n");
                Console.SetCursorPosition(x, y + 6); Console.Write(" /   \\               ,'    ,        \\\n");
                Console.SetCursorPosition(x, y + 7); Console.Write("|`.  |\\            ,`      |         |\n");
                Console.SetCursorPosition(x, y + 8); Console.Write("L  `.| |         .''     _,'        _'\n");
                Console.SetCursorPosition(x, y + 9); Console.Write(" \\    \"'        ,`'_..-''        _,'\n");
                Console.SetCursorPosition(x, y + 10); Console.Write("  `.            '\"\"          _,.' `.\n");
                Console.SetCursorPosition(x, y + 11); Console.Write("    /._                 _..-\"       \\\n");
                Console.SetCursorPosition(x, y + 12); Console.Write("   /   `.          _,.-'             \\\n");
                Console.SetCursorPosition(x, y + 13); Console.Write("  /      \\-.___.--'/                  \\\n");
                Console.SetCursorPosition(x, y + 14); Console.Write(" |      ,/.     .-^+.._               F\n");
                Console.SetCursorPosition(x, y + 15); Console.Write("  L..-''.' \\  .'   |   `'--.....___   .\n");
                Console.SetCursorPosition(x, y + 16); Console.Write("  /     /   `/     |               `\"-;\n");
                Console.SetCursorPosition(x, y + 17); Console.Write(" /     j    j      '                ,'\n");
                Console.SetCursorPosition(x, y + 18); Console.Write(" `.    |    |       L          _.-'Y\n");
                Console.SetCursorPosition(x, y + 19); Console.Write("  ,`._/     |        .    _,.-'     .\n");
                Console.SetCursorPosition(x, y + 20); Console.Write("  `.  '|    |         \\\"\"\"|         |\n");
                Console.SetCursorPosition(x, y + 21); Console.Write("   |   |    |         |   |         |\n");
                Console.SetCursorPosition(x, y + 22); Console.Write("   |   |    |        ,'   |         |\n");
                Console.SetCursorPosition(x, y + 23); Console.Write("   |   L    +      ,'     |         |\n");
                Console.SetCursorPosition(x, y + 24); Console.Write("   |    \\    L    ,\\      j         |\n");
                Console.SetCursorPosition(x, y + 25); Console.Write("   L     \\   |   /  `.   /          j\n");
                Console.SetCursorPosition(x, y + 26); Console.Write("    \\    j\\  |  /    `. /          .\n");
                Console.SetCursorPosition(x, y + 27); Console.Write("     L  .  ` | /       \\          /\n");
                Console.SetCursorPosition(x, y + 28); Console.Write("     +  |   `|/                  /\n");
                Console.SetCursorPosition(x, y + 29); Console.Write("      \\ | _,..._         \\      /\n");
                Console.SetCursorPosition(x, y + 30); Console.Write("       ./'      `-._      \\   ,'\n");
                Console.SetCursorPosition(x, y + 31); Console.Write("        l           `.     ^_/\n");
                Console.SetCursorPosition(x, y + 32); Console.Write("        +             `   /\n");
                Console.SetCursorPosition(x, y + 33); Console.Write("         L-\"\"--.       .,'\n");
                Console.SetCursorPosition(x, y + 34); Console.Write("         |      `.     ,\n");
                Console.SetCursorPosition(x, y + 35); Console.Write("         .        \\  ,'\n");
                Console.SetCursorPosition(x, y + 36); Console.Write("          `       _.'\n");
                Console.SetCursorPosition(x, y + 37); Console.Write("           `....-' \n");
            }

            else if (pokenumber == 15)
            {
                Console.SetCursorPosition(x, y); Console.Write("                     ,--\"\"+--.\n");
                Console.SetCursorPosition(x, y + 1); Console.Write("                    /     j   /`.\n");
                Console.SetCursorPosition(x, y + 2); Console.Write("                   |     /   |   `.\n");
                Console.SetCursorPosition(x, y + 3); Console.Write("                   |   ,'    '     \\\n");
                Console.SetCursorPosition(x, y + 4); Console.Write("                   j,-'     '`..    \\\n");
                Console.SetCursorPosition(x, y + 5); Console.Write("                  +      _ /    `._/ \\\n");
                Console.SetCursorPosition(x, y + 6); Console.Write("                  |     / '-.     |   .\n");
                Console.SetCursorPosition(x, y + 7); Console.Write("                  |    /     |   /    |\n");
                Console.SetCursorPosition(x, y + 8); Console.Write("                  |   /     j   j     |\n");
                Console.SetCursorPosition(x, y + 9); Console.Write("                  |  j      |   |     |._\n");
                Console.SetCursorPosition(x, y + 10); Console.Write("                  | .'     7    |     |  `.\n");
                Console.SetCursorPosition(x, y + 11); Console.Write("  ___      _.._   | j      |    +     '    `.\n");
                Console.SetCursorPosition(x, y + 12); Console.Write(" |.---=-.,'+-. `. |/       F     L  ,'    ,'`.\n");
                Console.SetCursorPosition(x, y + 13); Console.Write(" ||,==--'|_' |  j  \\      /      |,'   ,`'    L\n");
                Console.SetCursorPosition(x, y + 14); Console.Write(" 'Y'   | |  '/ ',.-.\\    j     ,,^  _,' \\     |\n");
                Console.SetCursorPosition(x, y + 15); Console.Write("`.||   |  `.'  '    `.   / _,-'   `'     L   F\n");
                Console.SetCursorPosition(x, y + 16); Console.Write("  ||   `     .  ,-.   `,--'              |   |\n");
                Console.SetCursorPosition(x, y + 17); Console.Write("  `'    `.  /_,' ,'     `--------------\"\"\"\"'Y\n");
                Console.SetCursorPosition(x, y + 18); Console.Write("         _){\"'_.-'       /_>){-.__           /\n");
                Console.SetCursorPosition(x, y + 19); Console.Write("      `-\".`\"'__,`-.,-._/      `.\"\"`------\"'\n");
                Console.SetCursorPosition(x, y + 20); Console.Write("      `.| `\"'      | | _.--'\"\"'--\\\n");
                Console.SetCursorPosition(x, y + 21); Console.Write("       || /        | '\"  ___,.._  \\\n");
                Console.SetCursorPosition(x, y + 22); Console.Write("      _|||__      / /,.-'       `- .\n");
                Console.SetCursorPosition(x, y + 23); Console.Write("    ,'   `. .    /,'/'  _.,-\"\"\"--._F\n");
                Console.SetCursorPosition(x, y + 24); Console.Write("    7     | |  .',L'|_-'           |\n");
                Console.SetCursorPosition(x, y + 25); Console.Write("    +     | | / / ',\"'  ,.-'\"\"'`-._|\n");
                Console.SetCursorPosition(x, y + 26); Console.Write("     L    ' |. /  .-.`\"'           |\n");
                Console.SetCursorPosition(x, y + 27); Console.Write("     |   j j   \\  `-.'\\           j\n");
                Console.SetCursorPosition(x, y + 28); Console.Write("     +   | | \\  `.   ` `.  _.... ,\n");
                Console.SetCursorPosition(x, y + 29); Console.Write("      L  | |  \\   .   `  \\\"     /\n");
                Console.SetCursorPosition(x, y + 30); Console.Write("      | ,' |   L  ,'    \\ `    .\n");
                Console.SetCursorPosition(x, y + 31); Console.Write("      | || |   '  |      L `   |\n");
                Console.SetCursorPosition(x, y + 32); Console.Write("      `./|j     `. .     `. \\ j\n");
                Console.SetCursorPosition(x, y + 33); Console.Write("       |  '       ` .     | '\\`\n");
                Console.SetCursorPosition(x, y + 34); Console.Write("                   \\ '.   | \\\n");
                Console.SetCursorPosition(x, y + 35); Console.Write("                    | |  /,-'\n");
                Console.SetCursorPosition(x, y + 36); Console.Write("                    j l  \"\n");
                Console.SetCursorPosition(x, y + 37); Console.Write("                  _/_,'\n");
                Console.SetCursorPosition(x, y + 38); Console.Write("                 ',' \n");
            }

            else if (pokenumber == 16)
            {
                Console.SetCursorPosition(x, y); Console.Write("                   .,\n");
                Console.SetCursorPosition(x, y + 1); Console.Write("            , _.-','\n");
                Console.SetCursorPosition(x, y + 2); Console.Write("          \"\"|\"    `\"\"\"\".,\n");
                Console.SetCursorPosition(x, y + 3); Console.Write("         /'/       __.-'-\"/\n");
                Console.SetCursorPosition(x, y + 4); Console.Write("        ','  _,--\"\"      '-._\n");
                Console.SetCursorPosition(x, y + 5); Console.Write("    _...`...'.\"\"\"\"\"\".\\\"\"-----'\n");
                Console.SetCursorPosition(x, y + 6); Console.Write(" ,-'          `-.) /  `.  \\\n");
                Console.SetCursorPosition(x, y + 7); Console.Write("+---.\"-.    |     `.    .  \\\n");
                Console.SetCursorPosition(x, y + 8); Console.Write("     \\  `.  |       \\   |   L\n");
                Console.SetCursorPosition(x, y + 9); Console.Write("      `v  ,-j        , .'   |\n");
                Console.SetCursorPosition(x, y + 10); Console.Write("     .'\\,' /        /,'      -._\n");
                Console.SetCursorPosition(x, y + 11); Console.Write("    ,____.'        .            `-.\n");
                Console.SetCursorPosition(x, y + 12); Console.Write("        |         /                `-.\n");
                Console.SetCursorPosition(x, y + 13); Console.Write("       /          `.                  `-.\n");
                Console.SetCursorPosition(x, y + 14); Console.Write("      /             `. |                 `.                  _.\n");
                Console.SetCursorPosition(x, y + 15); Console.Write("     .                `|                 ,-.             _.-\" .\n");
                Console.SetCursorPosition(x, y + 16); Console.Write("    j                  |                 |  \\         _.'    /\n");
                Console.SetCursorPosition(x, y + 17); Console.Write("    .                  |               .'    \\     ,-'      /\n");
                Console.SetCursorPosition(x, y + 18); Console.Write("    |                  |            ,-.\\      \\  ,'      _.-\n");
                Console.SetCursorPosition(x, y + 19); Console.Write("    |                . '  `.       |   `      `v'  _,.-\"/\n");
                Console.SetCursorPosition(x, y + 20); Console.Write("    ||    \\          |  ` |(`'-`.,.j         \\ `.-'----+---.\n");
                Console.SetCursorPosition(x, y + 21); Console.Write("    |'|   |L    \\  | |   `|   \\'              L \\___      /\n");
                Console.SetCursorPosition(x, y + 22); Console.Write("    ' L   |`     L | |     `.                 | j   `\"\"\"-'\n");
                Console.SetCursorPosition(x, y + 23); Console.Write("       `-'||\\    | ||j       `.       ._    ` '.\n");
                Console.SetCursorPosition(x, y + 24); Console.Write("          `\\ '\"`^\"- '          `.       \\    |/|\n");
                Console.SetCursorPosition(x, y + 25); Console.Write("            `._                  `-.     \\   Y |\n");
                Console.SetCursorPosition(x, y + 26); Console.Write("    __,..-\"\"`..`._                  `-._  `\\ `.|\n");
                Console.SetCursorPosition(x, y + 27); Console.Write("   +.....>+----.' \"\"----.........,--\"\"\" `--.'.'\n");
                Console.SetCursorPosition(x, y + 28); Console.Write("       ,' _\\  ,..--.-\"' __>---'  |\n");
                Console.SetCursorPosition(x, y + 29); Console.Write("      --\"\"  \"'  _.\" }<\"\"          `---\"\"`._\n");
                Console.SetCursorPosition(x, y + 30); Console.Write("               /...\"  L__.+--   _,......'..'\n");
                Console.SetCursorPosition(x, y + 31); Console.Write("                 /.-\"\"'/   \\ ,-'\n");
                Console.SetCursorPosition(x, y + 32); Console.Write("                     .' ,-\"\"'\n");
                Console.SetCursorPosition(x, y + 33); Console.Write("                    /.-' \n");
            }

            else if (pokenumber == 17)
            {
                Console.SetCursorPosition(x, y); Console.Write("                        |\n");
                Console.SetCursorPosition(x, y + 1); Console.Write("                   ____ A,\n");
                Console.SetCursorPosition(x, y + 2); Console.Write("               _,-'\\  || /`'`.\n");
                Console.SetCursorPosition(x, y + 3); Console.Write("              /-.   '.'|    ,'-.\n");
                Console.SetCursorPosition(x, y + 4); Console.Write("            .'   `. |/j | ,'    ..\n");
                Console.SetCursorPosition(x, y + 5); Console.Write("           .\"\"|._  \\` | ,'  _.,\\--.\n");
                Console.SetCursorPosition(x, y + 6); Console.Write("           '/ |  |\"\\\\,| |,\"| |  |  \\\n");
                Console.SetCursorPosition(x, y + 7); Console.Write("           |.'_..|().\\../()|_/\\ |\\ |'\n");
                Console.SetCursorPosition(x, y + 8); Console.Write("           | |     ,'   `    L \\| Y\n");
                Console.SetCursorPosition(x, y + 9); Console.Write("           | '    /.-\"\"-.`    |||  \\\n");
                Console.SetCursorPosition(x, y + 10); Console.Write("           . |   |_,-----.|   j||  `\n");
                Console.SetCursorPosition(x, y + 11); Console.Write("           | .   . .     ,'  /,'/\n");
                Console.SetCursorPosition(x, y + 12); Console.Write("         __|  \\   \\ \\__,'/  // j\n");
                Console.SetCursorPosition(x, y + 13); Console.Write("     _,'\" ,'   `._ `.__.'  ,'  |---._\n");
                Console.SetCursorPosition(x, y + 14); Console.Write("   ,'    .        `\"----\"\"'    .     `.\n");
                Console.SetCursorPosition(x, y + 15); Console.Write("  ,     .                       `      `\n");
                Console.SetCursorPosition(x, y + 16); Console.Write(" /     /    ,-\"\"\"\"\"\"\"\"\"\"\"\"\"--._  \\      '\n");
                Console.SetCursorPosition(x, y + 17); Console.Write(" |    j   ,'                   `. `     |\n");
                Console.SetCursorPosition(x, y + 18); Console.Write("|'.'  |  /                       `.|    |\n");
                Console.SetCursorPosition(x, y + 19); Console.Write("| `.  /.'                          \\  | |\n");
                Console.SetCursorPosition(x, y + 20); Console.Write("L  `'v'/                            . |,|\n");
                Console.SetCursorPosition(x, y + 21); Console.Write(" \\   '|                             | 'j\n");
                Console.SetCursorPosition(x, y + 22); Console.Write("      |                             ./ /\n");
                Console.SetCursorPosition(x, y + 23); Console.Write("  `   '                             j /\n");
                Console.SetCursorPosition(x, y + 24); Console.Write("   `  `                            / /\n");
                Console.SetCursorPosition(x, y + 25); Console.Write("    `. .                          / /\n");
                Console.SetCursorPosition(x, y + 26); Console.Write("      `.`.                       /,'\n");
                Console.SetCursorPosition(x, y + 27); Console.Write("         \\`.                   ,',\n");
                Console.SetCursorPosition(x, y + 28); Console.Write("          . `                 .-\n");
                Console.SetCursorPosition(x, y + 29); Console.Write("           `.  +.       _,.- ,'\n");
                Console.SetCursorPosition(x, y + 30); Console.Write("            |`-| `\"--\"\"' `,'-|\n");
                Console.SetCursorPosition(x, y + 31); Console.Write("           ,'  | _      _ |  |\n");
                Console.SetCursorPosition(x, y + 32); Console.Write("   ,--...-'    `' |> <(\"     |-..__,..\n");
                Console.SetCursorPosition(x, y + 33); Console.Write(" ,'    _.+- ,  +..'    --.  .  `.___  '\n");
                Console.SetCursorPosition(x, y + 34); Console.Write("`-\"\"--){-' ,' |  `.       |   `..   .||_\\\n");
                Console.SetCursorPosition(x, y + 35); Console.Write("     /\"|_'   `.,-|       | _.|  `-.'_\\ `\n");
                Console.SetCursorPosition(x, y + 36); Console.Write("     .'        | |        ` ||\n");
                Console.SetCursorPosition(x, y + 37); Console.Write("                '          V' \n");
            }

            else if (pokenumber == 18)
            {
                Console.SetCursorPosition(x, y); Console.Write("                   ..-`\"-._\n");
                Console.SetCursorPosition(x, y + 1); Console.Write("                 ,'      ,'`.\n");
                Console.SetCursorPosition(x, y + 2); Console.Write("               ,f \\   . / ,-'-.\n");
                Console.SetCursorPosition(x, y + 3); Console.Write("              '  `. | |  , ,'`|\n");
                Console.SetCursorPosition(x, y + 4); Console.Write("             `.-.  \\| | ,.' ,-.\\\n");
                Console.SetCursorPosition(x, y + 5); Console.Write("              /| |. ` | /.'\"||Y .\n");
                Console.SetCursorPosition(x, y + 6); Console.Write("             . |_|U_\\.|//_U_||. |\n");
                Console.SetCursorPosition(x, y + 7); Console.Write("             | j    /   .    \\ |'\n");
                Console.SetCursorPosition(x, y + 8); Console.Write("              L    /     \\    .j`\n");
                Console.SetCursorPosition(x, y + 9); Console.Write("               .  `\"`._,--|  //  \\\n");
                Console.SetCursorPosition(x, y + 10); Console.Write("               j   `.   ,'  , \\   L\n");
                Console.SetCursorPosition(x, y + 11); Console.Write("          ____/      `\"'     \\ L  |\n");
                Console.SetCursorPosition(x, y + 12); Console.Write("       ,-'   ,'               \\|'-+.\n");
                Console.SetCursorPosition(x, y + 13); Console.Write("      /    ,'                  .    \\\n");
                Console.SetCursorPosition(x, y + 14); Console.Write("     /    /                     `    `.\n");
                Console.SetCursorPosition(x, y + 15); Console.Write("    . |  j                       \\     \\\n");
                Console.SetCursorPosition(x, y + 16); Console.Write("    |F   |                        '   \\ .\n");
                Console.SetCursorPosition(x, y + 17); Console.Write("    ||  F                         |   |\\|\n");
                Console.SetCursorPosition(x, y + 18); Console.Write("    ||  |                         |   | |\n");
                Console.SetCursorPosition(x, y + 19); Console.Write("    ||  |                         |   | |\n");
                Console.SetCursorPosition(x, y + 20); Console.Write("    `.._L                         |  ,' '\n");
                Console.SetCursorPosition(x, y + 21); Console.Write("     .   |                        |,| ,'\n");
                Console.SetCursorPosition(x, y + 22); Console.Write("      `  |                    '|||  j/\n");
                Console.SetCursorPosition(x, y + 23); Console.Write("       `.'    .             ,'   /  '\n");
                Console.SetCursorPosition(x, y + 24); Console.Write("         \\\\    `._        ,'    / ,'\n");
                Console.SetCursorPosition(x, y + 25); Console.Write("          .\\         ._ ,'     /,'\n");
                Console.SetCursorPosition(x, y + 26); Console.Write("            .  ,   .'| \\  (   //\n");
                Console.SetCursorPosition(x, y + 27); Console.Write("            j_|'_,'  |  ._'` / `.\n");
                Console.SetCursorPosition(x, y + 28); Console.Write("           ' |  |    |   |  Y    `.\n");
                Console.SetCursorPosition(x, y + 29); Console.Write("    ,.__  `; |  |-\"\"\"^\"\"\"'  |.--\"\"`\n");
                Console.SetCursorPosition(x, y + 30); Console.Write(" ,--\\   \"\"\" ,    \\  / \\ ,-     \"\"\"\"---.\n");
                Console.SetCursorPosition(x, y + 31); Console.Write("'.--`v.=){.-'  .  L.\"`\"'\"\\   ,  `.,.._ /`.\n");
                Console.SetCursorPosition(x, y + 32); Console.Write("     .L    j-\"`.   `\\    j  |`.  \"'--\"\"`-'\n");
                Console.SetCursorPosition(x, y + 33); Console.Write("     / |_,'    L ,-.|   (/`.)  `-\\.-'\\\n");
                Console.SetCursorPosition(x, y + 34); Console.Write("    `-\"\"        `. |     l /     `-\"`-'\n");
                Console.SetCursorPosition(x, y + 35); Console.Write("                  `      `- \n");
            }

            else if (pokenumber == 19)
            {
                Console.SetCursorPosition(x, y); Console.Write("                                      ,'\"\"`--.\n");
                Console.SetCursorPosition(x, y + 1); Console.Write("                                     |     __ `-.\n");
                Console.SetCursorPosition(x, y + 2); Console.Write("                                     |    /  `.  `.\n");
                Console.SetCursorPosition(x, y + 3); Console.Write("                                      \\        ,   `.\n");
                Console.SetCursorPosition(x, y + 4); Console.Write("                                       `.      \\_    `.\n");
                Console.SetCursorPosition(x, y + 5); Console.Write("                                         `.    | `.    \\\n");
                Console.SetCursorPosition(x, y + 6); Console.Write("                                           `--\"    `.   `\n");
                Console.SetCursorPosition(x, y + 7); Console.Write("                                                     `.  `\n");
                Console.SetCursorPosition(x, y + 8); Console.Write("                 ,.._                                  \\  `\n");
                Console.SetCursorPosition(x, y + 9); Console.Write("               /_,.  `.                                 \\  `\n");
                Console.SetCursorPosition(x, y + 10); Console.Write("              j/   .   \\                  ___            \\  \\\n");
                Console.SetCursorPosition(x, y + 11); Console.Write("              |    |   `____         _,--'   `.           .  L\n");
                Console.SetCursorPosition(x, y + 12); Console.Write("               L  /`--\"'    `'--._ ,'   ,-`'\\ |            . |\n");
                Console.SetCursorPosition(x, y + 13); Console.Write("                |-                /  ,''     ||            | |\n");
                Console.SetCursorPosition(x, y + 14); Console.Write("     -v._      /                   ,'        ||            | |\n");
                Console.SetCursorPosition(x, y + 15); Console.Write("       `.`-._,'               _     \\        |j    _,...   | |\n");
                Console.SetCursorPosition(x, y + 16); Console.Write("         `,.'             _,-. \\     |      /,---\"\"     `- | |\n");
                Console.SetCursorPosition(x, y + 17); Console.Write("        .'              ,\".   ||     `..___/,'            `' |\n");
                Console.SetCursorPosition(x, y + 18); Console.Write("        |   ,         _/`-'  /,'                            `|\n");
                Console.SetCursorPosition(x, y + 19); Console.Write("        |-.__.-'\"''\"\"' \"\"\"\"\"\"\"\"--`_,...-----''''--...--      `.\n");
                Console.SetCursorPosition(x, y + 20); Console.Write("         `.____,..              \"\"   __,..---\"\"\"              |\n");
                Console.SetCursorPosition(x, y + 21); Console.Write("          |       `              --\"'.                        `\n");
                Console.SetCursorPosition(x, y + 22); Console.Write("          |     ,' `._                \\'                       `\n");
                Console.SetCursorPosition(x, y + 23); Console.Write("          | |  .^.    `.             /                          `.\n");
                Console.SetCursorPosition(x, y + 24); Console.Write("         ,'_]__|  \\   / `.          /          /____._            `._\n");
                Console.SetCursorPosition(x, y + 25); Console.Write("       ,'          \\ j    '        /          /       `.             `.\n");
                Console.SetCursorPosition(x, y + 26); Console.Write(" ___,.' `._       __L/    |     __'          /     _, / \\             |\n");
                Console.SetCursorPosition(x, y + 27); Console.Write("`-._       L,.-\"\"\"  .    ,' _.-','          /-----'-./   `--.         |\n");
                Console.SetCursorPosition(x, y + 28); Console.Write("   '   / ,'         '..'\"_,'    /         F /  .\"'_,'        |.__     '\n");
                Console.SetCursorPosition(x, y + 29); Console.Write("  / ,.\\,'              \"\"      /         / (,'\\ .'        ,.-\"'  `.  j\n");
                Console.SetCursorPosition(x, y + 30); Console.Write("  -'   '                      /        ,'     `\"         / __/' .- ,'\n");
                Console.SetCursorPosition(x, y + 31); Console.Write("                           __.'\"`.    /                 `-' | _,L,'\n");
                Console.SetCursorPosition(x, y + 32); Console.Write("                         .',      `\"\"'                      '/,--\n");
                Console.SetCursorPosition(x, y + 33); Console.Write("                          / _..' _,,'\n");
                Console.SetCursorPosition(x, y + 34); Console.Write("                          ,' `-\"' \n");
            }

            else if (pokenumber == 20)
            {
                Console.SetCursorPosition(x, y); Console.Write("                        |.     .|\n");
                Console.SetCursorPosition(x, y + 1); Console.Write("                      `.  `._.' |,'Y'     _.......\n");
                Console.SetCursorPosition(x, y + 2); Console.Write("      +--------..  _\\\"'  \"\"\"\"\"\"'--.=-_ ,-'  ,.-- '     .\n");
                Console.SetCursorPosition(x, y + 3); Console.Write("       |  '\"\"`.  `.`-._           .-\" |   .'    (      |`\n");
                Console.SetCursorPosition(x, y + 4); Console.Write("       j       \\  |..'-- ,-----. ,.]..|  /       `.    L .\n");
                Console.SetCursorPosition(x, y + 5); Console.Write("  ____(___     |      _.' -  , `--..    | __.....-/-..__|L\n");
                Console.SetCursorPosition(x, y + 6); Console.Write(".'._______\"\"\"\"----  ,'   _____._    ` ,-'){,...------\"\"\"\"i .\n");
                Console.SetCursorPosition(x, y + 7); Console.Write("         |\"\"\"\"-.  -'    '.     /`    ' -------.j__      | |\n");
                Console.SetCursorPosition(x, y + 8); Console.Write("     .,--------        / \\    j  L      `=..-\"\"----'    | |\n");
                Console.SetCursorPosition(x, y + 9); Console.Write("           ,-_,.-     j   L | |   .     `-..){-.__       | |\n");
                Console.SetCursorPosition(x, y + 10); Console.Write("        ,++-.  |      |   /-+-|   |       | `\"-._`._    | |\n");
                Console.SetCursorPosition(x, y + 11); Console.Write("      .+\"\" '- .'      L  j  | L   j       | L    `-.`.  F-|\n");
                Console.SetCursorPosition(x, y + 12); Console.Write("    ,'    .-) `,       \\_/     \\ /        j  \\       ` /-.|\n");
                Console.SetCursorPosition(x, y + 13); Console.Write("   '        |  .        `.......-        /   j_       j  j\n");
                Console.SetCursorPosition(x, y + 14); Console.Write("         .--|  ,\\_                      ,'\". / )     ,^-.|\n");
                Console.SetCursorPosition(x, y + 15); Console.Write("          `.`,-                        /  / / ,`._  ,.   F\n");
                Console.SetCursorPosition(x, y + 16); Console.Write("       \"\"\"| '  .'`.'                   `-'\\ \"'  \\ \\,  \\ /\n");
                Console.SetCursorPosition(x, y + 17); Console.Write("      | j`.    |     . ,. .,..  ,_  .     `...-.| |.  ,'\n");
                Console.SetCursorPosition(x, y + 18); Console.Write("      `-'  /\"\"/    ,' .' \\ '  `/. `-       Y   |`\"  `/\n");
                Console.SetCursorPosition(x, y + 19); Console.Write("          j  /'                             .  | \\ ,'\n");
                Console.SetCursorPosition(x, y + 20); Console.Write("           \\ \\                              |  | ,'\n");
                Console.SetCursorPosition(x, y + 21); Console.Write("           ' '                              j j-'\n");
                Console.SetCursorPosition(x, y + 22); Console.Write("            `.\\                            ,.'\n");
                Console.SetCursorPosition(x, y + 23); Console.Write("            _+.`.                       _.,---.._    _\n");
                Console.SetCursorPosition(x, y + 24); Console.Write("   ,-\"\"--.,'   `--.._              ,){){`\"-        '\"\"' -.\n");
                Console.SetCursorPosition(x, y + 25); Console.Write(" .'  _..--          ,`\"`--------\"\"'  `._    ....<\"\"`-\",.'\n");
                Console.SetCursorPosition(x, y + 26); Console.Write(" `-\"'   _,-\"\"'  _,-'                    `-..__   v._  `.\n");
                Console.SetCursorPosition(x, y + 27); Console.Write("   / ,-'/  _,-`'                              `-. \\ `-.|\n");
                Console.SetCursorPosition(x, y + 28); Console.Write("   -'  |_,'                                      \"' \n");
            }

            else if (pokenumber == 21)
            {
                Console.SetCursorPosition(x, y); Console.Write("               _,\n");
                Console.SetCursorPosition(x, y + 1); Console.Write("             .'.'  _.\n");
                Console.SetCursorPosition(x, y + 2); Console.Write("           ,' ._,-'_\"'\n");
                Console.SetCursorPosition(x, y + 3); Console.Write("        _,'   '  ------\"\"'`._\n");
                Console.SetCursorPosition(x, y + 4); Console.Write("      ,'                 _,.--\"'              ___        __,..\n");
                Console.SetCursorPosition(x, y + 5); Console.Write("      |    _,..       ,-'             _,.--\"\"'   7_,.--\"'    ,'\n");
                Console.SetCursorPosition(x, y + 6); Console.Write("      j. .'D  |       |            ,'\"       _.-'       _.-\"\"'.  _,..-\"'\n");
                Console.SetCursorPosition(x, y + 7); Console.Write(" ,---'  `+----'       |`._      _.'         '                '.-'      /\n");
                Console.SetCursorPosition(x, y + 8); Console.Write("j         `.       ,-'    `'--,\"                           ,'       ,-'\n");
                Console.SetCursorPosition(x, y + 9); Console.Write("|    __    |      '-.._,    .'                           ,'     ,.-'\n");
                Console.SetCursorPosition(x, y + 10); Console.Write("`. ,' ('T--'        .\"     /                          _.'  _,--\"\n");
                Console.SetCursorPosition(x, y + 11); Console.Write("  `   `,  /         _`.   j                         _', ,-\"__,..,-.\n");
                Console.SetCursorPosition(x, y + 12); Console.Write("      `-\"`.        \\   `-.|                        _,'\"\"\"\"'       l\n");
                Console.SetCursorPosition(x, y + 13); Console.Write("           `.,      \\     L                     _.'      __,...--'\n");
                Console.SetCursorPosition(x, y + 14); Console.Write("            ` '-    .`     `._             _,.-' ,--'\"\"\"\"\n");
                Console.SetCursorPosition(x, y + 15); Console.Write("             '  \\`.,\\         `+------,--\"'     /\n");
                Console.SetCursorPosition(x, y + 16); Console.Write("                 \\ )`'      ,-'      /         /\n");
                Console.SetCursorPosition(x, y + 17); Console.Write("                  `     _,-'       ,'         /\n");
                Console.SetCursorPosition(x, y + 18); Console.Write("                   `+\"\"'         ,'     ,.  ,'\n");
                Console.SetCursorPosition(x, y + 19); Console.Write("                     `.        ,'     ,'   .\n");
                Console.SetCursorPosition(x, y + 20); Console.Write("                       `-._.,-'      /. _.,j\n");
                Console.SetCursorPosition(x, y + 21); Console.Write("                           \"\"`-----.'  '  /\n");
                Console.SetCursorPosition(x, y + 22); Console.Write("                                / /   /  /\n");
                Console.SetCursorPosition(x, y + 23); Console.Write("                    _.......__,' /__,' ,'\n");
                Console.SetCursorPosition(x, y + 24); Console.Write("                  ,\\  ,--..--------\"_  ...._\n");
                Console.SetCursorPosition(x, y + 25); Console.Write("                 '--\"(_,`|  ,..-' _,....__  |.\n");
                Console.SetCursorPosition(x, y + 26); Console.Write("                        '-./...-'\"        `\"\"\"- \n");
            }

            else if (pokenumber == 22)
            {
                Console.SetCursorPosition(x, y); Console.Write("    ,---...__     ,.._\n");
                Console.SetCursorPosition(x, y + 1); Console.Write("  .\"\"\"_...   \"\"---\\.,_`\"-._                    __,..._\n");
                Console.SetCursorPosition(x, y + 2); Console.Write(" ,--   \"\"\"\"\"\"){--..    \"-   `-._ _,.        ,-\"\" ..----'\"\"\",\n");
                Console.SetCursorPosition(x, y + 3); Console.Write("`---........_____ ._     `-._  `. |       / /'      '\"\"\"\"-----.\n");
                Console.SetCursorPosition(x, y + 4); Console.Write("\\\"'\"\"\"\"\"\"''\"\"\"'\"-`           `-. `.      / j     .\\ |\\   -.,){,- .\n");
                Console.SetCursorPosition(x, y + 5); Console.Write(" `-.......___     `._           \\  \\    ]\\ |   . |L ||/\\   `. ` .`.\n");
                Console.SetCursorPosition(x, y + 6); Console.Write("         __,..==--'/ '           \\  L  A|,'|    \\| |||||  ` .`.. -._\n");
                Console.SetCursorPosition(x, y + 7); Console.Write("    .--\"\"          `.             L | j  /'\"-.__\\V '/|||   | `. `._ `.\n");
                Console.SetCursorPosition(x, y + 8); Console.Write("      `....----_..-`\"`/.          | | | j   __ `._   | |'_`.\\  `.  `. |\n");
                Console.SetCursorPosition(x, y + 9); Console.Write("            -\"'       \\           | `_|.   l  `.  `.   |||   ` | `   \\'\n");
                Console.SetCursorPosition(x, y + 10); Console.Write("            `-._,...-\"\"\\-         |        |    .   /`.  \\  ..Y   `.  \\\n");
                Console.SetCursorPosition(x, y + 11); Console.Write("               `-..,'  .`         '         L \\  .  `--\"`.`.`|  .   \\  |\n");
                Console.SetCursorPosition(x, y + 12); Console.Write("                  \\  ,'  `|     ,'          .\\ +-'-...-^._`. | |..  ,\\ '\n");
                Console.SetCursorPosition(x, y + 13); Console.Write("                   `\\     `.._ j             /\"       \\  |\\ `..- `.'- `\n");
                Console.SetCursorPosition(x, y + 14); Console.Write("                    `. ,' | .  |           .'          \\ | `._`.\n");
                Console.SetCursorPosition(x, y + 15); Console.Write("                      +   | | j           /             `'    `.`.\n");
                Console.SetCursorPosition(x, y + 16); Console.Write("                       `.+._j_'      __..)                      `..\n");
                Console.SetCursorPosition(x, y + 17); Console.Write("                        _,-'   .,   j ` .'\"\"`--.                  `\n");
                Console.SetCursorPosition(x, y + 18); Console.Write("                     _.' .-'  /,'`\"-.  ,` .\\ \\` `\n");
                Console.SetCursorPosition(x, y + 19); Console.Write("                   ,'  .' / /`,'    ||'` ,'`T|.`-|\n");
                Console.SetCursorPosition(x, y + 20); Console.Write("                 ___,'/_,._/        L|   . |'-'\\\"\n");
                Console.SetCursorPosition(x, y + 21); Console.Write("                                    `-   ||    ' \n");
            }

            else if (pokenumber == 23)
            {
                Console.SetCursorPosition(x, y); Console.Write("        _,--\"\"'\"\"\"-.\n");
                Console.SetCursorPosition(x, y + 1); Console.Write("      ,'   .,-.     `.\n");
                Console.SetCursorPosition(x, y + 2); Console.Write("     '`...( |  |      \\\n");
                Console.SetCursorPosition(x, y + 3); Console.Write("    |      `--'        .\n");
                Console.SetCursorPosition(x, y + 4); Console.Write("    '_,...__,'          `\n");
                Console.SetCursorPosition(x, y + 5); Console.Write("     `._                 `\n");
                Console.SetCursorPosition(x, y + 6); Console.Write("        `..______         |\n");
                Console.SetCursorPosition(x, y + 7); Console.Write("             |.          ,|\n");
                Console.SetCursorPosition(x, y + 8); Console.Write("             | `-.....,-\" |\n");
                Console.SetCursorPosition(x, y + 9); Console.Write("             |            j\n");
                Console.SetCursorPosition(x, y + 10); Console.Write("             ^.         _F\n");
                Console.SetCursorPosition(x, y + 11); Console.Write("            /  `-.....-'/\n");
                Console.SetCursorPosition(x, y + 12); Console.Write("           /          ,'\n");
                Console.SetCursorPosition(x, y + 13); Console.Write("          /          /\n");
                Console.SetCursorPosition(x, y + 14); Console.Write("         /          /\n");
                Console.SetCursorPosition(x, y + 15); Console.Write("        j       _.-- .\n");
                Console.SetCursorPosition(x, y + 16); Console.Write("        |      /     ,+---....___\n");
                Console.SetCursorPosition(x, y + 17); Console.Write("        L     /     /            \"\"`-.._\n");
                Console.SetCursorPosition(x, y + 18); Console.Write("         \\   j     j                    `-.\n");
                Console.SetCursorPosition(x, y + 19); Console.Write("          `. |     |            .'         `\n");
                Console.SetCursorPosition(x, y + 20); Console.Write("            `+...__|__       .,+-..         |\n");
                Console.SetCursorPosition(x, y + 21); Console.Write("                      \"\"`._.l      `.       j\n");
                Console.SetCursorPosition(x, y + 22); Console.Write("                      ,.-\"   \"-.     L    ,'\n");
                Console.SetCursorPosition(x, y + 23); Console.Write("                    ,'          L    ){ _.'\n");
                Console.SetCursorPosition(x, y + 24); Console.Write("                   /            |   _){'\n");
                Console.SetCursorPosition(x, y + 25); Console.Write("                  .            .|,-'\n");
                Console.SetCursorPosition(x, y + 26); Console.Write("                   .            `.._\n");
                Console.SetCursorPosition(x, y + 27); Console.Write("   '\\               `-.             `\"-.\n");
                Console.SetCursorPosition(x, y + 28); Console.Write(" ,`.'                  `-.              L\n");
                Console.SetCursorPosition(x, y + 29); Console.Write(" |  )                     `-. _...__     |\n");
                Console.SetCursorPosition(x, y + 30); Console.Write(".'-'                         )      `.   j\n");
                Console.SetCursorPosition(x, y + 31); Console.Write("|  |_                      _,'\"\"`.    \\ /\n");
                Console.SetCursorPosition(x, y + 32); Console.Write(" .-' `+._               _,\"       `.  |/\n");
                Console.SetCursorPosition(x, y + 33); Console.Write("  \\   |  \"`,,,,,....---'           | .'\n");
                Console.SetCursorPosition(x, y + 34); Console.Write("   `-.'   /                        |+\n");
                Console.SetCursorPosition(x, y + 35); Console.Write("      `--+                     _.-'\n");
                Console.SetCursorPosition(x, y + 36); Console.Write("          `--.___       __.---'\n");
                Console.SetCursorPosition(x, y + 37); Console.Write("                 `\"\"\"\"\"\" \n");
            }

            else if (pokenumber == 24)
            {
                Console.SetCursorPosition(x, y); Console.Write("                   _,.----'\"\"\"'---..._\n");
                Console.SetCursorPosition(x, y + 1); Console.Write("              _,-'\"                   `-..\n");
                Console.SetCursorPosition(x, y + 2); Console.Write("           _,'                            `-.\n");
                Console.SetCursorPosition(x, y + 3); Console.Write("         ,'                                  `-.\n");
                Console.SetCursorPosition(x, y + 4); Console.Write("       ,'                                _,..._ `.\n");
                Console.SetCursorPosition(x, y + 5); Console.Write("      /                               ,.\"     `){- L\n");
                Console.SetCursorPosition(x, y + 6); Console.Write("    ,'                             |.'         / ||\n");
                Console.SetCursorPosition(x, y + 7); Console.Write("   /            _,.-._             L        .-' -,'\n");
                Console.SetCursorPosition(x, y + 8); Console.Write("  /        _,.-\"      `.            `     __   .'\n");
                Console.SetCursorPosition(x, y + 9); Console.Write(" j      _,\"           ||\\|           `. ,-  _.'\n");
                Console.SetCursorPosition(x, y + 10); Console.Write(".     ,' `-..________.-' |            |' ,-'\n");
                Console.SetCursorPosition(x, y + 11); Console.Write("|   .' `--,.___       _,'| /`.        ` '\n");
                Console.SetCursorPosition(x, y + 12); Console.Write("|   |     `._  '\"\"\"\"\"'   . `_Y.        Y_\n");
                Console.SetCursorPosition(x, y + 13); Console.Write("`._          `-...__      `.`-'        | `-,...___\n");
                Console.SetCursorPosition(x, y + 14); Console.Write("   ``-,.._          `\"\"--.._`.         |  /     _,+`-._\n");
                Console.SetCursorPosition(x, y + 15); Console.Write("    .'    '--._             `-+      _ |./    ,\"       \\\n");
                Console.SetCursorPosition(x, y + 16); Console.Write("   ,  _,...._  `..             `-.){L_,v-'\"`-./_____     L\n");
                Console.SetCursorPosition(x, y + 17); Console.Write("  .,-\"       `-.| `,                )/       \\     \"`   |\n");
                Console.SetCursorPosition(x, y + 18); Console.Write("  j             |  \\`\\       _,......|       |       `  |\n");
                Console.SetCursorPosition(x, y + 19); Console.Write("  |       _,.---^.v[\\_   _,-'        |       |        \\ '\n");
                Console.SetCursorPosition(x, y + 20); Console.Write("  |     ,\"       _>.. \"\"\"            |       |        _V\n");
                Console.SetCursorPosition(x, y + 21); Console.Write("  '    .        /  |'`\\              |.._   ,'     _,'\n");
                Console.SetCursorPosition(x, y + 22); Console.Write("   .  j       ,'    |  `._           |   `\"\"-----\"'\n");
                Console.SetCursorPosition(x, y + 23); Console.Write("    \\ |      j      '     `--..,,,..j\n");
                Console.SetCursorPosition(x, y + 24); Console.Write("     Y       |       \\             /\n");
                Console.SetCursorPosition(x, y + 25); Console.Write("      `.     |        \\           /\n");
                Console.SetCursorPosition(x, y + 26); Console.Write("        `.   `         `.      _,'\n");
                Console.SetCursorPosition(x, y + 27); Console.Write("          `._ `.         `--..'\n");
                Console.SetCursorPosition(x, y + 28); Console.Write("             `---...,,,...-\"' \n");
                Console.SetCursorPosition(x, y + 29); Console.Write("\n");
            }

            else if (pokenumber == 25)
            {
                Console.SetCursorPosition(x, y); Console.Write("                                             ,-.\n");
                Console.SetCursorPosition(x, y + 1); Console.Write("                                          _.|  '\n");
                Console.SetCursorPosition(x, y + 2); Console.Write("                                        .'  | /\n");
                Console.SetCursorPosition(x, y + 3); Console.Write("                                      ,'    |'\n");
                Console.SetCursorPosition(x, y + 4); Console.Write("                                     /      /\n");
                Console.SetCursorPosition(x, y + 5); Console.Write("                       _..----\"\"---.'      /\n");
                Console.SetCursorPosition(x, y + 6); Console.Write(" _.....---------...,-\"\"                  ,'\n");
                Console.SetCursorPosition(x, y + 7); Console.Write(" `-._  \\                                /\n");
                Console.SetCursorPosition(x, y + 8); Console.Write("     `-.+_            __           ,--. .\n");
                Console.SetCursorPosition(x, y + 9); Console.Write("          `-.._     .){  ).        (`--\"| \\\n");
                Console.SetCursorPosition(x, y + 10); Console.Write("               7    | `\" |         `...'  \\\n");
                Console.SetCursorPosition(x, y + 11); Console.Write("               |     `--'     '+\"        ,\". ,\"\"-\n");
                Console.SetCursorPosition(x, y + 12); Console.Write("               |   _...        .____     | |/    '\n");
                Console.SetCursorPosition(x, y + 13); Console.Write("          _.   |  .    `.  '--\"   /      `./     j\n");
                Console.SetCursorPosition(x, y + 14); Console.Write("         \\' `-.|  '     |   `.   /        /     /\n");
                Console.SetCursorPosition(x, y + 15); Console.Write("         '     `-. `---\"      `-\"        /     /\n");
                Console.SetCursorPosition(x, y + 16); Console.Write("          \\       `.                  _,'     /\n");
                Console.SetCursorPosition(x, y + 17); Console.Write("           \\        `                        .\n");
                Console.SetCursorPosition(x, y + 18); Console.Write("            \\                                j\n");
                Console.SetCursorPosition(x, y + 19); Console.Write("             \\                              /\n");
                Console.SetCursorPosition(x, y + 20); Console.Write("              `.                           .\n");
                Console.SetCursorPosition(x, y + 21); Console.Write("                +                          \\\n");
                Console.SetCursorPosition(x, y + 22); Console.Write("                |                           L\n");
                Console.SetCursorPosition(x, y + 23); Console.Write("                |                           |\n");
                Console.SetCursorPosition(x, y + 24); Console.Write("                |  _ /,                     |\n");
                Console.SetCursorPosition(x, y + 25); Console.Write("                | | L)'..                   |\n");
                Console.SetCursorPosition(x, y + 26); Console.Write("                | .    | `                  |\n");
                Console.SetCursorPosition(x, y + 27); Console.Write("                '  \\'   L                   '\n");
                Console.SetCursorPosition(x, y + 28); Console.Write("                 \\  \\   |                  j\n");
                Console.SetCursorPosition(x, y + 29); Console.Write("                  `. `__'                 /\n");
                Console.SetCursorPosition(x, y + 30); Console.Write("                _,.--.---........__      /\n");
                Console.SetCursorPosition(x, y + 31); Console.Write("               ---.,'---`         |   -j\"\n");
                Console.SetCursorPosition(x, y + 32); Console.Write("                .-'  '....__      L    |\n");
                Console.SetCursorPosition(x, y + 33); Console.Write("              \"\"--..    _,-'       \\ l||\n");
                Console.SetCursorPosition(x, y + 34); Console.Write("                  ,-'  .....------. `||'\n");
                Console.SetCursorPosition(x, y + 35); Console.Write("               _,'                /\n");
                Console.SetCursorPosition(x, y + 36); Console.Write("             ,'                  /\n");
                Console.SetCursorPosition(x, y + 37); Console.Write("            '---------+-        /\n");
                Console.SetCursorPosition(x, y + 38); Console.Write("                     /         /\n");
                Console.SetCursorPosition(x, y + 39); Console.Write("                   .'         /\n");
                Console.SetCursorPosition(x, y + 40); Console.Write("                 .'          /\n");
                Console.SetCursorPosition(x, y + 41); Console.Write("               ,'           /\n");
                Console.SetCursorPosition(x, y + 42); Console.Write("             _'....----\"\"\"\"\" \n");
            }

            else if (pokenumber == 26)
            {
                Console.SetCursorPosition(x, y); Console.Write("                                        _,--\"\"`---...__\n");
                Console.SetCursorPosition(x, y + 1); Console.Write("                            _.---\"\"\"\"`-'.   .-\"\"\"'`-.._`-._\n");
                Console.SetCursorPosition(x, y + 2); Console.Write("                _,.-----.,-\"         .\". `-.           \"---`.\n");
                Console.SetCursorPosition(x, y + 3); Console.Write("             _,' _,.-..,'__          `.'  ,-`...._      ,\"\"''`-.\n");
                Console.SetCursorPosition(x, y + 4); Console.Write("           ,' ,-'     / (  .   ,-.       |    `.  `-._  .       `.\n");
                Console.SetCursorPosition(x, y + 5); Console.Write("         ,',-\"       /   `\"    `\"'       '      .    _`. \\\n");
                Console.SetCursorPosition(x, y + 6); Console.Write("       ,','       ,-'7--.                 `.__.\"|   ( ` `j\n");
                Console.SetCursorPosition(x, y + 7); Console.Write("      '.){--.    ,'   |   .       |\\             '    `--'\n");
                Console.SetCursorPosition(x, y + 8); Console.Write("     /.     | ,'     |   |       `'            .\n");
                Console.SetCursorPosition(x, y + 9); Console.Write("    '       |',\".    |._,'                     `      _.--\"\"\"\"\"-._\n");
                Console.SetCursorPosition(x, y + 10); Console.Write("'.          `-..'    `.                      ,  \\  ,-' _.-\"\"\"\"\"-. `.\n");
                Console.SetCursorPosition(x, y + 11); Console.Write("` `                   F  -.                 /    ,' .-'          `  `\n");
                Console.SetCursorPosition(x, y + 12); Console.Write(" \\ `                 j     `.              ,-.   . /               . `\n");
                Console.SetCursorPosition(x, y + 13); Console.Write("    `.               |     .-`.           .  '-.  V                 . `\n");
                Console.SetCursorPosition(x, y + 14); Console.Write("  `   `.      .      | .    \\  \\         j      \\/|                  ' .\n");
                Console.SetCursorPosition(x, y + 15); Console.Write("   .    `.    |`.    |-.`._/`   .        |    ,'  A                  | |\n");
                Console.SetCursorPosition(x, y + 16); Console.Write("    \\     `. F   \\   |--`  \"._  |        `-.-\"   / .                 | |\n");
                Console.SetCursorPosition(x, y + 17); Console.Write("     \\      -'    `. |        `\"'                  |                 F '\n");
                Console.SetCursorPosition(x, y + 18); Console.Write("      \\             `+`.                           |                / .\n");
                Console.SetCursorPosition(x, y + 19); Console.Write("       \\              .-`                     .    j               / ,\n");
                Console.SetCursorPosition(x, y + 20); Console.Write("        \\              \\   `.               .'    /               ' .\n");
                Console.SetCursorPosition(x, y + 21); Console.Write("         \\       |`._   \\    `-.._        ,'    ,'              ,'.'\n");
                Console.SetCursorPosition(x, y + 22); Console.Write("          '      |   `.  `.       `<`\"\"\"\"'    .'             _,'.'\n");
                Console.SetCursorPosition(x, y + 23); Console.Write("           `     |     `-. `._      )   `.     .          _.'_.'\n");
                Console.SetCursorPosition(x, y + 24); Console.Write("            `    |        `--/     /`-._  .     `.___..--'_.\"\n");
                Console.SetCursorPosition(x, y + 25); Console.Write("             `   |          /     /._   `\"\"`.     `. _,.-\"\n");
                Console.SetCursorPosition(x, y + 26); Console.Write("              `  |         /     /   `--.....`.     `._\n");
                Console.SetCursorPosition(x, y + 27); Console.Write("               ` |       ,'     /              .\"\"\"\"'  `.\n");
                Console.SetCursorPosition(x, y + 28); Console.Write("                `'      , `-..,7                `    . `.`.\n");
                Console.SetCursorPosition(x, y + 29); Console.Write("                       .       '                 `.   \\  `v\n");
                Console.SetCursorPosition(x, y + 30); Console.Write("                      j.  ,   /                    `.._L_.'\n");
                Console.SetCursorPosition(x, y + 31); Console.Write("                      || .   /\n");
                Console.SetCursorPosition(x, y + 32); Console.Write("                      `\"-'__/ \n");
                Console.SetCursorPosition(x, y + 33); Console.Write("\n");
                Console.SetCursorPosition(x, y + 34); Console.Write("\n");
            }

            else if (pokenumber == 27)
            {
                Console.SetCursorPosition(x, y); Console.Write("          _...-----'`._\n");
                Console.SetCursorPosition(x, y + 1); Console.Write("      _,-'   _`. .\"\". \\`._\n");
                Console.SetCursorPosition(x, y + 2); Console.Write("    ,'    ,-'   ` ` |  \\/--.\n");
                Console.SetCursorPosition(x, y + 3); Console.Write("  ,){_  ,-'       ` `|  |`.  `.\n");
                Console.SetCursorPosition(x, y + 4); Console.Write(" /   `'-..        `  .-'  `   \\\n");
                Console.SetCursorPosition(x, y + 5); Console.Write("j         `.--,    \\       `   ){\n");
                Console.SetCursorPosition(x, y + 6); Console.Write("|         '--' |    \\       `._'-.\n");
                Console.SetCursorPosition(x, y + 7); Console.Write("|___     |     |     L      .'    `.\n");
                Console.SetCursorPosition(x, y + 8); Console.Write("|   `-. /|___.' `.   |    .'.       .\n");
                Console.SetCursorPosition(x, y + 9); Console.Write("|     ,'          .  j.  /   `.      \\\n");
                Console.SetCursorPosition(x, y + 10); Console.Write(".  _,'            |,'  `.      \\   ,<`.\n");
                Console.SetCursorPosition(x, y + 11); Console.Write(" .'             _.-      `      j.'  \\ \\                          ,.\n");
                Console.SetCursorPosition(x, y + 12); Console.Write("  `       ,v-\"\"'   \\      )__,+'      . \\                       ,' |\n");
                Console.SetCursorPosition(x, y + 13); Console.Write("   `.    / |  /  _,'`.  ,'  \\  \\       /`.                   _.){   |\n");
                Console.SetCursorPosition(x, y + 14); Console.Write("     `,-'-`  / ,'     \\'    j,  \\   ,.'   L               ,-'   . F\n");
                Console.SetCursorPosition(x, y + 15); Console.Write("     / ,. | / .        \\  .'     \\.-\\     |         _,.-\"`.     `,'\n");
                Console.SetCursorPosition(x, y + 16); Console.Write("     (_\\/|'|   \\        .'   _,-\"    `    +....---+'       `     '\n");
                Console.SetCursorPosition(x, y + 17); Console.Write("     . \\ |.     \\    ,.^---`<_        | ,'||       \\        \\   /\n");
                Console.SetCursorPosition(x, y + 18); Console.Write("      `.'| \\_    ){v-'         `.      |-  | \\ __..--\\     _,'\\,'\n");
                Console.SetCursorPosition(x, y + 19); Console.Write("        `'/`----'/              '.  ,'    |  Y       L_,-'  ,'\n");
                Console.SetCursorPosition(x, y + 20); Console.Write("          \\     /            ___,.'\\     j   |       |    .'\n");
                Console.SetCursorPosition(x, y + 21); Console.Write("           \\   .\"`\",\"\"'\"\"\"'\"`     | .   .'   |       |  ,'\n");
                Console.SetCursorPosition(x, y + 22); Console.Write("            \\  |   |         |    | | .' j,.-|       j-'\n");
                Console.SetCursorPosition(x, y + 23); Console.Write("             `. ___|________/.....|_Y'  /    |   _.-'\n");
                Console.SetCursorPosition(x, y + 24); Console.Write("          __,-' \\                 |    /    _j,-'\n");
                Console.SetCursorPosition(x, y + 25); Console.Write("         '--.    .                `...+---\"\"\n");
                Console.SetCursorPosition(x, y + 26); Console.Write("        `_____\\  _`..__    __,..-\"'\n");
                Console.SetCursorPosition(x, y + 27); Console.Write("              .-'_|._  `\"\"\"       \\\n");
                Console.SetCursorPosition(x, y + 28); Console.Write("             , -'    .          __/\n");
                Console.SetCursorPosition(x, y + 29); Console.Write("             \"------------\"\"\"\"\"\" \n");
                Console.SetCursorPosition(x, y + 30); Console.Write("\n");
            }

            else if (pokenumber == 28)
            {
                Console.SetCursorPosition(x, y); Console.Write("                    ,\\\n");
                Console.SetCursorPosition(x, y + 1); Console.Write("                _,-'.+..----\"/_____\n");
                Console.SetCursorPosition(x, y + 2); Console.Write("             _,'---,        /      `\"\",\n");
                Console.SetCursorPosition(x, y + 3); Console.Write("           .'    ,'  __..../_     _,-'\n");
                Console.SetCursorPosition(x, y + 4); Console.Write("          /    ,' ,-\"       ,'---+--...__\n");
                Console.SetCursorPosition(x, y + 5); Console.Write("        ,'   ----'        ,'             `\"\n");
                Console.SetCursorPosition(x, y + 6); Console.Write("       '                ,'     ______  ,-\"`-._\n");
                Console.SetCursorPosition(x, y + 7); Console.Write("      /  ,+\"\"\",   ....-^--..<\"\"      ``-._    `-.\n");
                Console.SetCursorPosition(x, y + 8); Console.Write("    ,' .'-'  /      |        `._          `-.   _`-\n");
                Console.SetCursorPosition(x, y + 9); Console.Write("   /    `\"\"\"'       `           `.           `,\"\n");
                Console.SetCursorPosition(x, y + 10); Console.Write("  |                  `.           `.      ,-'\"--.\n");
                Console.SetCursorPosition(x, y + 11); Console.Write("  '               ,-   `._ ,-\"\"\"`.__){---\"\"'-._   `._\n");
                Console.SetCursorPosition(x, y + 12); Console.Write("   `-----..__  _,'     .-\".       `._         `.    `.\n");
                Console.SetCursorPosition(x, y + 13); Console.Write("   /________.'\"/      /  j         | `-._       `.    `.\n");
                Console.SetCursorPosition(x, y + 14); Console.Write("\\`-.`.__    )_/__    ._,-|         |     `.       `.\"\"\"'\n");
                Console.SetCursorPosition(x, y + 15); Console.Write(" .      `\"\"\"\"j   `\"\"`'   |         |       `.       `.\n");
                Console.SetCursorPosition(x, y + 16); Console.Write(" \\`._       /            L         '         `.....---\n");
                Console.SetCursorPosition(x, y + 17); Console.Write("  `  `..___'              \\      ,\"            .   `.\n");
                Console.SetCursorPosition(x, y + 18); Console.Write("   `.     `              _.\\ _.-\" `-._          `.   `.\n");
                Console.SetCursorPosition(x, y + 19); Console.Write("     `-._  \\         _,-\"-. '|        .`-.-\"\"\"\"``\\     `.\n");
                Console.SetCursorPosition(x, y + 20); Console.Write("         `\"-^'   _.-'        |         \\  `.      `---...-\n");
                Console.SetCursorPosition(x, y + 21); Console.Write("              \\.\"            |          L   `.     `.\n");
                Console.SetCursorPosition(x, y + 22); Console.Write("              /              `          |     \\      `.\n");
                Console.SetCursorPosition(x, y + 23); Console.Write("             j                `.        |      `,....__`\n");
                Console.SetCursorPosition(x, y + 24); Console.Write("             |                  \\       |       `   \\\n");
                Console.SetCursorPosition(x, y + 25); Console.Write("              .                  .      F        \\   `.\n");
                Console.SetCursorPosition(x, y + 26); Console.Write("      _,...,---`.                 `.   j `.       L--..`\n");
                Console.SetCursorPosition(x, y + 27); Console.Write("    ,\",.--\"'-.   -.                _`. |   `._    .\n");
                Console.SetCursorPosition(x, y + 28); Console.Write("    ,'        \\_.--`._     ,----.-<.  V       `-._ ._\n");
                Console.SetCursorPosition(x, y + 29); Console.Write("   /.---\"\".-\"\"\" )     `\"\"\"'      `. `-.._         `' `._\n");
                Console.SetCursorPosition(x, y + 30); Console.Write("        ,' _.-\"\"\"\"`.               |     `\"-..__        `-.\n");
                Console.SetCursorPosition(x, y + 31); Console.Write("        '\"\"         \\         _,..-'            `\"\"----...-'\n");
                Console.SetCursorPosition(x, y + 32); Console.Write("         '-----------+---\"\"\"\"\" \n");
                Console.SetCursorPosition(x, y + 33); Console.Write("\n");
                Console.SetCursorPosition(x, y + 34); Console.Write("\n");
            }

            else if (pokenumber == 29)
            {
                Console.SetCursorPosition(x, y); Console.Write("        .'-.                            ,.. _,._\n");
                Console.SetCursorPosition(x, y + 1); Console.Write("  ,--\"\".`.  `.                        ,'  /'    `-.._\n");
                Console.SetCursorPosition(x, y + 2); Console.Write("  \\__   `-`   \\                     ,'  ,' _____     `-.\n");
                Console.SetCursorPosition(x, y + 3); Console.Write("     | ,-.._   \\                  ,'    _,'     \\   ___.'\n");
                Console.SetCursorPosition(x, y + 4); Console.Write("     j |    `   L               .'    ,'        |  |\n");
                Console.SetCursorPosition(x, y + 5); Console.Write("    . j      \\  |              /    ,'  ___     |  |\n");
                Console.SetCursorPosition(x, y + 6); Console.Write("    | |  .\"\"\"|  `    _,.--....'|   /-'\"\"   `.   |  '\n");
                Console.SetCursorPosition(x, y + 7); Console.Write("    |j  j    `   `-\"\"          '  '         |   | F\n");
                Console.SetCursorPosition(x, y + 8); Console.Write("    ||  |    ,'                   `         |   | |\n");
                Console.SetCursorPosition(x, y + 9); Console.Write("    |`. |   /      ,\"\".       .    \\        |   ' |\n");
                Console.SetCursorPosition(x, y + 10); Console.Write("    `  `.  /,\\     |   \\     / `    \\       |,-' F\n");
                Console.SetCursorPosition(x, y + 11); Console.Write("     `.  `/ | \\    '    .   /.  |    \\   _,-   ,-'\n");
                Console.SetCursorPosition(x, y + 12); Console.Write("       `-. j  |\\       \"   /.|  |     `\"\"__..-'\n");
                Console.SetCursorPosition(x, y + 13); Console.Write("        .' |_ |(`        ,' )|__'      `._____\n");
                Console.SetCursorPosition(x, y + 14); Console.Write(".-------'.   `-'-`       `--\"\"      \"\"\"\"\"__..-'\n");
                Console.SetCursorPosition(x, y + 15); Console.Write(" \"\"\"\"\"\"--.                           \"\"\"(\n");
                Console.SetCursorPosition(x, y + 16); Console.Write("     ___.'        .                 -----..._\n");
                Console.SetCursorPosition(x, y + 17); Console.Write("   .\"____..       '   -'              \"\"`----`_\n");
                Console.SetCursorPosition(x, y + 18); Console.Write("          `.     . _._   _,             ,. `./ |\n");
                Console.SetCursorPosition(x, y + 19); Console.Write("            >     `.  .\"\".              \\ |  \\ j\n");
                Console.SetCursorPosition(x, y + 20); Console.Write("           j       `.,'  /               \"'   Y\n");
                Console.SetCursorPosition(x, y + 21); Console.Write("          /          `..'                     |\n");
                Console.SetCursorPosition(x, y + 22); Console.Write("                                              |\n");
                Console.SetCursorPosition(x, y + 23); Console.Write("         .                             ,\"-.   |\n");
                Console.SetCursorPosition(x, y + 24); Console.Write("         |                             |   \\  |\n");
                Console.SetCursorPosition(x, y + 25); Console.Write("         |                             .   /  |\n");
                Console.SetCursorPosition(x, y + 26); Console.Write("         |                              `-'   |\n");
                Console.SetCursorPosition(x, y + 27); Console.Write("         |   `.                           ,   '\n");
                Console.SetCursorPosition(x, y + 28); Console.Write("         L     \\                      _  /   /.\n");
                Console.SetCursorPosition(x, y + 29); Console.Write("          \\     \\             |      ( `/  .'  `.\n");
                Console.SetCursorPosition(x, y + 30); Console.Write("           L     `.           |       \"/ _/    _|\n");
                Console.SetCursorPosition(x, y + 31); Console.Write("         _,|       -,_        |       j-'_._  ,  `.\n");
                Console.SetCursorPosition(x, y + 32); Console.Write("        '..|       (_.'--.._  L       |-+_  ..`.,.`\n");
                Console.SetCursorPosition(x, y + 33); Console.Write("           |      j         \"\" .    __|   `\"'\n");
                Console.SetCursorPosition(x, y + 34); Console.Write("           |,..__<             |\"`,\"  \\\n");
                Console.SetCursorPosition(x, y + 35); Console.Write("           | _,x..)            '-' --.'\n");
                Console.SetCursorPosition(x, y + 36); Console.Write("            \" \n");
            }

            else if (pokenumber == 30)
            {
                Console.SetCursorPosition(x, y); Console.Write("                           _            _\n");
                Console.SetCursorPosition(x, y + 1); Console.Write("                          / )  _  _,.-\"\" )\n");
                Console.SetCursorPosition(x, y + 2); Console.Write("                        ,' /..' /\"   _,+'--\"`.\n");
                Console.SetCursorPosition(x, y + 3); Console.Write("                       /     / j_.-\"'     ,-\"\n");
                Console.SetCursorPosition(x, y + 4); Console.Write("                     ,'    ,'       _____  `\n");
                Console.SetCursorPosition(x, y + 5); Console.Write("                   _+__   .     _.-'     \\  `...._\n");
                Console.SetCursorPosition(x, y + 6); Console.Write("              ,'\"\"\"    \"\"/  _.-'          .       \\\n");
                Console.SetCursorPosition(x, y + 7); Console.Write("            ,'          '  ',--'\"\"`-.      L   ,-\"\n");
                Console.SetCursorPosition(x, y + 8); Console.Write("          .\"              .'         \\     |  /\n");
                Console.SetCursorPosition(x, y + 9); Console.Write("        ,' _                          \\    | j      _\n");
                Console.SetCursorPosition(x, y + 10); Console.Write("       / ,'   _,+-'                 _,'   ,' /_,.-\"\" |\n");
                Console.SetCursorPosition(x, y + 11); Console.Write("    _.' '  .+'.  \\               ,-\"___..\"  -'      ,'\n");
                Console.SetCursorPosition(x, y + 12); Console.Write(" ,-\"     ,'-' |  |           .,-\"\"''___,..-'       /\n");
                Console.SetCursorPosition(x, y + 13); Console.Write("j        `\"\"\"\"---'             '\"'\"\"       ._    , _.--\".\n");
                Console.SetCursorPosition(x, y + 14); Console.Write("\\   ,                                        `- ' `._  ,'\n");
                Console.SetCursorPosition(x, y + 15); Console.Write(" \\                            _.-'            .\"`.   `-. ____...----\"\"`\n");
                Console.SetCursorPosition(x, y + 16); Console.Write("  `.-\"-._,..---+ +          ,'       `         `.'      `.             |\n");
                Console.SetCursorPosition(x, y + 17); Console.Write("      `.        \\/        ,'          |            ,.---. \\           .\n");
                Console.SetCursorPosition(x, y + 18); Console.Write("        `._               +__,...__   |     ,     |     |  L        .'\n");
                Console.SetCursorPosition(x, y + 19); Console.Write("           `--...-\"\"`-._   /       `,\"    ,'      `     |  |      ,'\n");
                Console.SetCursorPosition(x, y + 20); Console.Write("                     /  `./        /    ,'         \\    j  '    .'\n");
                Console.SetCursorPosition(x, y + 21); Console.Write("                    /    j        /    .       _    `._'     ,-'\n");
                Console.SetCursorPosition(x, y + 22); Console.Write("                   j     '       /     |     .\" `         ,-'\n");
                Console.SetCursorPosition(x, y + 23); Console.Write("                   |, .<(       '      `      \\_/       ,'\n");
                Console.SetCursorPosition(x, y + 24); Console.Write("                   |-...+.___,./`.______\\             ,'\n");
                Console.SetCursorPosition(x, y + 25); Console.Write("                   `.'`.' \\/  V /_/.___  `.  _     _,'\n");
                Console.SetCursorPosition(x, y + 26); Console.Write("                                `....\\_`,-\",' |,-./\n");
                Console.SetCursorPosition(x, y + 27); Console.Write("                                        `\"\"..-'---` \n");
            }

            else if (pokenumber == 31)
            {
                Console.SetCursorPosition(x, y); Console.Write("                                          .\"\n");
                Console.SetCursorPosition(x, y + 1); Console.Write("                                        ,'  |\n");
                Console.SetCursorPosition(x, y + 2); Console.Write("                                      _,... '.___\n");
                Console.SetCursorPosition(x, y + 3); Console.Write("                             +--._  ,'.-\"+.      \"`-.\n");
                Console.SetCursorPosition(x, y + 4); Console.Write("                         _,---\\   `\" / |p|.'     \"'   \\\n");
                Console.SetCursorPosition(x, y + 5); Console.Write("                       ,- _.---\".   |_,'      ,-\"\"\"\"-._|\n");
                Console.SetCursorPosition(x, y + 6); Console.Write("                     ,' ,.'    .'          ,-'        ,'\n");
                Console.SetCursorPosition(x, y + 7); Console.Write("                   ,' ,' |    .          .^---._      |\n");
                Console.SetCursorPosition(x, y + 8); Console.Write("            |. _  `. /   .    |   ,---.+'       `.    |\n");
                Console.SetCursorPosition(x, y + 9); Console.Write("           ,| | `/\\|.    `    |  .      `-.       .  /\n");
                Console.SetCursorPosition(x, y + 10); Console.Write("       .---. \"`-`.,\\ \\    `-.,'  |         `-._   | '\n");
                Console.SetCursorPosition(x, y + 11); Console.Write("        `.-'        , \"\"\"\"--'..-  \\            `--'.L\n");
                Console.SetCursorPosition(x, y + 12); Console.Write("          .          |`.     `     `._             _,'   .\n");
                Console.SetCursorPosition(x, y + 13); Console.Write("           `.        |  `.    |_,..   `-..______.-'  _,-| |. ,\"\\\n");
                Console.SetCursorPosition(x, y + 14); Console.Write("             -.     /     +--'/    `.            -,\"'   `\"  \".-'\n");
                Console.SetCursorPosition(x, y + 15); Console.Write("               `-+-'      |  /       `.        '\\ |           .L_\n");
                Console.SetCursorPosition(x, y + 16); Console.Write("           -\"--.,-`._..._,' j          `.     / | '           (_,'\n");
                Console.SetCursorPosition(x, y + 17); Console.Write("          `.    j.-'     `- |            \\   j  |  `.  _...___'\n");
                Console.SetCursorPosition(x, y + 18); Console.Write("            `. /__ ,...._  \\|             |  |  |...-`\"\n");
                Console.SetCursorPosition(x, y + 19); Console.Write("              j|  `      ,-/`.           /   `  ;.._\n");
                Console.SetCursorPosition(x, y + 20); Console.Write("          ,-. ||   |\"\"-.'  |  `..__,...-'     \\'    `.\n");
                Console.SetCursorPosition(x, y + 21); Console.Write("          `   |/`--    .  /|                  /----.__\\\n");
                Console.SetCursorPosition(x, y + 22); Console.Write("           \\  .         `' /                 /         \\\n");
                Console.SetCursorPosition(x, y + 23); Console.Write("            . |           ,`.              ,'     ___..+--.\n");
                Console.SetCursorPosition(x, y + 24); Console.Write("            +-|          /   `-..______..-\"     ,\"  `.   /___\n");
                Console.SetCursorPosition(x, y + 25); Console.Write("          ,'  |         j               .'    ,'      `\"|    /\n");
                Console.SetCursorPosition(x, y + 26); Console.Write("       ,-+    .         |`._          ,+_    /          `-..'\n");
                Console.SetCursorPosition(x, y + 27); Console.Write("   _.-'  |     `.      /    ``-----){='   `.,'         _,..'\n");
                Console.SetCursorPosition(x, y + 28); Console.Write(",-'      L       `-.--'         ,,'        |       ,-'\n");
                Console.SetCursorPosition(x, y + 29); Console.Write("\\_        \\         `._    _,.-'           `.___..'\n");
                Console.SetCursorPosition(x, y + 30); Console.Write("  `.._     `._      __.+'\"'\n");
                Console.SetCursorPosition(x, y + 31); Console.Write("      `---... +---\"\" \n");
            }

            else if (pokenumber == 32)
            {
                Console.SetCursorPosition(x, y); Console.Write("                  .\"\\                            _\n");
                Console.SetCursorPosition(x, y + 1); Console.Write("                  | |  ,.                    _,-\" /\n");
                Console.SetCursorPosition(x, y + 2); Console.Write("                  j `-' /                 _.'   /..\n");
                Console.SetCursorPosition(x, y + 3); Console.Write("                ,'     |                ,'   _..  |\n");
                Console.SetCursorPosition(x, y + 4); Console.Write("               /       `.          .\"','  ,-'   \\ `...\n");
                Console.SetCursorPosition(x, y + 5); Console.Write("             .'          \\       ,' ,' ,-'      |   _/\n");
                Console.SetCursorPosition(x, y + 6); Console.Write("            /             \\     /    ,'         |  |\n");
                Console.SetCursorPosition(x, y + 7); Console.Write("           /               `.  /    /           |  '\n");
                Console.SetCursorPosition(x, y + 8); Console.Write("          |                  `/    /            | `.\n");
                Console.SetCursorPosition(x, y + 9); Console.Write("       .-.`                  /   ,'            j   |        _\n");
                Console.SetCursorPosition(x, y + 10); Console.Write("       \\                   /V   /              |  ,'     ,-' |\n");
                Console.SetCursorPosition(x, y + 11); Console.Write("        .                _/    /               | /    ,-'   /\n");
                Console.SetCursorPosition(x, y + 12); Console.Write("        |               |    ,'               j / _.-'    ,'\n");
                Console.SetCursorPosition(x, y + 13); Console.Write("        |               |   /                 ' \"\"       /\n");
                Console.SetCursorPosition(x, y + 14); Console.Write("     `\"--               |  /                  |        ,'  _,..-.\n");
                Console.SetCursorPosition(x, y + 15); Console.Write("      \\                 | j                  .'       ---\"'     /\n");
                Console.SetCursorPosition(x, y + 16); Console.Write("       \\               j  |                  /                ,'\n");
                Console.SetCursorPosition(x, y + 17); Console.Write("        \\       __...--.  |                 /_..-----.       /\n");
                Console.SetCursorPosition(x, y + 18); Console.Write("         \\   ,\"\"       |  |   _.           /        /      ,'\n");
                Console.SetCursorPosition(x, y + 19); Console.Write("          . /          |  |  /  |        ,'        /      /\n");
                Console.SetCursorPosition(x, y + 20); Console.Write("           Y           |  |.'   F    _,-'         /__,._ `.......\n");
                Console.SetCursorPosition(x, y + 21); Console.Write("        _,'               '    / _.+'   ,-\"\"-.        .'       ,'\n");
                Console.SetCursorPosition(x, y + 22); Console.Write("    _.-'                      `-'| |   ,      .       -._   ,-'\n");
                Console.SetCursorPosition(x, y + 23); Console.Write("_.-'                  .\"\\        | |    ._   ,'         / .'\n");
                Console.SetCursorPosition(x, y + 24); Console.Write(" `\"\"\"---...._        /D  |       | |      \"\"' .     __  `--.\n");
                Console.SetCursorPosition(x, y + 25); Console.Write("       / |  ,      ,`  `-|       ` |  /`    ,'    /\"  \\     `.\n");
                Console.SetCursorPosition(x, y + 26); Console.Write("      .  `_/      /  `-..|         |  .'   /      `.  |       \\\n");
                Console.SetCursorPosition(x, y + 27); Console.Write("      `          '-......'         |      .         `-'        L\n");
                Console.SetCursorPosition(x, y + 28); Console.Write("       \\                          ,'     j                     |\n");
                Console.SetCursorPosition(x, y + 29); Console.Write("        `                      _.'       |                    .-.\n");
                Console.SetCursorPosition(x, y + 30); Console.Write("        /    ,            _,.-'          |                    '  \\\n");
                Console.SetCursorPosition(x, y + 31); Console.Write("       j._            ,-+'             __|                  ,^.   \\\n");
                Console.SetCursorPosition(x, y + 32); Console.Write("      | | `+\"\"-.....,' .'           ,-'   `._           _.-'\"\"\"`\"\"\n");
                Console.SetCursorPosition(x, y + 33); Console.Write("      |,|  _`. |     ,+          _,'         `\"-------\"'\n");
                Console.SetCursorPosition(x, y + 34); Console.Write("      '  \"\"   \"     | ,\"\"-.   _,'\n");
                Console.SetCursorPosition(x, y + 35); Console.Write("                    |,` _.+--'\n");
                Console.SetCursorPosition(x, y + 36); Console.Write("                    ' \"' \n");
            }

            else if (pokenumber == 33)
            {
                Console.SetCursorPosition(x, y); Console.Write("    `._\n");
                Console.SetCursorPosition(x, y + 1); Console.Write("     \\ `.\n");
                Console.SetCursorPosition(x, y + 2); Console.Write("      \\  `.\n");
                Console.SetCursorPosition(x, y + 3); Console.Write("       .   `.\n");
                Console.SetCursorPosition(x, y + 4); Console.Write("       j     ){-----+...-.\n");
                Console.SetCursorPosition(x, y + 5); Console.Write("       /  _,'   /\"\"_     `.     _,..._\n");
                Console.SetCursorPosition(x, y + 6); Console.Write("     ,'  '      .-\"c|\"`+- -+--\"'      `-.._\n");
                Console.SetCursorPosition(x, y + 7); Console.Write("   ,'            \"\"\"+_ |       _,--\"\"--.._ `---..\n");
                Console.SetCursorPosition(x, y + 8); Console.Write("  '     _             \"'      '\\          `--._  `.\n");
                Console.SetCursorPosition(x, y + 9); Console.Write(" |    -'                      _.'              `-. `.\n");
                Console.SetCursorPosition(x, y + 10); Console.Write(" (     __   ,.----.._        \\``-.                |  `._\n");
                Console.SetCursorPosition(x, y + 11); Console.Write("  `.  /_ \"\"\"   ___.| ,.      j  `.`.   ,          `.    `.\n");
                Console.SetCursorPosition(x, y + 12); Console.Write("    `'| |    ,'    '.'/'\"\"'\"'   j`. \\,'|  _________||\"\"`-'`.\n");
                Console.SetCursorPosition(x, y + 13); Console.Write("      `_.\\   j       j      __-'|_/'\"._){.\"  __       .    \"\n");
                Console.SetCursorPosition(x, y + 14); Console.Write("          | /        /      \\ `/        |`.   .   ..._`.\n");
                Console.SetCursorPosition(x, y + 15); Console.Write("          ||        /       | /         | |    ){.'    -/\n");
                Console.SetCursorPosition(x, y + 16); Console.Write("          |'    _,-'        |.`.       ,' |   | |\\_\n");
                Console.SetCursorPosition(x, y + 17); Console.Write("    _     | `--'     _,-    . `.`--- ,'   /   |  .\\`-..\n");
                Console.SetCursorPosition(x, y + 18); Console.Write("    |`v,-'\"\"\"'`-.,.-'        `._``--'  _,'    |  | \\  ,'\n");
                Console.SetCursorPosition(x, y + 19); Console.Write(",--'`- _       \\ \\              '\"\"''`'       `_,'  +-\n");
                Console.SetCursorPosition(x, y + 20); Console.Write(" -.'    \\       . |                        /`     ,---.\n");
                Console.SetCursorPosition(x, y + 21); Console.Write(" -`\\    |       | L                        `-'     '\"\"'`\\\n");
                Console.SetCursorPosition(x, y + 22); Console.Write(" '---...){_      / \\                          |   ,.-\"\"\".|\n");
                Console.SetCursorPosition(x, y + 23); Console.Write("          '---+'   \\                         ' ,'       `\n");
                Console.SetCursorPosition(x, y + 24); Console.Write("               '`''\".                       / /          `.\n");
                Console.SetCursorPosition(x, y + 25); Console.Write("                     \\                     j |            '.\n");
                Console.SetCursorPosition(x, y + 26); Console.Write("                      `.                   | |              \\\n");
                Console.SetCursorPosition(x, y + 27); Console.Write("                        \\ _                |/             /\\|\n");
                Console.SetCursorPosition(x, y + 28); Console.Write("                         / \"-   --\"\"----+--'             / ||\n");
                Console.SetCursorPosition(x, y + 29); Console.Write("                        `v'\"\"\"\"\"-..     |      `..__.,.-'-.,,\n");
                Console.SetCursorPosition(x, y + 30); Console.Write("                         |         `-.,'           .`.J     /\n");
                Console.SetCursorPosition(x, y + 31); Console.Write("                         |            |             '---...'\n");
                Console.SetCursorPosition(x, y + 32); Console.Write("                         |     .     /\n");
                Console.SetCursorPosition(x, y + 33); Console.Write("                         |    | `,  j\n");
                Console.SetCursorPosition(x, y + 34); Console.Write("                        ..--+'\"--_  /\n");
                Console.SetCursorPosition(x, y + 35); Console.Write("                         `-.|     \\'\n");
                Console.SetCursorPosition(x, y + 36); Console.Write("                             `----' \n");
            }

            else if (pokenumber == 34)
            {
                Console.SetCursorPosition(x, y); Console.Write("                  _.___.._              ,'            ,. ____\n");
                Console.SetCursorPosition(x, y + 1); Console.Write("                   \\      '-.._      |){ | '       __,- _ ... )\n");
                Console.SetCursorPosition(x, y + 2); Console.Write("                   j-\"\"\"|\"`-._ `.'.  | \\| |    ,\"'_,--.     `.\n");
                Console.SetCursorPosition(x, y + 3); Console.Write("                  |     |     `. `.\\-' j   .-.'  '     `.    |\n");
                Console.SetCursorPosition(x, y + 4); Console.Write("     _.           `     |       \\  \"  /    \\   .'       |    |\n");
                Console.SetCursorPosition(x, y + 5); Console.Write("    /  |           \\    L       j           )   \\       j   j\n");
                Console.SetCursorPosition(x, y + 6); Console.Write("   /   |            \\    `.   ,'_ ..   .__,. ,   `     /   ,'\n");
                Console.SetCursorPosition(x, y + 7); Console.Write("  /   j              `-._  `./  /`. \\       / /\"| \\ .-'  ,'\n");
                Console.SetCursorPosition(x, y + 8); Console.Write(" .  ,.|                _`+..    |.)`       ' (| |  ``._.'\n");
                Console.SetCursorPosition(x, y + 9); Console.Write(" |-'  |              ,'    /,     \"`'       '--\"   |   '`.\n");
                Console.SetCursorPosition(x, y + 10); Console.Write("j     |             '        \\ './.             |\\-'      `\n");
                Console.SetCursorPosition(x, y + 11); Console.Write("|     |            |          \\  `/, . . . _-|./ |        _\\\n");
                Console.SetCursorPosition(x, y + 12); Console.Write("| ,-\"\".            `-\"\"-.     |`-._`| \\--|'/|, ,,'    _.-' /\n");
                Console.SetCursorPosition(x, y + 13); Console.Write("|/     \\        __(      \\   ,+..._`---...-'_.--\"\". .'     \\\n");
                Console.SetCursorPosition(x, y + 14); Console.Write("|       `   ,-\"'   `._   | _.      `\"-....-'       `.    ,.---.\n");
                Console.SetCursorPosition(x, y + 15); Console.Write("|    ,-'\"  '\"'\\       L,-|'            `v           |  ,'      `\n");
                Console.SetCursorPosition(x, y + 16); Console.Write("L   /    .\"`--'       |  |              |           |||         `'\n");
                Console.SetCursorPosition(x, y + 17); Console.Write(" | /     `..        ,.|  |.             |          ,' '|       .\"\".\\\n");
                Console.SetCursorPosition(x, y + 18); Console.Write(" `'      | /        . `. | `.       _,--+--._    ,',-''|        `-'|\n");
                Console.SetCursorPosition(x, y + 19); Console.Write("  `     .,\"`. ,..  / `  `|   `-...-'         `\"-' / ,.-\\         /\"\".\n");
                Console.SetCursorPosition(x, y + 20); Console.Write("   \\   j    |`. |.-   `/. `.     __.-----...__   ,`/    `.___    \\  |\n");
                Console.SetCursorPosition(x, y + 21); Console.Write("    .  |    |  \\|      | \\\\ `- -'             `.. |       |  `,\"\" `.'\n");
                Console.SetCursorPosition(x, y + 22); Console.Write("     ` |   j .         | | \\                   |  |       |,-| \\\n");
                Console.SetCursorPosition(x, y + 23); Console.Write("      `'   | \".      ,-' `. L                  .-' `        ,'  |\n");
                Console.SetCursorPosition(x, y + 24); Console.Write("        `. |   \\    /     .'`.               ,'     `      /    |\n");
                Console.SetCursorPosition(x, y + 25); Console.Write("          `.    `\"\"'      /   `-._       __.' .'\\    `....'    /\n");
                Console.SetCursorPosition(x, y + 26); Console.Write("           ,'             \\ _____ `\"\"\"\"\"\"  _.'  /             '\n");
                Console.SetCursorPosition(x, y + 27); Console.Write("           ' ,--'\"\"`--.___,'     \"\"------''    '_    _,...__ /`.\n");
                Console.SetCursorPosition(x, y + 28); Console.Write("            `-........'                          `-.'       `,\"\n");
                Console.SetCursorPosition(x, y + 29); Console.Write("                                                     `\"\"\"---' \n");
            }

            else if (pokenumber == 35)
            {
                Console.SetCursorPosition(x, y); Console.Write("                    __.._\n");
                Console.SetCursorPosition(x, y + 1); Console.Write("                ,--'     \"`-._    _,.-,--------.\n");
                Console.SetCursorPosition(x, y + 2); Console.Write("    ________ ,-'              `-\"'   /     _.-'|\n");
                Console.SetCursorPosition(x, y + 3); Console.Write(" ,-'  '     ){                       .    ,'    '\n");
                Console.SetCursorPosition(x, y + 4); Console.Write("|    '     j      _.._              |  ,'     j\n");
                Console.SetCursorPosition(x, y + 5); Console.Write("L   /      |    .'    `.            |.'      /\n");
                Console.SetCursorPosition(x, y + 6); Console.Write(" \\ j       |    `.,'   |           ,'       /    _\n");
                Console.SetCursorPosition(x, y + 7); Console.Write("  .|      ,'\\         /           '.___    / _.-\" |\n");
                Console.SetCursorPosition(x, y + 8); Console.Write("   `    .'   `-.....-'                 `- +-'    /\n");
                Console.SetCursorPosition(x, y + 9); Console.Write("    `. ,'                                `.     <__\n");
                Console.SetCursorPosition(x, y + 10); Console.Write("      `.             .\\ \\                 |   ___ ,'\n");
                Console.SetCursorPosition(x, y + 11); Console.Write("      |     | #      || |                  ,\"\"   \"`.\n");
                Console.SetCursorPosition(x, y + 12); Console.Write("      |     | #      `'_/                   .       `.\n");
                Console.SetCursorPosition(x, y + 13); Console.Write("     ,'     `.         ,-\"\".                L         `.\n");
                Console.SetCursorPosition(x, y + 14); Console.Write("    /     (__)       _  \"\"\"                  ){\"\"-.      .\n");
                Console.SetCursorPosition(x, y + 15); Console.Write("   /             \\\"'u|         |/            |    \\     |\n");
                Console.SetCursorPosition(x, y + 16); Console.Write("  .               \\  |         |           | |     |    |\n");
                Console.SetCursorPosition(x, y + 17); Console.Write("  |     _          `-'        j           /  |     '    |\n");
                Console.SetCursorPosition(x, y + 18); Console.Write("  L      `.                   |          /   |   ,'     '\n");
                Console.SetCursorPosition(x, y + 19); Console.Write("   \\       `.                ,'         /    |_,'      /\n");
                Console.SetCursorPosition(x, y + 20); Console.Write("    `.   ,.<'                `+--.    ,'     /       ,'\n");
                Console.SetCursorPosition(x, y + 21); Console.Write("      `./`._'                 '_.`._,'      j      _,\n");
                Console.SetCursorPosition(x, y + 22); Console.Write("        /\"'                      \"          |   _,'\n");
                Console.SetCursorPosition(x, y + 23); Console.Write("       /   `._              .              '..-'\n");
                Console.SetCursorPosition(x, y + 24); Console.Write("      j       `-._           `            /\n");
                Console.SetCursorPosition(x, y + 25); Console.Write("      |        _,'`\"--........+.         /\n");
                Console.SetCursorPosition(x, y + 26); Console.Write("      ,\"-.._,-'                 `.  .-._/\n");
                Console.SetCursorPosition(x, y + 27); Console.Write("      '---'                       `+__,' \n");
            }

            else if (pokenumber == 36)
            {
                Console.SetCursorPosition(x, y); Console.Write("                                       __,......._\n");
                Console.SetCursorPosition(x, y + 1); Console.Write("    _............___          ____....<__         `\"._\n");
                Console.SetCursorPosition(x, y + 2); Console.Write("   '._      `\",     `'--._,.-'   ___     `\"-.    ___..>---,---------..\n");
                Console.SetCursorPosition(x, y + 3); Console.Write(" ____ -.,..--\"            `-  ,-'   `       .`-\"'       .'_         ,-'\n");
                Console.SetCursorPosition(x, y + 4); Console.Write("'._  \"\"'-.                  .'     _.._                    `-._ ,.-'\n");
                Console.SetCursorPosition(x, y + 5); Console.Write("   `-._   `._              .     ,'    `.                    ,-'----.._\n");
                Console.SetCursorPosition(x, y + 6); Console.Write("       _>.   -.            `     |      |                _,-'          )\n");
                Console.SetCursorPosition(x, y + 7); Console.Write(",..--\"\"`--\"\"\"\"\"`-.          \\    `-.    |             ,.+.__   _,;---\"\"\n");
                Console.SetCursorPosition(x, y + 8); Console.Write("\\_ |              `.         `.       _.'         _,-`      `\"\"   `.\n");
                Console.SetCursorPosition(x, y + 9); Console.Write("  \"\\                `       / _`\"----'           '                 /-.\n");
                Console.SetCursorPosition(x, y + 10); Console.Write("   `.____                  |  #      #' \\                         `,..'\n");
                Console.SetCursorPosition(x, y + 11); Console.Write("       ,-\"--...__          `--        --'                   ___,..'\n");
                Console.SetCursorPosition(x, y + 12); Console.Write("      '-.---\"'  |           -.,........,            ,.---\"\"\" .\n");
                Console.SetCursorPosition(x, y + 13); Console.Write("                |            |        \\'             \\\"\"--..._`\n");
                Console.SetCursorPosition(x, y + 14); Console.Write("                |             \\       /              |\n");
                Console.SetCursorPosition(x, y + 15); Console.Write("                .              `.    /               |\n");
                Console.SetCursorPosition(x, y + 16); Console.Write("                 ,               `--'                j\n");
                Console.SetCursorPosition(x, y + 17); Console.Write("                j \\                                 /\n");
                Console.SetCursorPosition(x, y + 18); Console.Write("                |  .                               '`.\n");
                Console.SetCursorPosition(x, y + 19); Console.Write("                 L._`.                           .' ,|\n");
                Console.SetCursorPosition(x, y + 20); Console.Write("                 |  `.){-._                    _,' ,' |\n");
                Console.SetCursorPosition(x, y + 21); Console.Write("                 `.,'| \"\"\"`.__            _,< _..-   '\n");
                Console.SetCursorPosition(x, y + 22); Console.Write("                     `...-'   `----------'   `-.__|`' \n");
            }

            else if (pokenumber == 37)
            {
                Console.SetCursorPosition(x, y); Console.Write("               _,.+-----__,._\n");
                Console.SetCursorPosition(x, y + 1); Console.Write("              /  /    ,'     `.\n");
                Console.SetCursorPosition(x, y + 2); Console.Write("     ,+._   ./...\\_  /   ,..   \\\n");
                Console.SetCursorPosition(x, y + 3); Console.Write("     | `.`+'       `-' .' ,.|  |\n");
                Console.SetCursorPosition(x, y + 4); Console.Write("     |  |( ,    ,.`,   |  `-',,........_       __......_\n");
                Console.SetCursorPosition(x, y + 5); Console.Write("      \\ |..`/,-'  '\"\"\"' `\"\"'\"  _,.---\"-,  .-+-'      _.-\"\"`--._\n");
                Console.SetCursorPosition(x, y + 6); Console.Write("       .\"|       /\"\\`.      ,-'       / .','      ,-'          \\\n");
                Console.SetCursorPosition(x, y + 7); Console.Write("      .'-'      |`-'  |    `./       / / /       /   ,.-'       |\n");
                Console.SetCursorPosition(x, y + 8); Console.Write("     j`v+\"      `----\"       ,'    ,'./ .'      /   |        ___|\n");
                Console.SetCursorPosition(x, y + 9); Console.Write("     |                      |   _,','j  |      /    L   _.-\"'    `--.\n");
                Console.SetCursorPosition(x, y + 10); Console.Write("      \\                     `.-'  j  |  L     F      \\-'             \\\n");
                Console.SetCursorPosition(x, y + 11); Console.Write("       \\ .-.               ,'     |  L   .    /    ,'       __..      `\n");
                Console.SetCursorPosition(x, y + 12); Console.Write("        \\ `.|            _/_      '   \\  |   /   ,'       ,\"    `.     '\n");
                Console.SetCursorPosition(x, y + 13); Console.Write("         `.             '   `-.    `.__| |  /  ,'         |            |\n");
                Console.SetCursorPosition(x, y + 14); Console.Write("           `\"-,.               `----'   `-.' .'   _,.--\"\"\"'\" --.      ,'\n");
                Console.SetCursorPosition(x, y + 15); Console.Write("              |          ,.                `.  ,-'              `.  _'\n");
                Console.SetCursorPosition(x, y + 16); Console.Write("             /|         /                    \\'          __.._    \\'\n");
                Console.SetCursorPosition(x, y + 17); Console.Write("   _...--...' +,..-----'                      \\-----._,-'     \\    |\n");
                Console.SetCursorPosition(x, y + 18); Console.Write(" ,'    |     /        \\                        \\      |       j    |\n");
                Console.SetCursorPosition(x, y + 19); Console.Write("/| /   |    j  ,      |                         ,._   `.    -'    /\n");
                Console.SetCursorPosition(x, y + 20); Console.Write("\\\\'   _`.__ | |      _L      |-----\\            `. \\    `._    _,'\n");
                Console.SetCursorPosition(x, y + 21); Console.Write(" \"\"`\"'     \"`\"---'\"\"`._`-._,-'      `.              `.     `--'\n");
                Console.SetCursorPosition(x, y + 22); Console.Write("                       \"`--.......____){.         _  / \\\n");
                Console.SetCursorPosition(x, y + 23); Console.Write("                               `-----.. `>-.....`,-'   \\\n");
                Console.SetCursorPosition(x, y + 24); Console.Write("                                      `|\"    `.  ` . \\ |\n");
                Console.SetCursorPosition(x, y + 25); Console.Write("                                        `._`..'    `-\"'\n");
                Console.SetCursorPosition(x, y + 26); Console.Write("                                           \"' \n");
            }

            else if (pokenumber == 38)
            {
                Console.SetCursorPosition(x, y); Console.Write("        ,-\"\"'-.._\n");
                Console.SetCursorPosition(x, y + 1); Console.Write("   .---'\"\" \">` - `--\n");
                Console.SetCursorPosition(x, y + 2); Console.Write("   `.      `-._  .`-.\n");
                Console.SetCursorPosition(x, y + 3); Console.Write("     `-.       \\ .` ){ -.\n");
                Console.SetCursorPosition(x, y + 4); Console.Write("      _.>._     / ` `){..,\n");
                Console.SetCursorPosition(x, y + 5); Console.Write(" ,.../...._`\"-./    '.|, `\n");
                Console.SetCursorPosition(x, y + 6); Console.Write("`---.._\"'-.`-._    |    \"'--.\n");
                Console.SetCursorPosition(x, y + 7); Console.Write("       `--.\\`. `._,'         `.---------------.._\n");
                Console.SetCursorPosition(x, y + 8); Console.Write("            \"-'--.___          \\`'\"-..__         `-._\n");
                Console.SetCursorPosition(x, y + 9); Console.Write("                     `.\"`-\\     ` `\"--..\"`-.-..__    `\".\n");
                Console.SetCursorPosition(x, y + 10); Console.Write("                       `.  `.     |``._ `--. `-..`\"-._`.\\-.\n");
                Console.SetCursorPosition(x, y + 11); Console.Write("                         \\   -....' `-.`-.  `-._ `-.  `-.\\ `.\n");
                Console.SetCursorPosition(x, y + 12); Console.Write("                          `-.__  `.`-. `. `._   `._ `-.  `.  `.\n");
                Console.SetCursorPosition(x, y + 13); Console.Write("                               `-..`` `. `.  `.    `.  `-.     \\\n");
                Console.SetCursorPosition(x, y + 14); Console.Write("                                   \\`.` `  `.  `.    `.   `-.   `.\n");
                Console.SetCursorPosition(x, y + 15); Console.Write("                                    `.`-'`.  \\   .     `.    `.   \\\n");
                Console.SetCursorPosition(x, y + 16); Console.Write("                                      `..  \\  \\   \\      `.    `.,_`.\n");
                Console.SetCursorPosition(x, y + 17); Console.Write("                                         \\` \\  .   `.     '\\     `.`.`._\n");
                Console.SetCursorPosition(x, y + 18); Console.Write("                                          \\``.  \\    \\     \\`.    |\n");
                Console.SetCursorPosition(x, y + 19); Console.Write("                                           ' '.  \\    \\     \\ \\   L\n");
                Console.SetCursorPosition(x, y + 20); Console.Write("                                             \\ \\  '    `    '. `.  \\\n");
                Console.SetCursorPosition(x, y + 21); Console.Write("                                              ` `. \\    `    '.  `. `.\n");
                Console.SetCursorPosition(x, y + 22); Console.Write("                                               `. `,`.   `.   `.   `._.\n");
                Console.SetCursorPosition(x, y + 23); Console.Write("                                                 `-  \\._   `.  `.     \"`\n");
                Console.SetCursorPosition(x, y + 24); Console.Write("                                                      ` `.   `.  .\n");
                Console.SetCursorPosition(x, y + 25); Console.Write("                                                          `-. ``-.){-.\n");
                Console.SetCursorPosition(x, y + 26); Console.Write("                                                              -.`. '\"-'\n");
                Console.SetCursorPosition(x, y + 27); Console.Write("                                                                 `\"-. \n");
            }

            else if (pokenumber == 39)
            {
                Console.SetCursorPosition(x, y); Console.Write("   ,..__\n");
                Console.SetCursorPosition(x, y + 1); Console.Write("  |  _  `--._                                  _.--\"\"\"`.\n");
                Console.SetCursorPosition(x, y + 2); Console.Write("  |   |._    `-.        __________         _.-'    ,|' |\n");
                Console.SetCursorPosition(x, y + 3); Console.Write("  |   |  `.     `-..--\"\"_.        `\"\"-..,-'      ,' |  |\n");
                Console.SetCursorPosition(x, y + 4); Console.Write("  L   |    `.        ,-'                      _,'   |  |\n");
                Console.SetCursorPosition(x, y + 5); Console.Write("   .  |     ,'     ,'            .           '.     |  |\n");
                Console.SetCursorPosition(x, y + 6); Console.Write("   |  |   ,'      /               \\            `.   |  |\n");
                Console.SetCursorPosition(x, y + 7); Console.Write("   |  . ,'      ,'                |              \\ /  j\n");
                Console.SetCursorPosition(x, y + 8); Console.Write("   `   \"       ,                  '               `   /\n");
                Console.SetCursorPosition(x, y + 9); Console.Write("    `,         |                ,'                  '+\n");
                Console.SetCursorPosition(x, y + 10); Console.Write("    /          |             _,'                     `\n");
                Console.SetCursorPosition(x, y + 11); Console.Write("   /     .-\"\"\"'L          ,-' \\  ,-'\"\"\"\"`-.           `\n");
                Console.SetCursorPosition(x, y + 12); Console.Write("  j    ,' ,.+--.\\        '    ',' ,.,-\"--._`.          \\\n");
                Console.SetCursorPosition(x, y + 13); Console.Write("  |   / .'  L    `.        _.'/ .'  |      \\ \\          .\n");
                Console.SetCursorPosition(x, y + 14); Console.Write(" j   | | `--'     |`+-----'  . j`._,'       L |         |\n");
                Console.SetCursorPosition(x, y + 15); Console.Write(" |   L .          | |        | |            | |         |\n");
                Console.SetCursorPosition(x, y + 16); Console.Write(" |   `\\ \\        / j         | |            | |         |\n");
                Console.SetCursorPosition(x, y + 17); Console.Write(" |     \\ `-.._,.- /           . `         .'  '         |\n");
                Console.SetCursorPosition(x, y + 18); Console.Write(" l      `-..__,.-'             `.`-.....-' _.'          '\n");
                Console.SetCursorPosition(x, y + 19); Console.Write(" '                               `-.....--'            j\n");
                Console.SetCursorPosition(x, y + 20); Console.Write("  .                  -.....                            |\n");
                Console.SetCursorPosition(x, y + 21); Console.Write("   L                  `---'                            '\n");
                Console.SetCursorPosition(x, y + 22); Console.Write("    \\                                                 /\n");
                Console.SetCursorPosition(x, y + 23); Console.Write("     ` \\                                        ,   ,'\n");
                Console.SetCursorPosition(x, y + 24); Console.Write("      `.`.    |                        /      ,'   .\n");
                Console.SetCursorPosition(x, y + 25); Console.Write("        . `._,                        |     ,'   .'\n");
                Console.SetCursorPosition(x, y + 26); Console.Write("         `.                           `._.-'  ,-'\n");
                Console.SetCursorPosition(x, y + 27); Console.Write("    _,-\"\"\"\"`-,                             _,'\"-.._\n");
                Console.SetCursorPosition(x, y + 28); Console.Write("  ,'          `-.._                     ,-'        `.\n");
                Console.SetCursorPosition(x, y + 29); Console.Write(" /             _,' `\"-..___     _,..--\"`.            `.\n");
                Console.SetCursorPosition(x, y + 30); Console.Write("|         _,.-'            `\"\"\"'         `-._          \\\n");
                Console.SetCursorPosition(x, y + 31); Console.Write("`-....---'                                   `-.._      |\n");
                Console.SetCursorPosition(x, y + 32); Console.Write("                                                  `--...' \n");
            }

            else if (pokenumber == 40)
            {
                Console.SetCursorPosition(x, y); Console.Write(",-.                                                 .\n");
                Console.SetCursorPosition(x, y + 1); Console.Write(".` `.                                             .'|\n");
                Console.SetCursorPosition(x, y + 2); Console.Write("` `. `-._                     _,.--._            /  |\n");
                Console.SetCursorPosition(x, y + 3); Console.Write(" `  ..   `.                  /       `.        ,' , '\n");
                Console.SetCursorPosition(x, y + 4); Console.Write("  `  ` `.  `-._              | '\".     \\      /  / .\n");
                Console.SetCursorPosition(x, y + 5); Console.Write("   `. `   `.   `.          ,\"'---'      .   ,' ,'' |\n");
                Console.SetCursorPosition(x, y + 6); Console.Write("     ` `.    `.  `.       .             |  /  / /  F\n");
                Console.SetCursorPosition(x, y + 7); Console.Write("      `. .     `.  \\ ,..--|             |,'  / /  /\n");
                Console.SetCursorPosition(x, y + 8); Console.Write("        \\ `.     .  |      \\           ,.   / /  /\n");
                Console.SetCursorPosition(x, y + 9); Console.Write("         `._`._   j   .----.`._     _,` | ,\" / ,'\n");
                Console.SetCursorPosition(x, y + 10); Console.Write("            `._`\"`  ,',\"\"\"\"-.`.\"\"--' ,-\"){+.-'.'\n");
                Console.SetCursorPosition(x, y + 11); Console.Write("            ,'     . |`._)   . L     ||_7\\+-'\n");
                Console.SetCursorPosition(x, y + 12); Console.Write("           /       | |       | |     .\\   \\.\n");
                Console.SetCursorPosition(x, y + 13); Console.Write("          /        |  .      | |      \\\\_,'j\n");
                Console.SetCursorPosition(x, y + 14); Console.Write("         .          ._ `----' /        `--\" '\n");
                Console.SetCursorPosition(x, y + 15); Console.Write("        j             \"--..--'              |\n");
                Console.SetCursorPosition(x, y + 16); Console.Write("       ,|                        ,-\".       |\n");
                Console.SetCursorPosition(x, y + 17); Console.Write("     ,' |                       /   |       '\n");
                Console.SetCursorPosition(x, y + 18); Console.Write("    /   '                       `..'    ,'   \\\n");
                Console.SetCursorPosition(x, y + 19); Console.Write("   /   j                               /      L\n");
                Console.SetCursorPosition(x, y + 20); Console.Write("  j    |                              .       |\n");
                Console.SetCursorPosition(x, y + 21); Console.Write("  |  _.'                              |     , |\n");
                Console.SetCursorPosition(x, y + 22); Console.Write("  `-' .                               |   ,'  '\n");
                Console.SetCursorPosition(x, y + 23); Console.Write("      |                               `.-'     .\n");
                Console.SetCursorPosition(x, y + 24); Console.Write("      |                                        |\n");
                Console.SetCursorPosition(x, y + 25); Console.Write("      |                                        j\n");
                Console.SetCursorPosition(x, y + 26); Console.Write("      '                                       .\n");
                Console.SetCursorPosition(x, y + 27); Console.Write("       `                                     /\n");
                Console.SetCursorPosition(x, y + 28); Console.Write("        `.                                  /\n");
                Console.SetCursorPosition(x, y + 29); Console.Write("     ______.                              ,'\n");
                Console.SetCursorPosition(x, y + 30); Console.Write("   ,'       `-._                     _,.'\"\"`--..\n");
                Console.SetCursorPosition(x, y + 31); Console.Write("  .         ___,+ -...._________,...<_          \\\n");
                Console.SetCursorPosition(x, y + 32); Console.Write("   .___,.-\"'                          `-._      |\n");
                Console.SetCursorPosition(x, y + 33); Console.Write("                                          `-....' \n");
            }

            else if (pokenumber == 41)
            {
                Console.SetCursorPosition(x, y); Console.Write("                                        `\"--.._\n");
                Console.SetCursorPosition(x, y + 1); Console.Write("                                         '  ,__`-._\n");
                Console.SetCursorPosition(x, y + 2); Console.Write("                                          ` |   `-.`._\n");
                Console.SetCursorPosition(x, y + 3); Console.Write("                                           |`       `._`.\n");
                Console.SetCursorPosition(x, y + 4); Console.Write("                                    ./\"\\   | `.        `.`.\n");
                Console.SetCursorPosition(x, y + 5); Console.Write("                                  .'/   .  | _ `.        `.`.\n");
                Console.SetCursorPosition(x, y + 6); Console.Write("     /|                          / /    |  || `-.`.         `..\n");
                Console.SetCursorPosition(x, y + 7); Console.Write("    / |                         . /     |  ||    `.`.         `.`\n");
                Console.SetCursorPosition(x, y + 8); Console.Write("   /  '        _.,.____      _,.'._     '  j       `.`          `..\n");
                Console.SetCursorPosition(x, y + 9); Console.Write("  j ,-.`       . \"\"--._`-. ,',.-++.`. ,'  //         `..          `..\n");
                Console.SetCursorPosition(x, y + 10); Console.Write("  / '  \\`       \\      `. '.'|  ''  \\`   //            ``.          `.\n");
                Console.SetCursorPosition(x, y + 11); Console.Write(" j /    \\`.      \\       || `'       |\\ //              `..    __,....`.\n");
                Console.SetCursorPosition(x, y + 12); Console.Write(" |.      `.`.     `.     ||         [|'//                 \\\\_,\"        `\n");
                Console.SetCursorPosition(x, y + 13); Console.Write(" ||       |,.`._    `----.`_\"\\   _.-\"  .        ___........\\|\n");
                Console.SetCursorPosition(x, y + 14); Console.Write("jj        || `-.`-.______ `/`--'\"       \\   _.-'\n");
                Console.SetCursorPosition(x, y + 15); Console.Write("|.        ||     `--..___\"\"              .,'\n");
                Console.SetCursorPosition(x, y + 16); Console.Write("||        ||             \"\"|             Y\n");
                Console.SetCursorPosition(x, y + 17); Console.Write("||        ||               \\            /\n");
                Console.SetCursorPosition(x, y + 18); Console.Write("||        ||           _....\\.         ,\\\n");
                Console.SetCursorPosition(x, y + 19); Console.Write("||        '|        ,-'       `,.___,.-. .\n");
                Console.SetCursorPosition(x, y + 20); Console.Write("||         L      ,'           `  /     ` .\n");
                Console.SetCursorPosition(x, y + 21); Console.Write("||         '`    /              ||       ` .\n");
                Console.SetCursorPosition(x, y + 22); Console.Write("||          \\| ,'               ||        `.`\n");
                Console.SetCursorPosition(x, y + 23); Console.Write("||        ___|/                 '|          .`.\n");
                Console.SetCursorPosition(x, y + 24); Console.Write("||    _,-'    |                  L           ` .\n");
                Console.SetCursorPosition(x, y + 25); Console.Write("||  ,'                           ||           ` .\n");
                Console.SetCursorPosition(x, y + 26); Console.Write("` ./                             ||            ` .\n");
                Console.SetCursorPosition(x, y + 27); Console.Write(" `V                              ||             ` .\n");
                Console.SetCursorPosition(x, y + 28); Console.Write("                                 ||              ``\n");
                Console.SetCursorPosition(x, y + 29); Console.Write("                                 ||               ``\n");
                Console.SetCursorPosition(x, y + 30); Console.Write("                                 ||                `\\\n");
                Console.SetCursorPosition(x, y + 31); Console.Write("                                 ||                 `'\n");
                Console.SetCursorPosition(x, y + 32); Console.Write("                                 ||\n");
                Console.SetCursorPosition(x, y + 33); Console.Write("                                 ||\n");
                Console.SetCursorPosition(x, y + 34); Console.Write("                                 !|\n");
                Console.SetCursorPosition(x, y + 35); Console.Write("                                 _/ \n");
            }

            else if (pokenumber == 42)
            {
                Console.SetCursorPosition(x, y); Console.Write("                           ---..__\n");
                Console.SetCursorPosition(x, y + 1); Console.Write("_____                          `._\"`._\n");
                Console.SetCursorPosition(x, y + 2); Console.Write("  `._`\"--_._                      `.  `._._\n");
                Console.SetCursorPosition(x, y + 3); Console.Write("     `._   `-._._                   `.   `.`._\n");
                Console.SetCursorPosition(x, y + 4); Console.Write("        `.     `-._.                  `.    `.`._\n");
                Console.SetCursorPosition(x, y + 5); Console.Write("          `.       `-`._                `.    `-.`.\n");
                Console.SetCursorPosition(x, y + 6); Console.Write("            `.        `-`._               \\      `.`.\n");
                Console.SetCursorPosition(x, y + 7); Console.Write("              \\          `.`.              \\       `-.`.\n");
                Console.SetCursorPosition(x, y + 8); Console.Write("               \\            `..             \\         `.`.\n");
                Console.SetCursorPosition(x, y + 9); Console.Write("                \\             `..            \\          `.`\n");
                Console.SetCursorPosition(x, y + 10); Console.Write("                 \\             _){`.           |           `..\n");
                Console.SetCursorPosition(x, y + 11); Console.Write("                  L       _,-\"\" jj            |     ___......){\n");
                Console.SetCursorPosition(x, y + 12); Console.Write("                  |     ,'      ||            |  ,.\"        .'\n");
                Console.SetCursorPosition(x, y + 13); Console.Write("                  |   ,'        ||            |\"'           / \\\n");
                Console.SetCursorPosition(x, y + 14); Console.Write("                  |  /         /|L       ,\".   ]`.         /   L\n");
                Console.SetCursorPosition(x, y + 15); Console.Write("                  |,'         . ` \\      /  \"\"\"  \"`.      j    |\n");
                Console.SetCursorPosition(x, y + 16); Console.Write("                  /_          |  `.\\    (\\  <.)|    \\     |    |\n");
                Console.SetCursorPosition(x, y + 17); Console.Write("                    `-.       |    \\`.  |_____..     \\   j     |\n");
                Console.SetCursorPosition(x, y + 18); Console.Write("                       `,     |     `.`.\\|    V \\   .'\\  |     |\n");
                Console.SetCursorPosition(x, y + 19); Console.Write("                         \\    |       `._|       | <  ` j     j\n");
                Console.SetCursorPosition(x, y + 20); Console.Write("                          `.  |          `.      |  \\  |      |\n");
                Console.SetCursorPosition(x, y + 21); Console.Write("                            \\ |           |L      L  L |__    |\n");
                Console.SetCursorPosition(x, y + 22); Console.Write("                             \\|           ||      |  |  __`. j\n");
                Console.SetCursorPosition(x, y + 23); Console.Write("                              Y           ||.-.   |  | |   \\ |\n");
                Console.SetCursorPosition(x, y + 24); Console.Write("                               \\,--\"\"\"\"\"`-.|`. \\  |  |/|    `\n");
                Console.SetCursorPosition(x, y + 25); Console.Write("                                '          |  \\ `.'    j\n");
                Console.SetCursorPosition(x, y + 26); Console.Write("                                          (|  | ,.`.  /\n");
                Console.SetCursorPosition(x, y + 27); Console.Write("                                      _.-\"_`._| | `' /\n");
                Console.SetCursorPosition(x, y + 28); Console.Write("                              ,....../ ,'\" `.__.'_,-'\n");
                Console.SetCursorPosition(x, y + 29); Console.Write("                              `-----._`..      \"\"\n");
                Console.SetCursorPosition(x, y + 30); Console.Write("                                      `.J \n");
            }

            else if (pokenumber == 43)
            {
                Console.SetCursorPosition(x, y); Console.Write("                           .-\"--.__\n");
                Console.SetCursorPosition(x, y + 1); Console.Write("          _                / '+.--'\n");
                Console.SetCursorPosition(x, y + 2); Console.Write("           \\.-._          j / |\n");
                Console.SetCursorPosition(x, y + 3); Console.Write("            \\`-.`._      . j  |\n");
                Console.SetCursorPosition(x, y + 4); Console.Write("             \\  `. `.    | |  L                        _,,--+='\n");
                Console.SetCursorPosition(x, y + 5); Console.Write("              L   `. `-. | |   \\                  _.-+'    /\n");
                Console.SetCursorPosition(x, y + 6); Console.Write("              |     \\   j  |    \\            _,-'\" .'    ,'\n");
                Console.SetCursorPosition(x, y + 7); Console.Write("              .      \\  |  |     \\         ,'   _,'    ,'\n");
                Console.SetCursorPosition(x, y + 8); Console.Write("               \\      `j   |      \\      .'   ,'      /\n");
                Console.SetCursorPosition(x, y + 9); Console.Write("                `.     |   |       \\   ,'   ,'       /\n");
                Console.SetCursorPosition(x, y + 10); Console.Write("                  \\    |   |        \\ /    /        /\n");
                Console.SetCursorPosition(x, y + 11); Console.Write("  _,-''\"\"\"\"'\"\"'\"\"`--. j    |         V    /      _,+............._\n");
                Console.SetCursorPosition(x, y + 12); Console.Write("-=`...-----...__     `|    |         .   /   _.-'        _,.--\"\",..=.\n");
                Console.SetCursorPosition(x, y + 13); Console.Write("      `-.       `._   |    |          L,'  ,'       _,.-'    ,-'\n");
                Console.SetCursorPosition(x, y + 14); Console.Write("         `.        `. |    |          |  .'     _.-'       ,'\n");
                Console.SetCursorPosition(x, y + 15); Console.Write("            .        \\|    '          L/    _,-'          /\n");
                Console.SetCursorPosition(x, y + 16); Console.Write("             `._      `.    L        /   _,'            ,'\n");
                Console.SetCursorPosition(x, y + 17); Console.Write("                `-._    \\   `       ,' ,'             ,'\n");
                Console.SetCursorPosition(x, y + 18); Console.Write("                    `-.. `   \\     /,-'           _.-'\n");
                Console.SetCursorPosition(x, y + 19); Console.Write("                      ,'\"-..  .   /_,..---\"`+'\"\"\"\"\n");
                Console.SetCursorPosition(x, y + 20); Console.Write("                     /           '           `.\n");
                Console.SetCursorPosition(x, y + 21); Console.Write("                    j                          .\n");
                Console.SetCursorPosition(x, y + 22); Console.Write("                   .                           |\n");
                Console.SetCursorPosition(x, y + 23); Console.Write("                   |   .-.       ,.            |\n");
                Console.SetCursorPosition(x, y + 24); Console.Write("                   |    -'       `.'           |\n");
                Console.SetCursorPosition(x, y + 25); Console.Write("                   `                           '\n");
                Console.SetCursorPosition(x, y + 26); Console.Write("                    `.      .--.             ,'\n");
                Console.SetCursorPosition(x, y + 27); Console.Write("                      `.    `._|          ,-'\n");
                Console.SetCursorPosition(x, y + 28); Console.Write("                    _.-`   ,..______.. .  `-.\n");
                Console.SetCursorPosition(x, y + 29); Console.Write("                  ,'       |          |      `.\n");
                Console.SetCursorPosition(x, y + 30); Console.Write("                ,'         '          |        `.\n");
                Console.SetCursorPosition(x, y + 31); Console.Write("               /         ,'            .         .\n");
                Console.SetCursorPosition(x, y + 32); Console.Write("               \\     _,-'               `._      |\n");
                Console.SetCursorPosition(x, y + 33); Console.Write("                `---'                      `-....' \n");
            }

            else if (pokenumber == 44)
            {
                Console.SetCursorPosition(x, y); Console.Write("                            ,.--\"\"+`-,\n");
                Console.SetCursorPosition(x, y + 1); Console.Write("                    ___,..-'  C'  `.' `-.\n");
                Console.SetCursorPosition(x, y + 2); Console.Write("                 .\"|      `-,...._   ___){.\n");
                Console.SetCursorPosition(x, y + 3); Console.Write("                /'\"|   _,..^..__ _'\"'     `-.\n");
                Console.SetCursorPosition(x, y + 4); Console.Write("               ' `\" ,-`c.   ..  `.     ,\"\".  `.\n");
                Console.SetCursorPosition(x, y + 5); Console.Write("              /,  ,'       `._'   `.|)  \"'    /\\           .\n");
                Console.SetCursorPosition(x, y + 6); Console.Write("          _,.|'- /  .-.             \\         `\".          |\\\n");
                Console.SetCursorPosition(x, y + 7); Console.Write("      _.-'   |  |   '-        _     |           |          | \\\n");
                Console.SetCursorPosition(x, y + 8); Console.Write("    ,'       |  |            \\.'    |           |          |  .\n");
                Console.SetCursorPosition(x, y + 9); Console.Write("   ,          . |                   |           j          j  |\n");
                Console.SetCursorPosition(x, y + 10); Console.Write("  /_.-'\"\"\"'\"'){.+|                   |          /         ,'   |\n");
                Console.SetCursorPosition(x, y + 11); Console.Write(" /'       ,-'    \\                 /        _,'-..___,..'     j\n");
                Console.SetCursorPosition(x, y + 12); Console.Write("j|       /        `.             ,^.......-+                 /\n");
                Console.SetCursorPosition(x, y + 13); Console.Write("||      /     _,-.\"\"'-..____,..-'-._        \\               /\n");
                Console.SetCursorPosition(x, y + 14); Console.Write("| \\   ,|    ,' .'   ,'    .         `.       \\__         ,-'\n");
                Console.SetCursorPosition(x, y + 15); Console.Write(" . `-'.|   /  /  _.'       `.         \\       . `---+.-'|\n");
                Console.SetCursorPosition(x, y + 16); Console.Write("  `._, ' j   j '\"            `--..     `.     |.     `. |\n");
                Console.SetCursorPosition(x, y + 17); Console.Write("        .|   |                           .    ||       `|\n");
                Console.SetCursorPosition(x, y + 18); Console.Write("        `'   |,----......__...._         '    ||        |\n");
                Console.SetCursorPosition(x, y + 19); Console.Write("             |`._=-=====___''-. `-.      |   / |        '\n");
                Console.SetCursorPosition(x, y + 20); Console.Write("          _,.L   `\"\"\"------|  .---'      |  /`-+_\n");
                Console.SetCursorPosition(x, y + 21); Console.Write("     ,'\"`/    \\            |  |          |.'.    `\"\"'-.\n");
                Console.SetCursorPosition(x, y + 22); Console.Write("     |   \\__,.'`           | j              _+-._     |\n");
                Console.SetCursorPosition(x, y + 23); Console.Write("     |    `     `._        | |             ,     `---\"\n");
                Console.SetCursorPosition(x, y + 24); Console.Write("      .    `...,-' +._      `|            /\n");
                Console.SetCursorPosition(x, y + 25); Console.Write("       `.       -'\"   `-...________,..--.  `.,..\n");
                Console.SetCursorPosition(x, y + 26); Console.Write("         \\     |                         `.     |\n");
                Console.SetCursorPosition(x, y + 27); Console.Write("          `._  |                          '    /\n");
                Console.SetCursorPosition(x, y + 28); Console.Write("             `'                      _,.-'    /\n");
                Console.SetCursorPosition(x, y + 29); Console.Write("                                  ,-'        /\n");
                Console.SetCursorPosition(x, y + 30); Console.Write("                                 `.       _,'\n");
                Console.SetCursorPosition(x, y + 31); Console.Write("                                   `'----' \n");
            }

            else if (pokenumber == 45)
            {
                Console.SetCursorPosition(x, y); Console.Write("                        _..--------..__\n");
                Console.SetCursorPosition(x, y + 1); Console.Write("                    ,-\"'    __         `-.\n");
                Console.SetCursorPosition(x, y + 2); Console.Write("                 ,-'    .-\"'  |   .--.    `. ____\n");
                Console.SetCursorPosition(x, y + 3); Console.Write("               ,'  _..   `\"\"\"'    `-'  _.-'\"'    `\"--._\n");
                Console.SetCursorPosition(x, y + 4); Console.Write("             .'   `..'  _           _,' ,\"\"`,        __`._\n");
                Console.SetCursorPosition(x, y + 5); Console.Write("      _.--\"\"\"`\"---.._  '.\"   ___..,'__   `\"'        `. `. `.\n");
                Console.SetCursorPosition(x, y + 6); Console.Write("    .'__       .-,   `'-+.--\"-------..`-.   `=`       `\"'   \\\n");
                Console.SetCursorPosition(x, y + 7); Console.Write("  ,'(__,'   _   \"       |( ,-'\"\"'\"\"'`-.`,|  _.----\"\"'\"`--.../\n");
                Console.SetCursorPosition(x, y + 8); Console.Write(" /         |_)          | `-...______,.' |-'        `-'      `-.\n");
                Console.SetCursorPosition(x, y + 9); Console.Write("j                      .'_,..........__,'     c.          .-.   `.\n");
                Console.SetCursorPosition(x, y + 10); Console.Write("|        _,..  `+' _,.-'\"        .,    `-._               \\__'    `\n");
                Console.SetCursorPosition(x, y + 11); Console.Write("|       `___,'   ,'   .){\"',     '\"    .-,  `-.     ,--.      _     |\n");
                Console.SetCursorPosition(x, y + 12); Console.Write(" \\             ,'       \"\"             `      `.   `--'    ,' |    |\n");
                Console.SetCursorPosition(x, y + 13); Console.Write("  `.         ,'  .'\"\"`.          ){\",       __   \\          `..'    '\n");
                Console.SetCursorPosition(x, y + 14); Console.Write("    `._     .    `---'            \"       |  `.  \\               ,'\n");
                Console.SetCursorPosition(x, y + 15); Console.Write("       `\"--+                   __          `\"'    .           _,'\n");
                Console.SetCursorPosition(x, y + 16); Console.Write("           |                 ('  )                |...,,...-'\"\n");
                Console.SetCursorPosition(x, y + 17); Console.Write("            `.                 \"'                ,'\n");
                Console.SetCursorPosition(x, y + 18); Console.Write("              `-..__                          _,'\n");
                Console.SetCursorPosition(x, y + 19); Console.Write("                    `+---.=,---------+.----+\"'\n");
                Console.SetCursorPosition(x, y + 20); Console.Write("                ,'\"`/     \"          \"   ,-.\\\n");
                Console.SetCursorPosition(x, y + 21); Console.Write("                \\    \\         _        /  | +.\n");
                Console.SetCursorPosition(x, y + 22); Console.Write("               .`.            '/       /   | | \\\n");
                Console.SetCursorPosition(x, y + 23); Console.Write("             ,'   A   '               /    j |  `.\n");
                Console.SetCursorPosition(x, y + 24); Console.Write("            '    / \\   \\             j    / /`.   \\\n");
                Console.SetCursorPosition(x, y + 25); Console.Write("             `--'   \\   \\            |   j,'   `.,'\n");
                Console.SetCursorPosition(x, y + 26); Console.Write("                      . |-.........,.|   .\n");
                Console.SetCursorPosition(x, y + 27); Console.Write("                       `'            `,.' \n");
            }

            else if (pokenumber == 46)
            {
                Console.SetCursorPosition(x, y); Console.Write("           ____                               ____\n");
                Console.SetCursorPosition(x, y + 1); Console.Write("      ,-\"|\"    \"\",._                    _,--\"' |  ``-.\n");
                Console.SetCursorPosition(x, y + 2); Console.Write("     /   \\.   _,'   `-.               ,'  \\   ,'    ,-\".\n");
                Console.SetCursorPosition(x, y + 3); Console.Write("    /      `\"'        |              /     \\.'      |   L\n");
                Console.SetCursorPosition(x, y + 4); Console.Write("   /_     .-..    ,'\"\"|             |   _,.    ,--. `.__|\n");
                Console.SetCursorPosition(x, y + 5); Console.Write("  j  \\   /    |  /    |     _____   `  j   \\  |    \\     L\n");
                Console.SetCursorPosition(x, y + 6); Console.Write("  |  |   `    L  \\   / _.\"\"|    .\"'--._|    |  `.__/     |\n");
                Console.SetCursorPosition(x, y + 7); Console.Write("  |  '    `-./    `.+-'    `..-'       |-.  |        ,\"`.|\n");
                Console.SetCursorPosition(x, y + 8); Console.Write("  `-'            ,'  )   __,...__       ` `-._      /   ||\n");
                Console.SetCursorPosition(x, y + 9); Console.Write("   `,---.      ,'  .'_,-'        ``-._   `-.__|-.../_...'\n");
                Console.SetCursorPosition(x, y + 10); Console.Write("    `-..,\\.--'/..-`.'  ..-------..._ ,-.\"'`-.    `.\n");
                Console.SetCursorPosition(x, y + 11); Console.Write("            ,\"`.__  `.'    `'  `-' .(   ).   \\     . ,--._\n");
                Console.SetCursorPosition(x, y + 12); Console.Write("         ,\"|`._)  `. |  _      ,.  |`-,'  `. |     |'     `.\n");
                Console.SetCursorPosition(x, y + 13); Console.Write("        / _|  .    | | `-'     -'  |  .   ,' |,-\"\"-`.,--.   `.\n");
                Console.SetCursorPosition(x, y + 14); Console.Write("       /\"\" `.  `\"-'  '    ___       `. `\"'  .'       .   I-.  `.\n");
                Console.SetCursorPosition(x, y + 15); Console.Write("     ,'      `-..,.-' ,-'\"   `-.      `\"--'\"/         \\   \\ `.  `\n");
                Console.SetCursorPosition(x, y + 16); Console.Write("    /         |      /         |\"-.        /           `.  `. `. \\\n");
                Console.SetCursorPosition(x, y + 17); Console.Write("   /          |.    | `. ___ ,.'  |       j            \\ `   `. \\ .\n");
                Console.SetCursorPosition(x, y + 18); Console.Write("  j           | `. (`._ \\  .\"   _,{      ,'             L `.   . \\|\n");
                Console.SetCursorPosition(x, y + 19); Console.Write("  |           |,' `-.  `\\   \",-'  |_,..-'|              |   L  |  '\n");
                Console.SetCursorPosition(x, y + 20); Console.Write("  |           |      `-..'  '__,.-'      |              |    . |\n");
                Console.SetCursorPosition(x, y + 21); Console.Write(" /|            L        `\"\"\"'           j               |    | |\n");
                Console.SetCursorPosition(x, y + 22); Console.Write("j |            |                        |              j     | |\n");
                Console.SetCursorPosition(x, y + 23); Console.Write("| |             L                       |              .     ' j\n");
                Console.SetCursorPosition(x, y + 24); Console.Write("| [             |                       |             /       '\n");
                Console.SetCursorPosition(x, y + 25); Console.Write(" - `.           |                       |            /\n");
                Console.SetCursorPosition(x, y + 26); Console.Write("    `.   ,'\"\"`-,                        |.--..__    /\n");
                Console.SetCursorPosition(x, y + 27); Console.Write("      `.'      \\                        '       `.,'\n");
                Console.SetCursorPosition(x, y + 28); Console.Write("        `.      \\                     ,'      _,-'\n");
                Console.SetCursorPosition(x, y + 29); Console.Write("          `.     `.                 ,'    _,-'\n");
                Console.SetCursorPosition(x, y + 30); Console.Write("            `-..__ \\              <___..-\" \n");
            }

            else if (pokenumber == 47)
            {
                Console.SetCursorPosition(x, y); Console.Write("                                       _______\n");
                Console.SetCursorPosition(x, y + 1); Console.Write("                                   _,\"\"|      `-._\n");
                Console.SetCursorPosition(x, y + 2); Console.Write("                                 ,\"  _.'          `.\n");
                Console.SetCursorPosition(x, y + 3); Console.Write("                                ,'\"\"'               `.\n");
                Console.SetCursorPosition(x, y + 4); Console.Write("                              ,'       ,.----._  .--. \\\n");
                Console.SetCursorPosition(x, y + 5); Console.Write("                             /        `____    \\  \\_ ) \\\n");
                Console.SetCursorPosition(x, y + 6); Console.Write("                           ,'              \"\"`-'    \"   L\n");
                Console.SetCursorPosition(x, y + 7); Console.Write("                         ,'                             |\n");
                Console.SetCursorPosition(x, y + 8); Console.Write("                       ,'.'                              L\n");
                Console.SetCursorPosition(x, y + 9); Console.Write("                     ,'-'    _,...._             .\"\"`.   |\n");
                Console.SetCursorPosition(x, y + 10); Console.Write("                  _,'     ,-'       `.       ,.   `.  `. '\n");
                Console.SetCursorPosition(x, y + 11); Console.Write("              _.-'      .'     ______/       `_)    `._;  \\\n");
                Console.SetCursorPosition(x, y + 12); Console.Write("           ,-'           `-\"'\"\"                            \\\n");
                Console.SetCursorPosition(x, y + 13); Console.Write("         ,'   ,.---,                                        \\\n");
                Console.SetCursorPosition(x, y + 14); Console.Write("        /   .'   _,                    ,\"\"\"`-._         .\"`-.'\n");
                Console.SetCursorPosition(x, y + 15); Console.Write("        7-\"'-+--'     ___               `-.__  `.       `.   `\n");
                Console.SetCursorPosition(x, y + 16); Console.Write("      ,'      \\_____.'   `.--.'\"\"`.          `-.'         `-..\\\n");
                Console.SetCursorPosition(x, y + 17); Console.Write("     /         `.`._|     | |      |`--...,.---.               `.\n");
                Console.SetCursorPosition(x, y + 18); Console.Write("   ,'      . `  |    \\    ,-|     ,'..,-'       `.,_             \\\n");
                Console.SetCursorPosition(x, y + 19); Console.Write("  /     \"       |.,.._\"'\"'   `-..'  .'            \\ `\"-.._      __\\\n");
                Console.SetCursorPosition(x, y + 20); Console.Write(" /              | '-..\"\"..________./              |..-\"\". `+.  (  ,\n");
                Console.SetCursorPosition(x, y + 21); Console.Write("j               | L\"`--._....___  /               |_...  `/  \\  -.'\n");
                Console.SetCursorPosition(x, y + 22); Console.Write("|             | | |      `--._  \"/                j__..`  `.  `.-'\n");
                Console.SetCursorPosition(x, y + 23); Console.Write("|          /  j ' |           \"./       ,.'    \" /_..-\"'\\   \\.  `.\n");
                Console.SetCursorPosition(x, y + 24); Console.Write("|         /' / /| |            /         ' \"    /'       \\   \\`.  `.\n");
                Console.SetCursorPosition(x, y + 25); Console.Write(" L       / |V j | |           /               ,'          \\   \\ \\   `.\n");
                Console.SetCursorPosition(x, y + 26); Console.Write(" |      j  |  | |  L         j              ,'            /    | \\   |\n");
                Console.SetCursorPosition(x, y + 27); Console.Write("  L     |  |  | `.  \\        |            ,'             j    /   \\  |\n");
                Console.SetCursorPosition(x, y + 28); Console.Write("  .    j   `. L   `._`.     j          _,'               '   '     . |\n");
                Console.SetCursorPosition(x, y + 29); Console.Write("   \\   |     `.\\     `\"`    |       _.'                 /   /      | |\n");
                Console.SetCursorPosition(x, y + 30); Console.Write("    \\  |       `           /   _,.-'                   /   /       j .\n");
                Console.SetCursorPosition(x, y + 31); Console.Write("     \\ |                  /.-\"'                    _,-'  ,'       /,'\n");
                Console.SetCursorPosition(x, y + 32); Console.Write("      '                                           '----\"' \n");
            }

            else if (pokenumber == 48)
            {
                Console.SetCursorPosition(x, y); Console.Write("                                           _.----.\n");
                Console.SetCursorPosition(x, y + 1); Console.Write("                                       __,'   _,-'\n");
                Console.SetCursorPosition(x, y + 2); Console.Write("                                  _..\"_..---\"'\n");
                Console.SetCursorPosition(x, y + 3); Console.Write("                               _.'_,-'_____________,......\n");
                Console.SetCursorPosition(x, y + 4); Console.Write("                    `. .   ._,_.-',--',.-...........    __;\n");
                Console.SetCursorPosition(x, y + 5); Console.Write("                 __  `/ ),`','_.'..,--'_,.---;      `\"\"\"\n");
                Console.SetCursorPosition(x, y + 6); Console.Write("              `.,..`\"'  ,.'.-_.-',..-'\"   ,-'\n");
                Console.SetCursorPosition(x, y + 7); Console.Write("            _,..        ___-'           ,'\n");
                Console.SetCursorPosition(x, y + 8); Console.Write("         ,-'    |     ,'   `-.         '----..\n");
                Console.SetCursorPosition(x, y + 9); Console.Write("       ,'       |   ,'        \\             \\.\n");
                Console.SetCursorPosition(x, y + 10); Console.Write("      /         '  /           L            `-\n");
                Console.SetCursorPosition(x, y + 11); Console.Write("     |        ,'  j            |        ,     `.\n");
                Console.SetCursorPosition(x, y + 12); Console.Write("     |    _,+----.|            |       . `.    .-.\n");
                Console.SetCursorPosition(x, y + 13); Console.Write("     |   /\\    ,..\\L           '       |   .   |`---\n");
                Console.SetCursorPosition(x, y + 14); Console.Write("     |`-| ,\\___|  | \\.        /        |   |  .--            .,|\n");
                Console.SetCursorPosition(x, y + 15); Console.Write("     |   V     / ,   '-.....'\"         |   |   `.           ,.-'`'\n");
                Console.SetCursorPosition(x, y + 16); Console.Write("     |\\       `-'                      `._,     _\\\n");
                Console.SetCursorPosition(x, y + 17); Console.Write("     '|                                         ` _   .-.--\".-\n");
                Console.SetCursorPosition(x, y + 18); Console.Write("  _,.. |                                       ,./`.,/   ,.-'\n");
                Console.SetCursorPosition(x, y + 19); Console.Write(".' .   |,                            ,---,     \"._      /\n");
                Console.SetCursorPosition(x, y + 20); Console.Write("|  `     `.                         /   `.     ,--     /.----...,\n");
                Console.SetCursorPosition(x, y + 21); Console.Write(" \\         \\                        \\   .\"    '.._             |\n");
                Console.SetCursorPosition(x, y + 22); Console.Write("  `.        L                        `...'  `..--. -\"\"_..    _.'\n");
                Console.SetCursorPosition(x, y + 23); Console.Write("    `.      '.,`.                          ..'-.`,_      `-\"'\n");
                Console.SetCursorPosition(x, y + 24); Console.Write("      \\       \\` ',-                     .'     \\\n");
                Console.SetCursorPosition(x, y + 25); Console.Write("       `.      L  `.  .             ,.-'\"\\       \\\n");
                Console.SetCursorPosition(x, y + 26); Console.Write("         \\     |    '`.`. .-. .-..,..'.   \\       \\\n");
                Console.SetCursorPosition(x, y + 27); Console.Write("          `-._,'         `\". `-..          \\       `.\n");
                Console.SetCursorPosition(x, y + 28); Console.Write("                                            `. -.   |\n");
                Console.SetCursorPosition(x, y + 29); Console.Write("                                              '-.+--' \n");
            }

            else if (pokenumber == 49)
            {
                Console.SetCursorPosition(x, y); Console.Write("                      ,-\"\"-.                _ _,....._\n");
                Console.SetCursorPosition(x, y + 1); Console.Write("                    ,'     |            _,-\"_..----\"\"-\"\\\n");
                Console.SetCursorPosition(x, y + 2); Console.Write("              .   ,      ,'|         _,\"_.-'            |\n");
                Console.SetCursorPosition(x, y + 3); Console.Write("            ,'/  /|    ,'  |      ,-'_,'                |\n");
                Console.SetCursorPosition(x, y + 4); Console.Write("           / /  /j    /    |   ,-'_,'            __,..--'\n");
                Console.SetCursorPosition(x, y + 5); Console.Write("          / /  / '   /    j  ,' ,'          _.--'      /\n");
                Console.SetCursorPosition(x, y + 6); Console.Write("         / /  / /   /     |,' .'         ,-'          /\n");
                Console.SetCursorPosition(x, y + 7); Console.Write("        / /  j /   /     /' .'        ,-'            /\n");
                Console.SetCursorPosition(x, y + 8); Console.Write("       / /   |j   /  __.' ,'       _,'             ,'\n");
                Console.SetCursorPosition(x, y + 9); Console.Write("      / /  ,\",|  /,-\".' ,'       ,){_______________/\n");
                Console.SetCursorPosition(x, y + 10); Console.Write("     / , ,','j  /\", /,\"/|      ,'                /\n");
                Console.SetCursorPosition(x, y + 11); Console.Write("    /  |' /  |_/ / / .' |    ,'                 /\n");
                Console.SetCursorPosition(x, y + 12); Console.Write("   /   |,'  ,' .' / /  j   ,'                _,`\n");
                Console.SetCursorPosition(x, y + 13); Console.Write("  j   '/ ,-' .'  / /   | ,'              _.-\" |\n");
                Console.SetCursorPosition(x, y + 14); Console.Write(" .'   j.'  ,'|  / /    ,'          _,.--'     j\n");
                Console.SetCursorPosition(x, y + 15); Console.Write(" | _.-_,../| | / /    |      _,,-'\"        _./\n");
                Console.SetCursorPosition(x, y + 16); Console.Write(" j  ,( )__ `.// /   ,'|  _.-'          _.-'  |\n");
                Console.SetCursorPosition(x, y + 17); Console.Write(".   | `(  ) |/ /   /  ,`+        _,..-'      '\n");
                Console.SetCursorPosition(x, y + 18); Console.Write("|   |   \"'  | /  ,'_,'   `.  _,-'           .\n");
                Console.SetCursorPosition(x, y + 19); Console.Write("|   .`.___,'--. /,'       ,+\"               |\n");
                Console.SetCursorPosition(x, y + 20); Console.Write("|  | `/         \\     ,-'\"\"'\"\"-.._         .'\n");
                Console.SetCursorPosition(x, y + 21); Console.Write(" .,j /           \\ ,-'         \\  `-.      /\n");
                Console.SetCursorPosition(x, y + 22); Console.Write("  `|'      /`.    Y-\"'\"\"\"---.._|     `.   /\n");
                Console.SetCursorPosition(x, y + 23); Console.Write("   |     ,' / 7   |            |`-.    \\ /\n");
                Console.SetCursorPosition(x, y + 24); Console.Write("   |___,'  / /`.  |_           |   `.  ,'\n");
                Console.SetCursorPosition(x, y + 25); Console.Write("   `.___..' / /  /  .,.__      |     `.\n");
                Console.SetCursorPosition(x, y + 26); Console.Write("     `.____/,' _'   /`.  '`-.._|      Y\n");
                Console.SetCursorPosition(x, y + 27); Console.Write("       `-+----'   ,'   7-..   j -.     .\n");
                Console.SetCursorPosition(x, y + 28); Console.Write("         |  __.,-'    -|   `-.+   `-.  |\n");
                Console.SetCursorPosition(x, y + 29); Console.Write("         |\"'      ,.'` ',   /  `._   `.|\n");
                Console.SetCursorPosition(x, y + 30); Console.Write("         |_  _,,.'      |`..      `.   |\n");
                Console.SetCursorPosition(x, y + 31); Console.Write("          .'\"          ,'  \\.       `. \"-.\n");
                Console.SetCursorPosition(x, y + 32); Console.Write("          `        ,./\"|\\   \\|        `.  |\n");
                Console.SetCursorPosition(x, y + 33); Console.Write("           `v.^.,`.    | \\   )     ,    `.|\n");
                Console.SetCursorPosition(x, y + 34); Console.Write("             `._     .'   `./_\\.--' .     `.\n");
                Console.SetCursorPosition(x, y + 35); Console.Write("                `---'               '      /\n");
                Console.SetCursorPosition(x, y + 36); Console.Write("                                     `. _,'\n");
                Console.SetCursorPosition(x, y + 37); Console.Write("                                       \" \n");
            }

            else if (pokenumber == 50)
            {
                Console.SetCursorPosition(x, y); Console.Write("                     _,.---'\"\"'\"--.._\n");
                Console.SetCursorPosition(x, y + 1); Console.Write("                   ,\"                `-.\n");
                Console.SetCursorPosition(x, y + 2); Console.Write("                 ,'                     `.\n");
                Console.SetCursorPosition(x, y + 3); Console.Write("                /     _       ,.          `.\n");
                Console.SetCursorPosition(x, y + 4); Console.Write("               /     ||      |\"|            \\\n");
                Console.SetCursorPosition(x, y + 5); Console.Write("              /      ||      | |             \\\n");
                Console.SetCursorPosition(x, y + 6); Console.Write("             /       .'      `_'              L\n");
                Console.SetCursorPosition(x, y + 7); Console.Write("            j                                 |\n");
                Console.SetCursorPosition(x, y + 8); Console.Write("            |        __,...._                 |\n");
                Console.SetCursorPosition(x, y + 9); Console.Write("            |      .\"        `.               |\n");
                Console.SetCursorPosition(x, y + 10); Console.Write("            |      '           )              |\n");
                Console.SetCursorPosition(x, y + 11); Console.Write("            |       `-...__,.-'               |\n");
                Console.SetCursorPosition(x, y + 12); Console.Write("            |                                 |\n");
                Console.SetCursorPosition(x, y + 13); Console.Write("            |                                 |\n");
                Console.SetCursorPosition(x, y + 14); Console.Write("         ...|                                 |\n");
                Console.SetCursorPosition(x, y + 15); Console.Write("      _,'   |                                 |\n");
                Console.SetCursorPosition(x, y + 16); Console.Write("  _,-'  ___ |                                 |.-----_\n");
                Console.SetCursorPosition(x, y + 17); Console.Write("-' ,.--`.  \\|                                 |     . \\\n");
                Console.SetCursorPosition(x, y + 18); Console.Write(",-'     ,  |--,                               |  _,'   `- -----._\n");
                Console.SetCursorPosition(x, y + 19); Console.Write("      ,' ,'    - ----.            _,..       _|.',               \\\n");
                Console.SetCursorPosition(x, y + 20); Console.Write(" ,-\"\"' .-             \\  ____   `'  _-'`  ,-'     `.              `-\n");
                Console.SetCursorPosition(x, y + 21); Console.Write(" .--'\"`   ,--){`.       --    ,\"'. ,'  ,'`,_\n");
                Console.SetCursorPosition(x, y + 22); Console.Write("        _'__,' |  _,..'_    ,){______,-     --.         _.\n");
                Console.SetCursorPosition(x, y + 23); Console.Write("        -__..--' '      ` ..`L________,___ _,     _,.-'\n");
                Console.SetCursorPosition(x, y + 24); Console.Write("                                              '\" ' \n");
            }

            else if (pokenumber == 51)
            {
                Console.SetCursorPosition(x, y); Console.Write("                                        _..-----._\n");
                Console.SetCursorPosition(x, y + 1); Console.Write("                                     ,-'__      __`-.\n");
                Console.SetCursorPosition(x, y + 2); Console.Write("                                   ,'  '  `    /  |  \\\n");
                Console.SetCursorPosition(x, y + 3); Console.Write("                   _____          /   ,...            \\\n");
                Console.SetCursorPosition(x, y + 4); Console.Write("              _.-\"\"     `-.      |   /    `. ,-\"\"`.    \\\n");
                Console.SetCursorPosition(x, y + 5); Console.Write("             /             `.    |  |   `  || .    |    .\n");
                Console.SetCursorPosition(x, y + 6); Console.Write("            j             _. \\   |  `..__.' '      |    |\n");
                Console.SetCursorPosition(x, y + 7); Console.Write("           .     __     ,'--. \\ j       ,....`....-'    |\n");
                Console.SetCursorPosition(x, y + 8); Console.Write("           |     .---. .     | \\|      (__    )         |\n");
                Console.SetCursorPosition(x, y + 9); Console.Write("           |   .'   . || '   |  Y         \"\"\"'          |\n");
                Console.SetCursorPosition(x, y + 10); Console.Write("           |   |      | `-..-'  |                       |\n");
                Console.SetCursorPosition(x, y + 11); Console.Write("           |    `-...',.--.     |      ,--,.--\"\"'\"-.._ j\n");
                Console.SetCursorPosition(x, y + 12); Console.Write("           |        .\"    _|    |      .-\" |    ,\"\"\"`.`|\n");
                Console.SetCursorPosition(x, y + 13); Console.Write("           |        `---\"'      `.    /    '   /     |  `\n");
                Console.SetCursorPosition(x, y + 14); Console.Write("           |                     L   /,-\"\"-.   _,...     \\\n");
                Console.SetCursorPosition(x, y + 15); Console.Write("       _._  L                    |  j|    _ | /     `.    L\n");
                Console.SetCursorPosition(x, y + 16); Console.Write("     ,'   `-|                     L ||      | |  '   |    |\n");
                Console.SetCursorPosition(x, y + 17); Console.Write(" ,--\"     _||                     |j  `----'  `      |    |\n");
                Console.SetCursorPosition(x, y + 18); Console.Write("\"       ,',){|                     .     ,-\"\"--.`-- -'     | _\n");
                Console.SetCursorPosition(x, y + 19); Console.Write("     ,-._'  '.                    |     `-...__)         j'\" `-.\n");
                Console.SetCursorPosition(x, y + 20); Console.Write("    ){,.._){.   `.               ,-'|                      |_,.._ ---.\n");
                Console.SetCursorPosition(x, y + 21); Console.Write("               _){......--.,..-'   |                      |     `.  ,`.\n");
                Console.SetCursorPosition(x, y + 22); Console.Write("          `\"\"\"' ..../__,  \"----.\"'-\\  _,-'\"`._           | .   __\n");
                Console.SetCursorPosition(x, y + 23); Console.Write("                                '-..- .....- .`-...,-\"\"`-,|___.\n");
                Console.SetCursorPosition(x, y + 24); Console.Write("                                                '\"-----\"'. \n");
            }

            else if (pokenumber == 52)
            {
                Console.SetCursorPosition(x, y); Console.Write("                                        .\n");
                Console.SetCursorPosition(x, y + 1); Console.Write("                         |              |\n");
                Console.SetCursorPosition(x, y + 2); Console.Write("                         |             ,|\n");
                Console.SetCursorPosition(x, y + 3); Console.Write("                ,_       |\\            F'   ,.-\"\"`.\n");
                Console.SetCursorPosition(x, y + 4); Console.Write("               /  `-._   |`           // ,-\"_,..  |\n");
                Console.SetCursorPosition(x, y + 5); Console.Write("              |   ___ `. | \\ ,\"\"\"`-. /.-' ,'    ' |_....._\n");
                Console.SetCursorPosition(x, y + 6); Console.Write("              |  /   `-.`.  L......|j j_.'      ` |       `._\n");
                Console.SetCursorPosition(x, y + 7); Console.Write("              | |      _,'| |______|' | '-._     ||  ,.-.    `.\n");
                Console.SetCursorPosition(x, y + 8); Console.Write("               L|    ,'   | |      | j      `-.  || '    `.    \\\n");
                Console.SetCursorPosition(x, y + 9); Console.Write("___            | \\_,'     | |`\"----| |         `.||       |\\    \\\n");
                Console.SetCursorPosition(x, y + 10); Console.Write(" \"\"=+...__     `,'   ,.-.   |....._|   _....     Y \\      j_),..+=--\n");
                Console.SetCursorPosition(x, y + 11); Console.Write("     `\"-._\"._  .   ,' |  `   \\    /  ,' |   \\     \\ j,..-\"_..+-\"  L\n");
                Console.SetCursorPosition(x, y + 12); Console.Write("          `-._-+. j   !   \\   `--'  .   !    \\  ,.-\" _..<._  |    |\n");
                Console.SetCursorPosition(x, y + 13); Console.Write("              |-. |   |    L        |   !     |  .-/'      `.|-.,-|\n");
                Console.SetCursorPosition(x, y + 14); Console.Write("              |__ '   '    |        '   |    /    /|   `, -. |   j\n");
                Console.SetCursorPosition(x, y + 15); Console.Write("        _..--'\"__  `-.___,'          `.___,.'  __/_|_  /   / '   |\n");
                Console.SetCursorPosition(x, y + 16); Console.Write("   _.-_..---\"\"_.-\\                            .,...__\"\"--./L/_   |\n");
                Console.SetCursorPosition(x, y + 17); Console.Write(" -'\"\"'     ,\"\"  ,-`-.    .___.,...___,    _,.+\"      \"\"\"\"`-+-==++-\n");
                Console.SetCursorPosition(x, y + 18); Console.Write("          / /  `.   )\"-.._`v \\|    V/  /-'    \\._,._.'\"-. /    /\n");
                Console.SetCursorPosition(x, y + 19); Console.Write("          ` `.  )---.     `\"\"\\\\__  / .'        /    \\    Y\"._.'\n");
                Console.SetCursorPosition(x, y + 20); Console.Write("           `\"'`\"     `-.     /|._\"\"_/         |  ,..   _ |  |\n");
                Console.SetCursorPosition(x, y + 21); Console.Write("                        `\"\"\"' |  \"'           `. `-'  (_|,-.'\n");
                Console.SetCursorPosition(x, y + 22); Console.Write("                               \\               |`       .`-\n");
                Console.SetCursorPosition(x, y + 23); Console.Write("                                `.           . j`._    /\n");
                Console.SetCursorPosition(x, y + 24); Console.Write("                                 |`.._     _.'|    `\"\"/\n");
                Console.SetCursorPosition(x, y + 25); Console.Write("                                 |    /\"\"'\"   |  .\". j\n");
                Console.SetCursorPosition(x, y + 26); Console.Write("                                .`.__j         \\ `.' |\n");
                Console.SetCursorPosition(x, y + 27); Console.Write("                                j    |          `._.'\n");
                Console.SetCursorPosition(x, y + 28); Console.Write("                               /     |\n");
                Console.SetCursorPosition(x, y + 29); Console.Write("                              /,  ,  \\\n");
                Console.SetCursorPosition(x, y + 30); Console.Write("                              \\|  |   L\n");
                Console.SetCursorPosition(x, y + 31); Console.Write("                               `..|_..' \n");
            }

            else if (pokenumber == 53)
            {
                Console.SetCursorPosition(x, y); Console.Write("\n");
                Console.SetCursorPosition(x, y + 1); Console.Write("         ,-\"\"--.\n");
                Console.SetCursorPosition(x, y + 2); Console.Write("        /       \\\n");
                Console.SetCursorPosition(x, y + 3); Console.Write("        | ,\"`.   L\n");
                Console.SetCursorPosition(x, y + 4); Console.Write("        |     |  |\n");
                Console.SetCursorPosition(x, y + 5); Console.Write("        \\_   /   |\n");
                Console.SetCursorPosition(x, y + 6); Console.Write("          `-' |  |\n");
                Console.SetCursorPosition(x, y + 7); Console.Write("              |  |\n");
                Console.SetCursorPosition(x, y + 8); Console.Write("              |  |\n");
                Console.SetCursorPosition(x, y + 9); Console.Write("              j  j\n");
                Console.SetCursorPosition(x, y + 10); Console.Write("             .  .\n");
                Console.SetCursorPosition(x, y + 11); Console.Write("             j  j\n");
                Console.SetCursorPosition(x, y + 12); Console.Write("            .  .\n");
                Console.SetCursorPosition(x, y + 13); Console.Write("            |  |\n");
                Console.SetCursorPosition(x, y + 14); Console.Write("            |  |\n");
                Console.SetCursorPosition(x, y + 15); Console.Write("            |  |\n");
                Console.SetCursorPosition(x, y + 16); Console.Write("            L  |\n");
                Console.SetCursorPosition(x, y + 17); Console.Write("             \\_|._\n");
                Console.SetCursorPosition(x, y + 18); Console.Write("       _.-,-\"     `\".\n");
                Console.SetCursorPosition(x, y + 19); Console.Write("     ,' .'           \\\n");
                Console.SetCursorPosition(x, y + 20); Console.Write("    /  /              \\\n");
                Console.SetCursorPosition(x, y + 21); Console.Write(" _,'  /  /             \\\n");
                Console.SetCursorPosition(x, y + 22); Console.Write("<    /  /              |\\\n");
                Console.SetCursorPosition(x, y + 23); Console.Write("<+-'|  j               |/\n");
                Console.SetCursorPosition(x, y + 24); Console.Write(" `--+  |    ___        `    ..-.\n");
                Console.SetCursorPosition(x, y + 25); Console.Write("     \\ |  ,\"--.`.       \\__/,\"\".|\n");
                Console.SetCursorPosition(x, y + 26); Console.Write("      `-\\||    `.\\--\"\"\"\"' //    |\n");
                Console.SetCursorPosition(x, y + 27); Console.Write("         |`    / `          \\  ,'\n");
                Console.SetCursorPosition(x, y + 28); Console.Write("          \\|. / ,.  ,-.  _.. \\'___..\n");
                Console.SetCursorPosition(x, y + 29); Console.Write("      _____| Y |  `.`./ /  | ;.=\"\n");
                Console.SetCursorPosition(x, y + 30); Console.Write("         \"-+=+.|  ! \\  /_! / |_____\n");
                Console.SetCursorPosition(x, y + 31); Console.Write("          _|_L, `\"\"\" ._. \"\"  .---------\n");
                Console.SetCursorPosition(x, y + 32); Console.Write("       _+==+-`\\. .__,.|...,-=+\\._\n");
                Console.SetCursorPosition(x, y + 33); Console.Write("     ,\"\"   | .+-+ \\     )/.'   \\\"-+\n");
                Console.SetCursorPosition(x, y + 34); Console.Write("           ,+'  |` \\    // \\    \\\n");
                Console.SetCursorPosition(x, y + 35); Console.Write("          '|    | `.\\..'/   \\    \\\n");
                Console.SetCursorPosition(x, y + 36); Console.Write("           |    |   `\"\"'     \\    L\n");
                Console.SetCursorPosition(x, y + 37); Console.Write("           |    |             \\   |,._\n");
                Console.SetCursorPosition(x, y + 38); Console.Write("           |    `             _j .'  '>\n");
                Console.SetCursorPosition(x, y + 39); Console.Write("           |  ,..\\           /        /-.\n");
                Console.SetCursorPosition(x, y + 40); Console.Write("          ,^.' _  |          `.  .--.'  j\n");
                Console.SetCursorPosition(x, y + 41); Console.Write("        ,'  | |/  |-\"`.       |'-'\"\"``-|/\n");
                Console.SetCursorPosition(x, y + 42); Console.Write("        |_   .,---.  |\\\n");
                Console.SetCursorPosition(x, y + 43); Console.Write("        |/_,`-...-^..`' \n");
            }

            else if (pokenumber == 54)
            {
                Console.SetCursorPosition(x, y); Console.Write("                              ,-'   ,\"\",\n");
                Console.SetCursorPosition(x, y + 1); Console.Write("                             / / ,-'.-'\n");
                Console.SetCursorPosition(x, y + 2); Console.Write("                   _,..-----+-\".\".-'_,..\n");
                Console.SetCursorPosition(x, y + 3); Console.Write("           ,...,.\"'             `--.---'\n");
                Console.SetCursorPosition(x, y + 4); Console.Write("         /,..,'                     `.\n");
                Console.SetCursorPosition(x, y + 5); Console.Write("       ,'  .'                         `.\n");
                Console.SetCursorPosition(x, y + 6); Console.Write("      j   /                             `.\n");
                Console.SetCursorPosition(x, y + 7); Console.Write("      |  /,----._           ,.----.       .\n");
                Console.SetCursorPosition(x, y + 8); Console.Write("     ,  j    _   \\        .'  .,   `.     |\n");
                Console.SetCursorPosition(x, y + 9); Console.Write("   ,'   |        |  ____  |         | .\"--+,^.\n");
                Console.SetCursorPosition(x, y + 10); Console.Write("  /     |`-....-',-'    `._`--....-' _/      |\n");
                Console.SetCursorPosition(x, y + 11); Console.Write(" /      |     _,'          `--..__  `        '\n");
                Console.SetCursorPosition(x, y + 12); Console.Write("j       | ,-\"'    `    .'         `. `        `.\n");
                Console.SetCursorPosition(x, y + 13); Console.Write("|        .\\                        /  |         \\\n");
                Console.SetCursorPosition(x, y + 14); Console.Write("|         `\\                     ,'   |          \\\n");
                Console.SetCursorPosition(x, y + 15); Console.Write("|          |                    |   ,-|           `.\n");
                Console.SetCursorPosition(x, y + 16); Console.Write(".         ,'                    |-\"'  |             \\\n");
                Console.SetCursorPosition(x, y + 17); Console.Write(" \\       /                      `.    |              .\n");
                Console.SetCursorPosition(x, y + 18); Console.Write("  ` /  ,'                        |    `              |\n");
                Console.SetCursorPosition(x, y + 19); Console.Write("   /  /                          |     \\             |\n");
                Console.SetCursorPosition(x, y + 20); Console.Write("  /  |                           |      \\           /\n");
                Console.SetCursorPosition(x, y + 21); Console.Write(" /   |                           |       `.       _,\n");
                Console.SetCursorPosition(x, y + 22); Console.Write(".     .                         .'         `.__,.',.----,\n");
                Console.SetCursorPosition(x, y + 23); Console.Write("|      `.                     ,'             .-\"\"      /\n");
                Console.SetCursorPosition(x, y + 24); Console.Write("|        `._               _.'               |        /\n");
                Console.SetCursorPosition(x, y + 25); Console.Write("|           `---.......,--\"                  |      ,'\n");
                Console.SetCursorPosition(x, y + 26); Console.Write("'                                            '    ,'\n");
                Console.SetCursorPosition(x, y + 27); Console.Write(" \\                                          /   ,'\n");
                Console.SetCursorPosition(x, y + 28); Console.Write("  \\                                        /  ,'\n");
                Console.SetCursorPosition(x, y + 29); Console.Write("   \\                                      / ,'\n");
                Console.SetCursorPosition(x, y + 30); Console.Write("    `.                                   ,+'\n");
                Console.SetCursorPosition(x, y + 31); Console.Write("      >.                               ,'\n");
                Console.SetCursorPosition(x, y + 32); Console.Write("  _.-'  `-.._                      _,-'-._\n");
                Console.SetCursorPosition(x, y + 33); Console.Write(",__          `\",-............,.---\"       `.\n");
                Console.SetCursorPosition(x, y + 34); Console.Write("   \\..---. _,-'            ,'               `.\n");
                Console.SetCursorPosition(x, y + 35); Console.Write("          \"                '..,--.___,-\"\"\"---' \n");
            }

            else if (pokenumber == 55)
            {
                Console.SetCursorPosition(x, y); Console.Write("                ,|\n");
                Console.SetCursorPosition(x, y + 1); Console.Write("              ,' |         .',\n");
                Console.SetCursorPosition(x, y + 2); Console.Write("             /   |    /\\_,' j\n");
                Console.SetCursorPosition(x, y + 3); Console.Write("            /    |  ,' |    |\n");
                Console.SetCursorPosition(x, y + 4); Console.Write("          ,'     |,'   |   .\n");
                Console.SetCursorPosition(x, y + 5); Console.Write("         /       '    j   j    _,.-/\n");
                Console.SetCursorPosition(x, y + 6); Console.Write("        /      ,'     |   |..-\"  ,'\n");
                Console.SetCursorPosition(x, y + 7); Console.Write("       /              |         /                      `\n");
                Console.SetCursorPosition(x, y + 8); Console.Write("      /               |       ,'\n");
                Console.SetCursorPosition(x, y + 9); Console.Write("    ('  (                 ,\"\"`-.                        /|\n");
                Console.SetCursorPosition(x, y + 10); Console.Write("     | | .              ,'      \\                      / |\n");
                Console.SetCursorPosition(x, y + 11); Console.Write("     | |p'             /        |                     /  |\n");
                Console.SetCursorPosition(x, y + 12); Console.Write("     |.`              '       ,'|-.                 ,'   '\n");
                Console.SetCursorPosition(x, y + 13); Console.Write("     /`\"`\"\"\"'\"`-.    /       .  |. `.___           /    /\n");
                Console.SetCursorPosition(x, y + 14); Console.Write("    /      ,-\"'_|._,'        |  | `.    `\"--..    /    j\n");
                Console.SetCursorPosition(x, y + 15); Console.Write("  ,'     ,',-\"',-'           |,'    `-.       | ,'     |\n");
                Console.SetCursorPosition(x, y + 16); Console.Write(" /     .'.'   /  ,-'|       \\'         `.    ,'/      j\n");
                Console.SetCursorPosition(x, y + 17); Console.Write("|    .','    /  /   |   ,-.  \\           `+-','       '\n");
                Console.SetCursorPosition(x, y + 18); Console.Write("|  .''      .._/   /   /   \\  \\           `.'        /\n");
                Console.SetCursorPosition(x, y + 19); Console.Write(" \\/         | /`\"-.'  /_,..\"\\,\\                     /\n");
                Console.SetCursorPosition(x, y + 20); Console.Write("            '/    |\"|(       \\ .                  ,'\n");
                Console.SetCursorPosition(x, y + 21); Console.Write("                   .| \\       `'                 /\n");
                Console.SetCursorPosition(x, y + 22); Console.Write("                    ' _\\       ,.----\"\"-\\      ,'\n");
                Console.SetCursorPosition(x, y + 23); Console.Write("                 ,-'\"\"  \\    ,'          `   ,'\n");
                Console.SetCursorPosition(x, y + 24); Console.Write("                |        `-.'              ,'\n");
                Console.SetCursorPosition(x, y + 25); Console.Write("                .           \\           _.'\n");
                Console.SetCursorPosition(x, y + 26); Console.Write("                 \\        ___\\         `.\n");
                Console.SetCursorPosition(x, y + 27); Console.Write("                  `.    \"\" `. \\          \\\n");
                Console.SetCursorPosition(x, y + 28); Console.Write("            ,-/\"\"\"\"'._       \\_`.         `.\n");
                Console.SetCursorPosition(x, y + 29); Console.Write("`         _.`-'\"\"            /_`.\\          \\\n");
                Console.SetCursorPosition(x, y + 30); Console.Write("         /.-n+==`       _,,-'\"    \\          \\\n");
                Console.SetCursorPosition(x, y + 31); Console.Write("           ,\\ __.-\"\"\"\"'\"           )          `..__\n");
                Console.SetCursorPosition(x, y + 32); Console.Write("          (,.'                   _/         .._   _\\_\n");
                Console.SetCursorPosition(x, y + 33); Console.Write("          '                    ,\"  _,.-._   -. `_/__ \\\n");
                Console.SetCursorPosition(x, y + 34); Console.Write("                              / ),+....._\\ ,--.\"    `'\n");
                Console.SetCursorPosition(x, y + 35); Console.Write("                             `\"'          `.._ \\\n");
                Console.SetCursorPosition(x, y + 36); Console.Write("                                              `' \n");
            }

            else if (pokenumber == 56)
            {
                Console.SetCursorPosition(x, y); Console.Write("                                ,.-\"\".\n");
                Console.SetCursorPosition(x, y + 1); Console.Write("                               ,| .   `.\n");
                Console.SetCursorPosition(x, y + 2); Console.Write("   ,-\"\"\"\"'\"`.                 '/ |   /  \\\n");
                Console.SetCursorPosition(x, y + 3); Console.Write("  ,'     _.  \\           ,.  (/ ,'  `    .               ,-\"\"--.\n");
                Console.SetCursorPosition(x, y + 4); Console.Write(".'j ,  ,\"\"`.  \\         /  \\  -.\\   |\\   L             ,'  ,..  `.\n");
                Console.SetCursorPosition(x, y + 5); Console.Write("|( |   |    \\  \\|`-.  ,//\"  \\   `\"--' \\   \\           j   /---.   .\n");
                Console.SetCursorPosition(x, y + 6); Console.Write("`-\\|_..'     \\  ||. `/`/  \\  \\---,    `.   \\          |  '.    |  |\n");
                Console.SetCursorPosition(x, y + 7); Console.Write("              \\ || \\    `-.|  ` '`\"-,  |    .         '   |    |__|\n");
                Console.SetCursorPosition(x, y + 8); Console.Write("               `||/        `       `.. |    |          `--'    |  |\n");
                Console.SetCursorPosition(x, y + 9); Console.Write("               ,'                 __.-\"     |                  |  |\n");
                Console.SetCursorPosition(x, y + 10); Console.Write("              /                ,'\"       ,-\"'                  '  |\n");
                Console.SetCursorPosition(x, y + 11); Console.Write("             /   ,'           '        ,'L                    /   '\n");
                Console.SetCursorPosition(x, y + 12); Console.Write("            /. .'.                   .'   |                  /   /\n");
                Console.SetCursorPosition(x, y + 13); Console.Write("           |/ /|||               __,'     L                 /   /\n");
                Console.SetCursorPosition(x, y + 14); Console.Write("          .-.'|L|'__            --         \\               '   /\n");
                Console.SetCursorPosition(x, y + 15); Console.Write("         | . \\                             `.           _,'   /\n");
                Console.SetCursorPosition(x, y + 16); Console.Write("         ` ' ,                              .`       _,'    ,'\n");
                Console.SetCursorPosition(x, y + 17); Console.Write("          `-+                              /--------'    _,'\n");
                Console.SetCursorPosition(x, y + 18); Console.Write("            \\             .               {         _,.-\"\n");
                Console.SetCursorPosition(x, y + 19); Console.Write("           ,\"\\            \\       .     ,-\"-----\"\"\"'\n");
                Console.SetCursorPosition(x, y + 20); Console.Write("       _,.'   `.           )      |  __,.\n");
                Console.SetCursorPosition(x, y + 21); Console.Write("      /        __.        /       |-'\n");
                Console.SetCursorPosition(x, y + 22); Console.Write("      .   ..--+.  `/`v  ./     ,-\"\"\"-.\n");
                Console.SetCursorPosition(x, y + 23); Console.Write("       `-\"`.    \\     `/ \\           '\n");
                Console.SetCursorPosition(x, y + 24); Console.Write("            `-.  \\        `\"\"\"\"--.._  `.\n");
                Console.SetCursorPosition(x, y + 25); Console.Write("               )  \\___              `._ `.\n");
                Console.SetCursorPosition(x, y + 26); Console.Write("             _/       `-.               _ `._\n");
                Console.SetCursorPosition(x, y + 27); Console.Write("     .'\"\"\"--' ,  ,-\"\"`..'           ,\"\"``    `.\n");
                Console.SetCursorPosition(x, y + 28); Console.Write("     \\ _.,--.' ,'                   ( ,-.    __'\"\"\"`.\n");
                Console.SetCursorPosition(x, y + 29); Console.Write("      \" '.___./                      '  |  '\"  `-.   '.\n");
                Console.SetCursorPosition(x, y + 30); Console.Write("                                        |   -.    `-._/\n");
                Console.SetCursorPosition(x, y + 31); Console.Write("                                        |   /\n");
                Console.SetCursorPosition(x, y + 32); Console.Write("                                        '--.' \n");
                Console.SetCursorPosition(x, y + 33); Console.Write("\n");
            }

            else if (pokenumber == 57)
            {
                Console.SetCursorPosition(x, y); Console.Write("                                       _.-\"\"'-.\n");
                Console.SetCursorPosition(x, y + 1); Console.Write("     _______                        ,-'        `.\n");
                Console.SetCursorPosition(x, y + 2); Console.Write("   ,\" .  ,  `.                  ,. .             \\\n");
                Console.SetCursorPosition(x, y + 3); Console.Write("  / ,.-\"\"     \\      ,v\\       / '\\|              `'.\n");
                Console.SetCursorPosition(x, y + 4); Console.Write(" /  |     _    |__  j   \\  /| / .  |               |.\\\n");
                Console.SetCursorPosition(x, y + 5); Console.Write("j   `._,.+.. ,-'  \\ |.\\ ,`,`'/ /|   \\         ,\"\"- '/ |\n");
                Console.SetCursorPosition(x, y + 6); Console.Write("'        |  / _.,_/ || \\,'  / / `    \\_    _.){-...+'  |\n");
                Console.SetCursorPosition(x, y + 7); Console.Write(" `-._    `-| /.\"  \\ |''      `. _\\   '.`---..|`-\"'  _/\n");
                Console.SetCursorPosition(x, y + 8); Console.Write("     `---' `.L\\    /'   | \\_.  ' `           '--.--'  \\\n");
                Console.SetCursorPosition(x, y + 9); Console.Write("               \\ ,-    .'  ,                    |      \\\n");
                Console.SetCursorPosition(x, y + 10); Console.Write("                V ,-   -. l            __       |       .\n");
                Console.SetCursorPosition(x, y + 11); Console.Write("              ,','    , '              ..+.....'        |\n");
                Console.SetCursorPosition(x, y + 12); Console.Write("             /.'    .|                 `,              /\n");
                Console.SetCursorPosition(x, y + 13); Console.Write("            | '   .' |                 .'           _.'\n");
                Console.SetCursorPosition(x, y + 14); Console.Write("            | . ,'!  |                 `--....,...-'--.. _\n");
                Console.SetCursorPosition(x, y + 15); Console.Write("           _|_`-..--\"                   -'             <__\n");
                Console.SetCursorPosition(x, y + 16); Console.Write("          /,  `.                                       ,.'\n");
                Console.SetCursorPosition(x, y + 17); Console.Write("          \\'   |                                    _,'\n");
                Console.SetCursorPosition(x, y + 18); Console.Write("           ._ ,'                                   <\n");
                Console.SetCursorPosition(x, y + 19); Console.Write("             \\                                    ,-`\n");
                Console.SetCursorPosition(x, y + 20); Console.Write("              \\                                  <\"`\n");
                Console.SetCursorPosition(x, y + 21); Console.Write("              .\\                                  \\\n");
                Console.SetCursorPosition(x, y + 22); Console.Write("           _,'  \\                     _     ___ ,--\"\n");
                Console.SetCursorPosition(x, y + 23); Console.Write("         .'      \\              ,.'--`|){._.._`. `\n");
                Console.SetCursorPosition(x, y + 24); Console.Write("         |       _\\'.,_        '| `\"- | `--. `\"`\n");
                Console.SetCursorPosition(x, y + 25); Console.Write("          \\         ) `...|`-`,-|      `.._\n");
                Console.SetCursorPosition(x, y + 26); Console.Write("           `\"-.     \\-.   `.    '          `,\n");
                Console.SetCursorPosition(x, y + 27); Console.Write("               j__._,-'|         `---.       \\ _\n");
                Console.SetCursorPosition(x, y + 28); Console.Write("              |-.-'   _'              ` _      )|.\n");
                Console.SetCursorPosition(x, y + 29); Console.Write("              `.__..-' `-.               +.__.,'  |\n");
                Console.SetCursorPosition(x, y + 30); Console.Write("               ,'         /              \\..-'   ,`.\n");
                Console.SetCursorPosition(x, y + 31); Console.Write("       ,-\"----'      ,.--'                \\___,-'   `.\n");
                Console.SetCursorPosition(x, y + 32); Console.Write("       /  .-\"'    ,-'                        `.       `.._\n");
                Console.SetCursorPosition(x, y + 33); Console.Write("       `-..L____,'                            j __        |\n");
                Console.SetCursorPosition(x, y + 34); Console.Write("                                             |    `.      |\n");
                Console.SetCursorPosition(x, y + 35); Console.Write("                                              `___,'--....' \n");
            }

            else if (pokenumber == 58)
            {
                Console.SetCursorPosition(x, y); Console.Write("\n");
                Console.SetCursorPosition(x, y + 1); Console.Write("\n");
                Console.SetCursorPosition(x, y + 2); Console.Write("\n");
                Console.SetCursorPosition(x, y + 3); Console.Write("                   _,\n");
                Console.SetCursorPosition(x, y + 4); Console.Write("                 .',_..,\n");
                Console.SetCursorPosition(x, y + 5); Console.Write("               ,'     /,--\n");
                Console.SetCursorPosition(x, y + 6); Console.Write("             .'       ,./.__\n");
                Console.SetCursorPosition(x, y + 7); Console.Write("             |_,.----/,,'`.  _\n");
                Console.SetCursorPosition(x, y + 8); Console.Write("            .'__     //    `...>\n");
                Console.SetCursorPosition(x, y + 9); Console.Write("       ____//|) |    `      /.'\n");
                Console.SetCursorPosition(x, y + 10); Console.Write("      (/    `-.-'.._     _,|                 ,.-------.._\n");
                Console.SetCursorPosition(x, y + 11); Console.Write("      .             `.  '   \\               /            `-._\n");
                Console.SetCursorPosition(x, y + 12); Console.Write("      `..---._       |       `.            j                 `.\n");
                Console.SetCursorPosition(x, y + 13); Console.Write("        >-,-\"`\"\"'    |        |`\"+-..__    |              -. `-.\n");
                Console.SetCursorPosition(x, y + 14); Console.Write("       ( /|         /____     |  |  |  \\\"\"|+-.._     ___    `.  `.\n");
                Console.SetCursorPosition(x, y + 15); Console.Write("        \" `-..._     \"--,_    |  |  `   | |   | `.-.\"   \"-._  |  -`\n");
                Console.SetCursorPosition(x, y + 16); Console.Write("             ,'        '_>_   j ,'  '. ,` |,  |   `. `.-v.' `-+..._`.\n");
                Console.SetCursorPosition(x, y + 17); Console.Write("            '.         >       '     | |  ' \\ L     ..`.  '        `._\n");
                Console.SetCursorPosition(x, y + 18); Console.Write("             '.       /              '|`     \\|      '^,         ..,{ `.\n");
                Console.SetCursorPosition(x, y + 19); Console.Write("            / /      /                '       v          |__    ___,'\"\"\n");
                Console.SetCursorPosition(x, y + 20); Console.Write("          ,'  >---+-+.        |   __,..--\"`-._          /.-'`\"----'\n");
                Console.SetCursorPosition(x, y + 21); Console.Write("         /`.       `. '.      |-\"'            `\"--....-'._\n");
                Console.SetCursorPosition(x, y + 22); Console.Write("       .'___'        `._`,    j             ___,-','      `-..._\n");
                Console.SetCursorPosition(x, y + 23); Console.Write("  _ _.'    '/.-          '  ,'       __..<\"\"__,.-'              `.\n");
                Console.SetCursorPosition(x, y + 24); Console.Write(" `.)         |'---\"\"`.+-.--'-------\"\"-...__  ,-'/ .\"\\          _  |\n");
                Console.SetCursorPosition(x, y + 25); Console.Write(",\"\\ ,--.  _,-          ` `'                `'\"\"\"'`\"'\"\"\"`--._  . `/\n");
                Console.SetCursorPosition(x, y + 26); Console.Write(" `-`.___.'                                                  `\"-\"'\n");
                Console.SetCursorPosition(x, y + 27); Console.Write("\n");
            }


            else if (pokenumber == 59)
            {
                Console.SetCursorPosition(x, y); Console.Write("            /  ,'(\n");
                Console.SetCursorPosition(x, y + 1); Console.Write("           /`-'   \\__.,\n");
                Console.SetCursorPosition(x, y + 2); Console.Write("         ,'     .-\"\\ `---/                     /\n");
                Console.SetCursorPosition(x, y + 3); Console.Write("      |`'      /,'||    '.               ,`. ,(,_. _,\n");
                Console.SetCursorPosition(x, y + 4); Console.Write("  __  |  ,--+--.  ||     `'/  .     _.-\"'   `    \"\"`.\n");
                Console.SetCursorPosition(x, y + 5); Console.Write(".\" ,'-'.\"d__|  `.'_'    _,-    ,.  /        ._      `\\_\n");
                Console.SetCursorPosition(x, y + 6); Console.Write("|,'     `-..-----\"._     `.     ` |           `.     \\.\n");
                Console.SetCursorPosition(x, y + 7); Console.Write(" `\"V\"--._           `.   `._    ' |             \\     \\,\n");
                Console.SetCursorPosition(x, y + 8); Console.Write("  \\      `----      '. _,-'    ,' |              \\     .\n");
                Console.SetCursorPosition(x, y + 9); Console.Write("   `._             .--`       `.  |               .    |\n");
                Console.SetCursorPosition(x, y + 10); Console.Write("      `-.          `,.       ,--  |               L    '\n");
                Console.SetCursorPosition(x, y + 11); Console.Write("        /   [-,=.---' `.__`,`     `.              |     \\\n");
                Console.SetCursorPosition(x, y + 12); Console.Write("    _.-'    `.._'--.._   - `--+\"\"\"\" '._           |      `._,\n");
                Console.SetCursorPosition(x, y + 13); Console.Write("    \\        _  ---..__`--._'-.`,  ,' ,`._       j         -,'\n");
                Console.SetCursorPosition(x, y + 14); Console.Write("   .'        ,-..     ,'    `. `  . ,'  / `._   /`._    ___,-'_\n");
                Console.SetCursorPosition(x, y + 15); Console.Write("   l        .|_  `,  -' . .-\"      v   /   _.`.'`   7\",',-,.-\" --,\n");
                Console.SetCursorPosition(x, y + 16); Console.Write("    \\      `.  .,  -..',')'\"\",   .    /  .'    |  ,'.',/| ,.     >\n");
                Console.SetCursorPosition(x, y + 17); Console.Write("     V-.    '    -._,-\"    _,  .,'   j ,^    ,'/`--' `    -..,   `...\n");
                Console.SetCursorPosition(x, y + 18); Console.Write("     '  \\/\\|.     ){/       './`'|    |/    ,' /            `___    ,'\n");
                Console.SetCursorPosition(x, y + 19); Console.Write("           | `. ,'`-.        /  |    ' _.-'  |               ,'  .\"\n");
                Console.SetCursorPosition(x, y + 20); Console.Write("           L._`.'   |       Y,.'|    ,-    ,-'          __.,'  .'\n");
                Console.SetCursorPosition(x, y + 21); Console.Write("            \\ \\  /`.|     _,.',''.  .`-,../         ,.-/,...-`'\n");
                Console.SetCursorPosition(x, y + 22); Console.Write("             \\ ,|| |/_.-\\\" .+'    \\._  _,'       _.'\"  |\n");
                Console.SetCursorPosition(x, y + 23); Console.Write("              '  ' L| | `,' |      `.\"\"          ,.    |\n");
                Console.SetCursorPosition(x, y + 24); Console.Write("              )    `|\"      |        `>.. _,..--\" j    |\n");
                Console.SetCursorPosition(x, y + 25); Console.Write("           ,-'      |____,..'       ,',-\"'       /   _,'\n");
                Console.SetCursorPosition(x, y + 26); Console.Write("          /\"'    _,.'               |(      _..-' `\"\"\n");
                Console.SetCursorPosition(x, y + 27); Console.Write("          `----\"'                    `'\"\"'\"\" \n");
                Console.SetCursorPosition(x, y + 28); Console.Write("\n");
            }

            else if (pokenumber == 60)
            {
                Console.SetCursorPosition(x, y); Console.Write("  _..__                                    ___\n");
                Console.SetCursorPosition(x, y + 1); Console.Write(" /     `._                          ,--\"\"\"\"   `\"-.\n");
                Console.SetCursorPosition(x, y + 2); Console.Write("|         `.                    _.'\"\"/`.        |/`-.\n");
                Console.SetCursorPosition(x, y + 3); Console.Write("|           `.                ,+ `..' | |       |'...+.\n");
                Console.SetCursorPosition(x, y + 4); Console.Write("|     \\       \\              / /\\____,' '    __ `.`._,\".\n");
                Console.SetCursorPosition(x, y + 5); Console.Write("|      ..      \\           ,'  \\      .' ,-\"'  `. `.._,'`.\n");
                Console.SetCursorPosition(x, y + 6); Console.Write("|       .`.     \\         /     `-..-'  .  _.... |._      \\\n");
                Console.SetCursorPosition(x, y + 7); Console.Write("'        ' `     \\       /          ,-\"\"`.____...'  `.     \\\n");
                Console.SetCursorPosition(x, y + 8); Console.Write(" `        `.`.    \\     '         ,'   _,--------.`.  `.    L\n");
                Console.SetCursorPosition(x, y + 9); Console.Write("  `         ` `.   \\   j         /  .,' ,\"_.....`.`.`   \\   |\n");
                Console.SetCursorPosition(x, y + 10); Console.Write("   `.        `. `.  \\  |        / ,'/ .','..... `.\\ \\|   .  |\n");
                Console.SetCursorPosition(x, y + 11); Console.Write("     `.        `. .  \\ |       j . / ..'.,-\"\". \\ || ||   |  |\n");
                Console.SetCursorPosition(x, y + 12); Console.Write("       `.        `.`. \\'.      | | | |||.   .,.','/ /'   |  |\n");
                Console.SetCursorPosition(x, y + 13); Console.Write("         `-.       `. .){\\      | | | ||'`..___.'.','/   j   |\n");
                Console.SetCursorPosition(x, y + 14); Console.Write("            `-._     `-._\\      \\'.`.`..`..__....','   ,   /\n");
                Console.SetCursorPosition(x, y + 15); Console.Write("                `--......-\\      \\ `.`.`.......-\"'   ,'   /\n");
                Console.SetCursorPosition(x, y + 16); Console.Write("                           `.     `. `-..____,.-\" _.'   ,'\n");
                Console.SetCursorPosition(x, y + 17); Console.Write("                             >.     '--...___,..-'   _.\"\n");
                Console.SetCursorPosition(x, y + 18); Console.Write("                           ,'  `--,__            _,-\"  `-.\n");
                Console.SetCursorPosition(x, y + 19); Console.Write("                       _.-'      '   `'--------\"' `.      `-.\n");
                Console.SetCursorPosition(x, y + 20); Console.Write("                     .'        ,'                   \\        `.\n");
                Console.SetCursorPosition(x, y + 21); Console.Write("                    .        .'                      `.        .\n");
                Console.SetCursorPosition(x, y + 22); Console.Write("                    |      ,'                          `._     |\n");
                Console.SetCursorPosition(x, y + 23); Console.Write("                     `----'                               `\"--\" \n");
                Console.SetCursorPosition(x, y + 24); Console.Write("\n");
            }

            else if (pokenumber == 61)
            {
                Console.SetCursorPosition(x, y); Console.Write("             ___   _,-'\"\"-.\n");
                Console.SetCursorPosition(x, y + 1); Console.Write("           /`.  `./,\\`.    `.\n");
                Console.SetCursorPosition(x, y + 2); Console.Write("          /'. |  / || |      .\n");
                Console.SetCursorPosition(x, y + 3); Console.Write("         . `|,+-'| `| |       `._\n");
                Console.SetCursorPosition(x, y + 4); Console.Write("         `,-'    `. | '          `.\n");
                Console.SetCursorPosition(x, y + 5); Console.Write("        ,' -'      `\"'             `.\n");
                Console.SetCursorPosition(x, y + 6); Console.Write("       /\"`-.                         `.\n");
                Console.SetCursorPosition(x, y + 7); Console.Write("      ){`.   \\                          .\n");
                Console.SetCursorPosition(x, y + 8); Console.Write("     ' `.\\   \\                          `\n");
                Console.SetCursorPosition(x, y + 9); Console.Write("    .`.  .`   `           `.             .\n");
                Console.SetCursorPosition(x, y + 10); Console.Write("   / `.'  .`   .      .     \\             \\\n");
                Console.SetCursorPosition(x, y + 11); Console.Write("  /``  .`  `\\   .      \\     .             .\n");
                Console.SetCursorPosition(x, y + 12); Console.Write(" j  .\\  .){  .'  ){       .    '             |\n");
                Console.SetCursorPosition(x, y + 13); Console.Write(" |`. .. ||  ){|  |        ,..--`._          |\n");
                Console.SetCursorPosition(x, y + 14); Console.Write(" |){| |){ ){|  |){  |      ,'        |         |\n");
                Console.SetCursorPosition(x, y + 15); Console.Write(" ||| ){){ |){  |){  |      |         |         |\n");
                Console.SetCursorPosition(x, y + 16); Console.Write(" ){'j '| ){|  ){|  |      |         |         |\n");
                Console.SetCursorPosition(x, y + 17); Console.Write(" `/ .j  ,){  ){|  |     ,'         `         |\n");
                Console.SetCursorPosition(x, y + 18); Console.Write("  \\/ / . '  ',  |   .'            \\        '\n");
                Console.SetCursorPosition(x, y + 19); Console.Write("  ` , /,'  /.  j   |               .      /\n");
                Console.SetCursorPosition(x, y + 20); Console.Write("   `.'/   /'   '   |  .             .   ,'\n");
                Console.SetCursorPosition(x, y + 21); Console.Write("     .  .'/   /    `._/             '  /\n");
                Console.SetCursorPosition(x, y + 22); Console.Write("      `.,'   /       |          __,' .'\n");
                Console.SetCursorPosition(x, y + 23); Console.Write("        `-._,         `.   _,.-\" _,-'\n");
                Console.SetCursorPosition(x, y + 24); Console.Write("            `+..____    `\"'    .'\n");
                Console.SetCursorPosition(x, y + 25); Console.Write("           _/    |  `\"\"\"''\\    '\n");
                Console.SetCursorPosition(x, y + 26); Console.Write("     _,.-\"'      \\        |     \\\n");
                Console.SetCursorPosition(x, y + 27); Console.Write(" _.-'             .       |      `\n");
                Console.SetCursorPosition(x, y + 28); Console.Write(",                 |       |       `.\n");
                Console.SetCursorPosition(x, y + 29); Console.Write("`_          __,,-'        '         `.\n");
                Console.SetCursorPosition(x, y + 30); Console.Write("  `'\"\"'\"'\"''             .            .\n");
                Console.SetCursorPosition(x, y + 31); Console.Write("                         |            |\n");
                Console.SetCursorPosition(x, y + 32); Console.Write("                         '            /\n");
                Console.SetCursorPosition(x, y + 33); Console.Write("                          `.        ,'\n");
                Console.SetCursorPosition(x, y + 34); Console.Write("                            `-..,.-' \n");
            }

            else if (pokenumber == 62)
            {
                Console.SetCursorPosition(x, y); Console.Write("                               __,.-\"\"\"'\"--..._.,---.\n");
                Console.SetCursorPosition(x, y + 1); Console.Write("                           _,-'               /      `.\n");
                Console.SetCursorPosition(x, y + 2); Console.Write("                        _.'                 ,'   ,-\"\"`.|\n");
                Console.SetCursorPosition(x, y + 3); Console.Write("                      ,'                        / ,+\"`.;\n");
                Console.SetCursorPosition(x, y + 4); Console.Write("                    ,'   ____                  . |_/  /\n");
                Console.SetCursorPosition(x, y + 5); Console.Write("                   /  .\"'    `-.               ` `..-/`.  _\n");
                Console.SetCursorPosition(x, y + 6); Console.Write("                  '  /                     .    `---'   `){ `.\n");
                Console.SetCursorPosition(x, y + 7); Console.Write("                 /  .    ,-\"\"`.           .'             \\`-.`+\"\"`\"`.\n");
                Console.SetCursorPosition(x, y + 8); Console.Write("                /   |  .' ,\"\".|               _,...,._    L |  `     `.\n");
                Console.SetCursorPosition(x, y + 9); Console.Write("               /    |  | ._)  /     \\    _.-\"'        \"`. | j          .\n");
                Console.SetCursorPosition(x, y + 10); Console.Write("              j     `  ' |  ,'        ,-'   ___......_   .|\"           |\n");
                Console.SetCursorPosition(x, y + 11); Console.Write("              |         `-+'        ,'  _,\"__.---\"\"\"`-.`.||            |\n");
                Console.SetCursorPosition(x, y + 12); Console.Write("              '                   ,'  ,'.-'    _______ `.`|\\           |\n");
                Console.SetCursorPosition(x, y + 13); Console.Write("            .\"                   /  ,\",'   _,\"+.------+`.`){|           |\n");
                Console.SetCursorPosition(x, y + 14); Console.Write("          ,'     .             ,' .,-'   .\".-'  _..._  ` \\''    .      ;\n");
                Console.SetCursorPosition(x, y + 15); Console.Write("       _,+      /             ,  ,/    ,'.' .-\",.----.+ `7  `.   `._,.'\n");
                Console.SetCursorPosition(x, y + 16); Console.Write("      /  '    ,'             .  '.   ,\".\" .){,-'__     ){|j     `-.-'\n");
                Console.SetCursorPosition(x, y + 17); Console.Write("     j    \\  /|`            ,  //   .,' ,'.' .\"__`.   ||'\n");
                Console.SetCursorPosition(x, y + 18); Console.Write("   ,-+     `\" | \\             /.   //  /,\" ,'.'  \\ \\  |'\n");
                Console.SetCursorPosition(x, y + 19); Console.Write("  /           '  \\         ){ j '  //  //  .,'     || ,\"\n");
                Console.SetCursorPosition(x, y + 20); Console.Write(" /           /    \\        | ){|  j.' j/   ||_.\") , ;<_\n");
                Console.SetCursorPosition(x, y + 21); Console.Write(".            `-.   `.      ){ ||  || |.    `..-'.'.'   `'-._\n");
                Console.SetCursorPosition(x, y + 22); Console.Write("|              |     `.    | |){  ){| |'        _,'          `.\n");
                Console.SetCursorPosition(x, y + 23); Console.Write("|              |      /`-._`.`){. \\' `.`..__.-'+              `\n");
                Console.SetCursorPosition(x, y + 24); Console.Write("`          .   F     ,     /\"`+-+.^+--`\"\"\"     `._            |\n");
                Console.SetCursorPosition(x, y + 25); Console.Write(" `.       |   /     /     .                       `._         /\n");
                Console.SetCursorPosition(x, y + 26); Console.Write("   `._   _,..'    ,'      '                          `\"-....-'\n");
                Console.SetCursorPosition(x, y + 27); Console.Write("      `\"\"        /       j\n");
                Console.SetCursorPosition(x, y + 28); Console.Write("               ,'        |\n");
                Console.SetCursorPosition(x, y + 29); Console.Write("              /          |\n");
                Console.SetCursorPosition(x, y + 30); Console.Write("             j           '\n");
                Console.SetCursorPosition(x, y + 31); Console.Write("             |          /\n");
                Console.SetCursorPosition(x, y + 32); Console.Write("             |         /\n");
                Console.SetCursorPosition(x, y + 33); Console.Write("             '        /\n");
                Console.SetCursorPosition(x, y + 34); Console.Write("              `.___,.' \n");
            }

            else if (pokenumber == 63)
            {
                Console.SetCursorPosition(x, y); Console.Write("                                                        _\n");
                Console.SetCursorPosition(x, y + 1); Console.Write("                                                   _, -\"'|\n");
                Console.SetCursorPosition(x, y + 2); Console.Write("                                               _.-'   ,'j\n");
                Console.SetCursorPosition(x, y + 3); Console.Write("                       ____           _,.....-'      /  |\n");
                Console.SetCursorPosition(x, y + 4); Console.Write("                      `.   `'--..,--\"'              .   |\n");
                Console.SetCursorPosition(x, y + 5); Console.Write("                       `.                           |   |\n");
                Console.SetCursorPosition(x, y + 6); Console.Write("                        .`.                         \\  j\n");
                Console.SetCursorPosition(x, y + 7); Console.Write("                _.,     '  .                         ` |\n");
                Console.SetCursorPosition(x, y + 8); Console.Write("              .','       . |                            \\\n");
                Console.SetCursorPosition(x, y + 9); Console.Write("            ,\" /         `./                             \\\n");
                Console.SetCursorPosition(x, y + 10); Console.Write("           /  /           /                    ,-'        \\\n");
                Console.SetCursorPosition(x, y + 11); Console.Write("         ,'  j           j  .._              ,'            L._\n");
                Console.SetCursorPosition(x, y + 12); Console.Write("        /    |           |     `.          ,'             ,'  `-.\n");
                Console.SetCursorPosition(x, y + 13); Console.Write("       .     |           |       `.       .            _,'       `.\n");
                Console.SetCursorPosition(x, y + 14); Console.Write("       |     |           `.        `               _,-'            \\\n");
                Console.SetCursorPosition(x, y + 15); Console.Write("       |     `           / `-.                  ,\"/                `.\n");
                Console.SetCursorPosition(x, y + 16); Console.Write("       |    _.\\         j     `-.._       ,   .' |                  ;\n");
                Console.SetCursorPosition(x, y + 17); Console.Write("       '  ,'   \\        |        _,'.    '  ,'    `.              .'\n");
                Console.SetCursorPosition(x, y + 18); Console.Write("        +'   ,.-^.      `-..,..-'/ _,^-----+.       `._       _,-'\n");
                Console.SetCursorPosition(x, y + 19); Console.Write("        .+--`._   `-._     L_   j-\"          `-.  _,-\\ `..,--'\n");
                Console.SetCursorPosition(x, y + 20); Console.Write("          \\    `      `\"-+'  `-.'               \"\" ,.'/ ` |      ,\n");
                Console.SetCursorPosition(x, y + 21); Console.Write("_____      L    `       /       `.._.----.._   _.-'  /   F     ,'|\n");
                Console.SetCursorPosition(x, y + 22); Console.Write("`.   `.    |     \\     '.           `\"\"\"-+.-`\"'     '    |`. ,'  |\n");
                Console.SetCursorPosition(x, y + 23); Console.Write("  `.   `.  |      L   _,+\\__              `          \\   |/ /    |\n");
                Console.SetCursorPosition(x, y + 24); Console.Write("    \\    +,'      |  '     `.`._           `.         |  |.,     |\n");
                Console.SetCursorPosition(x, y + 25); Console.Write("    `.  '         |,\"        \\  `.          |.      _,|         /\n");
                Console.SetCursorPosition(x, y + 26); Console.Write("      `           |           |   +.       / | _,-+'  |        /\n");
                Console.SetCursorPosition(x, y + 27); Console.Write("       \\          |          '    |\\.     /-',\"  /    |       j\n");
                Console.SetCursorPosition(x, y + 28); Console.Write("        \\         |         /_    | \\`..,-\".\"   |     j       |\n");
                Console.SetCursorPosition(x, y + 29); Console.Write("         \\         \\ _   _,'  `-.  `-,|/___.\\,-.|    /        '\n");
                Console.SetCursorPosition(x, y + 30); Console.Write("         `         `' \"\"\"        `\"\"'            \\  |        .\n");
                Console.SetCursorPosition(x, y + 31); Console.Write("          `. ,\"\"'   |                             `-+`./     |\n");
                Console.SetCursorPosition(x, y + 32); Console.Write("            `.     '                                  |      F\n");
                Console.SetCursorPosition(x, y + 33); Console.Write("              )   |                                    \\    /\n");
                Console.SetCursorPosition(x, y + 34); Console.Write("             /__,.'                                     \\,.' \n");
            }

            else if (pokenumber == 64)
            {
                Console.SetCursorPosition(x, y); Console.Write("                       .-\n");
                Console.SetCursorPosition(x, y + 1); Console.Write("                       | \\               _,\n");
                Console.SetCursorPosition(x, y + 2); Console.Write("                      j   \\           ,-' |\n");
                Console.SetCursorPosition(x, y + 3); Console.Write("                      |    \\       ,''   .'\n");
                Console.SetCursorPosition(x, y + 4); Console.Write("                      |     \\    ,'   .  |\n");
                Console.SetCursorPosition(x, y + 5); Console.Write("         .-`.        .|    __\\_,'    ,  ,\n");
                Console.SetCursorPosition(x, y + 6); Console.Write("       ,'   |        ||  \"\"        .'  /\n");
                Console.SetCursorPosition(x, y + 7); Console.Write("      .     +.      ,\"'           .   /   ___\n");
                Console.SetCursorPosition(x, y + 8); Console.Write("    ,-.\\ _,`.'     ,  __._        `. ,  ,'   |\n");
                Console.SetCursorPosition(x, y + 9); Console.Write("    .  `'   /     /  <   ,'    _    \\`.'     `-,._\n");
                Console.SetCursorPosition(x, y + 10); Console.Write(" ,\\_|`.,-`.'     /`. `-^-'  _.|    .-\"||     .'   `-.\n");
                Console.SetCursorPosition(x, y + 11); Console.Write("` `. //`.`      j \\`.     ,'|)|   ,\\  |`.    |  ,.--'\n");
                Console.SetCursorPosition(x, y + 12); Console.Write(" `. `'`//       |  `|   .){,-'     |`.'   `.___`\" '\n");
                Console.SetCursorPosition(x, y + 13); Console.Write("  `.|>,'\\       |`..|  /     ____.' |    `-. >    \\,_..._\n");
                Console.SetCursorPosition(x, y + 14); Console.Write("  // `   \\     ,',-'| /  \"'-\".  ` `.`.    ,-\"\"\\  ,'      `\".\n");
                Console.SetCursorPosition(x, y + 15); Console.Write(" (/   ){  `-._,/ /,'`./  '\"-._ `. `. ``--..\\_,-' ,'          \\\n");
                Console.SetCursorPosition(x, y + 16); Console.Write("      '.    .',' /'|     /|  `. `. ._.__ _,'.\"|'             \\\n");
                Console.SetCursorPosition(x, y + 17); Console.Write("        .   `,' /  |  ` /-'    \\  `. ` -..-'  |\"`.            '\n");
                Console.SetCursorPosition(x, y + 18); Console.Write("         `--'/ /    `+-'        \\  ``.       .    `.          `\n");
                Console.SetCursorPosition(x, y + 19); Console.Write("            ' .       `-.  ,-\"--.+  \\ .    .' `.    `    .   | \\\n");
                Console.SetCursorPosition(x, y + 20); Console.Write("           '| |          `.\\,\" ,. ` ' '_.-'     \\    \\   |   ' |\n");
                Console.SetCursorPosition(x, y + 21); Console.Write("           |' |    __,.-\"' .| '|`. . \\`.   \\     \\    .  | ,'  |\n");
                Console.SetCursorPosition(x, y + 22); Console.Write("           || |  ,'\\        .`. V  | |     |      .   |  '   /.'\n");
                Console.SetCursorPosition(x, y + 23); Console.Write("           `| | /   `._     `. _|  | ||    |      |   | /..-' /   .\n");
                Console.SetCursorPosition(x, y + 24); Console.Write("            ' . '      /`---'.`.`._| '|,--.|      |   |'     /    '|\n");
                Console.SetCursorPosition(x, y + 25); Console.Write("             . . \\    ,'      ` \\/ '/ `    `._    '  ,'     |   ,' |\n");
                Console.SetCursorPosition(x, y + 26); Console.Write("              `.\\ `.  \\        `. .'   |      `.,' ,'|      '+-'   '\n");
                Console.SetCursorPosition(x, y + 27); Console.Write("            _.--`.-j   `-.-..    `-.   `-.     | ,/  `.       `  .'\n");
                Console.SetCursorPosition(x, y + 28); Console.Write("          .'_.'+\"\"' _   _,.'-`      `-..._,\\   |-'     `-...__..'\n");
                Console.SetCursorPosition(x, y + 29); Console.Write("          ' /_..|/-' `\"'                ,_.`'   `..__\n");
                Console.SetCursorPosition(x, y + 30); Console.Write("                                          `.  `-._  ,-'\n");
                Console.SetCursorPosition(x, y + 31); Console.Write("                                           `,..`. `/  |\n");
                Console.SetCursorPosition(x, y + 32); Console.Write("                                            ){  /    `.'\n");
                Console.SetCursorPosition(x, y + 33); Console.Write("                                             `.' \n");
            }

            else if (pokenumber == 65)
            {
                Console.SetCursorPosition(x, y); Console.Write("                                               _,'|\n");
                Console.SetCursorPosition(x, y + 1); Console.Write("                                             .'  /\n");
                Console.SetCursorPosition(x, y + 2); Console.Write("                    __                     ,'   '\n");
                Console.SetCursorPosition(x, y + 3); Console.Write("                   `  `.                 .'    '\n");
                Console.SetCursorPosition(x, y + 4); Console.Write("                    \\   `.             ,'     '\n");
                Console.SetCursorPosition(x, y + 5); Console.Write("                     \\    `.          ,      /\n");
                Console.SetCursorPosition(x, y + 6); Console.Write("                      .     `.       /      ,\n");
                Console.SetCursorPosition(x, y + 7); Console.Write("                      '       ..__../'     /\n");
                Console.SetCursorPosition(x, y + 8); Console.Write("                       \\     ,\"'   '      . _.._\n");
                Console.SetCursorPosition(x, y + 9); Console.Write("                        \\  ,'             |'    `\"._\n");
                Console.SetCursorPosition(x, y + 10); Console.Write("                         |/               ,---.._   `.\n");
                Console.SetCursorPosition(x, y + 11); Console.Write("                       ,-|           .   '       `-.  \\\n");
                Console.SetCursorPosition(x, y + 12); Console.Write("                     ,'  |     ,   ,'   ){           '__\\_\n");
                Console.SetCursorPosition(x, y + 13); Console.Write("                     |  /,_   /  ,U|    '            |   .__\n");
                Console.SetCursorPosition(x, y + 14); Console.Write("                     `,' `.\\ `./..-'  __ \\           |   `. `.\n");
                Console.SetCursorPosition(x, y + 15); Console.Write("                       `\",_|  /     ,\"  `.`._       .|     \\ |\n");
                Console.SetCursorPosition(x, y + 16); Console.Write("                      / /_.| j  ---'.     `._`-----`.`     | |\n");
                Console.SetCursorPosition(x, y + 17); Console.Write("                     / // ,|`'  `-/' `.      `\"/-+--'    ,'  `.\n");
                Console.SetCursorPosition(x, y + 18); Console.Write("                 _,.`,'| / |.'  -,' \\  \\       \\ '._    /     |\n");
                Console.SetCursorPosition(x, y + 19); Console.Write(" .--.      _,.-\"'   `| L \\ \\__ ,^.__.\\  `.  _,--`._,>+-'  __,-'\n");
                Console.SetCursorPosition(x, y + 20); Console.Write("){    \\   ,'          |  | \\          /.   `'      '.  `--'| \\\n");
                Console.SetCursorPosition(x, y + 21); Console.Write("'    | ,-.. `'   _,--' ,'  \\        `.\\            7      |,.\\\n");
                Console.SetCursorPosition(x, y + 22); Console.Write(" `._ '.  .`.    .>  `-.-    |-.\"\"---..-\\        _>`       `.-'\n");
                Console.SetCursorPosition(x, y + 23); Console.Write("    `.,' | l  ,' ,>         | `.___,....\\._    ,--``-.\n");
                Console.SetCursorPosition(x, y + 24); Console.Write("   j | .'|_|.'  /_         /   _|         \\`\"--+--.   ` ,..._\n");
                Console.SetCursorPosition(x, y + 25); Console.Write("   |_`-'/  |     ,' ,.._,.'\"\"\"'\\           `--'    `-..'     `\".\n");
                Console.SetCursorPosition(x, y + 26); Console.Write("     \"-'_,+'\\    '^-     |      \\                    /         |\n");
                Console.SetCursorPosition(x, y + 27); Console.Write("          |_/         __ \\       .                   `.`.._  ,'`.\n");
                Console.SetCursorPosition(x, y + 28); Console.Write("                  _.){'__`'        `,.                  |   `'   |\n");
                Console.SetCursorPosition(x, y + 29); Console.Write("                 `--`-..`\"        /--`               ,-`        |\n");
                Console.SetCursorPosition(x, y + 30); Console.Write("                   `---'---------'                   \"\"| `#     '.\n");
                Console.SetCursorPosition(x, y + 31); Console.Write("                                                       `._,       `){._\n");
                Console.SetCursorPosition(x, y + 32); Console.Write("                                                         `|   ,..  |  '.\n");
                Console.SetCursorPosition(x, y + 33); Console.Write("                                                         j   '.  `-+---'\n");
                Console.SetCursorPosition(x, y + 34); Console.Write("                                                         |,.. |\n");
                Console.SetCursorPosition(x, y + 35); Console.Write("                                                          `. `;\n");
                Console.SetCursorPosition(x, y + 36); Console.Write("                                                            `' \n");
            }

            else if (pokenumber == 66)
            {
                Console.SetCursorPosition(x, y); Console.Write("                        ,.\"--.\n");
                Console.SetCursorPosition(x, y + 1); Console.Write("                   _.../     _\\\"\"-.\n");
                Console.SetCursorPosition(x, y + 2); Console.Write("                 //  ,'    ,\"      ){\n");
                Console.SetCursorPosition(x, y + 3); Console.Write("                .'  /   .){'      __|\n");
                Console.SetCursorPosition(x, y + 4); Console.Write("                || ||  /,    _.\"   '.\n");
                Console.SetCursorPosition(x, y + 5); Console.Write("                || ||  ||  ,'        `.\n");
                Console.SetCursorPosition(x, y + 6); Console.Write("               /|| ||  ||,'            .\n");
                Console.SetCursorPosition(x, y + 7); Console.Write("              /.`| /` /`,'  __          '\n");
                Console.SetCursorPosition(x, y + 8); Console.Write("             j /. \" `\"  ' ,' /`.        |\n");
                Console.SetCursorPosition(x, y + 9); Console.Write("             ||.|        .  | . .      _|,--._\n");
                Console.SetCursorPosition(x, y + 10); Console.Write("             ||#|        |  | #'|   ,-\"       `-.\n");
                Console.SetCursorPosition(x, y + 11); Console.Write("            /'.||        |  \\.\" |  /             `\n");
                Console.SetCursorPosition(x, y + 12); Console.Write("           /    '        `.----\"   |`.|           |\n");
                Console.SetCursorPosition(x, y + 13); Console.Write("           \\  `.    ,'             `  \\           |\n");
                Console.SetCursorPosition(x, y + 14); Console.Write("            `._____           _,-'  `._,..        |\n");
                Console.SetCursorPosition(x, y + 15); Console.Write("              `\".  `'-..__..-'   _,.--'.  .       |\n");
                Console.SetCursorPosition(x, y + 16); Console.Write("               ,-^-._      _,..-'       `.|       '\n");
                Console.SetCursorPosition(x, y + 17); Console.Write("           _,-'     |'\"\"'\"\"              `|  `\\    \\\n");
                Console.SetCursorPosition(x, y + 18); Console.Write("       _.-'         |            `.,--    |    \\    \\\n");
                Console.SetCursorPosition(x, y + 19); Console.Write("  _,.\"\"'\"\"'-._      '      `.     .      j      '    \\\n");
                Console.SetCursorPosition(x, y + 20); Console.Write(" /            `.___/.-\"    ._`-._  \\.    |      |     L\n");
                Console.SetCursorPosition(x, y + 21); Console.Write("/  ____           /,.-'    . `._ '\"\"|`.  `      |     |\n");
                Console.SetCursorPosition(x, y + 22); Console.Write(" `.    `\"-.      / _,-\"     `._ `\"'\".  `. \\     '     '\n");
                Console.SetCursorPosition(x, y + 23); Console.Write("   \\       `-   .\"'            \"`---'\\   ` `-._/     /\n");
                Console.SetCursorPosition(x, y + 24); Console.Write("    `-------.   |                     \\   `-._      /\n");
                Console.SetCursorPosition(x, y + 25); Console.Write("             \\ j                      .       `...,'\n");
                Console.SetCursorPosition(x, y + 26); Console.Write("              `|                       \\\n");
                Console.SetCursorPosition(x, y + 27); Console.Write("               '                        \\\n");
                Console.SetCursorPosition(x, y + 28); Console.Write("                .                      / \\\n");
                Console.SetCursorPosition(x, y + 29); Console.Write("                |`.                   /   `._\n");
                Console.SetCursorPosition(x, y + 30); Console.Write("                |    `.._____        /|      `-._\n");
                Console.SetCursorPosition(x, y + 31); Console.Write("                |        |   Y.       |.         `.\n");
                Console.SetCursorPosition(x, y + 32); Console.Write("                |       j     \\       '.`\"--....-'\n");
                Console.SetCursorPosition(x, y + 33); Console.Write("             _,-'       |      |        \\\n");
                Console.SetCursorPosition(x, y + 34); Console.Write("          .-'           |     ,'         `.\n");
                Console.SetCursorPosition(x, y + 35); Console.Write("         '              |     |            `.\n");
                Console.SetCursorPosition(x, y + 36); Console.Write("         `.        __,..'     '.             \\\n");
                Console.SetCursorPosition(x, y + 37); Console.Write("           `-.---\"'             `-..__      _/\n");
                Console.SetCursorPosition(x, y + 38); Console.Write("                                      `'\"\"\"' \n");
            }

            else if (pokenumber == 67)
            {
                Console.SetCursorPosition(x, y); Console.Write("           ,-\"\"\",.--\n");
                Console.SetCursorPosition(x, y + 1); Console.Write("         ,){-'_.--\"\"\"\\\n");
                Console.SetCursorPosition(x, y + 2); Console.Write("       ,\"/,-'  _,..--+-.\n");
                Console.SetCursorPosition(x, y + 3); Console.Write("      .,'/ _.-'         \\\n");
                Console.SetCursorPosition(x, y + 4); Console.Write("      |||,'_.-.          \\ ____\n");
                Console.SetCursorPosition(x, y + 5); Console.Write("      |.','U| |         .-'    `-.\n");
                Console.SetCursorPosition(x, y + 6); Console.Write("    ,\"   |_L){/        ,'          `.\n");
                Console.SetCursorPosition(x, y + 7); Console.Write("   j                 /              .\n");
                Console.SetCursorPosition(x, y + 8); Console.Write("   \\_______...-7    j           ___ |\n");
                Console.SetCursorPosition(x, y + 9); Console.Write("    V V/     _.'    |    _,.---- ,_`\"-.\n");
                Console.SetCursorPosition(x, y + 10); Console.Write("     ,/_...-\"   __.-|  -\"    `,.   ``.'`.\n");
                Console.SetCursorPosition(x, y + 11); Console.Write("     `..,......\"    `.  | \\    `+`. `  \\ .\n");
                Console.SetCursorPosition(x, y + 12); Console.Write("       j /            `./ \\\\    ` .  \\\\ . .\n");
                Console.SetCursorPosition(x, y + 13); Console.Write("       | |               ` `\\     \\'  \\' \\|\n");
                Console.SetCursorPosition(x, y + 14); Console.Write("       | |              | `.`+. /         \\\n");
                Console.SetCursorPosition(x, y + 15); Console.Write("       ` '              |   `\".',  `\\  `|  )\n");
                Console.SetCursorPosition(x, y + 16); Console.Write("        \\ \\           .'     . ||   || ||.'\n");
                Console.SetCursorPosition(x, y + 17); Console.Write("         `>`.,.....-----\"'\"\"\"\"\\`|   |' |||\n");
                Console.SetCursorPosition(x, y + 18); Console.Write("         / .||D.\\\\|.'\\ () (_) (\\|  j|  j/|\n");
                Console.SetCursorPosition(x, y + 19); Console.Write("        / +,|| ||||_____........|  || / .'\n");
                Console.SetCursorPosition(x, y + 20); Console.Write("     _,'.\"'_|\\.'/|   _,---._    |  .' ,'\n");
                Console.SetCursorPosition(x, y + 21); Console.Write("  .\"' .   '\"j-...' ,' ,     `. .'  '  |\n");
                Console.SetCursorPosition(x, y + 22); Console.Write(" /  ,/  ,'.'`     /  /       ,'       `.\n");
                Console.SetCursorPosition(x, y + 23); Console.Write(" | /| ,`./   \\   / .'        |         |.\n");
                Console.SetCursorPosition(x, y + 24); Console.Write(" | ||_|./ .   `.j /          `.        | )\n");
                Console.SetCursorPosition(x, y + 25); Console.Write(" `-'`.+' /      | `          ,'`.__     Y\n");
                Console.SetCursorPosition(x, y + 26); Console.Write("     .' /       | `.       .'   /  `\"\"'\"\n");
                Console.SetCursorPosition(x, y + 27); Console.Write("     |  '      /|    .___.'   ,'\n");
                Console.SetCursorPosition(x, y + 28); Console.Write("      `.   / -' `.        ,   `.\n");
                Console.SetCursorPosition(x, y + 29); Console.Write("       |  /       `+.     |     `.\n");
                Console.SetCursorPosition(x, y + 30); Console.Write("       |  \\        | `    `       \\\n");
                Console.SetCursorPosition(x, y + 31); Console.Write("        \\  `.      |`.`.   `.      |\n");
                Console.SetCursorPosition(x, y + 32); Console.Write("         \\   `.    |  `..    `.    '\n");
                Console.SetCursorPosition(x, y + 33); Console.Write("         /     `-. |    `.     `  /\n");
                Console.SetCursorPosition(x, y + 34); Console.Write("  ____.-'          `.  _,'      --\\\n");
                Console.SetCursorPosition(x, y + 35); Console.Write(",' .'_.,_.         __){\"            `.\n");
                Console.SetCursorPosition(x, y + 36); Console.Write("| ( | (         ,-\" ,-'.\" ,'_.      |\n");
                Console.SetCursorPosition(x, y + 37); Console.Write("`-`-^--`--------'__|__(  | /   _,--\"\n");
                Console.SetCursorPosition(x, y + 38); Console.Write("                       \"\"--'..' \n");
            }

            else if (pokenumber == 68)
            {
                Console.SetCursorPosition(x, y); Console.Write("                 __.\"`. .-.                    ,-..__\n");
                Console.SetCursorPosition(x, y + 1); Console.Write("              ,-.  \\  |-| |               ,-\"+' ,\"'  `.\n");
                Console.SetCursorPosition(x, y + 2); Console.Write("              \\  \\  \\_' `.'             .'  .|_.|_.,--'.\n");
                Console.SetCursorPosition(x, y + 3); Console.Write("               \\.'`\"     `.              `-' `.   .  _,'.\n");
                Console.SetCursorPosition(x, y + 4); Console.Write("                \\_     `\"\"\"-.             .\"--+\\   '\"   |\n");
                Console.SetCursorPosition(x, y + 5); Console.Write("                | `\"\"+..`..,'             `-._ |        |\n");
                Console.SetCursorPosition(x, y + 6); Console.Write("               j     |                       '.       _/.\n");
                Console.SetCursorPosition(x, y + 7); Console.Write("              /   ,' `.      _.----._          `\"-.  '   \\\n");
                Console.SetCursorPosition(x, y + 8); Console.Write("             |   |     |   ,'  ,.-\"\"\"`.           |  .    \\\n");
                Console.SetCursorPosition(x, y + 9); Console.Write("    __       |   '    /-._.  ,'        `.         |   \\    \\\n");
                Console.SetCursorPosition(x, y + 10); Console.Write("   (  `.     `.     .'    | /  _,.-----. \\       j     .    \\\n");
                Console.SetCursorPosition(x, y + 11); Console.Write("    `. |.  __  `,         |j ,'\\        `|\"+---._|          ,\n");
                Console.SetCursorPosition(x, y + 12); Console.Write(" .-\"-|\"' \\\"  |   \". '.    ||/d |_-\"\"`.    /     ,'.          )\n");
                Console.SetCursorPosition(x, y + 13); Console.Write(" `._. |  '.,.'     '  `  ,||_.-\"      |  j     '   `        .\n");
                Console.SetCursorPosition(x, y + 14); Console.Write(".\"'--){' .  )        `.  (     _.-+    |  |                  |\n");
                Console.SetCursorPosition(x, y + 15); Console.Write("`-,..'  ` <_          `-.`..+\"   '   ./,  ._         |      |\n");
                Console.SetCursorPosition(x, y + 16); Console.Write(" `.__|   |  `-._     _.-\"`. |   /  ,'j      `. `....' ____..'\n");
                Console.SetCursorPosition(x, y + 17); Console.Write("   `-.,.'    \\  `. ,'     ,-|_,'  /  |        `.___,-'   )\n");
                Console.SetCursorPosition(x, y + 18); Console.Write("      `.      `.  Y       `-..__.',-'    __,.'           '\n");
                Console.SetCursorPosition(x, y + 19); Console.Write("        `         '   ,--.    |  /            `+\"\"       `.\n");
                Console.SetCursorPosition(x, y + 20); Console.Write("         `.       ,--+   '  .-+-\"  _,'   ,--  /     '.    |\n");
                Console.SetCursorPosition(x, y + 21); Console.Write("           `-..   \\     __,'           .'    /        `.  |\n");
                Console.SetCursorPosition(x, y + 22); Console.Write("               `---)   |  ____,'      ,....-'           `,'\n");
                Console.SetCursorPosition(x, y + 23); Console.Write("                  '                 ,' _,-----.         /\n");
                Console.SetCursorPosition(x, y + 24); Console.Write("                   `.____,.....___.\\ _...______________/\n");
                Console.SetCursorPosition(x, y + 25); Console.Write("                                  __\\){+.`'O O  O O  O |\n");
                Console.SetCursorPosition(x, y + 26); Console.Write("                              ,-\"'  _,|){;|\"\"\"\"\"\"\"\"\"\"\"\"|\n");
                Console.SetCursorPosition(x, y + 27); Console.Write("                            ,'   ,-'  `._/    _.\"  .`-|\n");
                Console.SetCursorPosition(x, y + 28); Console.Write("                         .-\"    '      \\    .'      `.`.\n");
                Console.SetCursorPosition(x, y + 29); Console.Write("                        ){      .        \\   |        / |\n");
                Console.SetCursorPosition(x, y + 30); Console.Write("                         .      \\.__   _,`-.|       /  |\n");
                Console.SetCursorPosition(x, y + 31); Console.Write("                         `.      \\  \"\"'     `.         `....\n");
                Console.SetCursorPosition(x, y + 32); Console.Write("                           .     |            \\             `.\n");
                Console.SetCursorPosition(x, y + 33); Console.Write("                          .'   ,'              \\              |\n");
                Console.SetCursorPosition(x, y + 34); Console.Write("                  ,------'     `.               `-...._  '\"-. '.\n");
                Console.SetCursorPosition(x, y + 35); Console.Write("                 / ,'\"'\"`        |                  `--`._      `.\n");
                Console.SetCursorPosition(x, y + 36); Console.Write("                 `\"......---\"\"--'                         \\       .\n");
                Console.SetCursorPosition(x, y + 37); Console.Write("                                                          |        `.\n");
                Console.SetCursorPosition(x, y + 38); Console.Write("                                                         (   -..     .\n");
                Console.SetCursorPosition(x, y + 39); Console.Write("                                                          `\"\"\"' `....' \n");
            }

            else if (pokenumber == 69)
            {
                Console.SetCursorPosition(x, y); Console.Write("                _.--\"'\"\"\"--._\n");
                Console.SetCursorPosition(x, y + 1); Console.Write("              .\"             `.\n");
                Console.SetCursorPosition(x, y + 2); Console.Write("             /                 .\n");
                Console.SetCursorPosition(x, y + 3); Console.Write("            j                   .\n");
                Console.SetCursorPosition(x, y + 4); Console.Write("            |                   |\n");
                Console.SetCursorPosition(x, y + 5); Console.Write("            |                   |\n");
                Console.SetCursorPosition(x, y + 6); Console.Write("            | (')              j\n");
                Console.SetCursorPosition(x, y + 7); Console.Write("            `                 ,`.\n");
                Console.SetCursorPosition(x, y + 8); Console.Write("             \\               ,^. `.\n");
                Console.SetCursorPosition(x, y + 9); Console.Write("              .             /   \\  .\n");
                Console.SetCursorPosition(x, y + 10); Console.Write("              |            /     . |\n");
                Console.SetCursorPosition(x, y + 11); Console.Write("              |          ,'      | |\n");
                Console.SetCursorPosition(x, y + 12); Console.Write("             ,'---..___ /        | |\n");
                Console.SetCursorPosition(x, y + 13); Console.Write("            ' `--..___ \"`.      .  |\n");
                Console.SetCursorPosition(x, y + 14); Console.Write("             `\"--....___.'     /  j__.....__\n");
                Console.SetCursorPosition(x, y + 15); Console.Write("                              /   |         `.\n");
                Console.SetCursorPosition(x, y + 16); Console.Write("                             / _,------._     `.\n");
                Console.SetCursorPosition(x, y + 17); Console.Write("                            /,+_         `.     `.\n");
                Console.SetCursorPosition(x, y + 18); Console.Write("                          ,'    `-.        \\      .\n");
                Console.SetCursorPosition(x, y + 19); Console.Write("                         .         `.       \\      \\\n");
                Console.SetCursorPosition(x, y + 20); Console.Write("                         |           `.     |       \\\n");
                Console.SetCursorPosition(x, y + 21); Console.Write("                         |             `.   |_,..__  .\n");
                Console.SetCursorPosition(x, y + 22); Console.Write("                         |\\              \\  |      `.|\n");
                Console.SetCursorPosition(x, y + 23); Console.Write("                         | `.,--------._  \\ |        `\n");
                Console.SetCursorPosition(x, y + 24); Console.Write("                         |  |           `. \\|\n");
                Console.SetCursorPosition(x, y + 25); Console.Write("                         |  |             `.|\n");
                Console.SetCursorPosition(x, y + 26); Console.Write("                         |  |\n");
                Console.SetCursorPosition(x, y + 27); Console.Write("                         |  |\n");
                Console.SetCursorPosition(x, y + 28); Console.Write("                         |. '\n");
                Console.SetCursorPosition(x, y + 29); Console.Write("                        .' \\ `.\n");
                Console.SetCursorPosition(x, y + 30); Console.Write("                     _,' ,' `. ._\n");
                Console.SetCursorPosition(x, y + 31); Console.Write("   ---====+,______,.\"_.-'     .  `.\n");
                Console.SetCursorPosition(x, y + 32); Console.Write("   _,..==`'_.+'-\"\"\"\"'         / ^.\\`){._\n");
                Console.SetCursorPosition(x, y + 33); Console.Write(" ,=\"/    ,\"            ....==+ /  `\\  `){.\n");
                Console.SetCursorPosition(x, y + 34); Console.Write("'  /    / |               _+){-'    .|   ``.\n");
                Console.SetCursorPosition(x, y + 35); Console.Write("       '  `.           --\"\"        |'     `\\\n");
                Console.SetCursorPosition(x, y + 36); Console.Write("                                   ' \n");
            }

            else if (pokenumber == 70)
            {
                Console.SetCursorPosition(x, y); Console.Write("                                    _...._\n");
                Console.SetCursorPosition(x, y + 1); Console.Write("                                  ,'   __ `.\n");
                Console.SetCursorPosition(x, y + 2); Console.Write("                                .'   ,'  `. |\n");
                Console.SetCursorPosition(x, y + 3); Console.Write("                               .   .'      .|\n");
                Console.SetCursorPosition(x, y + 4); Console.Write("                              /   .        ||\n");
                Console.SetCursorPosition(x, y + 5); Console.Write("                          .-\"'\"\"\"-'        ,'\n");
                Console.SetCursorPosition(x, y + 6); Console.Write("                      _,'\"\"\"'\"--._ `.\n");
                Console.SetCursorPosition(x, y + 7); Console.Write("                    .'            `.){\n");
                Console.SetCursorPosition(x, y + 8); Console.Write("                  ,'                `.\n");
                Console.SetCursorPosition(x, y + 9); Console.Write("                 /     _              \\\n");
                Console.SetCursorPosition(x, y + 10); Console.Write("   ..--._       /     ._;              \\\n");
                Console.SetCursorPosition(x, y + 11); Console.Write(" ,'      `.    j                        .\n");
                Console.SetCursorPosition(x, y + 12); Console.Write(".          `.  |                        |\n");
                Console.SetCursorPosition(x, y + 13); Console.Write("|           ,+-' ,-\"\"-.       _.-\"'\"\"\"`\"`._\n");
                Console.SetCursorPosition(x, y + 14); Console.Write("|          ){ |/ /`.    |    ,'             `.\n");
                Console.SetCursorPosition(x, y + 15); Console.Write("|          |// ){  |    |   ,                 '.\n");
                Console.SetCursorPosition(x, y + 16); Console.Write("'    .     |/  '-\"     |  /                    `.\n");
                Console.SetCursorPosition(x, y + 17); Console.Write(" `    \\   ,'    `-...,'  j                       `\n");
                Console.SetCursorPosition(x, y + 18); Console.Write("  '._/_\\.'               |                        `\n");
                Console.SetCursorPosition(x, y + 19); Console.Write("  .'   `\"-._             |                         \\\n");
                Console.SetCursorPosition(x, y + 20); Console.Write("  |         `.           |                          \\\n");
                Console.SetCursorPosition(x, y + 21); Console.Write("  | --+.      `.          .                 ___      .\n");
                Console.SetCursorPosition(x, y + 22); Console.Write("  '   | `.      `.         .           _.-\"\"   `\"._  |\n");
                Console.SetCursorPosition(x, y + 23); Console.Write("   .  '    .      `.        `-.____,.-' /          `.|\n");
                Console.SetCursorPosition(x, y + 24); Console.Write("    .  `    `.      .                  /             `\n");
                Console.SetCursorPosition(x, y + 25); Console.Write("     `. `.    `.     \\                ,\n");
                Console.SetCursorPosition(x, y + 26); Console.Write("       .  .     .     .             ,'\n");
                Console.SetCursorPosition(x, y + 27); Console.Write("        `  `.    `.    .           .\n");
                Console.SetCursorPosition(x, y + 28); Console.Write("         `.  `.    .   |        _,'\n");
                Console.SetCursorPosition(x, y + 29); Console.Write("           `    `. |   |      ,'\n");
                Console.SetCursorPosition(x, y + 30); Console.Write("            `.    `'   |  _.-'\n");
                Console.SetCursorPosition(x, y + 31); Console.Write("              `-.      ;-'\n");
                Console.SetCursorPosition(x, y + 32); Console.Write("                 `--..\" \n");
            }

            else if (pokenumber == 71)
            {
                Console.SetCursorPosition(x, y); Console.Write("                                       ___\n");
                Console.SetCursorPosition(x, y + 1); Console.Write("                                    ,\"\" __\"`.\n");
                Console.SetCursorPosition(x, y + 2); Console.Write("                                   / .'\"   `-`.\n");
                Console.SetCursorPosition(x, y + 3); Console.Write("                                  / /        ` .\n");
                Console.SetCursorPosition(x, y + 4); Console.Write("                            _,.__. /_,...._   \\ \\\n");
                Console.SetCursorPosition(x, y + 5); Console.Write("                         ,-'     |j        `-._\\ \\\n");
                Console.SetCursorPosition(x, y + 6); Console.Write("                      _,'        ||            `._\\\n");
                Console.SetCursorPosition(x, y + 7); Console.Write("                    ,'_,..,.      |        .----._`.\n");
                Console.SetCursorPosition(x, y + 8); Console.Write("                  _,\"'   / /     `'         `.   ){`-'\n");
                Console.SetCursorPosition(x, y + 9); Console.Write("                        / j               ,_  \\   `|\n");
                Console.SetCursorPosition(x, y + 10); Console.Write("                       j ,'-._      _..-\"\"' | `.  ||\n");
                Console.SetCursorPosition(x, y + 11); Console.Write("                       | |    `'-.,'        |  |  ||\n");
                Console.SetCursorPosition(x, y + 12); Console.Write("                       | |  _.              ' j   ||\n");
                Console.SetCursorPosition(x, y + 13); Console.Write("                       ' '.'.'         \\\"-./ ,    |'\n");
                Console.SetCursorPosition(x, y + 14); Console.Write("                        ` `/_           \\_/ /     | L\n");
                Console.SetCursorPosition(x, y + 15); Console.Write("                         `._ `-..___,.-'\"_,){      | |\n");
                Console.SetCursorPosition(x, y + 16); Console.Write("                          | `._      _,-' ||      | |\n");
                Console.SetCursorPosition(x, y + 17); Console.Write("                          |`..,+----`.__,\" |      | |\n");
                Console.SetCursorPosition(x, y + 18); Console.Write("                          |                |      | |\n");
                Console.SetCursorPosition(x, y + 19); Console.Write("         _.--\"\"\"\"--._     |               _'    _.+-'\"\"\"'`-._\n");
                Console.SetCursorPosition(x, y + 20); Console.Write("       ,'            `-.  |.-.           , `\\ ,'             `.\n");
                Console.SetCursorPosition(x, y + 21); Console.Write("     ,'                 \\j |  |          `./ /                 `.\n");
                Console.SetCursorPosition(x, y + 22); Console.Write("    / _.--\"\"\"--._        | `-\"               |    _,.-------.._  \\\n");
                Console.SetCursorPosition(x, y + 23); Console.Write("   /.'           `-.    j                    | ,-'             `-.\\\n");
                Console.SetCursorPosition(x, y + 24); Console.Write("  ,'                `-. |                    |'                   '.\n");
                Console.SetCursorPosition(x, y + 25); Console.Write(" /   __                \\|                    /                      `\n");
                Console.SetCursorPosition(x, y + 26); Console.Write("j .'\"  \"-..             |  _         ,\"`.    |           _,.--'\"\"'-. .\n");
                Console.SetCursorPosition(x, y + 27); Console.Write("|/){        `._          / | \\        |  |    |        _,){           \\|\n");
                Console.SetCursorPosition(x, y + 28); Console.Write("` '           `-._    ,'| `.,'       '.-'    `..__,..' '`.   __\n");
                Console.SetCursorPosition(x, y + 29); Console.Write(" '                `\"\"'  '                    ;          `.`.'  \"'--...,'\n");
                Console.SetCursorPosition(x, y + 30); Console.Write("                         .  Y.          /\"','             '-..____,.-'\n");
                Console.SetCursorPosition(x, y + 31); Console.Write("                          `-._         _`-'\n");
                Console.SetCursorPosition(x, y + 32); Console.Write("                              `\"------\" \n");
            }

            else if (pokenumber == 72)
            {
                Console.SetCursorPosition(x, y); Console.Write("                             _,--'\"\"\"`\"--._\n");
                Console.SetCursorPosition(x, y + 1); Console.Write("                           ,'            _.-+._\n");
                Console.SetCursorPosition(x, y + 2); Console.Write("                       ,-.'            ,'      `.\n");
                Console.SetCursorPosition(x, y + 3); Console.Write("                     .'  |            .          `.\n");
                Console.SetCursorPosition(x, y + 4); Console.Write("                    /    '            |            \\\n");
                Console.SetCursorPosition(x, y + 5); Console.Write("                   /    /             |             L\n");
                Console.SetCursorPosition(x, y + 6); Console.Write("                  /    /            . |             |\n");
                Console.SetCursorPosition(x, y + 7); Console.Write("                 j    /             | '             |\n");
                Console.SetCursorPosition(x, y + 8); Console.Write("                 |   /              '  .            |\n");
                Console.SetCursorPosition(x, y + 9); Console.Write("                 |  j  .             \\  .           |\n");
                Console.SetCursorPosition(x, y + 10); Console.Write("                 '  | /               `  `.       .''\n");
                Console.SetCursorPosition(x, y + 11); Console.Write("                  \\ |j                 `.  `-....\" j\n");
                Console.SetCursorPosition(x, y + 12); Console.Write("                  |`'|   ,',..           `.._      |\n");
                Console.SetCursorPosition(x, y + 13); Console.Write("                  `. `   |/   \\              `     |\n");
                Console.SetCursorPosition(x, y + 14); Console.Write("                    `.   `.   |                    |\n");
                Console.SetCursorPosition(x, y + 15); Console.Write("                     |     `__'                    |_,..---..\n");
                Console.SetCursorPosition(x, y + 16); Console.Write("                   __|                            ,'         |\n");
                Console.SetCursorPosition(x, y + 17); Console.Write("                .\"\"  '     .    '               ,'           |\n");
                Console.SetCursorPosition(x, y + 18); Console.Write("                |     .    |     \\   ____     ,'             |\n");
                Console.SetCursorPosition(x, y + 19); Console.Write("                .      `-..L      `,'u   `){-./              j\n");
                Console.SetCursorPosition(x, y + 20); Console.Write("                '        |u \\     /    _,-'  |             /\n");
                Console.SetCursorPosition(x, y + 21); Console.Write("                 `.   ,./`\"\"`\\_ ,'`\"--'      |            /\n");
                Console.SetCursorPosition(x, y + 22); Console.Write("                   `./  \\..._  |    _,..._   |.---+.    ,'\n");
                Console.SetCursorPosition(x, y + 23); Console.Write("                    / ,'     `.|  ,'      `--'-.   \\`--'\n");
                Console.SetCursorPosition(x, y + 24); Console.Write("                   j .         `.'              `.  .\n");
                Console.SetCursorPosition(x, y + 25); Console.Write("                   | |                           |  |\n");
                Console.SetCursorPosition(x, y + 26); Console.Write("                   | |                           |  |\n");
                Console.SetCursorPosition(x, y + 27); Console.Write("                  j j                            |  |\n");
                Console.SetCursorPosition(x, y + 28); Console.Write("                 ,' |                            |  |\n");
                Console.SetCursorPosition(x, y + 29); Console.Write("           ___.-'  ,'                            |  |          _,-..\n");
                Console.SetCursorPosition(x, y + 30); Console.Write("    _,.-'\"\"   __,.-'                             |  |       ,-' ,--\"'\n");
                Console.SetCursorPosition(x, y + 31); Console.Write(" ,-',.-' _,.-'                                   |  '     ,'  .'   /\n");
                Console.SetCursorPosition(x, y + 32); Console.Write(". ,' _,-'                                         .  `---'  ,'  _,'\n");
                Console.SetCursorPosition(x, y + 33); Console.Write("|/ .'                                              `.    _,' _,'\n");
                Console.SetCursorPosition(x, y + 34); Console.Write("`-'                                                  `\"-`.,-' \n");
            }

            else if (pokenumber == 73)
            {
                Console.SetCursorPosition(x, y); Console.Write("                                      _.._,-\"\"-.._     \n");
                Console.SetCursorPosition(x, y + 1); Console.Write("                             _....\"\".'_,./        `.\n");
                Console.SetCursorPosition(x, y + 2); Console.Write("                           .'  ,|   ,'   |          `.\n");
                Console.SetCursorPosition(x, y + 3); Console.Write("                          ' _,'\"'\"\"'      `.          |\n");
                Console.SetCursorPosition(x, y + 4); Console.Write("                         .,' ___            `--....__ |\n");
                Console.SetCursorPosition(x, y + 5); Console.Write("                        ,|.\"\"   `-.____,.--'\"\"\"\"`-._ `'.\n");
                Console.SetCursorPosition(x, y + 6); Console.Write("                      ,','            _,.--         `.._`.._\n");
                Console.SetCursorPosition(x, y + 7); Console.Write("                    ,.,'          _.-\"   /'\"\"-._        `\"'-`.\n");
                Console.SetCursorPosition(x, y + 8); Console.Write("                   /      ,-\"\"\"-,'-.._,.'       `.           |\n");
                Console.SetCursorPosition(x, y + 9); Console.Write("                  (      |`.__,' `.      ,-.      |         (\n");
                Console.SetCursorPosition(x, y + 10); Console.Write("                   `._   |_.'     |  /|  ` |,\" .  |          |\n");
                Console.SetCursorPosition(x, y + 11); Console.Write("                     /`  |       .'  |`   `.'.`\\`/          ,'\n");
                Console.SetCursorPosition(x, y + 12); Console.Write("                    '._ j       /   .` .    .``.`.`-._ _,.-'\n");
                Console.SetCursorPosition(x, y + 13); Console.Write("                       `/      /    ||`.`    `..``.`-.`.._\n");
                Console.SetCursorPosition(x, y + 14); Console.Write("       _              ,'      /,.___'|  ``.,..-\\`-\\`/ `._.+,------._\n");
                Console.SetCursorPosition(x, y + 15); Console.Write("      \\ `\"-.__      ,+      .'|| | j |+-+-`._`+.\\+--\"\"\"\"            `-.\n");
                Console.SetCursorPosition(x, y + 16); Console.Write("       `._    \"'\"'\"'/|     j| |' . | |\\`.`.  |+---+--+-+--.....__      \\\n");
                Console.SetCursorPosition(x, y + 17); Console.Write("     __..-`--------+-|     || | \\ / / \\\\ \\ \\ | `.\\ \\. \\ \\   `. `.`-.___/\n");
                Console.SetCursorPosition(x, y + 18); Console.Write("   .'       _,.-',','`     || |  /,\\  ` \\ ' \\|   `\\ \\`.\\ '    \\  \\\n");
                Console.SetCursorPosition(x, y + 19); Console.Write(" ,'     _,-'    / . .'\\    || |,'/\\ \\  \\ \\ \\ |    | |-. L`+._  \\  |\n");
                Console.SetCursorPosition(x, y + 20); Console.Write("/    ,/'       . j  | |\\   '.-'.'  \\ `. \\ \\ .|    / `  `| |  `-.`-'\n");
                Console.SetCursorPosition(x, y + 21); Console.Write("|   ,'        j  | j  | `.  `.\"\\    `  \\ . .|'   /|  \\  | |`.   .\n");
                Console.SetCursorPosition(x, y + 22); Console.Write("`..'          .  | |  `.  /. `. `    `. `| |/   / |  |  |  . `-.'\n");
                Console.SetCursorPosition(x, y + 23); Console.Write("              |  | `.  | /  +. \\ `.    \\ |,'  ,'\\ |  |  |  |\n");
                Console.SetCursorPosition(x, y + 24); Console.Write("              |. |  `..' | .' `\".  .   _\\+  _.| | |  '  '  '\n");
                Console.SetCursorPosition(x, y + 25); Console.Write("              .`.'       `-'    `--'  '--+\"'| `.' `-'  `..'\n");
                Console.SetCursorPosition(x, y + 26); Console.Write("                                         `--' \n");
            }

            else if (pokenumber == 74)
            {
                Console.SetCursorPosition(x, y); Console.Write("                                            _,.---.\n");
                Console.SetCursorPosition(x, y + 1); Console.Write("                                        _,-'       `.\n");
                Console.SetCursorPosition(x, y + 2); Console.Write("                                     _,'  ,          \\\n");
                Console.SetCursorPosition(x, y + 3); Console.Write("                                   ,'  _,'   .        `.\n");
                Console.SetCursorPosition(x, y + 4); Console.Write("                                  /  ,'     ,'          `.\n");
                Console.SetCursorPosition(x, y + 5); Console.Write("         __                       .,'    _,'              `.\n");
                Console.SetCursorPosition(x, y + 6); Console.Write("    _,..'  `-....___              ){    ,'     '             \\\n");
                Console.SetCursorPosition(x, y + 7); Console.Write("  ,'   /            ){             /`.,'      /               `\n");
                Console.SetCursorPosition(x, y + 8); Console.Write(" /    /  ._         |         __..|  `.    .'       ,         `.\n");
                Console.SetCursorPosition(x, y + 9); Console.Write(" |   |   ,'\"--._    |      ,-'    `-._`.,-'       ,){            .\n");
                Console.SetCursorPosition(x, y + 10); Console.Write(".'\\   \\     _,'.    `'___.'           `\"`.     _,' /            |\n");
                Console.SetCursorPosition(x, y + 11); Console.Write("|  \\   \\---'       ,\"'  .-\"\"'\"----.       `.  '  ,'             |\n");
                Console.SetCursorPosition(x, y + 12); Console.Write(" `. `-.'          /    /                    `-..^._             '\n");
                Console.SetCursorPosition(x, y + 13); Console.Write("   |._|    _.    /    /                            `._           .\n");
                Console.SetCursorPosition(x, y + 14); Console.Write("   `...){--'--+..'   ,'                              /            |\n");
                Console.SetCursorPosition(x, y + 15); Console.Write("       '._  `|   ,-'       _..._                   j     \\       |\n");
                Console.SetCursorPosition(x, y + 16); Console.Write("         |` |   /       ,-'     `-.__              |      L      |\n");
                Console.SetCursorPosition(x, y + 17); Console.Write("         |  |  /      ,'                           |      |      |\n");
                Console.SetCursorPosition(x, y + 18); Console.Write("         |_,'        /         _,-                  .     |      |\n");
                Console.SetCursorPosition(x, y + 19); Console.Write("        ,'  ,   |  ,'        ,|            ,..._     \\    |      '\n");
                Console.SetCursorPosition(x, y + 20); Console.Write("       ,     \\ j  '       _.\" |           /     `-.__'    '    ,'\n");
                Console.SetCursorPosition(x, y + 21); Console.Write("        +._   '|       ,'|    |          /        ,'    .'    /\n");
                Console.SetCursorPosition(x, y + 22); Console.Write("        |  `._  `-' .){|  |    '.       -'        '           j\n");
                Console.SetCursorPosition(x, y + 23); Console.Write("        '    |`    ' |'  |     |                             |\n");
                Console.SetCursorPosition(x, y + 24); Console.Write("         `.  |       |--'     _|        .                    |\n");
                Console.SetCursorPosition(x, y + 25); Console.Write("           \\ |       '----'\"\"\"           \\      __,....-+----'\n");
                Console.SetCursorPosition(x, y + 26); Console.Write("           | '                            `---\"\"      .'\n");
                Console.SetCursorPosition(x, y + 27); Console.Write("           `. `.                                     ,\n");
                Console.SetCursorPosition(x, y + 28); Console.Write("             `\" \\_...-\"\"\"'--..         _+          ,'\n");
                Console.SetCursorPosition(x, y + 29); Console.Write("                  '            -.'  `-'  `.  .\"-..'\n");
                Console.SetCursorPosition(x, y + 30); Console.Write("                   `-..._            _____,.'\n");
                Console.SetCursorPosition(x, y + 31); Console.Write("                         `--.....,-\"' \n");
            }

            else if (pokenumber == 75)
            {
                Console.SetCursorPosition(x, y); Console.Write("               __..  ,..--+'\"\"--.._\n");
                Console.SetCursorPosition(x, y + 1); Console.Write("            ,-'    \\_|_...'        |\n");
                Console.SetCursorPosition(x, y + 2); Console.Write("     ,'\\  ,'`.,----\"    '          |.._\n");
                Console.SetCursorPosition(x, y + 3); Console.Write("    /  _\\_'   `.                _,.+.  `-.___\n");
                Console.SetCursorPosition(x, y + 4); Console.Write("    |          |           ,.--'     \\       `.\n");
                Console.SetCursorPosition(x, y + 5); Console.Write("  /'|          |\\,-.       |          `\"--.    `.\n");
                Console.SetCursorPosition(x, y + 6); Console.Write(" |  |          |/   \\                      ){     |\n");
                Console.SetCursorPosition(x, y + 7); Console.Write(" |  '          /    '                      |     |\n");
                Console.SetCursorPosition(x, y + 8); Console.Write(" `.|         ,'    /                       '     `\n");
                Console.SetCursorPosition(x, y + 9); Console.Write("|\"j               _,\\                             \\\n");
                Console.SetCursorPosition(x, y + 10); Console.Write("| /  ,          -'   \\                             \\\n");
                Console.SetCursorPosition(x, y + 11); Console.Write(" |  '/     _.-       |            _,.               `..\n");
                Console.SetCursorPosition(x, y + 12); Console.Write(".'| /   ,-'/     --- `         -\"'   `.                |\n");
                Console.SetCursorPosition(x, y + 13); Console.Write(" `| `--d  |         __        __       |        __     |\n");
                Console.SetCursorPosition(x, y + 14); Console.Write(" /    /...'   .  ,\"'  .         `.    .'          \\    |\n");
                Console.SetCursorPosition(x, y + 15); Console.Write("'..-----.._ ,'   |    '           \\    `           |   |\n");
                Console.SetCursorPosition(x, y + 16); Console.Write("   |/  _,.-'     '                      \\          /  ,'\n");
                Console.SetCursorPosition(x, y + 17); Console.Write("  /'\"\"'                      .\"\\         \\       ,'   |\n");
                Console.SetCursorPosition(x, y + 18); Console.Write("   -...--.__                 `  \\        _\\..     \\   `.\n");
                Console.SetCursorPosition(x, y + 19); Console.Write("    `.                        \\\"        ){   |     |   /\n");
                Console.SetCursorPosition(x, y + 20); Console.Write("     |    _..-.    ,..-.       `.    ..\"    `     /  .'\n");
                Console.SetCursorPosition(x, y + 21); Console.Write("   ,-|   |     `---;             |           `.  '   |\n");
                Console.SetCursorPosition(x, y + 22); Console.Write("   \\  `. `---._ '\"\"`---.         |             | __.-'\n");
                Console.SetCursorPosition(x, y + 23); Console.Write("   |..\"|+.\"`-'        /         j.            /  |\n");
                Console.SetCursorPosition(x, y + 24); Console.Write("    `. | \\          \"'      _.' '|           /  /\n");
                Console.SetCursorPosition(x, y + 25); Console.Write("     |\"\"`.`\"'          __,\"\"  __.-          j ,'\n");
                Console.SetCursorPosition(x, y + 26); Console.Write("     .--- \\ `--------\"'      ,              +'\n");
                Console.SetCursorPosition(x, y + 27); Console.Write("     |__,' `+.          .    |.            |\n");
                Console.SetCursorPosition(x, y + 28); Console.Write("   ,'  |     \\`-.___,-' `.__.' `.          |\n");
                Console.SetCursorPosition(x, y + 29); Console.Write("   |._,'   | |   |         |   ,'\\    '.   '\n");
                Console.SetCursorPosition(x, y + 30); Console.Write("   |\"`.--|-+.' _.'         |`..  /`--/ ){.-.|\n");
                Console.SetCursorPosition(x, y + 31); Console.Write("   '  |  \\  |,'.. _     .-' _ .-'   /.-'  /\n");
                Console.SetCursorPosition(x, y + 32); Console.Write("    `-'   `.|_(._|______|_ /  '.__,' \\,...'\n");
                Console.SetCursorPosition(x, y + 33); Console.Write("                          `\"-------'\" \n");
            }

            else if (pokenumber == 76)
            {
                Console.SetCursorPosition(x, y); Console.Write("                            _____   ____\n");
                Console.SetCursorPosition(x, y + 1); Console.Write("                       _,.,|     `\"`-.._`--._\n");
                Console.SetCursorPosition(x, y + 2); Console.Write("                    _,\" ,j |            `\"-. `-,\n");
                Console.SetCursorPosition(x, y + 3); Console.Write("                 _,\"_,-' ' |._              `.  \\`.\n");
                Console.SetCursorPosition(x, y + 4); Console.Write("               ,' ,',.....L   `-._            \\  . `.\n");
                Console.SetCursorPosition(x, y + 5); Console.Write("             .' ,\"'\"`.__  |       `-.._        | |   \\\n");
                Console.SetCursorPosition(x, y + 6); Console.Write("   ,.._     ,'-/     '  `.|..'\"\"|`._   `-.___.-','-._ `.\n");
                Console.SetCursorPosition(x, y + 7); Console.Write(" ,' . _>-.._/ /     /    /   `-.' \\ `-._  |   ,'     `-..\n");
                Console.SetCursorPosition(x, y + 8); Console.Write("/,..|`._'  / /     /   ,'   _ _\\   `.   `-){..'          `\\\n");
                Console.SetCursorPosition(x, y + 9); Console.Write("''  | .--./ /     /   / ,'\"\"|/ .'\"\"'\\`.._ |  \\            |\n");
                Console.SetCursorPosition(x, y + 10); Console.Write("  /'`.   / |`...+.   /.' _.`+._ `._/ \\'| `|\\  `.____      |\n");
                Console.SetCursorPosition(x, y + 11); Console.Write(" /,..){.-+ _|.-\"'\"\"`./__.\"      `.|    j   `.\\  /---._\"---.|`.\n");
                Console.SetCursorPosition(x, y + 12); Console.Write(" '     _){\"    ____  | |          `+---'     `\\/       \"-._| |\n");
                Console.SetCursorPosition(x, y + 13); Console.Write("     ,'    ,+\"  |   ' '.           \\`.       |            `.|\n");
                Console.SetCursorPosition(x, y + 14); Console.Write("    .     d |  /     \\  \\          |  \\      |             ||\n");
                Console.SetCursorPosition(x, y + 15); Console.Write("    |   _/..+.'       \\  \\      __,^.  '._   |            j |\n");
                Console.SetCursorPosition(x, y + 16); Console.Write("   ,'_,'        ___    \\  `----\" ,.--`+..,.-'+`-.._       | |\n");
                Console.SetCursorPosition(x, y + 17); Console.Write("  ',\"     ____,'/     / +...--'_,.--\"'||       '._ `-..__/ /\n");
                Console.SetCursorPosition(x, y + 18); Console.Write("   `...--\"'|  .'   _,'| / ..-'\"       ||          `.    / |\n");
                Console.SetCursorPosition(x, y + 19); Console.Write("          ,'./ ,.-'   |j |          __||          .'`,\"__.'\n");
                Console.SetCursorPosition(x, y + 20); Console.Write("          \\__.'\\     j | |        ,'    `-.     ,\" ,'.\" .'\n");
                Console.SetCursorPosition(x, y + 21); Console.Write("              \\|     | 'j       ,'         `. ,' .',' .'\n");
                Console.SetCursorPosition(x, y + 22); Console.Write("             . `.____|/ |__    ){            |`,-'.'_.\"\n");
                Console.SetCursorPosition(x, y + 23); Console.Write("             '.  `._ _.\"-._`-._|            +----'\"\n");
                Console.SetCursorPosition(x, y + 24); Console.Write("               `.   `\"\"-.._`-._|            |\n");
                Console.SetCursorPosition(x, y + 25); Console.Write("                |          `<\" `.           |\n");
                Console.SetCursorPosition(x, y + 26); Console.Write("                /            `.  `.         '\n");
                Console.SetCursorPosition(x, y + 27); Console.Write("           ,.\"){\"_,-           |,..'          `._\n");
                Console.SetCursorPosition(x, y + 28); Console.Write("          '.__|' ,--.    __,.\"'> .             /`.\n");
                Console.SetCursorPosition(x, y + 29); Console.Write("              '\"\"`---`'\"\"  \\_.' _|-\"){__,....--'\"''\n");
                Console.SetCursorPosition(x, y + 30); Console.Write("                             `-',..-' \n");
            }

            else if (pokenumber == 77)
            {
                Console.SetCursorPosition(x, y); Console.Write("                    .' .\n");
                Console.SetCursorPosition(x, y + 1); Console.Write("                   .| '\\\n");
                Console.SetCursorPosition(x, y + 2); Console.Write("           _...___/`'   .\n");
                Console.SetCursorPosition(x, y + 3); Console.Write("         ,'             |\n");
                Console.SetCursorPosition(x, y + 4); Console.Write("     ,|,\"             )/|                             , .\n");
                Console.SetCursorPosition(x, y + 5); Console.Write("    / |              / , .                            \\` \\\n");
                Console.SetCursorPosition(x, y + 6); Console.Write("   /            ...-'  ',                              .  \\\n");
                Console.SetCursorPosition(x, y + 7); Console.Write("  .           ,>      .                                |   |\n");
                Console.SetCursorPosition(x, y + 8); Console.Write("  |          .'   ___`,                  .'  ,--.._,.-'/  ,'\n");
                Console.SetCursorPosition(x, y + 9); Console.Write("..|          |.-\"', /                  ,' | /       .\"'   '.\n");
                Console.SetCursorPosition(x, y + 10); Console.Write("\\ '          |  ,'//                   .'  \"    __,._'    |\n");
                Console.SetCursorPosition(x, y + 11); Console.Write(" \\ `         /.\"_/'_,                 '.       /         _'\n");
                Console.SetCursorPosition(x, y + 12); Console.Write("  `.\\     _,'   \\.`  ) ,^.              `     '       ,-\"\n");
                Console.SetCursorPosition(x, y + 13); Console.Write("    |.  .'  _   | `. '-  `,            , \\     `.    ,-\n");
                Console.SetCursorPosition(x, y + 14); Console.Write("    | `w  ,\" |  |   \\   .'   _,_ ){\"'. / 7 . ,`..'   .'\n");
                Console.SetCursorPosition(x, y + 15); Console.Write("    '|    `.'  /     \\   `-'\"   `   _){_,.}|  ){  _. ,'\n");
                Console.SetCursorPosition(x, y + 16); Console.Write("     \\       .'       `-.      _,.-\"       `-+-`  '\n");
                Console.SetCursorPosition(x, y + 17); Console.Write("     |       |           ``--\"'               `.\n");
                Console.SetCursorPosition(x, y + 18); Console.Write("     \\   .- .                                   \\\n");
                Console.SetCursorPosition(x, y + 19); Console.Write("      `.._,\"){                                    \\\n");
                Console.SetCursorPosition(x, y + 20); Console.Write("            '                                    `.  '-7\n");
                Console.SetCursorPosition(x, y + 21); Console.Write("             \\                                  .'`-\"  ){\n");
                Console.SetCursorPosition(x, y + 22); Console.Write("              \\                        .        `      `-'\n");
                Console.SetCursorPosition(x, y + 23); Console.Write("             j \\                       `.        `.     |\n");
                Console.SetCursorPosition(x, y + 24); Console.Write("             |  `.  |      .^,'.       ,.+        ){    _'\n");
                Console.SetCursorPosition(x, y + 25); Console.Write("             |   |`.|      |    \\,  ,-'  ){`.       \\  /_.,\n");
                Console.SetCursorPosition(x, y + 26); Console.Write("            /    |  |     /     .,-'.     `.`.      \\   /\n");
                Console.SetCursorPosition(x, y + 27); Console.Write("           /    .' j     / _._,\"     `      '){`.     . (\n");
                Console.SetCursorPosition(x, y + 28); Console.Write("          /    /,-\"|    j  `.         `-.    |  .    |/\n");
                Console.SetCursorPosition(x, y + 29); Console.Write("          .   `'   |    |    7           |   |   |   |\n");
                Console.SetCursorPosition(x, y + 30); Console.Write("           `.   .  |    |  v'            |  .'   |   |\n");
                Console.SetCursorPosition(x, y + 31); Console.Write("             `.  `.|   j'.'              |  |    |  j\n");
                Console.SetCursorPosition(x, y + 32); Console.Write("               \\   |   |                j   |   j   |\n");
                Console.SetCursorPosition(x, y + 33); Console.Write("                `.j   /\\                |_,j    |  j\n");
                Console.SetCursorPosition(x, y + 34); Console.Write("                  /  /`\"              ,\"   |    '  |\n");
                Console.SetCursorPosition(x, y + 35); Console.Write("                 /  j                 '_,.-'   /.-'|\n");
                Console.SetCursorPosition(x, y + 36); Console.Write("                |   |                         /__.-'\n");
                Console.SetCursorPosition(x, y + 37); Console.Write("               .'`-.'\n");
                Console.SetCursorPosition(x, y + 38); Console.Write("              /    |\n");
                Console.SetCursorPosition(x, y + 39); Console.Write("              `----' \n");
            }

            else if (pokenumber == 78)
            {
                Console.SetCursorPosition(x, y); Console.Write("                     ){`./\n");
                Console.SetCursorPosition(x, y + 1); Console.Write("                    _|  ,-\n");
                Console.SetCursorPosition(x, y + 2); Console.Write("               ,'\"\"'    ,`\n");
                Console.SetCursorPosition(x, y + 3); Console.Write("             ,'.\\       `.    __  ,.-.\n");
                Console.SetCursorPosition(x, y + 4); Console.Write("          . ./ `'    __  '. ,'  \\ `.|\n");
                Console.SetCursorPosition(x, y + 5); Console.Write("          \\\\  \\   .\"'  L   \"     `\" `\\                          _,-.\n");
                Console.SetCursorPosition(x, y + 6); Console.Write("           \\` |\\.`      7     .,   ){._|   --'`.                 ` |\n");
                Console.SetCursorPosition(x, y + 7); Console.Write("          ` \\`+ `'\\      \\^--\"  `. |    ,'     `.            ,..' |\n");
                Console.SetCursorPosition(x, y + 8); Console.Write("           | ,.    |              ` `.  |    ..  '.          |    /\n");
                Console.SetCursorPosition(x, y + 9); Console.Write("           '){P'     '.    ,..      \\  `-+`\"-'  `._ \\     -`,- ..,'\n");
                Console.SetCursorPosition(x, y + 10); Console.Write("          /        / `-,-'  ,'`.    `.   ; .--'   `+    '.   | ,\n");
                Console.SetCursorPosition(x, y + 11); Console.Write("         /     _..     .   `-.  \\,.   `-'  '.  `.^  `\".__|   ' |\n");
                Console.SetCursorPosition(x, y + 12); Console.Write("        '   , / |       `.   \\    |        ,'     \\           /\n");
                Console.SetCursorPosition(x, y + 13); Console.Write("         `\"' \" .         \\   |  __ \\    ,-'       `----.   _,'\n");
                Console.SetCursorPosition(x, y + 14); Console.Write("              /           |  `\"' _} `\"\"'                `-'\n");
                Console.SetCursorPosition(x, y + 15); Console.Write("             /.'         /     .-.         ,\".\n");
                Console.SetCursorPosition(x, y + 16); Console.Write("     .._,.  /           /     '-.,'    ,'-. .'.\n");
                Console.SetCursorPosition(x, y + 17); Console.Write("    /  `. \\/             `-.      `.   /`.  ){\n");
                Console.SetCursorPosition(x, y + 18); Console.Write("   /  __ `.'                '-.     `-+_.'  .'          ,__\n");
                Console.SetCursorPosition(x, y + 19); Console.Write("  / .'  `.___                  `,..__      <__          \\ (\n");
                Console.SetCursorPosition(x, y + 20); Console.Write(" / /       \"..   /                   `-.     .' .-'\"`--.'  \\\n");
                Console.SetCursorPosition(x, y + 21); Console.Write("/  |       /-'  /                       \\ ,._|  |          /'\n");
                Console.SetCursorPosition(x, y + 22); Console.Write("\\.'|+.+.  (`..,'                         \\`._ _,'           \\__\n");
                Console.SetCursorPosition(x, y + 23); Console.Write(" \\ |||| \\ _`.^ `.            .            |  \"    .'`\"-.       `.\n");
                Console.SetCursorPosition(x, y + 24); Console.Write("  `+'|/ `( \\'    `-....__    |            |._,\".,'     `,        |\n");
                Console.SetCursorPosition(x, y + 25); Console.Write("                         `){-.|            `           ..'   ,'`.,-\n");
                Console.SetCursorPosition(x, y + 26); Console.Write("                          |  |            |`.        '-..    . /\n");
                Console.SetCursorPosition(x, y + 27); Console.Write("                          '  |           /  /           `.   |\n");
                Console.SetCursorPosition(x, y + 28); Console.Write("                           ` '          /  ',.         ,     `._\n");
                Console.SetCursorPosition(x, y + 29); Console.Write("                            \\|        ,'   \\'|         ){  __    '\n");
                Console.SetCursorPosition(x, y + 30); Console.Write("                             `,     ,`     .._`..       `'  `-,.`.\n");
                Console.SetCursorPosition(x, y + 31); Console.Write("                       _`'`\".  `.   ``-._ /   F   )        ,._\\ `\n");
                Console.SetCursorPosition(x, y + 32); Console.Write("                      '-\"'`, \\   \\ ,. ).-'-.^,|_,'         `  '.\n");
                Console.SetCursorPosition(x, y + 33); Console.Write("                          '.. \\___j  `\"'               ,..  | .'\n");
                Console.SetCursorPosition(x, y + 34); Console.Write("                             \\            ___       ,. `\\ \\,+-'\n");
                Console.SetCursorPosition(x, y + 35); Console.Write("                              7.._   .--+`.  |_    |  `,'\n");
                Console.SetCursorPosition(x, y + 36); Console.Write("                           _,'  .'`--'  '    7 ` v.-\n");
                Console.SetCursorPosition(x, y + 37); Console.Write("                         .\"._  /-.  -.   \\.^-`\n");
                Console.SetCursorPosition(x, y + 38); Console.Write("                       .'  __+'...`'  `--'\n");
                Console.SetCursorPosition(x, y + 39); Console.Write("                        `\"\" \n");
            }

            else if (pokenumber == 79)
            {
                Console.SetCursorPosition(x, y); Console.Write("                                  _.---\"'\"\"\"\"\"'`--.._\n");
                Console.SetCursorPosition(x, y + 1); Console.Write("                             _,.-'                   `-._\n");
                Console.SetCursorPosition(x, y + 2); Console.Write("                         _,.\"                            -.\n");
                Console.SetCursorPosition(x, y + 3); Console.Write("                     .-\"\"   ___...---------.._             `.\n");
                Console.SetCursorPosition(x, y + 4); Console.Write("                     `---'\"\"                  `-.            `.\n");
                Console.SetCursorPosition(x, y + 5); Console.Write("                                                 `.            \\\n");
                Console.SetCursorPosition(x, y + 6); Console.Write("                                                   `.           \\\n");
                Console.SetCursorPosition(x, y + 7); Console.Write("                                                     \\           \\\n");
                Console.SetCursorPosition(x, y + 8); Console.Write("                                                      .           \\\n");
                Console.SetCursorPosition(x, y + 9); Console.Write("                                                      |            .\n");
                Console.SetCursorPosition(x, y + 10); Console.Write("                                                      |            |\n");
                Console.SetCursorPosition(x, y + 11); Console.Write("                                _________             |            |\n");
                Console.SetCursorPosition(x, y + 12); Console.Write("                          _,.-'\"         `\"'-.._      ){            |\n");
                Console.SetCursorPosition(x, y + 13); Console.Write("                      _,-'                      `-._.'             |\n");
                Console.SetCursorPosition(x, y + 14); Console.Write("                   _.'                              `.             '\n");
                Console.SetCursorPosition(x, y + 15); Console.Write("        _.-.    _,+......__                           `.          .\n");
                Console.SetCursorPosition(x, y + 16); Console.Write("      .'    `-\"'           `\"-.,-\"\"--._                 \\        /\n");
                Console.SetCursorPosition(x, y + 17); Console.Write("     /    ,'                  |    __  \\                 \\      /\n");
                Console.SetCursorPosition(x, y + 18); Console.Write("    `   ..                       +\"  )  \\                 \\    /\n");
                Console.SetCursorPosition(x, y + 19); Console.Write("     `.'  \\          ,-\"`-..    |       |                  \\  /\n");
                Console.SetCursorPosition(x, y + 20); Console.Write("      / \" |        .'       \\   '.    _.'                   .'\n");
                Console.SetCursorPosition(x, y + 21); Console.Write("     |,..\"--\"\"\"--..|    \"    |    `\"\"`.                     |\n");
                Console.SetCursorPosition(x, y + 22); Console.Write("   ,\"               `-._     |        |                     |\n");
                Console.SetCursorPosition(x, y + 23); Console.Write(" .'                     `-._+         |                     |\n");
                Console.SetCursorPosition(x, y + 24); Console.Write("/                           `.                        /     |\n");
                Console.SetCursorPosition(x, y + 25); Console.Write("|    `     '                  |                      /      |\n");
                Console.SetCursorPosition(x, y + 26); Console.Write("`-.....--.__                  |              |      /       |\n");
                Console.SetCursorPosition(x, y + 27); Console.Write("   `./ \"| / `-.........--.-   '              |    ,'        '\n");
                Console.SetCursorPosition(x, y + 28); Console.Write("     /| ||        `.'  ,'   .'               |_,-+         /\n");
                Console.SetCursorPosition(x, y + 29); Console.Write("    / ' '.`.        _,'   ,'     `.          |   '   _,.. /\n");
                Console.SetCursorPosition(x, y + 30); Console.Write("   /   `.  `\"'\"'\"\"'\"   _,^--------\"`.        |    `.'_  _/\n");
                Console.SetCursorPosition(x, y + 31); Console.Write("  /... _.`){.________,.'              `._,.-..|        \"'\n");
                Console.SetCursorPosition(x, y + 32); Console.Write(" `.__.'                                 `._  /\n");
                Console.SetCursorPosition(x, y + 33); Console.Write("                                           \"' \n");
            }

            else if (pokenumber == 80)
            {
                Console.SetCursorPosition(x, y); Console.Write("                   ,-'\"-.\n");
                Console.SetCursorPosition(x, y + 1); Console.Write("             __...| .\".  |\n");
                Console.SetCursorPosition(x, y + 2); Console.Write("        ,--+\"     ' |   ,'\n");
                Console.SetCursorPosition(x, y + 3); Console.Write("       | .'   ..--,  `-' `.\n");
                Console.SetCursorPosition(x, y + 4); Console.Write("       |/    |  ,' |       ){\n");
                Console.SetCursorPosition(x, y + 5); Console.Write("       |\\...-+-\".._|       |\n");
                Console.SetCursorPosition(x, y + 6); Console.Write("     ,\"            `--.     `.     _..-'+\"/__\n");
                Console.SetCursorPosition(x, y + 7); Console.Write("    /   .              |      ){,-\"'     `\" |_'\n");
                Console.SetCursorPosition(x, y + 8); Console.Write(" ..| .    _,....___,'  |    ,'            /\\\n");
                Console.SetCursorPosition(x, y + 9); Console.Write("..\\'.__.-'  /V     |   '                ,'\"\"\n");
                Console.SetCursorPosition(x, y + 10); Console.Write("`. |  `){  \\.       |  .               ,'         ,.-.\n");
                Console.SetCursorPosition(x, y + 11); Console.Write("  `){       |       |  '             .^.        ,' ,\"`.\n");
                Console.SetCursorPosition(x, y + 12); Console.Write("    `.     |       | /               _.\\.---..'  /   |     ,-,.\n");
                Console.SetCursorPosition(x, y + 13); Console.Write("      `._  A      / j              .\"       /   /    |   .',' |\n");
                Console.SetCursorPosition(x, y + 14); Console.Write("         `. `...-' ,'             /        /._ /     | ,' /   |\n");
                Console.SetCursorPosition(x, y + 15); Console.Write("           |\"-----'             ,'        /   /-.__  |'  /    |\n");
                Console.SetCursorPosition(x, y + 16); Console.Write("           | _.--'\"'\"\"`.       .         /   /     `\"^-.,     |\n");
                Console.SetCursorPosition(x, y + 17); Console.Write("           |\"       ____\\     j             j            `\"--.|\n");
                Console.SetCursorPosition(x, y + 18); Console.Write("           |  _.-\"\"'     \\    |             |                j\n");
                Console.SetCursorPosition(x, y + 19); Console.Write("         _,+.\"_           \\   |             |                |\n");
                Console.SetCursorPosition(x, y + 20); Console.Write("        '    . `.     _.-\"'.     ,          |                '\n");
                Console.SetCursorPosition(x, y + 21); Console.Write("       |_    | `.`. ,'      `.   |          |               .\n");
                Console.SetCursorPosition(x, y + 22); Console.Write("       | `-. |  ,'.\\         .\\   \\         |              /\n");
                Console.SetCursorPosition(x, y + 23); Console.Write("       |\\   ;+-'   \"\\      ,'  `.  \\        |             /\n");
                Console.SetCursorPosition(x, y + 24); Console.Write("       '\\\\.\"         \\ _.-'     ,`. \\       '            /\n");
                Console.SetCursorPosition(x, y + 25); Console.Write("        \\\\\\           ){       .'   `.`._     \\          / `-..-.\n");
                Console.SetCursorPosition(x, y + 26); Console.Write("         ``.          |    _.\" _...,){.._`.    `._     ,'   -. \\'\n");
                Console.SetCursorPosition(x, y + 27); Console.Write("          `.`.        |`\".'__.'           `,...__\"--`/  |   / |\n");
                Console.SetCursorPosition(x, y + 28); Console.Write("            `.`.     _'    \\|             ,'       ,'_  `..'  |..__,.\n");
                Console.SetCursorPosition(x, y + 29); Console.Write("              `._`--\".'     \\`._      _,-'       ,' `-'  /    | .  ,'\n");
                Console.SetCursorPosition(x, y + 30); Console.Write("                 `\"\"'        `. `\"'\"\"'   ,-\" _,-'    _ .'     '  `' `.\n");
                Console.SetCursorPosition(x, y + 31); Console.Write("                               `-.._____){  |\"       _,\" .\"  ,'__,..\"'\n");
                Console.SetCursorPosition(x, y + 32); Console.Write("                                         `.|-...,.<'    `,_\"\"'`./\n");
                Console.SetCursorPosition(x, y + 33); Console.Write("                                             `.'   `\"--'\" \n");
            }

            else if (pokenumber == 81)
            {
                Console.SetCursorPosition(x, y); Console.Write("                                  _,._,._\n");
                Console.SetCursorPosition(x, y + 1); Console.Write("                                 '-\"._,\"--,\n");
                Console.SetCursorPosition(x, y + 2); Console.Write("                                  `\"..-+-'\n");
                Console.SetCursorPosition(x, y + 3); Console.Write("                                  ){'==-){\n");
                Console.SetCursorPosition(x, y + 4); Console.Write("                                  ){`=-\"){\n");
                Console.SetCursorPosition(x, y + 5); Console.Write("                                 _.\"-..|\n");
                Console.SetCursorPosition(x, y + 6); Console.Write("     _____                  _.-'\"  `\"\"' `-._\n");
                Console.SetCursorPosition(x, y + 7); Console.Write("    |  |  `\"\"'----._      ,'                `.\n");
                Console.SetCursorPosition(x, y + 8); Console.Write("    |__|            `.  ,'                    '.\n");
                Console.SetCursorPosition(x, y + 9); Console.Write("    '..|\"\"'---._     | /                        \\    _.......______\n");
                Console.SetCursorPosition(x, y + 10); Console.Write("          `\"\"\"--){    |/         ,.---._          \\ .'.------.....__`-...\n");
                Console.SetCursorPosition(x, y + 11); Console.Write("                |    j        ,'       `.         . '              |\"--|\n");
                Console.SetCursorPosition(x, y + 12); Console.Write(".'\"\"|\"---......-'   .|       /           \\        |'     ______    |   |\n");
                Console.SetCursorPosition(x, y + 13); Console.Write("|   |              / |      .      .      .       |    .'      `\"\"`--..'\n");
                Console.SetCursorPosition(x, y + 14); Console.Write("){\"\"'|---.....___.-'.'|      |             |       |    ){\n");
                Console.SetCursorPosition(x, y + 15); Console.Write(" `\"`+---....____,.'  `      `.           /       /|    '_\n");
                Console.SetCursorPosition(x, y + 16); Console.Write("                      \\ _,..  `.       ,'       / `      `\"\"'--....,._\n");
                Console.SetCursorPosition(x, y + 17); Console.Write("                      .'){){__){   `-...-'        ,   `._            '   |\n");
                Console.SetCursorPosition(x, y + 18); Console.Write("                      |-..--|          ,-\"-. ,'       \"--.....___){   j\n");
                Console.SetCursorPosition(x, y + 19); Console.Write("                      `.){){_,          |.-''-){                     `\"'\n");
                Console.SetCursorPosition(x, y + 20); Console.Write("                            `\"-...____' \" ){.'\n");
                Console.SetCursorPosition(x, y + 21); Console.Write("                                       `\"\"' \n");
                Console.SetCursorPosition(x, y + 22); Console.Write("\n");
            }


            else if (pokenumber == 82)
            {
                Console.SetCursorPosition(x, y); Console.Write("                                 _\n");
                Console.SetCursorPosition(x, y + 1); Console.Write("                              ,\"'_\\\n");
                Console.SetCursorPosition(x, y + 2); Console.Write("                         ,\"\\  `.\"  \\       ,..._\n");
                Console.SetCursorPosition(x, y + 3); Console.Write("                        '.' \\   \\   .     ('\"\"`.\\     _\n");
                Console.SetCursorPosition(x, y + 4); Console.Write("                         \\   \\  `.  |      /=.){.'  ,){`.`.\n");
                Console.SetCursorPosition(x, y + 5); Console.Write("                          \\   \\.';  |\"\"\"\"\"`-./   .'   .`\n");
                Console.SetCursorPosition(x, y + 6); Console.Write("                           \\   `\"   '         `.'   ,' ,\"`.\n");
                Console.SetCursorPosition(x, y + 7); Console.Write("                            `.___..'            `. `..){'`./\n");
                Console.SetCursorPosition(x, y + 8); Console.Write("                            /             _,.._   \\    _.'\n");
                Console.SetCursorPosition(x, y + 9); Console.Write("                 _....__   /            ,\"     `.  ._,'\n");
                Console.SetCursorPosition(x, y + 10); Console.Write("             ,-\"'       `\"+.           ){         . |\n");
                Console.SetCursorPosition(x, y + 11); Console.Write("+'\"|\"\"'-.  ,'               `.         |      \"  | |\n");
                Console.SetCursorPosition(x, y + 12); Console.Write("\\\\_|__   `){                   \\         \\       /  |          _,-.\n");
                Console.SetCursorPosition(x, y + 13); Console.Write("      ){)  |        ,.-----.    \\         ._   .'   '._    _,-'`\\  j\n");
                Console.SetCursorPosition(x, y + 14); Console.Write("  ...,'   |       /        \\    . __ _ _,\".`\"'   ,'   `.,\"    _.`\"\n");
                Console.SetCursorPosition(x, y + 15); Console.Write("  \\\\ |  _,'      .          .   || |I ' -'|    _, _     `   ,\"'  _.\".\n");
                Console.SetCursorPosition(x, y + 16); Console.Write("  `\"\"''){         '     \"    |   |`\"'^\"`\"| /  ,`){){//\\     \\  `..-' \\  '\n");
                Console.SetCursorPosition(x, y + 17); Console.Write("       '          \\        /   ,\"\"`--..`\"\"-\"`\"\"'){{.|      .      _,+\"\n");
                Console.SetCursorPosition(x, y + 18); Console.Write("        .          `-....-'   ){`){'-|            |l,'      |.__.-\"\n");
                Console.SetCursorPosition(x, y + 19); Console.Write("         \\,.                  '. ){/                       |\n");
                Console.SetCursorPosition(x, y + 20); Console.Write("     .-.\"){`.`.              ,'  \"'     ,\"-.   _       _,._|\n");
                Console.SetCursorPosition(x, y + 21); Console.Write("     \\`. \\`,\"`._        __,){      .    `.'/`,'.`.   .'    '\n");
                Console.SetCursorPosition(x, y + 22); Console.Write("      '.`.;     \"--+--'\"_  `       `     `.` \"' ; ,'  .  /\n");
                Console.SetCursorPosition(x, y + 23); Console.Write("        `\"         ||  ){|.  ){       `.     \\_){.' ){    _.'\n");
                Console.SetCursorPosition(x, y + 24); Console.Write("                   ||  |||__|         `._        `...\"\n");
                Console.SetCursorPosition(x, y + 25); Console.Write("                   ||__||| _|            `\"-....-\"\\\\,\\\n");
                Console.SetCursorPosition(x, y + 26); Console.Write("                   || _| `\"                  \\\\  \\ \\\\'\n");
                Console.SetCursorPosition(x, y + 27); Console.Write("                   `\"'                        \\`.-\\\n");
                Console.SetCursorPosition(x, y + 28); Console.Write("                                               \\\\.' \n");
            }

            else if (pokenumber == 83)
            {
                Console.SetCursorPosition(x, y); Console.Write("        .\n");
                Console.SetCursorPosition(x, y + 1); Console.Write("      ,' \\\\\n");
                Console.SetCursorPosition(x, y + 2); Console.Write("     /   ' \\\n");
                Console.SetCursorPosition(x, y + 3); Console.Write("  _  \\    \\ \\\n");
                Console.SetCursorPosition(x, y + 4); Console.Write(" / \". \\    ` \\                                        ,.\n");
                Console.SetCursorPosition(x, y + 5); Console.Write("j    \\ \\    ` \\                \"\"\"'-. ..          .. ){| \\\n");
                Console.SetCursorPosition(x, y + 6); Console.Write("|     `.\\    ` `              __ `.  \\){ \\         \\ `||  .    ___\n");
                Console.SetCursorPosition(x, y + 7); Console.Write(" `.     `\\    `.`.            \\ `\"-`. \\ |          \\ `|  |   //  |\n");
                Console.SetCursorPosition(x, y + 8); Console.Write(" _ '.     `     . `.           `-.,    `'-.._       \\    |  //   |\n");
                Console.SetCursorPosition(x, y + 9); Console.Write("| `._`.          `. `         .-'   --._  || `.      \\   | //   j\n");
                Console.SetCursorPosition(x, y + 10); Console.Write("|    `.`           . `.      /     .\"\"-.`._|.\".\\      \\,-|'/    |\n");
                Console.SetCursorPosition(x, y + 11); Console.Write("'       `.          `. `.   /      | '){){|  '|){| .      ){ |,     '\n");
                Console.SetCursorPosition(x, y + 12); Console.Write(" `._                  .  \\ ){       |  ){){|.-\"\"\"'.|___...+-+-..  /\n");
                Console.SetCursorPosition(x, y + 13); Console.Write("    `-.                \\  `){       '__.,'               _,..-)/\n");
                Console.SetCursorPosition(x, y + 14); Console.Write("   .\"`-`.               \\   .       .'_....__    __..-\"' _.-'/\n");
                Console.SetCursorPosition(x, y + 15); Console.Write("    \\                    \\   \\      ){\"       `'\"\"  __.-\"){ |,\"){\"`.\n");
                Console.SetCursorPosition(x, y + 16); Console.Write("     \\                    \\   \\ .,\"--`.       _..-\",'   | |.\"   |\n");
                Console.SetCursorPosition(x, y + 17); Console.Write("      `._                  \\    j      `\"'\"\"){'  ,'      |,'     |\n");
                Console.SetCursorPosition(x, y + 18); Console.Write("         `.                 .   /           |_,'      ,-'       |\n");
                Console.SetCursorPosition(x, y + 19); Console.Write("      \\`._ `.                `\"'            '       ,'          |\n");
                Console.SetCursorPosition(x, y + 20); Console.Write("       .  `-.){._                           j       /          _.'\n");
                Console.SetCursorPosition(x, y + 21); Console.Write("        `.     .`.._                       |      ){.......--\"\" '\n");
                Console.SetCursorPosition(x, y + 22); Console.Write("          `. '`   `.`-._                  .      .'           /\n");
                Console.SetCursorPosition(x, y + 23); Console.Write("            `){      `                    ,       \"-..._____..'\n");
                Console.SetCursorPosition(x, y + 24); Console.Write("        `\"\"\"-.--.....__                .'         _.' /  /\n");
                Console.SetCursorPosition(x, y + 25); Console.Write("        _.`--         .`,           _,'----....--'   /  /\n");
                Console.SetCursorPosition(x, y + 26); Console.Write("       \"---..,.  __,--`-........,.-\"                /  /\n");
                Console.SetCursorPosition(x, y + 27); Console.Write("            /..-\"_..---\"'   _.-'                   /  j\n");
                Console.SetCursorPosition(x, y + 28); Console.Write("               --.,..    _,'                      /   |\n");
                Console.SetCursorPosition(x, y + 29); Console.Write("                 .','_,-'                         '--\"\n");
                Console.SetCursorPosition(x, y + 30); Console.Write("                 `\"-' \n");
            }

            else if (pokenumber == 84)
            {
                Console.SetCursorPosition(x, y); Console.Write("                                  _.---.._\n");
                Console.SetCursorPosition(x, y + 1); Console.Write("                                ,'       ,.\n");
                Console.SetCursorPosition(x, y + 2); Console.Write("                               ){    _    '_|\n");
                Console.SetCursorPosition(x, y + 3); Console.Write("             _,-\"'--._         ){  ){'|\\      ){\n");
                Console.SetCursorPosition(x, y + 4); Console.Write("           .'         `.       |  `--'  .\"\".;\n");
                Console.SetCursorPosition(x, y + 5); Console.Write("           |     __     .      `.       `. '.\n");
                Console.SetCursorPosition(x, y + 6); Console.Write("           |    ){_'|    ){        `.    _.'`. `.\n");
                Console.SetCursorPosition(x, y + 7); Console.Write("           ,\"'. `--'    .          |\"''     `. '.\n");
                Console.SetCursorPosition(x, y + 8); Console.Write("          '  ,'        /           | |        `. `._\n");
                Console.SetCursorPosition(x, y + 9); Console.Write("        .' ,'`.   __,-\"            | |          `.  `.\n");
                Console.SetCursorPosition(x, y + 10); Console.Write("      .' .'    `|\" |              j .             `.  \\\n");
                Console.SetCursorPosition(x, y + 11); Console.Write("    ,' .'       |  | _   ._      .  '               `.'\n");
                Console.SetCursorPosition(x, y + 12); Console.Write("  ,' ,'         '  |' `-'  `..\"',  j\n");
                Console.SetCursorPosition(x, y + 13); Console.Write(".' .'         .\"'  '          ,'  .'\n");
                Console.SetCursorPosition(x, y + 14); Console.Write("`-'         .'   `  `.      .\"  ,'  \\\n");
                Console.SetCursorPosition(x, y + 15); Console.Write("           <      `   \\      `-'     .\n");
                Console.SetCursorPosition(x, y + 16); Console.Write("            ){      `  .'             ,\n");
                Console.SetCursorPosition(x, y + 17); Console.Write("           j        `\"         .-   ){\n");
                Console.SetCursorPosition(x, y + 18); Console.Write("           ){                  .  \"   `\n");
                Console.SetCursorPosition(x, y + 19); Console.Write("           |               .  `       '\n");
                Console.SetCursorPosition(x, y + 20); Console.Write("          `.                         7\n");
                Console.SetCursorPosition(x, y + 21); Console.Write("           ,                        '\n");
                Console.SetCursorPosition(x, y + 22); Console.Write("            '.                    .'\n");
                Console.SetCursorPosition(x, y + 23); Console.Write("              ,-.               ,'\n");
                Console.SetCursorPosition(x, y + 24); Console.Write("                 '..        _.-){\n");
                Console.SetCursorPosition(x, y + 25); Console.Write("                    `|\".-.-' | |\n");
                Console.SetCursorPosition(x, y + 26); Console.Write("                     | |     | |\n");
                Console.SetCursorPosition(x, y + 27); Console.Write("                     | |     | |\n");
                Console.SetCursorPosition(x, y + 28); Console.Write("                     ' .     ' '\n");
                Console.SetCursorPosition(x, y + 29); Console.Write("                    . .       , .\n");
                Console.SetCursorPosition(x, y + 30); Console.Write("                      |       | |\n");
                Console.SetCursorPosition(x, y + 31); Console.Write("                   ){  '       | |\n");
                Console.SetCursorPosition(x, y + 32); Console.Write("          ,-\"`----\"'  .___    | |\n");
                Console.SetCursorPosition(x, y + 33); Console.Write("         '-'..--\",    ___){_`.\"'  -..____\n");
                Console.SetCursorPosition(x, y + 34); Console.Write("             _.-'_,.  ._\\_,.      _____){_\\\n");
                Console.SetCursorPosition(x, y + 35); Console.Write("           ,\"  ,'   ){ `    / ,-.  \\\n");
                Console.SetCursorPosition(x, y + 36); Console.Write("          ,'.,'     |  ){ ,' /   '  \\\n");
                Console.SetCursorPosition(x, y + 37); Console.Write("         '.-\"       `.\"\"){ ,'     `  `.\n");
                Console.SetCursorPosition(x, y + 38); Console.Write("                      '/`.        `.\"|\n");
                Console.SetCursorPosition(x, y + 39); Console.Write("                       .'           \\' \n");
            }

            else if (pokenumber == 85)
            {
                Console.SetCursorPosition(x, y); Console.Write("                            .\n");
                Console.SetCursorPosition(x, y + 1); Console.Write("                          .'/   .\n");
                Console.SetCursorPosition(x, y + 2); Console.Write("                        .\" / ,\".'    _.--){'`-......___\n");
                Console.SetCursorPosition(x, y + 3); Console.Write("                     , / ,-\"_,' ___.\"   ,.`-.....-\"\"\n");
                Console.SetCursorPosition(x, y + 4); Console.Write("                   // //_.-'   /.._\"\"\". |_'  ){ `-...\n");
                Console.SetCursorPosition(x, y + 5); Console.Write("                 ,/.-'`'  `.  '  '._..-.     '\n");
                Console.SetCursorPosition(x, y + 6); Console.Write("               ..','   _,   ){      `.,'    .'\n");
                Console.SetCursorPosition(x, y + 7); Console.Write("             .'/-.){ |,'|_   ){       /\\__ ,'\n");
                Console.SetCursorPosition(x, y + 8); Console.Write("           ,'_,   _'_ \"     ;       j,| |\"`--,\\_\n");
                Console.SetCursorPosition(x, y + 9); Console.Write("          ){_`.'_,\"_,+\\   ,^.`.     '/ | |      '.\n");
                Console.SetCursorPosition(x, y + 10); Console.Write(" ,.------\"...,\".-\" '/`\"'`   `.`.  ,'  ` l       `.    _.---._,.-..\n");
                Console.SetCursorPosition(x, y + 11); Console.Write("'-...-\"' .\",.____./`.\"-._     `.`...   `_\\       '_.-'_,.-'       \\\n");
                Console.SetCursorPosition(x, y + 12); Console.Write("       .','      ){/  `-._`\"---..`.._|            ){ ,-\" __..--\"\"'`.-'\n");
                Console.SetCursorPosition(x, y + 13); Console.Write("      +\"'        /       `\"'\"\"----.              ;,.-\"'          _|\n");
                Console.SetCursorPosition(x, y + 14); Console.Write("                /                 ){_     '.   _;\"'+.,--\"'\"''\"'\"\"\"\n");
                Console.SetCursorPosition(x, y + 15); Console.Write("                                  ' `-){.,' `'\"     /-..\n");
                Console.SetCursorPosition(x, y + 16); Console.Write("                                      |     .-----'--..`.\n");
                Console.SetCursorPosition(x, y + 17); Console.Write("                                      ;___,'           `.`.\n");
                Console.SetCursorPosition(x, y + 18); Console.Write("                  _.,....---------...' ,'                `.`.\n");
                Console.SetCursorPosition(x, y + 19); Console.Write("            _.--\"',     ____,.....----\"                    `.`-._     ,\n");
                Console.SetCursorPosition(x, y + 20); Console.Write("           ){-'.,-' .-._'.                                    `._ `----')\n");
                Console.SetCursorPosition(x, y + 21); Console.Write("          '._\".  .'    \"'                                       `. `.__\n");
                Console.SetCursorPosition(x, y + 22); Console.Write("         `' ',.-'                                                `.-...' \n");
            }

            else if (pokenumber == 86)
            {
                Console.SetCursorPosition(x, y); Console.Write("                            _,.--\"\"\"'--._\n");
                Console.SetCursorPosition(x, y + 1); Console.Write("                          ,\"             `.         _,.--'\"\"\"\"--.._\n");
                Console.SetCursorPosition(x, y + 2); Console.Write("                         /                 `.     ,\"               `.\n");
                Console.SetCursorPosition(x, y + 3); Console.Write("                        |  ,                 \\   '                   `.\n");
                Console.SetCursorPosition(x, y + 4); Console.Write("                        '.'                   \\ /                -..   .\n");
                Console.SetCursorPosition(x, y + 5); Console.Write("                         j                     '                    \\  |\n");
                Console.SetCursorPosition(x, y + 6); Console.Write("                         |                                    .._    . |\n");
                Console.SetCursorPosition(x, y + 7); Console.Write("                         .    .       _...         _,..._        `.  ){'\n");
                Console.SetCursorPosition(x, y + 8); Console.Write("                          `-./      ,'    `.      /      \"`.      |  ;\n");
                Console.SetCursorPosition(x, y + 9); Console.Write("                             '.   ,'       |     (          \\     .-'\n");
                Console.SetCursorPosition(x, y + 10); Console.Write("                               `\"'         |      \\          `-..'\n");
                Console.SetCursorPosition(x, y + 11); Console.Write("                                          /        \\\n");
                Console.SetCursorPosition(x, y + 12); Console.Write("                                        ,'          \\\n");
                Console.SetCursorPosition(x, y + 13); Console.Write("                                     _,'             `.\n");
                Console.SetCursorPosition(x, y + 14); Console.Write("                                 _,-'                  \\\n");
                Console.SetCursorPosition(x, y + 15); Console.Write("                               ,'                       \\\n");
                Console.SetCursorPosition(x, y + 16); Console.Write("                              /  /\\                      \\\n");
                Console.SetCursorPosition(x, y + 17); Console.Write("                             /  /  \\                      \\\n");
                Console.SetCursorPosition(x, y + 18); Console.Write("                            /  /    \\                      l\n");
                Console.SetCursorPosition(x, y + 19); Console.Write("                         _,.-\"/      '--._                 |\n");
                Console.SetCursorPosition(x, y + 20); Console.Write("                       ,'      `.  '      `.               |\n");
                Console.SetCursorPosition(x, y + 21); Console.Write("                     ,' _..          _      `.             |\n");
                Console.SetCursorPosition(x, y + 22); Console.Write("                    ,   _  `       ,' `.      \\            |\n");
                Console.SetCursorPosition(x, y + 23); Console.Write("                   .  .\".`          ...        \\           '\n");
                Console.SetCursorPosition(x, y + 24); Console.Write("  _.--\"\"`--....--\"'|  |`' |       .(_) |        .         /\n");
                Console.SetCursorPosition(x, y + 25); Console.Write(",'  _              |  `../        `.__.'        |        /\n");
                Console.SetCursorPosition(x, y + 26); Console.Write("| ,'              ,'-\"'--._,...  ______         |    _  /\n");
                Console.SetCursorPosition(x, y + 27); Console.Write("|/  _.           .  .      \\_,'\"'      `-.      '     `'..__,...----._\n");
                Console.SetCursorPosition(x, y + 28); Console.Write("' ,'             | | \\               ,'|  \\    /                      `\n");
                Console.SetCursorPosition(x, y + 29); Console.Write(" `|          _,-\"'.|  \\ .---,-._    /  |   | .' __                \"\"`-.\\\n");
                Console.SetCursorPosition(x, y + 30); Console.Write("  `.     _.-'      |  .){   j    `-.j   |  /.'--'  `.           .       |\n");
                Console.SetCursorPosition(x, y + 31); Console.Write("    `'\"\"'           `-''   '     ,'|   | ,'         `.          \\      |\n");
                Console.SetCursorPosition(x, y + 32); Console.Write("                        `-......'--...`-'             \\          .    ,'\n");
                Console.SetCursorPosition(x, y + 33); Console.Write("                                                       `-._      |_,.'\n");
                Console.SetCursorPosition(x, y + 34); Console.Write("                                                           `\"---\"' \n");
            }

            else if (pokenumber == 87)
            {
                Console.SetCursorPosition(x, y); Console.Write("             /\\\n");
                Console.SetCursorPosition(x, y + 1); Console.Write("        _.--'  `\"-.\n");
                Console.SetCursorPosition(x, y + 2); Console.Write("       ' ,.        `\n");
                Console.SetCursorPosition(x, y + 3); Console.Write("     ,' '_.'        \\\n");
                Console.SetCursorPosition(x, y + 4); Console.Write("    |                .\n");
                Console.SetCursorPosition(x, y + 5); Console.Write("    \"..+--.,-        ){\n");
                Console.SetCursorPosition(x, y + 6); Console.Write("       ||'           '\n");
                Console.SetCursorPosition(x, y + 7); Console.Write("       `._            `.\n");
                Console.SetCursorPosition(x, y + 8); Console.Write("          |             `._\n");
                Console.SetCursorPosition(x, y + 9); Console.Write("          |                `.._\n");
                Console.SetCursorPosition(x, y + 10); Console.Write("          |  .                 `\"--.._\n");
                Console.SetCursorPosition(x, y + 11); Console.Write("          | /   . .                   `-._\n");
                Console.SetCursorPosition(x, y + 12); Console.Write("          `/    |  .                      `.\n");
                Console.SetCursorPosition(x, y + 13); Console.Write("          /    j   |                        `.\n");
                Console.SetCursorPosition(x, y + 14); Console.Write("        ,'    '|   |                          \\\n");
                Console.SetCursorPosition(x, y + 15); Console.Write("      ,' .\"  / |   |                           \\\n");
                Console.SetCursorPosition(x, y + 16); Console.Write("    .' ,'  ,'  '   |                            \\\n");
                Console.SetCursorPosition(x, y + 17); Console.Write("   /          '    ._                            .\n");
                Console.SetCursorPosition(x, y + 18); Console.Write("   `\"\"-.          /  `-._                         .\n");
                Console.SetCursorPosition(x, y + 19); Console.Write("        `\"'-....-'       `\"--...__                |\n");
                Console.SetCursorPosition(x, y + 20); Console.Write("                                  `\"-.._          |\n");
                Console.SetCursorPosition(x, y + 21); Console.Write("                                        `.        |\n");
                Console.SetCursorPosition(x, y + 22); Console.Write("                                          `.      '\n");
                Console.SetCursorPosition(x, y + 23); Console.Write("     ,-._                                   .    .\n");
                Console.SetCursorPosition(x, y + 24); Console.Write("    /    `-._                               |    '\n");
                Console.SetCursorPosition(x, y + 25); Console.Write("   j         `-._                           |   /\n");
                Console.SetCursorPosition(x, y + 26); Console.Write("   |    ___      `-.                       ,'  /\n");
                Console.SetCursorPosition(x, y + 27); Console.Write(" ,'        `\"--..__ `-._                _,'  ,'\n");
                Console.SetCursorPosition(x, y + 28); Console.Write("|                  `\"--.``---........--'    /\n");
                Console.SetCursorPosition(x, y + 29); Console.Write("`                               _..-      ,'\n");
                Console.SetCursorPosition(x, y + 30); Console.Write(" `.                    __...--\"' _,'    .'\n");
                Console.SetCursorPosition(x, y + 31); Console.Write("  |     '\"\"'\"-----\"'`\"\"      _.-'    _,'\n");
                Console.SetCursorPosition(x, y + 32); Console.Write(" /                    __,.-\"'  _. _,'\n");
                Console.SetCursorPosition(x, y + 33); Console.Write(" `.    _______....--\"'      _,'_.'\n");
                Console.SetCursorPosition(x, y + 34); Console.Write("   `.                   _,.'_.'\n");
                Console.SetCursorPosition(x, y + 35); Console.Write("    |           ___,..-'_,-'\n");
                Console.SetCursorPosition(x, y + 36); Console.Write("    `._          __..-\"'\n");
                Console.SetCursorPosition(x, y + 37); Console.Write("       \"'`._...-\" \n");
            }

            else if (pokenumber == 88)
            {
                Console.SetCursorPosition(x, y); Console.Write("                                        _.---.\n");
                Console.SetCursorPosition(x, y + 1); Console.Write("              __             _____  _.-'      |\n");
                Console.SetCursorPosition(x, y + 2); Console.Write("    .\"\"\"--._,'  \\          .\"     \"\"          |\n");
                Console.SetCursorPosition(x, y + 3); Console.Write("    '.    `.`._ /          |                 / `.\n");
                Console.SetCursorPosition(x, y + 4); Console.Write(" .---'      `._|  _,....._  `.___          .`   /\n");
                Console.SetCursorPosition(x, y + 5); Console.Write("|     ...._   .`\"'    __  `\"-. ` `.     _.'___,'\n");
                Console.SetCursorPosition(x, y + 6); Console.Write("`._      `.`.'\\     ,\"  `.    `.)`.`-\"\"'_.\" .'\n");
                Console.SetCursorPosition(x, y + 7); Console.Write("   |.____.,'. |   _/ .    ;__  ,   ``\"\"\"     `.\n");
                Console.SetCursorPosition(x, y + 8); Console.Write("   |,-.  /    ' .\" |     ,__ `.'           . ,'\n");
                Console.SetCursorPosition(x, y + 9); Console.Write("   '   `j`---'.',-\"`----'   `\"| \\ __       | |\n");
                Console.SetCursorPosition(x, y + 10); Console.Write("    `.  |   `'\"'            .  \\ `._\"..__.'  .\n");
                Console.SetCursorPosition(x, y + 11); Console.Write("     |  '                  /){  |\"`--',..\"     |\n");
                Console.SetCursorPosition(x, y + 12); Console.Write("     |`. `.___...----.....' '  `    |  |     .'\n");
                Console.SetCursorPosition(x, y + 13); Console.Write("     |-.`.__,--|          |\"   ){    |  |    /(\n");
                Console.SetCursorPosition(x, y + 14); Console.Write("    .   `-.___.|   ,--.,-\"|    ``.  |  |   . .'\n");
                Console.SetCursorPosition(x, y + 15); Console.Write("    `          |  /       |   . `.`.`--' ,'.'  `-\n");
                Console.SetCursorPosition(x, y + 16); Console.Write("     '.        | /        |   |   `.`...-,'      |\n");
                Console.SetCursorPosition(x, y + 17); Console.Write("      '`-._  _/|j        /  ,.'     '---\"   _..-\"|\n");
                Console.SetCursorPosition(x, y + 18); Console.Write("       `._.`\" |||       / .','            .' _..'|\n");
                Console.SetCursorPosition(x, y + 19); Console.Write("        |  `..||\\     ,'.\".-     ``.    .' .'    `.\n");
                Console.SetCursorPosition(x, y + 20); Console.Write("        |     \\`\"-..-'  ){|         \\`\"\"' .'     .'.`.\n");
                Console.SetCursorPosition(x, y + 21); Console.Write("       ,'      `-----.-\".'   '`._   `\"--'     .','   \\\n");
                Console.SetCursorPosition(x, y + 22); Console.Write("      .               `\"      `..-'     .\"\"`-','.'   |\n");
                Console.SetCursorPosition(x, y + 23); Console.Write("      |.__..        ___       .        /.'\"\"\" .'     '.\n");
                Console.SetCursorPosition(x, y + 24); Console.Write("      '___.--..__.-\"_..`.    ,..___  ,'  `\"'\"'       _.'.\n");
                Console.SetCursorPosition(x, y + 25); Console.Write("        '---. `.__,\"`._`-._,' `----`'              .'  ,-'\\\n");
                Console.SetCursorPosition(x, y + 26); Console.Write("     _,'  ___`--\"                      ,-'\"`..___.' .-'   |\n");
                Console.SetCursorPosition(x, y + 27); Console.Write("   ,\"   ,..-.`\"._  ___..._    .\"\"..__,'.'\"\"`-......'       `._\n");
                Console.SetCursorPosition(x, y + 28); Console.Write("  /    _____ `.__`\" _.-\"'       `-..--\"       _...._  _....__ `.\n");
                Console.SetCursorPosition(x, y + 29); Console.Write("  | .\"'----.`._  `\"\"       ,.\"\"--._         _.....,_`\"_.----...'\n");
                Console.SetCursorPosition(x, y + 30); Console.Write("  `------'\"\"`._`.      _,.--\"''\"\"--......-\"'        \"\"\n");
                Console.SetCursorPosition(x, y + 31); Console.Write("               `\"-----\" \n");
            }

            else if (pokenumber == 89)
            {
                Console.SetCursorPosition(x, y); Console.Write("                             _,..-------.._\n");
                Console.SetCursorPosition(x, y + 1); Console.Write("                         _,-'              `-._\n");
                Console.SetCursorPosition(x, y + 2); Console.Write("                       ,\"               .---.._`.\n");
                Console.SetCursorPosition(x, y + 3); Console.Write("                      /----.       _._,.._\"\"\"){\"`\"`.\n");
                Console.SetCursorPosition(x, y + 4); Console.Write("                     /`--\"\"     _.'.'  / .`-.'-\"'\"`\\_\n");
                Console.SetCursorPosition(x, y + 5); Console.Write("                    /\"\"-._`----\" .'  .' '   _.`     \\\"-._\n");
                Console.SetCursorPosition(x, y + 6); Console.Write("                   .      `.___.'   / ,' . |   |  ._  . .``-._\n");
                Console.SetCursorPosition(x, y + 7); Console.Write("                 _,' _.            .,' ,\"| |   |   .`.|'.' ,--\".\n");
                Console.SetCursorPosition(x, y + 8); Console.Write("               ,'    ||`._..____..\"' ,'--'.|   |    `.|'  .'\"-._|\n");
                Console.SetCursorPosition(x, y + 9); Console.Write("              /___...'|   ){._     _,'      `'-. |     |  _,.._  |.\n");
                Console.SetCursorPosition(x, y + 10); Console.Write("             |,--.._|j  ,'   `'\"\"'         ||  `|     '.'_..._` | )\n");
                Console.SetCursorPosition(x, y + 11); Console.Write("            ,'      /  /                   ||   |    /',\"     ` '/|\n");
                Console.SetCursorPosition(x, y + 12); Console.Write("         ,-'   .,-./  /      _,..----..___,'){`_'    /.'        `.' ._\n");
                Console.SetCursorPosition(x, y + 13); Console.Write("        /  __.._ `-\\.'-----\"'  _,...__      '\"     /.\"\"-..-\"\"\"-. |_  `._\n");
                Console.SetCursorPosition(x, y + 14); Console.Write("   __..){--\"_.--.`.  `---....-`\"..__.\" `-...      _.\"'\"''`---..__`._`\"\"__\\\n");
                Console.SetCursorPosition(x, y + 15); Console.Write(".-'  `\"\"''\"       `..--\"\"-.   _.--.._   _.-\"\"-_,'              _.._`-._  '_\n");
                Console.SetCursorPosition(x, y + 16); Console.Write("|\"\"-.    __.-----._ '....`._-\" _,-\"'`-..._,..`__...\"\"\"-.__  _.'_.._`-..){'\"-)\n");
                Console.SetCursorPosition(x, y + 17); Console.Write(" `\"\"`..-\"_...----..___)     `\"\"              `....------._\"\",-'    `..-'`\"\"\n");
                Console.SetCursorPosition(x, y + 18); Console.Write("      `\"                                                  `\" \n");
            }

            else if (pokenumber == 90)
            {
                Console.SetCursorPosition(x, y); Console.Write("               _,.-'\"\"\"''--..._\n");
                Console.SetCursorPosition(x, y + 1); Console.Write("           _,-'               `.\"-.._\n");
                Console.SetCursorPosition(x, y + 2); Console.Write("         .\"     _..-'\"'\"\"--._   `.   `-._\n");
                Console.SetCursorPosition(x, y + 3); Console.Write("       ,'   _.-'             `._  `.     `-._\n");
                Console.SetCursorPosition(x, y + 4); Console.Write("      /   .`                    `.  \\        `.\n");
                Console.SetCursorPosition(x, y + 5); Console.Write("     /  .'                        `. `.        `.       _,..\n");
                Console.SetCursorPosition(x, y + 6); Console.Write("   .'  /                            `. `.        `...-\"'    \\\n");
                Console.SetCursorPosition(x, y + 7); Console.Write("  /   /                               _. `.               ,-'\n");
                Console.SetCursorPosition(x, y + 8); Console.Write(" j   /                   ,-\"\"'`.   ,\"'  `. `.           .'\n");
                Console.SetCursorPosition(x, y + 9); Console.Write(" |  .     _..------...__'  \"   |  |   \"   |  `.       ,'\n");
                Console.SetCursorPosition(x, y + 10); Console.Write(" `._...-'\"_,.-\"'        `..__,\"    `._ _,.'`.  `    .'\\\n");
                Console.SetCursorPosition(x, y + 11); Console.Write("   ,\"  _,'             __..-\"\"'`\"'.  ,'    `..  `.     .\n");
                Console.SetCursorPosition(x, y + 12); Console.Write(" ,'  .\"        _..-''\"\"            \\/        `.   \\    '\n");
                Console.SetCursorPosition(x, y + 13); Console.Write("){         _..+'----\"'               `.         `.  \\    \\\n");
                Console.SetCursorPosition(x, y + 14); Console.Write("){      _,'    `-._                               \\  \\    \\\n");
                Console.SetCursorPosition(x, y + 15); Console.Write(" `...-'           `.                              \\  \\\n");
                Console.SetCursorPosition(x, y + 16); Console.Write("                    \\                              \\  \\   .\n");
                Console.SetCursorPosition(x, y + 17); Console.Write("                     \\                              .     '\n");
                Console.SetCursorPosition(x, y + 18); Console.Write("                    / \\                    .        '  `  ){\n");
                Console.SetCursorPosition(x, y + 19); Console.Write("                  ,'   \\               .    \\        \\  \\  `-,._\n");
                Console.SetCursorPosition(x, y + 20); Console.Write("                ,'    __\\               \\    \\        \\  \\  /._ `.\n");
                Console.SetCursorPosition(x, y + 21); Console.Write("               .  _.\"'   \\               \\    \\        `._'/._ \"-.\\\n");
                Console.SetCursorPosition(x, y + 22); Console.Write("                `\"        `.              `._.'        ,'.-.. `-._ `\n");
                Console.SetCursorPosition(x, y + 23); Console.Write("                            `-._                    _.'.  `,\"`-._ `.`\n");
                Console.SetCursorPosition(x, y + 24); Console.Write("                                `--...__     ___..-\"  \\ `. '     `._`|\n");
                Console.SetCursorPosition(x, y + 25); Console.Write("                                        `\"'\"\" \\   ){    \\  `.`.      \"\n");
                Console.SetCursorPosition(x, y + 26); Console.Write("                                               \\  ){     `   `.`.\n");
                Console.SetCursorPosition(x, y + 27); Console.Write("                                                '\"){      `.__,.'\n");
                Console.SetCursorPosition(x, y + 28); Console.Write("                                                  `-.....' \n");
            }

            else if (pokenumber == 91)
            {
                Console.SetCursorPosition(x, y); Console.Write("                                                          _\n");
                Console.SetCursorPosition(x, y + 1); Console.Write("                                                       ,\"  '\n");
                Console.SetCursorPosition(x, y + 2); Console.Write("                                                     ,'   /\n");
                Console.SetCursorPosition(x, y + 3); Console.Write("                                                    /    /\n");
                Console.SetCursorPosition(x, y + 4); Console.Write("                                                  ,'    /\n");
                Console.SetCursorPosition(x, y + 5); Console.Write("                                                ,'     .\n");
                Console.SetCursorPosition(x, y + 6); Console.Write("                                     _...      /       '\n");
                Console.SetCursorPosition(x, y + 7); Console.Write("                                  ,'\"'\"\".`.   |_..    /\n");
                Console.SetCursorPosition(x, y + 8); Console.Write("                        ,-\"'\".   /       \\\\  ,'   `.\"'\n");
                Console.SetCursorPosition(x, y + 9); Console.Write("                       .\"\"\"'. |,'         .`\".    /.\n");
                Console.SetCursorPosition(x, y + 10); Console.Write("                      /     | |           `...`\".',___\n");
                Console.SetCursorPosition(x, y + 11); Console.Write("                     /      | `.            _.-' /.___`\".\n");
                Console.SetCursorPosition(x, y + 12); Console.Write("                   .'       `-._`-.._____,-'    /     \\ |\n");
                Console.SetCursorPosition(x, y + 13); Console.Write("             ,..    \\           `. . ,'.'      /       .|\n");
                Console.SetCursorPosition(x, y + 14); Console.Write("           .'   `.   \\   /        .||.'       '.`.._   ||--.\n");
                Console.SetCursorPosition(x, y + 15); Console.Write("           \\      `...`-'         ||||      .'  `-.._`.||_ |\n");
                Console.SetCursorPosition(x, y + 16); Console.Write("       _,.--`\"'-..\"'              ||``. ,-\"\"\"\"`'\"--._`\"-._`-.\n");
                Console.SetCursorPosition(x, y + 17); Console.Write("  _,-\"'           `.              ' .\\`'             `.   `. \\......\n");
                Console.SetCursorPosition(x, y + 18); Console.Write(",'                 '               || .|              |`.   \\ \\   .'\n");
                Console.SetCursorPosition(x, y + 19); Console.Write("`.._____________ ,'\"`+-\"\"'''       || ||              |  \\  `. .-'\n");
                Console.SetCursorPosition(x, y + 20); Console.Write("               |    .    _..-'    j | ||              |  |    ||\n");
                Console.SetCursorPosition(x, y + 21); Console.Write("               |    |   .         |. j |              |_'|.   ||\n");
                Console.SetCursorPosition(x, y + 22); Console.Write("               |    '    `-.._    || | |  .........      | |  ||\n");
                Console.SetCursorPosition(x, y + 23); Console.Write("               |     `._          || ' '   \\  __.-\"  _,' '.. , '\n");
                Console.SetCursorPosition(x, y + 24); Console.Write("               `._      `..       ' . `..   \"\"_,..-\"'  .'  \\/.'\n");
                Console.SetCursorPosition(x, y + 25); Console.Write("                  ``.    /         \\`.  ``-._`-....\"_,'   .,'|`._\n");
                Console.SetCursorPosition(x, y + 26); Console.Write("                     `..'           `.`._  `.`--\"'      .,'\\ ){   `.\n");
                Console.SetCursorPosition(x, y + 27); Console.Write("                      /     _.-   .    `-.){-._ ` '._    ){   . `--..'\n");
                Console.SetCursorPosition(x, y + 28); Console.Write("                    ,'  _,-' `.   ){    __  `-.` `.._`. /,  ,','\n");
                Console.SetCursorPosition(x, y + 29); Console.Write("                  .'  .'       `-. `-'\"       \\`.   ` ',  ','\n");
                Console.SetCursorPosition(x, y + 30); Console.Write("                  `--' `--..     | `-._____   `._){---.| .'/\n");
                Console.SetCursorPosition(x, y + 31); Console.Write("                            \\    |     .'  \"-.____`\". |-\"'\n");
                Console.SetCursorPosition(x, y + 32); Console.Write("                             `.__|    /           `\"'\"\n");
                Console.SetCursorPosition(x, y + 33); Console.Write("                                 |   /\n");
                Console.SetCursorPosition(x, y + 34); Console.Write("                                 '._' \n");
            }

            else if (pokenumber == 92)
            {
                Console.SetCursorPosition(x, y); Console.Write("                             _\n");
                Console.SetCursorPosition(x, y + 1); Console.Write("                          .\"' `..._\n");
                Console.SetCursorPosition(x, y + 2); Console.Write("                         '         `.\n");
                Console.SetCursorPosition(x, y + 3); Console.Write("                       .'      ___..'\n");
                Console.SetCursorPosition(x, y + 4); Console.Write("                 _   .\"       '   .__,-.,\"\", ,----.\n");
                Console.SetCursorPosition(x, y + 5); Console.Write("      ,.-\"\"''-..\" ){  ){        `--'        ' ){      ){\n");
                Console.SetCursorPosition(x, y + 6); Console.Write("    .'            ){_,'                    `._`\"--. ;\n");
                Console.SetCursorPosition(x, y + 7); Console.Write("    ){              _,.--'\"'\"\"`--._           `.  `\"\n");
                Console.SetCursorPosition(x, y + 8); Console.Write("   j             ,'               `-.      ,._.'  ,\"\".\n");
                Console.SetCursorPosition(x, y + 9); Console.Write("   ){           ,'                   ,-.   .   __  `..'\n");
                Console.SetCursorPosition(x, y + 10); Console.Write("   `--.    .'.'                   ,'   `. ){_,\"  `.\n");
                Console.SetCursorPosition(x, y + 11); Console.Write(" ,.   ;   .   \\                 ,'      |         `.\n");
                Console.SetCursorPosition(x, y + 12); Console.Write("' ){  ){    |    `.             ,'        |\\         `.  _\n");
                Console.SetCursorPosition(x, y + 13); Console.Write(" `.   ._  |      \\         _.'          | .      ___ `\" ){\n");
                Console.SetCursorPosition(x, y + 14); Console.Write("        ){ '     . \\      ,'  .          ' |     ){   `...'\n");
                Console.SetCursorPosition(x, y + 15); Console.Write("       ,'  \\       `.   .             ,'  |     '  __\n");
                Console.SetCursorPosition(x, y + 16); Console.Write("      .    `.       |    \\          .'    '    .  (  `.\n");
                Console.SetCursorPosition(x, y + 17); Console.Write("    .'      \\`.___,'      `-.____.-'     '     ){   `-.'\n");
                Console.SetCursorPosition(x, y + 18); Console.Write("     .   ,\". \\ ..___              _     /      ){    .\n");
                Console.SetCursorPosition(x, y + 19); Console.Write("     ){   . ){  \\|/\\  `\"'--------+\"|,'  ,'       `-..' ){\n");
                Console.SetCursorPosition(x, y + 20); Console.Write("      `-\" .'   `){ `\"-.._______,.\\|  .'               '\n");
                Console.SetCursorPosition(x, y + 21); Console.Write("          `--. _ `._             _,'        ,\"\"-.__,'\n");
                Console.SetCursorPosition(x, y + 22); Console.Write("              \" ){   `\"--.....--\"'     __   .\n");
                Console.SetCursorPosition(x, y + 23); Console.Write("              ,-'                 ,.-\"  `-'\n");
                Console.SetCursorPosition(x, y + 24); Console.Write("             ){   ,..             .    ,\"\".\n");
                Console.SetCursorPosition(x, y + 25); Console.Write("            .'   .  ){   __..._   `\"-. ){   ){\n");
                Console.SetCursorPosition(x, y + 26); Console.Write("            `.._  ){ ' ,'      `\"--..' `--\"\n");
                Console.SetCursorPosition(x, y + 27); Console.Write("                `-' `\" \n");
            }

            else if (pokenumber == 93)
            {
                Console.SetCursorPosition(x, y); Console.Write("               -._                                   _.\n");
                Console.SetCursorPosition(x, y + 1); Console.Write("                \\ `-.._                           _,' |\n");
                Console.SetCursorPosition(x, y + 2); Console.Write("                 \\     `-._    _,.--------.._  _.\"    '\n");
                Console.SetCursorPosition(x, y + 3); Console.Write("                  \\        `--'              ``.     /\n");
                Console.SetCursorPosition(x, y + 4); Console.Write("                   \\                                j    __\n");
                Console.SetCursorPosition(x, y + 5); Console.Write("__         __       \\                               |.-\"' /\n");
                Console.SetCursorPosition(x, y + 6); Console.Write(" `.`-.`-.__`.`'\"----\"\\                              |    /\n");
                Console.SetCursorPosition(x, y + 7); Console.Write("    `.       `.       '        ._                       /\n");
                Console.SetCursorPosition(x, y + 8); Console.Write("    `..        \\               | `.               /|   /\n");
                Console.SetCursorPosition(x, y + 9); Console.Write("      `.        `.             |   `._          .' |  /\n");
                Console.SetCursorPosition(x, y + 10); Console.Write("        `.  .-----`            |      `.       /   ' '\"\"''\n");
                Console.SetCursorPosition(x, y + 11); Console.Write("          `. `.            .    ._      `_    /  ,'    .'\n");
                Console.SetCursorPosition(x, y + 12); Console.Write("            `. `.           `._   `'\"\"'\"'     \"\"' ,  ,'\n");
                Console.SetCursorPosition(x, y + 13); Console.Write("              `. `.          `.`.              ,-/ ,'       _..\n");
                Console.SetCursorPosition(x, y + 14); Console.Write("                `. `.          \\|,---..  ,--\"./ / ,--------\".  \\\n");
                Console.SetCursorPosition(x, y + 15); Console.Write("                  `._           `.     `/ , .`.',){           \\  \\\n");
                Console.SetCursorPosition(x, y + 16); Console.Write("                     `._          `..\".,./ ' _.' ){            \\  `.\n");
                Console.SetCursorPosition(x, y + 17); Console.Write("                   ,-'\" `-._              _.\"     .   |.-\"`.   \\  |\n");
                Console.SetCursorPosition(x, y + 18); Console.Write("                  .         `-..........-'        |   `..   \\   |_'\n");
                Console.SetCursorPosition(x, y + 19); Console.Write("                  |           `\".                 `.._   .  '  ,'\n");
                Console.SetCursorPosition(x, y + 20); Console.Write("                  |         |   |                     `\"'    .'\n");
                Console.SetCursorPosition(x, y + 21); Console.Write("                  |   /\\    |'  '\n");
                Console.SetCursorPosition(x, y + 22); Console.Write("                  '  /  \\   ||   .\n");
                Console.SetCursorPosition(x, y + 23); Console.Write("                 '   \\  '   |'   ;\n");
                Console.SetCursorPosition(x, y + 24); Console.Write("                  \\  '  \\   `...'\n");
                Console.SetCursorPosition(x, y + 25); Console.Write("                   `\"\"   `,' \n");
            }

            else if (pokenumber == 94)
            {
                Console.SetCursorPosition(x, y); Console.Write("                 |`._         |\\\n");
                Console.SetCursorPosition(x, y + 1); Console.Write("                 `   `.  .    | `.    |`.\n");
                Console.SetCursorPosition(x, y + 2); Console.Write("                  .    `.|`-. |   `-..'  \\           _,.-'\n");
                Console.SetCursorPosition(x, y + 3); Console.Write("                  '      `-. `.           \\ /|   _,-'   /\n");
                Console.SetCursorPosition(x, y + 4); Console.Write("              .--..'        `._`           ` |.-'      /\n");
                Console.SetCursorPosition(x, y + 5); Console.Write("               \\   |                                  /\n");
                Console.SetCursorPosition(x, y + 6); Console.Write("            ,..'   '                                 /\n");
                Console.SetCursorPosition(x, y + 7); Console.Write("            `.                                      /\n");
                Console.SetCursorPosition(x, y + 8); Console.Write("            _`.---                                 /\n");
                Console.SetCursorPosition(x, y + 9); Console.Write("        _,-'               `.                 ,-  /\"-._\n");
                Console.SetCursorPosition(x, y + 10); Console.Write("      ,\"                   | `.             ,'|   `    `.\n");
                Console.SetCursorPosition(x, y + 11); Console.Write("    .'                     |   `.         .'  |    .     `.\n");
                Console.SetCursorPosition(x, y + 12); Console.Write("  ,'                       '   ()`.     ,'()  '    |       `.\n");
                Console.SetCursorPosition(x, y + 13); Console.Write("'-.                    |`.  `.....-'    -----' _   |         .\n");
                Console.SetCursorPosition(x, y + 14); Console.Write(" / ,   ________..'     '  `-._              _.'/   |         ){\n");
                Console.SetCursorPosition(x, y + 15); Console.Write(" ` '-\"\" _,.--\"'         \\   | `\"+--......-+' //   j `\"--.. , '\n");
                Console.SetCursorPosition(x, y + 16); Console.Write("    `.'\"    .'           `. |   |     |   / //    .       ` '\n");
                Console.SetCursorPosition(x, y + 17); Console.Write("      `.   /               `'   |    j   /,.'     '\n");
                Console.SetCursorPosition(x, y + 18); Console.Write("        \\ /                  `-.|_   |_.-'       /\\\n");
                Console.SetCursorPosition(x, y + 19); Console.Write("         /                        `\"\"          .'  \\\n");
                Console.SetCursorPosition(x, y + 20); Console.Write("        j                                           .\n");
                Console.SetCursorPosition(x, y + 21); Console.Write("        |                                 _,        |\n");
                Console.SetCursorPosition(x, y + 22); Console.Write("        |             ,^._            _.-\"          '\n");
                Console.SetCursorPosition(x, y + 23); Console.Write("        |          _.'    `'\"\"`----`\"'   `._       '\n");
                Console.SetCursorPosition(x, y + 24); Console.Write("        j__     _,'                         `-.'-.\"`\n");
                Console.SetCursorPosition(x, y + 25); Console.Write("          ',-.,' \n");
            }

            else if (pokenumber == 95)
            {
                Console.SetCursorPosition(x, y); Console.Write("                                                       _\n");
                Console.SetCursorPosition(x, y + 1); Console.Write("                                       ___            | |\n");
                Console.SetCursorPosition(x, y + 2); Console.Write("                                   .-\"'   `...._      | |\n");
                Console.SetCursorPosition(x, y + 3); Console.Write("                      _,--\"'-.   ,' .           `.    | |\n");
                Console.SetCursorPosition(x, y + 4); Console.Write("                    .'       ,`,'    \\            `.  | |\n");
                Console.SetCursorPosition(x, y + 5); Console.Write("                  ,'.      .','       \\            | j  |\n");
                Console.SetCursorPosition(x, y + 6); Console.Write("           __,..,'   `----\"  `         \\       _..-+.`  |..\n");
                Console.SetCursorPosition(x, y + 7); Console.Write("        ,'\"     .             '._  ___...-._ ,'     |   |  `--.\n");
                Console.SetCursorPosition(x, y + 8); Console.Write("       /       _|              | `\"        .'       |   |      `.\n");
                Console.SetCursorPosition(x, y + 9); Console.Write("      /`  _.-`'  ._..----\"\"`._ |         ,'         |   |        .\n");
                Console.SetCursorPosition(x, y + 10); Console.Write("     | .-\"         `-._    _,.' `.     .'          j    |         `.\n");
                Console.SetCursorPosition(x, y + 11); Console.Write("  ,-\"\"\"--..._       |  '`\"\"       `-../\\     _,\"''\"|    |.._       ,|\n");
                Console.SetCursorPosition(x, y + 12); Console.Write(" /    '.     `\"----,'                 ` '._,'      |   j    `.   .' |\n");
                Console.SetCursorPosition(x, y + 13); Console.Write("/_.-'\"  `-.___..-.\"                    \\ ,'   \\    |   '    | `.'   '\n");
                Console.SetCursorPosition(x, y + 14); Console.Write("`                |                    _.'          |  |,_   '   `. /\n");
                Console.SetCursorPosition(x, y + 15); Console.Write(" .        _______|                 .-'    |.       `. '           |\n");
                Console.SetCursorPosition(x, y + 16); Console.Write("  `...---\"     .-'               .'       | `.                 ,  '\n");
                Console.SetCursorPosition(x, y + 17); Console.Write("  ,'._     _,-\"                  `        |  ,`.  ,  .    _.-'|    `.\n");
                Console.SetCursorPosition(x, y + 18); Console.Write(" .    `\"\"-'    `.                 \\       `.....`.     .-',   |      .\n");
                Console.SetCursorPosition(x, y + 19); Console.Write(" |             _,|                 ._ --.        |     '\"--...       '\n");
                Console.SetCursorPosition(x, y + 20); Console.Write("  `.--\"`.....-\" ,                    /\".`        |   |        _____,'\n");
                Console.SetCursorPosition(x, y + 21); Console.Write("    .       | .'_                   /   \\        |  j       \"'_,..'\n");
                Console.SetCursorPosition(x, y + 22); Console.Write("     /`-...-+\"   `.                 '   .'.__ -..'  |_,..   ,'  |\n");
                Console.SetCursorPosition(x, y + 23); Console.Write("    '          ____.                 \\  |    \"`-..___,....-.    '\n");
                Console.SetCursorPosition(x, y + 24); Console.Write("     .     _.\"\"'   |                  `. .                 / .-'\n");
                Console.SetCursorPosition(x, y + 25); Console.Write("      `. .'       .._                   \\ \\               / /\n");
                Console.SetCursorPosition(x, y + 26); Console.Write("        `-._   _.'   `.                  \\.--......____ .' /\n");
                Console.SetCursorPosition(x, y + 27); Console.Write("          .'`\"\"    .'  .                  .            '_.'\n");
                Console.SetCursorPosition(x, y + 28); Console.Write("          |       /    |____               `\"._     _,-\"      ,-'\"'\n");
                Console.SetCursorPosition(x, y + 29); Console.Write("           `. _.,'     |    `.                 `--\"'       _.--,.'\n");
                Console.SetCursorPosition(x, y + 30); Console.Write("             `'--.__,.\"       |                          ,' .' |\n");
                Console.SetCursorPosition(x, y + 31); Console.Write("                   |   ,.._   |\"--._                  ,-+-.'  /\n");
                Console.SetCursorPosition(x, y + 32); Console.Write("                   `..'    ``.'   ,.`.     _..__.-\"\"\"-.__.'\\\"'\n");
                Console.SetCursorPosition(x, y + 33); Console.Write("                     `----.,\"    '   .--..'   _..`-../){  _,'\n");
                Console.SetCursorPosition(x, y + 34); Console.Write("                           .    /  .'  _.'\\.-\"  |     '-\"\n");
                Console.SetCursorPosition(x, y + 35); Console.Write("                            \"--+--\"`..'   |.   ,^.__,'\n");
                Console.SetCursorPosition(x, y + 36); Console.Write("                                     `---\"  `-\" \n");
            }

            else if (pokenumber == 96)
            {
                Console.SetCursorPosition(x, y); Console.Write("                        .\"'`-._,........_.------..\n");
                Console.SetCursorPosition(x, y + 1); Console.Write("                       / _.-'          ,' ,---\"\"/\n");
                Console.SetCursorPosition(x, y + 2); Console.Write("                      /.'                /   ,.'\n");
                Console.SetCursorPosition(x, y + 3); Console.Write("                    .'                      `-.\n");
                Console.SetCursorPosition(x, y + 4); Console.Write("                  ,'                           `.\n");
                Console.SetCursorPosition(x, y + 5); Console.Write("                 /          _..                  \\\n");
                Console.SetCursorPosition(x, y + 6); Console.Write("        ______,..         .',\"\"\"\"\\)               `.\n");
                Console.SetCursorPosition(x, y + 7); Console.Write("   .\"\"\"\"        |.-----           -                 \\\n");
                Console.SetCursorPosition(x, y + 8); Console.Write("  /.' .   _     |______                              \\\n");
                Console.SetCursorPosition(x, y + 9); Console.Write(".'/   | ,'      '        _.....-         _,---.       \\\n");
                Console.SetCursorPosition(x, y + 10); Console.Write(" \\  ,\"'/-._      \\----  /-..____.   _,.-\"              .\n");
                Console.SetCursorPosition(x, y + 11); Console.Write("  `.|      `\"-.._ \\____/        ,---..._               '\n");
                Console.SetCursorPosition(x, y + 12); Console.Write("                 `            .' .      `.              \\\n");
                Console.SetCursorPosition(x, y + 13); Console.Write("                  |           |  |  |  |/       ,        .\n");
                Console.SetCursorPosition(x, y + 14); Console.Write("                  |           './|  |`.'.._   .'         |\n");
                Console.SetCursorPosition(x, y + 15); Console.Write("                  |               `.'      `\"\"           |\n");
                Console.SetCursorPosition(x, y + 16); Console.Write("                  |--.      ___       _,...    _.'\"`-...'|\n");
                Console.SetCursorPosition(x, y + 17); Console.Write("                ,/    `---\"'   `-....'     `--\"          |\n");
                Console.SetCursorPosition(x, y + 18); Console.Write("              .'.                         _...           |\n");
                Console.SetCursorPosition(x, y + 19); Console.Write("             /  |                      ,-'               |\n");
                Console.SetCursorPosition(x, y + 20); Console.Write("            /   |                    ,'                 j\n");
                Console.SetCursorPosition(x, y + 21); Console.Write("           .     \\                  /                   |\n");
                Console.SetCursorPosition(x, y + 22); Console.Write("           |      \\                .                    |\n");
                Console.SetCursorPosition(x, y + 23); Console.Write("           '       `               |                    |\n");
                Console.SetCursorPosition(x, y + 24); Console.Write("            `.      `._            '                    '\n");
                Console.SetCursorPosition(x, y + 25); Console.Write("              `.       `._          \\                  /\n");
                Console.SetCursorPosition(x, y + 26); Console.Write("            ,.\".          `.-........'.               /\n");
                Console.SetCursorPosition(x, y + 27); Console.Write("          ,.-'  `.____....-'           `.            '\n");
                Console.SetCursorPosition(x, y + 28); Console.Write("          '...--\"'                       )           `.\n");
                Console.SetCursorPosition(x, y + 29); Console.Write("                                       .',.-,----.    |\n");
                Console.SetCursorPosition(x, y + 30); Console.Write("                                       `.  |      \\_.'\n");
                Console.SetCursorPosition(x, y + 31); Console.Write("                                         `-+----\"\"' \n");
            }

            else if (pokenumber == 97)
            {
                Console.SetCursorPosition(x, y); Console.Write("                  .\\\n");
                Console.SetCursorPosition(x, y + 1); Console.Write("                 .  \\\n");
                Console.SetCursorPosition(x, y + 2); Console.Write("                     \\              _,|\n");
                Console.SetCursorPosition(x, y + 3); Console.Write("                j    _\\____      _.\" ||\n");
                Console.SetCursorPosition(x, y + 4); Console.Write("                |  -'      `\"-.-',---.|_\n");
                Console.SetCursorPosition(x, y + 5); Console.Write("               /                /j      `.\n");
                Console.SetCursorPosition(x, y + 6); Console.Write("              /                . |    |   `.\n");
                Console.SetCursorPosition(x, y + 7); Console.Write("             ,                 | |    |     \\\n");
                Console.SetCursorPosition(x, y + 8); Console.Write("            /|.                ' `    |  / ,'|\n");
                Console.SetCursorPosition(x, y + 9); Console.Write("          ,' |\\`.               `.`.__|_/.',`\n");
                Console.SetCursorPosition(x, y + 10); Console.Write("         ){   | `|      ,.--..     ||\\   '\"   `.\n");
                Console.SetCursorPosition(x, y + 11); Console.Write("        .'   | /      |`'-\"\"'     '| \\         `.\n");
                Console.SetCursorPosition(x, y + 12); Console.Write("        )    `j       `.         / |  \\          .\n");
                Console.SetCursorPosition(x, y + 13); Console.Write("       ,`-'   |       .'        /  | `.\\         |\n");
                Console.SetCursorPosition(x, y + 14); Console.Write("      / |   _ |     ,'       _,'  _|_ | \\        '\n");
                Console.SetCursorPosition(x, y + 15); Console.Write("  _,-'  `. /  \\   ,'......--'   .\" _ `.  `      /\n");
                Console.SetCursorPosition(x, y + 16); Console.Write(".\" ---._ ,'|   --`              | . `. |------\"'\n");
                Console.SetCursorPosition(x, y + 17); Console.Write("|       |  '    .       .       `.`-' .'\n");
                Console.SetCursorPosition(x, y + 18); Console.Write("|       |   `.  |        |      _/){--'\n");
                Console.SetCursorPosition(x, y + 19); Console.Write("|       |    \\`-|        | _..-'  |\n");
                Console.SetCursorPosition(x, y + 20); Console.Write("|       |  _,.\\  `\"--..-\"'`      ,^.\n");
                Console.SetCursorPosition(x, y + 21); Console.Write("|       `.'    `                    `-.\n");
                Console.SetCursorPosition(x, y + 22); Console.Write("`         `\"-.                         `.\n");
                Console.SetCursorPosition(x, y + 23); Console.Write(" \\       .---'                           \\\n");
                Console.SetCursorPosition(x, y + 24); Console.Write("  \\\\\\  . `.         __....._              \\\n");
                Console.SetCursorPosition(x, y + 25); Console.Write("   \\\\\\__\\__'    _,-'        `-.            .\n");
                Console.SetCursorPosition(x, y + 26); Console.Write("   |          ,+             .'`.         .'\n");
                Console.SetCursorPosition(x, y + 27); Console.Write("   '.     _.-'  \\            '            \\\n");
                Console.SetCursorPosition(x, y + 28); Console.Write("  ,-\"`-...     ,'             \\     _ '\"-. `.\n");
                Console.SetCursorPosition(x, y + 29); Console.Write(" / ,'   .-    /                `.    `.   \\.'\n");
                Console.SetCursorPosition(x, y + 30); Console.Write(" \\_|  .'    ,'                   `-...'--\"\n");
                Console.SetCursorPosition(x, y + 31); Console.Write("   `--'---'\" \n");
            }

            else if (pokenumber == 98)
            {
                Console.SetCursorPosition(x, y); Console.Write("            ,-\"'\"'\"--.                       ,-\"\"\"\"'`-.\n");
                Console.SetCursorPosition(x, y + 1); Console.Write("           '          `.                   /           \\\n");
                Console.SetCursorPosition(x, y + 2); Console.Write("          '             \\                 ' __          \\\n");
                Console.SetCursorPosition(x, y + 3); Console.Write("         /       .+\"\"`'`-                `-'  `\",        \\\n");
                Console.SetCursorPosition(x, y + 4); Console.Write("        /       , |                             |\\        .\n");
                Console.SetCursorPosition(x, y + 5); Console.Write("       .       .  |          ,.    ,-.       .  | .       |\n");
                Console.SetCursorPosition(x, y + 6); Console.Write("       '       |  |.\".       | .   | |      ' `.| |       |\n");
                Console.SetCursorPosition(x, y + 7); Console.Write("        \\      |_.'  '      .' .  .  |       `  `.|       '\n");
                Console.SetCursorPosition(x, y + 8); Console.Write("        .    _,'    /    ,\"\"-. `-.' ,-\"\"-.    |    `.    .\n");
                Console.SetCursorPosition(x, y + 9); Console.Write("        j-..'      / ,-.'  .  \\    |  .   .--.'      `...'.\n");
                Console.SetCursorPosition(x, y + 10); Console.Write("        | `-`._.--'.'  `._     |   |   __.'   \\`--...'-'  |\n");
                Console.SetCursorPosition(x, y + 11); Console.Write("        `....'     | /\\___`'--'     `\"\"_....\"\\ \\     `...'\n");
                Console.SetCursorPosition(x, y + 12); Console.Write("         | |-\"-._,`.'     `\"-._     _.\"       \\|\". ,^.|  |\n");
                Console.SetCursorPosition(x, y + 13); Console.Write("         | `..,\"_,'            `---'           \\  `-..'  |\n");
                Console.SetCursorPosition(x, y + 14); Console.Write("         `._|_.\\ `._____                 _...__.`._,_' _.|\n");
                Console.SetCursorPosition(x, y + 15); Console.Write("         /  '`-.`-._|.  `-._           ,\"     .','_,\"'`\\ \\\n");
                Console.SetCursorPosition(x, y + 16); Console.Write("        ' .'    `-._`.`.    `.       ,'     ,' _.'      . `\n");
                Console.SetCursorPosition(x, y + 17); Console.Write("  ____.'  |         `\"  `\"---+------'-----\" `\"'         |  `.____\n");
                Console.SetCursorPosition(x, y + 18); Console.Write(",'_,.-`._,'                                             '.--...._`\n");
                Console.SetCursorPosition(x, y + 19); Console.Write("`\".--..__'                                               `._.---`\"` \n");
            }

            else if (pokenumber == 99)
            {
                Console.SetCursorPosition(x, y); Console.Write("                                 _,.._\n");
                Console.SetCursorPosition(x, y + 1); Console.Write("                            _,-'\"     `.\n");
                Console.SetCursorPosition(x, y + 2); Console.Write("                       _,.-'            `._\n");
                Console.SetCursorPosition(x, y + 3); Console.Write("                     .'                    `-._\n");
                Console.SetCursorPosition(x, y + 4); Console.Write("                    .       /                  `-.\n");
                Console.SetCursorPosition(x, y + 5); Console.Write("                    |      /                      |\n");
                Console.SetCursorPosition(x, y + 6); Console.Write("                    |   _,'                       |\n");
                Console.SetCursorPosition(x, y + 7); Console.Write("  ,'\"\"'\"`-._        |`\"\"                          |\n");
                Console.SetCursorPosition(x, y + 8); Console.Write(" /          `-.     |       _,....._              |\n");
                Console.SetCursorPosition(x, y + 9); Console.Write("/...._         .    '    ,-'| | |`-.`.            '\n");
                Console.SetCursorPosition(x, y + 10); Console.Write("     ``.       '  _  `./\\`\\ | | | | `.`.   _,.---- `.\n");
                Console.SetCursorPosition(x, y + 11); Console.Write("  ,.  | .       \\ ``.    ._\\|_| | | / \\ \\._          `.\n");
                Console.SetCursorPosition(x, y + 12); Console.Write("  | `.| |        . `.`.  |\\   `-'.|/_,.-\"  `          |\n");
                Console.SetCursorPosition(x, y + 13); Console.Write("  \\    `._       |   `.`-' `.              |         ,'\n");
                Console.SetCursorPosition(x, y + 14); Console.Write("   \\      `.   ,'     _\\,.'\"\"`.            |        .\\\n");
                Console.SetCursorPosition(x, y + 15); Console.Write("    `.     |  /   ||.'./ /.   |`.          |       / |\n");
                Console.SetCursorPosition(x, y + 16); Console.Write("      `-._.'_.    |||,' ._...-' .`-.._____.'    _,' .'\n");
                Console.SetCursorPosition(x, y + 17); Console.Write("          \\\" |   ,'|'   _ _   ,'   | .-\". `-..-'  ,|\n");
                Console.SetCursorPosition(x, y + 18); Console.Write("           . |   \\  `..' \" `-'     '/|   `._`\".    |.\n");
                Console.SetCursorPosition(x, y + 19); Console.Write("           | `){\"-'`.                `+.._   `\"|    .'\n");
                Console.SetCursorPosition(x, y + 20); Console.Write("           `._|_,\".\"`.   ........_   ,\"  `-._ '.    )|\n");
                Console.SetCursorPosition(x, y + 21); Console.Write("                  ' /.`-._        `\"'...-\"_.'`._\\_,' '\n");
                Console.SetCursorPosition(x, y + 22); Console.Write("              __.' j  /`..`..__      _.){-'    | |  \\  \\\n");
                Console.SetCursorPosition(x, y + 23); Console.Write("            ,__/   |-`.,'      `\"`'\"\"         | |   \\  \\\n");
                Console.SetCursorPosition(x, y + 24); Console.Write("               `--\"'-.'                       |  \\   .  `___\n");
                Console.SetCursorPosition(x, y + 25); Console.Write("                                              `./\"\"\"-`./\"'__`\n");
                Console.SetCursorPosition(x, y + 26); Console.Write("                                                `..--.|`-'  `' \n");
            }

            else if (pokenumber == 100)
            {
                Console.SetCursorPosition(x, y); Console.Write("                         __...--------...__\n");
                Console.SetCursorPosition(x, y + 1); Console.Write("                    _.--'                  `\"-..\n");
                Console.SetCursorPosition(x, y + 2); Console.Write("                _.-'                  ,.        `-._\n");
                Console.SetCursorPosition(x, y + 3); Console.Write("             _,'                    .'  \\           `._\n");
                Console.SetCursorPosition(x, y + 4); Console.Write("           ,\"                     ,'     .             `.\n");
                Console.SetCursorPosition(x, y + 5); Console.Write("         ,'                      /        `.             `.\n");
                Console.SetCursorPosition(x, y + 6); Console.Write("        /                       .           \\              `.\n");
                Console.SetCursorPosition(x, y + 7); Console.Write("      ,'                         `.._        .               .\n");
                Console.SetCursorPosition(x, y + 8); Console.Write("     /                               `-._    /`               \\\n");
                Console.SetCursorPosition(x, y + 9); Console.Write("    /                                    `-._  \\               \\\n");
                Console.SetCursorPosition(x, y + 10); Console.Write("   /    __,........----...__                 `\"-'               \\\n");
                Console.SetCursorPosition(x, y + 11); Console.Write("  /.--\"\"                    `'--.._                 ...........\n");
                Console.SetCursorPosition(x, y + 12); Console.Write(" j                                 `\"-._            `. /      |  `\n");
                Console.SetCursorPosition(x, y + 13); Console.Write(" '                                      `._           `.      .   .\n");
                Console.SetCursorPosition(x, y + 14); Console.Write(".                                          `._          `.    '   |\n");
                Console.SetCursorPosition(x, y + 15); Console.Write("|                                             `.          \\  /    |\n");
                Console.SetCursorPosition(x, y + 16); Console.Write("|                                               `.         `'     |\n");
                Console.SetCursorPosition(x, y + 17); Console.Write("|                                                 `.              |\n");
                Console.SetCursorPosition(x, y + 18); Console.Write("|                                                   `.            |\n");
                Console.SetCursorPosition(x, y + 19); Console.Write("'                                                     `.          |\n");
                Console.SetCursorPosition(x, y + 20); Console.Write(" .                                                      .         |\n");
                Console.SetCursorPosition(x, y + 21); Console.Write("                                                         \\        '\n");
                Console.SetCursorPosition(x, y + 22); Console.Write("  '                                                       \\      '\n");
                Console.SetCursorPosition(x, y + 23); Console.Write("   .                                                       \\    /\n");
                Console.SetCursorPosition(x, y + 24); Console.Write("    \\       ____                                            .  /\n");
                Console.SetCursorPosition(x, y + 25); Console.Write("     \\    .\"    `\"\"-._                                       '/\n");
                Console.SetCursorPosition(x, y + 26); Console.Write("      `   '           `-.                                   ,'\n");
                Console.SetCursorPosition(x, y + 27); Console.Write("       `.  `.            `.                               ,'\n");
                Console.SetCursorPosition(x, y + 28); Console.Write("         `.  .             `.                           .'\n");
                Console.SetCursorPosition(x, y + 29); Console.Write("           `._`-.            \\                        .'\n");
                Console.SetCursorPosition(x, y + 30); Console.Write("              `._`._          '                    _,'\n");
                Console.SetCursorPosition(x, y + 31); Console.Write("                 `._`\"-._     |                 _.\"\n");
                Console.SetCursorPosition(x, y + 32); Console.Write("                     \"-.._`--'           __,.-\"'\n");
                Console.SetCursorPosition(x, y + 33); Console.Write("                          `\"\"----------\"' \n");
            }

            else if (pokenumber == 101)
            {
                Console.SetCursorPosition(x, y); Console.Write("\n");
                Console.SetCursorPosition(x, y + 1); Console.Write("                         _,.--\"'\"\"\"''\"\"\"''--..__\n");
                Console.SetCursorPosition(x, y + 2); Console.Write("                    _.-\"'                       `-._\n");
                Console.SetCursorPosition(x, y + 3); Console.Write("                 _.'                                `-._\n");
                Console.SetCursorPosition(x, y + 4); Console.Write("              _,'                     ._                `.\n");
                Console.SetCursorPosition(x, y + 5); Console.Write("            ,'                          `._               `.\n");
                Console.SetCursorPosition(x, y + 6); Console.Write("          .'                               `._              `.\n");
                Console.SetCursorPosition(x, y + 7); Console.Write("         /                                    `.              \\\n");
                Console.SetCursorPosition(x, y + 8); Console.Write("       ,'                             .         `.    |        `.\n");
                Console.SetCursorPosition(x, y + 9); Console.Write("      /                               |           `.  |   |      .\n");
                Console.SetCursorPosition(x, y + 10); Console.Write("     /                                |             \\ |   |       \\\n");
                Console.SetCursorPosition(x, y + 11); Console.Write("    /                                                `    | ,.-\"'  \\\n");
                Console.SetCursorPosition(x, y + 12); Console.Write("   /                                                                \\\n");
                Console.SetCursorPosition(x, y + 13); Console.Write("  j                                                        |         .\n");
                Console.SetCursorPosition(x, y + 14); Console.Write("  |                  __...--'\"''\"\"'\"'\"\"\"'`--..__           |         '\n");
                Console.SetCursorPosition(x, y + 15); Console.Write(" j             _.--\"'                           `-.._                 .\n");
                Console.SetCursorPosition(x, y + 16); Console.Write(" |         _,-'                      .\"\"'`--..__     `\"-._            |\n");
                Console.SetCursorPosition(x, y + 17); Console.Write(" |     _.-'                          |          `\"-._     `._         |\n");
                Console.SetCursorPosition(x, y + 18); Console.Write(" |  _.'                              |               `-._    `._      |\n");
                Console.SetCursorPosition(x, y + 19); Console.Write(" |,'                                 |    |              `-._   `.    |\n");
                Console.SetCursorPosition(x, y + 20); Console.Write(" |                                   |    |                  `-.  `._ |\n");
                Console.SetCursorPosition(x, y + 21); Console.Write(" |                                   '    |     |               `.   `'\n");
                Console.SetCursorPosition(x, y + 22); Console.Write(" |                                    `\"--'.....+................'   j\n");
                Console.SetCursorPosition(x, y + 23); Console.Write(" '                                                                   |\n");
                Console.SetCursorPosition(x, y + 24); Console.Write("  .                                                                  '\n");
                Console.SetCursorPosition(x, y + 25); Console.Write("   .                                                                /\n");
                Console.SetCursorPosition(x, y + 26); Console.Write("    `                                                              /\n");
                Console.SetCursorPosition(x, y + 27); Console.Write("     '                                                           ,'\n");
                Console.SetCursorPosition(x, y + 28); Console.Write("      `.                                                        .\n");
                Console.SetCursorPosition(x, y + 29); Console.Write("        .                                                      /\n");
                Console.SetCursorPosition(x, y + 30); Console.Write("         `.                                                  ,'\n");
                Console.SetCursorPosition(x, y + 31); Console.Write("           `.                                              .'\n");
                Console.SetCursorPosition(x, y + 32); Console.Write("             `._                                        _.'\n");
                Console.SetCursorPosition(x, y + 33); Console.Write("                `._                                 _.-'\n");
                Console.SetCursorPosition(x, y + 34); Console.Write("                   `-._                         _,-\"\n");
                Console.SetCursorPosition(x, y + 35); Console.Write("                       `\"--..__           __..-'\n");
                Console.SetCursorPosition(x, y + 36); Console.Write("                               `\"\"\"''\"'\"\"\" \n");
            }

            else if (pokenumber == 102)
            {
                Console.SetCursorPosition(x, y); Console.Write("                       __.__._\n");
                Console.SetCursorPosition(x, y + 1); Console.Write("                     .\"   ) `.`\".\n");
                Console.SetCursorPosition(x, y + 2); Console.Write("                    /     `.../  \\\n");
                Console.SetCursorPosition(x, y + 3); Console.Write("                   |   _.'   \\    .\n");
                Console.SetCursorPosition(x, y + 4); Console.Write("                   |  '       `.  |\n");
                Console.SetCursorPosition(x, y + 5); Console.Write("                   '            `.'\n");
                Console.SetCursorPosition(x, y + 6); Console.Write("                    \\          _,..---..._\n");
                Console.SetCursorPosition(x, y + 7); Console.Write("         _,.._       `._     ,'           |.\n");
                Console.SetCursorPosition(x, y + 8); Console.Write("      ,\"\\  `. `\".       `\"\".'             | `.\n");
                Console.SetCursorPosition(x, y + 9); Console.Write("     /   \\ _|_  _\\       .'               |   `.\n");
                Console.SetCursorPosition(x, y + 10); Console.Write("   ,'     `...' `.\\    ,'                 |     \\         _......_\n");
                Console.SetCursorPosition(x, y + 11); Console.Write("  .        ,' ___. .  /                  j    _,'\\      .'   |    `.\n");
                Console.SetCursorPosition(x, y + 12); Console.Write("  |       .        | /                   |.--\"    \\    /     |      /.\n");
                Console.SetCursorPosition(x, y + 13); Console.Write("  |       |        |.                    |            /      |     /  \\\n");
                Console.SetCursorPosition(x, y + 14); Console.Write("  '       |        '                     '         ' j       |`  .'    .\n");
                Console.SetCursorPosition(x, y + 15); Console.Write("   `.  ,`.|       /|     `.                         .|`-._   .--,      |\n");
                Console.SetCursorPosition(x, y + 16); Console.Write("     `/   |    _.' |      |`._             _,       || `--` '--'       '\n");
                Console.SetCursorPosition(x, y + 17); Console.Write("       `\"-+---\"    |      `   `-._     _.-'  |      | .   ----        /\n");
                Console.SetCursorPosition(x, y + 18); Console.Write("      _.......__   |       `.....'   -.______'      |  \\            ,'\n");
                Console.SetCursorPosition(x, y + 19); Console.Write("    ,'         `\"--|_            ____               '   `-._    __.'\n");
                Console.SetCursorPosition(x, y + 20); Console.Write("   /                 |.         -....-\"            /        `\"\"\"\n");
                Console.SetCursorPosition(x, y + 21); Console.Write("  /         '   -._  | `.                         /\n");
                Console.SetCursorPosition(x, y + 22); Console.Write(" /         / \\     `.|   \\                      .'\n");
                Console.SetCursorPosition(x, y + 23); Console.Write(".         / .'       '._  \\                   ,'\n");
                Console.SetCursorPosition(x, y + 24); Console.Write("|        /.\"            '--._                .__..._\n");
                Console.SetCursorPosition(x, y + 25); Console.Write("'  .....,               |  | `-.._     __..-\"\"      `\".\n");
                Console.SetCursorPosition(x, y + 26); Console.Write(" . |  .'  _.-           |  |      `'\"\"'.\"              `.\n");
                Console.SetCursorPosition(x, y + 27); Console.Write(" `. `\" .-'              |  '          /                  \\\n");
                Console.SetCursorPosition(x, y + 28); Console.Write("   .                    ' .          /                    .\n");
                Console.SetCursorPosition(x, y + 29); Console.Write("    `.                .' /          |                     |\n");
                Console.SetCursorPosition(x, y + 30); Console.Write("      `.              |.'           |                     |\n");
                Console.SetCursorPosition(x, y + 31); Console.Write("        `-._       _,-'             `.     '-.        _,- '\n");
                Console.SetCursorPosition(x, y + 32); Console.Write("            \"'---\"'                   \\     `..`.  ....' /\n");
                Console.SetCursorPosition(x, y + 33); Console.Write("                                       \\                /\n");
                Console.SetCursorPosition(x, y + 34); Console.Write("                                        `._   --==-. _,'\n");
                Console.SetCursorPosition(x, y + 35); Console.Write("                                           `---...--' \n");
            }

            else if (pokenumber == 103)
            {
                Console.SetCursorPosition(x, y); Console.Write("\n");
                Console.SetCursorPosition(x, y + 1); Console.Write("                              .'\n");
                Console.SetCursorPosition(x, y + 2); Console.Write("                              | \\\n");
                Console.SetCursorPosition(x, y + 3); Console.Write("                              |  .\n");
                Console.SetCursorPosition(x, y + 4); Console.Write("              '._             |   .\n");
                Console.SetCursorPosition(x, y + 5); Console.Write("              `. `._          |   |        .             __...\n");
                Console.SetCursorPosition(x, y + 6); Console.Write("                `.  `.        |   '      .'        _,.-\"'_.'\n");
                Console.SetCursorPosition(x, y + 7); Console.Write("                  .   `.      |    .    / '    _,-'   _,'\n");
                Console.SetCursorPosition(x, y + 8); Console.Write("                   `.   `.    |        / /  _,\"    _,\"\n");
                Console.SetCursorPosition(x, y + 9); Console.Write("           `+.._     `    `.  '     . / / .\"     ,\"\n");
                Console.SetCursorPosition(x, y + 10); Console.Write("              `._`-._ `.    `. .    |/ /,'     .'\n");
                Console.SetCursorPosition(x, y + 11); Console.Write("    _,..---\"\"\"\"--`.  `-.`.    \\|    | ./     ,'  _,.---,________\n");
                Console.SetCursorPosition(x, y + 12); Console.Write(" -`=..__                `-.    |    |.'    .'_..+---\"\"\"         `\"-..\n");
                Console.SetCursorPosition(x, y + 13); Console.Write("        `\"\"---..___        `.  |    |'   .'-\"          ___,.....---\"\"`'\n");
                Console.SetCursorPosition(x, y + 14); Console.Write("               _,.-\"\"__,.._  `   ___'  .'  ____..---\"\"'\n");
                Console.SetCursorPosition(x, y + 15); Console.Write("         _,.-\"\"    .'  ,.  \\ .-\"'   `-.  \"\"-------...__\n");
                Console.SetCursorPosition(x, y + 16); Console.Write("      .-\"    __.-.'   '-\"'  / -='   `\"'\\......__       `\"-..._\n");
                Console.SetCursorPosition(x, y + 17); Console.Write("    .\" _,.--\"\"  / .\"\"\"|    /            \\  _  ..`.-.....______`_\n");
                Console.SetCursorPosition(x, y + 18); Console.Write("   '.-' .'_.-\"\".  | _.|   .   `.-----\"'  .'\"  __  `             '\n");
                Console.SetCursorPosition(x, y + 19); Console.Write("       -\"'     '  |'  |   |              | '\"\"     .\n");
                Console.SetCursorPosition(x, y + 20); Console.Write("                \\  ...'   |              '         |`-.\n");
                Console.SetCursorPosition(x, y + 21); Console.Write("                 `._      ,.            /          '\"--'\n");
                Console.SetCursorPosition(x, y + 22); Console.Write("                    `\"\"\".'  `._     _,\"`.       _,'\n");
                Console.SetCursorPosition(x, y + 23); Console.Write("                       /.....__`\"\"\"'     \\--..-\"\n");
                Console.SetCursorPosition(x, y + 24); Console.Write("                      /        `'\"\"'----...\n");
                Console.SetCursorPosition(x, y + 25); Console.Write("                .    /____                |\n");
                Console.SetCursorPosition(x, y + 26); Console.Write("               | |  j----.`\"\"---..__      |\n");
                Console.SetCursorPosition(x, y + 27); Console.Write("         '`-.,-`.'--|`-.  `.        `'\"--.|\n");
                Console.SetCursorPosition(x, y + 28); Console.Write("          `./   ___ `.  .  |              '\n");
                Console.SetCursorPosition(x, y + 29); Console.Write("           ' ,\"'   `. . |  |             /\n");
                Console.SetCursorPosition(x, y + 30); Console.Write("           . |      | | | .'          .'j\n");
                Console.SetCursorPosition(x, y + 31); Console.Write("            \\`.     | '-'`..._____..-'  |\n");
                Console.SetCursorPosition(x, y + 32); Console.Write("             `.`.__.'/     ,'`._       ,'\n");
                Console.SetCursorPosition(x, y + 33); Console.Write("               `\"--`'     . \\   `-.__ /\n");
                Console.SetCursorPosition(x, y + 34); Console.Write("                          |  `...___.'\n");
                Console.SetCursorPosition(x, y + 35); Console.Write("                          /\"`__.._'\".\n");
                Console.SetCursorPosition(x, y + 36); Console.Write("                          `\"'     `\" \n");
            }

            else if (pokenumber == 104)
            {
                Console.SetCursorPosition(x, y); Console.Write("                                             ..\n");
                Console.SetCursorPosition(x, y + 1); Console.Write("                                           .'  |\n");
                Console.SetCursorPosition(x, y + 2); Console.Write("                                           |   '\n");
                Console.SetCursorPosition(x, y + 3); Console.Write("                                           '    \\\n");
                Console.SetCursorPosition(x, y + 4); Console.Write("                                          /      `-._\n");
                Console.SetCursorPosition(x, y + 5); Console.Write("                                  _...--\"'           `\"-._\n");
                Console.SetCursorPosition(x, y + 6); Console.Write("                                ,'                        `-.______\n");
                Console.SetCursorPosition(x, y + 7); Console.Write("                               j                                   |\n");
                Console.SetCursorPosition(x, y + 8); Console.Write("                               |                                  ,'\n");
                Console.SetCursorPosition(x, y + 9); Console.Write("                               |           _                    ,'\n");
                Console.SetCursorPosition(x, y + 10); Console.Write("                              /          ,'){\"\"\"\"\"-.           .'\n");
                Console.SetCursorPosition(x, y + 11); Console.Write("                             .___..  __,'\"       `.`.         |\n");
                Console.SetCursorPosition(x, y + 12); Console.Write("                               |       ||        `.\\ .        |\n");
                Console.SetCursorPosition(x, y + 13); Console.Write("                             ,'|      _||  `-._   | ||        |\n");
                Console.SetCursorPosition(x, y + 14); Console.Write("                  .\"`-------'  `-..,-\" ||...._()`-  '|        '\n");
                Console.SetCursorPosition(x, y + 15); Console.Write("                  `.               \\.-\"       `.__,','       /\n");
                Console.SetCursorPosition(x, y + 16); Console.Write("                    \\            .\"            |_.-'        .\n");
                Console.SetCursorPosition(x, y + 17); Console.Write("                     /                    _...-'            |\n");
                Console.SetCursorPosition(x, y + 18); Console.Write("                    /                   .'.                 |\n");
                Console.SetCursorPosition(x, y + 19); Console.Write("                  ,'                  .'   |        __      '\n");
                Console.SetCursorPosition(x, y + 20); Console.Write("                 ,                  ,'     |      .'  `      `.\n");
                Console.SetCursorPosition(x, y + 21); Console.Write("                /                  '       |___   |   /    .--'\n");
                Console.SetCursorPosition(x, y + 22); Console.Write("               .        ____                 | `. `..'   ,'\n");
                Console.SetCursorPosition(x, y + 23); Console.Write("               |            `\"-.             |   \\     .'\n");
                Console.SetCursorPosition(x, y + 24); Console.Write("            _,\"j'               `.           |    `--+\"-._\n");
                Console.SetCursorPosition(x, y + 25); Console.Write("          ,\"  /                   \\          |       |    `.\n");
                Console.SetCursorPosition(x, y + 26); Console.Write("       _,'   .                     .         |       '.     `.  _,.\n");
                Console.SetCursorPosition(x, y + 27); Console.Write("     ,\"      |                     |         '      /  |    ,\"._  '\n");
                Console.SetCursorPosition(x, y + 28); Console.Write("  _,'        |_,...._              |       ,'      /__.'  ,'    `/\n");
                Console.SetCursorPosition(x, y + 29); Console.Write(",'           |   _.' `\".          .     _,'\"--.._,'     .'      /\n");
                Console.SetCursorPosition(x, y + 30); Console.Write("`._          `--'       \\        /_,.-\"'  __,.-'       '      ,'\n");
                Console.SetCursorPosition(x, y + 31); Console.Write("   `\"'\"\"------`.        .\"`----\"\"     _.-\"..__________      ,'\n");
                Console.SetCursorPosition(x, y + 32); Console.Write("                `._     |          ,-'                `\"--'\"\n");
                Console.SetCursorPosition(x, y + 33); Console.Write("                   `-..-`._       /\n");
                Console.SetCursorPosition(x, y + 34); Console.Write("                           `.   ,'\n");
                Console.SetCursorPosition(x, y + 35); Console.Write("                             `\"' \n");
            }

            else if (pokenumber == 105)
            {
                Console.SetCursorPosition(x, y); Console.Write("      ,.                           __     ,\"`.\n");
                Console.SetCursorPosition(x, y + 1); Console.Write("     / |                      _.-\"'  `\"--'   |\n");
                Console.SetCursorPosition(x, y + 2); Console.Write("    /  |              .\"--..,'               |\n");
                Console.SetCursorPosition(x, y + 3); Console.Write("   j   |              `                      |\n");
                Console.SetCursorPosition(x, y + 4); Console.Write("   '    `-.            `.                    |\n");
                Console.SetCursorPosition(x, y + 5); Console.Write("  .       .'            '                    |\n");
                Console.SetCursorPosition(x, y + 6); Console.Write("  |    ,-\"               .                   '\n");
                Console.SetCursorPosition(x, y + 7); Console.Write("  |     \\                |                    ,\"\"`.\n");
                Console.SetCursorPosition(x, y + 8); Console.Write("  |      \\               |                   ||    `\n");
                Console.SetCursorPosition(x, y + 9); Console.Write("  |       \\             j     `-.           .||     `.\n");
                Console.SetCursorPosition(x, y + 10); Console.Write("  |        \\            |       |`.         |||      |\n");
                Console.SetCursorPosition(x, y + 11); Console.Write("  |         \\         __|       |  |`.      |'|\\   .'\n");
                Console.SetCursorPosition(x, y + 12); Console.Write("  |          `.  _.-\"'   `-.._  `._'  `.    | | `-\"\n");
                Console.SetCursorPosition(x, y + 13); Console.Write("  |          _,+\"             `.   `\"\"--\\     |\n");
                Console.SetCursorPosition(x, y + 14); Console.Write("  '        .'                   `.            |\n");
                Console.SetCursorPosition(x, y + 15); Console.Write("  '      ,'                      |`.       .  '\n");
                Console.SetCursorPosition(x, y + 16); Console.Write("   \\   .'                        `. `.     , /\n");
                Console.SetCursorPosition(x, y + 17); Console.Write("    \\,'             _,.-+\"\"'.      `  `.   .'\n");
                Console.SetCursorPosition(x, y + 18); Console.Write("    /            .-'     `-. '      `.  `\"'\n");
                Console.SetCursorPosition(x, y + 19); Console.Write("  ,'           ,'\\          `.`.      `\n");
                Console.SetCursorPosition(x, y + 20); Console.Write(" '            /.  `.         ,\\ \\      `._\n");
                Console.SetCursorPosition(x, y + 21); Console.Write(".            /  \\   `._    .'  \\ .        `\".\n");
                Console.SetCursorPosition(x, y + 22); Console.Write("|           /._  `-._  `,-'    ,' `.         \\\n");
                Console.SetCursorPosition(x, y + 23); Console.Write("|          /   `\"-+---\"'      |    |         ,-.._\n");
                Console.SetCursorPosition(x, y + 24); Console.Write("|..____,.-'       |`.         '   ,'         |    `\"-._        __\n");
                Console.SetCursorPosition(x, y + 25); Console.Write("`---'\"            |  \\         `.'  `-.._   ,|      `._`\"-._.\"'  `.\n");
                Console.SetCursorPosition(x, y + 26); Console.Write("                  |`._`.        |        `.  `-._      \"-          .\n");
                Console.SetCursorPosition(x, y + 27); Console.Write("                   `.,' `.___..'           `\"    `._                |\n");
                Console.SetCursorPosition(x, y + 28); Console.Write("                                                    `.              |\n");
                Console.SetCursorPosition(x, y + 29); Console.Write("                                                      `._         .'\n");
                Console.SetCursorPosition(x, y + 30); Console.Write("                                                         `        |\n");
                Console.SetCursorPosition(x, y + 31); Console.Write("                                                          .       |\n");
                Console.SetCursorPosition(x, y + 32); Console.Write("                                                           \\      |\n");
                Console.SetCursorPosition(x, y + 33); Console.Write("                                                            `..,.' \n");
            }

            else if (pokenumber == 106)
            {
                Console.SetCursorPosition(x, y); Console.Write("                                                   __           ,-\"\".\n");
                Console.SetCursorPosition(x, y + 1); Console.Write("                                                 .'  `.       ,'     .\n");
                Console.SetCursorPosition(x, y + 2); Console.Write("                                            _____|     \\    ,'       |\n");
                Console.SetCursorPosition(x, y + 3); Console.Write("                                      _,-'\"\"     |      `..'     _,-'\n");
                Console.SetCursorPosition(x, y + 4); Console.Write("                                    ,\"           `.            ,'\n");
                Console.SetCursorPosition(x, y + 5); Console.Write("                                   /       /|   ,\"'`,        ,'\n");
                Console.SetCursorPosition(x, y + 6); Console.Write("               _,..__             /      ,'.|  .  .',`.     `.\n");
                Console.SetCursorPosition(x, y + 7); Console.Write("            .\"'      `'--\"\"-._  .'     .' ,'/  |  | |' |      `.\n");
                Console.SetCursorPosition(x, y + 8); Console.Write("        __.'             `.   `.       |`'.'      ` '.`|        `\n");
                Console.SetCursorPosition(x, y + 9); Console.Write("   .-\"\"'   |               `\"-.' ,\"`.  '-'         `---'.        \\\n");
                Console.SetCursorPosition(x, y + 10); Console.Write("  `-.      '             ____   '.`\"\"/               .'  `\"-.     .\n");
                Console.SetCursorPosition(x, y + 11); Console.Write("     `-.__/            ,'    `\".  `./._              |       '    |\n");
                Console.SetCursorPosition(x, y + 12); Console.Write("       _,.            j        |   |  |`\"-._         '      .     '\n");
                Console.SetCursorPosition(x, y + 13); Console.Write(" _,.-\"'   \\           |        |   |  |   | `+-.\"\"-.  .     |    .\n");
                Console.SetCursorPosition(x, y + 14); Console.Write("'._       |           |        |   '  |   '  |  |.    |     `..-'\n");
                Console.SetCursorPosition(x, y + 15); Console.Write("   `\"-....'           `.      ,'  '  ,'  ,   |  ' .   '\n");
                Console.SetCursorPosition(x, y + 16); Console.Write("         .._            `-...'  ,'--+---+--.'_.'  |  .\n");
                Console.SetCursorPosition(x, y + 17); Console.Write("       .'   `                _.'      `.     `-..'  /\n");
                Console.SetCursorPosition(x, y + 18); Console.Write("     ,'     _\\         __..-\",'         `     \\    /\n");
                Console.SetCursorPosition(x, y + 19); Console.Write("     \"'`\"'\"'  `\"----'\"\"/.-+\"             `     `  /\n");
                Console.SetCursorPosition(x, y + 20); Console.Write("                    ,-'---|               \\      .\n");
                Console.SetCursorPosition(x, y + 21); Console.Write("                   /      |                `.__..'\n");
                Console.SetCursorPosition(x, y + 22); Console.Write("                 .'    .' `.                \\    /.\n");
                Console.SetCursorPosition(x, y + 23); Console.Write("               ,'  ,..\" ..  `.               \\-\"'  \\\n");
                Console.SetCursorPosition(x, y + 24); Console.Write("               '._'  |  | `-.'                \\  _,`.\n");
                Console.SetCursorPosition(x, y + 25); Console.Write("                     |  '                      \\'   /.\n");
                Console.SetCursorPosition(x, y + 26); Console.Write("                     `.  )                      . ,'  '+-._\n");
                Console.SetCursorPosition(x, y + 27); Console.Write("                       `'                        `. .' ||.\"`.\n");
                Console.SetCursorPosition(x, y + 28); Console.Write("                                                   `._,'||   |\n");
                Console.SetCursorPosition(x, y + 29); Console.Write("                                                    |._,' `-.|\n");
                Console.SetCursorPosition(x, y + 30); Console.Write("                                                    `.       |\n");
                Console.SetCursorPosition(x, y + 31); Console.Write("                                                     '       |\n");
                Console.SetCursorPosition(x, y + 32); Console.Write("                                                      .__ _ .|\n");
                Console.SetCursorPosition(x, y + 33); Console.Write("                                                       | | | |\n");
                Console.SetCursorPosition(x, y + 34); Console.Write("                                                       '.`.'.' \n");
            }

            else if (pokenumber == 107)
            {
                Console.SetCursorPosition(x, y); Console.Write("                                            __\n");
                Console.SetCursorPosition(x, y + 1); Console.Write("                                          ,'  `\".\n");
                Console.SetCursorPosition(x, y + 2); Console.Write("                                    _    /      '\n");
                Console.SetCursorPosition(x, y + 3); Console.Write("                                .-\"' | ,'      /\n");
                Console.SetCursorPosition(x, y + 4); Console.Write("                             ,.j     |/       /   _,\".\n");
                Console.SetCursorPosition(x, y + 5); Console.Write("                           ,' ||     |       j _,\"    `.\n");
                Console.SetCursorPosition(x, y + 6); Console.Write("                          |   ||             '\"      .'\n");
                Console.SetCursorPosition(x, y + 7); Console.Write("                          |    |                   ,\"\n");
                Console.SetCursorPosition(x, y + 8); Console.Write("                          |                      .' _..-.\n");
                Console.SetCursorPosition(x, y + 9); Console.Write("           _______        |   \\                  `'\"     \\\n");
                Console.SetCursorPosition(x, y + 10); Console.Write("      _,-\"'       `-._    |  | \\                      _.\"\n");
                Console.SetCursorPosition(x, y + 11); Console.Write("    .'                `.  |  | b`       _..+-      _,'  ___......\n");
                Console.SetCursorPosition(x, y + 12); Console.Write("   ,                    \\ `. `-     -'\"d   |   _,.---'\"\"         |\n");
                Console.SetCursorPosition(x, y + 13); Console.Write(" ,.                      \\  `.----.._  ---'_.-'                  |\n");
                Console.SetCursorPosition(x, y + 14); Console.Write("| |                       ',-\"`._    `-.,-'                    .'\n");
                Console.SetCursorPosition(x, y + 15); Console.Write("`.|                       |      `\"---.'  _..,.-\"\"\"\".      _.-'\n");
                Console.SetCursorPosition(x, y + 16); Console.Write("  `.                      |\\        ,'. .\"    |    __...-\"'\n");
                Console.SetCursorPosition(x, y + 17); Console.Write("    `.                   ,'/`\"-.__,'  ,'    __|.-'\"    /\n");
                Console.SetCursorPosition(x, y + 18); Console.Write("      `-._            _,\\.'         `.  _,-\"\\`-._____,'._\n");
                Console.SetCursorPosition(x, y + 19); Console.Write("          `\"-...----'\"   \\---...____.'\"\"_.'  `-..,'   `  `-.\n");
                Console.SetCursorPosition(x, y + 20); Console.Write("                          `\"'\"`\\   `._.'     .' /      '    \\\n");
                Console.SetCursorPosition(x, y + 21); Console.Write("                                `._,'      ,'  /       |     \\\n");
                Console.SetCursorPosition(x, y + 22); Console.Write("                                    `\"-.  .   /        |      \\\n");
                Console.SetCursorPosition(x, y + 23); Console.Write("                                  ,'   ,'\"'`-+...-'\"\"'/__..--\"'\n");
                Console.SetCursorPosition(x, y + 24); Console.Write("                              _,.'   .'        |     /\n");
                Console.SetCursorPosition(x, y + 25); Console.Write("                            ,\"     ,'          |    .\n");
                Console.SetCursorPosition(x, y + 26); Console.Write("                          ,'      .            |    '.__\n");
                Console.SetCursorPosition(x, y + 27); Console.Write("                        .'      .'             `.       `.\n");
                Console.SetCursorPosition(x, y + 28); Console.Write("                     _.'|    _,'                 `.       `.\n");
                Console.SetCursorPosition(x, y + 29); Console.Write("                   .\"   `-..'7                     `.       `.\n");
                Console.SetCursorPosition(x, y + 30); Console.Write("                 .'         /                        \\        \\\n");
                Console.SetCursorPosition(x, y + 31); Console.Write("                 |        .'                          \\        ,\".\n");
                Console.SetCursorPosition(x, y + 32); Console.Write("                 `--....-\"                          ..-`'\"\"`--'   \\\n");
                Console.SetCursorPosition(x, y + 33); Console.Write("                                                   /              '\n");
                Console.SetCursorPosition(x, y + 34); Console.Write("                                                   `._      _...-'\n");
                Console.SetCursorPosition(x, y + 35); Console.Write("                                                      `\"--\"' \n");
            }

            else if (pokenumber == 108)
            {
                Console.SetCursorPosition(x, y); Console.Write("             _____                       ,\".\n");
                Console.SetCursorPosition(x, y + 1); Console.Write("        _.-\"'     ``.                  .'   `\n");
                Console.SetCursorPosition(x, y + 2); Console.Write("      ,'             .               ,'      |\n");
                Console.SetCursorPosition(x, y + 3); Console.Write("    .'               |            _,'        |\n");
                Console.SetCursorPosition(x, y + 4); Console.Write("  ,'                 '          ,'           |\n");
                Console.SetCursorPosition(x, y + 5); Console.Write(" ,               / ,'         .'             '---.._\n");
                Console.SetCursorPosition(x, y + 6); Console.Write(" '              /.'         ,'              /       `-.\n");
                Console.SetCursorPosition(x, y + 7); Console.Write(".              ,\"          /               '           `.\n");
                Console.SetCursorPosition(x, y + 8); Console.Write("|      |      .           .                              \\\n");
                Console.SetCursorPosition(x, y + 9); Console.Write("|      |      |           |                               \\\n");
                Console.SetCursorPosition(x, y + 10); Console.Write("|      |      |           |                                .\n");
                Console.SetCursorPosition(x, y + 11); Console.Write("|      |      |           `\n");
                Console.SetCursorPosition(x, y + 12); Console.Write("'      |      |            `.             _,.._             .\n");
                Console.SetCursorPosition(x, y + 13); Console.Write(" \\     |      '    __...._   `.__     _,-'     \"-.          |\n");
                Console.SetCursorPosition(x, y + 14); Console.Write("  \\    '      ' ,\"'       ``./   `'\"\"'            `.        |\n");
                Console.SetCursorPosition(x, y + 15); Console.Write("   \\    .      '.       ___  `.                     \\       '\n");
                Console.SetCursorPosition(x, y + 16); Console.Write("    \\    \\      \\       ,..`                         \\     /\n");
                Console.SetCursorPosition(x, y + 17); Console.Write("     `.   \\      \\     ( \" )          ,......--'\"\"`.  \\   /\n");
                Console.SetCursorPosition(x, y + 18); Console.Write("       .   \\      \\     `\"'                   ,\".   |  `.'\n");
                Console.SetCursorPosition(x, y + 19); Console.Write("    ,..|`.  \\      `.                         `\"'   |    \\\n");
                Console.SetCursorPosition(x, y + 20); Console.Write("   |    . `.-`\"''\"\"\"`--._                        _.'      \\\n");
                Console.SetCursorPosition(x, y + 21); Console.Write("   ,\".   `.|             `-..    /`. .._      _,\"          \\\n");
                Console.SetCursorPosition(x, y + 22); Console.Write("   `\"'._   '                   ,'  | |  `\"+\"\"' ,-'\"\"''-.    .\n");
                Console.SetCursorPosition(x, y + 23); Console.Write("        `\"--`._             _.\"    | |   |    .  ,...   .   |\n");
                Console.SetCursorPosition(x, y + 24); Console.Write("              |`+..____,..-'       ' |   |    | .    |  |   |\n");
                Console.SetCursorPosition(x, y + 25); Console.Write("              |/  ,..\\           ,'  '   |    | `.__,'  |  ,'\n");
                Console.SetCursorPosition(x, y + 26); Console.Write("              '  |   |`.___   _.'   /    `.   `._     _.' ,-.\n");
                Console.SetCursorPosition(x, y + 27); Console.Write("               \\ `--'   /._'\"\"   _,'     .'`._   `\"--\"  .'   `.\n");
                Console.SetCursorPosition(x, y + 28); Console.Write("                `-..,.-'   `---\"'     _,'_,.--`\".___,.-'      |\n");
                Console.SetCursorPosition(x, y + 29); Console.Write("                   /-----\"'   ,`\"\"''\"\"           |   _....._ .'\n");
                Console.SetCursorPosition(x, y + 30); Console.Write("                  ,-'\"\"--._,-'                   '.\"'      .\"\n");
                Console.SetCursorPosition(x, y + 31); Console.Write("                   -..---'                         `\"-----' \n");
            }

            else if (pokenumber == 109)
            {
                Console.SetCursorPosition(x, y); Console.Write("                               ,----.\n");
                Console.SetCursorPosition(x, y + 1); Console.Write("                              '      |\n");
                Console.SetCursorPosition(x, y + 2); Console.Write("                             /       '\n");
                Console.SetCursorPosition(x, y + 3); Console.Write("                       __,..'         \"-._        _\n");
                Console.SetCursorPosition(x, y + 4); Console.Write("                  _.-\"\"                   `-.   ,\" `\".\n");
                Console.SetCursorPosition(x, y + 5); Console.Write("         ,-._  _.'                           `\"'      '\n");
                Console.SetCursorPosition(x, y + 6); Console.Write("       ,'    `\"                                       |\n");
                Console.SetCursorPosition(x, y + 7); Console.Write("      .                                               .\n");
                Console.SetCursorPosition(x, y + 8); Console.Write("       `.          _.--..               ____          '\n");
                Console.SetCursorPosition(x, y + 9); Console.Write("       /         ,'    . `           ,\"' .  `.         `.\n");
                Console.SetCursorPosition(x, y + 10); Console.Write("      /         .         |         /         \\          \\\n");
                Console.SetCursorPosition(x, y + 11); Console.Write("     /          `------...'        ._____      .          \\\n");
                Console.SetCursorPosition(x, y + 12); Console.Write("    .                                    `'\"\"\"'            \\\n");
                Console.SetCursorPosition(x, y + 13); Console.Write("    '                    ________                           .\n");
                Console.SetCursorPosition(x, y + 14); Console.Write("   j           `.\"\"/'\"\"\"`        '\"\"\"'\"'--....,-            |\n");
                Console.SetCursorPosition(x, y + 15); Console.Write("   |             `/.                      ,\\ /              `.\n");
                Console.SetCursorPosition(x, y + 16); Console.Write("   |                `-._               _.'  '                 `-.\n");
                Console.SetCursorPosition(x, y + 17); Console.Write("   |                    `\"-----------\"'                         |\n");
                Console.SetCursorPosition(x, y + 18); Console.Write(" .\"                         ____                                |\n");
                Console.SetCursorPosition(x, y + 19); Console.Write("|                      ,-\"\"'    `\".                            ,'\n");
                Console.SetCursorPosition(x, y + 20); Console.Write("|                     .   .----.   `.                        .\"\n");
                Console.SetCursorPosition(x, y + 21); Console.Write("`.._                  |  '.____,'   |                        '\n");
                Console.SetCursorPosition(x, y + 22); Console.Write("    |             ,\". `.           ,' _                     /\n");
                Console.SetCursorPosition(x, y + 23); Console.Write("    '            '   `._`.'._\".__,' .' .                   /\n");
                Console.SetCursorPosition(x, y + 24); Console.Write("     .            `'-._ `._     _.-'  _.'                 /\n");
                Console.SetCursorPosition(x, y + 25); Console.Write("      `.               `.  `--'\" _,.-'                    `\n");
                Console.SetCursorPosition(x, y + 26); Console.Write("        .               ,'     .\"                          '\n");
                Console.SetCursorPosition(x, y + 27); Console.Write("         '        .-..-' _,.--._`\"-..,-.                 ,'\n");
                Console.SetCursorPosition(x, y + 28); Console.Write("        /         \\    ,'       `-.    |           .-'\"-\"\n");
                Console.SetCursorPosition(x, y + 29); Console.Write("        \\          `-.'            `..'         _,'\n");
                Console.SetCursorPosition(x, y + 30); Console.Write("         `.,.-\"`._                           ,-'\n");
                Console.SetCursorPosition(x, y + 31); Console.Write("                  `\"-.                       |\n");
                Console.SetCursorPosition(x, y + 32); Console.Write("                      \\       ,..----.     _.'\n");
                Console.SetCursorPosition(x, y + 33); Console.Write("                       `\"\"---\"        `..-\" \n");
            }

            else if (pokenumber == 110)
            {
                Console.SetCursorPosition(x, y); Console.Write("                  __....____,'  `-.\n");
                Console.SetCursorPosition(x, y + 1); Console.Write("         ,\"\"-..-'\"          \"-    |       ..      _.._\n");
                Console.SetCursorPosition(x, y + 2); Console.Write("         |        _, .,           '._    /  `'\"\"\"'    |\n");
                Console.SetCursorPosition(x, y + 3); Console.Write("        .'         _____             `.,'     ____     `.\n");
                Console.SetCursorPosition(x, y + 4); Console.Write("     _,\" _.'      \\  |  '\"--..        '       \\__ `\"-.   `.\n");
                Console.SetCursorPosition(x, y + 5); Console.Write("    | ,'\"|/        `-.______,'      `     ' |\\_  `'\"\"'  .  \\\n");
                Console.SetCursorPosition(x, y + 6); Console.Write("    .'---'      _____             . '   `   |,'\"\"\"-._  ' \\  .\n");
                Console.SetCursorPosition(x, y + 7); Console.Write("   /   __..--\"\"|___/ \"-.._/|         ,'       ___    `. \\ \\ '_\n");
                Console.SetCursorPosition(x, y + 8); Console.Write("  . .'...-----'\"\"----.._.' |-.      |        | ,.`\".   \\ `'   |\n");
                Console.SetCursorPosition(x, y + 9); Console.Write("  | `\"                  \"-.'-'      `.        \\`._`.\\   |.  .-'\n");
                Console.SetCursorPosition(x, y + 10); Console.Write(".\"        _..._                 .              `._  ,   `.' |\n");
                Console.SetCursorPosition(x, y + 11); Console.Write(" `.    ,\"'_....`\".               |                \"\"       .\n");
                Console.SetCursorPosition(x, y + 12); Console.Write("  |    | |     | |             -'   `,                    /\n");
                Console.SetCursorPosition(x, y + 13); Console.Write("  `,.  `._`---'_,'  ,-.    '        ' `-.             _   |\n");
                Console.SetCursorPosition(x, y + 14); Console.Write("  ,\\ `._  |___|  _,'  |  `    \\        . /-.__     _.' `-\"\n");
                Console.SetCursorPosition(x, y + 15); Console.Write("  \\ `.._`-._ _.-'_,.--'        |        `.    |  ,'\n");
                Console.SetCursorPosition(x, y + 16); Console.Write("   `-\"\\ `-. ' ,'_         `-..'       .-'    /  /\n");
                Console.SetCursorPosition(x, y + 17); Console.Write("       `._.---._ `\"----.        .   ,'.   _.'  /\n");
                Console.SetCursorPosition(x, y + 18); Console.Write("         `.     `'-.._/       -\" ,-\" `.`-'      `.\n");
                Console.SetCursorPosition(x, y + 19); Console.Write("           `.,       .-\"    _    |     | .     ) |\n");
                Console.SetCursorPosition(x, y + 20); Console.Write("             '._  ,\"`----\"\"`.    |     ' `'       .\n");
                Console.SetCursorPosition(x, y + 21); Console.Write("                \"\"           `--'       \\`      ,\"'\n");
                Console.SetCursorPosition(x, y + 22); Console.Write("                                         `-._,-' \n");
                Console.SetCursorPosition(x, y + 23); Console.Write("\n");
            }


            else if (pokenumber == 111)
            {
                Console.SetCursorPosition(x, y); Console.Write("\n");
                Console.SetCursorPosition(x, y + 1); Console.Write("                                        '\"-.\n");
                Console.SetCursorPosition(x, y + 2); Console.Write("                                       //   .\n");
                Console.SetCursorPosition(x, y + 3); Console.Write("                            .,.       '/    `\n");
                Console.SetCursorPosition(x, y + 4); Console.Write("                           |   \\     /.      \\        ,.\n");
                Console.SetCursorPosition(x, y + 5); Console.Write("                           |    `.  / '       \\     ,' |\n");
                Console.SetCursorPosition(x, y + 6); Console.Write("                          .|      `\"-'         \\  ,'   |\n");
                Console.SetCursorPosition(x, y + 7); Console.Write("                          ||                    \\'     '\n");
                Console.SetCursorPosition(x, y + 8); Console.Write("                   ,--.   ||             _,.     `\"-.   `.\n");
                Console.SetCursorPosition(x, y + 9); Console.Write("                __.  ,.`.j '    _.-'\"\"','  |__ ..    |    `.\n");
                Console.SetCursorPosition(x, y + 10); Console.Write("               .  |  |/  `.   ,'    .'     ' .'  `. ,_...   \\\n");
                Console.SetCursorPosition(x, y + 11); Console.Write("               '  '        \\-+.._,.'      .,'      `    .'   .\n");
                Console.SetCursorPosition(x, y + 12); Console.Write("              .  /      '  |     .-'      /           ./     |\n");
                Console.SetCursorPosition(x, y + 13); Console.Write("             /  /     .'   |             .'         ,'_|,..   .\n");
                Console.SetCursorPosition(x, y + 14); Console.Write("            /  '     /     '             |        _.-\"   .'   |\n");
                Console.SetCursorPosition(x, y + 15); Console.Write("           /  '    .' _.'   `.        __ |    _,-'      /      .\n");
                Console.SetCursorPosition(x, y + 16); Console.Write("          / ,'    / .'        `.    ,'. ||_,-'         /       |\n");
                Console.SetCursorPosition(x, y + 17); Console.Write("         /,'     /.'           `._,',\"  '|           ,'        '\n");
                Console.SetCursorPosition(x, y + 18); Console.Write("       ,+'      .'            .'\".'    / '          .           .\n");
                Console.SetCursorPosition(x, y + 19); Console.Write("      |         '           .','      |,`.         j            |\n");
                Console.SetCursorPosition(x, y + 20); Console.Write(".\"\"'--+--     .'           | /        '   .        |            |\n");
                Console.SetCursorPosition(x, y + 21); Console.Write(" \\          ,_|             \\'         `._|        |            '\n");
                Console.SetCursorPosition(x, y + 22); Console.Write("  `._     .'    ______      .+---.        `--..    |             .\n");
                Console.SetCursorPosition(x, y + 23); Console.Write("     `. ,'   _.\" |    `-. ,'      `.          |    |             |\n");
                Console.SetCursorPosition(x, y + 24); Console.Write("      |    .' /\\ |    ,' /         |        ,'     '.            |\n");
                Console.SetCursorPosition(x, y + 25); Console.Write("       `--'  /,'\"    /  /          |      ,'        /            |\n");
                Console.SetCursorPosition(x, y + 26); Console.Write("            /.     .' .'           |    ,){    ___  /             |\n");
                Console.SetCursorPosition(x, y + 27); Console.Write("           . |    /  /.  ,---.    j    /. `..'   \"           ,-. |\n");
                Console.SetCursorPosition(x, y + 28); Console.Write("           | |  .'  / |.'     `.  |   / ,\"-..__,...--._     /   \\|\n");
                Console.SetCursorPosition(x, y + 29); Console.Write("           |`-\"' _.' .'|      . .' `-'.'        /     |`..-'     |\n");
                Console.SetCursorPosition(x, y + 30); Console.Write("           `..-\"'--\"/  |    .'| |    '_.-. _.--'     .'.    /\\   |\n");
                Console.SetCursorPosition(x, y + 31); Console.Write("                    ..-'----' |,          '          |.`._ . | _,'\n");
                Console.SetCursorPosition(x, y + 32); Console.Write("                             `                       '    `| ,'\n");
                Console.SetCursorPosition(x, y + 33); Console.Write("                                                            \" \n");
            }

            else if (pokenumber == 112)
            {
                Console.SetCursorPosition(x, y); Console.Write("            ,\".\n");
                Console.SetCursorPosition(x, y + 1); Console.Write("            |--\\\n");
                Console.SetCursorPosition(x, y + 2); Console.Write("            | .'\\   |.\n");
                Console.SetCursorPosition(x, y + 3); Console.Write("            |'  _\\  |' ,.\n");
                Console.SetCursorPosition(x, y + 4); Console.Write("            |,.._ \\_| `.|    .-\"|\n");
                Console.SetCursorPosition(x, y + 5); Console.Write("          .'      .--   `. ,',\" '\n");
                Console.SetCursorPosition(x, y + 6); Console.Write("         '_..._   ..|`    \\ '  /\n");
                Console.SetCursorPosition(x, y + 7); Console.Write("         `     `.       .  /  /\n");
                Console.SetCursorPosition(x, y + 8); Console.Write("          .     ``.     ,' `./\n");
                Console.SetCursorPosition(x, y + 9); Console.Write("          |      `|`.   `-._ `\"\"\".\n");
                Console.SetCursorPosition(x, y + 10); Console.Write("          '       |.'`.     '   '\n");
                Console.SetCursorPosition(x, y + 11); Console.Write("           \\           \\  .'     `__,..\n");
                Console.SetCursorPosition(x, y + 12); Console.Write("            `.                ,.-'    '\n");
                Console.SetCursorPosition(x, y + 13); Console.Write("        _..-' `.     _.'   \"-.|      /\n");
                Console.SetCursorPosition(x, y + 14); Console.Write("    _.-'    |  ,`\"'\"\"   _       `.  .-..\n");
                Console.SetCursorPosition(x, y + 15); Console.Write("  ,\"   |    | .       .'  `     | `.  /  _,..\n");
                Console.SetCursorPosition(x, y + 16); Console.Write(" |     '    ' |      /     |    |   `.`'\"   '                _,..__\n");
                Console.SetCursorPosition(x, y + 17); Console.Write(".'.     `.__..| |\\  /      '    |     \\    /             _,'\\    _.'\n");
                Console.SetCursorPosition(x, y + 18); Console.Write("|,'     ,' _..|.-'\".            |      \\  .            .'.   \\,-'\n");
                Console.SetCursorPosition(x, y + 19); Console.Write(" \\\",  .'  ,`-.      `.          |       \\ `\".       _,'   \\ .'\n");
                Console.SetCursorPosition(x, y + 20); Console.Write("  `\"\"'    ` ._\\      |   _,.'   '        \\ /___,.--\"`.    .'\n");
                Console.SetCursorPosition(x, y + 21); Console.Write("          .`         |,-\"     .+       _  V    `.     \\  /\n");
                Console.SetCursorPosition(x, y + 22); Console.Write("           `-._    _,' `\"-...' ,\\ .\"    `.|      .     \\'\n");
                Console.SetCursorPosition(x, y + 23); Console.Write("              ,`.            .'  /        `.     |    /\n");
                Console.SetCursorPosition(x, y + 24); Console.Write("            ,'   \\\"--.....-\"'   .        .  \\    |  ,'\n");
                Console.SetCursorPosition(x, y + 25); Console.Write("           .    .\"\\           _,|        |   .   |.'\n");
                Console.SetCursorPosition(x, y + 26); Console.Write("           |  ,'   `-.____..-\"  |        '   |_..'\n");
                Console.SetCursorPosition(x, y + 27); Console.Write("           | |       /`._      _|         \\  |\n");
                Console.SetCursorPosition(x, y + 28); Console.Write("          ,. .       \\   `-.-'\"  .         \\ |\n");
                Console.SetCursorPosition(x, y + 29); Console.Write("        .' |,-`     _/       `'\"\"-`.        `.\n");
                Console.SetCursorPosition(x, y + 30); Console.Write("       -'\".'  \\_,-\"\"                |.     .. |\n");
                Console.SetCursorPosition(x, y + 31); Console.Write("         ''\"'\"\"                     ' |  ,'  \\|\n");
                Console.SetCursorPosition(x, y + 32); Console.Write("                                   | .'..|    |\n");
                Console.SetCursorPosition(x, y + 33); Console.Write("                                   '\"     `... \n");
            }

            else if (pokenumber == 113)
            {
                Console.SetCursorPosition(x, y); Console.Write("\n");
                Console.SetCursorPosition(x, y + 1); Console.Write("                    _,.-''\"\"\"`-._\n");
                Console.SetCursorPosition(x, y + 2); Console.Write("                  ,\"             `._\n");
                Console.SetCursorPosition(x, y + 3); Console.Write("                ,'   ..     .       `.\n");
                Console.SetCursorPosition(x, y + 4); Console.Write("              .'     ||     ||        `._\n");
                Console.SetCursorPosition(x, y + 5); Console.Write("   ,.....---'\"                         `._`-..._\n");
                Console.SetCursorPosition(x, y + 6); Console.Write("   `._  _,.-\"/        `\"--'         `  `. `._   `\"'-.\n");
                Console.SetCursorPosition(x, y + 7); Console.Write("  __..-'   ,' /                      \\   `.  `-.__.-'\n");
                Console.SetCursorPosition(x, y + 8); Console.Write("`._    __,'  ,                        `.   `.    \"--.\n");
                Console.SetCursorPosition(x, y + 9); Console.Write("   `\"'.'   .'       _,.+..              `.   `.-...-'\n");
                Console.SetCursorPosition(x, y + 10); Console.Write("    ,'  _,'     _.-\"   A  `-._            `._  `-.\n");
                Console.SetCursorPosition(x, y + 11); Console.Write("    `\"+'       '     ,' `     `-             \"''-'\n");
                Console.SetCursorPosition(x, y + 12); Console.Write("      '            ,' ___`.                   |\n");
                Console.SetCursorPosition(x, y + 13); Console.Write("     .            ' .`   `.`.                 |  _,.\n");
                Console.SetCursorPosition(x, y + 14); Console.Write("     |            ,'       `                  |,\" ,'\n");
                Console.SetCursorPosition(x, y + 15); Console.Write("     |           /          \\                 |  /\n");
                Console.SetCursorPosition(x, y + 16); Console.Write("     |          j            '                | /\n");
                Console.SetCursorPosition(x, y + 17); Console.Write("     '          |'`\"\"''\"`'\"\"\"|                |/\n");
                Console.SetCursorPosition(x, y + 18); Console.Write("      .         `            '               ,'\n");
                Console.SetCursorPosition(x, y + 19); Console.Write("       `.        \\          /              ,'\n");
                Console.SetCursorPosition(x, y + 20); Console.Write("         `._      `._     ,'             .'\n");
                Console.SetCursorPosition(x, y + 21); Console.Write("            `._      `\"\"\"'             .'\n");
                Console.SetCursorPosition(x, y + 22); Console.Write("          _,'  `-.....___________...-'`-.\n");
                Console.SetCursorPosition(x, y + 23); Console.Write("         `...---'               `--.....-' \n");
            }

            else if (pokenumber == 114)
            {
                Console.SetCursorPosition(x, y); Console.Write("                      _____         ____\n");
                Console.SetCursorPosition(x, y + 1); Console.Write("                   ,\"'     `.   ,-\"'    `\".     ,.\n");
                Console.SetCursorPosition(x, y + 2); Console.Write("                  .  ,---.   |,'   _...    .    | `.\n");
                Console.SetCursorPosition(x, y + 3); Console.Write("             _.---'`'\"-._ |  /   .'.---`.  '    '  |\n");
                Console.SetCursorPosition(x, y + 4); Console.Write("           ,'            `| /...-._____ |  |`\".'   |\n");
                Console.SetCursorPosition(x, y + 5); Console.Write("          /    _,---+-.   ,'       `-. ||  '   `..-.._\n");
                Console.SetCursorPosition(x, y + 6); Console.Write("         .   ,`._    `.`,'.   _...    \\` .  `.   `.   `-.\n");
                Console.SetCursorPosition(x, y + 7); Console.Write("         |_,.-...`---\"'|  ,`.|  .\"`    \\`.`.  `.   \\     \\\n");
                Console.SetCursorPosition(x, y + 8); Console.Write(" ,      ,'             |  |  |  |  \\    \\ `.`._ `.  \\`.   .\n");
                Console.SetCursorPosition(x, y + 9); Console.Write("| \\    '     __......-\"|  |  |  |`._\\    '. `\"-`. .  . \\,\"'-._\n");
                Console.SetCursorPosition(x, y + 10); Console.Write("|  `\"'|   .\"'   ___    |  |  '  `-...\\...|_`.._ | |..){-'      `.\n");
                Console.SetCursorPosition(x, y + 11); Console.Write(" `-..-|  .    .\"  _`+.,'  |   `._          `-.,'  |     ,+\"|`. |\n");
                Console.SetCursorPosition(x, y + 12); Console.Write(" ,'  ,|  |  ,' ,\"'     __,'      `'\"\"\"\"'`-.   .  ,'...-' | | | |\n");
                Console.SetCursorPosition(x, y + 13); Console.Write(".   / `  |  | .   ,-'\"'             ____   `. |-'-.| |   ',' `'\n");
                Console.SetCursorPosition(x, y + 14); Console.Write("|  |   \\ |  | | .'   ,-'\"\"'-.    ,'\"    `.  | |.   | |__     ,.\n");
                Console.SetCursorPosition(x, y + 15); Console.Write("'  `.   `|  ' | |  .'        \\  .         | | `.`. '  . `\"-.' |\n");
                Console.SetCursorPosition(x, y + 16); Console.Write(" \\ |\\`-..|   .`.|  |    ()    | |   ()    ' `._ ,.' \\  `---' ,\n");
                Console.SetCursorPosition(x, y + 17); Console.Write("  `| `--\"    | |   '          ' '        .    .' |   |.____,' \\\n");
                Console.SetCursorPosition(x, y + 18); Console.Write("   `.       ,' '    `.     _,'   `. ___.'_..,'   |   |  | `.   .\n");
                Console.SetCursorPosition(x, y + 19); Console.Write("     `-...-' .' _...  `---\" _....._  _.'\"    `..'|   |  |  |   |\n");
                Console.SetCursorPosition(x, y + 20); Console.Write("    ,'    _.\" ,'    |    .-' ___   `'   _..    `/|   |`.|  |   '\n");
                Console.SetCursorPosition(x, y + 21); Console.Write("   '    ,'/  /   _,.'  ,' .-'   `\".  \\,'   `.   | .  `  .  '  /\n");
                Console.SetCursorPosition(x, y + 22); Console.Write("  .   ,` ' .'   '    |/  /   ____/ \\  . ,-\"'|   '-.`.__,',' ,'\n");
                Console.SetCursorPosition(x, y + 23); Console.Write("  |   | |  ||  |`-..\"/  /`.'\"   /   . |'  _,'  /.  `. .\"' .'`..__,.\n");
                Console.SetCursorPosition(x, y + 24); Console.Write("  `   `.|_..'  `._  /  /   `._ /   /| | ,'/   /  \\   \\  ,\"._    _,'\n");
                Console.SetCursorPosition(x, y + 25); Console.Write("  ,`.        \\    `-._/ `.    `-.,' | |. /  ,'   /.   \\'  __`--\"\n");
                Console.SetCursorPosition(x, y + 26); Console.Write("  |  |-..,.\"| `-._    `.  `,      \",  '-j  .   ,',`.   `\"'  '\n");
                Console.SetCursorPosition(x, y + 27); Console.Write("  |  |   `. `-../ `-.   `.' `\"+-..' .'  |  |_,'.\"| |`.   _,'\n");
                Console.SetCursorPosition(x, y + 28); Console.Write("  '   `-._ `._.'   / `.  | _,'  |\"'|`-..|  |   | | |  `\"\"\n");
                Console.SetCursorPosition(x, y + 29); Console.Write("   `._    `\"'   _.|__.-| |\" `---|  '.   |  '.,'  `.'\n");
                Console.SetCursorPosition(x, y + 30); Console.Write("      `-.....-\"'  |___,  '       `. \\`+-`.   `.\n");
                Console.SetCursorPosition(x, y + 31); Console.Write("             .'   '  /  /          \"'/    `\"--'-._\n");
                Console.SetCursorPosition(x, y + 32); Console.Write("           _,){  ,'   `-\".           .             `._\n");
                Console.SetCursorPosition(x, y + 33); Console.Write("        ,-'   `\"         |          |                `.\n");
                Console.SetCursorPosition(x, y + 34); Console.Write("      ,'                 |          '                  `.\n");
                Console.SetCursorPosition(x, y + 35); Console.Write("     /                 _,'           `._                |\n");
                Console.SetCursorPosition(x, y + 36); Console.Write("    |               _,\"                 `-..__        _,'\n");
                Console.SetCursorPosition(x, y + 37); Console.Write("    `.        __..-'                          `\"\"\"`\"''\n");
                Console.SetCursorPosition(x, y + 38); Console.Write("      `-----\"' \n");
            }

            else if (pokenumber == 115)
            {
                Console.SetCursorPosition(x, y); Console.Write("                               |`.\n");
                Console.SetCursorPosition(x, y + 1); Console.Write("                               |  \\\n");
                Console.SetCursorPosition(x, y + 2); Console.Write("                          __   |   `.\n");
                Console.SetCursorPosition(x, y + 3); Console.Write("                        _|  \\  |     .\n");
                Console.SetCursorPosition(x, y + 4); Console.Write("                      .' \\`-.. `     | _____\n");
                Console.SetCursorPosition(x, y + 5); Console.Write("                      ,`-`  `.| \\   ,\"'     `-.     ______\n");
                Console.SetCursorPosition(x, y + 6); Console.Write("                     |        |  \\.'           `.,\"'      `\",'\n");
                Console.SetCursorPosition(x, y + 7); Console.Write("                     `.     __| ,'|             |        _.'\n");
                Console.SetCursorPosition(x, y + 8); Console.Write("                      '    .  ){/  |             |......-'\n");
                Console.SetCursorPosition(x, y + 9); Console.Write("                     j      `./  .'\\            | |\n");
                Console.SetCursorPosition(x, y + 10); Console.Write("                    ||      ,/   ' \"'         ,'  |\n");
                Console.SetCursorPosition(x, y + 11); Console.Write("                    ||     . `.   `.|       .'|   |\n");
                Console.SetCursorPosition(x, y + 12); Console.Write("                    '+     `.  `.   '     ,|__'   '\n");
                Console.SetCursorPosition(x, y + 13); Console.Write("                     `    .'    \\`.  `\"-.'      .'_\n");
                Console.SetCursorPosition(x, y + 14); Console.Write("                      \\   `   ,  `.`.    _..-|     `---....-\"-._\n");
                Console.SetCursorPosition(x, y + 15); Console.Write("                       \\ . `.' _..---`.._..-\"|   |              `,\n");
                Console.SetCursorPosition(x, y + 16); Console.Write("                        /    .'          `.  |  ,` ._           /|\n");
                Console.SetCursorPosition(x, y + 17); Console.Write("                      .'    /              \\ `-|     |        ,'|'\n");
                Console.SetCursorPosition(x, y + 18); Console.Write("                     '/    /                .  '    .' ,-----'\"\"'\n");
                Console.SetCursorPosition(x, y + 19); Console.Write("                _ ,.-'    /       _.._      |   \\.-'--'\n");
                Console.SetCursorPosition(x, y + 20); Console.Write("              .\"         /   ,..\"'`\\/ `     |   |\n");
                Console.SetCursorPosition(x, y + 21); Console.Write("             /|         j  _,`/    _| \"`.   |   |\\\n");
                Console.SetCursorPosition(x, y + 22); Console.Write("            j `-.       |,' `.    |.|    .  |   .|\n");
                Console.SetCursorPosition(x, y + 23); Console.Write("            |    |    . |     `._.`-|`.  |  |    '\n");
                Console.SetCursorPosition(x, y + 24); Console.Write("            |    |  _ ` |       `..'\"`\"\"' \\ '     `.\n");
                Console.SetCursorPosition(x, y + 25); Console.Write("         _.-'\"\"\"\"' | `\"\\`                  .       |.\n");
                Console.SetCursorPosition(x, y + 26); Console.Write("      ,-'|   .\"`.  `.   \\`.                '      j  .\n");
                Console.SetCursorPosition(x, y + 27); Console.Write("    _'_..'   |   ){-.--.' `.`._           ,'       |  |\n");
                Console.SetCursorPosition(x, y + 28); Console.Write("  .'          `+'_  `.|      _`.._____,-' ,\"`.    `._/\n");
                Console.SetCursorPosition(x, y + 29); Console.Write(" /         _____  `-.__..--\"\"         `-.'    \\     |\n");
                Console.SetCursorPosition(x, y + 30); Console.Write(".    _,.-\"'     ``\"\"'                    `-..-\"  ___/\\\n");
                Console.SetCursorPosition(x, y + 31); Console.Write("'.,-'                                      .',-.'   |'\n");
                Console.SetCursorPosition(x, y + 32); Console.Write("                                           ,'   `.  |\n");
                Console.SetCursorPosition(x, y + 33); Console.Write("                                                  `\" \n");
            }

            else if (pokenumber == 116)
            {
                Console.SetCursorPosition(x, y); Console.Write("                          _,..----.._\n");
                Console.SetCursorPosition(x, y + 1); Console.Write(" ,\"''-.               _.-'           `\"-._\n");
                Console.SetCursorPosition(x, y + 2); Console.Write(".,-.   `._          ,'    ,---.           `.             _,..\n");
                Console.SetCursorPosition(x, y + 3); Console.Write("||  \\     `._     ,'    .' |   .            `.     _,.-\"' _,'\n");
                Console.SetCursorPosition(x, y + 4); Console.Write("||   .       `-._.      |.'|   |            _...-\"'    _,'\n");
                Console.SetCursorPosition(x, y + 5); Console.Write("''   |           '      |  '   |         --'       _,-'\n");
                Console.SetCursorPosition(x, y + 6); Console.Write(" \\\\  |                  '.'    |                 ,'\n");
                Console.SetCursorPosition(x, y + 7); Console.Write("  .`.'                   `.    '                (\n");
                Console.SetCursorPosition(x, y + 8); Console.Write("   `.____                  `--'                  `--..__\n");
                Console.SetCursorPosition(x, y + 9); Console.Write("         ``\"-.._                                        ``--..__\n");
                Console.SetCursorPosition(x, y + 10); Console.Write("                |\"                                              ``.\n");
                Console.SetCursorPosition(x, y + 11); Console.Write("                `                             .--\"''\"\"\"'`--------'\n");
                Console.SetCursorPosition(x, y + 12); Console.Write("                 `.                           \\\n");
                Console.SetCursorPosition(x, y + 13); Console.Write("     ,-\"'`-._      `-._                 `._    `.\n");
                Console.SetCursorPosition(x, y + 14); Console.Write("    /        `.     ,._`-.._          _,'  `-.   .\n");
                Console.SetCursorPosition(x, y + 15); Console.Write("   .    _      `.   |  `\"-._`     .-\"'        `-. `.\n");
                Console.SetCursorPosition(x, y + 16); Console.Write("   |     `\"-._   `. |--.._  `._   \\              `. .\n");
                Console.SetCursorPosition(x, y + 17); Console.Write("   |          `-._ `|     `-._ `-. `.              `'\n");
                Console.SetCursorPosition(x, y + 18); Console.Write("   `        ._    `/'         `-. `. .\n");
                Console.SetCursorPosition(x, y + 19); Console.Write("    \\         `\"-.'  .-....__    `. `.`.\n");
                Console.SetCursorPosition(x, y + 20); Console.Write("     .          /    '       `\"-.._   | \\\n");
                Console.SetCursorPosition(x, y + 21); Console.Write("      `.       /------\\            `  |  \\\n");
                Console.SetCursorPosition(x, y + 22); Console.Write("        `.___./        `              '   .\n");
                Console.SetCursorPosition(x, y + 23); Console.Write("             ,          `._        ,-'    |\n");
                Console.SetCursorPosition(x, y + 24); Console.Write("             |.-\"''\"\"'--.._`\"---'\"/       |\n");
                Console.SetCursorPosition(x, y + 25); Console.Write("             |  ______      `\"-../        |\n");
                Console.SetCursorPosition(x, y + 26); Console.Write("             .\"'      `\".       /         '\n");
                Console.SetCursorPosition(x, y + 27); Console.Write("           ,'            .     /         .\n");
                Console.SetCursorPosition(x, y + 28); Console.Write("          .              |   .'         /\n");
                Console.SetCursorPosition(x, y + 29); Console.Write("          |       ,'     |.-'          /\n");
                Console.SetCursorPosition(x, y + 30); Console.Write("          |       |      '            '\n");
                Console.SetCursorPosition(x, y + 31); Console.Write("           .       `-..-\"          _,'\n");
                Console.SetCursorPosition(x, y + 32); Console.Write("            `.                  _,\"\n");
                Console.SetCursorPosition(x, y + 33); Console.Write("              `._          __.-'\n");
                Console.SetCursorPosition(x, y + 34); Console.Write("                 `'------\"' \n");
            }

            else if (pokenumber == 117)
            {
                Console.SetCursorPosition(x, y); Console.Write("                                .                ,'\n");
                Console.SetCursorPosition(x, y + 1); Console.Write("                               /|               /,\n");
                Console.SetCursorPosition(x, y + 2); Console.Write("                              'j               / |\n");
                Console.SetCursorPosition(x, y + 3); Console.Write("                             / |              / j\n");
                Console.SetCursorPosition(x, y + 4); Console.Write("                            .  |             /  |\n");
                Console.SetCursorPosition(x, y + 5); Console.Write("             .              |  |      _     /  j                _,..\n");
                Console.SetCursorPosition(x, y + 6); Console.Write("   ,         |\\            j   |   _,\",'   /   |           _.-\"',-'\n");
                Console.SetCursorPosition(x, y + 7); Console.Write("   '`        | `.      ,.  |   | ,'  '    /   j        _.-', _.'\n");
                Console.SetCursorPosition(x, y + 8); Console.Write("    \\`.      |   `...-\" '  |   \"'  ,'    /    |    _.-' _.','\n");
                Console.SetCursorPosition(x, y + 9); Console.Write("     \\ \\     |           \\ |      /     /     L_.-'  _,' .'\n");
                Console.SetCursorPosition(x, y + 10); Console.Write("      \\ `. ,\"`            v      `.__  /           ,' _.'\n");
                Console.SetCursorPosition(x, y + 11); Console.Write("       \\  \\   .           |        .' /         _,' ,'\n");
                Console.SetCursorPosition(x, y + 12); Console.Write("        \\  `  '           '      ,'  /        ,'  ,'\n");
                Console.SetCursorPosition(x, y + 13); Console.Write("      .--`.    \\   .     .     .'---/      ,-'   (\n");
                Console.SetCursorPosition(x, y + 14); Console.Write("       `.  \\| | .  |    |`.  .'    /    _,'       `-..__\n");
                Console.SetCursorPosition(x, y + 15); Console.Write("         `. | ' '  |    ' |  |        ,'                `\"---...__\n");
                Console.SetCursorPosition(x, y + 16); Console.Write("          .'`. ` \\ '   ..'|  |    `,              __________......\"\n");
                Console.SetCursorPosition(x, y + 17); Console.Write("          `\"--`.`.\\ ` `---' ,    -.    -'\"'\"\"`''\"\"\n");
                Console.SetCursorPosition(x, y + 18); Console.Write("                |\"\"`      .'     /  .._.'  .  `\"`.\n");
                Console.SetCursorPosition(x, y + 19); Console.Write("       __..--'\"\" `.       |`__|\\.     |  __`     |\n");
                Console.SetCursorPosition(x, y + 20); Console.Write(" _,.-\"'            \\      | |     .  .'    |  --.'\\\n");
                Console.SetCursorPosition(x, y + 21); Console.Write("`-----\"`'\"\"''+.  _,'|     |/|      `-'  .  |    |  \\\n");
                Console.SetCursorPosition(x, y + 22); Console.Write("           .' _,\"   |     ' `..'_......._`\"  .  '   .\n");
                Console.SetCursorPosition(x, y + 23); Console.Write("         .'_,\"   _. |    _.'  ,'         `.   `'    |\n");
                Console.SetCursorPosition(x, y + 24); Console.Write("        /.\"  _.-'  '`.--\"   .'             \\  /     |\n");
                Console.SetCursorPosition(x, y + 25); Console.Write("      .''_.-'     .  /     /        __      .'      |\n");
                Console.SetCursorPosition(x, y + 26); Console.Write("    ,'_.'         ' /     .       ,\"  `.    |       |\n");
                Console.SetCursorPosition(x, y + 27); Console.Write("   .-'           / /      |       |    '    |       '\n");
                Console.SetCursorPosition(x, y + 28); Console.Write("                . /       '       '         '      /\n");
                Console.SetCursorPosition(x, y + 29); Console.Write("                ,'         \\       .       /      /\n");
                Console.SetCursorPosition(x, y + 30); Console.Write("                            \\       `-...-'     .'\n");
                Console.SetCursorPosition(x, y + 31); Console.Write("                             `.              _,'\n");
                Console.SetCursorPosition(x, y + 32); Console.Write("                               `._        _,\"\n");
                Console.SetCursorPosition(x, y + 33); Console.Write("                                  `\"----\"' \n");
            }

            else if (pokenumber == 118)
            {
                Console.SetCursorPosition(x, y); Console.Write("                                            _.--.\n");
                Console.SetCursorPosition(x, y + 1); Console.Write("                                      __  ,'     \\\n");
                Console.SetCursorPosition(x, y + 2); Console.Write("                                    ,'  `\"        .\n");
                Console.SetCursorPosition(x, y + 3); Console.Write("                                   |              |\n");
                Console.SetCursorPosition(x, y + 4); Console.Write("                        ,'`.      ,'              |\n");
                Console.SetCursorPosition(x, y + 5); Console.Write("                  .._  /    \\   .'                |\n");
                Console.SetCursorPosition(x, y + 6); Console.Write("                 /   `'      `. |     .          .'\n");
                Console.SetCursorPosition(x, y + 7); Console.Write("                .   |   _...__ |'    .           |\n");
                Console.SetCursorPosition(x, y + 8); Console.Write("                |   |.\"'      `|     '           .\n");
                Console.SetCursorPosition(x, y + 9); Console.Write("                |  ,'           \\   /            `.\n");
                Console.SetCursorPosition(x, y + 10); Console.Write("         '`.   .| .              \\ j               |\n");
                Console.SetCursorPosition(x, y + 11); Console.Write("          \\ `./ | |               .|              ,\n");
                Console.SetCursorPosition(x, y + 12); Console.Write("           \\  . `.|                .            .'\n");
                Console.SetCursorPosition(x, y + 13); Console.Write("            \\  `.                  '           _|_\n");
                Console.SetCursorPosition(x, y + 14); Console.Write("             \\   `.                 .        .'__ `\n");
                Console.SetCursorPosition(x, y + 15); Console.Write("            / .   |                 |        |\"  | `-...._\n");
                Console.SetCursorPosition(x, y + 16); Console.Write("           .      |       ,.--.     |     _.'    |        `.\n");
                Console.SetCursorPosition(x, y + 17); Console.Write(" .-._      |   `  |      /     \\    |.--'\"       '         |\n");
                Console.SetCursorPosition(x, y + 18); Console.Write(" |   `'\"\"'\"|    `       .     .'|                 \\        |\n");
                Console.SetCursorPosition(x, y + 19); Console.Write(" |        ||            |    /| |                  \\       |\n");
                Console.SetCursorPosition(x, y + 20); Console.Write(" '        ||            |  ,d | '                  |       |\n");
                Console.SetCursorPosition(x, y + 21); Console.Write(".         ){`             .'\"-' /  /`.            _,'`.      `.\n");
                Console.SetCursorPosition(x, y + 22); Console.Write("|          \\.             `..-'  / \\ \\       .\"\"'     `.      |\n");
                Console.SetCursorPosition(x, y + 23); Console.Write("'._         '                   /   \\ `.    /           `    .'\n");
                Console.SetCursorPosition(x, y + 24); Console.Write("   `-.     .'`. .._____        /     \\  \\   |                |\n");
                Console.SetCursorPosition(x, y + 25); Console.Write("    _|     |   \\  ___  '    _,'       .  `  .`-._            '\n");
                Console.SetCursorPosition(x, y + 26); Console.Write("  ,' |     |    `. \"\" / __,\"           `-..'     `.           `.\n");
                Console.SetCursorPosition(x, y + 27); Console.Write("  |  `-----'     |\"''\"'\"                          '            |\n");
                Console.SetCursorPosition(x, y + 28); Console.Write("  '              |                                 .           '\n");
                Console.SetCursorPosition(x, y + 29); Console.Write("   \\          _.'                                  |          |\n");
                Console.SetCursorPosition(x, y + 30); Console.Write("   |     ,-\"''                                      ._   _..  `.\n");
                Console.SetCursorPosition(x, y + 31); Console.Write("   |    /                                             `\"'   `.  '\n");
                Console.SetCursorPosition(x, y + 32); Console.Write("   `...'                                                      `\" \n");
            }

            else if (pokenumber == 119)
            {
                Console.SetCursorPosition(x, y); Console.Write("                     ,-'\"\"\"--..__  .'\\\n");
                Console.SetCursorPosition(x, y + 1); Console.Write("                    .            `\"   \\\n");
                Console.SetCursorPosition(x, y + 2); Console.Write("                    '                  \\\n");
                Console.SetCursorPosition(x, y + 3); Console.Write("      _____          .                  .\n");
                Console.SetCursorPosition(x, y + 4); Console.Write("  ,\"\"'     `'--.._    \\                 '\n");
                Console.SetCursorPosition(x, y + 5); Console.Write(" /                `._  \\  \\    +.     ){' .\n");
                Console.SetCursorPosition(x, y + 6); Console.Write(".                    `._`. `.            |\n");
                Console.SetCursorPosition(x, y + 7); Console.Write("|                       `-`  .      _ .  |\n");
                Console.SetCursorPosition(x, y + 8); Console.Write("|                      '-._`._\\  \\ ' ||  |\n");
                Console.SetCursorPosition(x, y + 9); Console.Write("`.                         `. `.  . \\||  '\n");
                Console.SetCursorPosition(x, y + 10); Console.Write("  `.                 .  ...  `._`.|  '` .\n");
                Console.SetCursorPosition(x, y + 11); Console.Write("    `._              `   `.){    `.`.   '|\n");
                Console.SetCursorPosition(x, y + 12); Console.Write("       `.                     '`  `.\\  ||  _,...._\n");
                Console.SetCursorPosition(x, y + 13); Console.Write("         `                   -.     ``.'|,\"       `-._\n");
                Console.SetCursorPosition(x, y + 14); Console.Write("          |                \" ._`-._ . -._`._ |  .     `--..  ...\n");
                Console.SetCursorPosition(x, y + 15); Console.Write("          |           ,....    `-.-'    .'  `.  ;       ,'  /   \\\n");
                Console.SetCursorPosition(x, y + 16); Console.Write("          |           `\"\"'   \"' /     .\"_     `.      .'   .     '\n");
                Console.SetCursorPosition(x, y + 17); Console.Write("          |       _       _,.-'/  .      \"\"-.   .   ,'.   j      .\n");
                Console.SetCursorPosition(x, y + 18); Console.Write("          |       +'    ,\"    /     +\"    _,.'  |  /.  \\  | . |  |\n");
                Console.SetCursorPosition(x, y + 19); Console.Write("          '           ,'     j  .'     ._ ...   | /  `. \\ |   '  |\n");
                Console.SetCursorPosition(x, y + 20); Console.Write("         ,.`----...._'`.    /|           _..-'  |/  ,-.  \\|  '   |\n");
                Console.SetCursorPosition(x, y + 21); Console.Write("         \".      __  `-.`. / |     +' _.\"  __....._  `.`._| / ,  '\n");
                Console.SetCursorPosition(x, y + 22); Console.Write("           `.   `\"-'      `-.|      .'_,-'\"        _.-\"'/ |/ '  /\n");
                Console.SetCursorPosition(x, y + 23); Console.Write("             \\         `\"-.._`-.   ,-'         ,-\"'   .`. |,' .'\n");
                Console.SetCursorPosition(x, y + 24); Console.Write("              |          `   `-.`./ _.._      |     ,'__ \\| ,'\n");
                Console.SetCursorPosition(x, y + 25); Console.Write("              |       __  +' -- .'.'.--.`.     \\  .','..`.+'\n");
                Console.SetCursorPosition(x, y + 26); Console.Write("              .      `--' .\"_,.\"  |||  | |      `\" | |  ||\n");
                Console.SetCursorPosition(x, y + 27); Console.Write("              `.         _.\"  /\\  || \"\" ||         || \"\"'|\n");
                Console.SetCursorPosition(x, y + 28); Console.Write("                `-...,-\"' ,' /  \\ `.`..'/          ' `..'\n");
                Console.SetCursorPosition(x, y + 29); Console.Write("                   '        /    `. `--'            `.,'\n");
                Console.SetCursorPosition(x, y + 30); Console.Write("                    \\      /       `=+=  ,--------. .'\n");
                Console.SetCursorPosition(x, y + 31); Console.Write("                     `.___,           `.| `.____.','\n");
                Console.SetCursorPosition(x, y + 32); Console.Write("                                         `-.....-' \n");
            }

            else if (pokenumber == 120)
            {
                Console.SetCursorPosition(x, y); Console.Write("                                ..\n");
                Console.SetCursorPosition(x, y + 1); Console.Write("                               .  .\n");
                Console.SetCursorPosition(x, y + 2); Console.Write("                                  '\n");
                Console.SetCursorPosition(x, y + 3); Console.Write("                              ' \\/ '\n");
                Console.SetCursorPosition(x, y + 4); Console.Write("                             /  .  `\n");
                Console.SetCursorPosition(x, y + 5); Console.Write("                            .   |   .\n");
                Console.SetCursorPosition(x, y + 6); Console.Write("                            '   |\n");
                Console.SetCursorPosition(x, y + 7); Console.Write("                                |    '\n");
                Console.SetCursorPosition(x, y + 8); Console.Write("                           '    |\n");
                Console.SetCursorPosition(x, y + 9); Console.Write("..__                      /     |     .\n");
                Console.SetCursorPosition(x, y + 10); Console.Write("'   \"-..__               .      |\n");
                Console.SetCursorPosition(x, y + 11); Console.Write(" `.       `\"--..____..          |      '                  __..--.\n");
                Console.SetCursorPosition(x, y + 12); Console.Write("   ..            |   |..'       |       ..\"-. ____,..---\"'      /\n");
                Console.SetCursorPosition(x, y + 13); Console.Write("    .`.          |   ' \\        |      .'/   /              .','\n");
                Console.SetCursorPosition(x, y + 14); Console.Write("     `.`.        `    \\ `. _,..-'._   , /   .            _.','\n");
                Console.SetCursorPosition(x, y + 15); Console.Write("       `.`.       \\       \"        `\"' /    '          ,' ,'\n");
                Console.SetCursorPosition(x, y + 16); Console.Write("         . `.      .   '              /    /        _,' .'\n");
                Console.SetCursorPosition(x, y + 17); Console.Write("          `. `.     .   \\            /   .'       .\"  .'\n");
                Console.SetCursorPosition(x, y + 18); Console.Write("            `. `.  /`    \\          /   , \\     .' _,'\n");
                Console.SetCursorPosition(x, y + 19); Console.Write("              `  `/  \\    \\        /   /   \\  ,' ,'\n");
                Console.SetCursorPosition(x, y + 20); Console.Write("             ,\"`./    \\  ,-'\"\"'\"-./   /     \\_.-'\n");
                Console.SetCursorPosition(x, y + 21); Console.Write("             |._ `.    ,',-\"\"'\"\"`-.` '    _,' `.\n");
                Console.SetCursorPosition(x, y + 22); Console.Write("             |  `-._  . /          \\`._.-' _.-\"|\n");
                Console.SetCursorPosition(x, y + 23); Console.Write("              `._   `-|.            .|..-\"'    |\n");
                Console.SetCursorPosition(x, y + 24); Console.Write("              /  \\\"._ ||            ||     _,-\".\n");
                Console.SetCursorPosition(x, y + 25); Console.Write("             .    \\  `.|            ||..-''/   |\n");
                Console.SetCursorPosition(x, y + 26); Console.Write("             '     .   `           .'    ,'    '\n");
                Console.SetCursorPosition(x, y + 27); Console.Write("            .       .  .`._      .'`.  .'       .\n");
                Console.SetCursorPosition(x, y + 28); Console.Write("                   .|,'   /\"----\"\\   `._|.      '\n");
                Console.SetCursorPosition(x, y + 29); Console.Write("           '     ,' `. _,\"-.    ,\"'._  .' `.\n");
                Console.SetCursorPosition(x, y + 30); Console.Write("          /    .'  _.'\"     `..'     `\"-.   \\    .\n");
                Console.SetCursorPosition(x, y + 31); Console.Write("         .   ,' _,'                      `.  `.  `\n");
                Console.SetCursorPosition(x, y + 32); Console.Write("         | .'_,'                           `'. `. .\n");
                Console.SetCursorPosition(x, y + 33); Console.Write("         `\"\"'                                 `. `|\n");
                Console.SetCursorPosition(x, y + 34); Console.Write("                                                `\" \n");
            }

            else if (pokenumber == 121)
            {
                Console.SetCursorPosition(x, y); Console.Write("             .\"-.._          ____\n");
                Console.SetCursorPosition(x, y + 1); Console.Write("             \\     `-._     /  /\"\"\"-.\n");
                Console.SetCursorPosition(x, y + 2); Console.Write("              .    `\"-.`-_.'`.j      \\\n");
                Console.SetCursorPosition(x, y + 3); Console.Write("     _________'  .,---'\"\",|   |...___.'\n");
                Console.SetCursorPosition(x, y + 4); Console.Write("   .'          \\ `-.._ ,' |  ,      || \\ ____\n");
                Console.SetCursorPosition(x, y + 5); Console.Write("    `.    __,.-+--'\"_.'  ,^./       ||  |____`\"\"---..__\n");
                Console.SetCursorPosition(x, y + 6); Console.Write("   _,.`\"\"\"__....--.'   .\"  `..___   ||_.'  `.\"\"'\"\"`--- '.\n");
                Console.SetCursorPosition(x, y + 7); Console.Write("  /_.--\"'\"       /   ,'      |   |\"\"'\\  \\    `.       .'\n");
                Console.SetCursorPosition(x, y + 8); Console.Write(" .'             '  .' ___    |   |`\"--\\  \\ ____`.   ,'\n");
                Console.SetCursorPosition(x, y + 9); Console.Write("  `.             \\,.-'   `.  |  j      \\  \\`.`.   ,'\n");
                Console.SetCursorPosition(x, y + 10); Console.Write("    `-.                 /  \\ |  |       \\  \\ `.`.' `._\n");
                Console.SetCursorPosition(x, y + 11); Console.Write("       `._             /   |j  j  ..--.  \\  \\  `.`.   `-._\n");
                Console.SetCursorPosition(x, y + 12); Console.Write("          `._        ,'    ||  | /  \\  `. '  .   `.`.     `.\n");
                Console.SetCursorPosition(x, y + 13); Console.Write("             >.     /      |'. |'    \\   `._,'     `.`.     `.\n");
                Console.SetCursorPosition(x, y + 14); Console.Write("           .\"  `.  /       |   |      \\               .` _..\"\n");
                Console.SetCursorPosition(x, y + 15); Console.Write("         ,\"    ,'`.         |\".'       \\               `.`.\n");
                Console.SetCursorPosition(x, y + 16); Console.Write("       ,'   _,'   |         | |         \\                `.`.\n");
                Console.SetCursorPosition(x, y + 17); Console.Write("     ,'  _,'      '        j j           \\                 \\ .\n");
                Console.SetCursorPosition(x, y + 18); Console.Write("   ,'  ,\"          .       | |          _.\\....___          \\'\n");
                Console.SetCursorPosition(x, y + 19); Console.Write("  '  .'            '       | '         /`   |     `\"\"`---..__|\n");
                Console.SetCursorPosition(x, y + 20); Console.Write(".'_.'               .     j .         '  `.  .\n");
                Console.SetCursorPosition(x, y + 21); Console.Write("|\"                  '     | |       ,'     \\  \\\n");
                Console.SetCursorPosition(x, y + 22); Console.Write(" ''\"''\"\"\"\"''---------.    | |      /        `  \\\n");
                Console.SetCursorPosition(x, y + 23); Console.Write("                     '   .' |    .'          \\  \\\n");
                Console.SetCursorPosition(x, y + 24); Console.Write("                      .  | .    ,'.           `. .\n");
                Console.SetCursorPosition(x, y + 25); Console.Write("                      ' j  |   /   `-.          . \\\n");
                Console.SetCursorPosition(x, y + 26); Console.Write("                       .|  | ,'       `-.        . \\\n");
                Console.SetCursorPosition(x, y + 27); Console.Write("                       `|  |.            `._      \\ \\\n");
                Console.SetCursorPosition(x, y + 28); Console.Write("                        `\"-'                \"._    ` .\n");
                Console.SetCursorPosition(x, y + 29); Console.Write("                                               `._  \\|\n");
                Console.SetCursorPosition(x, y + 30); Console.Write("                                                  `-.| \n");
                Console.SetCursorPosition(x, y + 31); Console.Write("\n");
            }


            else if (pokenumber == 122)
            {
                Console.SetCursorPosition(x, y); Console.Write("               ,---.    ___\n");
                Console.SetCursorPosition(x, y + 1); Console.Write("               |(__)| .',-.`.\n");
                Console.SetCursorPosition(x, y + 2); Console.Write("               `.  j  | \\.'.'\n");
                Console.SetCursorPosition(x, y + 3); Console.Write("               _'  `\"'  ,-'___\n");
                Console.SetCursorPosition(x, y + 4); Console.Write("             ,\"         `\"',--.\\                     _..--.\n");
                Console.SetCursorPosition(x, y + 5); Console.Write("             |           __`..''                _,.-'      `-.\n");
                Console.SetCursorPosition(x, y + 6); Console.Write("   ,-\"\"'`-.. '          (  `\"\"'         _...--\"'        ,.--..'\n");
                Console.SetCursorPosition(x, y + 7); Console.Write(" ,'        .' `._____  ,.`-..--\"\"\"'----.               /\n");
                Console.SetCursorPosition(x, y + 8); Console.Write("/   _..._,'   .\"     \\ `..'|            `.        ___.'\n");
                Console.SetCursorPosition(x, y + 9); Console.Write("'.-\"  .'    ,'        '---\"               `.     /\n");
                Console.SetCursorPosition(x, y + 10); Console.Write("     |    .'.._     ,'                      `.  /\n");
                Console.SetCursorPosition(x, y + 11); Console.Write("      \\   `    `._ /      |  !    !  |        |\"\n");
                Console.SetCursorPosition(x, y + 12); Console.Write("       `.  `.     |   __  |          j  ,--. _|..._\n");
                Console.SetCursorPosition(x, y + 13); Console.Write("         \\   `.\"\"\"\"-.'  `. '           /  ,'\"      `-.\n");
                Console.SetCursorPosition(x, y + 14); Console.Write("          `.   `.    `.  |   _____|   |  /            `.\n");
                Console.SetCursorPosition(x, y + 15); Console.Write("          |`....'     |_,'   `.   '    `.              |\n");
                Console.SetCursorPosition(x, y + 16); Console.Write("          |           |---....____....-\"`        .--.  '\n");
                Console.SetCursorPosition(x, y + 17); Console.Write("           .         ,'                  `..._  (    `'\n");
                Console.SetCursorPosition(x, y + 18); Console.Write("            `--..,.-'      _.--\"\"\"'\"'.   |,\"\".`. ,--.. \\\n");
                Console.SetCursorPosition(x, y + 19); Console.Write("                 |       ,'       .\"\"\"`. ``-\" | |(__)|  `.\n");
                Console.SetCursorPosition(x, y + 20); Console.Write("                 |      .         |(__) `-'   '\"   ,\"     |\n");
                Console.SetCursorPosition(x, y + 21); Console.Write("                / `     |          `--.          .'_,..-\"'\n");
                Console.SetCursorPosition(x, y + 22); Console.Write("               /   `._   ._       .\"\"\"`-         ||\n");
                Console.SetCursorPosition(x, y + 23); Console.Write("               '..._  `._  `-....( (__) __    _.','\n");
                Console.SetCursorPosition(x, y + 24); Console.Write("              ,'    `.   `---.....`..-\"'  `\"'\"_,\".\n");
                Console.SetCursorPosition(x, y + 25); Console.Write("         ,-\"\"`. _.---+..-'            `\"---+-'   `\n");
                Console.SetCursorPosition(x, y + 26); Console.Write("        /      `.                       .\" , \\    \\\n");
                Console.SetCursorPosition(x, y + 27); Console.Write("        ._    ,--.                     |  |  |.    \\\n");
                Console.SetCursorPosition(x, y + 28); Console.Write("         _){--'    `.                   |  `._| `..-|\n");
                Console.SetCursorPosition(x, y + 29); Console.Write("     ,-'\"  `.    .' |                  '    `\"--...'-.\n");
                Console.SetCursorPosition(x, y + 30); Console.Write("    .        `\"\"'_.-'                   `.           |\n");
                Console.SetCursorPosition(x, y + 31); Console.Write("    |         ,-'                         `-.______,.'\n");
                Console.SetCursorPosition(x, y + 32); Console.Write("    '.     _.'\n");
                Console.SetCursorPosition(x, y + 33); Console.Write("      `---' \n");
            }

            else if (pokenumber == 123)
            {
                Console.SetCursorPosition(x, y); Console.Write("           ______\n");
                Console.SetCursorPosition(x, y + 1); Console.Write("       _.-\"______`._             ,.\n");
                Console.SetCursorPosition(x, y + 2); Console.Write("     ,\"_,\"'      `-.`._         /.|\n");
                Console.SetCursorPosition(x, y + 3); Console.Write("   ,',\"   ____      `-.`.___   // |\n");
                Console.SetCursorPosition(x, y + 4); Console.Write("  /.' ,-\"'    `-._     `.   | j.  |  /|\n");
                Console.SetCursorPosition(x, y + 5); Console.Write(" // .'   __...._  `\"--.. `. ' |   | ' '\n");
                Console.SetCursorPosition(x, y + 6); Console.Write("j/  _.-\"'       `._,.\"\".   |  |   |/ '\n");
                Console.SetCursorPosition(x, y + 7); Console.Write("|.-'                    `.'/| |   | /\n");
                Console.SetCursorPosition(x, y + 8); Console.Write("'                        '/ | |   |/\n");
                Console.SetCursorPosition(x, y + 9); Console.Write("                         /  ' '   '\n");
                Console.SetCursorPosition(x, y + 10); Console.Write("                   |.   ` .'/.   /\n");
                Console.SetCursorPosition(x, y + 11); Console.Write("                   | `. ,','.  ,'\n");
                Console.SetCursorPosition(x, y + 12); Console.Write("                   |   \\.' j.-'/\n");
                Console.SetCursorPosition(x, y + 13); Console.Write("                   '   '   '. /\n");
                Console.SetCursorPosition(x, y + 14); Console.Write("                  |          `\"-...__\n");
                Console.SetCursorPosition(x, y + 15); Console.Write("                  |             _..-'\n");
                Console.SetCursorPosition(x, y + 16); Console.Write("                 ,|'      __.-7'   _......____\n");
                Console.SetCursorPosition(x, y + 17); Console.Write("                . |    ,\"/   ,'`.'__........___`-...__\n");
                Console.SetCursorPosition(x, y + 18); Console.Write("                 .    '-'_..' .-\"\"-._         `\"\"'-----`---...___\n");
                Console.SetCursorPosition(x, y + 19); Console.Write("                 |____.-','\" /      /`.._,\"\".                 _.-'\n");
                Console.SetCursorPosition(x, y + 20); Console.Write("              ,\"`| ,'   '   |      .,--. ;--|             _,-\"\n");
                Console.SetCursorPosition(x, y + 21); Console.Write("             |   '.| `-.|   `.     ||   /   '`---.....--\"'.\n");
                Console.SetCursorPosition(x, y + 22); Console.Write("             '     `._  |     `+----`._;'.   `-..____..--'\"\n");
                Console.SetCursorPosition(x, y + 23); Console.Write("              `.    | \"'|__...-|,|       /     `.\n");
                Console.SetCursorPosition(x, y + 24); Console.Write("                |-..|`-.7    /   '      /   |  '|\n");
                Console.SetCursorPosition(x, y + 25); Console.Write("                ' |' `.||`--'    |      \\   | . |\n");
                Console.SetCursorPosition(x, y + 26); Console.Write("                        |        |       \\  ' | |\n");
                Console.SetCursorPosition(x, y + 27); Console.Write("                        `.      .'        .   ' '\n");
                Console.SetCursorPosition(x, y + 28); Console.Write("                          `'-+-\"|`.       '  ' /\n");
                Console.SetCursorPosition(x, y + 29); Console.Write("                             |`-'  \\     /  /.'\n");
                Console.SetCursorPosition(x, y + 30); Console.Write("                             `   _ ,.   / ,'/\n");
                Console.SetCursorPosition(x, y + 31); Console.Write("                              ||'.'`.  / /,'\n");
                Console.SetCursorPosition(x, y + 32); Console.Write("                               `      ' .'\n");
                Console.SetCursorPosition(x, y + 33); Console.Write("                                     /.' \n");
            }

            else if (pokenumber == 124)
            {
                Console.SetCursorPosition(x, y); Console.Write("                _   _,.-.' .-.\n");
                Console.SetCursorPosition(x, y + 1); Console.Write("            _ .' |,'   .\"\".| |.\"\"._\n");
                Console.SetCursorPosition(x, y + 2); Console.Write("           ( || ,',\"\". `._`' `  '  `.\n");
                Console.SetCursorPosition(x, y + 3); Console.Write("           `\\ | `\" .-\"`-..`     .    `.\n");
                Console.SetCursorPosition(x, y + 4); Console.Write("            |     `..--.._       |     \\\n");
                Console.SetCursorPosition(x, y + 5); Console.Write("          _,|      _...'_.'     ,+.     `.\n");
                Console.SetCursorPosition(x, y + 6); Console.Write("     ,\"\"'|   `...-'..\"\"(__.._ -\"   `\"--.. `.\n");
                Console.SetCursorPosition(x, y + 7); Console.Write("    |`._,'  ,'  /\\ .'\"\"` .'\"\"`. `.    |  `. \\\n");
                Console.SetCursorPosition(x, y + 8); Console.Write("    '      / / /  ||    ||    |.`.`.   .   | \\\n");
                Console.SetCursorPosition(x, y + 9); Console.Write("     `.__,'-._'  /|` -\"'  `-.'  \\ \\ \\   `\"-'  \\\n");
                Console.SetCursorPosition(x, y + 10); Console.Write("      ' `.   /  /_| | |'\"\"| | .-\"\"'`'\"`-,.-\"\\  .\n");
                Console.SetCursorPosition(x, y + 11); Console.Write("     . / .\\ .  /  | | `._.' ||        ,'     \\  \\\n");
                Console.SetCursorPosition(x, y + 12); Console.Write("    ' / / |/  /_.-+._`-..--\"-.       .   .    \\  `\n");
                Console.SetCursorPosition(x, y + 13); Console.Write("   / /.'  '  ,'\"\"'-. `\".\"'\"\"'`..     |.        \\  \\\n");
                Console.SetCursorPosition(x, y + 14); Console.Write("  / . |  j  .       . |        |\\__,\" |.  `    '   \\\n");
                Console.SetCursorPosition(x, y + 15); Console.Write(" .  | |  |  |       ' |        '|   | ' `  \\    \\   .\n");
                Console.SetCursorPosition(x, y + 16); Console.Write(" |    |  |  `.____,'   ..____,' |   |    .       \\\n");
                Console.SetCursorPosition(x, y + 17); Console.Write(" |    |  |  | ._  _..---._   _,'    |       .        '\n");
                Console.SetCursorPosition(x, y + 18); Console.Write(" |    |  |  | | \"\"  .    |`\"'   \\ `.|     '  '  '     .\n");
                Console.SetCursorPosition(x, y + 19); Console.Write(" |    |  |  | |     |    |       `  `      .  .  \\    |\n");
                Console.SetCursorPosition(x, y + 20); Console.Write(" |    |  |  | |     '    |        \\  `.    |  |   .   |\n");
                Console.SetCursorPosition(x, y + 21); Console.Write(" '    '  |  | |      .   `         \\   \\   |  |   |   |\n");
                Console.SetCursorPosition(x, y + 22); Console.Write("  \\      `  | |      |              .   `. |  |   |   |\n");
                Console.SetCursorPosition(x, y + 23); Console.Write("   \\      \\ ' |      `    '          `    `+..|___|___|_........\n");
                Console.SetCursorPosition(x, y + 24); Console.Write("    \\      \\ \\|       '    .           `.    `.                 |\n");
                Console.SetCursorPosition(x, y + 25); Console.Write("     `.     \\ .        .   `             `.    `-.            .'\n");
                Console.SetCursorPosition(x, y + 26); Console.Write("    _,'`.    \\'         .   \\              `-.._  `._       ,'\n");
                Console.SetCursorPosition(x, y + 27); Console.Write(" _.\"     `._ `.`        |    .                       `._   .\n");
                Console.SetCursorPosition(x, y + 28); Console.Write("`._       _,`\"--`.      |     .                         `. |\n");
                Console.SetCursorPosition(x, y + 29); Console.Write("   `-._ ,'              |      `.                         `|_\n");
                Console.SetCursorPosition(x, y + 30); Console.Write("      ,'         |      |        `.                          `.\n");
                Console.SetCursorPosition(x, y + 31); Console.Write("    .'   __...__.|      |          \\ __..._     _,..,.__       `.\n");
                Console.SetCursorPosition(x, y + 32); Console.Write("    `-`\"'        `._..--'-.__      .'      `-..'        ``'\"--..-'\n");
                Console.SetCursorPosition(x, y + 33); Console.Write("                             `\"---' \n");
            }

            else if (pokenumber == 125)
            {
                Console.SetCursorPosition(x, y); Console.Write("              '\n");
                Console.SetCursorPosition(x, y + 1); Console.Write("             .\n");
                Console.SetCursorPosition(x, y + 2); Console.Write("             | '\n");
                Console.SetCursorPosition(x, y + 3); Console.Write("             | |\n");
                Console.SetCursorPosition(x, y + 4); Console.Write("          .  ` '                              .\n");
                Console.SetCursorPosition(x, y + 5); Console.Write("          '`. . .          .--.              , .\n");
                Console.SetCursorPosition(x, y + 6); Console.Write("       ..  `.`| `....___  '   |            ,_' |\n");
                Console.SetCursorPosition(x, y + 7); Console.Write("      |  |   .    _,   .`-`,-\"          ,.'    '-.\n");
                Console.SetCursorPosition(x, y + 8); Console.Write("      `..`._,'` .'.   '  ,'            /    .....|\n");
                Console.SetCursorPosition(x, y + 9); Console.Write("          `.'  ','      '  `-._      ,'     `----'\n");
                Console.SetCursorPosition(x, y + 10); Console.Write("          ,'| '/               `.  ,'   \\ .-\"\".   \\\n");
                Console.SetCursorPosition(x, y + 11); Console.Write("        |' |`'/ .|               `.     .'  _,'_.\"'\n");
                Console.SetCursorPosition(x, y + 12); Console.Write("       /   `.' /_|  __       _...-'   .' |.' .\"    \\\n");
                Console.SetCursorPosition(x, y + 13); Console.Write("     ,' `-.   '\" .-\"V `-.  ,'       ,'   |    `-'\"\"'\n");
                Console.SetCursorPosition(x, y + 14); Console.Write("    ,--.'. `.   /      / ,' ,      /`.   |          |\n");
                Console.SetCursorPosition(x, y + 15); Console.Write("  .'---'  `./\"\"|'.    / /  /      '   `-.|          |\n");
                Console.SetCursorPosition(x, y + 16); Console.Write(" /         /   `-....','  /              `.|    | . |\n");
                Console.SetCursorPosition(x, y + 17); Console.Write(".|       .'       .'.'   /      _,        .'   .  | '\n");
                Console.SetCursorPosition(x, y + 18); Console.Write("||       |        |/    /    _,'  7    _,\" `---'--\"'        _.._\n");
                Console.SetCursorPosition(x, y + 19); Console.Write("|`  .   /         |    . _.-\"    /   ,\"     |             ,'    `.\n");
                Console.SetCursorPosition(x, y + 20); Console.Write("`.`-', /          |   '.' ,.    /  ,'     ,-'.          .'       |\n");
                Console.SetCursorPosition(x, y + 21); Console.Write("  `.              |   _.-' |   '  /    _,'   |         .\"\"`.   _,'\n");
                Console.SetCursorPosition(x, y + 22); Console.Write("                  '.-'     '  /  /   ,\"      |        ,\"'.  |.\"\n");
                Console.SetCursorPosition(x, y + 23); Console.Write("                   `      .  /  /  ,'        .       /    |,'\n");
                Console.SetCursorPosition(x, y + 24); Console.Write("                 ,\".`.      .  '_.'        _.-`.    ,\"-.  /\n");
                Console.SetCursorPosition(x, y + 25); Console.Write("               .'`._`.`. '  ' ,'          `_.'\"\".  /\".  |'\n");
                Console.SetCursorPosition(x, y + 26); Console.Write("               |.`._`\" .`-.'           .     ___|.'   |'\n");
                Console.SetCursorPosition(x, y + 27); Console.Write("           ,--'  `-.' `|   `\"--..__..-\"' | .\" __|   ,'\n");
                Console.SetCursorPosition(x, y + 28); Console.Write("         ,' )       _,'            `'\"._.'  \"'   `-'\n");
                Console.SetCursorPosition(x, y + 29); Console.Write("        '\",' )__.-'\"                    `.          |.\n");
                Console.SetCursorPosition(x, y + 30); Console.Write("          '\"\"                             `-.  .    | |\n");
                Console.SetCursorPosition(x, y + 31); Console.Write("                                             `| `.-'`-.\n");
                Console.SetCursorPosition(x, y + 32); Console.Write("                                               `.'\n");
                Console.SetCursorPosition(x, y + 33); Console.Write("                                                 ' \n");
            }

            else if (pokenumber == 126)
            {
                Console.SetCursorPosition(x, y); Console.Write("\n");
                Console.SetCursorPosition(x, y + 1); Console.Write("                                                 ,--''''-.\n");
                Console.SetCursorPosition(x, y + 2); Console.Write("                                               ..    `'  `\n");
                Console.SetCursorPosition(x, y + 3); Console.Write("                                                '    .'...'\n");
                Console.SetCursorPosition(x, y + 4); Console.Write("                                            '  ,'){){     |\n");
                Console.SetCursorPosition(x, y + 5); Console.Write("                                               ,..-Y-'  /--\n");
                Console.SetCursorPosition(x, y + 6); Console.Write("                                    .              |' _.'\n");
                Console.SetCursorPosition(x, y + 7); Console.Write("                                  .' .______ ,-'\"|  ,'\n");
                Console.SetCursorPosition(x, y + 8); Console.Write("                           /,  ,. '-'     .-' .\" | '\n");
                Console.SetCursorPosition(x, y + 9); Console.Write("                          /  \"'  ' -=L;'\\'    `-.'.\n");
                Console.SetCursorPosition(x, y + 10); Console.Write("             ,,          /__       ],L_/'        .'            |\\\n");
                Console.SetCursorPosition(x, y + 11); Console.Write("       |`.  '\\  _,          |         .        ,'          =-. `|\n");
                Console.SetCursorPosition(x, y + 12); Console.Write("       `. ,' |.`            '`-v      `'-.    |             | -,..\n");
                Console.SetCursorPosition(x, y + 13); Console.Write("        _){  \" `\\,.     ___    _'|  ,-,_-  `-..'          .]---> _`'\n");
                Console.SetCursorPosition(x, y + 14); Console.Write("      . ___.   ' /'--.  -.=[----`, |   '-  ,'                | </\n");
                Console.SetCursorPosition(x, y + 15); Console.Write("             ]..b--`. -'- , ----`` |'--v -'            __-- ' ,,\n");
                Console.SetCursorPosition(x, y + 16); Console.Write("            .'|    <\\]``,[ -    '\\\\._  |'  '''`- _  _,|    `''|\n");
                Console.SetCursorPosition(x, y + 17); Console.Write("   \\\" ''L     |   X`.  ` /--,    |  -`.){_ `.    ' TX_,.){'..  ,|\n");
                Console.SetCursorPosition(x, y + 18); Console.Write("   `   |       \"` =. ----  _|    |      ` _ `\\ |=){| /   '-\\ --'\n");
                Console.SetCursorPosition(x, y + 19); Console.Write("   |.   `.          '''-..L    _,'      .' `,.``-() Y.-[ .'\n");
                Console.SetCursorPosition(x, y + 20); Console.Write("   '    .            _. _.. -]-,..-,'    v.   \\|  ` '`'\n");
                Console.SetCursorPosition(x, y + 21); Console.Write("`.'       `.        ' ---.'- /-[  .',_   -.   ,)L\n");
                Console.SetCursorPosition(x, y + 22); Console.Write("  |       .'      __,...-`=..__       '   '     '.\n");
                Console.SetCursorPosition(x, y + 23); Console.Write("   ,\"', .'      -`... _-'      `.     ` ,'      | `.\n");
                Console.SetCursorPosition(x, y + 24); Console.Write("       .`            .'          .     '        |   \\\n");
                Console.SetCursorPosition(x, y + 25); Console.Write("         '           |           |             .'    .\n");
                Console.SetCursorPosition(x, y + 26); Console.Write("        \\ `.         '           '            ,'     |\n");
                Console.SetCursorPosition(x, y + 27); Console.Write("         \\  `.        `         /           .'     _.'\n");
                Console.SetCursorPosition(x, y + 28); Console.Write("          '.  `-.     /`__    ,'.._______,-'--...-` `.\n");
                Console.SetCursorPosition(x, y + 29); Console.Write("            `.   `--..'J  \"'.'         ,'       `._\\` ``-...\n");
                Console.SetCursorPosition(x, y + 30); Console.Write("              `.   .'   `'|'        _,'          |    _    \"-.\n");
                Console.SetCursorPosition(x, y + 31); Console.Write("                `.'|  ..  |     _,-'             `-._| '.---.'\n");
                Console.SetCursorPosition(x, y + 32); Console.Write("                / _,_/  |-`---\"'                     `-..|\n");
                Console.SetCursorPosition(x, y + 33); Console.Write("               `-\"   | .'\n");
                Console.SetCursorPosition(x, y + 34); Console.Write("                     -'\n");
            }

            else if (pokenumber == 127)
            {
                Console.SetCursorPosition(x, y); Console.Write("                        _.-\".\n");
                Console.SetCursorPosition(x, y + 1); Console.Write("                ..-\"\"`.'    '..__,\n");
                Console.SetCursorPosition(x, y + 2); Console.Write("                `-. .'     /  ,.`.\n");
                Console.SetCursorPosition(x, y + 3); Console.Write("                  ,'      '`. .'  `.\n");
                Console.SetCursorPosition(x, y + 4); Console.Write("                 /       .-'        `....\n");
                Console.SetCursorPosition(x, y + 5); Console.Write("              ..'.      .\\             .|\n");
                Console.SetCursorPosition(x, y + 6); Console.Write("              .`./      | `.            '.\n");
                Console.SetCursorPosition(x, y + 7); Console.Write("              |         |  .\\       /|    \\\n");
                Console.SetCursorPosition(x, y + 8); Console.Write("             .'         |)  `\\       '   (_`\n");
                Console.SetCursorPosition(x, y + 9); Console.Write("            ,|          |    `.            |\n");
                Console.SetCursorPosition(x, y + 10); Console.Write("             |          |  _,.-.           |\n");
                Console.SetCursorPosition(x, y + 11); Console.Write("             |          |,'     \\          |\n");
                Console.SetCursorPosition(x, y + 12); Console.Write("             |          |        \\         |\n");
                Console.SetCursorPosition(x, y + 13); Console.Write("             |      \\,  '.        \\        |\n");
                Console.SetCursorPosition(x, y + 14); Console.Write("             '           |         `._     |\n");
                Console.SetCursorPosition(x, y + 15); Console.Write("              \\          |            `-..,+___\n");
                Console.SetCursorPosition(x, y + 16); Console.Write("               \\         |          /       |  `.\n");
                Console.SetCursorPosition(x, y + 17); Console.Write("                \\        '         / ,      '    \\\n");
                Console.SetCursorPosition(x, y + 18); Console.Write("                 \\      ,  _      /.'      /|    `-.\n");
                Console.SetCursorPosition(x, y + 19); Console.Write("                  `.   .    `-.    __     ' |     .'\n");
                Console.SetCursorPosition(x, y + 20); Console.Write("                    `..'   -\"'  .-\"| |  ,'  |    |  '-..\n");
                Console.SetCursorPosition(x, y + 21); Console.Write("                    /`.        (_`.`\" \\'    |_.-'-\"'-. .`.\n");
                Console.SetCursorPosition(x, y + 22); Console.Write("                   .   \\       `._. `\".|    |         `|  .\n");
                Console.SetCursorPosition(x, y + 23); Console.Write("                   |    \\`----\"\"`.`. / |,.-\"'`-.        `. '\n");
                Console.SetCursorPosition(x, y + 24); Console.Write("                   |     \\        `-+-\"   /     \\         \\ \\\n");
                Console.SetCursorPosition(x, y + 25); Console.Write("                  ,'     _\\ ___..-'      .       \\         \\ \\\n");
                Console.SetCursorPosition(x, y + 26); Console.Write("                  j\"._,-\".'`.       _.-\"'|     _  \\         . \\\n");
                Console.SetCursorPosition(x, y + 27); Console.Write("                 / ,'   /    `.._,-'    _| _.-'   `.        |  \\\n");
                Console.SetCursorPosition(x, y + 28); Console.Write("               .' '    ._      `-..__.-\"_|'        |        `..\"`.\n");
                Console.SetCursorPosition(x, y + 29); Console.Write("   _..      _,'\"-/     | `-._   .'   `\"' `.      __|        /|  | \\_\n");
                Console.SetCursorPosition(x, y + 30); Console.Write(" .'   `--\"\"' _.-'    .-|     `.'          '._  .`  `.      / |  |.'|\n");
                Console.SetCursorPosition(x, y + 31); Console.Write(".  \\ .\"\\ _,-'        `.'..-.-'           /   `.-._   .     `.|./__.'\n");
                Console.SetCursorPosition(x, y + 32); Console.Write("|`.` | /\"               |.'             / _.'     `-.|\n");
                Console.SetCursorPosition(x, y + 33); Console.Write("`_|.'`'                                `-' \n");
                Console.SetCursorPosition(x, y + 34); Console.Write("\n");
            }

            else if (pokenumber == 128)
            {
                Console.SetCursorPosition(x, y); Console.Write("                                                           .'`.'\n");
                Console.SetCursorPosition(x, y + 1); Console.Write("                                                          `     '\n");
                Console.SetCursorPosition(x, y + 2); Console.Write("                                             ,-'.`.        `    ``\n");
                Console.SetCursorPosition(x, y + 3); Console.Write("            '\"--.                          /'      \\        |    |\n");
                Console.SetCursorPosition(x, y + 4); Console.Write("             \\   `                         '.      `.      ',    '\n");
                Console.SetCursorPosition(x, y + 5); Console.Write("              .   |                          `- _,.\"-._-._   `. /\n");
                Console.SetCursorPosition(x, y + 6); Console.Write("              '   |,`.----.                            \"-.`.  |'\n");
                Console.SetCursorPosition(x, y + 7); Console.Write(" ,\".        .'    '       '---.                            \\\\ ||\n");
                Console.SetCursorPosition(x, y + 8); Console.Write(" | ){     ,-'|    .             '                            ..||\n");
                Console.SetCursorPosition(x, y + 9); Console.Write(" |  `._.',||`._.'|              \\.                          ||||\n");
                Console.SetCursorPosition(x, y + 10); Console.Write(" `.   / ._| `-...'\\              \\`._                       |. '\n");
                Console.SetCursorPosition(x, y + 11); Console.Write("  _,-'             . `--.         \\  `.                     '.'\n");
                Console.SetCursorPosition(x, y + 12); Console.Write(".\" .'             _|     `-`\".     .   `.                 .'.\n");
                Console.SetCursorPosition(x, y + 13); Console.Write(" '-....'          |           `-. _.'    `._           _.','\n");
                Console.SetCursorPosition(x, y + 14); Console.Write("  `.             .'                .-       `.       .'_,'\n");
                Console.SetCursorPosition(x, y + 15); Console.Write("    `..__....._ `.               ,'           `-._ .',\"\n");
                Console.SetCursorPosition(x, y + 16); Console.Write("          /    `.|               '                `.'....__\n");
                Console.SetCursorPosition(x, y + 17); Console.Write("         .                   _){.]                   `\"''-._`.\n");
                Console.SetCursorPosition(x, y + 18); Console.Write("         '                 ){\"    '                   `.    `. .\n");
                Console.SetCursorPosition(x, y + 19); Console.Write("          \\                |                                 `.`.\n");
                Console.SetCursorPosition(x, y + 20); Console.Write("           .               |                           .       ` .\n");
                Console.SetCursorPosition(x, y + 21); Console.Write("           |               '         |                          ` .\n");
                Console.SetCursorPosition(x, y + 22); Console.Write("           '.             .          |                  '        .|\n");
                Console.SetCursorPosition(x, y + 23); Console.Write("             |`.          |          |                  |        ||\n");
                Console.SetCursorPosition(x, y + 24); Console.Write("             |  `.        '          '                  |       . '\n");
                Console.SetCursorPosition(x, y + 25); Console.Write("             |    \"--.     |        /_                  |     -'   |\n");
                Console.SetCursorPosition(x, y + 26); Console.Write("             |        `.   |       /  `'\"\"`-._          |    ,'    |\n");
                Console.SetCursorPosition(x, y + 27); Console.Write("             '        ,\"'..|      .      '    `.        |    |.    |\n");
                Console.SetCursorPosition(x, y + 28); Console.Write("              .     ,'     '.     |\\    .       `       |      | ,/\n");
                Console.SetCursorPosition(x, y + 29); Console.Write("              |    /        |     | .   |        `.     |      `'\n");
                Console.SetCursorPosition(x, y + 30); Console.Write("              |   .         |    ,' |  .           \\    |\n");
                Console.SetCursorPosition(x, y + 31); Console.Write("              |   |         |    .  | .'            .__ '\n");
                Console.SetCursorPosition(x, y + 32); Console.Write("              '-..|         |___.   '\"              |../\n");
                Console.SetCursorPosition(x, y + 33); Console.Write("             /.-'           \\ .'\n");
                Console.SetCursorPosition(x, y + 34); Console.Write("                             ' \n");
            }

            else if (pokenumber == 129)
            {
                Console.SetCursorPosition(x, y); Console.Write("\n");
                Console.SetCursorPosition(x, y + 1); Console.Write("                                 __.--.._,-'\"\"-.\n");
                Console.SetCursorPosition(x, y + 2); Console.Write("                              ,-' .' ,'  .-\"''-.`.       .--.\n");
                Console.SetCursorPosition(x, y + 3); Console.Write("                            ,'    |  |  '`-.    \\ \\       `-.|\n");
                Console.SetCursorPosition(x, y + 4); Console.Write("                           /       .   /    `.   \\ \\        ||\n");
                Console.SetCursorPosition(x, y + 5); Console.Write("                          /         `..`.    `.   \\ .       ||\n");
                Console.SetCursorPosition(x, y + 6); Console.Write("                         /        . .    `.    \\   . .      '.\n");
                Console.SetCursorPosition(x, y + 7); Console.Write("                .\"-.    .  ,\"\"'-. | |      \\    \\   `.`.__,'.'\n");
                Console.SetCursorPosition(x, y + 8); Console.Write("                 `. `. .   |     `. |       \\    .    `-..-'\n");
                Console.SetCursorPosition(x, y + 9); Console.Write("       _______     .  `|   |   '   .'        .   |...--._\n");
                Console.SetCursorPosition(x, y + 10); Console.Write("       `.     `\"--.'   '    .      | .        .  |\"\"''\"-._\"-._\n");
                Console.SetCursorPosition(x, y + 11); Console.Write("         `.             \\    `-._..'. .       |  |---.._  `-.__\"-..\n");
                Console.SetCursorPosition(x, y + 12); Console.Write("    -.     `.           |\\           `.`      |  |'`-.  `-._   +\"-'\n");
                Console.SetCursorPosition(x, y + 13); Console.Write("    `.`.     `-.        | `            .`.       | `. `.    `,\"\n");
                Console.SetCursorPosition(x, y + 14); Console.Write("      `.`.      `.      |  '.           ` `      `.  \\  `   /\n");
                Console.SetCursorPosition(x, y + 15); Console.Write("      | `.`.    __`.    |`/  `.     ...  `.`.     |   `.   .\n");
                Console.SetCursorPosition(x, y + 16); Console.Write("      |   \\ .  `._      | `. / `. .'.' |   \\ \\    |     \\  |\n");
                Console.SetCursorPosition(x, y + 17); Console.Write("      |.   ` \\    `-.   |   \\   .'.'/' |    \\ \\   |      ._'\n");
                Console.SetCursorPosition(x, y + 18); Console.Write("      | `.  `.\\      `. |    \\ / , '.  |_    . \\  '-.\n");
                Console.SetCursorPosition(x, y + 19); Console.Write("     ,     .  .\\       `|     . ' / |  | `-...\\ \\'   `._\n");
                Console.SetCursorPosition(x, y + 20); Console.Write("     `.     `.  \\       |.    '/ .  |  |       ' .      `-.\n");
                Console.SetCursorPosition(x, y + 21); Console.Write("      .`._    \\` \\      | `. /'  '  |  |       | |       ,.'\n");
                Console.SetCursorPosition(x, y + 22); Console.Write("       .  `-.  \\`.\\    ,|   //  '   |  |__  .' | |      |\n");
                Console.SetCursorPosition(x, y + 23); Console.Write("       |     `._`| `--' `  //  .    |  '  `\"  /| |   . -'\n");
                Console.SetCursorPosition(x, y + 24); Console.Write("       '        `|       `//   '    |   .    / | |   |\n");
                Console.SetCursorPosition(x, y + 25); Console.Write("      /....._____|       //   .  ___|   |   /  | |  ,|\n");
                Console.SetCursorPosition(x, y + 26); Console.Write("     .         _.'      /, _.--\"'-._ `\".| ,'   | |.'\n");
                Console.SetCursorPosition(x, y + 27); Console.Write("     |      _,' / ___   `-'.        `. _|'     |,\n");
                Console.SetCursorPosition(x, y + 28); Console.Write("     |  _,-\"  ,'.'   `-.._  `.      _,'         `\n");
                Console.SetCursorPosition(x, y + 29); Console.Write("     '-\"   _,','          \"- ....--'\n");
                Console.SetCursorPosition(x, y + 30); Console.Write("    /  _.-\"_.'\n");
                Console.SetCursorPosition(x, y + 31); Console.Write("   /_,'_,-'\n");
                Console.SetCursorPosition(x, y + 32); Console.Write(" .'_.-'\n");
                Console.SetCursorPosition(x, y + 33); Console.Write(" '\"\n");
            }

            else if (pokenumber == 130)
            {
                Console.SetCursorPosition(x, y); Console.Write("\n");
                Console.SetCursorPosition(x, y + 1); Console.Write("                            /|\n");
                Console.SetCursorPosition(x, y + 2); Console.Write("                /`     |   / |\n");
                Console.SetCursorPosition(x, y + 3); Console.Write("               . |     |`.'  |  ,          .\n");
                Console.SetCursorPosition(x, y + 4); Console.Write("               | |     |     `\"'/       _,'           ,\"'\n");
                Console.SetCursorPosition(x, y + 5); Console.Write("               | |     |       /      .\" ,'         ,'/_\n");
                Console.SetCursorPosition(x, y + 6); Console.Write("               | |   ,\"| .-\"\"\"''`,`.,'  /      /|  /  ' )\n");
                Console.SetCursorPosition(x, y + 7); Console.Write("     .'.       | |\"\"+._|'   .    '     ,__    / ) /   .'\n");
                Console.SetCursorPosition(x, y + 8); Console.Write("      `.`.   .'| |     '_,\".`     \\     .'   '   '   /  _\n");
                Console.SetCursorPosition(x, y + 9); Console.Write("        `.`./ j  |  _,-'_,'.       `-..'    .        `-'/\n");
                Console.SetCursorPosition(x, y + 10); Console.Write("         _\\' `   |,\" _.' `. `.     _..|     |         ,'\n");
                Console.SetCursorPosition(x, y + 11); Console.Write(" .    .\"'  \\._____.-' '    `-|  .-'  ,|    _|   ___  /\n");
                Console.SetCursorPosition(x, y + 12); Console.Write("  \\`._ `-. `|.___,'| /     _.'      / |  ,\" |.-'   `.'.\n");
                Console.SetCursorPosition(x, y + 13); Console.Write("   \\-.`\"-'  _______`'    ,' __.---.' ,^.' _.'_    __ `.`.\n");
                Console.SetCursorPosition(x, y + 14); Console.Write("   |    `-.,...... `.   |,-\"     / .'. |-'    `-.\"  | |` \\\n");
                Console.SetCursorPosition(x, y + 15); Console.Write("   '      ||\\/  |/`.|  .`       (,'   `|         `.'  '.| \\\n");
                Console.SetCursorPosition(x, y + 16); Console.Write("   `-..--.||       || j      ____\\     |       _  |  /     `.---------.\n");
                Console.SetCursorPosition(x, y + 17); Console.Write("      |   ||  ___..|||,.--\"\"'|.      .\"|     ,' | |\"/ `. ,'. .   ,.--\"\n");
                Console.SetCursorPosition(x, y + 18); Console.Write("      |  .||.'      ||.._    ' )  _,'\\ |`'-.'   | |/    ||.' |   `.\n");
                Console.SetCursorPosition(x, y + 19); Console.Write("      |,',|||      . |\"-.`._  `+`\"    \"      `.'  ^,.__,'.   |  ,--'\n");
                Console.SetCursorPosition(x, y + 20); Console.Write("       // |||      |j  |\\\\  \"'  `.     |   ,-` `./ '     |   |`.\\\n");
                Console.SetCursorPosition(x, y + 21); Console.Write("      .'  |||      ||  | .'      |   .\"`..|_ |  .   \\    |  /|\n");
                Console.SetCursorPosition(x, y + 22); Console.Write("      ||  ||`.___.'f   ' ||     ,'--\"`._|,-.`|  '    +.._|,'.|\n");
                Console.SetCursorPosition(x, y + 23); Console.Write("      ||  |`-.....'|    .'`.\"\"'`.       /\\ | `.'     |    |  |\n");
                Console.SetCursorPosition(x, y + 24); Console.Write(" .'`  ''   `--....-'    | \\|   ``\\     '  \\|   |     |`._,'-\"'\n");
                Console.SetCursorPosition(x, y + 25); Console.Write(" |`..''                 |  '    )|.   /`..|'   '     |   \\  /\n");
                Console.SetCursorPosition(x, y + 26); Console.Write("  `\"\"'                  |   `-..''|  /    |   /    _..\"`.` /\n");
                Console.SetCursorPosition(x, y + 27); Console.Write("                        `         |,'     |  /  ,\"'_,|     \\\n");
                Console.SetCursorPosition(x, y + 28); Console.Write("                         `,_   _.-'.      |,' .'-'\"  '    , \\\n");
                Console.SetCursorPosition(x, y + 29); Console.Write("                          `.\"\"'     `.   .' .'      /   ,' | .\n");
                Console.SetCursorPosition(x, y + 30); Console.Write("                            `._       \\,'  .       /   /   | |\n");
                Console.SetCursorPosition(x, y + 31); Console.Write("                               `\"----\"'     \\  _  /  ,'    | |\n");
                Console.SetCursorPosition(x, y + 32); Console.Write("                                             `\" 7._,`      | |\n");
                Console.SetCursorPosition(x, y + 33); Console.Write("                                                    \\      | '\n");
                Console.SetCursorPosition(x, y + 34); Console.Write("                                                     `-. ,.|/\n");
                Console.SetCursorPosition(x, y + 35); Console.Write("                                                        '  |\n");
            }

            else if (pokenumber == 131)
            {
                Console.SetCursorPosition(x, y); Console.Write("                                       ,|\n");
                Console.SetCursorPosition(x, y + 1); Console.Write("                                       ||\n");
                Console.SetCursorPosition(x, y + 2); Console.Write("                               ,-\"'\"\"`' `._\n");
                Console.SetCursorPosition(x, y + 3); Console.Write("                              '----.     __`....._\n");
                Console.SetCursorPosition(x, y + 4); Console.Write("                               `    `.  `. ;      `.\n");
                Console.SetCursorPosition(x, y + 5); Console.Write("                                `.    `.  `   ,\"`. |\n");
                Console.SetCursorPosition(x, y + 6); Console.Write("                                  `.  _.`._   |  ' |\n");
                Console.SetCursorPosition(x, y + 7); Console.Write("                                  .','  ,' `.  `--'\n");
                Console.SetCursorPosition(x, y + 8); Console.Write("                                 /.' _,'    | /\n");
                Console.SetCursorPosition(x, y + 9); Console.Write("                                '/_.'       |.\n");
                Console.SetCursorPosition(x, y + 10); Console.Write("                                 `---`\".    ||\n");
                Console.SetCursorPosition(x, y + 11); Console.Write("                                       |    ||\n");
                Console.SetCursorPosition(x, y + 12); Console.Write("                                      ,'    `|\n");
                Console.SetCursorPosition(x, y + 13); Console.Write("                         _           /       |\n");
                Console.SetCursorPosition(x, y + 14); Console.Write("                        ' `.        .'       |\n");
                Console.SetCursorPosition(x, y + 15); Console.Write("                         .  `._  _,'/|       |\n");
                Console.SetCursorPosition(x, y + 16); Console.Write("                        _|     \"'  / |       '\n");
                Console.SetCursorPosition(x, y + 17); Console.Write("                    _,-' |        /  '        .\n");
                Console.SetCursorPosition(x, y + 18); Console.Write("                 |\"'            ,'  '          \\\n");
                Console.SetCursorPosition(x, y + 19); Console.Write("                 |   _        ,'   /            \\\n");
                Console.SetCursorPosition(x, y + 20); Console.Write("                 ;  '        /    j              .\n");
                Console.SetCursorPosition(x, y + 21); Console.Write("            ,\"--'    `.    .      |              |         ________\n");
                Console.SetCursorPosition(x, y + 22); Console.Write("            `.   -.       / '     |              |   _,-\"\"'   __.._\"`-._\n");
                Console.SetCursorPosition(x, y + 23); Console.Write("             ,' ,-.`-.__.' /      '              |.-'  _..--'\"       _.-'\n");
                Console.SetCursorPosition(x, y + 24); Console.Write("             \\.'   `-.___.'      ,               '__.-\"           _.'\n");
                Console.SetCursorPosition(x, y + 25); Console.Write("             /        _..--    . |              /               ,'\n");
                Console.SetCursorPosition(x, y + 26); Console.Write("           ,`      .-'         | |           _,'._          _,-'\n");
                Console.SetCursorPosition(x, y + 27); Console.Write("       _,-'      ,'           .' '       _.-'     \"-.....-\"'\n");
                Console.SetCursorPosition(x, y + 28); Console.Write("     ,'     __ ,'          _.'  /  __..-'\n");
                Console.SetCursorPosition(x, y + 29); Console.Write("   ,' _.-\"\"'  /         _.'  _.'-\"'\n");
                Console.SetCursorPosition(x, y + 30); Console.Write("  '-'\"       /      _.-' _.-\"\n");
                Console.SetCursorPosition(x, y + 31); Console.Write("            /    _.' _.-'\n");
                Console.SetCursorPosition(x, y + 32); Console.Write("           .   .'_.-'\n");
                Console.SetCursorPosition(x, y + 33); Console.Write("           | ,'.'\n");
                Console.SetCursorPosition(x, y + 34); Console.Write("           | .`\n");
                Console.SetCursorPosition(x, y + 35); Console.Write("            `\n");
            }

            else if (pokenumber == 132)
            {
                Console.SetCursorPosition(x, y); Console.Write("\n");
                Console.SetCursorPosition(x, y + 1); Console.Write("                                           ,--._\n");
                Console.SetCursorPosition(x, y + 2); Console.Write("                                        _,'     `.\n");
                Console.SetCursorPosition(x, y + 3); Console.Write("                              ,.-------\"          `.\n");
                Console.SetCursorPosition(x, y + 4); Console.Write("                             /                 \"    `-.__\n");
                Console.SetCursorPosition(x, y + 5); Console.Write("                            .         \"        _,        `._\n");
                Console.SetCursorPosition(x, y + 6); Console.Write("                            |            __..-\"             `.\n");
                Console.SetCursorPosition(x, y + 7); Console.Write("                            |        ''\"'                     `._\n");
                Console.SetCursorPosition(x, y + 8); Console.Write("                            |                                    `\"-.\n");
                Console.SetCursorPosition(x, y + 9); Console.Write("                            '                                        `.\n");
                Console.SetCursorPosition(x, y + 10); Console.Write("                           .                                          |\n");
                Console.SetCursorPosition(x, y + 11); Console.Write("                          /                                           |\n");
                Console.SetCursorPosition(x, y + 12); Console.Write("                       _,'                                           ,'\n");
                Console.SetCursorPosition(x, y + 13); Console.Write("                     ,\"                                             /\n");
                Console.SetCursorPosition(x, y + 14); Console.Write("                    .                                              /\n");
                Console.SetCursorPosition(x, y + 15); Console.Write("                    |                                             /\n");
                Console.SetCursorPosition(x, y + 16); Console.Write("                    |                                            .\n");
                Console.SetCursorPosition(x, y + 17); Console.Write("                    '                                            |\n");
                Console.SetCursorPosition(x, y + 18); Console.Write("                     `.                                          |\n");
                Console.SetCursorPosition(x, y + 19); Console.Write("                       `.                                        |\n");
                Console.SetCursorPosition(x, y + 20); Console.Write("                         `.                                      '\n");
                Console.SetCursorPosition(x, y + 21); Console.Write("                           .                                      .\n");
                Console.SetCursorPosition(x, y + 22); Console.Write("                           |                                       `.\n");
                Console.SetCursorPosition(x, y + 23); Console.Write("                           '                                        |\n");
                Console.SetCursorPosition(x, y + 24); Console.Write("                         ,'                                         |\n");
                Console.SetCursorPosition(x, y + 25); Console.Write("                       ,'                                           '\n");
                Console.SetCursorPosition(x, y + 26); Console.Write("                      /                                _...._      /\n");
                Console.SetCursorPosition(x, y + 27); Console.Write("                     .                              ,-'      `\"'--'\n");
                Console.SetCursorPosition(x, y + 28); Console.Write("      ___            |                            ,'\n");
                Console.SetCursorPosition(x, y + 29); Console.Write("   ,-'   `\"-._     _.'                          ,'\n");
                Console.SetCursorPosition(x, y + 30); Console.Write("  /           `\"--'             _,....__     _,'\n");
                Console.SetCursorPosition(x, y + 31); Console.Write(" '                            .'        `---'\n");
                Console.SetCursorPosition(x, y + 32); Console.Write(" `                 ____     ,'\n");
                Console.SetCursorPosition(x, y + 33); Console.Write("  .           _.-'\"    `---'\n");
                Console.SetCursorPosition(x, y + 34); Console.Write("   `-._    _.\"\n");
                Console.SetCursorPosition(x, y + 35); Console.Write("       \"\"\"'\n");
            }

            else if (pokenumber == 133)
            {
                Console.SetCursorPosition(x, y); Console.Write("\n");
                Console.SetCursorPosition(x, y + 1); Console.Write("                                      |\n");
                Console.SetCursorPosition(x, y + 2); Console.Write("                                     /|\n");
                Console.SetCursorPosition(x, y + 3); Console.Write("                                   ,' |\n");
                Console.SetCursorPosition(x, y + 4); Console.Write("                                  .   |\n");
                Console.SetCursorPosition(x, y + 5); Console.Write("                                    | |\n");
                Console.SetCursorPosition(x, y + 6); Console.Write("                                 ' '| |\n");
                Console.SetCursorPosition(x, y + 7); Console.Write("                                / / | |\n");
                Console.SetCursorPosition(x, y + 8); Console.Write("       _,.-\"\"--._              / /  | |\n");
                Console.SetCursorPosition(x, y + 9); Console.Write("     ,'          `.           j '   ' '\n");
                Console.SetCursorPosition(x, y + 10); Console.Write("   ,'              `.         ||   / ,                         ___..--,\n");
                Console.SetCursorPosition(x, y + 11); Console.Write("  /                  \\        ' `.'`.-.,-\".  .       _..---\"\"'' __, ,'\n");
                Console.SetCursorPosition(x, y + 12); Console.Write(" /                    \\        \\` .\"`      `\"'\\   ,'\"_..--''\"\"\"'.'.'\n");
                Console.SetCursorPosition(x, y + 13); Console.Write(".                      .      .'-'             \\,' ,'         ,','\n");
                Console.SetCursorPosition(x, y + 14); Console.Write("|                      |      ,`               ' .`         .' /\n");
                Console.SetCursorPosition(x, y + 15); Console.Write("|                      |     /          ,\"`.  ' `-. _____.-' .'\n");
                Console.SetCursorPosition(x, y + 16); Console.Write("'                      |..---.|,\".      | | .  .-'\"\"   __.,-'\n");
                Console.SetCursorPosition(x, y + 17); Console.Write(" .                   ,'       ||,|      |.' |    |\"\"`'\"\n");
                Console.SetCursorPosition(x, y + 18); Console.Write("  `-._   `._.._____  |        || |      `._,'    |\n");
                Console.SetCursorPosition(x, y + 19); Console.Write("      `.   .       `\".     ,'\"| \"  `'           ,+.\n");
                Console.SetCursorPosition(x, y + 20); Console.Write("        \\  '         |    '   |   .....        .'  `.\n");
                Console.SetCursorPosition(x, y + 21); Console.Write("         .'          '     7  \".              ,'     \\\n");
                Console.SetCursorPosition(x, y + 22); Console.Write("                   ,'      |    `..        _,'      F\n");
                Console.SetCursorPosition(x, y + 23); Console.Write("                  .        |,      `'----''         |\n");
                Console.SetCursorPosition(x, y + 24); Console.Write("                  |      ,\"j  /                   | '\n");
                Console.SetCursorPosition(x, y + 25); Console.Write("                  `     |  | .                 | `,'\n");
                Console.SetCursorPosition(x, y + 26); Console.Write("                   .    |  `.|                 |/\n");
                Console.SetCursorPosition(x, y + 27); Console.Write("                    `-..'   ,'                .'\n");
                Console.SetCursorPosition(x, y + 28); Console.Write("                            | \\             ,''\n");
                Console.SetCursorPosition(x, y + 29); Console.Write("                            |  `,'.      _,' /\n");
                Console.SetCursorPosition(x, y + 30); Console.Write("                            |    | ^.  .'   /\n");
                Console.SetCursorPosition(x, y + 31); Console.Write("                             `-'.' j` V    /\n");
                Console.SetCursorPosition(x, y + 32); Console.Write("                                   |      /\n");
                Console.SetCursorPosition(x, y + 33); Console.Write("                                   |     /\n");
                Console.SetCursorPosition(x, y + 34); Console.Write("                                   |   ,'\n");
                Console.SetCursorPosition(x, y + 35); Console.Write("                                    `\"\"\n");
            }

            else if (pokenumber == 134)
            {
                Console.SetCursorPosition(x, y); Console.Write("                                                                                                    \n");
                Console.SetCursorPosition(x, y + 1); Console.Write("                                      ``                                                            \n");
                Console.SetCursorPosition(x, y + 2); Console.Write("                                       o`                                                           \n");
                Console.SetCursorPosition(x, y + 3); Console.Write("                                       -/                                                           \n");
                Console.SetCursorPosition(x, y + 4); Console.Write("                                        /-                                                          \n");
                Console.SetCursorPosition(x, y + 5); Console.Write("                                        ./`                            .-){`                         \n");
                Console.SetCursorPosition(x, y + 6); Console.Write("                                         ){){                        `.-){-/`                          \n");
                Console.SetCursorPosition(x, y + 7); Console.Write("                                         .){-                     ..){-. -`                           \n");
                Console.SetCursorPosition(x, y + 8); Console.Write("                                        .-){){-....--.`         `...-`   ){                            \n");
                Console.SetCursorPosition(x, y + 9); Console.Write("                                   ``...` `){-    ){  `....`  .-..-`     ){                            \n");
                Console.SetCursorPosition(x, y + 10); Console.Write("                                  ){```    ./){-...-.`  `-`---``-.    .-){.                            \n");
                Console.SetCursorPosition(x, y + 11); Console.Write("                                `-` ..`...``-){  `....-- .-` ..   .-..-                              \n");
                Console.SetCursorPosition(x, y + 12); Console.Write("                             `...    --`..  -){  ..`....-` .-` `--` `-                               \n");
                Console.SetCursorPosition(x, y + 13); Console.Write("           `-){){//){------.....){.`..` -`.-`.-`    ){    `-. -. .-.`   -`                               \n");
                Console.SetCursorPosition(x, y + 14); Console.Write("                `.-.````......``.--/.-.    .-. .-  .-oss/``.`  ``.`/                                \n");
                Console.SetCursorPosition(x, y + 15); Console.Write("                   ..       ``....``){`.){){..  `.-  ){){+NMd-. `.--.``){.                                \n");
                Console.SetCursorPosition(x, y + 16); Console.Write("                    ){.............`---mNd+/o`     hmNds/ ){`````` ..                                 \n");
                Console.SetCursorPosition(x, y + 17); Console.Write("                    `..-.`  ``````  ){`oydmmd){  `  .--.`` ){``````){-                                  \n");
                Console.SetCursorPosition(x, y + 18); Console.Write("                        `-`  `...`  .){ .--.`   ..``      ){       ){                                  \n");
                Console.SetCursorPosition(x, y + 19); Console.Write("                          ){-){.``  `..-.      .-...-      /..``  `-                                  \n");
                Console.SetCursorPosition(x, y + 20); Console.Write("                          ```){.`......){.      .-  ){    `-`  ``  -`                                  \n");
                Console.SetCursorPosition(x, y + 21); Console.Write("                             ./.`..`   ...     `.-`  `.){.      `.-                                  \n");
                Console.SetCursorPosition(x, y + 22); Console.Write("                             -.        .-......````-.`  `-`   ..`                                   \n");
                Console.SetCursorPosition(x, y + 23); Console.Write("                             ``..`    -.     ){`````.-     `  ..                                     \n");
                Console.SetCursorPosition(x, y + 24); Console.Write("                                 ){){` ``     `-      .`    ```){                                      \n");
                Console.SetCursorPosition(x, y + 25); Console.Write("                            ````..`/```     ``         `.){.```                                      \n");
                Console.SetCursorPosition(x, y + 26); Console.Write("                      ``.....```.`-..``...``  ``.....`..`..                                         \n");
                Console.SetCursorPosition(x, y + 27); Console.Write("                   ....`` ```...``        `.-.``     ``   ){                                         \n");
                Console.SetCursorPosition(x, y + 28); Console.Write("                `..````....``                             ){               ```.....```               \n");
                Console.SetCursorPosition(x, y + 29); Console.Write("               .- `..``     `````               `.   ``   ){            ``..```   `...-.``           \n");
                Console.SetCursorPosition(x, y + 30); Console.Write("              ){` ..`        `````...`   ){       ..  .-   `/````````  `.``             `.-/`         \n");
                Console.SetCursorPosition(x, y + 31); Console.Write("             .- .-                 `..  ){       -..){){-.){){){){-){){){--){---.                `--`          \n");
                Console.SetCursorPosition(x, y + 32); Console.Write("            -. .-                    `-`-    ``-/.---```.............){.              .-`            \n");
                Console.SetCursorPosition(x, y + 33); Console.Write("            ){ .-                      `){){``-.--.``.-.``.        ```.       ``     `.-.              \n");
                Console.SetCursorPosition(x, y + 34); Console.Write("           -. -`       ..````````````.-){){){){``....`       ``..```   -        `-.```.`                \n");
                Console.SetCursorPosition(x, y + 35); Console.Write("           .-`-`         `````..-){--){-   `...`        `.){.`        -          ..                    \n");
                Console.SetCursorPosition(x, y + 36); Console.Write("           ``){.-`.`   `    ````-.  ```....`        `.-.`){          ){           .-                   \n");
                Console.SetCursorPosition(x, y + 37); Console.Write("           `.`--.`.-.......```.``.....          `.){.`  ..          `-           .-                  \n");
                Console.SetCursorPosition(x, y + 38); Console.Write("            -  `......``........`             `-/.){    ){            `-.          /                  \n");
                Console.SetCursorPosition(x, y + 39); Console.Write("            `-        ``                   `--. -`){    ){              `--`       -.                 \n");
                Console.SetCursorPosition(x, y + 40); Console.Write("             .-                         `){){/    `-){    ){                 .--`    `){                 \n");
                Console.SetCursorPosition(x, y + 41); Console.Write("               --`                  `.---.+){`    ){){  ``){.                   .--` `){                 \n");
                Console.SetCursorPosition(x, y + 42); Console.Write("                 ..-..`        `.--//-``-){- -` .`){/-.){-){`                      .){/.                 \n");
                Console.SetCursorPosition(x, y + 43); Console.Write("                     `..........`     ```    ..-..   \n");
            }

            else if (pokenumber == 135)
            {
                Console.SetCursorPosition(x, y); Console.Write("XH                             HX               \n");
                Console.SetCursorPosition(x, y + 1); Console.Write("H;XHX                         HXH               \n");
                Console.SetCursorPosition(x, y + 2); Console.Write("H;;;;XH                      XHXH               \n");
                Console.SetCursorPosition(x, y + 3); Console.Write("XXXX;;;H                     HX;H               \n");
                Console.SetCursorPosition(x, y + 4); Console.Write(" HXHHX;;H                   HXH;H    XH         \n");
                Console.SetCursorPosition(x, y + 5); Console.Write(" HXXHHX;;X                 HXXH;H  HX;H         \n");
                Console.SetCursorPosition(x, y + 6); Console.Write(" XXXHHHX;H        X  H     HXHX;HHX;;;X         \n");
                Console.SetCursorPosition(x, y + 7); Console.Write("  HXHHHHX;H       HH HH   HXHH;;X;;;;X       XHX\n");
                Console.SetCursorPosition(x, y + 8); Console.Write("   HXHHHHX;X XH  XXXHHXH  HHHH;XHX;;;H    XHX;;H\n");
                Console.SetCursorPosition(x, y + 9); Console.Write("    HXHHHH;;XHXH HX;XHX;HHXHHX;H;H;;XXXHHX;;;;H \n");
                Console.SetCursorPosition(x, y + 10); Console.Write(" HHHXXXHHHX;;HXXXHX;;XHXHXHHH;;;XH;HXXX;;;;;XH  \n");
                Console.SetCursorPosition(x, y + 11); Console.Write("  HXXXXXXHHX;;H;XXX;;;HX;HHHXX;XHHHXX;;;;;;XH   \n");
                Console.SetCursorPosition(x, y + 12); Console.Write("   XHXXXXHHXX;X;;XXX;;;X;XHHXXH;;;HX;;;;;XXH    \n");
                Console.SetCursorPosition(x, y + 13); Console.Write("     HHHXXX;;;;;;;;X;;;;;;XHXH;;;HX;;;;;XXH     \n");
                Console.SetCursorPosition(x, y + 14); Console.Write("      HXHXXX;;;;;;;;;;;;;;HXH;;;;HX;;;;XXH      \n");
                Console.SetCursorPosition(x, y + 15); Console.Write("       XHHX;XHXX ;;;;;;;XXXH;;;;HX;;;;XX;;XHX   \n");
                Console.SetCursorPosition(x, y + 16); Console.Write("       HXXH;;HH X ;;;;;X H;H;;XHHHHHHXX;;;;;;HX \n");
                Console.SetCursorPosition(x, y + 17); Console.Write("     XHX;HX;;XHHHX;;;;XHHX;X;;;;;;;  H;;;;;;HX  \n");
                Console.SetCursorPosition(x, y + 18); Console.Write("  XHX;;;HXHX;;XHHH;;;;HHX;;;H;;;    H;;;;;HX    \n");
                Console.SetCursorPosition(x, y + 19); Console.Write(" XH;;;;;XHXH;;;;;;;XH;;;;;;XH      HXX;;HX      \n");
                Console.SetCursorPosition(x, y + 20); Console.Write("   XHX;XHXHXX;H;;;;;;;;;H;XHX    HHXXXXX;;XHHHHX\n");
                Console.SetCursorPosition(x, y + 21); Console.Write("      XH;;;HHXXHHHHHHHHH;XH    ;;  HXXXXXXXX;;H \n");
                Console.SetCursorPosition(x, y + 22); Console.Write("     H;;;;;;XX;XHHXXXXHH;H      H;; HXX;;;;;;H  \n");
                Console.SetCursorPosition(x, y + 23); Console.Write("   XH;;;H;;;;HX;HXXXXXH;X        HHHXX;;;;;;H   \n");
                Console.SetCursorPosition(x, y + 24); Console.Write("    HHHX;;;;;;H;;HHHHH;XH   ;;    HXXX;;;;HX    \n");
                Console.SetCursorPosition(x, y + 25); Console.Write("      H;; ;;;;;HX;;;;;H     HX;;   HX;;;XHH     \n");
                Console.SetCursorPosition(x, y + 26); Console.Write("     H;;   ;;;;;;XHHHX      XHHX;;  H;XH;;H     \n");
                Console.SetCursorPosition(x, y + 27); Console.Write("    H;;    ;;;;              HHHHHHHH;H;;;XH    \n");
                Console.SetCursorPosition(x, y + 28); Console.Write("   H;;   XHX;;;        X;    XHHHHHXXXX;;;;H    \n");
                Console.SetCursorPosition(x, y + 29); Console.Write("  H;;XHHXH;H;;  H;     XX;    HHHHXXXXX;;;;XH   \n");
                Console.SetCursorPosition(x, y + 30); Console.Write(" XHHHHHHHXX;;  ; H;     HHX;  XHHHXXXXXX;;;;XX  \n");
                Console.SetCursorPosition(x, y + 31); Console.Write("        HXH;   H; H;    HHHX;  HHXHXXXXXXX;;;H  \n");
                Console.SetCursorPosition(x, y + 32); Console.Write("        HXH   HXH; H;   XHHHHX; H   XHHXXXX;;;X \n");
                Console.SetCursorPosition(x, y + 33); Console.Write("       HXXH  HX  H;HH;   HHXXHHHHX     HHXXX;;H \n");
                Console.SetCursorPosition(x, y + 34); Console.Write("       HXX;HHX   XH;;H;  HHXXXXXHH      HXXX;;H \n");
                Console.SetCursorPosition(x, y + 35); Console.Write("      HXX;;HH   HXX;;;H; H HXXXXXX       HXX;;X \n");
                Console.SetCursorPosition(x, y + 36); Console.Write("     HXXX;;H    HXX;;;XH;H HXXXXXH       HXX;;;X\n");
                Console.SetCursorPosition(x, y + 37); Console.Write("    HXXX;;X     HXX;;;XXHH  HXXXXH       HXX;;;H\n");
                Console.SetCursorPosition(x, y + 38); Console.Write(" HHHXX;;;XH    HXX;;;XH  X  HXHXXX       HXX;;;H\n");
                Console.SetCursorPosition(x, y + 39); Console.Write("HXXX;;;;;H     HXX;;;H      XHHHX        HXX;;;H\n");
                Console.SetCursorPosition(x, y + 40); Console.Write("HX;HH;;HH     XXX;;;;H                   HHX;H;H\n");
                Console.SetCursorPosition(x, y + 41); Console.Write("HH;H;XHH      HX;;;;XX                   XHX;H;X\n");
                Console.SetCursorPosition(x, y + 42); Console.Write("  HHHHX      HXX;;;;H                     XHHHX \n");
                Console.SetCursorPosition(x, y + 43); Console.Write("           XHXX;;;;XH                           \n");
                Console.SetCursorPosition(x, y + 44); Console.Write("           HXX;;H;;H                            \n");
                Console.SetCursorPosition(x, y + 45); Console.Write("           XH;;H;;XH                            \n");
                Console.SetCursorPosition(x, y + 46); Console.Write("            XH;H;XH                             \n");
                Console.SetCursorPosition(x, y + 47); Console.Write("              XHHX\n");
            }

            else if (pokenumber == 136)
            {
                Console.SetCursorPosition(x, y); Console.Write("                         /|     '\n");
                Console.SetCursorPosition(x, y + 1); Console.Write("                        / `.  ,'|,-.____\n");
                Console.SetCursorPosition(x, y + 2); Console.Write("                       /    `'  `       `\"\"----...,\n");
                Console.SetCursorPosition(x, y + 3); Console.Write("             .    ,__.'                        .-'._\n");
                Console.SetCursorPosition(x, y + 4); Console.Write("            / |   ' .'                   ,_         `'`--.._\n");
                Console.SetCursorPosition(x, y + 5); Console.Write("         _.'  . ,'                        `.`-._            `'.\n");
                Console.SetCursorPosition(x, y + 6); Console.Write("        |      `                            .  .`-._,\"'--._    `-.\n");
                Console.SetCursorPosition(x, y + 7); Console.Write("     ,_.'     `                              `. .`._`.     `-._   '\n");
                Console.SetCursorPosition(x, y + 8); Console.Write("      .                                     ..'  `. `.`.       `-. `.\n");
                Console.SetCursorPosition(x, y + 9); Console.Write("      |                                       `.   `. `.`.        `. \\\n");
                Console.SetCursorPosition(x, y + 10); Console.Write("      |                                       ,',.'\"-\\  \\ `.         `\n");
                Console.SetCursorPosition(x, y + 11); Console.Write("    ,-'                                       /     .\"\\  `  \\\n");
                Console.SetCursorPosition(x, y + 12); Console.Write("     .                              '`._ ,.  /      |  '  `. \\\n");
                Console.SetCursorPosition(x, y + 13); Console.Write(" ..._)                               |  \"  `.        `-'.  |  .\n");
                Console.SetCursorPosition(x, y + 14); Console.Write("   \\        '.---.._'._  .\"'-._     .'      |            `.|  '\n");
                Console.SetCursorPosition(x, y + 15); Console.Write("    `.         `._ .._ `-'     `.`-.|       '              ` /\n");
                Console.SetCursorPosition(x, y + 16); Console.Write("      `.          `-. `. `-.__   '-  `._     \\              |.\n");
                Console.SetCursorPosition(x, y + 17); Console.Write("       L_            `._ `.   `\"--..__  `\"-../\\             ||-.,\\\n");
                Console.SetCursorPosition(x, y + 18); Console.Write("         `.'            `-.`.         `-._     `-._       .' |`.  \\\n");
                Console.SetCursorPosition(x, y + 19); Console.Write("            .           _..`.`.._       ..`      __`\"-..-'   |.'  '-'\n");
                Console.SetCursorPosition(x, y + 20); Console.Write("            /___     .\"'     `-._`\"----\"'   `  .( )`.          `.  .\n");
                Console.SetCursorPosition(x, y + 21); Console.Write("                -.,./      `\"\"   `\"\"'\"\"'`--.   `._   `.        /    \\\n");
                Console.SetCursorPosition(x, y + 22); Console.Write("                   /        ,               `._   `\"\"'  _____.'      '\n");
                Console.SetCursorPosition(x, y + 23); Console.Write("                             .                 `._      \"...'       /\n");
                Console.SetCursorPosition(x, y + 24); Console.Write("                  .         .'                    `\"\"-----'        ' _\n");
                Console.SetCursorPosition(x, y + 25); Console.Write("                  '         `-.                                    .'\n");
                Console.SetCursorPosition(x, y + 26); Console.Write("                ,'            /                                   _,\n");
                Console.SetCursorPosition(x, y + 27); Console.Write("               /         _..-\"|\"--..                             |\n");
                Console.SetCursorPosition(x, y + 28); Console.Write("              /       .\"'     |  .'.,----,                  ,.-'\"|\n");
                Console.SetCursorPosition(x, y + 29); Console.Write("             .      ,'        |     \\   `--'.        __...-\"`...-'\n");
                Console.SetCursorPosition(x, y + 30); Console.Write("             '     /          '      \\       `-----\"'\n");
                Console.SetCursorPosition(x, y + 31); Console.Write("            /     '            .      \\        \\\n");
                Console.SetCursorPosition(x, y + 32); Console.Write("           .       .           '._,'_.'`.       \\\n");
                Console.SetCursorPosition(x, y + 33); Console.Write("           '._.  ).'                    `        `.\n");
                Console.SetCursorPosition(x, y + 34); Console.Write("              `\"'                        \\         `\n");
                Console.SetCursorPosition(x, y + 35); Console.Write("                                          `.   .   ,'\n");
                Console.SetCursorPosition(x, y + 36); Console.Write("                                            `\"-'--'\n");
            }

            else if (pokenumber == 137)
            {
                Console.SetCursorPosition(x, y); Console.Write("\n");
                Console.SetCursorPosition(x, y + 1); Console.Write("                                                                                                     \n");
                Console.SetCursorPosition(x, y + 2); Console.Write("                                                                                                    \n");
                Console.SetCursorPosition(x, y + 3); Console.Write("                                 ){+///////){--.``                                                    \n");
                Console.SetCursorPosition(x, y + 4); Console.Write("                              .++-       ``.--+hs-                                                  \n");
                Console.SetCursorPosition(x, y + 5); Console.Write("                           `/+){`            .o/` ++                                                 \n");
                Console.SetCursorPosition(x, y + 6); Console.Write("                        `){+/`             `++`    -s.                                               \n");
                Console.SetCursorPosition(x, y + 7); Console.Write("                      -++-              `++`       `o){                              `--.            \n");
                Console.SetCursorPosition(x, y + 8); Console.Write("                   `/+){`      .---){){){//+s.           /+`                          `++-){ho`          \n");
                Console.SetCursorPosition(x, y + 9); Console.Write("                  .s-         y){..``````/+.           .s.                       `/+. .s`.y          \n");
                Console.SetCursorPosition(x, y + 10); Console.Write("                 ){o`          y`   odmd+ `/+.          `o/                     ){o.  .s` ){o          \n");
                Console.SetCursorPosition(x, y + 11); Console.Write("                +/           `y   `mmmmd`  `++){){/////////h                   -o-   .s`  y.          \n");
                Console.SetCursorPosition(x, y + 12); Console.Write("              `o-            `y    ){sys.    .s.`        ){o                 -o){    .s.  ){o           \n");
                Console.SetCursorPosition(x, y + 13); Console.Write("             -s.            .os/           -s`          s.               .o/`    .s.   y.           \n");
                Console.SetCursorPosition(x, y + 14); Console.Write("            /+`           `++` +/     ``.-/o`          `y              `++`     `s.   ){o            \n");
                Console.SetCursorPosition(x, y + 15); Console.Write("          `o){            /o.   .y+/////){-.`            +/            `/+`      `s.    y`            \n");
                Console.SetCursorPosition(x, y + 16); Console.Write("         `s+///////){){--){o-   -+/`                   `/+.            ){o.       `s.    ){o             \n");
                Console.SetCursorPosition(x, y + 17); Console.Write("        `s.        ``-yoo){`-o){`                   `oy-`           -o-        `s.     y`             \n");
                Console.SetCursorPosition(x, y + 18); Console.Write("       `s-         `++`  oho`                   .+/`.-){/////){-.`.o){         `s.     ){+              \n");
                Console.SetCursorPosition(x, y + 19); Console.Write("       o){         ){o. `){o- ){o.                -o/           `.-){+////){-.`  `s.      y`              \n");
                Console.SetCursorPosition(x, y + 20); Console.Write("      +/        -o){ `/+-    `++`            ){o){                      `.-){//oo/`    ){+               \n");
                Console.SetCursorPosition(x, y + 21); Console.Write("     /+       `+/``/+.        .o){     ``.-+o-                                //    y`               \n");
                Console.SetCursorPosition(x, y + 22); Console.Write("    .y`     `/o``++.      ``.-){/yo/////){-./h+.                               .s   ){+                \n");
                Console.SetCursorPosition(x, y + 23); Console.Write("     ){//////y){.os/){///////ss-.`            y./+-                              y`  y`                \n");
                Console.SetCursorPosition(x, y + 24); Console.Write("           `-){/){-.`      ){o`               -o  -+/`                           o- ){+                 \n");
                Console.SetCursorPosition(x, y + 25); Console.Write("                      .){oo                  s.   .++.                         ){+ y`                 \n");
                Console.SetCursorPosition(x, y + 26); Console.Write("                  .///){+o                   .s     .y                         .y){+                  \n");
                Console.SetCursorPosition(x, y + 27); Console.Write("                `o/`  /+                     +){    s-            `ooo//){){--/+//yy`                  \n");
                Console.SetCursorPosition(x, y + 28); Console.Write("               /o`   /s`                     `y`  -s            `s-`){++-..-){///oo/////){-..`         \n");
                Console.SetCursorPosition(x, y + 29); Console.Write("             -o-     -ohs///){.                ){+  y`           `o){    `){+/`           `.--++`       \n");
                Console.SetCursorPosition(x, y + 30); Console.Write("           `+/`         -s+-.-/////){.`         y.){+       `-//+h){        `/+){`             .o/`     \n");
                Console.SetCursorPosition(x, y + 31); Console.Write("          ){o.          `+/`){+/.    .-/////){.`  .sy`  `-////-` +/            .++-             -o){    \n");
                Console.SetCursorPosition(x, y + 32); Console.Write("        .s){           ){o.    `/+/`        `-////hs////.      /+                -++-```......---os   \n");
                Console.SetCursorPosition(x, y + 33); Console.Write("        ){y/////){.`  .o){         ./+){`           `y.         ){+                   /o){){){------...){o   \n");
                Console.SetCursorPosition(x, y + 34); Console.Write("         y.    .-//+s`           .){os+-`         `y.       ){o                  `o){             +){   \n");
                Console.SetCursorPosition(x, y + 35); Console.Write("         `){/+/.    .s        .///){.   -++-        .y`     -s                  .s.              y`   \n");
                Console.SetCursorPosition(x, y + 36); Console.Write("             `){++){``y   `-/+/){`          ){+/.      .s    .s`                 /o`             `){s    \n");
                Console.SetCursorPosition(x, y + 37); Console.Write("                 ./+h////-`                `-////){-`-o  .s`                `o){            `){+/.     \n");
                Console.SetCursorPosition(x, y + 38); Console.Write("                     `                           `-){/oo+y`                .s.          `/+/.        \n");
                Console.SetCursorPosition(x, y + 39); Console.Write("                                                       y+-.`             ){o`        `/+/.           \n");
                Console.SetCursorPosition(x, y + 40); Console.Write("                                                       /o.-){/////){-.`  `o/       `/+/`              \n");
                Console.SetCursorPosition(x, y + 41); Console.Write("                                                        y.       `.-){//y-     ./+/`                 \n");
                Console.SetCursorPosition(x, y + 42); Console.Write("                                                        -s`            y`  ./+){`                    \n");
                Console.SetCursorPosition(x, y + 43); Console.Write("                                                         -///////){-.`  y-/+){`                       \n");
                Console.SetCursorPosition(x, y + 44); Console.Write("                                                                 `.-){//o){`                          \n");
                Console.SetCursorPosition(x, y + 45); Console.Write("                                                                               \n");
            }

            else if (pokenumber == 138)
            {
                Console.SetCursorPosition(x, y); Console.Write("                                                                                                    \n");
                Console.SetCursorPosition(x, y + 1); Console.Write("                                                                                                    \n");
                Console.SetCursorPosition(x, y + 2); Console.Write("                                                                                                    \n");
                Console.SetCursorPosition(x, y + 3); Console.Write("                                                            `.){+oyhhhhhhhhhhyyso+){.                 \n");
                Console.SetCursorPosition(x, y + 4); Console.Write("                                                       .){oyhyo+/-.``         ``.){/oyy+-             \n");
                Console.SetCursorPosition(x, y + 5); Console.Write("                                                   `){oys+){.                         `){sho`          \n");
                Console.SetCursorPosition(x, y + 6); Console.Write("                                                `/ss/.`                                `/h/         \n");
                Console.SetCursorPosition(x, y + 7); Console.Write("                                              -ss/``..----------.....``                  `oy.       \n");
                Console.SetCursorPosition(x, y + 8); Console.Write("                                            ){yy){){---.`````````.-----){){/////){){-`            ){h.      \n");
                Console.SetCursorPosition(x, y + 9); Console.Write("                                          -yo-`                            ```-){){){.         ){d.     \n");
                Console.SetCursorPosition(x, y + 10); Console.Write("                                        `os.                                     `-/-        +h     \n");
                Console.SetCursorPosition(x, y + 11); Console.Write("                                       .y/                                          ./.       y+    \n");
                Console.SetCursorPosition(x, y + 12); Console.Write("                                      ){y.    `......```                               /-      .m`   \n");
                Console.SetCursorPosition(x, y + 13); Console.Write("                                     +y---){){){---...-------------..`                    +.      d+   \n");
                Console.SetCursorPosition(x, y + 14); Console.Write("                                    os){``                     ````.-----..`            `s     .od   \n");
                Console.SetCursorPosition(x, y + 15); Console.Write("                                   oo`                                 ```.--..         o     /.N.  \n");
                Console.SetCursorPosition(x, y + 16); Console.Write("                                  +s`                                        ``){-.      +   `){` m-  \n");
                Console.SetCursorPosition(x, y + 17); Console.Write("                                 ){y`                                            `.){.  `-+----`  d){  \n");
                Console.SetCursorPosition(x, y + 18); Console.Write("                                .h.                                                -/--`  +`    d){  \n");
                Console.SetCursorPosition(x, y + 19); Console.Write("                               `y/       ````````                                  `+`    ){`    m-  \n");
                Console.SetCursorPosition(x, y + 20); Console.Write("                               +s`..-){){--...........--------.....`                `){`     -.    m`  \n");
                Console.SetCursorPosition(x, y + 21); Console.Write("                              `d/.``                        `````.----...        ./       .- `./m   \n");
                Console.SetCursorPosition(x, y + 22); Console.Write("                              ++                                      ``.-){-.   `/        ./..`/h   \n");
                Console.SetCursorPosition(x, y + 23); Console.Write("                             `h`                                           `.){-`+`   -){-  ..   so   \n");
                Console.SetCursorPosition(x, y + 24); Console.Write("                             /+                                               `o-   .. /  ){`   d/   \n");
                Console.SetCursorPosition(x, y + 25); Console.Write("                             h`                                               .+   .-  /  /   `m.   \n");
                Console.SetCursorPosition(x, y + 26); Console.Write("                            -s     ```.....`````                              +`   ){   /  +```+h    \n");
                Console.SetCursorPosition(x, y + 27); Console.Write("                            o){.-----.....``....------.......``               -/   ){`   / `/```d/    \n");
                Console.SetCursorPosition(x, y + 28); Console.Write("                           `d){.`                      `````...------...`     +`   ){ `.){` /`  -d`    \n");
                Console.SetCursorPosition(x, y + 29); Console.Write("                    `.-){/o){++                                       ``..-){.` s    ){ `){. ./`  so     \n");
                Console.SetCursorPosition(x, y + 30); Console.Write("                 .){++/){-oo`d.                                             .--s   `){    `){.-){-m`     \n");
                Console.SetCursorPosition(x, y + 31); Console.Write("               -oo){`   /s`+o                                                -s    /   .){   `ho      \n");
                Console.SetCursorPosition(x, y + 32); Console.Write("             .oo.     .h`+o`                                                `y    --.){){`   -h`      \n");
                Console.SetCursorPosition(x, y + 33); Console.Write("            ){y-       y){oo`                                                  h`    /){){`.- .h-       \n");
                Console.SetCursorPosition(x, y + 34); Console.Write("           /y.       `ds/    .-){+//){){){){-.`              ..-){){){){){/-..`        o+   ){` /  `){y+        \n");
                Console.SetCursorPosition(x, y + 35); Console.Write("          ){h`        `m/   -+/o+-`.-){){-..--`         `){+){-.```.-/oo-){/-`     `h.`-`  /  `ho         \n");
                Console.SetCursorPosition(x, y + 36); Console.Write("         `h-          y   +/`/. .sdNNmN+/..+`      ./y/  .+syy+){` /o``-+-     -y.    ){ `yo          \n");
                Console.SetCursorPosition(x, y + 37); Console.Write("         ){h           ){/ `h ./ `hNNmmmNddy ){s-```./){){o  +mmmNNyhh` /+   ){/`    -o`  -..y/           \n");
                Console.SetCursorPosition(x, y + 38); Console.Write("         +y            //`y){){- .mNNNNmmmms //.-){){-` o. -mNmmmNNmm-  y    `+.    .o.`){/s-            \n");
                Console.SetCursorPosition(x, y + 39); Console.Write("         ){d             -+oy++``ymmmmmm.`o`       o` .mmNNNNmmm`  s    `-+.    `syo/              \n");
                Console.SetCursorPosition(x, y + 40); Console.Write("          h/              .-.`/){.){+oss+){.-){`        ){){  +dmmNN){  ){-     --+     `y+               \n");
                Console.SetCursorPosition(x, y + 41); Console.Write("          .h+`                 `---.----.`           /-` .){///-` ./){       /s.     -m`              \n");
                Console.SetCursorPosition(x, y + 42); Console.Write("           .os-`                                      .){){-````.){/){`         ++     .N`              \n");
                Console.SetCursorPosition(x, y + 43); Console.Write("             `/o/.`                                      `.----.             ){+`   oy               \n");
                Console.SetCursorPosition(x, y + 44); Console.Write("              `.os--.`                                                        `//`+y`               \n");
                Console.SetCursorPosition(x, y + 45); Console.Write("          `-/++/.    `-`                                     ){             .`   .+h){`               \n");
                Console.SetCursorPosition(x, y + 46); Console.Write("          ){y/-....-){/.       .      .                       ){.             .){     `){++-``           \n");
                Console.SetCursorPosition(x, y + 47); Console.Write("            .-){/oy+.       .-`     .){         .        `.  ){){              +//.      `){+so-`        \n");
                Console.SetCursorPosition(x, y + 48); Console.Write("             .so){`    ``.-/.      ./         .y.        .//-              +){ `){/-`       .+s+`      \n");
                Console.SetCursorPosition(x, y + 49); Console.Write("             `){/){//){/+sho-       ){/        .+o-s-   ``-/o/`             `o/     .){){){.`````.){d/      \n");
                Console.SetCursorPosition(x, y + 50); Console.Write("                   `yy){`       .+-      `/so. ./hooooo/-              `){h/``       `/dsooo+/-.`     \n");
                Console.SetCursorPosition(x, y + 51); Console.Write("                    .+o+++///+yo` `.-){+oo){`   h+.``                `-+o){){ddysoo++++oo){.```````      \n");
                Console.SetCursorPosition(x, y + 52); Console.Write("                             sy+++o+){-`       `+o/-`          ``-+syo-```.sy``````                  \n");
                Console.SetCursorPosition(x, y + 53); Console.Write("                                                 .){+++++++ossoo+sy){+osssso/`                        \n");
                Console.SetCursorPosition(x, y + 54); Console.Write("                                                          `){/+++){`                                  \n");
            }


            else if (pokenumber == 139)
            {
                Console.SetCursorPosition(x, y); Console.Write("\n");
                Console.SetCursorPosition(x, y + 1); Console.Write("                                                +s.                                                  \n");
                Console.SetCursorPosition(x, y + 2); Console.Write("                                              `h`o+                                                 \n");
                Console.SetCursorPosition(x, y + 3); Console.Write("                                              /o  -o-           `-.                                 \n");
                Console.SetCursorPosition(x, y + 4); Console.Write("                                             `d.    +yo++++/){){oo/.s-                                \n");
                Console.SetCursorPosition(x, y + 5); Console.Write("                           -/-`         -/+++/s.....){-    ``.){///--h                                \n");
                Console.SetCursorPosition(x, y + 6); Console.Write("                           `h-){///){../oso/){--.-.....`           ./+o+/`                             \n");
                Console.SetCursorPosition(x, y + 7); Console.Write("                            /s   ``){oo.`           `.--..`        ./`.+o-                           \n");
                Console.SetCursorPosition(x, y + 8); Console.Write("                             s/      `s                  .-.       `+  `/o){                         \n");
                Console.SetCursorPosition(x, y + 9); Console.Write("                             `d/    .){-                    `-.      ./   `/s.                       \n");
                Console.SetCursorPosition(x, y + 10); Console.Write("                            .o/){){-.............`             ..      +     `y/                      \n");
                Console.SetCursorPosition(x, y + 11); Console.Write("                           /o...---..```````````..-..`        -`     +      /oo                     \n");
                Console.SetCursorPosition(x, y + 12); Console.Write("                    ``.--){oh++){){-.                `.-){-.       ){     /      /`o+                    \n");
                Console.SetCursorPosition(x, y + 13); Console.Write("                  /yo){--....`````.){`           -//){-s/ ./.     ){    `){     --  y-                   \n");
                Console.SetCursorPosition(x, y + 14); Console.Write("                   ./+/`          `/         .o/`  s/   `){-    ){..-){){/-. .){.  `){h--.`               \n");
                Console.SetCursorPosition(x, y + 15); Console.Write("                     `-+s){.       .-        .y-   -y      --  -){``    `-+. `//){..-/+/               \n");
                Console.SetCursorPosition(x, y + 16); Console.Write("                       ){o-/+){-...-.         y.    ++       /.){`  `---.  `){/o.  ./h.`                \n");
                Console.SetCursorPosition(x, y + 17); Console.Write("                       h`   `..--.....-...-){o     ){s``     `+-..){/.``-){  /o`  //`y-                 \n");
                Console.SetCursorPosition(x, y + 18); Console.Write("                      -y  ``.--.````       .s      oo...`  ){`  -+   ` `){ y`  ){s` ++                 \n");
                Console.SetCursorPosition(x, y + 19); Console.Write("                      ++...`                +-     `/o){.`../```o.   -  / y   h){--o+                 \n");
                Console.SetCursorPosition(x, y + 20); Console.Write("       ``.``          o+`  `.....``       ``.+){      `-++){-/...s`   /``/ y  .h   o/                 \n");
                Console.SetCursorPosition(x, y + 21); Console.Write("     ){+/){){){/+){.       o/-){){){--...``. `.){+++//+s/`       `/oo`  -){   .-.` s- -s   y.                 \n");
                Console.SetCursorPosition(x, y + 22); Console.Write("    ){s-.-..``-o/     ){y+-`         .//-.`      -/         `){o/` +-`    `.h- ){s  .h                  \n");
                Console.SetCursorPosition(x, y + 23); Console.Write("    `-----){+-  o/    `/h+){-.``     -.   .-----.+-           `+s-..-){-){){/+s  /o--s-                  \n");
                Console.SetCursorPosition(x, y + 24); Console.Write("           `y  `h`  `s/`  `---){){---`  `){...`  `){-             s+ `..){///-  .s` ++                   \n");
                Console.SetCursorPosition(x, y + 25); Console.Write("            s-  o/  o+   -){){-){.      .y` - -    +             ){h/){--.`  `.//` /o                    \n");
                Console.SetCursorPosition(x, y + 26); Console.Write("            +/  .s-.+s` ){-..``-){`   `/){. `..`   +             oo   `.-){/){-){.`/+                     \n");
                Console.SetCursorPosition(x, y + 27); Console.Write("            .y.  `){/+o//y `.-  ){+){---` ){.`..-``){-            ){h--){//oo+/){-.+o){                      \n");
                Console.SetCursorPosition(x, y + 28); Console.Write("          `/oyh+//){){){){/+//`... ){. ``````.-----.`           `/y/){.       `-){o+.                      \n");
                Console.SetCursorPosition(x, y + 29); Console.Write("        `+o){.`    `...`  `-------/..-+.......`            .s/``.-){///+/-.`  .++.            `-.     \n");
                Console.SetCursorPosition(x, y + 30); Console.Write("        s/                   `-.){- `o       ./){`         ..+/+/){.``-/y-.-){/){.`.++-`       .+/oo     \n");
                Console.SetCursorPosition(x, y + 31); Console.Write("       ){s   `-){){-`           ){  `/ -+`````---``/           .s`       ){o    `){/){`./++){-..-++-/o`     \n");
                Console.SetCursorPosition(x, y + 32); Console.Write("       +/ `+o){-.-/+.        `+--.){  ------```.){/            .+o/){){.   ++`     `){/){.`-){){){-./+-       \n");
                Console.SetCursorPosition(x, y + 33); Console.Write("      `){s/o.      -y+-`      /..-){. /+){){---..-){               /+-`-/-  /o/---){/. `-){){/){){){){.         \n");
                Console.SetCursorPosition(x, y + 34); Console.Write("     /+os.      `s+` -/s){--+``-..`/ `){){` `...`                 `){o){`){+/-.----/s){                    \n");
                Console.SetCursorPosition(x, y + 35); Console.Write("     y. +s-`  `){s.  .+y/  -s    `......){///////){-.`               /s  `.){///){-                      \n");
                Console.SetCursorPosition(x, y + 36); Console.Write("     -s. `){++//-  .o+`h  oy){        -+o+){.`    `.-){){///){-`        -y                                \n");
                Console.SetCursorPosition(x, y + 37); Console.Write("      `++-`    .){o+.  s-`m){      `/+){`                 `.){////////-                                 \n");
                Console.SetCursorPosition(x, y + 38); Console.Write("        `){///++){.      ///++/){){//){`                                                                 \n");
                Console.SetCursorPosition(x, y + 39); Console.Write("                                                                \n");
            }

            else if (pokenumber == 140)
            {
                Console.SetCursorPosition(x, y); Console.Write("\n");
                Console.SetCursorPosition(x, y + 1); Console.Write("                                       `--){----------------.`                                        \n");
                Console.SetCursorPosition(x, y + 2); Console.Write("                              `-------.`                  -+++){){-.                                  \n");
                Console.SetCursorPosition(x, y + 3); Console.Write("                         `-----`                         .){   -){-.){---                              \n");
                Console.SetCursorPosition(x, y + 4); Console.Write("                     .){){){-                                --.`  `o   `---.                          \n");
                Console.SetCursorPosition(x, y + 5); Console.Write("                 `){/o-                                       .---`       `-){-`                      \n");
                Console.SetCursorPosition(x, y + 6); Console.Write("              `){/){``/-                                                      `-){-`                   \n");
                Console.SetCursorPosition(x, y + 7); Console.Write("            -o+..--){`                                                          `){-.                 \n");
                Console.SetCursorPosition(x, y + 8); Console.Write("          ){/-`...`                                                                -){.               \n");
                Console.SetCursorPosition(x, y + 9); Console.Write("        -/.                                                                         -/`             \n");
                Console.SetCursorPosition(x, y + 10); Console.Write("      ./.                                                                           .+){){            \n");
                Console.SetCursorPosition(x, y + 11); Console.Write("     /){`                  ){                                                          ){-.){`          \n");
                Console.SetCursorPosition(x, y + 12); Console.Write("   `/-                    ){`                     .){oyhdyyo/-`                         +` --         \n");
                Console.SetCursorPosition(x, y + 13); Console.Write("  `+`        -+ydh+-`      /                 `-odNMMMMMMMMMN+.                      `+  ./`       \n");
                Console.SetCursorPosition(x, y + 14); Console.Write("  +`      .+hNMMMMMNdo-`   `-.            .){sdNMMMMMMMMMMMMMMMMmy-                     -){  `/`      \n");
                Console.SetCursorPosition(x, y + 15); Console.Write(" /.     .sNMMMMMMMMMMMNdy+-.``.      `.){ohmMMMMMMMMMMMMMMMMMMMMMMNy.                    o   `/`     \n");
                Console.SetCursorPosition(x, y + 16); Console.Write(" s     /mMMMMMMMMMMMMMMMMMNmmdhysssyhmNMMMMMMNmNNMMMMMMMMMMMMMMMMMMm){                   ){){    /`    \n");
                Console.SetCursorPosition(x, y + 17); Console.Write(" h    +.dMMMMMMMMMMMmdddmMMMMMMMMMMMMMMMMMms){..../sNMMMMMMMMMMMMMMMMNo`                  ){-   `/    \n");
                Console.SetCursorPosition(x, y + 18); Console.Write(" s    + yMMMMMMMMNs-`` `./hMMMMMMMMMMMMMMy`        .hMMMMMMMMMMMMMMMM){`                 ./.  ./   \n");
                Console.SetCursorPosition(x, y + 19); Console.Write(" o    / +MMMMMMMM/        `yMMMMMMMMMMMMm`          .MMMMMMMMMMMMMMMMMMNdo){`                -){` o`  \n");
                Console.SetCursorPosition(x, y + 20); Console.Write(" /`   ` .NMMMMMMN          ){MMMMMMMMMMMMd           `NMMMMMMMMMMMMMMMMMMMMM+){.             `/-.+  \n");
                Console.SetCursorPosition(x, y + 21); Console.Write(" `/`     +MMMMMMM/        `yMMMMMMMMMMMMM+         `sMMMMMMMMMMMMMMMMMMMMMMMMMMmy/.`           -/y` \n");
                Console.SetCursorPosition(x, y + 22); Console.Write("  `){-`    sMMMMMMNs-`` `.){hMMMMMMMMMMMMMMMy){.` ``./dMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMNd+.          `){/ \n");
                Console.SetCursorPosition(x, y + 23); Console.Write("    .){-``  sMMMMMMMMmdhdmMMMMMMMMMMMMMMMMMMMNdhddNMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMNs.          s \n");
                Console.SetCursorPosition(x, y + 24); Console.Write("      `.){-`-yNMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMNsooosdMMMMMMMMMN/         o \n");
                Console.SetCursorPosition(x, y + 25); Console.Write("        `+/- -hNMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMNs){`      `NMMMNNMMMMMo        +`\n");
                Console.SetCursorPosition(x, y + 26); Console.Write("       .+.     -smMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMy.          dd+){--yMMmyy+       o \n");
                Console.SetCursorPosition(x, y + 27); Console.Write("      -+         ./yNMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMd            o`     +d`  .){      o \n");
                Console.SetCursorPosition(x, y + 28); Console.Write("      s             +shNMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM+            ){-      +    --    `+ \n");
                Console.SetCursorPosition(x, y + 29); Console.Write("      o            /){.+-/ymNMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM/             +      ./    -`   +` \n");
                Console.SetCursorPosition(x, y + 30); Console.Write("      +`           + ./    -+hmMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMd             o       -+.` ){`  ){){  \n");
                Console.SetCursorPosition(x, y + 31); Console.Write("      `+           `+o`   `   `yoohmNMMMMMMMMMMMMMMMMMMMMMMMMMMMNm){            o        o.-){s``-/   \n");
                Console.SetCursorPosition(x, y + 32); Console.Write("       -){         `-){){---.-/.-+){`-/){/){so++ooooo++osdhhmNNNNmdhs+-+.           /-      `/`   `..     \n");
                Console.SetCursorPosition(x, y + 33); Console.Write("        ./.              `){){   ....  .+--.----.----    ````    `+-          `/.      ){){             \n");
                Console.SetCursorPosition(x, y + 34); Console.Write("          -){-`         .){){`         .+                ){/.-------           ){/      -/`              \n");
                Console.SetCursorPosition(x, y + 35); Console.Write("             ---){){.`.){){/){.        `){){                 `+-                ){){`     -){.                \n");
                Console.SetCursorPosition(x, y + 36); Console.Write("                 .--`    `--.------                     -){){.          -){-.--.----`                  \n");
                Console.SetCursorPosition(x, y + 37); Console.Write("                                                           .---.------ \n");
            }

            else if (pokenumber == 141)
            {
                Console.SetCursorPosition(x, y); Console.Write("\n");
                Console.SetCursorPosition(x, y + 1); Console.Write("                     `...........`        ``                                                         \n");
                Console.SetCursorPosition(x, y + 2); Console.Write("               ``..-..........  -       `  .`                                  ``.                  \n");
                Console.SetCursorPosition(x, y + 3); Console.Write("           ``.-....`         `  ){      .    ``.````````        ``....`     ```` ``                  \n");
                Console.SetCursorPosition(x, y + 4); Console.Write("        `.....              ``. ){     ``     `        `........``     ..```    `.                   \n");
                Console.SetCursorPosition(x, y + 5); Console.Write("       ....                .`  ){`){`   .     `                       ..        `.                    \n");
                Console.SetCursorPosition(x, y + 6); Console.Write("     ...`      `..........-`    ){ -.  .    ``                     ..         `.                     \n");
                Console.SetCursorPosition(x, y + 7); Console.Write("    ..`     ...`                -` --..    .                    `.          `.                      \n");
                Console.SetCursorPosition(x, y + 8); Console.Write("   ..`   `.-`                    -.){-){     .                  `.`          ..                       \n");
                Console.SetCursorPosition(x, y + 9); Console.Write("  - `  `-.                       ````-    .                  ..           -`                        \n");
                Console.SetCursorPosition(x, y + 10); Console.Write(" -   `-.                            `/`   .                .-`          `){.                         \n");
                Console.SetCursorPosition(x, y + 11); Console.Write(".`  .-                               `){   -               --           -- `..                       \n");
                Console.SetCursorPosition(x, y + 12); Console.Write("- `-`                                 -`  ){`            .){`-         .-.``..-){                      \n");
                Console.SetCursorPosition(x, y + 13); Console.Write("-.-                                    ){` --           .){){.-       .-.      ``                      \n");
                Console.SetCursorPosition(x, y + 14); Console.Write("..                                      -.`){          -.`.`      `-.`..````````                     \n");
                Console.SetCursorPosition(x, y + 15); Console.Write("                                         `..-        -`      ```.-` `. .     ``....`                \n");
                Console.SetCursorPosition(x, y + 16); Console.Write("                                           `--      -`````````  -    - `          ``-.`             \n");
                Console.SetCursorPosition(x, y + 17); Console.Write("                                             `-..``.`.   .`    `-  `.-  `````````````.){             \n");
                Console.SetCursorPosition(x, y + 18); Console.Write("                                               `..`  `.   ..```.  .....` . ```....`````             \n");
                Console.SetCursorPosition(x, y + 19); Console.Write("                                             `````.`  `...-.`..  ````  - `-``    ``.`               \n");
                Console.SetCursorPosition(x, y + 20); Console.Write("                                         `````  `  ..`     `.`  `-     .` ``..``....`               \n");
                Console.SetCursorPosition(x, y + 21); Console.Write("                                      `.``````..`.` `..-..``...`.-```..      `.`  ```               \n");
                Console.SetCursorPosition(x, y + 22); Console.Write("                                    ..` `.`   .`  ..``.......-```..  -         -``  `.`             \n");
                Console.SetCursorPosition(x, y + 23); Console.Write("                                  `.` `.`      .   ````        .`  . .`        - `....){             \n");
                Console.SetCursorPosition(x, y + 24); Console.Write("                                 `-  .`      ``.  .`           -`   - -        `-  ```              \n");
                Console.SetCursorPosition(x, y + 25); Console.Write("                                 -  -`    ``.``  .             `.--.){`-.        ){    ```            \n");
                Console.SetCursorPosition(x, y + 26); Console.Write("                                -  -    `.`      -          ``..``````.){        ..     `.`          \n");
                Console.SetCursorPosition(x, y + 27); Console.Write("                               `. -`   `.        -..`````...``         ){         ){       `.         \n");
                Console.SetCursorPosition(x, y + 28); Console.Write("                               - ..   ..        .``..-```              -.   ```.`-``       .`       \n");
                Console.SetCursorPosition(x, y + 29); Console.Write("                               - ){   .`         .    -                  .-.`-  `/. ````     `.      \n");
                Console.SetCursorPosition(x, y + 30); Console.Write("                              .`..  `.          -   .`                     `-... `-   ```     .`    \n");
                Console.SetCursorPosition(x, y + 31); Console.Write("                              .`){   -          ..  -                        ..    `.     ```   ``   \n");
                Console.SetCursorPosition(x, y + 32); Console.Write("                              `.){  .`          ){  -                          `..   .-      `.`  ``  \n");
                Console.SetCursorPosition(x, y + 33); Console.Write("                               ){.` .          -` `.                            `-`  `..      `.`  ` \n");
                Console.SetCursorPosition(x, y + 34); Console.Write("                               ){ ` .         .`  .                               ){`   `-       `.```\n");
                Console.SetCursorPosition(x, y + 35); Console.Write("                               -`  .        .`   .`                               ){    ..        ``-\n");
                Console.SetCursorPosition(x, y + 36); Console.Write("                                ){  .      `..... .`                               `.    -           \n");
                Console.SetCursorPosition(x, y + 37); Console.Write("                                .. -```-`..`.`  ..                                 -    -           \n");
                Console.SetCursorPosition(x, y + 38); Console.Write("                                .){`-.``.`.   -`  .                                 -  `..           \n");
                Console.SetCursorPosition(x, y + 39); Console.Write("                                . -..`   -``.....`                                 ....`.-`         \n");
                Console.SetCursorPosition(x, y + 40); Console.Write("                                  `.`...`                                          ){`.````){/`       \n");
                Console.SetCursorPosition(x, y + 41); Console.Write("                                  ..`                                             `-` -  . `--      \n");
                Console.SetCursorPosition(x, y + 42); Console.Write("                                                                                 .`  .-``..`  ){     \n");
                Console.SetCursorPosition(x, y + 43); Console.Write("                                                                                 - .`      `-.-     \n");
                Console.SetCursorPosition(x, y + 44); Console.Write("                                                                                  ){          .){  \n");
            }

            else if (pokenumber == 142)
            {
                Console.SetCursorPosition(x, y); Console.Write("                              +H+                       \n");
                Console.SetCursorPosition(x, y + 1); Console.Write("                             H;;+          +HHHHHHHHHHH+\n");
                Console.SetCursorPosition(x, y + 2); Console.Write("                             +;+ +H+   +HH+;;;;;HHHHH+  \n");
                Console.SetCursorPosition(x, y + 3); Console.Write("                            +;;HH;;HHH+;;;;;;+HHH+HH+   \n");
                Console.SetCursorPosition(x, y + 4); Console.Write("                         H  H;+H;;++;;;;+HHHHHH+++H+    \n");
                Console.SetCursorPosition(x, y + 5); Console.Write("                        H;H H;HH;++;;+HHHHHH++++H+      \n");
                Console.SetCursorPosition(x, y + 6); Console.Write("                        +;+HH;HH++HHHHHHH++++++H        \n");
                Console.SetCursorPosition(x, y + 7); Console.Write("                         H;;+;;;HHHHHH++++++++H         \n");
                Console.SetCursorPosition(x, y + 8); Console.Write("                          +HH+;;;HHH+++++++++H          \n");
                Console.SetCursorPosition(x, y + 9); Console.Write("                             H;;+HH+++++++++H           \n");
                Console.SetCursorPosition(x, y + 10); Console.Write("                             +;+HH++++++++++            \n");
                Console.SetCursorPosition(x, y + 11); Console.Write("                            +;;HHH+++++++++H     +HHHHH+\n");
                Console.SetCursorPosition(x, y + 12); Console.Write("                      H+    H;;HHH++++++++H  +HH+;;;;;H \n");
                Console.SetCursorPosition(x, y + 13); Console.Write("                   H+ +HH+  H;+HH+++++++++HH+;;;;;;;;H  \n");
                Console.SetCursorPosition(x, y + 14); Console.Write("                  H;H  +HHH++;HHH++++++++H;;;;;;;;;;H   \n");
                Console.SetCursorPosition(x, y + 15); Console.Write("   +H+           H;++  HHHHH;;HHH+++++++++;;;;;;;;;H    \n");
                Console.SetCursorPosition(x, y + 16); Console.Write("  +;;;H         H;++  H+HHH+;;HHH+++++++H;;;;;;;;;H     \n");
                Console.SetCursorPosition(x, y + 17); Console.Write("  H+;;+    +HHH+;++H H++HH+;;;+HH+++++++H;;;;;;;;+      \n");
                Console.SetCursorPosition(x, y + 18); Console.Write(" ++;;;;H+ +;;;;;++HHH++HH+;;;HHHH++++++++;;;;;;;;H      \n");
                Console.SetCursorPosition(x, y + 19); Console.Write(" H;;;;;;;H;++H;;;;+HH+HH+;;;+HHHHH++++++;;;;;;;;H       \n");
                Console.SetCursorPosition(x, y + 20); Console.Write("+;;;;;;;;;+   ;;;H+HHHH+;;+HHHHHHHH++++H;;;;;;;H        \n");
                Console.SetCursorPosition(x, y + 21); Console.Write("H;;;;;;;;+  H ;;;H++HH+;;+HHHH+++HHHH+++;;;;;;H         \n");
                Console.SetCursorPosition(x, y + 22); Console.Write("H;;;;;;;;;++H+;;H+++HH;;;HHHH++++++++HH;;;;;;;H         \n");
                Console.SetCursorPosition(x, y + 23); Console.Write("+;+HH+;;;;;;;;;;H++HH+;;+HHH++++++++++H;;;;;;+          \n");
                Console.SetCursorPosition(x, y + 24); Console.Write(" +    +HHH++;;;;;++HH;;++HH+++++++++++++;;;;;H          \n");
                Console.SetCursorPosition(x, y + 25); Console.Write("       H+++H++;;;+HHH;++HH+++++++++++++H;;;;;+          \n");
                Console.SetCursorPosition(x, y + 26); Console.Write("      H+H++++;;;H+HH+;+HHH++++++++++HH+;;;;;+           \n");
                Console.SetCursorPosition(x, y + 27); Console.Write("      HH H;;;;;H+++H;++HHH+++++++HH+;;;;;;;;H           \n");
                Console.SetCursorPosition(x, y + 28); Console.Write("    +H H+;;;;H++++++;++HHH+++++H+;;;+H;;;;;;H           \n");
                Console.SetCursorPosition(x, y + 29); Console.Write("   + H+;;;;H+  H++++;;+HHHH+++H+;;;;;;+H;;;;H           \n");
                Console.SetCursorPosition(x, y + 30); Console.Write("   H+;;;;+H     H++;;;;+HHH++H++;;;;;;;;+H;;H           \n");
                Console.SetCursorPosition(x, y + 31); Console.Write("  H;;;;;+H       H++;;;;+HHH+++;;;+HHHH+;;H+H           \n");
                Console.SetCursorPosition(x, y + 32); Console.Write("  +H;;++++        H;;;;;;+HHH++;H+      +HHHH           \n");
                Console.SetCursorPosition(x, y + 33); Console.Write("    H+++H         H;;;;;;;;+H+++            +           \n");
                Console.SetCursorPosition(x, y + 34); Console.Write("     HHH          H;;;;;;;;;;+HH+                       \n");
                Console.SetCursorPosition(x, y + 35); Console.Write("                  +;;;;;;;;;;;+++H                      \n");
                Console.SetCursorPosition(x, y + 36); Console.Write("                   +;;;;;;;;;;;;++H                     \n");
                Console.SetCursorPosition(x, y + 37); Console.Write("                   H;;;;;;;;;;;;;;++H                   \n");
                Console.SetCursorPosition(x, y + 38); Console.Write("           H       +;;+;;;;;;+;;;;;;;H                  \n");
                Console.SetCursorPosition(x, y + 39); Console.Write("          ++H       HHH;;;;;;H;;;;;;;;H                 \n");
                Console.SetCursorPosition(x, y + 40); Console.Write("          H++H       H;;;;;;;H;;;;;;;;;H                \n");
                Console.SetCursorPosition(x, y + 41); Console.Write("          H;++H      +;;;;+++H+;;;;;;;;;H               \n");
                Console.SetCursorPosition(x, y + 42); Console.Write("          H;;++H    +;;;;+++HHH+;;;;;;;;;H              \n");
                Console.SetCursorPosition(x, y + 43); Console.Write("          H;;;++H   H;;;;++H    +H;;;;;;;+              \n");
                Console.SetCursorPosition(x, y + 44); Console.Write("          H;;;;++H  H;;;;+H   +HH H+;;;;;;+             \n");
                Console.SetCursorPosition(x, y + 45); Console.Write("          H;;;;;;;H +;;;;H   H;;+ H++;;;;;H             \n");
                Console.SetCursorPosition(x, y + 46); Console.Write("          H;;;;;+H   H;;;;+HH;;H  ++++;;;;H             \n");
                Console.SetCursorPosition(x, y + 47); Console.Write("          +;;;;;H     +H+;;;;;;+   H+H;;;;H             \n");
                Console.SetCursorPosition(x, y + 48); Console.Write("           +H+;;;H       +HH+;++H+  HH;;;;+             \n");
                Console.SetCursorPosition(x, y + 49); Console.Write("              H;;;H         H;++++H  +;;;+              \n");
                Console.SetCursorPosition(x, y + 50); Console.Write("               H;;;+H+       +;++++H+;;;;H              \n");
                Console.SetCursorPosition(x, y + 51); Console.Write("                +H;;;;+H+    H++++H+;;;;H               \n");
                Console.SetCursorPosition(x, y + 52); Console.Write("                  +H+;;;;+HHHHHH+;;;;;;H                \n");
                Console.SetCursorPosition(x, y + 53); Console.Write("                     +HH+;;;;;;;;;;;;+H                 \n");
                Console.SetCursorPosition(x, y + 54); Console.Write("                         +H+;;;;;+HH+                   \n");
                Console.SetCursorPosition(x, y + 55); Console.Write("                            +HHHHH+\n");
            }

            else if (pokenumber == 143)
            {
                Console.SetCursorPosition(x, y); Console.Write("      ){){                                              \n");
                Console.SetCursorPosition(x, y + 1); Console.Write("      HHH){                   ){HH                      \n");
                Console.SetCursorPosition(x, y + 2); Console.Write("      HHHHH){               ){HHHH                      \n");
                Console.SetCursorPosition(x, y + 3); Console.Write("      HHHHHH){ ){HHHHHHHHH){ ){HHHHH                      \n");
                Console.SetCursorPosition(x, y + 4); Console.Write("      HHHHHHHHHHHHHHHHHHH){HHHHHH                      \n");
                Console.SetCursorPosition(x, y + 5); Console.Write("      ){HHHHHHHHHHHHHHHHHHHHHHHHH                      \n");
                Console.SetCursorPosition(x, y + 6); Console.Write("      ,HHHHHHHH){,,,,){HHHH){,,){HHH                      \n");
                Console.SetCursorPosition(x, y + 7); Console.Write("       HHHHHH){,      ,){H){    ,){H                      \n");
                Console.SetCursorPosition(x, y + 8); Console.Write("       HHHHH){,  ){HH){  ,){  ){H){ ,){                      \n");
                Console.SetCursorPosition(x, y + 9); Console.Write("      ){HHHH){,,){H             ){H,){                     \n");
                Console.SetCursorPosition(x, y + 10); Console.Write("      HHHHH,,,,       ){){){       H                     \n");
                Console.SetCursorPosition(x, y + 11); Console.Write("      HHHH){,,,,      ){){){){){      ){,                    \n");
                Console.SetCursorPosition(x, y + 12); Console.Write("      HHHH,,,,,,    ,){){){){){,     ,){                    \n");
                Console.SetCursorPosition(x, y + 13); Console.Write("     ,HHHH,,,,,,,   H){){,,){H     ,H,                   \n");
                Console.SetCursorPosition(x, y + 14); Console.Write("     ){HHHH,,,,,,,,  H){ ,, H    ,,HH){,){HHHH){,          \n");
                Console.SetCursorPosition(x, y + 15); Console.Write("     H){){){HHHH){,,,,,){HHHHHHHHHHHH){HHHHHHHHHHH){         \n");
                Console.SetCursorPosition(x, y + 16); Console.Write("    ){){HHHH){,){H){,){HH){){,,         ,){HHH ,HHHHHH){        \n");
                Console.SetCursorPosition(x, y + 17); Console.Write("   ){HHHHHHHH){, HH){){,,             ,){H ){HHHHHHH){       \n");
                Console.SetCursorPosition(x, y + 18); Console.Write("  ){HHHHHHHHHHHHH){,,,               ,){HH){,, HHHH){      \n");
                Console.SetCursorPosition(x, y + 19); Console.Write("  HHHHHHHHHHHH){, ){,                  ){H,,  HHHHH      \n");
                Console.SetCursorPosition(x, y + 20); Console.Write(" ,HHHHHHHHHHHHH){ H,                   ){H  ){HHHHH){     \n");
                Console.SetCursorPosition(x, y + 21); Console.Write(" ){HHHHHHHHHHHHHH){,                     ){HHHHHHHHH     \n");
                Console.SetCursorPosition(x, y + 22); Console.Write(" HHHHHHHHHHHHHH,,,                      ){HHHHHHHH     \n");
                Console.SetCursorPosition(x, y + 23); Console.Write(",HHHHHHHHHHHHH){,,,,                     ,){HHHHHH){     \n");
                Console.SetCursorPosition(x, y + 24); Console.Write("){HHHHHHHHHHHH){,,,,,,                    ,,HHH){ HHH){   \n");
                Console.SetCursorPosition(x, y + 25); Console.Write("HHHHHHHHHHHH){,,,,,,){,                   ,,HHH, HH,H H){\n");
                Console.SetCursorPosition(x, y + 26); Console.Write("HHHHHHHHHHHH,,){,,,H H,                 ,,){HH){,,){, H){,H\n");
                Console.SetCursorPosition(x, y + 27); Console.Write("HHHHHHHHHHH){,){ ){,){   ){,,H){            ,,,H){){){){H ){H){, H\n");
                Console.SetCursorPosition(x, y + 28); Console.Write("HHHHHHHHHHH,,H  HH,  H){H,H,,        ,,,,){H){){,,     ){ ){\n");
                Console.SetCursorPosition(x, y + 29); Console.Write("HHHHHHHHHHH,){,  ){){,, ){H, H,,,,,,,,,,,,,,H){){,,      ,){ \n");
                Console.SetCursorPosition(x, y + 30); Console.Write("){HHHHHHHHHHHH,,){,,){H){,){, ){,,,,,,,,,,,,,){H){,,,       H \n");
                Console.SetCursorPosition(x, y + 31); Console.Write(",HHHHHHHHHH){,){H,      ,){H,,,,,,,,,,,,,){H){){,,        ){ \n");
                Console.SetCursorPosition(x, y + 32); Console.Write(" HHHHHHHHHH,,,,         ,){,,,,,,,,){HHHHH){,,,   ,){,  ,){\n");
                Console.SetCursorPosition(x, y + 33); Console.Write(" HHHHHHHHHH,,,           H,,,){HHHHHHHHHH){,,   ,){){){,  H\n");
                Console.SetCursorPosition(x, y + 34); Console.Write(" HHHHHHHHH){,,,   ,){){){,   ){){){HHHHHHHHHHHH){,,   ){){){){){  H\n");
                Console.SetCursorPosition(x, y + 35); Console.Write(" HHHHHHHHH,,,    ){){){){){,  ,HHHHHHHHHHHHHH){,,   ){){){){){  H\n");
                Console.SetCursorPosition(x, y + 36); Console.Write(" HHHHHHHHH,,,   ,){){){){){){   HHHHHHHHHHHHHH){,,   ){){){){, ,){\n");
                Console.SetCursorPosition(x, y + 37); Console.Write(" HHHHHHHHH,,,   ){){){){){){){   HHHHHHHHHHHHHH){,,   ,){){,  ){ \n");
                Console.SetCursorPosition(x, y + 38); Console.Write(" HHHHHHHHH,,,   ){){){){){){){   HHHHHHHHHHHHHH){,,    ,,   H \n");
                Console.SetCursorPosition(x, y + 39); Console.Write(" ){HHHHHHHH,,,   ){){){){){){){   HHHHHHHHHHHHHH){,,,       ,){ \n");
                Console.SetCursorPosition(x, y + 40); Console.Write(" ,HHHHHHHH,,,   ){){){){){){,   HHHHHHHHHHHHHHH){,,      ,){  \n");
                Console.SetCursorPosition(x, y + 41); Console.Write("  HHHHHHHH,,,   ,){){){){){   ,HHHHHHHHHHHHHHH){,,,,  ,,H   \n");
                Console.SetCursorPosition(x, y + 42); Console.Write("  ){HHHHHHH,,,    ,){){){,   ){HHHHHHHHHHHHHHHH){,,,,,H){    \n");
                Console.SetCursorPosition(x, y + 43); Console.Write("   ){HHHHHH){,,,    ,){,   ,HHHHHHHHHHHHHHHHHHHHHH){      \n");
                Console.SetCursorPosition(x, y + 44); Console.Write("    ){HHHHHH,,,          ){HHHHHHHHHHHHHHHHHH){,         \n");
                Console.SetCursorPosition(x, y + 45); Console.Write("     ){HHHHH){,,,        ,HHHHHHHHH){,                   \n");
                Console.SetCursorPosition(x, y + 46); Console.Write("      ){HHHHH){,,,      ,){HHHHHH){,                      \n");
                Console.SetCursorPosition(x, y + 47); Console.Write("        H){HHH){,,,    ,){HH){,                           \n");
                Console.SetCursorPosition(x, y + 48); Console.Write("              ){HHHHHH){\n");
            }

            else if (pokenumber == 144)
            {
                Console.SetCursorPosition(x, y); Console.Write("    ){--){.                                                                                .--/`      \n");
                Console.SetCursorPosition(x, y + 1); Console.Write("    +   -){.                                                                           .){){.  --      \n");
                Console.SetCursorPosition(x, y + 2); Console.Write("    -){    -){`                                                                    .){///.   `/){       \n");
                Console.SetCursorPosition(x, y + 3); Console.Write("     .-    `){-                                                             `-){///-`    .){/){         \n");
                Console.SetCursorPosition(x, y + 4); Console.Write("  ----`-.     -.`                                                     `-///){.``    `-){/){`           \n");
                Console.SetCursorPosition(x, y + 5); Console.Write("  +` `--){/.     -){.                                               .){//){.....`` .-){//-----){          \n");
                Console.SetCursorPosition(x, y + 6); Console.Write("  `/-    `-//.    -/.                                          -/+){``---`    ..`       .){){          \n");
                Console.SetCursorPosition(x, y + 7); Console.Write("`----){.     `.`    `){){                                       /+-``){){-`             .){){){-`           \n");
                Console.SetCursorPosition(x, y + 8); Console.Write("./``.-){/-`           `+`                                   `o){ ./){`           `-/++/){---            \n");
                Console.SetCursorPosition(x, y + 9); Console.Write(" -){`    `...`      `. ./                                   o){ //`         `.---.``   `){/            \n");
                Console.SetCursorPosition(x, y + 10); Console.Write(" .-/){.      `       ){  o                                  ){o -o         ```       `-){){`             \n");
                Console.SetCursorPosition(x, y + 11); Console.Write("o``.-){/){--.`        ){` o                                  y` s.               `-){){){.`               \n");
                Console.SetCursorPosition(x, y + 12); Console.Write("-/-    ```..`       ){`.o                                 ){+ -o           .--){//){){----               \n");
                Console.SetCursorPosition(x, y + 13); Console.Write(" `.){){-.             ){ +-                                 s. o.         `-.``       -/               \n");
                Console.SetCursorPosition(x, y + 14); Console.Write("    `-){//){.`        ){`s                                 `y `s                 `--){){.                \n");
                Console.SetCursorPosition(x, y + 15); Console.Write("  -){){.``           ..+-                                 ){+ ){/           `..-){//){){){-                 \n");
                Console.SetCursorPosition(x, y + 16); Console.Write(" /-`   `..`        ){`s                                  o- +`        `..```    .-){-                 \n");
                Console.SetCursorPosition(x, y + 17); Console.Write(" .){){){++){.`        ..+-                                  y  /              `--){){.`                   \n");
                Console.SetCursorPosition(x, y + 18); Console.Write("  `){){.`           .`s                                  `o  -         `.---------                    \n");
                Console.SetCursorPosition(x, y + 19); Console.Write("  +.   `.-..     ``/){         `    `.-`                ){){  .              `.--){){                    \n");
                Console.SetCursorPosition(x, y + 20); Console.Write("  ){){){/++){``      ` s        `-/`..-`){.  .){             o` ``        `.--){//--`                      \n");
                Console.SetCursorPosition(x, y + 21); Console.Write("   -/-`    `       y       .){`){-`  ){-.--/.            `+                   `-){                      \n");
                Console.SetCursorPosition(x, y + 22); Console.Write("  ){/`   ...`       s`      / .- `..```./.            `+`       ``...------){){-`                      \n");
                Console.SetCursorPosition(x, y + 23); Console.Write("  ./){){){/){`         .+.     -`){`-```.-){){`           .){){`        ``.-){){){-.``                          \n");
                Console.SetCursorPosition(x, y + 24); Console.Write("    `-){`  .--`    ```/){     ){//){++/`.-          `-){.`        ````    `.-){-                          \n");
                Console.SetCursorPosition(x, y + 25); Console.Write("    -/..-/){.       `.`-/`  ){..){){..`  /`      `.-.`            ```.){){...``./`                        \n");
                Console.SetCursorPosition(x, y + 26); Console.Write("    `..){/.   .`     `..`/. .){--`     ){.    .--`              .`    ./){..--){`                        \n");
                Console.SetCursorPosition(x, y + 27); Console.Write("      `o``.){/.        `-`-- /        -){  `-.` ``              .){.`   -/`                            \n");
                Console.SetCursorPosition(x, y + 28); Console.Write("       ){){--/`   `      `-.`){){        `o .-` `.`             `  `){--...){/                            \n");
                Console.SetCursorPosition(x, y + 29); Console.Write("         `+`  `-` `      -`/          ){--  ..           ``   -`  ){.```.`  `...---){){---..`           \n");
                Console.SetCursorPosition(x, y + 30); Console.Write("         .+..){o` .` `    `){`           `  -`             `.  `/-` +`  `.-){-..`` `````...){){-`        \n");
                Console.SetCursorPosition(x, y + 31); Console.Write("          ...){){`){` -.   `-`        `-    ..       ``  ``  `/.`){--){/--){-.`  ..-){){-.```.----){/-`      \n");
                Console.SetCursorPosition(x, y + 32); Console.Write("             /){+` -/   `/-          /`   `         -   -.  ){-.- `-){-`  `-){){..`           `.-/+){     \n");
                Console.SetCursorPosition(x, y + 33); Console.Write("             ``--){o  ` ){/`          ./     `` `    `+` `/){-/` `-){.  `-){-.`  `..-){){){-..---..` `-/`   \n");
                Console.SetCursorPosition(x, y + 34); Console.Write("                ` +-){){ .+-           /   `` ){` -   `o){){){. ` `-){.  `){){.` `.-){-..``..........-){-.`/.  \n");
                Console.SetCursorPosition(x, y + 35); Console.Write("                  `.`-`){+`          `/    ){-`){--/..+.     `){){.  .){){. `-){){.``.-){/){..){){....){/){....-+. \n");
                Console.SetCursorPosition(x, y + 36); Console.Write("                      ``){.-         `/     -/--..--`    .){){` `-/-``.){-. `.){-.` `-`  +     -.`.-..){s`\n");
                Console.SetCursorPosition(x, y + 37); Console.Write("                        `//        `){.      -         .){-` .-){. `-){-``.){-.       ){  /`     ){   `-`-/\n");
                Console.SetCursorPosition(x, y + 38); Console.Write("                          -){-    ..){-      -){      .-){.``-){-` .){){. .){){.          ){  /`     /     - /\n");
                Console.SetCursorPosition(x, y + 39); Console.Write("                           //--.){){``       ./ ``.---..-){-. .-){-``-){-`           -.  +     -.     . /\n");
                Console.SetCursorPosition(x, y + 40); Console.Write("                           .){ ..-.`.-      `o..--.-){-..`.){){-.`.){-.             .){  ){-    `/       `){\n");
                Console.SetCursorPosition(x, y + 41); Console.Write("                            ){-   `--){){`    .+..---.--){---..---.               -){  -){    `/`       ){`\n");
                Console.SetCursorPosition(x, y + 42); Console.Write("                             --  `-` `){){`  //---){){){-----...                 `){- `){-    `/.      `){` \n");
                Console.SetCursorPosition(x, y + 43); Console.Write("                              ){){-){`    `/`.+`                             `){){` .){.    `/.      `-`  \n");
                Console.SetCursorPosition(x, y + 44); Console.Write("                              ){`){`      /--+                           `.){-``.){.     .+.      .-    \n");
                Console.SetCursorPosition(x, y + 45); Console.Write("                             .){){`       ){ -`                       ``-){){.`.){-.     ./){`     `-`     \n");
                Console.SetCursorPosition(x, y + 46); Console.Write("                             /`){       .-){`                    ``-){){-.`.){-.      ./){`     `..       \n");
                Console.SetCursorPosition(x, y + 47); Console.Write("                      ``` ``){`){`       /--               ```-){){--.`.-){-.      `-/){`     `..         \n");
                Console.SetCursorPosition(x, y + 48); Console.Write("                    ...-){){){-` ..```   -./`         ```-){){){--.`.-){--.`      `-//-     `..`           \n");
                Console.SetCursorPosition(x, y + 49); Console.Write("                   -){.-){..--....../-`.- .-){- ```-){){){-){-.-){){---.`     ```-){/){-    ``...`             \n");
                Console.SetCursorPosition(x, y + 50); Console.Write("                   .. ){-){`){.-`  `.-..   `){){/){){--..-){---.`    ````.-){){){){-.`  ``.-){-.                 \n");
                Console.SetCursorPosition(x, y + 51); Console.Write("                       -  /.    ...){..///){-``----.`````.--){){){){){--.`` ```.-){){){-.`                    \n");
                Console.SetCursorPosition(x, y + 52); Console.Write("                                ){-){){){){.``-){--``.){){){){){-){-..``..-){){//){){){){){-`                          \n");
                Console.SetCursorPosition(x, y + 53); Console.Write("                                /o){.`.){){-..){){){){-..-){///){){){){){--.`                                    \n");
                Console.SetCursorPosition(x, y + 54); Console.Write("                              `/){``){){-.){//){){//){){){-.`                                                \n");
                Console.SetCursorPosition(x, y + 55); Console.Write("                             ){/``/){`.+o+/){-.                                                        \n");
                Console.SetCursorPosition(x, y + 56); Console.Write("                           `/. -+``/s/-                                                             \n");
                Console.SetCursorPosition(x, y + 57); Console.Write("                           +. /){ -+-                                                                \n");
                Console.SetCursorPosition(x, y + 58); Console.Write("                          ){- /){ +/                                                                  \n");
                Console.SetCursorPosition(x, y + 59); Console.Write("                          o `o +){                                                                   \n");
                Console.SetCursorPosition(x, y + 60); Console.Write("                          + /.-+                                                                    \n");
                Console.SetCursorPosition(x, y + 61); Console.Write("                          /.+.+-                                                                    \n");
                Console.SetCursorPosition(x, y + 62); Console.Write("                           /){//){                                                                    \n");
                Console.SetCursorPosition(x, y + 63); Console.Write("                            -o-o){                                                                   \n");
                Console.SetCursorPosition(x, y + 64); Console.Write("                              --+o/){-.``...`                                                        \n");
                Console.SetCursorPosition(x, y + 65); Console.Write("                                 `-){){///){){---.                                                      \n");
                Console.SetCursorPosition(x, y + 66); Console.Write("                                              `   \n");
            }

            else if (pokenumber == 145)
            {
                Console.SetCursorPosition(x, y); Console.Write("\n");
                Console.SetCursorPosition(x, y + 1); Console.Write("                                                                                                .-){o){\n");
                Console.SetCursorPosition(x, y + 2); Console.Write("                       /-                                                                `------){-  \n");
                Console.SetCursorPosition(x, y + 3); Console.Write("/o){--`                 .){){-                                         `//             `-----   -){.    \n");
                Console.SetCursorPosition(x, y + 4); Console.Write("  -){`.----.             --`){){         ){.                          -){/o-o`      .----.     `){){`      \n");
                Console.SetCursorPosition(x, y + 5); Console.Write("    -){.   `----- `o/----`){- `){-       ){--      `+`             -){- -/`/` `-----`        `){-         \n");
                Console.SetCursorPosition(x, y + 6); Console.Write("      .){-      `---++`  .-+.  `/-     / --    ){-/           `){){`  ){-`o----            -){){--         \n");
                Console.SetCursorPosition(x, y + 7); Console.Write("        .){-          .----./`   .){.){` /  ){. -){ ..         -){.    -/-.               -/-.-){.         \n");
                Console.SetCursorPosition(x, y + 8); Console.Write("          `){){             `--    .+y){){+   /){`  /  `../..){-                       `){){` .){.           \n");
                Console.SetCursorPosition(x, y + 9); Console.Write("       /++---){){`                  ){-      `   `){..-){/++){..                     .){-  .){.             \n");
                Console.SetCursorPosition(x, y + 10); Console.Write("          ---. ){){`                 -){             `.``---                    -){.  .){.               \n");
                Console.SetCursorPosition(x, y + 11); Console.Write("             `---){){.                `/.+    ){yy`   .--                     ){){`  .){.                 \n");
                Console.SetCursorPosition(x, y + 12); Console.Write("                 .-+o.              -. do-/+dh`  --`                    `/){   .){.                   \n");
                Console.SetCursorPosition(x, y + 13); Console.Write("   ./++/-------------){            `+--//--oo     `/                     ..----){--------/+-          \n");
                Console.SetCursorPosition(x, y + 14); Console.Write("       .-----`                      `// `/+){ .+--.`){`                           .------`            \n");
                Console.SetCursorPosition(x, y + 15); Console.Write("             .-----                 .o` +- .){){/`  .--                    .---){//){/){                 \n");
                Console.SetCursorPosition(x, y + 16); Console.Write("                  `-----.           /`-){      -`    `             .------`  .----`                  \n");
                Console.SetCursorPosition(x, y + 17); Console.Write("                        `-----`    /`){+             ){       .-----`    .----`                       \n");
                Console.SetCursorPosition(x, y + 18); Console.Write("                              +`  ){-){ ---       .){. /        ){-   -----`                            \n");
                Console.SetCursorPosition(x, y + 19); Console.Write("                          `){){/`  .+-`-/++-`    ---`-+        `.//-`                                 \n");
                Console.SetCursorPosition(x, y + 20); Console.Write("                          `o-){/``){){--){-  ){){`   .+`   ){-   `--/  -){`                                 \n");
                Console.SetCursorPosition(x, y + 21); Console.Write("                        `-){`+` o.   --    /.   /){     /---/`-+    ){){                                \n");
                Console.SetCursorPosition(x, y + 22); Console.Write("                    `//+--){+./ `/  ./){`   -){   .-.   `){){ -- //-`.-){-+){                              \n");
                Console.SetCursorPosition(x, y + 23); Console.Write("                       .----..` .){-`-/---){/.     `+--/`.){+ ){.`-/. -+ ./`                            \n");
                Console.SetCursorPosition(x, y + 24); Console.Write("                      `+----`     -){`     ){.      ){-` ---` ...`---.----/){                           \n");
                Console.SetCursorPosition(x, y + 25); Console.Write("                     -){){--------` +      ){){         .--/      -----+.. `-`                          \n");
                Console.SetCursorPosition(x, y + 26); Console.Write("                                ){ /    ){){             ){.  .--------+-.                              \n");
                Console.SetCursorPosition(x, y + 27); Console.Write("                                .){+  ){){              -. --/-                                        \n");
                Console.SetCursorPosition(x, y + 28); Console.Write("                                 ){.){){`.-){.            o){+` `){.                                      \n");
                Console.SetCursorPosition(x, y + 29); Console.Write("                                 -+){--``/         `    o.-+-..){`                                    \n");
                Console.SetCursorPosition(x, y + 30); Console.Write("                                `){`    +   `/+    o.   ./-./.--o`                                   \n");
                Console.SetCursorPosition(x, y + 31); Console.Write("                                      --  /- ){){  ---/   + .--                                       \n");
                Console.SetCursorPosition(x, y + 32); Console.Write("                                      + .//`/`+  /){-+/` `/                                          \n");
                Console.SetCursorPosition(x, y + 33); Console.Write("                                     `/){. ){){  ){.`){ .){ ){- /                                          \n");
                Console.SetCursorPosition(x, y + 34); Console.Write("                                     -){        //      `){+`                                         \n");
                Console.SetCursorPosition(x, y + 35); Console.Write("                                               /){        `        \n");
            }

            else if (pokenumber == 146)
            {
                Console.SetCursorPosition(x, y); Console.Write("                                                                                                 `  \n");
                Console.SetCursorPosition(x, y + 1); Console.Write("                                                                                               ``.. \n");
                Console.SetCursorPosition(x, y + 2); Console.Write("       `                                                                                    `.-  -  \n");
                Console.SetCursorPosition(x, y + 3); Console.Write("    ..``.                                ``.`                                          ``.`.``  .   \n");
                Console.SetCursorPosition(x, y + 4); Console.Write(" ``){`  `.                              ``. .                         `.              .``.``    `.   \n");
                Console.SetCursorPosition(x, y + 5); Console.Write(" ){-){   `.``                      `` .`.` `.`          `             `.`.            .``.       .    \n");
                Console.SetCursorPosition(x, y + 6); Console.Write(".`  -    .`                    ``. ``    ``          ..``   -`     `.  .          ```.`      -.     \n");
                Console.SetCursorPosition(x, y + 7); Console.Write("``  -    `.`              `` . -`     `.      .``````.` . .){..`   ..  -`      `````-.       --      \n");
                Console.SetCursorPosition(x, y + 8); Console.Write(" `` -       .             ){){){...    ``.      `-         - ..  .`  -   `-````.`  ..-`      ```       \n");
                Console.SetCursorPosition(x, y + 9); Console.Write("  . ```     `.``      ``  `.){     ..-        .`       ``.``   -  `-``...`     `.``        .         \n");
                Console.SetCursorPosition(x, y + 10); Console.Write("  .`  .       `-      ){.. ..     `-     `.`   .      `-``..` `.````         ``         `.`          \n");
                Console.SetCursorPosition(x, y + 11); Console.Write("   `. ..`     ..    ...`.`.   ```-      `-`.` .`    `-`.`..          .-```..          -`            \n");
                Console.SetCursorPosition(x, y + 12); Console.Write("    `.``.`     `-``-`   `.    +.-    -`.`.  -`..     ````       ````.``` `            ){.            \n");
                Console.SetCursorPosition(x, y + 13); Console.Write("      .. -`      `.-          ``.    -` `   ```     `.`     `..`                   `..`             \n");
                Console.SetCursorPosition(x, y + 14); Console.Write("       .``-.`    -      ```````.     `.          ````     `.-`                ````..                \n");
                Console.SetCursorPosition(x, y + 15); Console.Write("        -  `.-. -.`    `-`` ````   .`-.. ````.``     ` ``.`                 ```````                 \n");
                Console.SetCursorPosition(x, y + 16); Console.Write("        `````` .-.-````){`      ````.){){`..````    ```...``                 .`){`                      \n");
                Console.SetCursorPosition(x, y + 17); Console.Write("            `...``){-``-/-   ``   `..`-.`       ``.                      -..``                       \n");
                Console.SetCursorPosition(x, y + 18); Console.Write("               `..``...-``.-``.     -.       ...`                   ````-`                          \n");
                Console.SetCursorPosition(x, y + 19); Console.Write("               `.``..-...`` .` .   .`   ````..`               `-..`.````                            \n");
                Console.SetCursorPosition(x, y + 20); Console.Write("              `.`--``  ``.`` `..       --`.`        ``.`       ){` `                                 \n");
                Console.SetCursorPosition(x, y + 21); Console.Write("             ....`        `..  .        `.`..```.`````         ){`                                   \n");
                Console.SetCursorPosition(x, y + 22); Console.Write("            `.`              ..`            `.``              -){                                    \n");
                Console.SetCursorPosition(x, y + 23); Console.Write("                              -               ``             ){-.`                                   \n");
                Console.SetCursorPosition(x, y + 24); Console.Write("                              .                 .            ` --                                   \n");
                Console.SetCursorPosition(x, y + 25); Console.Write("                              .                  .`          ...                                    \n");
                Console.SetCursorPosition(x, y + 26); Console.Write("                              `.       `          ..``       -                                      \n");
                Console.SetCursorPosition(x, y + 27); Console.Write("                              .`       .           - -      .                                       \n");
                Console.SetCursorPosition(x, y + 28); Console.Write("                              `.       `.          - ````````                                       \n");
                Console.SetCursorPosition(x, y + 29); Console.Write("                               -`  ```` ..         -                                                \n");
                Console.SetCursorPosition(x, y + 30); Console.Write("                                ...```.````.``  ``.`                                                \n");
                Console.SetCursorPosition(x, y + 31); Console.Write("                                 . `.         `.. `.                                                \n");
                Console.SetCursorPosition(x, y + 32); Console.Write("                               `.`.-             .` .`                                              \n");
                Console.SetCursorPosition(x, y + 33); Console.Write("                              .`..`               `. -                                              \n");
                Console.SetCursorPosition(x, y + 34); Console.Write("                         `...```.`                 . ``                                             \n");
                Console.SetCursorPosition(x, y + 35); Console.Write("                       .--..`.``..-               `.` ``.``                                         \n");
                Console.SetCursorPosition(x, y + 36); Console.Write("                       `.`-..     .             `--- ...-.-.                                        \n");
                Console.SetCursorPosition(x, y + 37); Console.Write("                          .`                       -.` .-.                                          \n");
                Console.SetCursorPosition(x, y + 38); Console.Write("                                                   `.   ``                                          \n");
            }

            else if (pokenumber == 147)
            {
                Console.SetCursorPosition(x, y); Console.Write("                              H  \n");
                Console.SetCursorPosition(x, y + 1); Console.Write("               +             H + \n");
                Console.SetCursorPosition(x, y + 2); Console.Write("  +HHHH+      + H           +; H \n");
                Console.SetCursorPosition(x, y + 3); Console.Write(" H+++;;;+H    H +           H; H \n");
                Console.SetCursorPosition(x, y + 4); Console.Write("+HH+++;;;;H   H  +   +HHHHH+;; H \n");
                Console.SetCursorPosition(x, y + 5); Console.Write("+   H++;;;;H  H; H H+;;;;;;;H  H \n");
                Console.SetCursorPosition(x, y + 6); Console.Write("     ++;;;;;+H+;; ++;;;;;;+H;H + \n");
                Console.SetCursorPosition(x, y + 7); Console.Write("     H++;;;;H;;H; H;;;;;;H  H;+ +\n");
                Console.SetCursorPosition(x, y + 8); Console.Write("      ++;;;;+;;;H H;;+H;;+; +;H H\n");
                Console.SetCursorPosition(x, y + 9); Console.Write("      H+;;;;;+;;  H;+  +;;+H;+ +H\n");
                Console.SetCursorPosition(x, y + 10); Console.Write("      H+;;;;;H;;  H;HH H;;;;;H H+\n");
                Console.SetCursorPosition(x, y + 11); Console.Write("      H;;;;;;H;   H;HHHH;;;;;HHH \n");
                Console.SetCursorPosition(x, y + 12); Console.Write("      H;;;;;;H   H+;+HH+;;+HH+H+ \n");
                Console.SetCursorPosition(x, y + 13); Console.Write("      +;;;;;;+  ++;;;++;+H    H  \n");
                Console.SetCursorPosition(x, y + 14); Console.Write("     +;;;;;;;;+H H+;;;+H       + \n");
                Console.SetCursorPosition(x, y + 15); Console.Write("     H;;;;;;;;H  H+;;++;;      H \n");
                Console.SetCursorPosition(x, y + 16); Console.Write("     +;;;;;;;;+   H;;+H;;;;    + \n");
                Console.SetCursorPosition(x, y + 17); Console.Write("    +;;;;;;;;;;+  H+;++;;;;;; +  \n");
                Console.SetCursorPosition(x, y + 18); Console.Write("    H;;;;;;;;;;H  H+;;+H+;;;;+   \n");
                Console.SetCursorPosition(x, y + 19); Console.Write("    H;;;;;;;;;+H  H+;;H;;+HH+    \n");
                Console.SetCursorPosition(x, y + 20); Console.Write("    H;;;;;;;;;+H  H+;+  ;;;H     \n");
                Console.SetCursorPosition(x, y + 21); Console.Write("    H;;;;;;;;;++H H+;H      +    \n");
                Console.SetCursorPosition(x, y + 22); Console.Write("    H;;;;;;;;;++HH+;;+      H    \n");
                Console.SetCursorPosition(x, y + 23); Console.Write("    H;;;;;;;;;+++H;;+       +    \n");
                Console.SetCursorPosition(x, y + 24); Console.Write("    H;;;;;;;;;;+H;;;H        +   \n");
                Console.SetCursorPosition(x, y + 25); Console.Write("    H+;;;;;;;;;H;;;;+        H   \n");
                Console.SetCursorPosition(x, y + 26); Console.Write("    +++;;;;;;;;;;;;H         H   \n");
                Console.SetCursorPosition(x, y + 27); Console.Write("     H++;;;;;;;;;;;+         H   \n");
                Console.SetCursorPosition(x, y + 28); Console.Write("     ++++;;;;;;;;;+          +   \n");
                Console.SetCursorPosition(x, y + 29); Console.Write("      H+++++;;;;;;H         +    \n");
                Console.SetCursorPosition(x, y + 30); Console.Write("      H++++++++++H;;;       H    \n");
                Console.SetCursorPosition(x, y + 31); Console.Write("       H++++++++H;;;;;;    +     \n");
                Console.SetCursorPosition(x, y + 32); Console.Write("        H++++++H;;;;;;;;  H      \n");
                Console.SetCursorPosition(x, y + 33); Console.Write("         H+++H+;;;;;;;;; H       \n");
                Console.SetCursorPosition(x, y + 34); Console.Write("          +HH;;;;;;;;;;H+        \n");
                Console.SetCursorPosition(x, y + 35); Console.Write("             +H;;;;;;H+          \n");
                Console.SetCursorPosition(x, y + 36); Console.Write("               +HHHH+\n");
            }

            else if (pokenumber == 148)
            {
                Console.SetCursorPosition(x, y); Console.Write("                          H){              \n");
                Console.SetCursorPosition(x, y + 1); Console.Write("                         H H            H){\n");
                Console.SetCursorPosition(x, y + 2); Console.Write("                        ){  H           H H\n");
                Console.SetCursorPosition(x, y + 3); Console.Write("                        H  ){          H  H\n");
                Console.SetCursorPosition(x, y + 4); Console.Write("              H){        ){   ){         H  ){\n");
                Console.SetCursorPosition(x, y + 5); Console.Write("            H){         ){ H  H  ){HHH){ ){  ){ \n");
                Console.SetCursorPosition(x, y + 6); Console.Write("           ){){          H  H  H){     ){H   ){\n");
                Console.SetCursorPosition(x, y + 7); Console.Write("          ){H           H     ){    ){   ){  H\n");
                Console.SetCursorPosition(x, y + 8); Console.Write("          HH           ){H ){ H    ){ ){  H H \n");
                Console.SetCursorPosition(x, y + 9); Console.Write("         ){){H           H H  ){    H H   HH \n");
                Console.SetCursorPosition(x, y + 10); Console.Write("         H H           ){ H ){){    ){H){  ){H){ \n");
                Console.SetCursorPosition(x, y + 11); Console.Write("         H){H            H HH){H){      ){ H  \n");
                Console.SetCursorPosition(x, y + 12); Console.Write("         HHH             ){HHHH ){     H H  \n");
                Console.SetCursorPosition(x, y + 13); Console.Write("        ){){  ){              HHH H     HH){  \n");
                Console.SetCursorPosition(x, y + 14); Console.Write("        H){){ H              H){HHH){   ){){H   \n");
                Console.SetCursorPosition(x, y + 15); Console.Write("        H){HHH              ){ ){HH){     ){){  \n");
                Console.SetCursorPosition(x, y + 16); Console.Write("        ){H){  H             H H){){       H  \n");
                Console.SetCursorPosition(x, y + 17); Console.Write("         H){){){H              ){ H){){      H  \n");
                Console.SetCursorPosition(x, y + 18); Console.Write("         ){HH ){H             H  H){){){   ){){  \n");
                Console.SetCursorPosition(x, y + 19); Console.Write("           ){H  ){H           ){   H){){){){){H   \n");
                Console.SetCursorPosition(x, y + 20); Console.Write("             H   ){H){         ){ H){){HHH){    \n");
                Console.SetCursorPosition(x, y + 21); Console.Write("              H     ){H       H H){){  H     \n");
                Console.SetCursorPosition(x, y + 22); Console.Write("               H){){    H      H  ){){){){){     \n");
                Console.SetCursorPosition(x, y + 23); Console.Write("                ){){){    H     ){   ){H){      \n");
                Console.SetCursorPosition(x, y + 24); Console.Write("                H){){){   ){      ){  ){  ){     \n");
                Console.SetCursorPosition(x, y + 25); Console.Write("                H){){){    ){     H  ){  H     \n");
                Console.SetCursorPosition(x, y + 26); Console.Write("      ){H){       ){){){     H     H  ){  ){     \n");
                Console.SetCursorPosition(x, y + 27); Console.Write("    H){   ){H   ){H){){      H     H  ){   ){    \n");
                Console.SetCursorPosition(x, y + 28); Console.Write("   H       ){H){          H     H  ){   H    \n");
                Console.SetCursorPosition(x, y + 29); Console.Write("  H                    ){H     H  ){   ){    \n");
                Console.SetCursorPosition(x, y + 30); Console.Write(" HH      ){             H){     H  ){    ){   \n");
                Console.SetCursorPosition(x, y + 31); Console.Write(" ){H      H){){){         ){){      ){  ){    H   \n");
                Console.SetCursorPosition(x, y + 32); Console.Write("){ ){       ){){){){){      ){ H     H   ){    H   \n");
                Console.SetCursorPosition(x, y + 33); Console.Write("H ){        ){H){){){   ){H H      ){  ){     H   \n");
                Console.SetCursorPosition(x, y + 34); Console.Write("H  ){         ){H){){){H  H      H   ){     H   \n");
                Console.SetCursorPosition(x, y + 35); Console.Write("H  ){           ){H){  H      H    ){     H   \n");
                Console.SetCursorPosition(x, y + 36); Console.Write("){   ){            ){H){     H){    ){      H   \n");
                Console.SetCursorPosition(x, y + 37); Console.Write(" ){   ){              ){HHH){      ){      H   \n");
                Console.SetCursorPosition(x, y + 38); Console.Write(" H    ){                       ){       H   \n");
                Console.SetCursorPosition(x, y + 39); Console.Write("  H    ){                     ){        ){   \n");
                Console.SetCursorPosition(x, y + 40); Console.Write("   H    ){){                  ){        H    \n");
                Console.SetCursorPosition(x, y + 41); Console.Write("    H     ){){             ){){){         ){    \n");
                Console.SetCursorPosition(x, y + 42); Console.Write("     H){     ){){){){    ){){){){){           H     \n");
                Console.SetCursorPosition(x, y + 43); Console.Write("       H){       ){){){){               H      \n");
                Console.SetCursorPosition(x, y + 44); Console.Write("         H){                       H       \n");
                Console.SetCursorPosition(x, y + 45); Console.Write("           ){H){                  ){H        \n");
                Console.SetCursorPosition(x, y + 46); Console.Write("              ){HH){           ){H){          \n");
                Console.SetCursorPosition(x, y + 47); Console.Write("                  ){HHHHHHHHH){\n");
            }

            else if (pokenumber == 149)
            {
                Console.SetCursorPosition(x, y); Console.Write("                                                     `-`                                            \n");
                Console.SetCursorPosition(x, y + 1); Console.Write("                    --`                              --`                    `                       \n");
                Console.SetCursorPosition(x, y + 2); Console.Write("                    --             .-.     `        .--                     ` `                     \n");
                Console.SetCursorPosition(x, y + 3); Console.Write("                    ){-`          `..`.-....---.....){--`                                             \n");
                Console.SetCursorPosition(x, y + 4); Console.Write("                    ---``....``...-` `-`---){-.....-``                                               \n");
                Console.SetCursorPosition(x, y + 5); Console.Write("                    `.-------){-`` `` ` `-````-`                           ```                       \n");
                Console.SetCursorPosition(x, y + 6); Console.Write("                      ``````.-``             `-`                                                    \n");
                Console.SetCursorPosition(x, y + 7); Console.Write("                         ```-``       `-){){`    ){`                           `                       \n");
                Console.SetCursorPosition(x, y + 8); Console.Write("                      ``````-/`      `-/yh){    `){          `````              `                     \n");
                Console.SetCursorPosition(x, y + 9); Console.Write("                        ````-o+       -/hdy`    -`         -``......``                              \n");
                Console.SetCursorPosition(x, y + 10); Console.Write("                    ````````.){-`      ``/-.      ){         `.){`........`                            \n");
                Console.SetCursorPosition(x, y + 11); Console.Write("                 ````` `  `-``                   ){          -){    ```...-`                          \n");
                Console.SetCursorPosition(x, y + 12); Console.Write("                    ``````-`              ``.    ){         `-/ `      `...-`                        \n");
                Console.SetCursorPosition(x, y + 13); Console.Write("                         `-`              --`    ..       `-.- `-       `..-`                       \n");
                Console.SetCursorPosition(x, y + 14); Console.Write("                      ``  .-` ``   .`    `){`      -.    ``---   ..        .--.                      \n");
                Console.SetCursorPosition(x, y + 15); Console.Write("                     ``  `-){.-.````````..-){        .-``..-.`     -`        .-){`                     \n");
                Console.SetCursorPosition(x, y + 16); Console.Write("                        `-){`  --.`.-..-..`-.        `){){.`         -         .-){                     \n");
                Console.SetCursorPosition(x, y + 17); Console.Write("            `   `.      -){`   -    ){```  ``/          ..          .`         --.                    \n");
                Console.SetCursorPosition(x, y + 18); Console.Write("           `){.-.){){``   `/.`   -    ){....```..          `-`         -          -){                    \n");
                Console.SetCursorPosition(x, y + 19); Console.Write("           `/.-`...-.``-){`    ){   ..        ){            ..        ..         -){                    \n");
                Console.SetCursorPosition(x, y + 20); Console.Write("          `-``   ````../){````.-.../` `    `.-.   -        `-`       -         -){                    \n");
                Console.SetCursorPosition(x, y + 21); Console.Write("          -){){`          `...`    ..`.`       -   -`         --      `.   `..  -){                    \n");
                Console.SetCursorPosition(x, y + 22); Console.Write("           --                   `-      `....-`   -`         `-`        -` `){`){){                    \n");
                Console.SetCursorPosition(x, y + 23); Console.Write("            .-`                 ){....        .-    ..          ./..... ){    `){o`                    \n");
                Console.SetCursorPosition(x, y + 24); Console.Write("              --`              .-  ..........`-     .-`          -.  `){.     +){           `.        \n");
                Console.SetCursorPosition(x, y + 25); Console.Write("                ...--..........){...           ){`      -`          .-         `         `..-){        \n");
                Console.SetCursorPosition(x, y + 26); Console.Write("                              .`               -       -.          `-                ... `){         \n");
                Console.SetCursorPosition(x, y + 27); Console.Write("                             `.  `...`.```.....){        .-          -`            ...   `){          \n");
                Console.SetCursorPosition(x, y + 28); Console.Write("                             ){...`             ..        `-.        /){        `...     `){           \n");
                Console.SetCursorPosition(x, y + 29); Console.Write("                            -`                `./          `..-..){./.-`   `...`       .-            \n");
                Console.SetCursorPosition(x, y + 30); Console.Write("                           `){            `....` `-..         -){){){-){/......`          -.             \n");
                Console.SetCursorPosition(x, y + 31); Console.Write("                          ..-      ```...`       -`          `` -.``               `-`              \n");
                Console.SetCursorPosition(x, y + 32); Console.Write("                         ){` ){......``           -`               ){               .){.                \n");
                Console.SetCursorPosition(x, y + 33); Console.Write("                        ){.  -`                .-.                -.          ``..-`                 \n");
                Console.SetCursorPosition(x, y + 34); Console.Write("                        ){   `-           ``...`){                  -        `--`..                   \n");
                Console.SetCursorPosition(x, y + 35); Console.Write("                       ..    `-`    ```..``    ){                  ){     `.-`.){.`                    \n");
                Console.SetCursorPosition(x, y + 36); Console.Write("                       -`     `--...```        -.                .- ``.){` /..`                      \n");
                Console.SetCursorPosition(x, y + 37); Console.Write("                       `-       `-`        ```...-`              /.){`` ){...                         \n");
                Console.SetCursorPosition(x, y + 38); Console.Write("                        -`        `...``...```   `.-`           ){. ..`..`                           \n");
                Console.SetCursorPosition(x, y + 39); Console.Write("                         -.         `.-.``         .){-`        ./``-.`                              \n");
                Console.SetCursorPosition(x, y + 40); Console.Write("                          .-`          `-`..`````..```.-       /){.`                                 \n");
                Console.SetCursorPosition(x, y + 41); Console.Write("                            --.`      `.    ```.-....../` .   `.                                    \n");
                Console.SetCursorPosition(x, y + 42); Console.Write("                        ``...`--     ..                `- `    -`                                   \n");
                Console.SetCursorPosition(x, y + 43); Console.Write("                     `-.``          .`                 -`      `){`                                  \n");
                Console.SetCursorPosition(x, y + 44); Console.Write("                   `--){-`        `..`                 -`        `-`                                 \n");
                Console.SetCursorPosition(x, y + 45); Console.Write("                  ./-..-){. ``...``                    ){`   `..----){                                 \n");
                Console.SetCursorPosition(x, y + 46); Console.Write("                   ){.){-.-){..`                         `-.-.+. -/.){`                                 \n");
                Console.SetCursorPosition(x, y + 47); Console.Write("                                                        ...){.-){`-`                                  \n");
                Console.SetCursorPosition(x, y + 48); Console.Write("                                                          `. `-   \n");
            }

            else if (pokenumber == 150)
            {
                Console.SetCursorPosition(x, y); Console.Write("\n");
                Console.SetCursorPosition(x, y + 1); Console.Write("                                               `/){+`                      ```                        \n");
                Console.SetCursorPosition(x, y + 2); Console.Write("                                              ){- .+`     `....``        -+-){/){                      \n");
                Console.SetCursorPosition(x, y + 3); Console.Write("                                              ./. `/--){){){-....--){){){){){-./){   +.                      \n");
                Console.SetCursorPosition(x, y + 4); Console.Write("                                               `/.  .`              `.){`  `/.                       \n");
                Console.SetCursorPosition(x, y + 5); Console.Write("                                                `/                       `+`                        \n");
                Console.SetCursorPosition(x, y + 6); Console.Write("                                                `o                       /.                         \n");
                Console.SetCursorPosition(x, y + 7); Console.Write("                                                ){-                       /.                         \n");
                Console.SetCursorPosition(x, y + 8); Console.Write("                                               `+                        ./                         \n");
                Console.SetCursorPosition(x, y + 9); Console.Write("                                               .){                        `+                         \n");
                Console.SetCursorPosition(x, y + 10); Console.Write("                                               `+    `.`           `     .+                         \n");
                Console.SetCursorPosition(x, y + 11); Console.Write("                                                ){-`-){``.-`      `..` `-.`/.                         \n");
                Console.SetCursorPosition(x, y + 12); Console.Write("                                                `+``o/o.` `- `- ```){+-/ ./                          \n");
                Console.SetCursorPosition(x, y + 13); Console.Write("                                                 ){- //Nh/. .){-/ .){hNh--.+`                          \n");
                Console.SetCursorPosition(x, y + 14); Console.Write("                        `-){){){){){-`                `+```){+ss){){.`){/yoo/.``+`                           \n");
                Console.SetCursorPosition(x, y + 15); Console.Write("                       `+-`   `.+.              `){+-     ``     `     -){                            \n");
                Console.SetCursorPosition(x, y + 16); Console.Write("                       /-       .o              +.`./-.            `-){-`                            \n");
                Console.SetCursorPosition(x, y + 17); Console.Write("                       ){/       ){+){`           ){){  --.-){){.` ``. `.){){.                               \n");
                Console.SetCursorPosition(x, y + 18); Console.Write("                        ){/-...-/){`./){--..`     o   o    s.){){-..){){-`                                 \n");
                Console.SetCursorPosition(x, y + 19); Console.Write("                         `..-+-`    -+){..-){-.` + `.+){---o````.+-                                    \n");
                Console.SetCursorPosition(x, y + 20); Console.Write("                  `...`      ){+      `){/-..-//){+){/){-.` `.--){``-){-.-.                                \n");
                Console.SetCursorPosition(x, y + 21); Console.Write("                -/){-.-){/-``.){/. -      .s){...-/-````.-){`  `..-){-  `){-                               \n");
                Console.SetCursorPosition(x, y + 22); Console.Write("               .o`     `o/--.  `o      o`     `o`     `/.      -``  -){                              \n");
                Console.SetCursorPosition(x, y + 23); Console.Write("        ```    -/       /-      +`     s       o`       +`     ` .){` ){-                             \n");
                Console.SetCursorPosition(x, y + 24); Console.Write("    `-//){){){){//){-s){`   `){o.``    `.   ``++.`  `){/-`      -/     .- -/  +`                            \n");
                Console.SetCursorPosition(x, y + 25); Console.Write("  `//-`       `-){os+){){){----){){){.````-/){-.-){){){){){. ./`     `+      /  +` ){/                            \n");
                Console.SetCursorPosition(x, y + 26); Console.Write(" .o.   ``...){.    `){+.       `-){){){){-`            `+.    `+      `  ){` ){s                            \n");
                Console.SetCursorPosition(x, y + 27); Console.Write("`o.  `){){----){+/`    `+){                           `/){`   /.      `..``/o                            \n");
                Console.SetCursorPosition(x, y + 28); Console.Write("){+  `+.       -+`     //                            ./-` `){){-..-){){-` ){./`                           \n");
                Console.SetCursorPosition(x, y + 29); Console.Write("o.  ){/         -o`     /+                             -/.    `    `  /..){                           \n");
                Console.SetCursorPosition(x, y + 30); Console.Write("y   +.          ){+      //                             `){){        /. ){-`/                           \n");
                Console.SetCursorPosition(x, y + 31); Console.Write("y   +.           //      o-                              +.       `o``+`/`                          \n");
                Console.SetCursorPosition(x, y + 32); Console.Write("s`  /){            +/     .o                              -/        .+ .+./`                         \n");
                Console.SetCursorPosition(x, y + 33); Console.Write("+-  .o             /+`    s.                             -){         -- .+.+`                        \n");
                Console.SetCursorPosition(x, y + 34); Console.Write("-+   +-             -o){   s`                        ./){){-){` .`       `  `/){o`                       \n");
                Console.SetCursorPosition(x, y + 35); Console.Write(" o`  `o.              -///-                      `){/-        ``       ````-/o){                      \n");
                Console.SetCursorPosition(x, y + 36); Console.Write(" .o   `o`                                      `//`              .){-){){){){){){/++s+                     \n");
                Console.SetCursorPosition(x, y + 37); Console.Write("  ){/   `+-                                    -+`                 -){        ){+){+-                   \n");
                Console.SetCursorPosition(x, y + 38); Console.Write("   //    ){+`                                 ){/`                   +         `o-){+`                 \n");
                Console.SetCursorPosition(x, y + 39); Console.Write("    ){+`   `//`                              ){/                     o          `s`-o`                \n");
                Console.SetCursorPosition(x, y + 40); Console.Write("     -+`    .//-                           -+                     .o           o. -+                \n");
                Console.SetCursorPosition(x, y + 41); Console.Write("      `+-     `-/){-.                     `-s                      +-           o.  /){               \n");
                Console.SetCursorPosition(x, y + 42); Console.Write("       `//`      `.-){){){---.....-------){){){){s.                     .o           `s   `s               \n");
                Console.SetCursorPosition(x, y + 43); Console.Write("         .+){`         ````......``````   ){/                     `o.           //    s`              \n");
                Console.SetCursorPosition(x, y + 44); Console.Write("           -/){`                         `o`                     +-           .o`    s`              \n");
                Console.SetCursorPosition(x, y + 45); Console.Write("             ./){`                       -/                    `+-           `o.     s`              \n");
                Console.SetCursorPosition(x, y + 46); Console.Write("               .){/-`                    +.                   `+-           `o-      s               \n");
                Console.SetCursorPosition(x, y + 47); Console.Write("                 `-/){.`                 o`                  .+-           -+.      `o               \n");
                Console.SetCursorPosition(x, y + 48); Console.Write("                    `-/){-.`             o`                `//`          ./){`       ){-               \n");
                Console.SetCursorPosition(x, y + 49); Console.Write("                       `.-){){){-.``       ){`              `){/.          .//.        ./                \n");
                Console.SetCursorPosition(x, y + 50); Console.Write("                            `.--){){){){-.-){+`            .){/.         `-/){.        .){){`                \n");
                Console.SetCursorPosition(x, y + 51); Console.Write("                                  `.){//){`          `.//.        `-){/-`       .-/-`                  \n");
                Console.SetCursorPosition(x, y + 52); Console.Write("                                  -/-`          `-/+){.````...-){/s){.      `.-/-.                     \n");
                Console.SetCursorPosition(x, y + 53); Console.Write("                                 `o         .){){){){-){---------..` o       `+-`                        \n");
                Console.SetCursorPosition(x, y + 54); Console.Write("                                  o`      `-){-`                 ){){      .+                          \n");
                Console.SetCursorPosition(x, y + 55); Console.Write("                                  o`     ./.                     +`     +.                          \n");
                Console.SetCursorPosition(x, y + 56); Console.Write("                                 `o     .o`                      +.     +                           \n");
                Console.SetCursorPosition(x, y + 57); Console.Write("                                 ){){     o.                      `o`     /`                          \n");
                Console.SetCursorPosition(x, y + 58); Console.Write("                                `o`    ){+                      `+-      `+-                         \n");
                Console.SetCursorPosition(x, y + 59); Console.Write("                                ){/     y`                    ./o/-`      `){/.                       \n");
                Console.SetCursorPosition(x, y + 60); Console.Write("                               `o`     h/-                  -+. `-s`       `//.`                    \n");
                Console.SetCursorPosition(x, y + 61); Console.Write("                              `o.      y`o`                 o`    o.         `){/){`                  \n");
                Console.SetCursorPosition(x, y + 62); Console.Write("                              /){       s.o.                 -o.``){s.`           .){/){.`       ````   \n");
                Console.SetCursorPosition(x, y + 63); Console.Write("                             ){/        ){o-                   `///-`-){/){.         ...){///){){){){/){){){//` \n");
                Console.SetCursorPosition(x, y + 64); Console.Write("                            ){/         `o.`..``                       .){+.        .-){/){){/++-`    .+){\n");
                Console.SetCursorPosition(x, y + 65); Console.Write("                           -+  `){//`    `/){..){){/-                       `+){`               -+-    `s\n");
                Console.SetCursorPosition(x, y + 66); Console.Write("                          -o      -+            //                        -//){.```         `/o-){--){.\n");
                Console.SetCursorPosition(x, y + 67); Console.Write("                          /){     `/o-){){){){){){){`   `s                           `-){){){){){){){){){--){-`       \n");
                Console.SetCursorPosition(x, y + 68); Console.Write("                           ){/){){){//-        `){////-  \n");
            }

            else if (pokenumber == 151)
            {
                Console.SetCursorPosition(x, y); Console.Write("                /H                   \n");
                Console.SetCursorPosition(x, y + 1); Console.Write("               / =/        /H/       \n");
                Console.SetCursorPosition(x, y + 2); Console.Write("         /HHHH/ ==H       H   H      \n");
                Console.SetCursorPosition(x, y + 3); Console.Write(" /H/  /H/      H==H      /=    H     \n");
                Console.SetCursorPosition(x, y + 4); Console.Write("/   HH=          =H      H==    /    \n");
                Console.SetCursorPosition(x, y + 5); Console.Write("H== ==           //      /==    H    \n");
                Console.SetCursorPosition(x, y + 6); Console.Write("/==             // /      H==   /    \n");
                Console.SetCursorPosition(x, y + 7); Console.Write(" H=   /H/==     H H /      H==   /   \n");
                Console.SetCursorPosition(x, y + 8); Console.Write("  H=  H=H/=     /H/ H       H==  H   \n");
                Console.SetCursorPosition(x, y + 9); Console.Write("   H= H HH/     =/ =/        H===H/  \n");
                Console.SetCursorPosition(x, y + 10); Console.Write("   H= H H /      ==H  H       H=H=H/ \n");
                Console.SetCursorPosition(x, y + 11); Console.Write("   /==/HH/=       H  H=/       H= HH/\n");
                Console.SetCursorPosition(x, y + 12); Console.Write("    H======       / H=/H      /=  / H\n");
                Console.SetCursorPosition(x, y + 13); Console.Write("     /H==/==     H H== /      H= /  H\n");
                Console.SetCursorPosition(x, y + 14); Console.Write("        HH/HHHHH/ H/==H       /= H =H\n");
                Console.SetCursorPosition(x, y + 15); Console.Write("         H///==/H///HH/      /=    //\n");
                Console.SetCursorPosition(x, y + 16); Console.Write("         ///====/HHH= H/     H=    / \n");
                Console.SetCursorPosition(x, y + 17); Console.Write("        H/===== =H=H  HH     H= =  H \n");
                Console.SetCursorPosition(x, y + 18); Console.Write("       H==/=     H H  H=/    H =/ // \n");
                Console.SetCursorPosition(x, y + 19); Console.Write("      H=  H=     / /  / H    H // H  \n");
                Console.SetCursorPosition(x, y + 20); Console.Write("     H=   /     /=      H    H // /  \n");
                Console.SetCursorPosition(x, y + 21); Console.Write("    H=   /=     H       H    H ///   \n");
                Console.SetCursorPosition(x, y + 22); Console.Write("   H==  /H=     H       H    H = H/  \n");
                Console.SetCursorPosition(x, y + 23); Console.Write("   /=H /H / =   H  =/= =/   H=  //H  \n");
                Console.SetCursorPosition(x, y + 24); Console.Write("    / /   H==/H H  /// /=/H H   H/H  \n");
                Console.SetCursorPosition(x, y + 25); Console.Write("          H==  /H  /// H==/H=   H=H  \n");
                Console.SetCursorPosition(x, y + 26); Console.Write("          H===  H  ///=/=====  /H=H  \n");
                Console.SetCursorPosition(x, y + 27); Console.Write("         H/==== /= =/=/====/HH/ /=/  \n");
                Console.SetCursorPosition(x, y + 28); Console.Write("        H///===///=   HHHH/    H H   \n");
                Console.SetCursorPosition(x, y + 29); Console.Write("       H//HH==///H=  =/        / /   \n");
                Console.SetCursorPosition(x, y + 30); Console.Write("      H///  /HHH/H== /        H H    \n");
                Console.SetCursorPosition(x, y + 31); Console.Write("      H//H      H/===H     /H/ H     \n");
                Console.SetCursorPosition(x, y + 32); Console.Write("       ////H/     /=/  /HH/=  H      \n");
                Console.SetCursorPosition(x, y + 33); Console.Write("        //////HHHHHHHH/====/H/       \n");
                Console.SetCursorPosition(x, y + 34); Console.Write("         /HH//==========/H/          \n");
                Console.SetCursorPosition(x, y + 35); Console.Write("             /HHHHHHHHH/\n");
            }

        }

    }
}


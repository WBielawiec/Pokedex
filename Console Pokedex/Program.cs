using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;


namespace Console_Pokedex
{
    class Program
    {
        private static void movement(int liczbaElementow, ref int pozycjaWskaznika, ConsoleKeyInfo wcisnietyKlawisz)
        {
            if (wcisnietyKlawisz.Key == ConsoleKey.DownArrow)
            {
                if (pozycjaWskaznika + 1 < liczbaElementow)
                    pozycjaWskaznika++;
                else
                    pozycjaWskaznika = 0;
            }
            else if (wcisnietyKlawisz.Key == ConsoleKey.UpArrow)
            {
                if (!(pozycjaWskaznika == 0))
                    pozycjaWskaznika--;
                else
                    pozycjaWskaznika = liczbaElementow - 1;
            }
        }

        private static void movement2d(int liczbaWierszy, int liczbaKolumn, ref int X, ref int Y, ConsoleKeyInfo wcisnietyKlawisz)
        {
            if (wcisnietyKlawisz.Key == ConsoleKey.DownArrow)
            {
                if (Y + 1 < liczbaWierszy)
                    Y++;
                else
                    Y = 0;
            }
            else if (wcisnietyKlawisz.Key == ConsoleKey.UpArrow)
            {
                if (!(Y == 0))
                    Y--;
                else
                    Y = liczbaWierszy - 1;
            }
            else if (wcisnietyKlawisz.Key == ConsoleKey.RightArrow)
            {
                if (X + 1 < liczbaKolumn)
                {
                    X++;
                }
                else
                {
                    X = 0;
                }
            }
            else if (wcisnietyKlawisz.Key == ConsoleKey.LeftArrow)
            {
                if (X != 0)
                {
                    X--;
                }
                else
                {
                    X = liczbaKolumn - 1;
                }
            }

        }

        public static void centerText(String text)
        {
            Console.Write(new string(' ', (Console.WindowWidth - text.Length) / 2));
            Console.WriteLine(text);
        }
        
        private static void pokemonData(int indexPokemon, int x, int y) {
            string startupPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName);
            string json = File.ReadAllText(startupPath + "\\dane\\pokemon.json");
            var pokemons = JsonConvert.DeserializeObject<List<Pokemon>>(json);


            for (int j = y - 2; j < y + 24; j++) {
                Console.SetCursorPosition(x-2, j);
                Console.WriteLine("#");

            }

            for (int i = x -1; i < x + 55; i++)
            {
                Console.SetCursorPosition(i, y-2);
                Console.WriteLine("#");
            }

            for (int j = y - 2; j < y + 24; j++)
            {
               Console.SetCursorPosition(x+55, j);
               Console.WriteLine("#");
            }

            for (int i = x - 1; i < x + 55; i++)
            {
                Console.SetCursorPosition(i, y + 23);
                Console.WriteLine("#");
            }

            Console.SetCursorPosition(x, y);
            Console.Write("Type: ");
            pokemons[indexPokemon].type.ForEach(delegate (string t)
            {
                Console.Write(t + ", ");
            });

            Console.SetCursorPosition(x, y+2);
            Console.Write("ATK: " + pokemons[indexPokemon].@base.Attack);
            Console.SetCursorPosition(x+20, y+2);
            Console.Write("DEF: " + pokemons[indexPokemon].@base.Defense);
            Console.SetCursorPosition(x, y+3);
            Console.Write("SPD: " + pokemons[indexPokemon].@base.Speed);
            Console.SetCursorPosition(x+20, y+3);
            Console.Write("HP:  " + pokemons[indexPokemon].@base.HP);
            Console.SetCursorPosition(x, y+4);
            Console.Write("SP.ATK: " + pokemons[indexPokemon].@base.SpAttack);
            Console.SetCursorPosition(x+20, y+4);
            Console.Write("SP.DEF: " + pokemons[indexPokemon].@base.SpDefense);

            Console.SetCursorPosition(x, y+6);
            Console.Write("Weight: " + pokemons[indexPokemon].profile.weight);
            Console.SetCursorPosition(x, y+7);
            Console.Write("Heigth: " + pokemons[indexPokemon].profile.height);

            Console.SetCursorPosition(x, y+9);
            Console.Write("Evolution: ");
            Console.SetCursorPosition(x+2, y+10);
            Console.Write("Previous: ");
            try
            {
                Console.Write(PokemonList.listaPokemonow[Convert.ToInt32(pokemons[indexPokemon].evolution.prev[0]) - 1] + " at ");
                Console.Write(pokemons[indexPokemon].evolution.prev[1]);
            }
            catch (System.NullReferenceException e)
            {
                Console.Write("-----");
            }
            catch (System.IndexOutOfRangeException e) {
                Console.Write("-----");
            }
            Console.SetCursorPosition(x+2, y+11);
            Console.Write("Next: ");
            try
            {
                Console.Write(PokemonList.listaPokemonow[Convert.ToInt32(pokemons[indexPokemon].evolution.next[0][0]) - 1] + " at ");
                Console.Write(pokemons[indexPokemon].evolution.next[0][1]);
            }
            catch (System.NullReferenceException e)
            {
                Console.Write("-----");
            }
            catch (System.IndexOutOfRangeException e)
            {
                Console.Write("-----");
            }

            Console.SetCursorPosition(x, y+13);
            Console.Write("Description: ");
            string[] description = pokemons[indexPokemon].description.Split(" ");
            int word = 1;
            Console.SetCursorPosition(x+2, y+14);
            for (int i = 1; i < description.Length+1; i++)
            {

                Console.Write(description[i-1] + " ");

                if (i % 6 == 0 )
                {
                    Console.SetCursorPosition(x+2, y+14 + word);
                    word++;
                }
            }
        }

        private static void movesTable() {
            string startupPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName);
            string json = File.ReadAllText(startupPath + "\\dane\\moves.json");
            var moves = JsonConvert.DeserializeObject<List<Moves>>(json);

            int widnowWidth = Console.WindowWidth;
            int size = 84;
            int leftSide = ((widnowWidth - size) / 2) +1;
            int rightSide = (widnowWidth - leftSide) + 2;
            int moveIndex = 0;


            while (true)
            {
                Console.Clear();
                
                //create table
                for (int i = 0; i < size; i++)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.SetCursorPosition(widnowWidth / 2 - size / 2 + i, 1);
                    Console.Write('_');
                    Console.SetCursorPosition(widnowWidth / 2 - size / 2 + i, 3);
                    Console.Write('-');
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.SetCursorPosition(widnowWidth / 2 - size / 2 + i, moves.Count+4);
                    Console.Write('-');
                }
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(widnowWidth / 2 - size / 2, 2);
                Console.Write("|  ID   |         NAME         |    TYPE    |   CATEGORY   |  PP  | POWER |ACCURACY|");

                for (int i = 0; i < moves.Count; i++)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.SetCursorPosition(widnowWidth / 2 - size / 2, 4 + i);
                    Console.Write("|       |                      |            |              |      |       |        |");

                    if (i == moveIndex)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                    Console.SetCursorPosition(leftSide + 1, 4 + i);
                    if (moves[i].id < 10)
                        Console.Write("00" + moves[i].id);
                    else if (moves[i].id < 100)
                        Console.Write("0" + moves[i].id);
                    else
                        Console.Write(moves[i].id);

                    Console.SetCursorPosition(leftSide + 9, 4 + i);
                    Console.Write(moves[i].name);

                    Console.SetCursorPosition(leftSide + 32, 4 + i);
                    Console.Write(moves[i].type);

                    Console.SetCursorPosition(leftSide + 45, 4 + i);
                    Console.Write(moves[i].category);

                    Console.SetCursorPosition(leftSide + 60, 4 + i);
                    Console.Write(moves[i].pp);

                    Console.SetCursorPosition(leftSide + 67, 4 + i);
                    Console.Write(moves[i].power);
                    if (moves[i].power == null) {
                        Console.Write("-");
                    }
                    Console.SetCursorPosition(leftSide + 75, 4 + i);
                    Console.Write(moves[i].accuracy);
                    if (moves[i].accuracy != null) {
                        Console.Write("%");
                    } else
                        Console.Write(" -");

                }
                string[] description = moves[moveIndex].description.Split(" ");
                int word = 1;

                if (moveIndex < 56)
                {

                    for (int i = 0; i < 47; i++) {
                        Console.SetCursorPosition(rightSide + 4 + i, 14);
                        Console.Write("#");
                        Console.SetCursorPosition(rightSide + 4 + i, 32);
                        Console.Write("#");
                    }

                    for (int i = 0; i < 18; i++)
                    {
                        Console.SetCursorPosition(rightSide + 4 , 14+i);
                        Console.Write("#");
                        Console.SetCursorPosition(rightSide + 50, 14 + i);
                        Console.Write("#");
                    }

                    Console.SetCursorPosition(rightSide + 6, 16);
                    for (int i = 1; i < description.Length + 1; i++)
                    {

                        Console.Write(description[i - 1] + " ");
                        if (i % 6 == 0)
                        {
                            Console.SetCursorPosition(rightSide + 6, 16 + word);
                            word++;
                        }
                    }
                    Console.SetCursorPosition(0, 0);
                }
                else if (moveIndex >= 56 && moveIndex < 116)
                {
                    for (int i = 0; i < 47; i++)
                    {
                        Console.SetCursorPosition(rightSide + 4 + i, 74);
                        Console.Write("#");
                        Console.SetCursorPosition(rightSide + 4 + i, 92);
                        Console.Write("#");
                    }

                    for (int i = 0; i < 18; i++)
                    {
                        Console.SetCursorPosition(rightSide + 4, 74 + i);
                        Console.Write("#");
                        Console.SetCursorPosition(rightSide + 50, 74 + i);
                        Console.Write("#");
                    }

                    Console.SetCursorPosition(rightSide + 6, 76);
                    for (int i = 1; i < description.Length + 1; i++)
                    {

                        Console.Write(description[i - 1] + " ");
                        if (i % 6 == 0)
                        {
                            Console.SetCursorPosition(rightSide + 6, 76 + word);
                            word++;
                        }
                    }
                    Console.SetCursorPosition(0, 60);
                }
                else if (moveIndex >= 116)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    for (int i = 0; i < 47; i++)
                    {
                        Console.SetCursorPosition(rightSide + 4 + i, 114);
                        Console.Write("#");
                        Console.SetCursorPosition(rightSide + 4 + i, 132);
                        Console.Write("#");
                    }

                    for (int i = 0; i < 18; i++)
                    {
                        Console.SetCursorPosition(rightSide + 4, 114 + i);
                        Console.Write("#");
                        Console.SetCursorPosition(rightSide + 50, 114 + i);
                        Console.Write("#");
                    }

                    Console.SetCursorPosition(rightSide + 6, 116);
                    for (int i = 1; i < description.Length + 1; i++)
                    {

                        Console.Write(description[i - 1] + " ");
                        if (i % 6 == 0)
                        {
                            Console.SetCursorPosition(rightSide + 6, 116 + word);
                            word++;
                        }
                    }

                    Console.SetCursorPosition(0, 100);
                }

                ConsoleKeyInfo pokemonKeyInfo = Console.ReadKey();
                movement(moves.Count, ref moveIndex, pokemonKeyInfo);

                if (pokemonKeyInfo.Key == ConsoleKey.Escape)
                {
                    break;
                }
            }
        }

        private static void items()
        {
            string startupPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName);
            string json = File.ReadAllText(startupPath + "\\dane\\items.json");
            var items = JsonConvert.DeserializeObject<List<Items>>(json);

            int widnowWidth = Console.WindowWidth;
            int itemIndex = 0;
            int tableLength = 60;
            int tableHeight = 8;
            string search;
            int searchIndex;

            var frame = new[] {
            @"╔══════════════════════════════════════════════════════════╗",
            @"║                                                          ║",
            @"║                                                          ║",
            @"║                                                          ║",
            @"║                                                          ║",
            @"║                                                          ║",
            @"║                                                          ║",
            @"╚══════════════════════════════════════════════════════════╝",
            };


            while (true) {

                Console.Clear();

                Console.SetCursorPosition(0, 22);
                foreach (string symbol in frame) {
                    centerText(symbol);
                }

                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition((widnowWidth - items[itemIndex].name.Length) / 2, 23);
                Console.Write(items[itemIndex].name);
                Console.ForegroundColor = ConsoleColor.White;
                splitText(widnowWidth, 25, items[itemIndex].description);

                /*                String information = "Press Up or Down Arrow to navigate. Press ENTER to search item.";

                                Console.Write(information);*/
                Console.SetCursorPosition(0,31);
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                centerText("Wciśnij UP lub DOWN aby zmieniać przedmioty. Wciśnij ENTER żeby wyszukać przedmiot.");
                Console.ForegroundColor = ConsoleColor.White;
                ConsoleKeyInfo pokemonKeyInfo = Console.ReadKey();
                movement(PokemonList.listaPokemonow.Count(), ref itemIndex, pokemonKeyInfo);

                if (pokemonKeyInfo.Key == ConsoleKey.Enter) {

                    Console.SetCursorPosition(0, 33);
                    centerText("┌────────────────────────┐");
                    centerText("│                        │");   
                    centerText("└────────────────────────┘");
                    Console.SetCursorPosition(widnowWidth / 2 -9, 34);
                    search = Console.ReadLine();

                    for(int i = 0; i<items.Count; i++) {
                        if (string.Equals(items[i].name, search, StringComparison.CurrentCultureIgnoreCase)){
                            itemIndex = i;
                            break;
                        }
                    }
                    
                }

                if (pokemonKeyInfo.Key == ConsoleKey.Escape)
                {
                    break;
                }
            }
        }

        private static void splitText(int x, int y, string text) {

            string[] description = text.Split(".");
            int size = 58;
            int additionalSpace = 0;

            for (int i = 0; i < description.Length - 1; i++)
            {
                char[] chararr = description[i].ToCharArray();
                if (chararr.Length < 58)
                {
                    Console.SetCursorPosition((x - description[i].Length) / 2, y + i + additionalSpace);
                    Console.Write(description[i] + ".");
                }
                else {
                    Console.SetCursorPosition((x - size) / 2, y + i);
                    string[] words = description[i].Split(" ");
                    int charsum = 0;
                    for (int j = 0; j < words.Length; j++) {
                        char[] letters = words[j].ToCharArray();
                        charsum += letters.Length;

                        if (charsum < size)
                        {
                            Console.Write(words[j]);
                            charsum++;

                            if (j != words.Length-1)
                            {
                                Console.Write(" ");
                            }
                        }
                        else {
                            Console.SetCursorPosition((x - 58) / 2, y + i+1);
                            charsum = 0;
                            additionalSpace++;
                        }
                    }
                    Console.Write(".");
                }
            }
        }


        static void Main(string[] args)
        {
            Console.Title = "Pokedex";
            Console.SetWindowSize(200, 60);
            Console.CursorVisible = false;
            int x = 0;
            WelcomeScreen ws = new WelcomeScreen();
            var sb = new StringBuilder();


            bool wasWelcome = false;

            var pressAnyKey = new[] {
                @" _    _      _           _ _       _                           _               _    _                _         ",
                @"| |  | |    (_)         (_|_)     | |                         | |             | |  | |              (_)        ",
                @"| |  | | ___ _ ___ _ __  _ _    __| | _____      ___ __   ___ | |_ __  _   _  | | _| | __ ___      ___ ___ ____",
                @"| |/\| |/ __| / __| '_ \| | |  / _` |/ _ \ \ /\ / / '_ \ / _ \| | '_ \| | | | | |/ / |/ _` \ \ /\ / / / __|_  /",
                @"\  /\  / (__| \__ \ | | | | | | (_| | (_) \ V  V /| | | | (_) | | | | | |_| | |   <| | (_| |\ V  V /| \__ \/ / ",
                @" \/  \/ \___|_|___/_| |_|_| |  \__,_|\___/ \_/\_/ |_| |_|\___/|_|_| |_|\__, | |_|\_\_|\__,_| \_/\_/ |_|___/___|",
                @"                         _/ |                                           __/ |                                  ",
                @"                        |__/                                           |___/                                   "
            };

            var blink = new[] {
                @"                                                                                                               ",
                @"                                                                                                               ",
                @"                                                                                                               ",
                @"                                                                                                               ",
                @"                                                                                                               ",
                @"                                                                                                               ",
                @"                                                                                                               ",
                @"                                                                                                               "
            };

            var pokedexMenu = new[] {
                @"     _____           _____     ____    ____       ______        _____        ______                                    ______  _______        ______    _____   ______    ____   ____ ",
                @" ___|\    \     ____|\    \   |    |  |    |  ___|\     \   ___|\    \   ___|\     \  _____      _____                |      \/       \   ___|\     \  |\    \ |\     \  |    | |    |",
                @"|    |\    \   /     /\    \  |    |  |    | |     \     \ |    |\    \ |     \     \ \    \    /    /               /          /\     \ |     \     \  \\    \| \     \ |    | |    |",
                @"|    | |    | /     /  \    \ |    | /    // |     ,_____/||    | |    ||     ,_____/| \    \  /    /               /     /\   / /\     ||     ,_____/|  \|    \  \     ||    | |    |",
                @"|    |/____/||     |    |    ||    |/ _ _//  |     \--'\_|/|    | |    ||     \--'\_|/  \____\/____/               /     /\ \_/ / /    /||     \--'\_|/   |     \  |    ||    | |    |",
                @"|    ||    |||     |    |    ||    |\    \'  |     /___/|  |    | |    ||     /___/|    /    /\    \              |     |  \|_|/ /    / ||     /___/|     |      \ |    ||    | |    |",
                @"|    ||____|/|\     \  /    /||    | \    \  |     \____|\ |    | |    ||     \____|\  /    /  \    \             |     |       |    |  ||     \____|\    |    |\ \|    ||    | |    |",
                @"|____|       | \_____\/____/ ||____|  \____\ |____ '     /||____|/____/||____ '     /|/____/ /\ \____\            |\____\       |____|  /|____ '     /|   |____||\_____/||\___\_|____|",
                @"|    |        \ |    ||    | /|    |   |    ||    /_____/ ||    /    | ||    /_____/ ||    |/  \|    |            | |    |      |    | / |    /_____/ |   |    |/ \|   ||| |    |    |",
                @"|____|         \|____||____|/ |____|   |____||____|     | /|____|____|/ |____|     | /|____|    |____|             \|____|      |____|/  |____|     | /   |____|   |___|/ \|____|____|",
                @"  \(              \(    )/      \(       )/    \( |_____|/   \(    )/     \( |_____|/   \(        )/                  \(          )/       \( |_____|/      \(       )/      \(   )/  ",
                @"   '               '    '        '       '      '    )/ '     '    '            )/       '        '                    '          '         '    )/          '       '        '   '   "

            };

            var pokemony = new[] {
                @"______         _                                          ",
                @"| ___ \       | |                                         ",
                @"| |_/ /  ___  | | __  ___  _ __ ___    ___   _ __   _   _ ",
                @"|  __/  / _ \ | |/ / / _ \| '_ ` _ \  / _ \ | '_ \ | | | |",
                @"| |    | (_) ||   < |  __/| | | | | || (_) || | | || |_| |",
                @"\_|     \___/ |_|\_\ \___||_| |_| |_| \___/ |_| |_| \__, |",
                @"                                                     __/ |",
                @"                                                    |___/ "
            };

            var umiejetnosci = new[] {
                @" _   _             _         _        _                             _ ",
                @"| | | |           (_)       (_)      | |                           (_)",
                @"| | | | _ __ ___   _   ___   _   ___ | |_  _ __    ___   ___   ___  _ ",
                @"| | | || '_ ` _ \ | | / _ \ | | / _ \| __|| '_ \  / _ \ / __| / __|| |",
                @"| |_| || | | | | || ||  __/ | ||  __/| |_ | | | || (_) |\__ \| (__ | |",
                @" \___/ |_| |_| |_||_| \___| | | \___| \__||_| |_| \___/ |___/ \___||_|",
                @"                           _/ |                                       ",
                @"                          |__/                                        "
            };

            var przedmioty = new[] {
                @"______                       _             _         _          ",
                @"| ___ \                     | |           (_)       | |         ",
                @"| |_/ / _ __  ____  ___   __| | _ __ ___   _   ___  | |_  _   _ ",
                @"|  __/ | '__||_  / / _ \ / _` || '_ ` _ \ | | / _ \ | __|| | | |",
                @"| |    | |    / / |  __/| (_| || | | | | || || (_) || |_ | |_| |",
                @"\_|    |_|   /___| \___| \__,_||_| |_| |_||_| \___/  \__| \__, |",
                @"                                                           __/ |",
                @"                                                          |___/ "
            };

            var zgadywanka = new[] {
                @" ______                   _                                 _           ",
                @"|___  /                  | |                               | |          ",
                @"   / /   __ _   __ _   __| | _   _ __      __  __ _  _ __  | | __  __ _ ",
                @"  / /   / _` | / _` | / _` || | | |\ \ /\ / / / _` || '_ \ | |/ / / _` |",
                @"./ /___| (_| || (_| || (_| || |_| | \ V  V / | (_| || | | ||   < | (_| |",
                @"\_____/ \__, | \__,_| \__,_| \__, |  \_/\_/   \__,_||_| |_||_|\_\ \__,_|",
                @"         __/ |                __/ |                                     ",
                @"        |___/                |___/                                      "
            };

            var exitProgram = new[] {
                @" _______   _______ _____ ",
                @"|  ___\ \ / /_   _|_   _|",
                @"| |__  \ V /  | |   | |  ",
                @"|  __| /   \  | |   | |  ",
                @"| |___/ /^\ \_| |_  | |  ",
                @"\____/\/   \/\___/  \_/  "

            };

            var whos = new[] {
                @" __    __ _          _       _   _           _                  _                                ___ ",
                @"/ / /\ \ \ |__   ___( )__   | |_| |__   __ _| |_    _ __   ___ | | _____ _ __ ___   ___  _ __   / _ \",
                @"\ \/  \/ / '_ \ / _ \/ __|  | __| '_ \ / _` | __|  | '_ \ / _ \| |/ / _ \ '_ ` _ \ / _ \| '_ \  \// /",
                @" \  /\  /| | | | (_) \__ \  | |_| | | | (_| | |_   | |_) | (_) |   <  __/ | | | | | (_) | | | |   \/ ",
                @"  \/  \/ |_| |_|\___/|___/   \__|_| |_|\__,_|\__|  | .__/ \___/|_|\_\___|_| |_| |_|\___/|_| |_|   () ",
                @"                                                   |_|                                               "
            };

            var easy = new[] {
                @"  ___  __ _ ___ _   _ ",
                @" / _ \/ _` / __| | | |",
                @"|  __/ (_| \__ \ |_| |",
                @" \___|\__,_|___/\__, |",
                @"                |___/ "
                };

            var hard = new[] {
                @" _                   _ ",
                @"| |__   __ _ _ __ __| |",
                @"| '_ \ / _` | '__/ _` |",
                @"| | | | (_| | | | (_| |",
                @"|_| |_|\__,_|_|  \__,_|"
            };





            var mainMenu = new[] {pokemony, umiejetnosci, przedmioty,zgadywanka,exitProgram};

            var levelMenu = new[] { easy, hard };

            while (true)
            {
                Console.Clear();

                ///////////////////////////////////////////////////////
                while (wasWelcome == false)
                {
                    ws.welcome();

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.SetCursorPosition(0, 38);

                    System.Threading.Thread.Sleep(600);

                    foreach (string line in pressAnyKey)
                    {
                        centerText(line);
                    }

                    Console.SetCursorPosition(0, 38);
                    System.Threading.Thread.Sleep(500);
                    foreach (string line in blink)
                    {
                        centerText(line);
                    }

                    if (Console.KeyAvailable == true)
                    {
                        wasWelcome = true;
                        Console.ReadKey();
                        Console.Clear();
                    }

                }

                //////////////////////////////////////////////////////
                //////////Menu główne////////////////////////////////
                /////////////////////////////////////////////////////
                Console.ForegroundColor = ConsoleColor.Red;
                foreach (string line in pokedexMenu)
                {
                    centerText(line);
                }

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.White;

                for (int i = 0; i < mainMenu.Count(); i++) {


                    if (x == i) {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                    } else {
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                    foreach (string line in mainMenu[i])
                    {
                        centerText(line);
                    }

                }

                ConsoleKeyInfo keyInfo = Console.ReadKey();
                movement(mainMenu.Length, ref x, keyInfo);

                /////////////////////////////
                //////////Pokemon's//////////
                ////////////////////////////
                if (keyInfo.Key == ConsoleKey.Enter && x == 0)
                {
                    int indexPokemon = 0;

                    while (true)
                    {
                        Console.Clear();
                        Console.WriteLine("Lista pokemonów:");
                        Console.WriteLine();
                        for (int i = 0; i < PokemonList.listaPokemonow.Count(); i++)
                        {
                            if (i == indexPokemon)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkYellow;

                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.White;
                            }

                            if (i + 1 < 10)
                            {
                                Console.Write("00" + (i + 1) + " :");
                            }
                            else if (i + 1 < 100)
                            {
                                Console.Write("0" + (i + 1) + " :");
                            }
                            else
                            {
                                Console.Write(i + 1 + " :");
                            }

                            Console.Write(PokemonList.listaPokemonow[i] + "\n");
                        }

                        if (indexPokemon < 58)
                        {
                            
                            PokemonList.showPokemon(indexPokemon + 1, 30, 10);
                            pokemonData(indexPokemon, 140 , 10);
                            Console.SetCursorPosition(0, 0);
                        }
                        else if (indexPokemon >= 58 && indexPokemon < 118)
                        {
                            PokemonList.showPokemon(indexPokemon + 1, 30, 70);
                            pokemonData(indexPokemon, 140, 70);
                            Console.SetCursorPosition(0, 60);
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            if (indexPokemon+1 == 138 || indexPokemon+1 == 142 || indexPokemon+1 == 144 || indexPokemon+1 == 150)
                                PokemonList.showPokemon(indexPokemon + 1, 30, 94);
                            else
                                PokemonList.showPokemon(indexPokemon + 1, 30, 100);
                            pokemonData(indexPokemon, 140, 104);
                            Console.SetCursorPosition(0, 94);
                        }


                        ConsoleKeyInfo pokemonKeyInfo = Console.ReadKey();
                        movement(PokemonList.listaPokemonow.Count(), ref indexPokemon, pokemonKeyInfo);

                        if (pokemonKeyInfo.Key == ConsoleKey.Escape)
                        {
                            break;
                        }
                    }
                }
                ///////////////////////////////////////////
                ////////moves//////////////////////
                //////////////////////////////////////
                if (keyInfo.Key == ConsoleKey.Enter && x == 1) {
                        movesTable();
                }

                if (keyInfo.Key == ConsoleKey.Enter && x == 2)
                {
                    items();
                }


                ////////////////////////////////////////////////////
                ///////////////////Quiz/////////////////////////////
                ////////////////////////////////////////////////////

                else if (keyInfo.Key == ConsoleKey.Enter && x == 3)
                {
                    int level = 0;
                    var rand = new Random();

                    while (true)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Blue;

                        foreach (string line in whos)
                        {
                            centerText(line);
                        }
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.White;

                        for (int i = 0; i < levelMenu.Count(); i++)
                        {
                            if (level == i)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.White;
                            }

                            foreach (string line in levelMenu[i])
                            {
                                centerText(line);
                            }

                        }

                        ConsoleKeyInfo levelKeyInfo = Console.ReadKey();
                        movement(levelMenu.Count(), ref level, levelKeyInfo);

                        //łatwy poziom
                        if (levelKeyInfo.Key == ConsoleKey.Enter && level == 0)
                        {
                            string correctAns, answer;
                            int pointCounter = 0;
                            int randomNumber;
                            List<int> pokemonRepeat = new List<int>();

                            string[,] options = new string[2, 2];
                            int ansX = 0;
                            int ansY = 0;

                            for (int i = 0; i < 10; i++)
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Blue;
                                foreach (string line in whos)
                                {
                                    centerText(line);
                                }
                                Console.WriteLine();

                                List<int> pokemonIndex = new List<int>();

                                for (int j = 0; j < 150; j++)
                                { //dodanie indexów poków do listy
                                    pokemonIndex.Add(j);
                                }

                                for (int j = 0; j < pokemonRepeat.Count(); j++)
                                { //usunięcie z listy indexów poków, które już wystąpiły
                                    pokemonIndex.Remove(pokemonRepeat.ElementAt(j));
                                }

                                int?[] optionRepeat = new int?[4];

                                for (int j = 0; j < 4; j++) //4 niepowtarzające się opcje
                                {
                                    randomNumber = rand.Next(pokemonIndex.Count);
                                    optionRepeat[j] = pokemonIndex.ElementAt(randomNumber);
                                    pokemonIndex.RemoveAt(randomNumber);
                                }

                                randomNumber = rand.Next(4); //wylosowanie poprawnej odpowiedzi

                                pokemonRepeat.Add(optionRepeat[randomNumber] ?? 0);

                                options[0, 0] = PokemonList.listaPokemonow[optionRepeat[0] ?? 0];
                                options[0, 1] = PokemonList.listaPokemonow[optionRepeat[1] ?? 0];
                                options[1, 0] = PokemonList.listaPokemonow[optionRepeat[2] ?? 0];
                                options[1, 1] = PokemonList.listaPokemonow[optionRepeat[3] ?? 0];

                                correctAns = PokemonList.listaPokemonow[optionRepeat[randomNumber] ?? 0];

                                while (true)
                                {
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    PokemonList.showPokemon((optionRepeat[randomNumber] ?? 0) + 1, 67, 10);

                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine();
                                    Console.WriteLine();
                                    centerText("NACIŚNIJ ENTER ŻEBY ZAZNACZYĆ PRAWIDŁOWĄ ODPOWIEDŹ");
                                    Console.Write(new string(' ', (Console.WindowWidth / 2 - 12)));


                                    for (int j = 0; j < 2; j++)
                                    {
                                        Console.ForegroundColor = ConsoleColor.White;
                                        for (int k = 0; k < 2; k++)
                                        {
                                            if (ansX == k && ansY == j)
                                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                            else
                                                Console.ForegroundColor = ConsoleColor.White;

                                            Console.Write(options[j, k]);
                                            Console.Write(new string(' ', ((15 - options[j, k].Length))));

                                        }

                                        Console.WriteLine();
                                        Console.Write(new string(' ', (Console.WindowWidth / 2 - 12)));
                                    }

                                    Console.WriteLine();
                                    Console.ForegroundColor = ConsoleColor.White;
                                    centerText("Liczba zdobytych punktów: " + pointCounter);

                                    ConsoleKeyInfo keyInfoAnswer = Console.ReadKey();
                                    movement2d(2, 2, ref ansX, ref ansY, keyInfoAnswer);

                                    if (keyInfoAnswer.Key == ConsoleKey.Enter)
                                    {
                                        if (ansX == 0 && ansY == 0)
                                        {
                                            answer = new string(options[0, 0]);
                                            if (string.Equals(answer, correctAns, StringComparison.CurrentCultureIgnoreCase))
                                            {
                                                pointCounter += 1;
                                                break;
                                            }
                                            else
                                            {
                                                centerText("Prawidłowa odpowiedź to: " + correctAns);
                                                centerText("Wciśnij dowolny klawisz... ");
                                                Console.ReadKey();
                                                break;
                                            }
                                        }
                                        else if (ansX == 0 && ansY == 1)
                                        {
                                            answer = new string(options[1, 0]);
                                            if (string.Equals(answer, correctAns, StringComparison.CurrentCultureIgnoreCase))
                                            {
                                                pointCounter += 1;
                                                break;
                                            }
                                            else
                                            {
                                                centerText("Prawidłowa odpowiedź to: " + correctAns);
                                                centerText("Wciśnij dowolny klawisz... ");
                                                Console.ReadKey();
                                                break;
                                            }
                                        }
                                        else if (ansX == 1 && ansY == 0)
                                        {
                                            answer = new string(options[0, 1]);
                                            if (string.Equals(answer, correctAns, StringComparison.CurrentCultureIgnoreCase))
                                            {
                                                pointCounter += 1;
                                                break;
                                            }
                                            else
                                            {
                                                centerText("Prawidłowa odpowiedź to: " + correctAns);
                                                centerText("Wciśnij dowolny klawisz... ");
                                                Console.ReadKey();
                                                break;
                                            }
                                        }
                                        else if (ansX == 1 && ansY == 1)
                                        {
                                            answer = new string(options[1, 1]);
                                            if (string.Equals(answer, correctAns, StringComparison.CurrentCultureIgnoreCase))
                                            {
                                                pointCounter += 1;
                                                break;
                                            }
                                            else
                                            {
                                                centerText("Prawidłowa odpowiedź to: " + correctAns);
                                                centerText("Wciśnij dowolny klawisz... ");
                                                Console.ReadKey();
                                                break;
                                            }
                                        }

                                    }
                                    else if (keyInfoAnswer.Key == ConsoleKey.Escape)
                                    {
                                        i = 10;
                                        break;
                                    }
                                }

                            }
                            if (pointCounter == 0)
                            {
                                centerText("Przykro mi nie udało Ci się odgadnąć żadnego pokemona :(");
                                centerText("Wciśnij dowolny klawisz");
                            }
                            else
                            {
                                centerText("Gratulacje, zdobyłeś: " + pointCounter + "punktów.");
                                centerText("Wciśnij dowolny klawisz");
                            }
                            Console.ReadKey();
                            break;
                        }

                        //trudny poziom
                        else if (levelKeyInfo.Key == ConsoleKey.Enter && level == 1)
                        {
                            int pointCounter = 0;
                            string correctAns, answer;
                            int randomNumber, randomPokemon;
                            bool iscorrect;

                            bool exit = false;
                            List<int> pokemonIndex = new List<int>();
                            for (int j = 0; j < 150; j++)
                            {
                                pokemonIndex.Add(j);
                            }

                            for (int i = 0; i < 10; i++)
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Blue;
                                foreach (string line in whos)
                                {
                                    centerText(line);
                                }
                                Console.WriteLine();
                                Console.WriteLine();

                                iscorrect = false;

                                randomNumber = rand.Next(pokemonIndex.Count);
                                randomPokemon = pokemonIndex.ElementAt(randomNumber);
                                pokemonIndex.RemoveAt(randomNumber);

                                Console.ForegroundColor = ConsoleColor.White;
                                PokemonList.showPokemon(randomPokemon + 1, 67, 10);
                                Console.WriteLine();
                                correctAns = PokemonList.listaPokemonow[randomPokemon];
                                centerText("Twoje punkty: " + pointCounter);
                                Console.WriteLine();
                                centerText("Podaj nazwę pokemona, jeżeli nie wiesz wpisz 'next'. Aby wyjść z gry wpisz 'exit'. ");

                                while (iscorrect == false)
                                {
                                    Console.WriteLine();
                                    Console.Write(new string(' ', (Console.WindowWidth / 2 - 6)));
                                    answer = Console.ReadLine();

                                    if (string.Equals(answer, correctAns, StringComparison.CurrentCultureIgnoreCase))
                                    {
                                        pointCounter += 1;
                                        iscorrect = true;
                                    }
                                    else if (string.Equals(answer, "next", StringComparison.CurrentCultureIgnoreCase))
                                    {
                                        iscorrect = true;
                                    }
                                    else if (string.Equals(answer, "exit", StringComparison.CurrentCultureIgnoreCase))
                                    {
                                        exit = true;
                                        break;
                                    }
                                    else
                                    {
                                        centerText("Nieprawidłowa odpowiedź, spróbuj jeszcze raz :)");
                                    }
                                }
                                if (exit == true)
                                {
                                    break;
                                }
                            }

                            if (pointCounter == 0)
                            {
                                centerText("Przykro mi nie udało Ci się odgadnąć żadnego pokemona :(");
                                centerText("Wciśnij dowolny klawisz");
                            }
                            else if (exit == true)
                            {
                                break;
                            }
                            else
                            {
                                centerText("Gratulacje, twoja liczba punktów: " + pointCounter);
                                centerText("Wciśnij dowolny klawisz");
                            }
                            Console.ReadKey();
                        }

                        //exit
                        else if (levelKeyInfo.Key == ConsoleKey.Escape)
                        {
                            break;
                        }
                    }
                }
                else if (keyInfo.Key == ConsoleKey.Enter && x == 4) {
                    break;
                }
            }
        }
    }
}

using System;

namespace TEZXANDVENTURE
{
    class PlayerStats
    {
        public static void manager()
        {
            // Creating initial variables 
            int age = 0, race = 0, height = 0, bulk = 0, alignment = 0, cClass = 0, cGold = 0;
            float cStr = 0, cDex = 0, cWis = 0, cChar = 0;
            string name = "";

            Prologue.ConsoleScrollingTextThig_01();

            // Initiates the Character Verification and assing the variables with the newly inputed info (character height, age, name, bulk, alignment)
            Tuple<float, float, float, float, int> charTupleValues_0 = CharacterManager(name, cClass, age, race, height, bulk, alignment, ref cStr, ref cDex, ref cWis, ref cChar);
            cStr = charTupleValues_0.Item1; cDex = charTupleValues_0.Item2; cWis = charTupleValues_0.Item3; cChar = charTupleValues_0.Item4; cClass = charTupleValues_0.Item5;

            // Initiates the Character Verification and assing the variables with the newly inputed info (character class)
            Tuple<float, float, float, float> charTupleValues_1 = CharacterAdvancedStatCreator(cClass, ref cStr, ref cDex, ref cWis, ref cChar);
            cStr = charTupleValues_0.Item1; cDex = charTupleValues_0.Item2; cWis = charTupleValues_0.Item3; cChar = charTupleValues_0.Item4; cClass = charTupleValues_0.Item5;

            CharacterEquipmentFinder(cClass, ref cStr, ref cDex, ref cWis, ref cChar);
        }

        // These sets of CharCreaters ask the user for input
        static string CharNameCreator(ref string name)
        {
            while (true)
            {
                Console.Clear();
                Console.Write("What is your name: ");
                name = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Your name is " + name + "? \ny or n");
                string i = Convert.ToString(Console.ReadLine());
                if (i != "y" && i != "n") { Console.WriteLine("\n\n\nINVALID ANSWER\n"); Console.ReadLine(); }
                else if (i == "y")
                {
                    return name;
                }
            }
        }
        static int CharClassCreator(ref int cClass)
        {
            while (true)
            {
                Console.Clear();
                Console.Write("Enter Class. 1 = Warrior; 2 = Explorer; 3 = Cleric; 4 = Deprived");
                string i = Console.ReadLine();
                if (int.TryParse(i, out cClass))
                {
                    if (cClass > 3 || cClass < 1) { Console.WriteLine("\n\n\nINVALID BULK\n"); Console.ReadLine(); }
                    else
                    {
                        if (cClass == 1) { Console.WriteLine("You are an warrior? \ny or n"); string ii = Console.ReadLine(); if (ii != "n" && ii != "y") { Console.WriteLine("INVALID ANSWER"); Console.ReadLine(); } else if (ii == "y") { return cClass; } }
                        else if (cClass == 2) { Console.WriteLine("You are a explorer? \ny or n"); string ii = Console.ReadLine(); if (ii != "n" && ii != "y") { Console.WriteLine("INVALID ANSWER"); Console.ReadLine(); } else if (ii == "y") { return cClass; } }
                        else if (cClass == 4) { Console.WriteLine("You are a deprived? \ny or n"); string ii = Console.ReadLine(); if (ii != "n" && ii != "y") { Console.WriteLine("INVALID ANSWER"); Console.ReadLine(); } else if (ii == "y") { return cClass; } }
                        else if (cClass == 3) { Console.WriteLine("Ummmm You Sure? \ny or n"); string ii = Console.ReadLine(); if (ii != "n" && ii != "y") { Console.WriteLine("INVALID ANSWER"); Console.ReadLine(); } else if (ii == "y") { return cClass; } }
                    }
                }
                else
                {
                    Console.WriteLine("\n\n\nINVALID CLASS\n"); Console.ReadLine();
                }
            }
        }
        static int CharRaceCreator(ref int race)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("                      ▄████▄   ██░ ██  ▒█████   ▒█████    ██████ ▓█████     ▄▄▄          ██▀███   ▄▄▄       ▄████▄  ▓█████ "); Console.WriteLine("▒██▀ ▀█  ▓██░ ██▒▒██▒  ██▒▒██▒  ██▒▒██    ▒ ▓█   ▀    ▒████▄       ▓██ ▒ ██▒▒████▄    ▒██▀ ▀█  ▓█   ▀ "); Console.WriteLine("▒▓█    ▄ ▒██▀▀██░▒██░  ██▒▒██░  ██▒░ ▓██▄   ▒███      ▒██  ▀█▄     ▓██ ░▄█ ▒▒██  ▀█▄  ▒▓█    ▄ ▒███   "); Console.WriteLine("▒▓▓▄ ▄██▒░▓█ ░██ ▒██   ██░▒██   ██░  ▒   ██▒▒▓█  ▄    ░██▄▄▄▄██    ▒██▀▀█▄  ░██▄▄▄▄██ ▒▓▓▄ ▄██▒▒▓█  ▄ "); Console.WriteLine("▒ ▓███▀ ░░▓█▒░██▓░ ████▓▒░░ ████▓▒░▒██████▒▒░▒████▒    ▓█   ▓██▒   ░██▓ ▒██▒ ▓█   ▓██▒▒ ▓███▀ ░░▒████▒"); Console.WriteLine("░ ░▒ ▒  ░ ▒ ░░▒░▒░ ▒░▒░▒░ ░ ▒░▒░▒░ ▒ ▒▓▒ ▒ ░░░ ▒░ ░    ▒▒   ▓▒█░   ░ ▒▓ ░▒▓░ ▒▒   ▓▒█░░ ░▒ ▒  ░░░ ▒░ ░"); Console.WriteLine("  ░  ▒    ▒ ░▒░ ░  ░ ▒ ▒░   ░ ▒ ▒░ ░ ░▒  ░ ░ ░ ░  ░     ▒   ▒▒ ░     ░▒ ░ ▒░  ▒   ▒▒ ░  ░  ▒    ░ ░  ░");
                Console.WriteLine("");
                Console.WriteLine("1. Orc");
                Console.WriteLine("2. Elf");
                Console.WriteLine("3. Human");
                Console.WriteLine("4. Halfling");
                Console.WriteLine("5. Gnome");
                Console.WriteLine("6. Goliath");
                Console.WriteLine("7. Firbolg");
                Console.WriteLine("8. Dwarf");
                Console.WriteLine("9. DragonBorn");
                string i = Console.ReadLine();

                if (int.TryParse(i, out race))
                {
                    if (race > 3 || race < 1) { Console.WriteLine("\n\n\nINVALID RACE\n"); Console.ReadLine(); }
                    else
                    {
                        if (race == 1) { Console.WriteLine("You are an Orc? \ny or n"); string ii = Console.ReadLine(); if (ii != "n" && ii != "y") { Console.WriteLine("INVALID ANSWER"); Console.ReadLine(); } else if (ii == "y") { return race; } }
                        else if (race == 2) { Console.WriteLine("You are an Elf? \ny or n"); string ii = Console.ReadLine(); if (ii != "n" && ii != "y") { Console.WriteLine("INVALID ANSWER"); Console.ReadLine(); } else if (ii == "y") { return race; } }
                        else if (race == 3) { Console.WriteLine("You are a Human? \ny or n"); string ii = Console.ReadLine(); if (ii != "n" && ii != "y") { Console.WriteLine("INVALID ANSWER"); Console.ReadLine(); } else if (ii == "y") { return race; } }
                        else if (race == 4) { Console.WriteLine("You are a Halfling? \ny or n"); string ii = Console.ReadLine(); if (ii != "n" && ii != "y") { Console.WriteLine("INVALID ANSWER"); Console.ReadLine(); } else if (ii == "y") { return race; } }
                        else if (race == 5) { Console.WriteLine("You are a Gnome? \ny or n"); string ii = Console.ReadLine(); if (ii != "n" && ii != "y") { Console.WriteLine("INVALID ANSWER"); Console.ReadLine(); } else if (ii == "y") { return race; } }
                        else if (race == 6) { Console.WriteLine("You are a Goliath? \ny or n"); string ii = Console.ReadLine(); if (ii != "n" && ii != "y") { Console.WriteLine("INVALID ANSWER"); Console.ReadLine(); } else if (ii == "y") { return race; } }
                        else if (race == 7) { Console.WriteLine("You are a Firbolg? \ny or n"); string ii = Console.ReadLine(); if (ii != "n" && ii != "y") { Console.WriteLine("INVALID ANSWER"); Console.ReadLine(); } else if (ii == "y") { return race; } }
                        else if (race == 8) { Console.WriteLine("You are a Dwarf? \ny or n"); string ii = Console.ReadLine(); if (ii != "n" && ii != "y") { Console.WriteLine("INVALID ANSWER"); Console.ReadLine(); } else if (ii == "y") { return race; } }
                        else if (race == 9) { Console.WriteLine("You are a Dargon Born? \ny or n"); string ii = Console.ReadLine(); if (ii != "n" && ii != "y") { Console.WriteLine("INVALID ANSWER"); Console.ReadLine(); } else if (ii == "y") { return race; } }
                    }
                }
                else
                {
                    Console.WriteLine("\n\n\nINVALID RACE\n"); Console.ReadLine();
                }

            }
        }
        static int CharAgeCreator(ref int age)
        {
            while (true)
            {
                Console.Clear();
                Console.Write("Enter age[16 - 110]: ");
                string i = Console.ReadLine();
                if (int.TryParse(i, out age))
                {
                    if (age > 100 || age <= 7) { Console.WriteLine("\n\n\nINVALID AGE\n"); Console.ReadLine(); }
                    else
                    {
                        Console.WriteLine("You are " + age + " years old? \ny or n");
                        string ii = Console.ReadLine();

                        if (ii != "n" && ii != "y")
                        {
                            Console.WriteLine("ok wanna play it that way, ill pick for you.\nAGE SET TO: 101"); Console.ReadLine();
                            age = 101;
                            return age;
                        }
                        else if (ii == "y")
                        {
                            return age;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("\n\n\nINVALID AGE\n"); Console.ReadLine();
                }

            }
        }
        static int CharAlignmentCreator(ref int alignment)
        {
            while (true)
            {
                Console.Clear();
                Console.Write("Enter personality. 1 = passive; 2 = average; 3 = agressive: ");
                string i = Console.ReadLine();
                if (int.TryParse(i, out alignment))
                {
                    if (alignment > 3 && alignment < 9000 && alignment > 9000 || alignment < 1) { Console.WriteLine("\n\n\nINVALID ALIGNMENT\n"); Console.ReadLine(); }
                    else
                    {
                        if (alignment == 1) { Console.WriteLine("You are passive? \ny or n"); string ii = Console.ReadLine(); if (ii != "n" && ii != "y") { Console.WriteLine("INVALID ANSWER"); Console.ReadLine(); } else if (ii == "y") { return alignment; } }
                        else if (alignment == 2) { Console.WriteLine("You are averagely average? \ny or n"); string ii = Console.ReadLine(); if (ii != "n" && ii != "y") { Console.WriteLine("INVALID ANSWER"); Console.ReadLine(); } else if (ii == "y") { return alignment; } }
                        else if (alignment == 3) { Console.WriteLine("You are agressive? \ny or n"); string ii = Console.ReadLine(); if (ii != "n" && ii != "y") { Console.WriteLine("INVALID ANSWER"); Console.ReadLine(); } else if (ii == "y") { return alignment; } }
                    }
                }
                else
                {
                    Console.WriteLine("\n\n\nINVALID ALIGNMENT\n"); Console.ReadLine();
                }
            }
        }

        // Completes and manages all steps of character creation
        static Tuple<float, float, float, float, int> CharacterManager(string name, int cClass, int age, int race, int height, int bulk, int alignment, ref float cStr, ref float cDex, ref float cWis, ref float cCharisma)
        {
            bool prologueDone = false;
            while (true)
            {
                CharNameCreator(ref name);
                if (prologueDone != true)
                    Prologue.ConsoleScrollingTextThig_02();
                CharClassCreator(ref cClass);
                CharAgeCreator(ref age);
                CharRaceCreator(ref height);
                CharAlignmentCreator(ref alignment);
                if (prologueDone != true)
                    Prologue.ConsoleScrollingTextThig_03();

                prologueDone = true;

                Console.Clear();
                Console.WriteLine("Name: " + name);
                Console.WriteLine("Age: " + age);

                if (cClass == 1) { Console.WriteLine("Class: Warrior"); ; }
                else if (cClass == 2) { Console.WriteLine("Class: Explorer"); }
                else if (cClass == 3) { Console.WriteLine("Class: Cleric?"); }
                else if (cClass == 4) { Console.WriteLine("Class: Deprived"); }

                if (race == 1) { Console.WriteLine("Race: Orc"); }
                else if (race == 2) { Console.WriteLine("Race: Elf? "); }
                else if (race == 3) { Console.WriteLine("Race: Human? "); }
                else if (race == 4) { Console.WriteLine("Race: Halfling? "); }
                else if (race == 5) { Console.WriteLine("Race: Gnome? "); }
                else if (race == 6) { Console.WriteLine("Race: Goliath? "); }
                else if (race == 7) { Console.WriteLine("Race: Firbolg? "); }
                else if (race == 8) { Console.WriteLine("Race: Dwarf? "); }
                else if (race == 9) { Console.WriteLine("Race: Dargon Born? "); }

                if (alignment == 1) { Console.WriteLine("Alignment: Passive"); ; }
                else if (alignment == 2) { Console.WriteLine("Alignment: Average"); }
                else if (alignment == 3) { Console.WriteLine("Alignment: Agressive"); }

                Console.WriteLine("\nIs this you character?\ny or n");
                string i = Convert.ToString(Console.ReadLine());

                if (i != "y" && i != "n") { Console.WriteLine("\n\n\nINVALID ANSWER\n"); }
                else if (i == "y")
                {
                    CharacterBasicStatCreator(name, age, race, height, bulk, alignment, ref cStr, ref cDex, ref cWis, ref cCharisma);
                    return Tuple.Create(cStr, cDex, cWis, cCharisma, cClass);
                }
                else { }




            }
        }
        // Turns the age, height, race, etc. to str, dex, wis, etc.
        static Tuple<float, float, float, float> CharacterBasicStatCreator(string name, int age, int race, int height, int bulk, int alignment, ref float cStr, ref float cDex, ref float cWis, ref float cCharisma)
        {
            float ctModStr = 0f, ctModDex = 0f, ctModWis = 0f, ctModChar = 0f;
            Inventory inventory = new Inventory();

            AddCharPerk orcRage = new AddCharPerk { Name = "Orcish Rage" };
            AddCharPerk halflingLuck = new AddCharPerk { Name = "Halfling Luck"};
            
            AddCharPerk sshort = new AddCharPerk { Name = "Short" };
            AddCharPerk tall = new AddCharPerk { Name = "Tall" };

            AddCharPerk passive = new AddCharPerk { Name = "Passive" };
            AddCharPerk aggressive = new AddCharPerk { Name = "Aggressive" };
            if (race == 1)
            {
                inventory.AddPerk(orcRage);
                height = 2;
                bulk = 3;
                ctModChar -= 5;

                if (age > 16 && age <= 24)
                {
                    ctModStr += 12;
                    ctModDex += 12;
                    ctModWis -= 8;
                    ctModChar -= 2;

                    if (bulk == 1)
                    {
                        ctModStr += 3;
                        ctModDex += 1;

                        if (height == 1)
                        {
                            ctModDex += 8;
                            ctModStr -= 1;
                            inventory.AddPerk(sshort);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 2)
                        {
                            ctModDex += 6;

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 3)
                        {
                            ctModDex += 3;
                            ctModStr += 1;
                            inventory.AddPerk(tall);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }

                    }
                    else if (bulk == 2)
                    {
                        ctModStr += 6;

                        if (height == 1)
                        {
                            ctModDex += 8;
                            ctModStr -= 1;
                            inventory.AddPerk(sshort);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 2)
                        {
                            ctModDex += 6;

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 3)
                        {
                            ctModDex += 3;
                            ctModStr += 1;
                            inventory.AddPerk(tall);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                    }
                    else if (bulk ==3)
                    {
                        ctModStr += 8;
                        ctModDex -= 1;
                        
                        if (height == 1)
                        {
                            ctModDex += 8;
                            ctModStr -= 1;
                            inventory.AddPerk(sshort);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 2)
                        {
                            ctModDex += 6;

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 3)
                        {
                            ctModDex += 3;
                            ctModStr += 1;
                            inventory.AddPerk(tall);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                    }
                
                }
                else if (age > 24 && age <= 36)
                {
                    ctModStr += 13;
                    ctModDex += 10;
                    ctModWis -= 3;
                
                    if (bulk == 1)
                    {
                        ctModStr += 3;
                        ctModDex += 1;

                        if (height == 1)
                        {
                            ctModDex += 8;
                            ctModStr -= 1;
                            inventory.AddPerk(sshort);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 2)
                        {
                            ctModDex += 6;

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 3)
                        {
                            ctModDex += 3;
                            ctModStr += 1;
                            inventory.AddPerk(tall);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }

                    }
                    else if (bulk == 2)
                    {
                        ctModStr += 6;

                        if (height == 1)
                        {
                            ctModDex += 8;
                            ctModStr -= 1;
                            inventory.AddPerk(sshort);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 2)
                        {
                            ctModDex += 6;

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 3)
                        {
                            ctModDex += 3;
                            ctModStr += 1;
                            inventory.AddPerk(tall);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                    }
                    else if (bulk ==3)
                    {
                        ctModStr += 8;
                        ctModDex -= 1;
                        
                        if (height == 1)
                        {
                            ctModDex += 8;
                            ctModStr -= 1;
                            inventory.AddPerk(sshort);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 2)
                        {
                            ctModDex += 6;

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 3)
                        {
                            ctModDex += 3;
                            ctModStr += 1;
                            inventory.AddPerk(tall);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                    }
                
                }
                else if (age > 36 && age <= 42)
                {
                    ctModStr += 10;
                    ctModDex += 7;
                    
                    if (bulk == 1)
                    {
                        ctModStr += 3;
                        ctModDex += 1;

                        if (height == 1)
                        {
                            ctModDex += 8;
                            ctModStr -= 1;
                            inventory.AddPerk(sshort);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 2)
                        {
                            ctModDex += 6;

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 3)
                        {
                            ctModDex += 3;
                            ctModStr += 1;
                            inventory.AddPerk(tall);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }

                    }
                    else if (bulk == 2)
                    {
                        ctModStr += 6;

                        if (height == 1)
                        {
                            ctModDex += 8;
                            ctModStr -= 1;
                            inventory.AddPerk(sshort);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 2)
                        {
                            ctModDex += 6;

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 3)
                        {
                            ctModDex += 3;
                            ctModStr += 1;
                            inventory.AddPerk(tall);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                    }
                    else if (bulk ==3)
                    {
                        ctModStr += 8;
                        ctModDex -= 1;
                        
                        if (height == 1)
                        {
                            ctModDex += 8;
                            ctModStr -= 1;
                            inventory.AddPerk(sshort);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 2)
                        {
                            ctModDex += 6;

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 3)
                        {
                            ctModDex += 3;
                            ctModStr += 1;
                            inventory.AddPerk(tall);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                    }
                
                }
                else if (age > 42 && age <= 52)
                {
                    ctModStr += 7;
                    ctModDex += 5;
                    ctModWis += 2;
                    
                    if (bulk == 1)
                    {
                        ctModStr += 3;
                        ctModDex += 1;

                        if (height == 1)
                        {
                            ctModDex += 8;
                            ctModStr -= 1;
                            inventory.AddPerk(sshort);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 2)
                        {
                            ctModDex += 6;

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 3)
                        {
                            ctModDex += 3;
                            ctModStr += 1;
                            inventory.AddPerk(tall);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }

                    }
                    else if (bulk == 2)
                    {
                        ctModStr += 6;

                        if (height == 1)
                        {
                            ctModDex += 8;
                            ctModStr -= 1;
                            inventory.AddPerk(sshort);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 2)
                        {
                            ctModDex += 6;

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 3)
                        {
                            ctModDex += 3;
                            ctModStr += 1;
                            inventory.AddPerk(tall);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                    }
                    else if (bulk ==3)
                    {
                        ctModStr += 8;
                        ctModDex -= 1;
                        
                        if (height == 1)
                        {
                            ctModDex += 8;
                            ctModStr -= 1;
                            inventory.AddPerk(sshort);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 2)
                        {
                            ctModDex += 6;

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 3)
                        {
                            ctModDex += 3;
                            ctModStr += 1;
                            inventory.AddPerk(tall);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                    }
                
                }
                else if (age > 52 && age <= 68)
                {
                    ctModStr += 5;
                    ctModDex += 4;
                    ctModWis += 5;
                    
                    if (bulk == 1)
                    {
                        ctModStr += 3;
                        ctModDex += 1;

                        if (height == 1)
                        {
                            ctModDex += 8;
                            ctModStr -= 1;
                            inventory.AddPerk(sshort);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 2)
                        {
                            ctModDex += 6;

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 3)
                        {
                            ctModDex += 3;
                            ctModStr += 1;
                            inventory.AddPerk(tall);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }

                    }
                    else if (bulk == 2)
                    {
                        ctModStr += 6;

                        if (height == 1)
                        {
                            ctModDex += 8;
                            ctModStr -= 1;
                            inventory.AddPerk(sshort);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 2)
                        {
                            ctModDex += 6;

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 3)
                        {
                            ctModDex += 3;
                            ctModStr += 1;
                            inventory.AddPerk(tall);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                    }
                    else if (bulk ==3)
                    {
                        ctModStr += 8;
                        ctModDex -= 1;
                        
                        if (height == 1)
                        {
                            ctModDex += 8;
                            ctModStr -= 1;
                            inventory.AddPerk(sshort);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 2)
                        {
                            ctModDex += 6;

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 3)
                        {
                            ctModDex += 3;
                            ctModStr += 1;
                            inventory.AddPerk(tall);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                    }
                
                }
                else if (age > 68 && age <= 76)
                {
                    ctModStr += 5;
                    ctModDex += 3;
                    ctModWis += 6;
                    
                    if (bulk == 1)
                    {
                        ctModStr += 3;
                        ctModDex += 1;

                        if (height == 1)
                        {
                            ctModDex += 8;
                            ctModStr -= 1;
                            inventory.AddPerk(sshort);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 2)
                        {
                            ctModDex += 6;

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 3)
                        {
                            ctModDex += 3;
                            ctModStr += 1;
                            inventory.AddPerk(tall);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }

                    }
                    else if (bulk == 2)
                    {
                        ctModStr += 6;

                        if (height == 1)
                        {
                            ctModDex += 8;
                            ctModStr -= 1;
                            inventory.AddPerk(sshort);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 2)
                        {
                            ctModDex += 6;

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 3)
                        {
                            ctModDex += 3;
                            ctModStr += 1;
                            inventory.AddPerk(tall);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                    }
                    else if (bulk ==3)
                    {
                        ctModStr += 8;
                        ctModDex -= 1;
                        
                        if (height == 1)
                        {
                            ctModDex += 8;
                            ctModStr -= 1;
                            inventory.AddPerk(sshort);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 2)
                        {
                            ctModDex += 6;

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 3)
                        {
                            ctModDex += 3;
                            ctModStr += 1;
                            inventory.AddPerk(tall);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                    }
                
                }
                else if (age > 76 && age <= 88)
                {
                    ctModStr += 4;
                    ctModDex += 3;
                    ctModWis += 7;
                    
                    if (bulk == 1)
                    {
                        ctModStr += 3;
                        ctModDex += 1;

                        if (height == 1)
                        {
                            ctModDex += 8;
                            ctModStr -= 1;
                            inventory.AddPerk(sshort);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 2)
                        {
                            ctModDex += 6;

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 3)
                        {
                            ctModDex += 3;
                            ctModStr += 1;
                            inventory.AddPerk(tall);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }

                    }
                    else if (bulk == 2)
                    {
                        ctModStr += 6;

                        if (height == 1)
                        {
                            ctModDex += 8;
                            ctModStr -= 1;
                            inventory.AddPerk(sshort);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 2)
                        {
                            ctModDex += 6;

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 3)
                        {
                            ctModDex += 3;
                            ctModStr += 1;
                            inventory.AddPerk(tall);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                    }
                    else if (bulk ==3)
                    {
                        ctModStr += 8;
                        ctModDex -= 1;
                        
                        if (height == 1)
                        {
                            ctModDex += 8;
                            ctModStr -= 1;
                            inventory.AddPerk(sshort);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 2)
                        {
                            ctModDex += 6;

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 3)
                        {
                            ctModDex += 3;
                            ctModStr += 1;
                            inventory.AddPerk(tall);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                    }
                
                }
                else if (age > 88 && age <= 99)
                {
                    ctModStr += 3;
                    ctModDex += 2;
                    ctModWis += 11;
                    
                    if (bulk == 1)
                    {
                        ctModStr += 3;
                        ctModDex += 1;

                        if (height == 1)
                        {
                            ctModDex += 8;
                            ctModStr -= 1;
                            inventory.AddPerk(sshort);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 2)
                        {
                            ctModDex += 6;

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 3)
                        {
                            ctModDex += 3;
                            ctModStr += 1;
                            inventory.AddPerk(tall);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }

                    }
                    else if (bulk == 2)
                    {
                        ctModStr += 6;

                        if (height == 1)
                        {
                            ctModDex += 8;
                            ctModStr -= 1;
                            inventory.AddPerk(sshort);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 2)
                        {
                            ctModDex += 6;

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 3)
                        {
                            ctModDex += 3;
                            ctModStr += 1;
                            inventory.AddPerk(tall);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                    }
                    else if (bulk ==3)
                    {
                        ctModStr += 8;
                        ctModDex -= 1;
                        
                        if (height == 1)
                        {
                            ctModDex += 8;
                            ctModStr -= 1;
                            inventory.AddPerk(sshort);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 2)
                        {
                            ctModDex += 6;

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 3)
                        {
                            ctModDex += 3;
                            ctModStr += 1;
                            inventory.AddPerk(tall);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                    }
                
                }
                else if (age > 99 && age <= 110)
                {
                    ctModStr += 2;
                    ctModDex += 1;
                    ctModWis += 13;
                    
                    if (bulk == 1)
                    {
                        ctModStr += 3;
                        ctModDex += 1;

                        if (height == 1)
                        {
                            ctModDex += 8;
                            ctModStr -= 1;
                            inventory.AddPerk(sshort);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 2)
                        {
                            ctModDex += 6;

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 3)
                        {
                            ctModDex += 3;
                            ctModStr += 1;
                            inventory.AddPerk(tall);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }

                    }
                    else if (bulk == 2)
                    {
                        ctModStr += 6;

                        if (height == 1)
                        {
                            ctModDex += 8;
                            ctModStr -= 1;
                            inventory.AddPerk(sshort);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 2)
                        {
                            ctModDex += 6;

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 3)
                        {
                            ctModDex += 3;
                            ctModStr += 1;
                            inventory.AddPerk(tall);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                    }
                    else if (bulk ==3)
                    {
                        ctModStr += 8;
                        ctModDex -= 1;
                        
                        if (height == 1)
                        {
                            ctModDex += 8;
                            ctModStr -= 1;
                            inventory.AddPerk(sshort);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 2)
                        {
                            ctModDex += 6;

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 3)
                        {
                            ctModDex += 3;
                            ctModStr += 1;
                            inventory.AddPerk(tall);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                    }
                
                }
            }
            else if (race == 2)
            {
                height = 2;
                bulk = 1;
                ctModWis += 3;
                
                if (age > 16 && age <= 24)
                {
                    ctModStr += 12;
                    ctModDex += 12;
                    ctModWis -= 8;
                    ctModChar -= 2;

                    if (bulk == 1)
                    {
                        ctModStr += 3;
                        ctModDex += 1;

                        if (height == 1)
                        {
                            ctModDex += 8;
                            ctModStr -= 1;
                            inventory.AddPerk(sshort);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 2)
                        {
                            ctModDex += 6;

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 3)
                        {
                            ctModDex += 3;
                            ctModStr += 1;
                            inventory.AddPerk(tall);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }

                    }
                    else if (bulk == 2)
                    {
                        ctModStr += 6;

                        if (height == 1)
                        {
                            ctModDex += 8;
                            ctModStr -= 1;
                            inventory.AddPerk(sshort);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 2)
                        {
                            ctModDex += 6;

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 3)
                        {
                            ctModDex += 3;
                            ctModStr += 1;
                            inventory.AddPerk(tall);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                    }
                    else if (bulk ==3)
                    {
                        ctModStr += 8;
                        ctModDex -= 1;
                        
                        if (height == 1)
                        {
                            ctModDex += 8;
                            ctModStr -= 1;
                            inventory.AddPerk(sshort);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 2)
                        {
                            ctModDex += 6;

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 3)
                        {
                            ctModDex += 3;
                            ctModStr += 1;
                            inventory.AddPerk(tall);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                    }
                
                }
                else if (age > 24 && age <= 36)
                {
                    ctModStr += 13;
                    ctModDex += 10;
                    ctModWis -= 3;
                
                    if (bulk == 1)
                    {
                        ctModStr += 3;
                        ctModDex += 1;

                        if (height == 1)
                        {
                            ctModDex += 8;
                            ctModStr -= 1;
                            inventory.AddPerk(sshort);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 2)
                        {
                            ctModDex += 6;

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 3)
                        {
                            ctModDex += 3;
                            ctModStr += 1;
                            inventory.AddPerk(tall);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }

                    }
                    else if (bulk == 2)
                    {
                        ctModStr += 6;

                        if (height == 1)
                        {
                            ctModDex += 8;
                            ctModStr -= 1;
                            inventory.AddPerk(sshort);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 2)
                        {
                            ctModDex += 6;

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 3)
                        {
                            ctModDex += 3;
                            ctModStr += 1;
                            inventory.AddPerk(tall);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                    }
                    else if (bulk ==3)
                    {
                        ctModStr += 8;
                        ctModDex -= 1;
                        
                        if (height == 1)
                        {
                            ctModDex += 8;
                            ctModStr -= 1;
                            inventory.AddPerk(sshort);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 2)
                        {
                            ctModDex += 6;

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 3)
                        {
                            ctModDex += 3;
                            ctModStr += 1;
                            inventory.AddPerk(tall);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                    }
                
                }
                else if (age > 36 && age <= 42)
                {
                    ctModStr += 10;
                    ctModDex += 7;
                    
                    if (bulk == 1)
                    {
                        ctModStr += 3;
                        ctModDex += 1;

                        if (height == 1)
                        {
                            ctModDex += 8;
                            ctModStr -= 1;
                            inventory.AddPerk(sshort);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 2)
                        {
                            ctModDex += 6;

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 3)
                        {
                            ctModDex += 3;
                            ctModStr += 1;
                            inventory.AddPerk(tall);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }

                    }
                    else if (bulk == 2)
                    {
                        ctModStr += 6;

                        if (height == 1)
                        {
                            ctModDex += 8;
                            ctModStr -= 1;
                            inventory.AddPerk(sshort);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 2)
                        {
                            ctModDex += 6;

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 3)
                        {
                            ctModDex += 3;
                            ctModStr += 1;
                            inventory.AddPerk(tall);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                    }
                    else if (bulk ==3)
                    {
                        ctModStr += 8;
                        ctModDex -= 1;
                        
                        if (height == 1)
                        {
                            ctModDex += 8;
                            ctModStr -= 1;
                            inventory.AddPerk(sshort);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 2)
                        {
                            ctModDex += 6;

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 3)
                        {
                            ctModDex += 3;
                            ctModStr += 1;
                            inventory.AddPerk(tall);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                    }
                
                }
                else if (age > 42 && age <= 52)
                {
                    ctModStr += 7;
                    ctModDex += 5;
                    ctModWis += 2;
                    
                    if (bulk == 1)
                    {
                        ctModStr += 3;
                        ctModDex += 1;

                        if (height == 1)
                        {
                            ctModDex += 8;
                            ctModStr -= 1;
                            inventory.AddPerk(sshort);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 2)
                        {
                            ctModDex += 6;

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 3)
                        {
                            ctModDex += 3;
                            ctModStr += 1;
                            inventory.AddPerk(tall);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }

                    }
                    else if (bulk == 2)
                    {
                        ctModStr += 6;

                        if (height == 1)
                        {
                            ctModDex += 8;
                            ctModStr -= 1;
                            inventory.AddPerk(sshort);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 2)
                        {
                            ctModDex += 6;

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 3)
                        {
                            ctModDex += 3;
                            ctModStr += 1;
                            inventory.AddPerk(tall);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                    }
                    else if (bulk ==3)
                    {
                        ctModStr += 8;
                        ctModDex -= 1;
                        
                        if (height == 1)
                        {
                            ctModDex += 8;
                            ctModStr -= 1;
                            inventory.AddPerk(sshort);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 2)
                        {
                            ctModDex += 6;

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 3)
                        {
                            ctModDex += 3;
                            ctModStr += 1;
                            inventory.AddPerk(tall);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                    }
                
                }
                else if (age > 52 && age <= 68)
                {
                    ctModStr += 5;
                    ctModDex += 4;
                    ctModWis += 5;
                    
                    if (bulk == 1)
                    {
                        ctModStr += 3;
                        ctModDex += 1;

                        if (height == 1)
                        {
                            ctModDex += 8;
                            ctModStr -= 1;
                            inventory.AddPerk(sshort);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 2)
                        {
                            ctModDex += 6;

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 3)
                        {
                            ctModDex += 3;
                            ctModStr += 1;
                            inventory.AddPerk(tall);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }

                    }
                    else if (bulk == 2)
                    {
                        ctModStr += 6;

                        if (height == 1)
                        {
                            ctModDex += 8;
                            ctModStr -= 1;
                            inventory.AddPerk(sshort);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 2)
                        {
                            ctModDex += 6;

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 3)
                        {
                            ctModDex += 3;
                            ctModStr += 1;
                            inventory.AddPerk(tall);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                    }
                    else if (bulk ==3)
                    {
                        ctModStr += 8;
                        ctModDex -= 1;
                        
                        if (height == 1)
                        {
                            ctModDex += 8;
                            ctModStr -= 1;
                            inventory.AddPerk(sshort);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 2)
                        {
                            ctModDex += 6;

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 3)
                        {
                            ctModDex += 3;
                            ctModStr += 1;
                            inventory.AddPerk(tall);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                    }
                
                }
                else if (age > 68 && age <= 76)
                {
                    ctModStr += 5;
                    ctModDex += 3;
                    ctModWis += 6;
                    
                    if (bulk == 1)
                    {
                        ctModStr += 3;
                        ctModDex += 1;

                        if (height == 1)
                        {
                            ctModDex += 8;
                            ctModStr -= 1;
                            inventory.AddPerk(sshort);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 2)
                        {
                            ctModDex += 6;

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 3)
                        {
                            ctModDex += 3;
                            ctModStr += 1;
                            inventory.AddPerk(tall);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }

                    }
                    else if (bulk == 2)
                    {
                        ctModStr += 6;

                        if (height == 1)
                        {
                            ctModDex += 8;
                            ctModStr -= 1;
                            inventory.AddPerk(sshort);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 2)
                        {
                            ctModDex += 6;

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 3)
                        {
                            ctModDex += 3;
                            ctModStr += 1;
                            inventory.AddPerk(tall);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                    }
                    else if (bulk ==3)
                    {
                        ctModStr += 8;
                        ctModDex -= 1;
                        
                        if (height == 1)
                        {
                            ctModDex += 8;
                            ctModStr -= 1;
                            inventory.AddPerk(sshort);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 2)
                        {
                            ctModDex += 6;

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 3)
                        {
                            ctModDex += 3;
                            ctModStr += 1;
                            inventory.AddPerk(tall);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                    }
                
                }
                else if (age > 76 && age <= 88)
                {
                    ctModStr += 4;
                    ctModDex += 3;
                    ctModWis += 7;
                    
                    if (bulk == 1)
                    {
                        ctModStr += 3;
                        ctModDex += 1;

                        if (height == 1)
                        {
                            ctModDex += 8;
                            ctModStr -= 1;
                            inventory.AddPerk(sshort);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 2)
                        {
                            ctModDex += 6;

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 3)
                        {
                            ctModDex += 3;
                            ctModStr += 1;
                            inventory.AddPerk(tall);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }

                    }
                    else if (bulk == 2)
                    {
                        ctModStr += 6;

                        if (height == 1)
                        {
                            ctModDex += 8;
                            ctModStr -= 1;
                            inventory.AddPerk(sshort);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 2)
                        {
                            ctModDex += 6;

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 3)
                        {
                            ctModDex += 3;
                            ctModStr += 1;
                            inventory.AddPerk(tall);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                    }
                    else if (bulk ==3)
                    {
                        ctModStr += 8;
                        ctModDex -= 1;
                        
                        if (height == 1)
                        {
                            ctModDex += 8;
                            ctModStr -= 1;
                            inventory.AddPerk(sshort);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 2)
                        {
                            ctModDex += 6;

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 3)
                        {
                            ctModDex += 3;
                            ctModStr += 1;
                            inventory.AddPerk(tall);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                    }
                
                }
                else if (age > 88 && age <= 99)
                {
                    ctModStr += 3;
                    ctModDex += 2;
                    ctModWis += 11;
                    
                    if (bulk == 1)
                    {
                        ctModStr += 3;
                        ctModDex += 1;

                        if (height == 1)
                        {
                            ctModDex += 8;
                            ctModStr -= 1;
                            inventory.AddPerk(sshort);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 2)
                        {
                            ctModDex += 6;

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 3)
                        {
                            ctModDex += 3;
                            ctModStr += 1;
                            inventory.AddPerk(tall);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }

                    }
                    else if (bulk == 2)
                    {
                        ctModStr += 6;

                        if (height == 1)
                        {
                            ctModDex += 8;
                            ctModStr -= 1;
                            inventory.AddPerk(sshort);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 2)
                        {
                            ctModDex += 6;

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 3)
                        {
                            ctModDex += 3;
                            ctModStr += 1;
                            inventory.AddPerk(tall);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                    }
                    else if (bulk ==3)
                    {
                        ctModStr += 8;
                        ctModDex -= 1;
                        
                        if (height == 1)
                        {
                            ctModDex += 8;
                            ctModStr -= 1;
                            inventory.AddPerk(sshort);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 2)
                        {
                            ctModDex += 6;

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 3)
                        {
                            ctModDex += 3;
                            ctModStr += 1;
                            inventory.AddPerk(tall);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                    }
                
                }
                else if (age > 99 && age <= 110)
                {
                    ctModStr += 2;
                    ctModDex += 1;
                    ctModWis += 13;
                    
                    if (bulk == 1)
                    {
                        ctModStr += 3;
                        ctModDex += 1;

                        if (height == 1)
                        {
                            ctModDex += 8;
                            ctModStr -= 1;
                            inventory.AddPerk(sshort);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 2)
                        {
                            ctModDex += 6;

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 3)
                        {
                            ctModDex += 3;
                            ctModStr += 1;
                            inventory.AddPerk(tall);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }

                    }
                    else if (bulk == 2)
                    {
                        ctModStr += 6;

                        if (height == 1)
                        {
                            ctModDex += 8;
                            ctModStr -= 1;
                            inventory.AddPerk(sshort);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 2)
                        {
                            ctModDex += 6;

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 3)
                        {
                            ctModDex += 3;
                            ctModStr += 1;
                            inventory.AddPerk(tall);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                    }
                    else if (bulk ==3)
                    {
                        ctModStr += 8;
                        ctModDex -= 1;
                        
                        if (height == 1)
                        {
                            ctModDex += 8;
                            ctModStr -= 1;
                            inventory.AddPerk(sshort);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 2)
                        {
                            ctModDex += 6;

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 3)
                        {
                            ctModDex += 3;
                            ctModStr += 1;
                            inventory.AddPerk(tall);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                    }
                
                }
            }
            else if (race == 3)
            {
                height = 2;
                bulk = 2;
                ctModChar += 1;
             
                if (age > 16 && age <= 24)
                {
                    ctModStr += 12;
                    ctModDex += 12;
                    ctModWis -= 8;
                    ctModChar -= 2;

                    if (bulk == 1)
                    {
                        ctModStr += 3;
                        ctModDex += 1;

                        if (height == 1)
                        {
                            ctModDex += 8;
                            ctModStr -= 1;
                            inventory.AddPerk(sshort);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 2)
                        {
                            ctModDex += 6;

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 3)
                        {
                            ctModDex += 3;
                            ctModStr += 1;
                            inventory.AddPerk(tall);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }

                    }
                    else if (bulk == 2)
                    {
                        ctModStr += 6;

                        if (height == 1)
                        {
                            ctModDex += 8;
                            ctModStr -= 1;
                            inventory.AddPerk(sshort);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 2)
                        {
                            ctModDex += 6;

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 3)
                        {
                            ctModDex += 3;
                            ctModStr += 1;
                            inventory.AddPerk(tall);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                    }
                    else if (bulk ==3)
                    {
                        ctModStr += 8;
                        ctModDex -= 1;
                        
                        if (height == 1)
                        {
                            ctModDex += 8;
                            ctModStr -= 1;
                            inventory.AddPerk(sshort);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 2)
                        {
                            ctModDex += 6;

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 3)
                        {
                            ctModDex += 3;
                            ctModStr += 1;
                            inventory.AddPerk(tall);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                    }
                
                }
                else if (age > 24 && age <= 36)
                {
                    ctModStr += 13;
                    ctModDex += 10;
                    ctModWis -= 3;
                
                    if (bulk == 1)
                    {
                        ctModStr += 3;
                        ctModDex += 1;

                        if (height == 1)
                        {
                            ctModDex += 8;
                            ctModStr -= 1;
                            inventory.AddPerk(sshort);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 2)
                        {
                            ctModDex += 6;

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 3)
                        {
                            ctModDex += 3;
                            ctModStr += 1;
                            inventory.AddPerk(tall);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }

                    }
                    else if (bulk == 2)
                    {
                        ctModStr += 6;

                        if (height == 1)
                        {
                            ctModDex += 8;
                            ctModStr -= 1;
                            inventory.AddPerk(sshort);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 2)
                        {
                            ctModDex += 6;

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 3)
                        {
                            ctModDex += 3;
                            ctModStr += 1;
                            inventory.AddPerk(tall);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                    }
                    else if (bulk ==3)
                    {
                        ctModStr += 8;
                        ctModDex -= 1;
                        
                        if (height == 1)
                        {
                            ctModDex += 8;
                            ctModStr -= 1;
                            inventory.AddPerk(sshort);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 2)
                        {
                            ctModDex += 6;

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 3)
                        {
                            ctModDex += 3;
                            ctModStr += 1;
                            inventory.AddPerk(tall);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                    }
                
                }
                else if (age > 36 && age <= 42)
                {
                    ctModStr += 10;
                    ctModDex += 7;
                    
                    if (bulk == 1)
                    {
                        ctModStr += 3;
                        ctModDex += 1;

                        if (height == 1)
                        {
                            ctModDex += 8;
                            ctModStr -= 1;
                            inventory.AddPerk(sshort);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 2)
                        {
                            ctModDex += 6;

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 3)
                        {
                            ctModDex += 3;
                            ctModStr += 1;
                            inventory.AddPerk(tall);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }

                    }
                    else if (bulk == 2)
                    {
                        ctModStr += 6;

                        if (height == 1)
                        {
                            ctModDex += 8;
                            ctModStr -= 1;
                            inventory.AddPerk(sshort);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 2)
                        {
                            ctModDex += 6;

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 3)
                        {
                            ctModDex += 3;
                            ctModStr += 1;
                            inventory.AddPerk(tall);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                    }
                    else if (bulk ==3)
                    {
                        ctModStr += 8;
                        ctModDex -= 1;
                        
                        if (height == 1)
                        {
                            ctModDex += 8;
                            ctModStr -= 1;
                            inventory.AddPerk(sshort);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 2)
                        {
                            ctModDex += 6;

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 3)
                        {
                            ctModDex += 3;
                            ctModStr += 1;
                            inventory.AddPerk(tall);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                    }
                
                }
                else if (age > 42 && age <= 52)
                {
                    ctModStr += 7;
                    ctModDex += 5;
                    ctModWis += 2;
                    
                    if (bulk == 1)
                    {
                        ctModStr += 3;
                        ctModDex += 1;

                        if (height == 1)
                        {
                            ctModDex += 8;
                            ctModStr -= 1;
                            inventory.AddPerk(sshort);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 2)
                        {
                            ctModDex += 6;

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 3)
                        {
                            ctModDex += 3;
                            ctModStr += 1;
                            inventory.AddPerk(tall);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }

                    }
                    else if (bulk == 2)
                    {
                        ctModStr += 6;

                        if (height == 1)
                        {
                            ctModDex += 8;
                            ctModStr -= 1;
                            inventory.AddPerk(sshort);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 2)
                        {
                            ctModDex += 6;

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 3)
                        {
                            ctModDex += 3;
                            ctModStr += 1;
                            inventory.AddPerk(tall);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                    }
                    else if (bulk ==3)
                    {
                        ctModStr += 8;
                        ctModDex -= 1;
                        
                        if (height == 1)
                        {
                            ctModDex += 8;
                            ctModStr -= 1;
                            inventory.AddPerk(sshort);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 2)
                        {
                            ctModDex += 6;

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 3)
                        {
                            ctModDex += 3;
                            ctModStr += 1;
                            inventory.AddPerk(tall);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                    }
                
                }
                else if (age > 52 && age <= 68)
                {
                    ctModStr += 5;
                    ctModDex += 4;
                    ctModWis += 5;
                    
                    if (bulk == 1)
                    {
                        ctModStr += 3;
                        ctModDex += 1;

                        if (height == 1)
                        {
                            ctModDex += 8;
                            ctModStr -= 1;
                            inventory.AddPerk(sshort);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 2)
                        {
                            ctModDex += 6;

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 3)
                        {
                            ctModDex += 3;
                            ctModStr += 1;
                            inventory.AddPerk(tall);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }

                    }
                    else if (bulk == 2)
                    {
                        ctModStr += 6;

                        if (height == 1)
                        {
                            ctModDex += 8;
                            ctModStr -= 1;
                            inventory.AddPerk(sshort);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 2)
                        {
                            ctModDex += 6;

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 3)
                        {
                            ctModDex += 3;
                            ctModStr += 1;
                            inventory.AddPerk(tall);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                    }
                    else if (bulk ==3)
                    {
                        ctModStr += 8;
                        ctModDex -= 1;
                        
                        if (height == 1)
                        {
                            ctModDex += 8;
                            ctModStr -= 1;
                            inventory.AddPerk(sshort);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 2)
                        {
                            ctModDex += 6;

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 3)
                        {
                            ctModDex += 3;
                            ctModStr += 1;
                            inventory.AddPerk(tall);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                    }
                
                }
                else if (age > 68 && age <= 76)
                {
                    ctModStr += 5;
                    ctModDex += 3;
                    ctModWis += 6;
                    
                    if (bulk == 1)
                    {
                        ctModStr += 3;
                        ctModDex += 1;

                        if (height == 1)
                        {
                            ctModDex += 8;
                            ctModStr -= 1;
                            inventory.AddPerk(sshort);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 2)
                        {
                            ctModDex += 6;

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 3)
                        {
                            ctModDex += 3;
                            ctModStr += 1;
                            inventory.AddPerk(tall);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }

                    }
                    else if (bulk == 2)
                    {
                        ctModStr += 6;

                        if (height == 1)
                        {
                            ctModDex += 8;
                            ctModStr -= 1;
                            inventory.AddPerk(sshort);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 2)
                        {
                            ctModDex += 6;

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 3)
                        {
                            ctModDex += 3;
                            ctModStr += 1;
                            inventory.AddPerk(tall);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                    }
                    else if (bulk ==3)
                    {
                        ctModStr += 8;
                        ctModDex -= 1;
                        
                        if (height == 1)
                        {
                            ctModDex += 8;
                            ctModStr -= 1;
                            inventory.AddPerk(sshort);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 2)
                        {
                            ctModDex += 6;

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 3)
                        {
                            ctModDex += 3;
                            ctModStr += 1;
                            inventory.AddPerk(tall);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                    }
                
                }
                else if (age > 76 && age <= 88)
                {
                    ctModStr += 4;
                    ctModDex += 3;
                    ctModWis += 7;
                    
                    if (bulk == 1)
                    {
                        ctModStr += 3;
                        ctModDex += 1;

                        if (height == 1)
                        {
                            ctModDex += 8;
                            ctModStr -= 1;
                            inventory.AddPerk(sshort);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 2)
                        {
                            ctModDex += 6;

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 3)
                        {
                            ctModDex += 3;
                            ctModStr += 1;
                            inventory.AddPerk(tall);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }

                    }
                    else if (bulk == 2)
                    {
                        ctModStr += 6;

                        if (height == 1)
                        {
                            ctModDex += 8;
                            ctModStr -= 1;
                            inventory.AddPerk(sshort);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 2)
                        {
                            ctModDex += 6;

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 3)
                        {
                            ctModDex += 3;
                            ctModStr += 1;
                            inventory.AddPerk(tall);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                    }
                    else if (bulk ==3)
                    {
                        ctModStr += 8;
                        ctModDex -= 1;
                        
                        if (height == 1)
                        {
                            ctModDex += 8;
                            ctModStr -= 1;
                            inventory.AddPerk(sshort);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 2)
                        {
                            ctModDex += 6;

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 3)
                        {
                            ctModDex += 3;
                            ctModStr += 1;
                            inventory.AddPerk(tall);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                    }
                
                }
                else if (age > 88 && age <= 99)
                {
                    ctModStr += 3;
                    ctModDex += 2;
                    ctModWis += 11;
                    
                    if (bulk == 1)
                    {
                        ctModStr += 3;
                        ctModDex += 1;

                        if (height == 1)
                        {
                            ctModDex += 8;
                            ctModStr -= 1;
                            inventory.AddPerk(sshort);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 2)
                        {
                            ctModDex += 6;

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 3)
                        {
                            ctModDex += 3;
                            ctModStr += 1;
                            inventory.AddPerk(tall);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }

                    }
                    else if (bulk == 2)
                    {
                        ctModStr += 6;

                        if (height == 1)
                        {
                            ctModDex += 8;
                            ctModStr -= 1;
                            inventory.AddPerk(sshort);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 2)
                        {
                            ctModDex += 6;

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 3)
                        {
                            ctModDex += 3;
                            ctModStr += 1;
                            inventory.AddPerk(tall);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                    }
                    else if (bulk ==3)
                    {
                        ctModStr += 8;
                        ctModDex -= 1;
                        
                        if (height == 1)
                        {
                            ctModDex += 8;
                            ctModStr -= 1;
                            inventory.AddPerk(sshort);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 2)
                        {
                            ctModDex += 6;

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 3)
                        {
                            ctModDex += 3;
                            ctModStr += 1;
                            inventory.AddPerk(tall);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                    }
                
                }
                else if (age > 99 && age <= 110)
                {
                    ctModStr += 2;
                    ctModDex += 1;
                    ctModWis += 13;
                    
                    if (bulk == 1)
                    {
                        ctModStr += 3;
                        ctModDex += 1;

                        if (height == 1)
                        {
                            ctModDex += 8;
                            ctModStr -= 1;
                            inventory.AddPerk(sshort);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 2)
                        {
                            ctModDex += 6;

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 3)
                        {
                            ctModDex += 3;
                            ctModStr += 1;
                            inventory.AddPerk(tall);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }

                    }
                    else if (bulk == 2)
                    {
                        ctModStr += 6;

                        if (height == 1)
                        {
                            ctModDex += 8;
                            ctModStr -= 1;
                            inventory.AddPerk(sshort);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 2)
                        {
                            ctModDex += 6;

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 3)
                        {
                            ctModDex += 3;
                            ctModStr += 1;
                            inventory.AddPerk(tall);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                    }
                    else if (bulk ==3)
                    {
                        ctModStr += 8;
                        ctModDex -= 1;
                        
                        if (height == 1)
                        {
                            ctModDex += 8;
                            ctModStr -= 1;
                            inventory.AddPerk(sshort);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 2)
                        {
                            ctModDex += 6;

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 3)
                        {
                            ctModDex += 3;
                            ctModStr += 1;
                            inventory.AddPerk(tall);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                    }
                
                }
            }
            else if (race == 4)
            {
                height = 1;
                bulk = 1;
                ctModChar +=1;
                inventory.AddPerk(halflingLuck);
                if (age > 16 && age <= 24)
                {
                    ctModStr += 12;
                    ctModDex += 12;
                    ctModWis -= 8;
                    ctModChar -= 2;

                    if (bulk == 1)
                    {
                        ctModStr += 3;
                        ctModDex += 1;

                        if (height == 1)
                        {
                            ctModDex += 8;
                            ctModStr -= 1;
                            inventory.AddPerk(sshort);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 2)
                        {
                            ctModDex += 6;

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 3)
                        {
                            ctModDex += 3;
                            ctModStr += 1;
                            inventory.AddPerk(tall);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }

                    }
                    else if (bulk == 2)
                    {
                        ctModStr += 6;

                        if (height == 1)
                        {
                            ctModDex += 8;
                            ctModStr -= 1;
                            inventory.AddPerk(sshort);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 2)
                        {
                            ctModDex += 6;

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 3)
                        {
                            ctModDex += 3;
                            ctModStr += 1;
                            inventory.AddPerk(tall);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                    }
                    else if (bulk ==3)
                    {
                        ctModStr += 8;
                        ctModDex -= 1;
                        
                        if (height == 1)
                        {
                            ctModDex += 8;
                            ctModStr -= 1;
                            inventory.AddPerk(sshort);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 2)
                        {
                            ctModDex += 6;

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 3)
                        {
                            ctModDex += 3;
                            ctModStr += 1;
                            inventory.AddPerk(tall);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                    }
                
                }
                else if (age > 24 && age <= 36)
                {
                    ctModStr += 13;
                    ctModDex += 10;
                    ctModWis -= 3;
                
                    if (bulk == 1)
                    {
                        ctModStr += 3;
                        ctModDex += 1;

                        if (height == 1)
                        {
                            ctModDex += 8;
                            ctModStr -= 1;
                            inventory.AddPerk(sshort);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 2)
                        {
                            ctModDex += 6;

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 3)
                        {
                            ctModDex += 3;
                            ctModStr += 1;
                            inventory.AddPerk(tall);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }

                    }
                    else if (bulk == 2)
                    {
                        ctModStr += 6;

                        if (height == 1)
                        {
                            ctModDex += 8;
                            ctModStr -= 1;
                            inventory.AddPerk(sshort);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 2)
                        {
                            ctModDex += 6;

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 3)
                        {
                            ctModDex += 3;
                            ctModStr += 1;
                            inventory.AddPerk(tall);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                    }
                    else if (bulk ==3)
                    {
                        ctModStr += 8;
                        ctModDex -= 1;
                        
                        if (height == 1)
                        {
                            ctModDex += 8;
                            ctModStr -= 1;
                            inventory.AddPerk(sshort);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 2)
                        {
                            ctModDex += 6;

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 3)
                        {
                            ctModDex += 3;
                            ctModStr += 1;
                            inventory.AddPerk(tall);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                    }
                
                }
                else if (age > 36 && age <= 42)
                {
                    ctModStr += 10;
                    ctModDex += 7;
                    
                    if (bulk == 1)
                    {
                        ctModStr += 3;
                        ctModDex += 1;

                        if (height == 1)
                        {
                            ctModDex += 8;
                            ctModStr -= 1;
                            inventory.AddPerk(sshort);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 2)
                        {
                            ctModDex += 6;

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 3)
                        {
                            ctModDex += 3;
                            ctModStr += 1;
                            inventory.AddPerk(tall);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }

                    }
                    else if (bulk == 2)
                    {
                        ctModStr += 6;

                        if (height == 1)
                        {
                            ctModDex += 8;
                            ctModStr -= 1;
                            inventory.AddPerk(sshort);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 2)
                        {
                            ctModDex += 6;

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 3)
                        {
                            ctModDex += 3;
                            ctModStr += 1;
                            inventory.AddPerk(tall);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                    }
                    else if (bulk ==3)
                    {
                        ctModStr += 8;
                        ctModDex -= 1;
                        
                        if (height == 1)
                        {
                            ctModDex += 8;
                            ctModStr -= 1;
                            inventory.AddPerk(sshort);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 2)
                        {
                            ctModDex += 6;

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 3)
                        {
                            ctModDex += 3;
                            ctModStr += 1;
                            inventory.AddPerk(tall);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                    }
                
                }
                else if (age > 42 && age <= 52)
                {
                    ctModStr += 7;
                    ctModDex += 5;
                    ctModWis += 2;
                    
                    if (bulk == 1)
                    {
                        ctModStr += 3;
                        ctModDex += 1;

                        if (height == 1)
                        {
                            ctModDex += 8;
                            ctModStr -= 1;
                            inventory.AddPerk(sshort);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 2)
                        {
                            ctModDex += 6;

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 3)
                        {
                            ctModDex += 3;
                            ctModStr += 1;
                            inventory.AddPerk(tall);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }

                    }
                    else if (bulk == 2)
                    {
                        ctModStr += 6;

                        if (height == 1)
                        {
                            ctModDex += 8;
                            ctModStr -= 1;
                            inventory.AddPerk(sshort);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 2)
                        {
                            ctModDex += 6;

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 3)
                        {
                            ctModDex += 3;
                            ctModStr += 1;
                            inventory.AddPerk(tall);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                    }
                    else if (bulk ==3)
                    {
                        ctModStr += 8;
                        ctModDex -= 1;
                        
                        if (height == 1)
                        {
                            ctModDex += 8;
                            ctModStr -= 1;
                            inventory.AddPerk(sshort);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 2)
                        {
                            ctModDex += 6;

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 3)
                        {
                            ctModDex += 3;
                            ctModStr += 1;
                            inventory.AddPerk(tall);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                    }
                
                }
                else if (age > 52 && age <= 68)
                {
                    ctModStr += 5;
                    ctModDex += 4;
                    ctModWis += 5;
                    
                    if (bulk == 1)
                    {
                        ctModStr += 3;
                        ctModDex += 1;

                        if (height == 1)
                        {
                            ctModDex += 8;
                            ctModStr -= 1;
                            inventory.AddPerk(sshort);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 2)
                        {
                            ctModDex += 6;

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 3)
                        {
                            ctModDex += 3;
                            ctModStr += 1;
                            inventory.AddPerk(tall);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }

                    }
                    else if (bulk == 2)
                    {
                        ctModStr += 6;

                        if (height == 1)
                        {
                            ctModDex += 8;
                            ctModStr -= 1;
                            inventory.AddPerk(sshort);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 2)
                        {
                            ctModDex += 6;

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 3)
                        {
                            ctModDex += 3;
                            ctModStr += 1;
                            inventory.AddPerk(tall);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                    }
                    else if (bulk ==3)
                    {
                        ctModStr += 8;
                        ctModDex -= 1;
                        
                        if (height == 1)
                        {
                            ctModDex += 8;
                            ctModStr -= 1;
                            inventory.AddPerk(sshort);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 2)
                        {
                            ctModDex += 6;

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 3)
                        {
                            ctModDex += 3;
                            ctModStr += 1;
                            inventory.AddPerk(tall);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                    }
                
                }
                else if (age > 68 && age <= 76)
                {
                    ctModStr += 5;
                    ctModDex += 3;
                    ctModWis += 6;
                    
                    if (bulk == 1)
                    {
                        ctModStr += 3;
                        ctModDex += 1;

                        if (height == 1)
                        {
                            ctModDex += 8;
                            ctModStr -= 1;
                            inventory.AddPerk(sshort);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 2)
                        {
                            ctModDex += 6;

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 3)
                        {
                            ctModDex += 3;
                            ctModStr += 1;
                            inventory.AddPerk(tall);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }

                    }
                    else if (bulk == 2)
                    {
                        ctModStr += 6;

                        if (height == 1)
                        {
                            ctModDex += 8;
                            ctModStr -= 1;
                            inventory.AddPerk(sshort);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 2)
                        {
                            ctModDex += 6;

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 3)
                        {
                            ctModDex += 3;
                            ctModStr += 1;
                            inventory.AddPerk(tall);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                    }
                    else if (bulk ==3)
                    {
                        ctModStr += 8;
                        ctModDex -= 1;
                        
                        if (height == 1)
                        {
                            ctModDex += 8;
                            ctModStr -= 1;
                            inventory.AddPerk(sshort);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 2)
                        {
                            ctModDex += 6;

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 3)
                        {
                            ctModDex += 3;
                            ctModStr += 1;
                            inventory.AddPerk(tall);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                    }
                
                }
                else if (age > 76 && age <= 88)
                {
                    ctModStr += 4;
                    ctModDex += 3;
                    ctModWis += 7;
                    
                    if (bulk == 1)
                    {
                        ctModStr += 3;
                        ctModDex += 1;

                        if (height == 1)
                        {
                            ctModDex += 8;
                            ctModStr -= 1;
                            inventory.AddPerk(sshort);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 2)
                        {
                            ctModDex += 6;

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 3)
                        {
                            ctModDex += 3;
                            ctModStr += 1;
                            inventory.AddPerk(tall);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }

                    }
                    else if (bulk == 2)
                    {
                        ctModStr += 6;

                        if (height == 1)
                        {
                            ctModDex += 8;
                            ctModStr -= 1;
                            inventory.AddPerk(sshort);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 2)
                        {
                            ctModDex += 6;

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 3)
                        {
                            ctModDex += 3;
                            ctModStr += 1;
                            inventory.AddPerk(tall);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                    }
                    else if (bulk ==3)
                    {
                        ctModStr += 8;
                        ctModDex -= 1;
                        
                        if (height == 1)
                        {
                            ctModDex += 8;
                            ctModStr -= 1;
                            inventory.AddPerk(sshort);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 2)
                        {
                            ctModDex += 6;

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 3)
                        {
                            ctModDex += 3;
                            ctModStr += 1;
                            inventory.AddPerk(tall);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                    }
                
                }
                else if (age > 88 && age <= 99)
                {
                    ctModStr += 3;
                    ctModDex += 2;
                    ctModWis += 11;
                    
                    if (bulk == 1)
                    {
                        ctModStr += 3;
                        ctModDex += 1;

                        if (height == 1)
                        {
                            ctModDex += 8;
                            ctModStr -= 1;
                            inventory.AddPerk(sshort);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 2)
                        {
                            ctModDex += 6;

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 3)
                        {
                            ctModDex += 3;
                            ctModStr += 1;
                            inventory.AddPerk(tall);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }

                    }
                    else if (bulk == 2)
                    {
                        ctModStr += 6;

                        if (height == 1)
                        {
                            ctModDex += 8;
                            ctModStr -= 1;
                            inventory.AddPerk(sshort);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 2)
                        {
                            ctModDex += 6;

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 3)
                        {
                            ctModDex += 3;
                            ctModStr += 1;
                            inventory.AddPerk(tall);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                    }
                    else if (bulk ==3)
                    {
                        ctModStr += 8;
                        ctModDex -= 1;
                        
                        if (height == 1)
                        {
                            ctModDex += 8;
                            ctModStr -= 1;
                            inventory.AddPerk(sshort);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 2)
                        {
                            ctModDex += 6;

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 3)
                        {
                            ctModDex += 3;
                            ctModStr += 1;
                            inventory.AddPerk(tall);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                    }
                
                }
                else if (age > 99 && age <= 110)
                {
                    ctModStr += 2;
                    ctModDex += 1;
                    ctModWis += 13;
                    
                    if (bulk == 1)
                    {
                        ctModStr += 3;
                        ctModDex += 1;

                        if (height == 1)
                        {
                            ctModDex += 8;
                            ctModStr -= 1;
                            inventory.AddPerk(sshort);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 2)
                        {
                            ctModDex += 6;

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 3)
                        {
                            ctModDex += 3;
                            ctModStr += 1;
                            inventory.AddPerk(tall);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }

                    }
                    else if (bulk == 2)
                    {
                        ctModStr += 6;

                        if (height == 1)
                        {
                            ctModDex += 8;
                            ctModStr -= 1;
                            inventory.AddPerk(sshort);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 2)
                        {
                            ctModDex += 6;

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 3)
                        {
                            ctModDex += 3;
                            ctModStr += 1;
                            inventory.AddPerk(tall);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                    }
                    else if (bulk ==3)
                    {
                        ctModStr += 8;
                        ctModDex -= 1;
                        
                        if (height == 1)
                        {
                            ctModDex += 8;
                            ctModStr -= 1;
                            inventory.AddPerk(sshort);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 2)
                        {
                            ctModDex += 6;

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                        else if (height == 3)
                        {
                            ctModDex += 3;
                            ctModStr += 1;
                            inventory.AddPerk(tall);

                            if (alignment == 1)
                            {
                                inventory.AddPerk(passive);
                                ctModStr -= 4;
                                ctModWis += 7;
                                ctModChar += 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 2)
                            {
                                ctModChar += 2;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                            if (alignment == 3)
                            {
                                inventory.AddPerk(passive);
                                ctModStr += 4;
                                ctModWis -= 7;
                                ctModChar -= 4;
                                cStr = (int)Math.Round(ctModStr);
                                cDex = (int)Math.Round(ctModDex);
                                cWis = (int)Math.Round(ctModWis);
                                cCharisma = (int)Math.Round(ctModChar);
                            }
                        }
                    }
                
                }
            
            }
            else if (race == 5)
            {

            }
            else if (race == 6)
            {

            }
            else if (race == 7)
            {

            }
            else if (race == 8)
            {

            }
            else if (race == 9)
            {

            }

            return Tuple.Create(cStr, cDex, cWis, cCharisma);
        }
        // Turns the class to str, dex, etc.
        static Tuple<float, float, float, float> CharacterAdvancedStatCreator(int cClass, ref float cStr, ref float cDex, ref float cWis, ref float cCharisma)
        {

            if (cClass == 1)
            {
                cStr *= 1.76f;
                cDex *= 0.69f;
                cWis *= 0.61f;
                cCharisma *= 0.71f;
                cStr = (int)Math.Round(cStr);
                cDex = (int)Math.Round(cDex);
                cWis = (int)Math.Round(cWis);
                cCharisma = (int)Math.Round(cCharisma);
                return Tuple.Create(cStr, cDex, cWis, cCharisma);
            }
            else if (cClass == 2)
            {
                cStr *= 0.47f;
                cDex *= 1.49f;
                cWis *= 1.27f;
                cCharisma *= 1.18f;
                cStr = (int)Math.Round(cStr);
                cDex = (int)Math.Round(cDex);
                cWis = (int)Math.Round(cWis);
                cCharisma = (int)Math.Round(cCharisma);
                return Tuple.Create(cStr, cDex, cWis, cCharisma);
            }
            else if (cClass == 3)
            {
                cStr *= 0.83f;
                cDex *= 1.15f;
                cWis *= 3.29f;
                cCharisma *= 1.08f;
                cStr = (int)Math.Round(cStr);
                cDex = (int)Math.Round(cDex);
                cWis = (int)Math.Round(cWis);
                cCharisma = (int)Math.Round(cCharisma);
                return Tuple.Create(cStr, cDex, cWis, cCharisma);
            }
            else if (cClass == 4)
            {
                cStr *= 0.9f;
                cDex *= 0.9f;
                cWis *= 0.9f;
                cCharisma *= 1.99f;
                cStr = (int)Math.Round(cStr);
                cDex = (int)Math.Round(cDex);
                cWis = (int)Math.Round(cWis);
                cCharisma = (int)Math.Round(cCharisma);
                return Tuple.Create(cStr, cDex, cWis, cCharisma);
            }
            else if (cClass == 41131514)
            {
                cStr *= 2.35f;
                cDex *= 1.89f;
                cWis = (-cWis) * 1.6f;
                cCharisma *= 0.07f;
                cStr = (int)Math.Round(cStr);
                cDex = (int)Math.Round(cDex);
                cWis = (int)Math.Round(cWis);
                cCharisma = (int)Math.Round(cCharisma);
                return Tuple.Create(cStr, cDex, cWis, cCharisma);
            }
            return Tuple.Create(cStr, cDex, cWis, cCharisma);
        }
        static void CharacterEquipmentFinder(int cClass, ref float cStr, ref float cDex, ref float cWis, ref float cCharisma)
        {
            int i = 1;

            Inventory inventory = new Inventory();
            AddInventoryAmmo ironArrow = new AddInventoryAmmo { Name = "Iron Arrows", Damage = 11, Quantity = 1 };
            AddInventoryAmmo woodArrow = new AddInventoryAmmo { Name = "Wooden Arrows", Damage = 6, Quantity = 1 };

            AddInventoryItem estutsFlask = new AddInventoryItem { Name = "Estus Flask", Quantity = 1 };
            AddInventoryWeapon battleAxe = new AddInventoryWeapon { Name = "Battle Axe", TwoHanded = false, BleedDamage = 0, Damage = 32, Quantity = 1 };
            AddInventoryWeapon zwiehander = new AddInventoryWeapon { Name = "Zwiehander", TwoHanded = true, BleedDamage = 0, Damage = 67, Quantity = 1 };
            AddInventoryWeapon shortBow = new AddInventoryWeapon { Name = "Short Bow", TwoHanded = true, BleedDamage = 0, Damage = 49, Quantity = 1 };
            AddInventoryWeapon dagger = new AddInventoryWeapon { Name = "Dagger", TwoHanded = false, BleedDamage = 20, Damage = 16, Quantity = 1 };
            AddInventoryWeapon woodClub = new AddInventoryWeapon { Name = "Wooden Club", TwoHanded = true, Damage = 41, Quantity = 1 };
            AddInventoryWeapon reinforcedSpikedClub = new AddInventoryWeapon { Name = "Reinforced Spiked Club", TwoHanded = true, BleedDamage = 30, Damage = 78, Quantity = 1 };
            AddInventoryWeapon dragonsTooth = new AddInventoryWeapon { Name = "Dragon Tooth Club", TwoHanded = true, Damage = 182, Quantity = 1 };


            AddInventorySpell spell_00001 = new AddInventorySpell { Name = "Firebolt", Damage = 65, FPCost = 35, Quantity = 1 };
            AddInventorySpell spell_00002 = new AddInventorySpell { Name = "Lightning", Damage = 96, FPCost = 47, Quantity = 1 };
            if (cClass == 1)
            {
                if (cStr > 19.5)
                {
                    inventory.AddWeapon(zwiehander);
                }
                else
                {
                    inventory.AddWeapon(battleAxe);
                }
            }
            else if (cClass == 2)
            {
                if (cDex > 16.5)
                {
                    inventory.AddWeapon(shortBow);
                    while (i < 30)
                        inventory.AddAmmo(ironArrow);
                    i++;

                }
                else
                {
                    inventory.AddWeapon(dagger);
                }
            }
            else if (cClass == 3)
            {
                if (cWis > 6)
                {
                    inventory.AddSpell(spell_00001);

                }
                else
                {
                    inventory.AddSpell(spell_00001);
                }
            }
            else if (cClass == 4)
            {
                inventory.AddWeapon(woodClub);
            }
            inventory.DisplayInventory();
        }
    }

  
}



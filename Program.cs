using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace TEZXANDVENTURE // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            // Creating initial variables 
            int age = 0, height = 0, bulk = 0, alignment = 0, cClass = 0, cGold;
            float cStr = 0, cDex = 0, cWis = 0, cChar = 0;
            string name = "";

            // Title Screen Animation
            ConsoleTitleThig();

            Prologue.ConsoleScrollingTextThig_01();

            // Initiates the Character Verification and assing the variables with the newly inputed info (character height, age, name, bulk, alignment)
            Console.Clear();
            Tuple<string, int, float, float, float, float, int> charTupleValues_0 = CharacterManager(name, cClass, age, height, bulk, alignment, ref cStr, ref cDex, ref cWis, ref cChar);
            name = charTupleValues_0.Item1; alignment = charTupleValues_0.Item2; cStr = charTupleValues_0.Item3; cDex = charTupleValues_0.Item4; cWis = charTupleValues_0.Item5; cChar = charTupleValues_0.Item6; cClass = charTupleValues_0.Item7;

            // Initiates the Character Verification and assing the variables with the newly inputed info (character class)
            Tuple<float, float, float, float> charTupleValues_1 = CharacterAdvancedStatCreator(cClass, ref cStr, ref cDex, ref cWis, ref cChar);
            cStr = charTupleValues_0.Item3; cDex = charTupleValues_0.Item4; cWis = charTupleValues_0.Item5; cChar = charTupleValues_0.Item6; cClass = charTupleValues_0.Item7;
        }

        // START SCREEN ANIMATION
        static void TitleCoolThig()
        {
            Console.WriteLine(""); Console.WriteLine("   ▄▄▄▄▀ ▄███▄       ▄   ▄▄▄▄▄▄       ██      ▄   ██▄       ▄   ▄███▄      ▄      ▄▄▄▄▀   ▄   █▄▄▄▄ ▄███▄   "); Console.WriteLine("▀▀▀ █    █▀   ▀  ▀▄   █ ▀   ▄▄▀       █ █      █  █  █       █  █▀   ▀      █  ▀▀▀ █       █  █  ▄▀ █▀   ▀  "); Console.WriteLine("    █    ██▄▄      █ ▀   ▄▀▀   ▄▀     █▄▄█ ██   █ █   █ █     █ ██▄▄    ██   █     █    █   █ █▀▀▌  ██▄▄    "); Console.WriteLine("   █     █▄   ▄▀  ▄ █    ▀▀▀▀▀▀       █  █ █ █  █ █  █   █    █ █▄   ▄▀ █ █  █    █     █   █ █  █  █▄   ▄▀ "); Console.WriteLine("  ▀      ▀███▀   █   ▀▄                  █ █  █ █ ███▀    █  █  ▀███▀   █  █ █   ▀      █▄ ▄█   █   ▀███▀   "); Console.WriteLine("                  ▀                     █  █   ██          █▐           █   ██           ▀▀▀   ▀            "); Console.WriteLine("                                       ▀                   ▐                                                "); Console.WriteLine("");
        }
        static void ConsoleTitleThig()
        {
            int titleHeight = 9; // Adjust value based on the actual height of title
            int animationSpeed = 200; // Adjust value to control animation speed

            int windowHeight = Console.WindowHeight;
            int initialTop = windowHeight - titleHeight;

            while (initialTop >= 0)
            {
                Console.Clear();
                Console.SetCursorPosition(0, initialTop);
                TitleCoolThig();
                Thread.Sleep(animationSpeed);
                initialTop--;
            }
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
                Console.Write("Enter Class. 1 = Warrior; 2 = Explorer; 3 = Deprived; 4 = Cleric: ");
                string i = Console.ReadLine();
                if (int.TryParse(i, out cClass))
                {
                    if (cClass > 3 && cClass < 451131514 && cClass > 451131514 || cClass < 1) { Console.WriteLine("\n\n\nINVALID BULK\n"); Console.ReadLine(); }
                    else
                    {
                        if (cClass == 1) { Console.WriteLine("You are an warrior? \ny or n"); string ii = Console.ReadLine(); if (ii != "n" && ii != "y") { Console.WriteLine("INVALID ANSWER"); Console.ReadLine(); } else if (ii == "y") { return cClass; } }
                        else if (cClass == 2) { Console.WriteLine("You are a explorer? \ny or n"); string ii = Console.ReadLine(); if (ii != "n" && ii != "y") { Console.WriteLine("INVALID ANSWER"); Console.ReadLine(); } else if (ii == "y") { return cClass; } }
                        else if (cClass == 3) { Console.WriteLine("You are a deprived? \ny or n"); string ii = Console.ReadLine(); if (ii != "n" && ii != "y") { Console.WriteLine("INVALID ANSWER"); Console.ReadLine(); } else if (ii == "y") { return cClass; } }
                        else if (cClass == 4) { Console.WriteLine("Really? \ny or n"); string ii = Console.ReadLine(); if (ii != "n" && ii != "y") { Console.WriteLine("INVALID ANSWER"); Console.ReadLine(); } else if (ii == "y") { return cClass; } }
                        else if (cClass == 451131514)
                        {//DeamonAnimationRaceCreation_0;
                            return cClass;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("\n\n\nINVALID CLASS\n"); Console.ReadLine();
                }
            }
        }
        static int CharHeightCreator(ref int height)
        {
            while (true)
            {
                Console.Clear();
                Console.Write("Enter height. 1 = short; 2 = average; 3 = tall: ");
                string i = Console.ReadLine();
                if (int.TryParse(i, out height))
                {
                    if (height > 3 || height < 1) { Console.WriteLine("\n\n\nINVALID HEIGHT\n"); Console.ReadLine(); }
                    else
                    {
                        if (height == 1) { Console.WriteLine("You are short? \ny or n"); string ii = Console.ReadLine(); if (ii != "n" && ii != "y") { Console.WriteLine("INVALID ANSWER"); Console.ReadLine(); } else if (ii == "y") { return height; } }
                        else if (height == 2) { Console.WriteLine("You are averagely tall? \ny or n"); string ii = Console.ReadLine(); if (ii != "n" && ii != "y") { Console.WriteLine("INVALID ANSWER"); Console.ReadLine(); } else if (ii == "y") { return height; } }
                        else if (height == 3) { Console.WriteLine("You are tall? \ny or n"); string ii = Console.ReadLine(); if (ii != "n" && ii != "y") { Console.WriteLine("INVALID ANSWER"); Console.ReadLine(); } else if (ii == "y") { return height; } }
                    }
                }
                else
                {
                    Console.WriteLine("\n\n\nINVALID HEIGHT\n"); Console.ReadLine();
                }

            }
        }
        static int CharBulkCreator(ref int bulk)
        {
            while (true)
            {
                Console.Clear();
                Console.Write("Enter bulk. 1 = scrawny; 2 = average; 3 = buff: ");
                string i = Console.ReadLine();
                if (int.TryParse(i, out bulk))
                {
                    if (bulk > 3 && bulk < 9000 && bulk > 9000 || bulk < 1) { Console.WriteLine("\n\n\nINVALID BULK\n"); Console.ReadLine(); }
                    else
                    {
                        if (bulk == 1) { Console.WriteLine("You are scrawny? \ny or n"); string ii = Console.ReadLine(); if (ii != "n" && ii != "y") { Console.WriteLine("INVALID ANSWER"); Console.ReadLine(); } else if (ii == "y") { return bulk; } }
                        else if (bulk == 2) { Console.WriteLine("You are averagely strong? \ny or n"); string ii = Console.ReadLine(); if (ii != "n" && ii != "y") { Console.WriteLine("INVALID ANSWER"); Console.ReadLine(); } else if (ii == "y") { return bulk; } }
                        else if (bulk == 3) { Console.WriteLine("You are buff? \ny or n"); string ii = Console.ReadLine(); if (ii != "n" && ii != "y") { Console.WriteLine("INVALID ANSWER"); Console.ReadLine(); } else if (ii == "y") { return bulk; } }
                        else if (bulk == 9000) { Console.WriteLine("ITS OVER 9000!!! \ny or n"); string ii = Console.ReadLine(); if (ii != "n" && ii != "y") { Console.WriteLine("INVALID ANSWER"); Console.ReadLine(); } else if (ii == "y") { return bulk; } }
                    }
                }
                else
                {
                    Console.WriteLine("\n\n\nINVALID BULK\n"); Console.ReadLine();
                }
            }
        }
        static int CharAgeCreator(ref int age)
        {
            while (true)
            {
                Console.Clear();
                Console.Write("Enter age: ");
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
        static Tuple<string, int, float, float, float, float, int> CharacterManager(string name, int cClass, int age, int height, int bulk, int alignment, ref float cStr, ref float cDex, ref float cWis, ref float cCharisma)
        {
            while (true)
            {
                CharNameCreator(ref name);
                Prologue.ConsoleScrollingTextThig_02();
                CharClassCreator(ref cClass);
                CharAgeCreator(ref age);
                Prologue.ConsoleScrollingTextThig_03();
                CharHeightCreator(ref height);
                CharBulkCreator(ref bulk);
                CharAlignmentCreator(ref alignment);

                Console.Clear();
                Console.WriteLine("Name: " + name);
                Console.WriteLine("Age: " + age);

                if (cClass == 1) { Console.WriteLine("Class: Warrior"); ; }
                else if (cClass == 2) { Console.WriteLine("Class: Explorer"); }
                else if (cClass == 3) { Console.WriteLine("Class: Deprived"); }
                else if (cClass == 4) { Console.WriteLine("Class: Cleric?"); }
                else if (cClass == 451131514) { Console.WriteLine("Class: N£t ╘ Cl1%i$c"); }

                if (height == 1) { Console.WriteLine("Height: Short"); }
                else if (height == 2) { Console.WriteLine("Height: Mediocre"); }
                else if (height == 3) { Console.WriteLine("Height: Tall"); }

                if (bulk == 1) { Console.WriteLine("Bulk: Weak"); ; }
                else if (bulk == 2) { Console.WriteLine("Bulk: Average"); }
                else if (bulk == 3) { Console.WriteLine("Bulk: Strong"); }
                else if (bulk == 9000) { Console.WriteLine("Bulk: Unmeasureable"); }

                if (alignment == 1) { Console.WriteLine("Alignment: Passive"); ; }
                else if (alignment == 2) { Console.WriteLine("Alignment: Average"); }
                else if (alignment == 3) { Console.WriteLine("Alignment: Agressive"); }

                Console.WriteLine("\nIs this you character?\ny or n");
                string i = Convert.ToString(Console.ReadLine());

                if (i != "y" && i != "n") { Console.WriteLine("\n\n\nINVALID ANSWER\n"); }
                else if (i == "y")
                {
                    CharacterBasicStatCreator(name, age, height, bulk, alignment, ref cStr, ref cDex, ref cWis, ref cCharisma);
                    return Tuple.Create(name, alignment, cStr, cDex, cWis, cCharisma, cClass);
                }

            }
        }

        // Turns the age, height, race, etc. to str, dex, wis, etc.
        static Tuple<float, float, float, float> CharacterBasicStatCreator(string name, int age, int height, int bulk, int alignment, ref float cStr, ref float cDex, ref float cWis, ref float cCharisma)
        {
            float ctModStr = 0f, ctModDex = 0f, ctModWis = 0f, ctModChar = 0f;


            if (alignment == 1)
            {
                ctModChar += 13;
                ctModStr -= 3;
                ctModWis += 2;
                if (bulk == 1)
                {
                    ctModStr += 6;
                    ctModDex += 3;
                    if (height == 1)
                    {
                        ctModDex += 13;
                        ctModStr += 1;

                        if (age < 16)
                        {
                            ctModStr *= 0.81f;
                            ctModDex *= 1.17f;
                            ctModWis *= 0.63f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                        else if (age > 16 && age < 35)
                        {
                            ctModStr *= 1.21f;
                            ctModDex *= 0.93f;
                            ctModWis *= 0.75f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                        else if (age > 35 && age <= 65)
                        {
                            ctModStr *= 0.95f;
                            ctModDex *= 0.84f;
                            ctModWis *= 0.87f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                        else if (age > 65 && age <= 80)
                        {
                            ctModDex *= 0.71f;
                            ctModStr *= 0.87f;
                            ctModWis *= 1.01f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                        else
                        {
                            ctModDex *= 0.65f;
                            ctModStr *= 0.72f;
                            ctModWis *= 1.27f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                    }
                    else if (height == 2)
                    {
                        ctModDex += 9;
                        ctModStr += 2;

                        if (age < 16)
                        {
                            ctModStr *= 0.81f;
                            ctModDex *= 1.17f;
                            ctModWis *= 0.63f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                        else if (age > 16 && age < 35)
                        {
                            ctModStr *= 1.21f;
                            ctModDex *= 0.93f;
                            ctModWis *= 0.75f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                        else if (age > 35 && age <= 65)
                        {
                            ctModStr *= 0.95f;
                            ctModDex *= 0.84f;
                            ctModWis *= 0.87f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                        else if (age > 65 && age <= 80)
                        {
                            ctModDex *= 0.71f;
                            ctModStr *= 0.87f;
                            ctModWis *= 1.01f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                        else
                        {
                            ctModDex *= 0.65f;
                            ctModStr *= 0.72f;
                            ctModWis *= 1.27f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                    }
                    else if (height == 3)
                    {
                        ctModDex += 6;
                        ctModStr += 1;

                        if (age < 16)
                        {
                            ctModStr *= 0.81f;
                            ctModDex *= 1.17f;
                            ctModWis *= 0.63f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                        else if (age > 16 && age < 35)
                        {
                            ctModStr *= 1.21f;
                            ctModDex *= 0.93f;
                            ctModWis *= 0.75f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                        else if (age > 35 && age <= 65)
                        {
                            ctModStr *= 0.95f;
                            ctModDex *= 0.84f;
                            ctModWis *= 0.87f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                        else if (age > 65 && age <= 80)
                        {
                            ctModDex *= 0.71f;
                            ctModStr *= 0.87f;
                            ctModWis *= 1.01f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                        else
                        {
                            ctModDex *= 0.65f;
                            ctModStr *= 0.72f;
                            ctModWis *= 1.27f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                    }
                }
                else if (bulk == 2)
                {
                    ctModStr += 9;
                    ctModDex += 2;
                    ctModChar += 1;
                    if (height == 1)
                    {
                        ctModDex += 13;
                        ctModStr += 1;

                        if (age < 16)
                        {
                            ctModStr *= 0.81f;
                            ctModDex *= 1.17f;
                            ctModWis *= 0.63f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                        else if (age > 16 && age < 35)
                        {
                            ctModStr *= 1.21f;
                            ctModDex *= 0.93f;
                            ctModWis *= 0.75f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                        else if (age > 35 && age <= 65)
                        {
                            ctModStr *= 0.95f;
                            ctModDex *= 0.84f;
                            ctModWis *= 0.87f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                        else if (age > 65 && age <= 80)
                        {
                            ctModDex *= 0.71f;
                            ctModStr *= 0.87f;
                            ctModWis *= 1.01f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                        else
                        {
                            ctModDex *= 0.65f;
                            ctModStr *= 0.72f;
                            ctModWis *= 1.27f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                    }
                    else if (height == 2)
                    {
                        ctModDex += 9;
                        ctModStr += 2;

                        if (age < 16)
                        {
                            ctModStr *= 0.81f;
                            ctModDex *= 1.17f;
                            ctModWis *= 0.63f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                        else if (age > 16 && age < 35)
                        {
                            ctModStr *= 1.21f;
                            ctModDex *= 0.93f;
                            ctModWis *= 0.75f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                        else if (age > 35 && age <= 65)
                        {
                            ctModStr *= 0.95f;
                            ctModDex *= 0.84f;
                            ctModWis *= 0.87f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                        else if (age > 65 && age <= 80)
                        {
                            ctModDex *= 0.71f;
                            ctModStr *= 0.87f;
                            ctModWis *= 1.01f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                        else
                        {
                            ctModDex *= 0.65f;
                            ctModStr *= 0.72f;
                            ctModWis *= 1.27f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                    }
                    else if (height == 3)
                    {
                        ctModDex += 6;
                        ctModStr += 1;

                        if (age < 16)
                        {
                            ctModStr *= 0.81f;
                            ctModDex *= 1.17f;
                            ctModWis *= 0.63f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                        else if (age > 16 && age < 35)
                        {
                            ctModStr *= 1.21f;
                            ctModDex *= 0.93f;
                            ctModWis *= 0.75f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                        else if (age > 35 && age <= 65)
                        {
                            ctModStr *= 0.95f;
                            ctModDex *= 0.84f;
                            ctModWis *= 0.87f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                        else if (age > 65 && age <= 80)
                        {
                            ctModDex *= 0.71f;
                            ctModStr *= 0.87f;
                            ctModWis *= 1.01f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                        else
                        {
                            ctModDex *= 0.65f;
                            ctModStr *= 0.72f;
                            ctModWis *= 1.27f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                    }
                }
                else if (bulk == 3)
                {
                    ctModStr += 13;
                    ctModDex += 1;
                    ctModChar += 2;
                    if (height == 1)
                    {
                        ctModDex += 13;
                        ctModStr += 1;

                        if (age < 16)
                        {
                            ctModStr *= 0.81f;
                            ctModDex *= 1.17f;
                            ctModWis *= 0.63f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                        else if (age > 16 && age < 35)
                        {
                            ctModStr *= 1.21f;
                            ctModDex *= 0.93f;
                            ctModWis *= 0.75f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                        else if (age > 35 && age <= 65)
                        {
                            ctModStr *= 0.95f;
                            ctModDex *= 0.84f;
                            ctModWis *= 0.87f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                        else if (age > 65 && age <= 80)
                        {
                            ctModDex *= 0.71f;
                            ctModStr *= 0.87f;
                            ctModWis *= 1.01f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                        else
                        {
                            ctModDex *= 0.65f;
                            ctModStr *= 0.72f;
                            ctModWis *= 1.27f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                    }
                    else if (height == 2)
                    {
                        ctModDex += 9;
                        ctModStr += 2;

                        if (age < 16)
                        {
                            ctModStr *= 0.81f;
                            ctModDex *= 1.17f;
                            ctModWis *= 0.63f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                        else if (age > 16 && age < 35)
                        {
                            ctModStr *= 1.21f;
                            ctModDex *= 0.93f;
                            ctModWis *= 0.75f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                        else if (age > 35 && age <= 65)
                        {
                            ctModStr *= 0.95f;
                            ctModDex *= 0.84f;
                            ctModWis *= 0.87f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                        else if (age > 65 && age <= 80)
                        {
                            ctModDex *= 0.71f;
                            ctModStr *= 0.87f;
                            ctModWis *= 1.01f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                        else
                        {
                            ctModDex *= 0.65f;
                            ctModStr *= 0.72f;
                            ctModWis *= 1.27f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                    }
                    else if (height == 3)
                    {
                        ctModDex += 6;
                        ctModStr += 1;

                        if (age < 16)
                        {
                            ctModStr *= 0.81f;
                            ctModDex *= 1.17f;
                            ctModWis *= 0.63f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                        else if (age > 16 && age < 35)
                        {
                            ctModStr *= 1.21f;
                            ctModDex *= 0.93f;
                            ctModWis *= 0.75f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                        else if (age > 35 && age <= 65)
                        {
                            ctModStr *= 0.95f;
                            ctModDex *= 0.84f;
                            ctModWis *= 0.87f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                        else if (age > 65 && age <= 80)
                        {
                            ctModDex *= 0.71f;
                            ctModStr *= 0.87f;
                            ctModWis *= 1.01f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                        else
                        {
                            ctModDex *= 0.65f;
                            ctModStr *= 0.72f;
                            ctModWis *= 1.27f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                    }
                }
                else if (bulk == 9000)
                {
                    ctModStr += 20;
                    ctModChar += 3;
                    if (height == 1)
                    {
                        ctModDex += 13;
                        ctModStr += 1;

                        if (age < 16)
                        {
                            ctModStr *= 0.81f;
                            ctModDex *= 1.17f;
                            ctModWis *= 0.63f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                        else if (age > 16 && age < 35)
                        {
                            ctModStr *= 1.21f;
                            ctModDex *= 0.93f;
                            ctModWis *= 0.75f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                        else if (age > 35 && age <= 65)
                        {
                            ctModStr *= 0.95f;
                            ctModDex *= 0.84f;
                            ctModWis *= 0.87f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                        else if (age > 65 && age <= 80)
                        {
                            ctModDex *= 0.71f;
                            ctModStr *= 0.87f;
                            ctModWis *= 1.01f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                        else
                        {
                            ctModDex *= 0.65f;
                            ctModStr *= 0.72f;
                            ctModWis *= 1.27f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                    }
                    else if (height == 2)
                    {
                        ctModDex += 9;
                        ctModStr += 2;

                        if (age < 16)
                        {
                            ctModStr *= 0.81f;
                            ctModDex *= 1.17f;
                            ctModWis *= 0.63f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                        else if (age > 16 && age < 35)
                        {
                            ctModStr *= 1.21f;
                            ctModDex *= 0.93f;
                            ctModWis *= 0.75f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                        else if (age > 35 && age <= 65)
                        {
                            ctModStr *= 0.95f;
                            ctModDex *= 0.84f;
                            ctModWis *= 0.87f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                        else if (age > 65 && age <= 80)
                        {
                            ctModDex *= 0.71f;
                            ctModStr *= 0.87f;
                            ctModWis *= 1.01f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                        else
                        {
                            ctModDex *= 0.65f;
                            ctModStr *= 0.72f;
                            ctModWis *= 1.27f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                    }
                    else if (height == 3)
                    {
                        ctModDex += 6;
                        ctModStr += 1;

                        if (age < 16)
                        {
                            ctModStr *= 0.81f;
                            ctModDex *= 1.17f;
                            ctModWis *= 0.63f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                        else if (age > 16 && age < 35)
                        {
                            ctModStr *= 1.21f;
                            ctModDex *= 0.93f;
                            ctModWis *= 0.75f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                        else if (age > 35 && age <= 65)
                        {
                            ctModStr *= 0.95f;
                            ctModDex *= 0.84f;
                            ctModWis *= 0.87f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                        else if (age > 65 && age <= 80)
                        {
                            ctModDex *= 0.71f;
                            ctModStr *= 0.87f;
                            ctModWis *= 1.01f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                        else
                        {
                            ctModDex *= 0.65f;
                            ctModStr *= 0.72f;
                            ctModWis *= 1.27f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                    }
                }
            }
            else if (alignment == 2)
            {
                ctModChar += 9;
                if (bulk == 1)
                {
                    ctModStr += 6;
                    ctModDex += 3;
                    if (height == 1)
                    {
                        ctModDex += 13;
                        ctModStr += 1;

                        if (age < 16)
                        {
                            ctModStr *= 0.81f;
                            ctModDex *= 1.17f;
                            ctModWis *= 0.63f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                        else if (age > 16 && age < 35)
                        {
                            ctModStr *= 1.21f;
                            ctModDex *= 0.93f;
                            ctModWis *= 0.75f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                        else if (age > 35 && age <= 65)
                        {
                            ctModStr *= 0.95f;
                            ctModDex *= 0.84f;
                            ctModWis *= 0.87f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                        else if (age > 65 && age <= 80)
                        {
                            ctModDex *= 0.71f;
                            ctModStr *= 0.87f;
                            ctModWis *= 1.01f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                        else
                        {
                            ctModDex *= 0.65f;
                            ctModStr *= 0.72f;
                            ctModWis *= 1.27f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                    }
                    else if (height == 2)
                    {
                        ctModDex += 9;
                        ctModStr += 2;

                        if (age < 16)
                        {
                            ctModStr *= 0.81f;
                            ctModDex *= 1.17f;
                            ctModWis *= 0.63f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                        else if (age > 16 && age < 35)
                        {
                            ctModStr *= 1.21f;
                            ctModDex *= 0.93f;
                            ctModWis *= 0.75f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                        else if (age > 35 && age <= 65)
                        {
                            ctModStr *= 0.95f;
                            ctModDex *= 0.84f;
                            ctModWis *= 0.87f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                        else if (age > 65 && age <= 80)
                        {
                            ctModDex *= 0.71f;
                            ctModStr *= 0.87f;
                            ctModWis *= 1.01f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                        else
                        {
                            ctModDex *= 0.65f;
                            ctModStr *= 0.72f;
                            ctModWis *= 1.27f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                    }
                    else if (height == 3)
                    {
                        ctModDex += 6;
                        ctModStr += 1;

                        if (age < 16)
                        {
                            ctModStr *= 0.81f;
                            ctModDex *= 1.17f;
                            ctModWis *= 0.63f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                        else if (age > 16 && age < 35)
                        {
                            ctModStr *= 1.21f;
                            ctModDex *= 0.93f;
                            ctModWis *= 0.75f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                        else if (age > 35 && age <= 65)
                        {
                            ctModStr *= 0.95f;
                            ctModDex *= 0.84f;
                            ctModWis *= 0.87f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                        else if (age > 65 && age <= 80)
                        {
                            ctModDex *= 0.71f;
                            ctModStr *= 0.87f;
                            ctModWis *= 1.01f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                        else
                        {
                            ctModDex *= 0.65f;
                            ctModStr *= 0.72f;
                            ctModWis *= 1.27f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                    }
                }
                else if (bulk == 2)
                {
                    ctModStr += 9;
                    ctModDex += 2;
                    ctModChar += 1;
                    if (height == 1)
                    {
                        ctModDex += 13;
                        ctModStr += 1;

                        if (age < 16)
                        {
                            ctModStr *= 0.81f;
                            ctModDex *= 1.17f;
                            ctModWis *= 0.63f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                        else if (age > 16 && age < 35)
                        {
                            ctModStr *= 1.21f;
                            ctModDex *= 0.93f;
                            ctModWis *= 0.75f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                        else if (age > 35 && age <= 65)
                        {
                            ctModStr *= 0.95f;
                            ctModDex *= 0.84f;
                            ctModWis *= 0.87f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                        else if (age > 65 && age <= 80)
                        {
                            ctModDex *= 0.71f;
                            ctModStr *= 0.87f;
                            ctModWis *= 1.01f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                        else
                        {
                            ctModDex *= 0.65f;
                            ctModStr *= 0.72f;
                            ctModWis *= 1.27f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                    }
                    else if (height == 2)
                    {
                        ctModDex += 9;
                        ctModStr += 2;

                        if (age < 16)
                        {
                            ctModStr *= 0.81f;
                            ctModDex *= 1.17f;
                            ctModWis *= 0.63f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                        else if (age > 16 && age < 35)
                        {
                            ctModStr *= 1.21f;
                            ctModDex *= 0.93f;
                            ctModWis *= 0.75f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                        else if (age > 35 && age <= 65)
                        {
                            ctModStr *= 0.95f;
                            ctModDex *= 0.84f;
                            ctModWis *= 0.87f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                        else if (age > 65 && age <= 80)
                        {
                            ctModDex *= 0.71f;
                            ctModStr *= 0.87f;
                            ctModWis *= 1.01f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                        else
                        {
                            ctModDex *= 0.65f;
                            ctModStr *= 0.72f;
                            ctModWis *= 1.27f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                    }
                    else if (height == 3)
                    {
                        ctModDex += 6;
                        ctModStr += 1;

                        if (age < 16)
                        {
                            ctModStr *= 0.81f;
                            ctModDex *= 1.17f;
                            ctModWis *= 0.63f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                        else if (age > 16 && age < 35)
                        {
                            ctModStr *= 1.21f;
                            ctModDex *= 0.93f;
                            ctModWis *= 0.75f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                        else if (age > 35 && age <= 65)
                        {
                            ctModStr *= 0.95f;
                            ctModDex *= 0.84f;
                            ctModWis *= 0.87f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                        else if (age > 65 && age <= 80)
                        {
                            ctModDex *= 0.71f;
                            ctModStr *= 0.87f;
                            ctModWis *= 1.01f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                        else
                        {
                            ctModDex *= 0.65f;
                            ctModStr *= 0.72f;
                            ctModWis *= 1.27f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                    }
                }
                else if (bulk == 3)
                {
                    ctModStr += 13;
                    ctModDex += 1;
                    ctModChar += 2;
                    if (height == 1)
                    {
                        ctModDex += 13;
                        ctModStr += 1;

                        if (age < 16)
                        {
                            ctModStr *= 0.81f;
                            ctModDex *= 1.17f;
                            ctModWis *= 0.63f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                        else if (age > 16 && age < 35)
                        {
                            ctModStr *= 1.21f;
                            ctModDex *= 0.93f;
                            ctModWis *= 0.75f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                        else if (age > 35 && age <= 65)
                        {
                            ctModStr *= 0.95f;
                            ctModDex *= 0.84f;
                            ctModWis *= 0.87f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                        else if (age > 65 && age <= 80)
                        {
                            ctModDex *= 0.71f;
                            ctModStr *= 0.87f;
                            ctModWis *= 1.01f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                        else
                        {
                            ctModDex *= 0.65f;
                            ctModStr *= 0.72f;
                            ctModWis *= 1.27f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                    }
                    else if (height == 2)
                    {
                        ctModDex += 9;
                        ctModStr += 2;

                        if (age < 16)
                        {
                            ctModStr *= 0.81f;
                            ctModDex *= 1.17f;
                            ctModWis *= 0.63f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                        else if (age > 16 && age < 35)
                        {
                            ctModStr *= 1.21f;
                            ctModDex *= 0.93f;
                            ctModWis *= 0.75f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                        else if (age > 35 && age <= 65)
                        {
                            ctModStr *= 0.95f;
                            ctModDex *= 0.84f;
                            ctModWis *= 0.87f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                        else if (age > 65 && age <= 80)
                        {
                            ctModDex *= 0.71f;
                            ctModStr *= 0.87f;
                            ctModWis *= 1.01f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                        else
                        {
                            ctModDex *= 0.65f;
                            ctModStr *= 0.72f;
                            ctModWis *= 1.27f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                    }
                    else if (height == 3)
                    {
                        ctModDex += 6;
                        ctModStr += 1;

                        if (age < 16)
                        {
                            ctModStr *= 0.81f;
                            ctModDex *= 1.17f;
                            ctModWis *= 0.63f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                        else if (age > 16 && age < 35)
                        {
                            ctModStr *= 1.21f;
                            ctModDex *= 0.93f;
                            ctModWis *= 0.75f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                        else if (age > 35 && age <= 65)
                        {
                            ctModStr *= 0.95f;
                            ctModDex *= 0.84f;
                            ctModWis *= 0.87f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                        else if (age > 65 && age <= 80)
                        {
                            ctModDex *= 0.71f;
                            ctModStr *= 0.87f;
                            ctModWis *= 1.01f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                        else
                        {
                            ctModDex *= 0.65f;
                            ctModStr *= 0.72f;
                            ctModWis *= 1.27f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                    }
                }
                else if (bulk == 9000)
                {
                    ctModStr += 20;
                    ctModChar += 3;
                    if (height == 1)
                    {
                        ctModDex += 13;
                        ctModStr += 1;

                        if (age < 16)
                        {
                            ctModStr *= 0.81f;
                            ctModDex *= 1.17f;
                            ctModWis *= 0.63f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                        else if (age > 16 && age < 35)
                        {
                            ctModStr *= 1.21f;
                            ctModDex *= 0.93f;
                            ctModWis *= 0.75f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                        else if (age > 35 && age <= 65)
                        {
                            ctModStr *= 0.95f;
                            ctModDex *= 0.84f;
                            ctModWis *= 0.87f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                        else if (age > 65 && age <= 80)
                        {
                            ctModDex *= 0.71f;
                            ctModStr *= 0.87f;
                            ctModWis *= 1.01f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                        else
                        {
                            ctModDex *= 0.65f;
                            ctModStr *= 0.72f;
                            ctModWis *= 1.27f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                    }
                    else if (height == 2)
                    {
                        ctModDex += 9;
                        ctModStr += 2;

                        if (age < 16)
                        {
                            ctModStr *= 0.81f;
                            ctModDex *= 1.17f;
                            ctModWis *= 0.63f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                        else if (age > 16 && age < 35)
                        {
                            ctModStr *= 1.21f;
                            ctModDex *= 0.93f;
                            ctModWis *= 0.75f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                        else if (age > 35 && age <= 65)
                        {
                            ctModStr *= 0.95f;
                            ctModDex *= 0.84f;
                            ctModWis *= 0.87f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                        else if (age > 65 && age <= 80)
                        {
                            ctModDex *= 0.71f;
                            ctModStr *= 0.87f;
                            ctModWis *= 1.01f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                        else
                        {
                            ctModDex *= 0.65f;
                            ctModStr *= 0.72f;
                            ctModWis *= 1.27f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                    }
                    else if (height == 3)
                    {
                        ctModDex += 6;
                        ctModStr += 1;

                        if (age < 16)
                        {
                            ctModStr *= 0.81f;
                            ctModDex *= 1.17f;
                            ctModWis *= 0.63f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                        else if (age > 16 && age < 35)
                        {
                            ctModStr *= 1.21f;
                            ctModDex *= 0.93f;
                            ctModWis *= 0.75f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                        else if (age > 35 && age <= 65)
                        {
                            ctModStr *= 0.95f;
                            ctModDex *= 0.84f;
                            ctModWis *= 0.87f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                        else if (age > 65 && age <= 80)
                        {
                            ctModDex *= 0.71f;
                            ctModStr *= 0.87f;
                            ctModWis *= 1.01f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                        else
                        {
                            ctModDex *= 0.65f;
                            ctModStr *= 0.72f;
                            ctModWis *= 1.27f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                    }
                }
            }
            else if (alignment == 3)
            {
                ctModChar += 6;
                ctModStr += 2;
                ctModDex += 1;
                if (bulk == 1)
                {
                    ctModStr += 6;
                    ctModDex += 3;
                    if (height == 1)
                    {
                        ctModDex += 13;
                        ctModStr += 1;

                        if (age < 16)
                        {
                            ctModStr *= 0.81f;
                            ctModDex *= 1.17f;
                            ctModWis *= 0.63f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                        else if (age > 16 && age < 35)
                        {
                            ctModStr *= 1.21f;
                            ctModDex *= 0.93f;
                            ctModWis *= 0.75f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                        else if (age > 35 && age <= 65)
                        {
                            ctModStr *= 0.95f;
                            ctModDex *= 0.84f;
                            ctModWis *= 0.87f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                        else if (age > 65 && age <= 80)
                        {
                            ctModDex *= 0.71f;
                            ctModStr *= 0.87f;
                            ctModWis *= 1.01f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                        else
                        {
                            ctModDex *= 0.65f;
                            ctModStr *= 0.72f;
                            ctModWis *= 1.27f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                    }
                    else if (height == 2)
                    {
                        ctModDex += 9;
                        ctModStr += 2;

                        if (age < 16)
                        {
                            ctModStr *= 0.81f;
                            ctModDex *= 1.17f;
                            ctModWis *= 0.63f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                        else if (age > 16 && age < 35)
                        {
                            ctModStr *= 1.21f;
                            ctModDex *= 0.93f;
                            ctModWis *= 0.75f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                        else if (age > 35 && age <= 65)
                        {
                            ctModStr *= 0.95f;
                            ctModDex *= 0.84f;
                            ctModWis *= 0.87f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                        else if (age > 65 && age <= 80)
                        {
                            ctModDex *= 0.71f;
                            ctModStr *= 0.87f;
                            ctModWis *= 1.01f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                        else
                        {
                            ctModDex *= 0.65f;
                            ctModStr *= 0.72f;
                            ctModWis *= 1.27f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                    }
                    else if (height == 3)
                    {
                        ctModDex += 6;
                        ctModStr += 1;

                        if (age < 16)
                        {
                            ctModStr *= 0.81f;
                            ctModDex *= 1.17f;
                            ctModWis *= 0.63f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                        else if (age > 16 && age < 35)
                        {
                            ctModStr *= 1.21f;
                            ctModDex *= 0.93f;
                            ctModWis *= 0.75f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                        else if (age > 35 && age <= 65)
                        {
                            ctModStr *= 0.95f;
                            ctModDex *= 0.84f;
                            ctModWis *= 0.87f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                        else if (age > 65 && age <= 80)
                        {
                            ctModDex *= 0.71f;
                            ctModStr *= 0.87f;
                            ctModWis *= 1.01f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                        else
                        {
                            ctModDex *= 0.65f;
                            ctModStr *= 0.72f;
                            ctModWis *= 1.27f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                    }
                }
                else if (bulk == 2)
                {
                    ctModStr += 9;
                    ctModDex += 2;
                    ctModChar += 1;
                    if (height == 1)
                    {
                        ctModDex += 13;
                        ctModStr += 1;

                        if (age < 16)
                        {
                            ctModStr *= 0.81f;
                            ctModDex *= 1.17f;
                            ctModWis *= 0.63f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                        else if (age > 16 && age < 35)
                        {
                            ctModStr *= 1.21f;
                            ctModDex *= 0.93f;
                            ctModWis *= 0.75f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                        else if (age > 35 && age <= 65)
                        {
                            ctModStr *= 0.95f;
                            ctModDex *= 0.84f;
                            ctModWis *= 0.87f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                        else if (age > 65 && age <= 80)
                        {
                            ctModDex *= 0.71f;
                            ctModStr *= 0.87f;
                            ctModWis *= 1.01f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                        else
                        {
                            ctModDex *= 0.65f;
                            ctModStr *= 0.72f;
                            ctModWis *= 1.27f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                    }
                    else if (height == 2)
                    {
                        ctModDex += 9;
                        ctModStr += 2;

                        if (age < 16)
                        {
                            ctModStr *= 0.81f;
                            ctModDex *= 1.17f;
                            ctModWis *= 0.63f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                        else if (age > 16 && age < 35)
                        {
                            ctModStr *= 1.21f;
                            ctModDex *= 0.93f;
                            ctModWis *= 0.75f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                        else if (age > 35 && age <= 65)
                        {
                            ctModStr *= 0.95f;
                            ctModDex *= 0.84f;
                            ctModWis *= 0.87f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                        else if (age > 65 && age <= 80)
                        {
                            ctModDex *= 0.71f;
                            ctModStr *= 0.87f;
                            ctModWis *= 1.01f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                        else
                        {
                            ctModDex *= 0.65f;
                            ctModStr *= 0.72f;
                            ctModWis *= 1.27f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                    }
                    else if (height == 3)
                    {
                        ctModDex += 6;
                        ctModStr += 1;

                        if (age < 16)
                        {
                            ctModStr *= 0.81f;
                            ctModDex *= 1.17f;
                            ctModWis *= 0.63f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                        else if (age > 16 && age < 35)
                        {
                            ctModStr *= 1.21f;
                            ctModDex *= 0.93f;
                            ctModWis *= 0.75f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                        else if (age > 35 && age <= 65)
                        {
                            ctModStr *= 0.95f;
                            ctModDex *= 0.84f;
                            ctModWis *= 0.87f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                        else if (age > 65 && age <= 80)
                        {
                            ctModDex *= 0.71f;
                            ctModStr *= 0.87f;
                            ctModWis *= 1.01f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                        else
                        {
                            ctModDex *= 0.65f;
                            ctModStr *= 0.72f;
                            ctModWis *= 1.27f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                    }
                }
                else if (bulk == 3)
                {
                    ctModStr += 13;
                    ctModDex += 1;
                    ctModChar += 2;
                    if (height == 1)
                    {
                        ctModDex += 13;
                        ctModStr += 1;

                        if (age < 16)
                        {
                            ctModStr *= 0.81f;
                            ctModDex *= 1.17f;
                            ctModWis *= 0.63f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                        else if (age > 16 && age < 35)
                        {
                            ctModStr *= 1.21f;
                            ctModDex *= 0.93f;
                            ctModWis *= 0.75f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                        else if (age > 35 && age <= 65)
                        {
                            ctModStr *= 0.95f;
                            ctModDex *= 0.84f;
                            ctModWis *= 0.87f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                        else if (age > 65 && age <= 80)
                        {
                            ctModDex *= 0.71f;
                            ctModStr *= 0.87f;
                            ctModWis *= 1.01f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                        else
                        {
                            ctModDex *= 0.65f;
                            ctModStr *= 0.72f;
                            ctModWis *= 1.27f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                    }
                    else if (height == 2)
                    {
                        ctModDex += 9;
                        ctModStr += 2;

                        if (age < 16)
                        {
                            ctModStr *= 0.81f;
                            ctModDex *= 1.17f;
                            ctModWis *= 0.63f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                        else if (age > 16 && age < 35)
                        {
                            ctModStr *= 1.21f;
                            ctModDex *= 0.93f;
                            ctModWis *= 0.75f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                        else if (age > 35 && age <= 65)
                        {
                            ctModStr *= 0.95f;
                            ctModDex *= 0.84f;
                            ctModWis *= 0.87f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                        else if (age > 65 && age <= 80)
                        {
                            ctModDex *= 0.71f;
                            ctModStr *= 0.87f;
                            ctModWis *= 1.01f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                        else
                        {
                            ctModDex *= 0.65f;
                            ctModStr *= 0.72f;
                            ctModWis *= 1.27f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                    }
                    else if (height == 3)
                    {
                        ctModDex += 6;
                        ctModStr += 1;

                        if (age < 16)
                        {
                            ctModStr *= 0.81f;
                            ctModDex *= 1.17f;
                            ctModWis *= 0.63f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                        else if (age > 16 && age < 35)
                        {
                            ctModStr *= 1.21f;
                            ctModDex *= 0.93f;
                            ctModWis *= 0.75f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                        else if (age > 35 && age <= 65)
                        {
                            ctModStr *= 0.95f;
                            ctModDex *= 0.84f;
                            ctModWis *= 0.87f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                        else if (age > 65 && age <= 80)
                        {
                            ctModDex *= 0.71f;
                            ctModStr *= 0.87f;
                            ctModWis *= 1.01f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                        else
                        {
                            ctModDex *= 0.65f;
                            ctModStr *= 0.72f;
                            ctModWis *= 1.27f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                    }
                }
                else if (bulk == 9000)
                {
                    ctModStr += 20;
                    ctModChar += 3;
                    if (height == 1)
                    {
                        ctModDex += 13;
                        ctModStr += 1;

                        if (age < 16)
                        {
                            ctModStr *= 0.81f;
                            ctModDex *= 1.17f;
                            ctModWis *= 0.63f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                        else if (age > 16 && age < 35)
                        {
                            ctModStr *= 1.21f;
                            ctModDex *= 0.93f;
                            ctModWis *= 0.75f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                        else if (age > 35 && age <= 65)
                        {
                            ctModStr *= 0.95f;
                            ctModDex *= 0.84f;
                            ctModWis *= 0.87f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                        else if (age > 65 && age <= 80)
                        {
                            ctModDex *= 0.71f;
                            ctModStr *= 0.87f;
                            ctModWis *= 1.01f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                        else
                        {
                            ctModDex *= 0.65f;
                            ctModStr *= 0.72f;
                            ctModWis *= 1.27f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                    }
                    else if (height == 2)
                    {
                        ctModDex += 9;
                        ctModStr += 2;

                        if (age < 16)
                        {
                            ctModStr *= 0.81f;
                            ctModDex *= 1.17f;
                            ctModWis *= 0.63f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                        else if (age > 16 && age < 35)
                        {
                            ctModStr *= 1.21f;
                            ctModDex *= 0.93f;
                            ctModWis *= 0.75f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                        else if (age > 35 && age <= 65)
                        {
                            ctModStr *= 0.95f;
                            ctModDex *= 0.84f;
                            ctModWis *= 0.87f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                        else if (age > 65 && age <= 80)
                        {
                            ctModDex *= 0.71f;
                            ctModStr *= 0.87f;
                            ctModWis *= 1.01f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                        else
                        {
                            ctModDex *= 0.65f;
                            ctModStr *= 0.72f;
                            ctModWis *= 1.27f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                    }
                    else if (height == 3)
                    {
                        ctModDex += 6;
                        ctModStr += 1;

                        if (age < 16)
                        {
                            ctModStr *= 0.81f;
                            ctModDex *= 1.17f;
                            ctModWis *= 0.63f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                        else if (age > 16 && age < 35)
                        {
                            ctModStr *= 1.21f;
                            ctModDex *= 0.93f;
                            ctModWis *= 0.75f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                        else if (age > 35 && age <= 65)
                        {
                            ctModStr *= 0.95f;
                            ctModDex *= 0.84f;
                            ctModWis *= 0.87f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                        else if (age > 65 && age <= 80)
                        {
                            ctModDex *= 0.71f;
                            ctModStr *= 0.87f;
                            ctModWis *= 1.01f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                        else
                        {
                            ctModDex *= 0.65f;
                            ctModStr *= 0.72f;
                            ctModWis *= 1.27f;
                            cStr = (int)Math.Round(ctModStr);
                            cDex = (int)Math.Round(ctModDex);
                            cWis = (int)Math.Round(ctModWis);
                            cCharisma = (int)Math.Round(ctModChar);
                            return Tuple.Create(cStr, cDex, cWis, cCharisma);
                        }
                    }
                }
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
                cStr *= 1.2f;
                cDex *= 1.2f;
                cWis *= 1.1f;
                cCharisma *= 1.47f;
                cStr = (int)Math.Round(cStr);
                cDex = (int)Math.Round(cDex);
                cWis = (int)Math.Round(cWis);
                cCharisma = (int)Math.Round(cCharisma);
                return Tuple.Create(cStr, cDex, cWis, cCharisma);
            }
            else if (cClass == 4)
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
    }
}















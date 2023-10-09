using System;
using System.Runtime.CompilerServices;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleCleaner();
            int age = 0, height = 0, bulk = 0;
            string name = "";

            Tuple<string, int> charTupleValues = CharCreaterVerification(name, age, height, bulk);
            name = charTupleValues.Item1;
            age = charTupleValues.Item2;
        }

        static void ConsoleCleaner() { Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n"); }
        static string CharNameCreater(ref string name)

        {
            while (true)
            {
                Console.Write("What is your name: ");
                name = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Your name is " + name + "? \ny or n");
                string i = Convert.ToString(Console.ReadLine());
                if (i != "y" && i != "n") { Console.WriteLine("\n\n\nINVALID ANSWER\n"); }
                else if (i == "y")
                {
                    return name;
                }
            }
        }
        static int CharHeightCreater(ref int height)
        {
            while (true)
            {
                Console.Write("Enter height. 1 = short; 2 = average; 3 = tall: ");
                string i = Console.ReadLine();
                if (int.TryParse(i, out height))
                {
                    if (height > 3 || height < 1) { Console.WriteLine("\n\n\nINVALID HEIGHT\n"); }
                    else
                    {
                        if (height == 1) { Console.WriteLine("You are short? \ny or n"); string ii = Console.ReadLine(); if (ii != "n" && ii != "y") { Console.WriteLine("INVALID ANSWER"); } else if (ii == "y") { return height; } }
                        else if (height == 2) { Console.WriteLine("You are averagely tall? \ny or n"); string ii = Console.ReadLine(); if (ii != "n" && ii != "y") { Console.WriteLine("INVALID ANSWER"); } else if (ii == "y") { return height; } }
                        else if (height == 3) { Console.WriteLine("You are tall? \ny or n"); string ii = Console.ReadLine(); if (ii != "n" && ii != "y") { Console.WriteLine("INVALID ANSWER"); } else if (ii == "y") { return height; } }
                    }
                }
                else
                {
                    Console.WriteLine("\n\n\nINVALID HEIGHT\n");
                }

            }
        }
        static int CharBulkCreater(ref int bulk)
        {
            while (true)
            {
                Console.Write("Enter bulk. 1 = scrawny; 2 = average; 3 = buff: ");
                string i = Console.ReadLine();
                if (int.TryParse(i, out bulk))
                {
                    if (bulk > 3 && bulk < 9000 && bulk > 9000 || bulk < 1) { Console.WriteLine("\n\n\nINVALID BULK\n"); }
                    else
                    {
                        if (bulk == 1) { Console.WriteLine("You are scrawny? \ny or n"); string ii = Console.ReadLine(); if (ii != "n" && ii != "y") { Console.WriteLine("INVALID ANSWER"); } else if (ii == "y") { return bulk; } }
                        else if (bulk == 2) { Console.WriteLine("You are averagely strong? \ny or n"); string ii = Console.ReadLine(); if (ii != "n" && ii != "y") { Console.WriteLine("INVALID ANSWER"); } else if (ii == "y") { return bulk; } }
                        else if (bulk == 3) { Console.WriteLine("You are buff? \ny or n"); string ii = Console.ReadLine(); if (ii != "n" && ii != "y") { Console.WriteLine("INVALID ANSWER"); } else if (ii == "y") { return bulk; } }
                        else if (bulk == 9000) { Console.WriteLine("ITS OVER 9000!!! \ny or n"); string ii = Console.ReadLine(); if (ii != "n" && ii != "y") { Console.WriteLine("INVALID ANSWER"); } else if (ii == "y") { return bulk; } }
                    }
                }
                else
                {
                    Console.WriteLine("\n\n\nINVALID BULK\n");
                }
            }
          
        }
        static int CharAgeCreater(ref int age)
            {
                while (true)
                {
                    Console.Write("Enter age: ");
                    string i = Console.ReadLine();
                    if (int.TryParse(i, out age))
                    {
                        if (age > 100 || age <= 7) { Console.WriteLine("\n\n\nINVALID AGE\n"); }
                        else
                        {
                            Console.WriteLine("You are " + age + " years old? \ny or n");
                            string ii = Console.ReadLine();

                            if (ii != "n" && ii != "y")
                            {
                                Console.WriteLine("ok wanna play it that way, ill pick for you.\nAGE SET TO: 101");
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
                        Console.WriteLine("\n\n\nINVALID AGE\n");
                    }

                }
            }
        static Tuple<string, int> CharCreaterVerification(string name, int age, int height, int bulk)
            {
                while (true)
                {
                    CharNameCreater(ref name);
                    CharAgeCreater(ref age);
                    CharHeightCreater(ref height);
                    CharBulkCreater(ref bulk);

                    ConsoleCleaner();
                    Console.WriteLine("Name: " + name);
                    Console.WriteLine("Age: " + age);
                    if (height == 1) { Console.WriteLine("Height: Short"); }
                    else if (height == 2) { Console.WriteLine("Height: Mediocre"); }
                    else if (height == 3) { Console.WriteLine("Height: Tall"); }
                    if (bulk == 1) { Console.WriteLine("Bulk: Weak"); ;}
                    else if (bulk == 2) { Console.WriteLine("Bulk: Average");}
                    else if (bulk == 3) { Console.WriteLine("Bulk: Strong");}
                    else if (bulk == 9000) { Console.WriteLine("Bulk: Unmeasureable");}
                    Console.WriteLine("\nIs this you character?\ny or n");
                    string i = Convert.ToString(Console.ReadLine());
                    if (i != "y" && i != "n") { Console.WriteLine("\n\n\nINVALID ANSWER\n"); }
                    else if (i == "y")
                    {
                        return Tuple.Create(name, age);
                    }

                }

                return Tuple.Create("", 0);
            }

    }


}

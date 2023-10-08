using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleCleaner();
            CharCreater();
        }

        static string CharCreater()
        {
            bool creating = true;
            int age, height, width;
            string race, name, cClass;
            while (creating == true)
            {
                Console.WriteLine("Enter age: ");
                age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("You are " + age + " years old? \n y or n");
                string x = Console.ReadLine();

                if (x != "n" && x != "y")
                {
                    Console.WriteLine("ok wanna play it that way, ill pick for you.\n AGE SET TO: 142");
                } 

                break;
            }

           
            

            return "";
        }

        static void ConsoleCleaner(){Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");}
        
        
    
    }
     
        

    
    
}

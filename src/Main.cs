using System;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace TEZXANDVENTURE // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        public static void Main(string[] args)
        {               
            // Title Screen Animation
            Console.BufferHeight = 91;
            ConsoleTitleThig();
            Console.Clear();

            // Start Player Creation
            PlayerStats.manager();
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
        
        
    }

}
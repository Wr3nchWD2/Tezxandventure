using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            // Creating initial variables 
            int age = 0, height = 0, bulk = 0;
            float cStr = 0, cDex = 0, cWis = 0, cCharisma = 0;
            string name = "";

            // CASTLE
            ConsoleCastle();

            // Initiates the Character Verification and assing the variables with the newly inputed info
            Tuple<string, int, int, int> charTupleValues = CharacterFinalization(name, age, height, bulk, ref cStr, ref cDex, ref cWis, ref cCharisma);
            name = charTupleValues.Item1;
            age = charTupleValues.Item2;
            height = charTupleValues.Item3;
            bulk = charTupleValues.Item4;
        }
        // Clears a large space in the console
        static void ConsoleCastle()
        {
            int i = 1;
            string spav = "  ";
            while (i <= 20)
            {
                if (i == 1)
                {
                    Console.Clear();
                    Console.WriteLine(spav + "    |>>>                                                      |>>>");
                    Thread.Sleep(50);

                    Console.Clear();
                    Console.WriteLine("    |>>>                                                      |>>>");
                    i++;
                }
                else if (i == 2)
                {
                    Console.Clear();
                    Console.WriteLine("    |>>>                                                      |>>>");
                    Console.WriteLine(spav + "    |                     |>>>          |>>>                  |");
                    Thread.Sleep(50);

                    Console.Clear();
                    Console.WriteLine("    |>>>                                                      |>>>");
                    Console.WriteLine("    |                     |>>>          |>>>                  |");
                    i++;
                }
                else if (i == 3)
                {
                    Console.Clear();
                    Console.WriteLine("    |>>>                                                      |>>>");
                    Console.WriteLine("    |                     |>>>          |>>>                  |");
                    Console.WriteLine(spav + "    *                     |             |                     *");
                    Thread.Sleep(50);

                    Console.Clear();
                    Console.WriteLine("    |>>>                                                      |>>>");
                    Console.WriteLine("    |                     |>>>          |>>>                  |");
                    Console.WriteLine("    *                     |             |                     *");
                    i++;
                }
                else if (i == 4)
                {
                    Console.Clear();
                    Console.WriteLine("    |>>>                                                      |>>>");
                    Console.WriteLine("    |                     |>>>          |>>>                  |");
                    Console.WriteLine("    *                     |             |                     *");
                    Console.WriteLine(spav + "   / \\                    *             *                    / \\");
                    Thread.Sleep(50);

                    Console.Clear();
                    Console.WriteLine("    |>>>                                                      |>>>");
                    Console.WriteLine("    |                     |>>>          |>>>                  |");
                    Console.WriteLine("    *                     |             |                     *");
                    Console.WriteLine("   / \\                    *             *                    / \\");
                    i++;
                }
                else if (i == 5)
                {
                    Console.Clear();
                    Console.WriteLine("    |>>>                                                      |>>>");
                    Console.WriteLine("    |                     |>>>          |>>>                  |");
                    Console.WriteLine("    *                     |             |                     *");
                    Console.WriteLine("   / \\                    *             *                    / \\");
                    Console.WriteLine(spav + "  /___\\                 _/ \\           / \\_                 /___\\");
                    Thread.Sleep(50);

                    Console.Clear();
                    Console.WriteLine("    |>>>                                                      |>>>");
                    Console.WriteLine("    |                     |>>>          |>>>                  |");
                    Console.WriteLine("    *                     |             |                     *");
                    Console.WriteLine("   / \\                    *             *                    / \\");
                    Console.WriteLine("  /___\\                 _/ \\           / \\_                 /___\\");
                    i++;
                }
                else if (i == 6)
                {
                    Console.Clear();
                    Console.WriteLine("    |>>>                                                      |>>>");
                    Console.WriteLine("    |                     |>>>          |>>>                  |");
                    Console.WriteLine("    *                     |             |                     *");
                    Console.WriteLine("   / \\                    *             *                    / \\");
                    Console.WriteLine("  /___\\                 _/ \\           / \\_                 /___\\");
                    Console.WriteLine(spav + "  [   ]                |/   \\_________/   \\|                [   ]");
                    Thread.Sleep(50);

                    Console.Clear();
                    Console.WriteLine("    |>>>                                                      |>>>");
                    Console.WriteLine("    |                     |>>>          |>>>                  |");
                    Console.WriteLine("    *                     |             |                     *");
                    Console.WriteLine("   / \\                    *             *                    / \\");
                    Console.WriteLine("  /___\\                 _/ \\           / \\_                 /___\\");
                    Console.WriteLine("  [   ]                |/   \\_________/   \\|                [   ]");
                    i++;
                }
                else if (i == 7)
                {
                    Console.Clear();
                    Console.WriteLine("    |>>>                                                      |>>>");
                    Console.WriteLine("    |                     |>>>          |>>>                  |");
                    Console.WriteLine("    *                     |             |                     *");
                    Console.WriteLine("   / \\                    *             *                    / \\");
                    Console.WriteLine("  /___\\                 _/ \\           / \\_                 /___\\");
                    Console.WriteLine("  [   ]                |/   \\_________/   \\|                [   ]");
                    Console.WriteLine(spav + "  [ I ]                /  0  \\       /  0  \\                [ I ]");
                    Thread.Sleep(50);

                    Console.Clear();
                    Console.WriteLine("    |>>>                                                      |>>>");
                    Console.WriteLine("    |                     |>>>          |>>>                  |");
                    Console.WriteLine("    *                     |             |                     *");
                    Console.WriteLine("   / \\                    *             *                    / \\");
                    Console.WriteLine("  /___\\                 _/ \\           / \\_                 /___\\");
                    Console.WriteLine("  [   ]                |/   \\_________/   \\|                [   ]");
                    Console.WriteLine("  [ I ]                /  0  \\       /  0  \\                [ I ]");
                    i++;
                }
                else if (i == 8)
                {
                    Console.Clear();
                    Console.WriteLine("    |>>>                                                      |>>>");
                    Console.WriteLine("    |                     |>>>          |>>>                  |");
                    Console.WriteLine("    *                     |             |                     *");
                    Console.WriteLine("   / \\                    *             *                    / \\");
                    Console.WriteLine("  /___\\                 _/ \\           / \\_                 /___\\");
                    Console.WriteLine("  [   ]                |/   \\_________/   \\|                [   ]");
                    Console.WriteLine("  [ I ]                /  0  \\       /  0  \\                [ I ]");
                    Console.WriteLine(spav + "  [   ]_ _ _          /       \\     /       \\          _ _ _[   ]");
                    Thread.Sleep(50);

                    Console.Clear();
                    Console.WriteLine("    |>>>                                                      |>>>");
                    Console.WriteLine("    |                     |>>>          |>>>                  |");
                    Console.WriteLine("    *                     |             |                     *");
                    Console.WriteLine("   / \\                    *             *                    / \\");
                    Console.WriteLine("  /___\\                 _/ \\           / \\_                 /___\\");
                    Console.WriteLine("  [   ]                |/   \\_________/   \\|                [   ]");
                    Console.WriteLine("  [ I ]                /  0  \\       /  0  \\                [ I ]");
                    Console.WriteLine("  [   ]_ _ _          /       \\     /       \\          _ _ _[   ]");
                    i++;
                }
                else if (i == 9)
                {
                    Console.Clear();
                    Console.WriteLine("    |>>>                                                      |>>>");
                    Console.WriteLine("    |                     |>>>          |>>>                  |");
                    Console.WriteLine("    *                     |             |                     *");
                    Console.WriteLine("   / \\                    *             *                    / \\");
                    Console.WriteLine("  /___\\                 _/ \\           / \\_                 /___\\");
                    Console.WriteLine("  [   ]                |/   \\_________/   \\|                [   ]");
                    Console.WriteLine("  [ I ]                /  0  \\       /  0  \\                [ I ]");
                    Console.WriteLine("  [   ]_ _ _          /       \\     /       \\          _ _ _[   ]");
                    Console.WriteLine(spav + "  [   ] U U |        {#########}   {#########}        | U U [   ]");
                    Thread.Sleep(50);

                    Console.Clear();
                    Console.WriteLine("    |>>>                                                      |>>>");
                    Console.WriteLine("    |                     |>>>          |>>>                  |");
                    Console.WriteLine("    *                     |             |                     *");
                    Console.WriteLine("   / \\                    *             *                    / \\");
                    Console.WriteLine("  /___\\                 _/ \\           / \\_                 /___\\");
                    Console.WriteLine("  [   ]                |/   \\_________/   \\|                [   ]");
                    Console.WriteLine("  [ I ]                /  0  \\       /  0  \\                [ I ]");
                    Console.WriteLine("  [   ]_ _ _          /       \\     /       \\          _ _ _[   ]");
                    Console.WriteLine("  [   ] U U |        {#########}   {#########}        | U U [   ]");
                    i++;
                }
                else if (i == 10)
                {
                    Console.Clear();
                    Console.WriteLine("    |>>>                                                      |>>>");
                    Console.WriteLine("    |                     |>>>          |>>>                  |");
                    Console.WriteLine("    *                     |             |                     *");
                    Console.WriteLine("   / \\                    *             *                    / \\");
                    Console.WriteLine("  /___\\                 _/ \\           / \\_                 /___\\");
                    Console.WriteLine("  [   ]                |/   \\_________/   \\|                [   ]");
                    Console.WriteLine("  [ I ]                /  0  \\       /  0  \\                [ I ]");
                    Console.WriteLine("  [   ]_ _ _          /       \\     /       \\          _ _ _[   ]");
                    Console.WriteLine("  [   ] U U |        {#########}   {#########}        | U U [   ]");
                    Console.WriteLine(spav + "  [   ]====/          \\=======/     \\=======/          \\====[   ]");
                    Thread.Sleep(50);

                    Console.Clear();
                    Console.WriteLine("    |>>>                                                      |>>>");
                    Console.WriteLine("    |                     |>>>          |>>>                  |");
                    Console.WriteLine("    *                     |             |                     *");
                    Console.WriteLine("   / \\                    *             *                    / \\");
                    Console.WriteLine("  /___\\                 _/ \\           / \\_                 /___\\");
                    Console.WriteLine("  [   ]                |/   \\_________/   \\|                [   ]");
                    Console.WriteLine("  [ I ]                /  0  \\       /  0  \\                [ I ]");
                    Console.WriteLine("  [   ]_ _ _          /       \\     /       \\          _ _ _[   ]");
                    Console.WriteLine("  [   ] U U |        {#########}   {#########}        | U U [   ]");
                    Console.WriteLine("  [   ]====/          \\=======/     \\=======/          \\====[   ]");
                    i++;
                }
                else if (i == 11)
                {
                    Console.Clear();
                    Console.WriteLine("    |>>>                                                      |>>>");
                    Console.WriteLine("    |                     |>>>          |>>>                  |");
                    Console.WriteLine("    *                     |             |                     *");
                    Console.WriteLine("   / \\                    *             *                    / \\");
                    Console.WriteLine("  /___\\                 _/ \\           / \\_                 /___\\");
                    Console.WriteLine("  [   ]                |/   \\_________/   \\|                [   ]");
                    Console.WriteLine("  [ I ]                /  0  \\       /  0  \\                [ I ]");
                    Console.WriteLine("  [   ]_ _ _          /       \\     /       \\          _ _ _[   ]");
                    Console.WriteLine("  [   ] U U |        {#########}   {#########}        | U U [   ]");
                    Console.WriteLine("  [   ]====/          \\=======/     \\=======/          \\====[   ]");
                    Console.WriteLine(spav + "  [   ]  []|           |   I |_ _ _ _| I   |           |    [   ]");
                    Thread.Sleep(50);

                    Console.Clear();
                    Console.WriteLine("    |>>>                                                      |>>>");
                    Console.WriteLine("    |                     |>>>          |>>>                  |");
                    Console.WriteLine("    *                     |             |                     *");
                    Console.WriteLine("   / \\                    *             *                    / \\");
                    Console.WriteLine("  /___\\                 _/ \\           / \\_                 /___\\");
                    Console.WriteLine("  [   ]                |/   \\_________/   \\|                [   ]");
                    Console.WriteLine("  [ I ]                /  0  \\       /  0  \\                [ I ]");
                    Console.WriteLine("  [   ]_ _ _          /       \\     /       \\          _ _ _[   ]");
                    Console.WriteLine("  [   ] U U |        {#########}   {#########}        | U U [   ]");
                    Console.WriteLine("  [   ]====/          \\=======/     \\=======/          \\====[   ]");
                    Console.WriteLine("  [   ]  []|           |   I |_ _ _ _| I   |           |    [   ]");
                    i++;
                }
                else if (i == 12)
                {
                    Console.Clear();
                    Console.WriteLine("    |>>>                                                      |>>>");
                    Console.WriteLine("    |                     |>>>          |>>>                  |");
                    Console.WriteLine("    *                     |             |                     *");
                    Console.WriteLine("   / \\                    *             *                    / \\");
                    Console.WriteLine("  /___\\                 _/ \\           / \\_                 /___\\");
                    Console.WriteLine("  [   ]                |/   \\_________/   \\|                [   ]");
                    Console.WriteLine("  [ I ]                /  0  \\       /  0  \\                [ I ]");
                    Console.WriteLine("  [   ]_ _ _          /       \\     /       \\          _ _ _[   ]");
                    Console.WriteLine("  [   ] U U |        {#########}   {#########}        | U U [   ]");
                    Console.WriteLine("  [   ]====/          \\=======/     \\=======/          \\====[   ]");
                    Console.WriteLine("  [   ]  []|           |   I |_ _ _ _| I   |           |    [   ]");
                    Console.WriteLine(spav + "  [___]    |_ _ _ _ _ _|     | U U U |     |_ _ _ _ _ _|  ==[___]");
                    Thread.Sleep(50);

                    Console.Clear();
                    Console.WriteLine("    |>>>                                                      |>>>");
                    Console.WriteLine("    |                     |>>>          |>>>                  |");
                    Console.WriteLine("    *                     |             |                     *");
                    Console.WriteLine("   / \\                    *             *                    / \\");
                    Console.WriteLine("  /___\\                 _/ \\           / \\_                 /___\\");
                    Console.WriteLine("  [   ]                |/   \\_________/   \\|                [   ]");
                    Console.WriteLine("  [ I ]                /  0  \\       /  0  \\                [ I ]");
                    Console.WriteLine("  [   ]_ _ _          /       \\     /       \\          _ _ _[   ]");
                    Console.WriteLine("  [   ] U U |        {#########}   {#########}        | U U [   ]");
                    Console.WriteLine("  [   ]====/          \\=======/     \\=======/          \\====[   ]");
                    Console.WriteLine("  [   ]  []|           |   I |_ _ _ _| I   |           |    [   ]");
                    Console.WriteLine("  [___]    |_ _ _ _ _ _|     | U U U |     |_ _ _ _ _ _|  ==[___]");
                    i++;
                }
                else if (i == 13)
                {
                    Console.Clear();
                    Console.WriteLine("    |>>>                                                      |>>>");
                    Console.WriteLine("    |                     |>>>          |>>>                  |");
                    Console.WriteLine("    *                     |             |                     *");
                    Console.WriteLine("   / \\                    *             *                    / \\");
                    Console.WriteLine("  /___\\                 _/ \\           / \\_                 /___\\");
                    Console.WriteLine("  [   ]                |/   \\_________/   \\|                [   ]");
                    Console.WriteLine("  [ I ]                /  0  \\       /  0  \\                [ I ]");
                    Console.WriteLine("  [   ]_ _ _          /       \\     /       \\          _ _ _[   ]");
                    Console.WriteLine("  [   ] U U |        {#########}   {#########}        | U U [   ]");
                    Console.WriteLine("  [   ]====/          \\=======/     \\=======/          \\====[   ]");
                    Console.WriteLine("  [   ]  []|           |   I |_ _ _ _| I   |           |    [   ]");
                    Console.WriteLine("  [___]    |_ _ _ _ _ _|     | U U U |     |_ _ _ _ _ _|  ==[___]");
                    Console.WriteLine(spav + "  \\===/  I | 0 0 0 0 0 |     |=======|     | 0 0 0 0 0 | I  \\===/");
                    Thread.Sleep(50);

                    Console.Clear();
                    Console.WriteLine("    |>>>                                                      |>>>");
                    Console.WriteLine("    |                     |>>>          |>>>                  |");
                    Console.WriteLine("    *                     |             |                     *");
                    Console.WriteLine("   / \\                    *             *                    / \\");
                    Console.WriteLine("  /___\\                 _/ \\           / \\_                 /___\\");
                    Console.WriteLine("  [   ]                |/   \\_________/   \\|                [   ]");
                    Console.WriteLine("  [ I ]                /  0  \\       /  0  \\                [ I ]");
                    Console.WriteLine("  [   ]_ _ _          /       \\     /       \\          _ _ _[   ]");
                    Console.WriteLine("  [   ] U U |        {#########}   {#########}        | U U [   ]");
                    Console.WriteLine("  [   ]====/          \\=======/     \\=======/          \\====[   ]");
                    Console.WriteLine("  [   ]  []|           |   I |_ _ _ _| I   |           |    [   ]");
                    Console.WriteLine("  [___]    |_ _ _ _ _ _|     | U U U |     |_ _ _ _ _ _|  ==[___]");
                    Console.WriteLine("  \\===/  I | 0 0 0 0 0 |     |=======|     | 0 0 0 0 0 | I  \\===/");
                    i++;
                }
                else if (i == 14)
                {
                    Console.Clear();
                    Console.WriteLine("    |>>>                                                      |>>>");
                    Console.WriteLine("    |                     |>>>          |>>>                  |");
                    Console.WriteLine("    *                     |             |                     *");
                    Console.WriteLine("   / \\                    *             *                    / \\");
                    Console.WriteLine("  /___\\                 _/ \\           / \\_                 /___\\");
                    Console.WriteLine("  [   ]                |/   \\_________/   \\|                [   ]");
                    Console.WriteLine("  [ I ]                /  0  \\       /  0  \\                [ I ]");
                    Console.WriteLine("  [   ]_ _ _          /       \\     /       \\          _ _ _[   ]");
                    Console.WriteLine("  [   ] U U |        {#########}   {#########}        | U U [   ]");
                    Console.WriteLine("  [   ]====/          \\=======/     \\=======/          \\====[   ]");
                    Console.WriteLine("  [   ]  []|           |   I |_ _ _ _| I   |           |    [   ]");
                    Console.WriteLine("  [___]    |_ _ _ _ _ _|     | U U U |     |_ _ _ _ _ _|  ==[___]");
                    Console.WriteLine("  \\===/  I | 0 0 0 0 0 |     |=======|     | 0 0 0 0 0 | I  \\===/");
                    Console.WriteLine(spav + "   \\=/     |===========| I   | + W + |   I |===========|     \\=/");
                    Thread.Sleep(50);

                    Console.Clear();
                    Console.WriteLine("    |>>>                                                      |>>>");
                    Console.WriteLine("    |                     |>>>          |>>>                  |");
                    Console.WriteLine("    *                     |             |                     *");
                    Console.WriteLine("   / \\                    *             *                    / \\");
                    Console.WriteLine("  /___\\                 _/ \\           / \\_                 /___\\");
                    Console.WriteLine("  [   ]                |/   \\_________/   \\|                [   ]");
                    Console.WriteLine("  [ I ]                /  0  \\       /  0  \\                [ I ]");
                    Console.WriteLine("  [   ]_ _ _          /       \\     /       \\          _ _ _[   ]");
                    Console.WriteLine("  [   ] U U |        {#########}   {#########}        | U U [   ]");
                    Console.WriteLine("  [   ]====/          \\=======/     \\=======/          \\====[   ]");
                    Console.WriteLine("  [   ]  []|           |   I |_ _ _ _| I   |           |    [   ]");
                    Console.WriteLine("  [___]    |_ _ _ _ _ _|     | U U U |     |_ _ _ _ _ _|  ==[___]");
                    Console.WriteLine("  \\===/  I | 0 0 0 0 0 |     |=======|     | 0 0 0 0 0 | I  \\===/");
                    Console.WriteLine("   \\=/     |===========| I   | + W + |   I |===========|     \\=/");
                    i++;
                }
                else if (i == 15)
                {
                    Console.Clear();
                    Console.WriteLine("    |>>>                                                      |>>>");
                    Console.WriteLine("    |                     |>>>          |>>>                  |");
                    Console.WriteLine("    *                     |             |                     *");
                    Console.WriteLine("   / \\                    *             *                    / \\");
                    Console.WriteLine("  /___\\                 _/ \\           / \\_                 /___\\");
                    Console.WriteLine("  [   ]                |/   \\_________/   \\|                [   ]");
                    Console.WriteLine("  [ I ]                /  0  \\       /  0  \\                [ I ]");
                    Console.WriteLine("  [   ]_ _ _          /       \\     /       \\          _ _ _[   ]");
                    Console.WriteLine("  [   ] U U |        {#########}   {#########}        | U U [   ]");
                    Console.WriteLine("  [   ]====/          \\=======/     \\=======/          \\====[   ]");
                    Console.WriteLine("  [   ]  []|           |   I |_ _ _ _| I   |           |    [   ]");
                    Console.WriteLine("  [___]    |_ _ _ _ _ _|     | U U U |     |_ _ _ _ _ _|  ==[___]");
                    Console.WriteLine("  \\===/  I | 0 0 0 0 0 |     |=======|     | 0 0 0 0 0 | I  \\===/");
                    Console.WriteLine("   \\=/     |===========| I   | + W + |   I |===========|     \\=/");
                    Console.WriteLine(spav + "    |  I   |           |   []|_______| ==  |           |   I  |");
                    Thread.Sleep(50);

                    Console.Clear();
                    Console.WriteLine("    |>>>                                                      |>>>");
                    Console.WriteLine("    |                     |>>>          |>>>                  |");
                    Console.WriteLine("    *                     |             |                     *");
                    Console.WriteLine("   / \\                    *             *                    / \\");
                    Console.WriteLine("  /___\\                 _/ \\           / \\_                 /___\\");
                    Console.WriteLine("  [   ]                |/   \\_________/   \\|                [   ]");
                    Console.WriteLine("  [ I ]                /  0  \\       /  0  \\                [ I ]");
                    Console.WriteLine("  [   ]_ _ _          /       \\     /       \\          _ _ _[   ]");
                    Console.WriteLine("  [   ] U U |        {#########}   {#########}        | U U [   ]");
                    Console.WriteLine("  [   ]====/          \\=======/     \\=======/          \\====[   ]");
                    Console.WriteLine("  [   ]  []|           |   I |_ _ _ _| I   |           |    [   ]");
                    Console.WriteLine("  [___]    |_ _ _ _ _ _|     | U U U |     |_ _ _ _ _ _|  ==[___]");
                    Console.WriteLine("  \\===/  I | 0 0 0 0 0 |     |=======|     | 0 0 0 0 0 | I  \\===/");
                    Console.WriteLine("   \\=/     |===========| I   | + W + |   I |===========|     \\=/");
                    Console.WriteLine("    |  I   |           |   []|_______| ==  |           |   I  |");
                    i++;
                }
                else if (i == 16)
                {
                    Console.Clear();
                    Console.WriteLine("    |>>>                                                      |>>>");
                    Console.WriteLine("    |                     |>>>          |>>>                  |");
                    Console.WriteLine("    *                     |             |                     *");
                    Console.WriteLine("   / \\                    *             *                    / \\");
                    Console.WriteLine("  /___\\                 _/ \\           / \\_                 /___\\");
                    Console.WriteLine("  [   ]                |/   \\_________/   \\|                [   ]");
                    Console.WriteLine("  [ I ]                /  0  \\       /  0  \\                [ I ]");
                    Console.WriteLine("  [   ]_ _ _          /       \\     /       \\          _ _ _[   ]");
                    Console.WriteLine("  [   ] U U |        {#########}   {#########}        | U U [   ]");
                    Console.WriteLine("  [   ]====/          \\=======/     \\=======/          \\====[   ]");
                    Console.WriteLine("  [   ]  []|           |   I |_ _ _ _| I   |           |    [   ]");
                    Console.WriteLine("  [___]    |_ _ _ _ _ _|     | U U U |     |_ _ _ _ _ _|  ==[___]");
                    Console.WriteLine("  \\===/  I | 0 0 0 0 0 |     |=======|     | 0 0 0 0 0 | I  \\===/");
                    Console.WriteLine("   \\=/     |===========| I   | + W + |   I |===========|     \\=/");
                    Console.WriteLine("    |  I   |           |   []|_______| ==  |           |   I  |");
                    Console.WriteLine(spav + "    |  []  |           |     |||||||||     |           |      |");
                    Thread.Sleep(50);

                    Console.Clear();
                    Console.WriteLine("    |>>>                                                      |>>>");
                    Console.WriteLine("    |                     |>>>          |>>>                  |");
                    Console.WriteLine("    *                     |             |                     *");
                    Console.WriteLine("   / \\                    *             *                    / \\");
                    Console.WriteLine("  /___\\                 _/ \\           / \\_                 /___\\");
                    Console.WriteLine("  [   ]                |/   \\_________/   \\|                [   ]");
                    Console.WriteLine("  [ I ]                /  0  \\       /  0  \\                [ I ]");
                    Console.WriteLine("  [   ]_ _ _          /       \\     /       \\          _ _ _[   ]");
                    Console.WriteLine("  [   ] U U |        {#########}   {#########}        | U U [   ]");
                    Console.WriteLine("  [   ]====/          \\=======/     \\=======/          \\====[   ]");
                    Console.WriteLine("  [   ]  []|           |   I |_ _ _ _| I   |           |    [   ]");
                    Console.WriteLine("  [___]    |_ _ _ _ _ _|     | U U U |     |_ _ _ _ _ _|  ==[___]");
                    Console.WriteLine("  \\===/  I | 0 0 0 0 0 |     |=======|     | 0 0 0 0 0 | I  \\===/");
                    Console.WriteLine("   \\=/     |===========| I   | + W + |   I |===========|     \\=/");
                    Console.WriteLine("    |  I   |           |   []|_______| ==  |           |   I  |");
                    Console.WriteLine("    |  []  |           |     |||||||||     |           |      |");
                    i++;
                }
                else if (i == 17)
                {
                    Console.Clear();
                    Console.WriteLine("    |>>>                                                      |>>>");
                    Console.WriteLine("    |                     |>>>          |>>>                  |");
                    Console.WriteLine("    *                     |             |                     *");
                    Console.WriteLine("   / \\                    *             *                    / \\");
                    Console.WriteLine("  /___\\                 _/ \\           / \\_                 /___\\");
                    Console.WriteLine("  [   ]                |/   \\_________/   \\|                [   ]");
                    Console.WriteLine("  [ I ]                /  0  \\       /  0  \\                [ I ]");
                    Console.WriteLine("  [   ]_ _ _          /       \\     /       \\          _ _ _[   ]");
                    Console.WriteLine("  [   ] U U |        {#########}   {#########}        | U U [   ]");
                    Console.WriteLine("  [   ]====/          \\=======/     \\=======/          \\====[   ]");
                    Console.WriteLine("  [   ]  []|           |   I |_ _ _ _| I   |           |    [   ]");
                    Console.WriteLine("  [___]    |_ _ _ _ _ _|     | U U U |     |_ _ _ _ _ _|  ==[___]");
                    Console.WriteLine("  \\===/  I | 0 0 0 0 0 |     |=======|     | 0 0 0 0 0 | I  \\===/");
                    Console.WriteLine("   \\=/     |===========| I   | + W + |   I |===========|     \\=/");
                    Console.WriteLine("    |  I   |           |   []|_______| ==  |           |   I  |");
                    Console.WriteLine("    |  []  |           |     |||||||||     |           |      |");
                    Console.WriteLine(spav + "    |      |           |   I ||vvvvv|| I   |           | []   |");
                    Thread.Sleep(50);

                    Console.Clear();
                    Console.WriteLine("    |>>>                                                      |>>>");
                    Console.WriteLine("    |                     |>>>          |>>>                  |");
                    Console.WriteLine("    *                     |             |                     *");
                    Console.WriteLine("   / \\                    *             *                    / \\");
                    Console.WriteLine("  /___\\                 _/ \\           / \\_                 /___\\");
                    Console.WriteLine("  [   ]                |/   \\_________/   \\|                [   ]");
                    Console.WriteLine("  [ I ]                /  0  \\       /  0  \\                [ I ]");
                    Console.WriteLine("  [   ]_ _ _          /       \\     /       \\          _ _ _[   ]");
                    Console.WriteLine("  [   ] U U |        {#########}   {#########}        | U U [   ]");
                    Console.WriteLine("  [   ]====/          \\=======/     \\=======/          \\====[   ]");
                    Console.WriteLine("  [   ]  []|           |   I |_ _ _ _| I   |           |    [   ]");
                    Console.WriteLine("  [___]    |_ _ _ _ _ _|     | U U U |     |_ _ _ _ _ _|  ==[___]");
                    Console.WriteLine("  \\===/  I | 0 0 0 0 0 |     |=======|     | 0 0 0 0 0 | I  \\===/");
                    Console.WriteLine("   \\=/     |===========| I   | + W + |   I |===========|     \\=/");
                    Console.WriteLine("    |  I   |           |   []|_______| ==  |           |   I  |");
                    Console.WriteLine("    |  []  |           |     |||||||||     |           |      |");
                    Console.WriteLine("    |      |           |   I ||vvvvv|| I   |           | []   |");
                    i++;
                }
                else if (i == 18)
                {
                    Console.Clear();
                    Console.WriteLine("    |>>>                                                      |>>>");
                    Console.WriteLine("    |                     |>>>          |>>>                  |");
                    Console.WriteLine("    *                     |             |                     *");
                    Console.WriteLine("   / \\                    *             *                    / \\");
                    Console.WriteLine("  /___\\                 _/ \\           / \\_                 /___\\");
                    Console.WriteLine("  [   ]                |/   \\_________/   \\|                [   ]");
                    Console.WriteLine("  [ I ]                /  0  \\       /  0  \\                [ I ]");
                    Console.WriteLine("  [   ]_ _ _          /       \\     /       \\          _ _ _[   ]");
                    Console.WriteLine("  [   ] U U |        {#########}   {#########}        | U U [   ]");
                    Console.WriteLine("  [   ]====/          \\=======/     \\=======/          \\====[   ]");
                    Console.WriteLine("  [   ]  []|           |   I |_ _ _ _| I   |           |    [   ]");
                    Console.WriteLine("  [___]    |_ _ _ _ _ _|     | U U U |     |_ _ _ _ _ _|  ==[___]");
                    Console.WriteLine("  \\===/  I | 0 0 0 0 0 |     |=======|     | 0 0 0 0 0 | I  \\===/");
                    Console.WriteLine("   \\=/     |===========| I   | + W + |   I |===========|     \\=/");
                    Console.WriteLine("    |  I   |           |   []|_______| ==  |           |   I  |");
                    Console.WriteLine("    |  []  |           |     |||||||||     |           |      |");
                    Console.WriteLine("    |      |           |   I ||vvvvv|| I   |           | []   |");
                    Console.WriteLine(spav + "_-_-|_==___|-----------|_____||     ||_____|-----------|______|-_-_");
                    Thread.Sleep(50);

                    Console.Clear();
                    Console.WriteLine("    |>>>                                                      |>>>");
                    Console.WriteLine("    |                     |>>>          |>>>                  |");
                    Console.WriteLine("    *                     |             |                     *");
                    Console.WriteLine("   / \\                    *             *                    / \\");
                    Console.WriteLine("  /___\\                 _/ \\           / \\_                 /___\\");
                    Console.WriteLine("  [   ]                |/   \\_________/   \\|                [   ]");
                    Console.WriteLine("  [ I ]                /  0  \\       /  0  \\                [ I ]");
                    Console.WriteLine("  [   ]_ _ _          /       \\     /       \\          _ _ _[   ]");
                    Console.WriteLine("  [   ] U U |        {#########}   {#########}        | U U [   ]");
                    Console.WriteLine("  [   ]====/          \\=======/     \\=======/          \\====[   ]");
                    Console.WriteLine("  [   ]  []|           |   I |_ _ _ _| I   |           |    [   ]");
                    Console.WriteLine("  [___]    |_ _ _ _ _ _|     | U U U |     |_ _ _ _ _ _|  ==[___]");
                    Console.WriteLine("  \\===/  I | 0 0 0 0 0 |     |=======|     | 0 0 0 0 0 | I  \\===/");
                    Console.WriteLine("   \\=/     |===========| I   | + W + |   I |===========|     \\=/");
                    Console.WriteLine("    |  I   |           |   []|_______| ==  |           |   I  |");
                    Console.WriteLine("    |  []  |           |     |||||||||     |           |      |");
                    Console.WriteLine("    |      |           |   I ||vvvvv|| I   |           | []   |");
                    Console.WriteLine("_-_-|_==___|-----------|_____||     ||_____|-----------|______|-_-_");
                    i++;
                }
                else if (i == 19)
                {
                    Console.Clear();
                    Console.WriteLine("    |>>>                                                      |>>>");
                    Console.WriteLine("    |                     |>>>          |>>>                  |");
                    Console.WriteLine("    *                     |             |                     *");
                    Console.WriteLine("   / \\                    *             *                    / \\");
                    Console.WriteLine("  /___\\                 _/ \\           / \\_                 /___\\");
                    Console.WriteLine("  [   ]                |/   \\_________/   \\|                [   ]");
                    Console.WriteLine("  [ I ]                /  0  \\       /  0  \\                [ I ]");
                    Console.WriteLine("  [   ]_ _ _          /       \\     /       \\          _ _ _[   ]");
                    Console.WriteLine("  [   ] U U |        {#########}   {#########}        | U U [   ]");
                    Console.WriteLine("  [   ]====/          \\=======/     \\=======/          \\====[   ]");
                    Console.WriteLine("  [   ]  []|           |   I |_ _ _ _| I   |           |    [   ]");
                    Console.WriteLine("  [___]    |_ _ _ _ _ _|     | U U U |     |_ _ _ _ _ _|  ==[___]");
                    Console.WriteLine("  \\===/  I | 0 0 0 0 0 |     |=======|     | 0 0 0 0 0 | I  \\===/");
                    Console.WriteLine("   \\=/     |===========| I   | + W + |   I |===========|     \\=/");
                    Console.WriteLine("    |  I   |           |   []|_______| ==  |           |   I  |");
                    Console.WriteLine("    |  []  |           |     |||||||||     |           |      |");
                    Console.WriteLine("    |      |           |   I ||vvvvv|| I   |           | []   |");
                    Console.WriteLine("_-_-|_==___|-----------|_____||     ||_____|-----------|______|-_-_");
                    Thread.Sleep(50);

                    Console.Clear();
                    Console.WriteLine("    |>>>                                                      |>>>");
                    Console.WriteLine("    |                     |>>>          |>>>                  |");
                    Console.WriteLine("    *                     |             |                     *");
                    Console.WriteLine("   / \\                    *             *                    / \\");
                    Console.WriteLine("  /___\\                 _/ \\           / \\_                 /___\\");
                    Console.WriteLine("  [   ]                |/   \\_________/   \\|                [   ]");
                    Console.WriteLine("  [ I ]                /  0  \\       /  0  \\                [ I ]");
                    Console.WriteLine("  [   ]_ _ _          /       \\     /       \\          _ _ _[   ]");
                    Console.WriteLine("  [   ] U U |        {#########}   {#########}        | U U [   ]");
                    Console.WriteLine("  [   ]====/          \\=======/     \\=======/          \\====[   ]");
                    Console.WriteLine("  [   ]  []|           |   I |_ _ _ _| I   |           |    [   ]");
                    Console.WriteLine("  [___]    |_ _ _ _ _ _|     | U U U |     |_ _ _ _ _ _|  ==[___]");
                    Console.WriteLine("  \\===/  I | 0 0 0 0 0 |     |=======|     | 0 0 0 0 0 | I  \\===/");
                    Console.WriteLine("   \\=/     |===========| I   | + W + |   I |===========|     \\=/");
                    Console.WriteLine("    |  I   |           |   []|_______| ==  |           |   I  |");
                    Console.WriteLine("    |  []  |           |     |||||||||     |           |      |");
                    Console.WriteLine("    |      |           |   I ||vvvvv|| I   |           | []   |");
                    Console.WriteLine("_-_-|_==___|-----------|_____||     ||_____|-----------|______|-_-_");
                    Console.WriteLine("");
                    i++;
                }
                else if (i == 20)
                {
                    Console.Clear();
                    Console.WriteLine("    |>>>                                                      |>>>");
                    Console.WriteLine("    |                     |>>>          |>>>                  |");
                    Console.WriteLine("    *                     |             |                     *");
                    Console.WriteLine("   / \\                    *             *                    / \\");
                    Console.WriteLine("  /___\\                 _/ \\           / \\_                 /___\\");
                    Console.WriteLine("  [   ]                |/   \\_________/   \\|                [   ]");
                    Console.WriteLine("  [ I ]                /  0  \\       /  0  \\                [ I ]");
                    Console.WriteLine("  [   ]_ _ _          /       \\     /       \\          _ _ _[   ]");
                    Console.WriteLine("  [   ] U U |        {#########}   {#########}        | U U [   ]");
                    Console.WriteLine("  [   ]====/          \\=======/     \\=======/          \\====[   ]");
                    Console.WriteLine("  [   ]  []|           |   I |_ _ _ _| I   |           |    [   ]");
                    Console.WriteLine("  [___]    |_ _ _ _ _ _|     | U U U |     |_ _ _ _ _ _|  ==[___]");
                    Console.WriteLine("  \\===/  I | 0 0 0 0 0 |     |=======|     | 0 0 0 0 0 | I  \\===/");
                    Console.WriteLine("   \\=/     |===========| I   | + W + |   I |===========|     \\=/");
                    Console.WriteLine("    |  I   |           |   []|_______| ==  |           |   I  |");
                    Console.WriteLine("    |  []  |           |     |||||||||     |           |      |");
                    Console.WriteLine("    |      |           |   I ||vvvvv|| I   |           | []   |");
                    Console.WriteLine("_-_-|_==___|-----------|_____||     ||_____|-----------|______|-_-_");
                    Thread.Sleep(50);

                    Console.Clear();
                    Console.WriteLine("    |>>>                                                      |>>>");
                    Console.WriteLine("    |                     |>>>          |>>>                  |");
                    Console.WriteLine("    *                     |             |                     *");
                    Console.WriteLine("   / \\                    *             *                    / \\");
                    Console.WriteLine("  /___\\                 _/ \\           / \\_                 /___\\");
                    Console.WriteLine("  [   ]                |/   \\_________/   \\|                [   ]");
                    Console.WriteLine("  [ I ]                /  0  \\       /  0  \\                [ I ]");
                    Console.WriteLine("  [   ]_ _ _          /       \\     /       \\          _ _ _[   ]");
                    Console.WriteLine("  [   ] U U |        {#########}   {#########}        | U U [   ]");
                    Console.WriteLine("  [   ]====/          \\=======/     \\=======/          \\====[   ]");
                    Console.WriteLine("  [   ]  []|           |   I |_ _ _ _| I   |           |    [   ]");
                    Console.WriteLine("  [___]    |_ _ _ _ _ _|     | U U U |     |_ _ _ _ _ _|  ==[___]");
                    Console.WriteLine("  \\===/  I | 0 0 0 0 0 |     |=======|     | 0 0 0 0 0 | I  \\===/");
                    Console.WriteLine("   \\=/     |===========| I   | + W + |   I |===========|     \\=/");
                    Console.WriteLine("    |  I   |           |   []|_______| ==  |           |   I  |");
                    Console.WriteLine("    |  []  |           |     |||||||||     |           |      |");
                    Console.WriteLine("    |      |           |   I ||vvvvv|| I   |           | []   |");
                    Console.WriteLine("_-_-|_==___|-----------|_____||     ||_____|-----------|______|-_-_");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Thread.Sleep(1150);

                    Console.Clear();
                    Console.WriteLine("    |>>>                                                      |>>>");
                    Console.WriteLine("    |                     |>>>          |>>>                  |");
                    Console.WriteLine("    *                     |             |                     *");
                    Console.WriteLine("   / \\                    *             *                    / \\");
                    Console.WriteLine("  /___\\                 _/ \\           / \\_                 /___\\");
                    Console.WriteLine("  [   ]                |/   \\_________/   \\|                [   ]");
                    Console.WriteLine("  [ I ]                /  0  \\       /  0  \\                [ I ]");
                    Console.WriteLine("  [   ]_ _ _          /       \\     /       \\          _ _ _[   ]");
                    Console.WriteLine("  [   ] U U |        {#########}   {#########}        | U U [   ]");
                    Console.WriteLine("  [   ]====/          \\=======/     \\=======/          \\====[   ]");
                    Console.WriteLine("  [   ]  []|           |   I |_ _ _ _| I   |           |    [   ]");
                    Console.WriteLine("  [___]    |_ _ _ _ _ _|     | U U U |     |_ _ _ _ _ _|  ==[___]");
                    Console.WriteLine("  \\===/  I | 0 0 0 0 0 |     |=======|     | 0 0 0 0 0 | I  \\===/");
                    Console.WriteLine("   \\=/     |===========| I   | + W + |   I |===========|     \\=/");
                    Console.WriteLine("    |  I   |           |   []|_______| ==  |           |   I  |");
                    Console.WriteLine("    |  []  |           |     |||||||||     |           |      |");
                    Console.WriteLine("    |      |           |   I ||vvvvv|| I   |           | []   |");
                    Console.WriteLine("_-_-|_==___|-----------|_____||     ||_____|-----------|______|-_-_");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine(spav + "Press any key to start");
                    Thread.Sleep(50);

                    Console.Clear();
                    Console.WriteLine("    |>>>                                                      |>>>");
                    Console.WriteLine("    |                     |>>>          |>>>                  |");
                    Console.WriteLine("    *                     |             |                     *");
                    Console.WriteLine("   / \\                    *             *                    / \\");
                    Console.WriteLine("  /___\\                 _/ \\           / \\_                 /___\\");
                    Console.WriteLine("  [   ]                |/   \\_________/   \\|                [   ]");
                    Console.WriteLine("  [ I ]                /  0  \\       /  0  \\                [ I ]");
                    Console.WriteLine("  [   ]_ _ _          /       \\     /       \\          _ _ _[   ]");
                    Console.WriteLine("  [   ] U U |        {#########}   {#########}        | U U [   ]");
                    Console.WriteLine("  [   ]====/          \\=======/     \\=======/          \\====[   ]");
                    Console.WriteLine("  [   ]  []|           |   I |_ _ _ _| I   |           |    [   ]");
                    Console.WriteLine("  [___]    |_ _ _ _ _ _|     | U U U |     |_ _ _ _ _ _|  ==[___]");
                    Console.WriteLine("  \\===/  I | 0 0 0 0 0 |     |=======|     | 0 0 0 0 0 | I  \\===/");
                    Console.WriteLine("   \\=/     |===========| I   | + W + |   I |===========|     \\=/");
                    Console.WriteLine("    |  I   |           |   []|_______| ==  |           |   I  |");
                    Console.WriteLine("    |  []  |           |     |||||||||     |           |      |");
                    Console.WriteLine("    |      |           |   I ||vvvvv|| I   |           | []   |");
                    Console.WriteLine("_-_-|_==___|-----------|_____||     ||_____|-----------|______|-_-_");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("Press any key to start");
                    Thread.Sleep(1150);

                    if (Console.ReadKey().Key == ConsoleKey.Enter)
                    {
                        break;
                    }
                }
                Thread.Sleep(1150);
            }
        }


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
        // Completes and manages all steps of character creation
        static Tuple<string, int, int, int> CharacterFinalization(string name, int age, int height, int bulk, ref float cStr, ref float cDex, ref float cWis, ref float cCharisma)
        {
            float cStrMod, cDexMod, cWisMod, cChaMod;
            float testS = 0, testD = 0, testW = 0, testC = 0;


            while (true)
            {
                CharNameCreater(ref name);
                CharAgeCreater(ref age);
                // Str weak <40 >16 weaker <65 weakist <80
                CharHeightCreater(ref height);
                CharBulkCreater(ref bulk);

                Console.Clear();
                Console.WriteLine("Name: " + name);
                Console.WriteLine("Age: " + age);

                if (height == 1) { Console.WriteLine("Height: Short"); }
                else if (height == 2) { Console.WriteLine("Height: Mediocre"); }
                else if (height == 3) { Console.WriteLine("Height: Tall"); }

                if (bulk == 1) { Console.WriteLine("Bulk: Weak"); ; }
                else if (bulk == 2) { Console.WriteLine("Bulk: Average"); }
                else if (bulk == 3) { Console.WriteLine("Bulk: Strong"); }
                else if (bulk == 9000) { Console.WriteLine("Bulk: Unmeasureable"); }

                Console.WriteLine("\nIs this you character?\ny or n");
                string i = Convert.ToString(Console.ReadLine());

                if (i != "y" && i != "n") { Console.WriteLine("\n\n\nINVALID ANSWER\n"); }
                else if (i == "y")
                {
                    CharacterStatCreater(ref cStr,ref cDex,ref cWis,ref cCharisma);
                }

            }

            return Tuple.Create("", 0, 0, 0);
        }
        static Tuple<> CharacterStatCreater(ref float cStr, ref float cDex, ref float cWis, ref float cCharisma)
        {
            return;
        }

    }
}





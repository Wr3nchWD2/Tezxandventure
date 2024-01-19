using System;

namespace TEZXANDVENTURE
{
    public class Fightscreen
    {
        public static void UI()
        {
            int vigur = PlayerStats.vigur;
            int endurance = PlayerStats.endurance;
            int focusPoints = PlayerStats.focusPoints;
            int enduranceRegen = PlayerStats.enduranceRegen;
            int focusPointsRegen = PlayerStats.focusPointsRegen;
            string name = PlayerStats.name;
            int evigur = EnemyDatabase.evigur;
            int eendurance = EnemyDatabase.eendurance;
            int efocusPoints = EnemyDatabase.efocusPoints;
            int eenduranceRegen = EnemyDatabase.eenduranceRegen;
            int efocusPointsRegen = EnemyDatabase.efocusPointsRegen;
            string ename = EnemyDatabase.ename;
            Console.WriteLine(ename + " Health: " + evigur);
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
        }
    }
}
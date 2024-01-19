using System;

namespace TEZXANDVENTURE
{
    public class EnemyDatabase
    {        
        public static int evigur = 0, eendurance = 0, efocusPoints = 0, eenduranceRegen = 18, efocusPointsRegen = 0;
        public static string ename = "";
        public static void EMain()
        {
            
            int enemyType = 0;
            if(enemyType == 001)
            {
                EnemyDrauger(ename, evigur, eendurance, efocusPoints, eenduranceRegen, efocusPointsRegen);
            }
        }
        public static void EnemyDrauger (string Name, int vigur, int endurance, int focusPoints, int enduranceRegen, int focusPointsRegen)
        {
            vigur = 263; endurance = 80; focusPoints = 0; enduranceRegen = 18; focusPointsRegen = 0;
            Name = "Drauger";
            EnemyInventory enemyInventory = new EnemyInventory();
            AddInventoryWeapon mace = new AddInventoryWeapon { Name = "Mace", TwoHanded = true, BleedDamage = 0, enduranceCost = 26, Damage = 39, Quantity = 1};
            enemyInventory.AddWeapon(mace);
        }
    }
}
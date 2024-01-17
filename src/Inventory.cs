using System;

namespace TEZXANDVENTURE
{
    public class AddInventoryItem
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
    }

    public class AddInventoryWeapon
    {
        public string Name { get; set; }
        public bool TwoHanded { get; set; }
        public int BleedDamage { get; set; }
        public int Damage { get; set; }
        public int Quantity { get; set; }
    }

    public class AddInventorySpell
    {
        public string Name { get; set; }
        public int Damage { get; set; }
        public int FPCost { get; set; }
        public int Quantity { get; set; }
    }

    public class AddInventoryAmmo
    {
        public string Name { get; set; }
        public int Damage { get; set; }
        public int Quantity { get; set; }
    }

    public class Inventory
    {
        private List<AddInventoryItem> items;
        private List<AddInventoryWeapon> weapons;
        private List<AddInventorySpell> spells;
        private List<AddInventoryAmmo> ammos;


        public Inventory()
        {
            items = new List<AddInventoryItem>();
            weapons = new List<AddInventoryWeapon>();
            spells = new List<AddInventorySpell>();
            ammos = new List<AddInventoryAmmo>();
        }

        public void AddItem(AddInventoryItem item)
        {
            items.Add(item);
        }
        public void AddWeapon(AddInventoryWeapon weapon)
        {
            weapons.Add(weapon);
        }
        public void AddSpell(AddInventorySpell spell)
        {
            spells.Add(spell);
        }
        public void AddAmmo(AddInventoryAmmo ammo)
        {
            ammos.Add(ammo);
        }

        public void RemoveItem(AddInventoryItem item)
        {
            items.Remove(item);
        }
        public void RemoveWeapon(AddInventoryWeapon weapon)
        {
            weapons.Remove(weapon);
        }
        public void RemoveSpell(AddInventorySpell spell)
        {
            spells.Remove(spell);
        }
        public void RemoveAmmo(AddInventoryAmmo ammo)
        {
            ammos.Remove(ammo);
        }

        public void DisplayInventory()
        {
            foreach (var item in items)
            {
                Console.WriteLine($"{item.Name} - {item.Quantity}");
            }
            foreach (var weapon in weapons)
            {
                Console.WriteLine($"{weapon.Name} - {weapon.Quantity}");
            }
            foreach (var spell in spells)
            {
                Console.WriteLine($"{spell.Name} - {spell.Quantity}");
            }
            foreach (var ammo in ammos)
            {
                Console.WriteLine($"{ammo.Name} - {ammo.Quantity}");
            }
            Console.ReadLine();
        }
    }
}
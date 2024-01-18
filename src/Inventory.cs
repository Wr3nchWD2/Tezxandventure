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
    public class AddCharPerk
    {
        public string Name { get; set; }
    }
    public class Inventory
    {
        private List<AddInventoryItem> items;
        private List<AddInventoryWeapon> weapons;
        private List<AddInventorySpell> spells;
        private List<AddInventoryAmmo> ammos;
        private List<AddCharPerk> perks;


        public Inventory()
        {
            items = new List<AddInventoryItem>();
            weapons = new List<AddInventoryWeapon>();
            spells = new List<AddInventorySpell>();
            ammos = new List<AddInventoryAmmo>();
            perks = new List<AddCharPerk>();
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
        public void AddPerk(AddCharPerk perk)
        {
            perks.Add(perk);
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
        public void RemovePerk(AddCharPerk perk)
        {
            perks.Remove(perk);
        }
        public void DisplayInventory()
        {
            Console.WriteLine("                         Inverntory");
            Console.WriteLine("                                                                             ");
            Console.WriteLine("1. All");
            Console.WriteLine("2. Items");
            Console.WriteLine("3. Weapons");
            Console.WriteLine("4. Spells");
            Console.WriteLine("5. Ammo");
            Console.WriteLine("6. Perks");
            int ii;
            string i = Console.ReadLine();
            if (int.TryParse(i, out ii))
            {
                if (ii == 1)
                {
                    foreach (var item in items)
                    {
                        Console.WriteLine($"{item.Quantity} - {item.Name}");
                    }
                    foreach (var weapon in weapons)
                    {
                        Console.WriteLine($"{weapon.Quantity} - {weapon.Name}");
                    }
                    foreach (var spell in spells)
                    {
                        Console.WriteLine($"{spell.Name} - {spell.Quantity}");
                    }
                    foreach (var ammo in ammos)
                    {
                        Console.WriteLine($"{ammo.Name} - {ammo.Quantity}");
                    }
                    foreach (var perk in perks)
                    {
                        Console.WriteLine($"{perk.Name}");
                    }
                }
                else if (ii == 2)
                {
                    foreach (var item in items)
                    {
                        Console.WriteLine($"{item.Quantity} - {item.Name}");
                    }
                }
                else if (ii == 3)
                {
                    foreach (var weapon in weapons)
                    {
                        Console.WriteLine($"{weapon.Quantity} - {weapon.Name}");
                    }
                }
                else if (ii == 4)
                {
                    foreach (var spell in spells)
                    {
                        Console.WriteLine($"{spell.Name} - {spell.Quantity}");
                    }
                }
                else if (ii == 5)
                {
                    foreach (var ammo in ammos)
                    {
                        Console.WriteLine($"{ammo.Name} - {ammo.Quantity}");
                    }
                }
                else if (ii == 6)
                {
                    foreach (var perk in perks)
                    {
                        Console.WriteLine($"{perk.Name}");
                    }
                }
            }


            Console.ReadLine();
        }
    }
}
using System;

namespace TEZXANDVENTURE
{
    public class InventoryItem
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
    }

    public class Inventory
    {
        private List<InventoryItem> items;

        public Inventory()
        {
            items = new List<InventoryItem>();
        }

        public void AddItem(InventoryItem item)
        {
            // Add logic to handle adding items, checking duplicates, etc.
            items.Add(item);
        }

        public void RemoveItem(InventoryItem item)
        {
            // Add logic to handle removing items.
            items.Remove(item);
        }

        public void DisplayInventory()
        {
            // Display logic, e.g., console output or UI update.
            foreach (var item in items)
            {
                Console.WriteLine($"{item.Name} - {item.Quantity}");
            }
        }
    }
}
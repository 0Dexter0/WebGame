using System.Collections.Generic;

namespace WebGame.Components.Inventory
{
    public class InventoryModel
    {
        public List<IInventoryItem> Items { get; set; }
        public int MaxSlots { get; set; }

        public InventoryModel()
        {
            MaxSlots = 25;
            Items = new(MaxSlots);
        }
    }
}
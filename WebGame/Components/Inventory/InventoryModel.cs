using System.Collections.Generic;
using WebGame.Components.Entities.Item;

namespace WebGame.Components.Inventory
{
    public class InventoryModel
    {
        public List<Item> Items { get; set; }
        public int MaxSlots { get; set; }
    }
}
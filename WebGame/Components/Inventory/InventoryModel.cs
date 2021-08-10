using System.Collections.Generic;
using WebGame.Components.Equipments;
using WebGame.Components.Resources;

namespace WebGame.Components.Inventory
{
    public class InventoryModel
    {
        public List<IEquipment> Equipments { get; set; }
        public List<Loot> Loots { get; set; }
        public List<Food> Foods { get; set; }
        public int MaxSlots { get; set; }

        public InventoryModel()
        {
            MaxSlots = 25;
            Equipments = new();
            Loots = new();
            Foods = new();
        }
    }
}
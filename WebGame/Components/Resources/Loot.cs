using System;
using WebGame.Components.Inventory;

namespace WebGame.Components.Resources
{
    public class Loot : IResource, IInventoryItem
    {
        public Guid Id { get; init; }
        public string Name { get; set; }
        public int Count { get; set; }
        public double DropChance { get; set; }
    }
}
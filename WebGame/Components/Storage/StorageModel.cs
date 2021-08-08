using System.Collections.Generic;
using WebGame.Components.Entities.Item;

namespace WebGame.Components.Storage
{
    public class StorageModel
    {
        public List<Item> Items { get; set; }
        public int MaxSlots { get; set; }
    }
}
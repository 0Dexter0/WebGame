using System.Collections.Generic;
using WebGame.Components.Resources;

namespace WebGame.Components.Storage
{
    public class StorageModel
    {
        public List<IResource> Items { get; set; }
        public int MaxSlots { get; set; }

        public StorageModel()
        {
            MaxSlots = 20;
            Items = new(MaxSlots);
        }
    }
}
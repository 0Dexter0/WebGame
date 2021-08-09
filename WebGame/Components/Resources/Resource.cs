using System;

namespace WebGame.Components.Resources
{
    public class Resource : IResource
    {
        public Guid Id { get; init; }
        public string Name { get; set; }
        public int Count { get; set; }
        public double DropChance { get; set; }
    }
}
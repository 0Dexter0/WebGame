using System;
using WebGame.Components.Enums;
using WebGame.Components.Inventory;

namespace WebGame.Components.Equipments.Models
{
    public class Weapon : IEquipment, IInventoryItem
    {
        public Guid Id { get; init; }
        public int Damage { get; set; }
        public int Defence { get; set; }
        public double CriticalHitChance { get; set; }
        public Quality Quality { get; set; }
        public WeaponType Type { get; set; }
        public int Sharpening { get; set; }
        public int Rank { get; set; }
        public double DodgeChance { get; set; }
        public string Name { get; set; }
    }
}
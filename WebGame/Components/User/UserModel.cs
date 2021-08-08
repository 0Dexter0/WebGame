using System;
using System.Collections.Generic;
using WebGame.Components.Barrack;
using WebGame.Components.Enums;
using WebGame.Components.Equipments;
using WebGame.Components.Guild;
using WebGame.Components.Inventory;
using WebGame.Components.Resources;
using WebGame.Components.Storage;

namespace WebGame.Components.User
{
    public class UserModel
    {
        public Guid Id { get; init; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Role Role { get; set; }
        public GuildModel Guild { get; set; }
        public InventoryModel Inventory { get; set; }
        public StorageModel Storage { get; set; }
        public List<IEquipment> Equipments { get; set; }
        public BarrackModel Barrack { get; set; }
        public Money Money { get; set; }
        public int Level { get; set; }
        public int Xp { get; set; }
        public DateTime RegisterDate { get; init; }
        public DateTime LastActive { get; set; }
        public string AvatarUrl { get; set; }
        public int Energy { get; set; }
        public double XpMultiplier { get; set; }
    }
}
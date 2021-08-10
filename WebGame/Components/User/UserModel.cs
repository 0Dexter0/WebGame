using System;
using System.Collections.Generic;
using System.Linq;
using WebGame.Components.Barrack;
using WebGame.Components.Enums;
using WebGame.Components.Equipments;
using WebGame.Components.Equipments.Models;
using WebGame.Components.Guild;
using WebGame.Components.Inventory;
using WebGame.Components.Resources;
using WebGame.Components.Storage;

namespace WebGame.Components.User
{
    public class UserModel
    {
        private int _energy;
        public Guid Id { get; init; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Role Role { get; set; }
        public GuildModel Guild { get; set; }
        public InventoryModel Inventory { get; set; }
        public StorageModel Storage { get; set; }
        public List<IEquipment> Equipments { get; init; }
        public BarrackModel Barrack { get; set; }
        public Money Money { get; set; }
        public int Level { get; set; }
        public int Xp { get; set; }
        public DateTime RegisterDate { get; init; }
        public DateTime LastActive { get; set; }
        public string AvatarUrl { get; set; }
        public int Energy
        {
            get => _energy + BonusStat.Energy; 
            set => _energy = value; 
        }
        public double XpMultiplier { get; set; }
        public int Hp { get; set; }
        public int Damage { get; set; }
        public int Defence { get; set; }
        public BonusStat BonusStat { get; set; }

        public UserModel()
        {
            Id = Guid.NewGuid();
            Role = Role.User;
            Inventory = new();
            Storage = new();
            Barrack = new();
            Money = new();
            Level = 1;
            Xp = 0;
            RegisterDate = DateTime.Now;
            LastActive = DateTime.Now;
            Energy = 100;
            XpMultiplier = 1.0;
            Hp = 50;
            Damage = 10;
            Defence = 0;
            BonusStat = new();
            Equipments = new()
            {
                new Weapon(), new Armor() {Type = ArmorType.Armor},
                new Armor() {Type = ArmorType.Boots}, new Armor() {Type = ArmorType.Helmet},
                new Armor() {Type = ArmorType.Leggings}, new Bijouterie() {Type = BijouterieType.Belt},
                new Bijouterie() {Type = BijouterieType.Earring}, new Bijouterie() {Type = BijouterieType.Earring},
                new Bijouterie() {Type = BijouterieType.Ring}, new Bijouterie() {Type = BijouterieType.Ring}
            };
        }

        public UserModel(string name, string email, string password)
        : this()
        {
            Name = name;
            Email = email;
            Password = password;
        }

        private void SetStats()
        {
            int sumDamage = 0; 
            int sumDefence = 0;

            foreach (IEquipment equipment in Equipments)
            {
                sumDamage += equipment.Damage;
                sumDefence += equipment.Defence;
            }

            Damage = 10 + sumDamage + BonusStat.Damage;
            Defence = sumDefence + BonusStat.Defence;

            Hp = (50 + BonusStat.Hp) * Level + Defence * 2;
        }

        public void ToInventory(IEquipment equipment)
        {
            Inventory.Equipments.Add(equipment);
            var e = Equipments.First(eq => eq.Equals(equipment));

            if (e is Armor a) e = new Armor() {Type = a.Type};
            else if (e is Weapon) e = new Weapon();
            else if (e is Bijouterie b) e = new Bijouterie() {Type = b.Type};
            
            SetStats();
        }

        public void ToEquipment(IEquipment equipment)
        {
            if (equipment is Weapon weapon)
            {
                for (int i = 0; i < Equipments.Count; i++)
                {
                    if (Equipments[i] is Weapon)
                    {
                        Equipments[i] = weapon;
                        break;
                    }
                }

                Inventory.Equipments.Remove(equipment);
            }
            else if (equipment is Armor armor)
            {
                for (int i = 0; i < Equipments.Count; i++)
                {
                    if (Equipments[i] is Armor a && a.Type == armor.Type)
                    {
                        Equipments[i] = armor;
                        break;
                    }
                }
                
                Inventory.Equipments.Remove(equipment);
            }
            else if (equipment is Bijouterie bijouterie)
            {
                for (int i = 0; i < Equipments.Count; i++)
                {
                    if (Equipments[i] is Bijouterie b && b.Type == bijouterie.Type
                    && b.Name == string.Empty)
                    {
                        Equipments[i] = bijouterie;
                        break;
                    }
                }
                
                Inventory.Equipments.Remove(equipment);
            }
            
            SetStats();
        }

        public void SwapEquip(IEquipment toInventory, IEquipment toEquipment)
        {
            ToInventory(toInventory);
            ToEquipment(toEquipment);
        }
    }
}
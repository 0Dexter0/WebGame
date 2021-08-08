using System;
using System.Collections.Generic;
using WebGame.Components.User;

namespace WebGame.Components.Guild
{
    public class GuildModel
    {
        public Guid Id { get; init; }
        public UserModel Founder { get; init; }
        public List<UserModel> Members { get; set; }
        public int Level { get; set; }
        public int Xp { get; set; }
    }
}
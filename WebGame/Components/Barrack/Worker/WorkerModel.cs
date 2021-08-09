using System;
using WebGame.Components.Enums;

namespace WebGame.Components.Barrack.Worker
{
    public class WorkerModel
    {
        public Guid Id { get; init; }
        public WorkerRank Rank { get; init; }
        public int Skill { get; set; }
        public int Luck { get; set; }
    }
}
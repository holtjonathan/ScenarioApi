using System;
using System.Collections.Generic;

namespace ScenarioApi.Models
{
    public partial class Missions
    {
        public int MissionId { get; set; }
        public int ScenarioId { get; set; }
        public int TypeId { get; set; }
        public string Description { get; set; }
        public int RewardId { get; set; }
        public int? TribeUpgradeId { get; set; }

        public virtual Rewards Reward { get; set; }
        public virtual Scenarios Scenario { get; set; }
        public virtual TribeUpgrades TribeUpgrade { get; set; }
        public virtual MissionTypes Type { get; set; }
    }
}

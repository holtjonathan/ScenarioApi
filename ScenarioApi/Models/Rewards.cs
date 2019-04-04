using System;
using System.Collections.Generic;

namespace ScenarioApi.Models
{
    public partial class Rewards
    {
        public Rewards()
        {
            Missions = new HashSet<Missions>();
        }

        public int RewardId { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Missions> Missions { get; set; }
    }
}

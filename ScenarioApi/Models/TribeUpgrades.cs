using System;
using System.Collections.Generic;

namespace ScenarioApi.Models
{
    public partial class TribeUpgrades
    {
        public TribeUpgrades()
        {
            Missions = new HashSet<Missions>();
        }

        public int TribeUpgradeId { get; set; }
        public int UpgradeId { get; set; }

        public virtual Upgrades Upgrade { get; set; }
        public virtual ICollection<Missions> Missions { get; set; }
    }
}

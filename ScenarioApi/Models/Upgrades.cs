using System;
using System.Collections.Generic;

namespace ScenarioApi.Models
{
    public partial class Upgrades
    {
        public Upgrades()
        {
            TribeUpgrades = new HashSet<TribeUpgrades>();
        }

        public int UpgradeId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<TribeUpgrades> TribeUpgrades { get; set; }
    }
}

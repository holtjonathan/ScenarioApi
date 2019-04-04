using System;
using System.Collections.Generic;

namespace ScenarioApi.Models
{
    public partial class MissionTypes
    {
        public MissionTypes()
        {
            Missions = new HashSet<Missions>();
        }

        public int MissionTypeId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Missions> Missions { get; set; }
    }
}

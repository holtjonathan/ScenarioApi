using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ScenarioApi.Models
{
    public partial class Scenarios
    {
        public Scenarios()
        {
            Missions = new HashSet<Missions>();
            SpecialRules = new HashSet<SpecialRules>();
            SpecialSetups = new HashSet<SpecialSetups>();
        }

        public int ScenarioId { get; set; }
        public string Slug { get; set; }
        public int LocationId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int PrereqId { get; set; }

        [MaxLength(25)]
        public string TestName { get; set; }

        public virtual Locations Location { get; set; }
        public virtual ICollection<Missions> Missions { get; set; }
        public virtual ICollection<SpecialRules> SpecialRules { get; set; }
        public virtual ICollection<SpecialSetups> SpecialSetups { get; set; }
    }
}

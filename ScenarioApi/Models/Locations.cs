using System;
using System.Collections.Generic;

namespace ScenarioApi.Models
{
    public partial class Locations
    {
        public Locations()
        {
            Scenarios = new HashSet<Scenarios>();
        }

        public int LocationId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Scenarios> Scenarios { get; set; }
    }
}

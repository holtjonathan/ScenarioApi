using System;
using System.Collections.Generic;

namespace ScenarioApi.Models
{
    public partial class SpecialSetups
    {
        public int SpecialSetupId { get; set; }
        public int ScenarioId { get; set; }
        public int ListOrder { get; set; }
        public string SetupText { get; set; }

        public virtual Scenarios Scenario { get; set; }
    }
}

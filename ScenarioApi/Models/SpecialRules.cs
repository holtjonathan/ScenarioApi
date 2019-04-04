using System;
using System.Collections.Generic;

namespace ScenarioApi.Models
{
    public partial class SpecialRules
    {
        public int SpecialRuleId { get; set; }
        public int ScenarioId { get; set; }
        public int ListOrder { get; set; }
        public string RuleText { get; set; }

        public virtual Scenarios Scenario { get; set; }
    }
}

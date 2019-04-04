using System;
using System.Collections.Generic;

namespace ScenarioApi.Models
{
    public partial class SpecialMovesActions
    {
        public int SpecialMoveActionId { get; set; }
        public int ScenarioId { get; set; }
        public int ListOrder { get; set; }
        public string MoveText { get; set; }
    }
}

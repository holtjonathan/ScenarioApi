using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScenarioApi.Models
{
    public partial class LocationSelectionTracking
    {
        public int LocationSelectionTrackingId { get; set; }
        public int ScenarioId { get; set; }
        public int PlayerId { get; set; }
    }
}

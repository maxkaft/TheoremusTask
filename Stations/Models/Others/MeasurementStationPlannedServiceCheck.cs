using System;
using System.Collections.Generic;

namespace Stations
{
    public partial class MeasurementStationPlannedServiceCheck
    {
        public int PlannedStationServiceDateStatus { get; set; }
        public DateTime ScheduledAtUtc { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Guid Id { get; set; }
        public Guid StationId { get; set; }

        public Station Station { get; set; }
    }
}

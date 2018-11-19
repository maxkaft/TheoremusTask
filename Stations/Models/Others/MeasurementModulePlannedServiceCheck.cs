using System;
using System.Collections.Generic;

namespace Stations
{
    public partial class MeasurementModulePlannedServiceCheck
    {
        public int PlannedStationServiceDateStatus { get; set; }
        public DateTime ScheduledAtUtc { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Guid Id { get; set; }
        public Guid ModuleId { get; set; }

        public Modules Module { get; set; }
    }
}

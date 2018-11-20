using System;
using System.Collections.Generic;

namespace Stations
{
    public partial class MeasurementStationLogicalGroup
    {
        public Guid StationId { get; set; }
        public int GroupId { get; set; }

        public LogicalGroups Group { get; set; }
        public Station Station { get; set; }
    }
}

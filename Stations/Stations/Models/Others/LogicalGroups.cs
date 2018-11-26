using System;
using System.Collections.Generic;

namespace Stations
{
    public partial class LogicalGroups
    {
        public LogicalGroups()
        {
            MeasurementModuleLogicalGroup = new HashSet<MeasurementModuleLogicalGroup>();
            MeasurementStationLogicalGroup = new HashSet<MeasurementStationLogicalGroup>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<MeasurementModuleLogicalGroup> MeasurementModuleLogicalGroup { get; set; }
        public ICollection<MeasurementStationLogicalGroup> MeasurementStationLogicalGroup { get; set; }
    }
}

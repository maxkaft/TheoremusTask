using System;
using System.Collections.Generic;

namespace Stations
{
    public partial class Stations
    {
        public Stations()
        {
            MeasurementStationLogicalGroup = new HashSet<MeasurementStationLogicalGroup>();
            MeasurementStationPlannedServiceCheck = new HashSet<MeasurementStationPlannedServiceCheck>();
            MeasurementStationProperty = new HashSet<MeasurementStationProperty>();
        }

        public Guid Id { get; set; }
        public Guid StationTypeId { get; set; }
        public Guid? ModuleId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid? LatestLocationId { get; set; }
        public Guid? ExpectedLocationId { get; set; }
        public bool IsActive { get; set; }
        public DateTime? LastActiveAtUtc { get; set; }
        public DateTime? DecommissionAtUtc { get; set; }
        public string FirmwareVersion { get; set; }
        public string Comment { get; set; }

        public GeoLocations ExpectedLocation { get; set; }
        public GeoLocations LatestLocation { get; set; }
        public Modules Module { get; set; }
        public StationTypes StationType { get; set; }
        public ICollection<MeasurementStationLogicalGroup> MeasurementStationLogicalGroup { get; set; }
        public ICollection<MeasurementStationPlannedServiceCheck> MeasurementStationPlannedServiceCheck { get; set; }
        public ICollection<MeasurementStationProperty> MeasurementStationProperty { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Stations
{
    public partial class Modules
    {
        public Modules()
        {
            MeasurementModuleLogicalGroup = new HashSet<MeasurementModuleLogicalGroup>();
            MeasurementModulePlannedServiceCheck = new HashSet<MeasurementModulePlannedServiceCheck>();
            MeasurementModuleProperty = new HashSet<MeasurementModuleProperty>();
            Stations = new HashSet<Station>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid? LatestLocationId { get; set; }
        public Guid? ExpectedLocationId { get; set; }
        public bool IsActive { get; set; }
        public DateTime? LastActiveAtUtc { get; set; }
        public DateTime? DecommissionAtUtc { get; set; }
        public string Comment { get; set; }

        public GeoLocations ExpectedLocation { get; set; }
        public GeoLocations LatestLocation { get; set; }
        public ICollection<MeasurementModuleLogicalGroup> MeasurementModuleLogicalGroup { get; set; }
        public ICollection<MeasurementModulePlannedServiceCheck> MeasurementModulePlannedServiceCheck { get; set; }
        public ICollection<MeasurementModuleProperty> MeasurementModuleProperty { get; set; }
        public ICollection<Station> Stations { get; set; }
    }
}

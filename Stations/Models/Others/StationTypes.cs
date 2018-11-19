using System;
using System.Collections.Generic;

namespace Stations
{
    public partial class StationTypes
    {
        public StationTypes()
        {
            MeasurementStationTypeProperty = new HashSet<MeasurementStationTypeProperty>();
            Stations = new HashSet<Stations>();
        }

        public Guid Id { get; set; }
        public string Manifacturer { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string Subcategory { get; set; }
        public bool? ProvidesReferentialMeasurements { get; set; }
        public string SupportedNetworkProtocolsCsv { get; set; }

        public ICollection<MeasurementStationTypeProperty> MeasurementStationTypeProperty { get; set; }
        public ICollection<Stations> Stations { get; set; }
    }
}

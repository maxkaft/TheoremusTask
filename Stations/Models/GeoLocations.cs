using System;
using System.Collections.Generic;

namespace Stations
{
    public partial class GeoLocations
    {
        public GeoLocations()
        {
            ModulesExpectedLocation = new HashSet<Modules>();
            ModulesLatestLocation = new HashSet<Modules>();
            StationsExpectedLocation = new HashSet<Stations>();
            StationsLatestLocation = new HashSet<Stations>();
        }

        public Guid Id { get; set; }
        public int? LocationType { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        public double? Altitude { get; set; }
        public string Annotation { get; set; }
        public string Description { get; set; }
        public DateTime TimeCreatedUtc { get; set; }

        public ICollection<Modules> ModulesExpectedLocation { get; set; }
        public ICollection<Modules> ModulesLatestLocation { get; set; }
        public ICollection<Stations> StationsExpectedLocation { get; set; }
        public ICollection<Stations> StationsLatestLocation { get; set; }
    }
}

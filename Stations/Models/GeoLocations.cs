using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Stations
{
    public partial class GeoLocations
    {
        public GeoLocations()
        {
            StationsExpectedLocation = new HashSet<Station>();
            StationsLatestLocation = new HashSet<Station>();
        }

        public Guid Id { get; set; }
        public int? LocationType { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        public double? Altitude { get; set; }
        public string Annotation { get; set; }
        public string Description { get; set; }
        public DateTime TimeCreatedUtc { get; set; }

        public ICollection<Station> StationsExpectedLocation { get; set; }
        public ICollection<Station> StationsLatestLocation { get; set; }
    }
}

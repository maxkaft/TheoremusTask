using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Stations
{
    public partial class MeasurementStationProperty
    {
        [Key]
        public Guid Id { get; set; }
        public string Key { get; set; }
        public string ValueType { get; set; }
        public string Value { get; set; }
        public Guid StationId { get; set; }

        public Station Station { get; set; }
    }
}

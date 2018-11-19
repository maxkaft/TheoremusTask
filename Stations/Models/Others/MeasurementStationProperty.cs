using System;
using System.Collections.Generic;

namespace Stations
{
    public partial class MeasurementStationProperty
    {
        public string Key { get; set; }
        public string ValueType { get; set; }
        public string Value { get; set; }
        public Guid StationId { get; set; }

        public Stations Station { get; set; }
    }
}

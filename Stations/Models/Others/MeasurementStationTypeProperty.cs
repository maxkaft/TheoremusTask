using System;
using System.Collections.Generic;

namespace Stations
{
    public partial class MeasurementStationTypeProperty
    {
        public string Key { get; set; }
        public string ValueType { get; set; }
        public string Value { get; set; }
        public Guid StationTypeId { get; set; }

        public StationTypes StationType { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Stations
{
    public partial class MeasurementModuleProperty
    {
        public string Key { get; set; }
        public string ValueType { get; set; }
        public string Value { get; set; }
        public Guid ModuleId { get; set; }

        public Modules Module { get; set; }
    }
}

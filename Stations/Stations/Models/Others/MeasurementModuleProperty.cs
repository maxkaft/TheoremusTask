using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Stations
{
    public partial class MeasurementModuleProperty
    {
        [Key]
        public Guid Id { get; set; }
        public string Key { get; set; }
        public string ValueType { get; set; }
        public string Value { get; set; }
        public Guid ModuleId { get; set; }

        public Modules Module { get; set; }
    }
}

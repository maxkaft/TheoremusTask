using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Stations
{
    public partial class MeasurementModuleLogicalGroup
    {
        [Key]
        public Guid Id { get; set; }
        public Guid ModuleId { get; set; }
        public int GroupId { get; set; }

        public LogicalGroups Group { get; set; }
        public Modules Module { get; set; }
    }
}

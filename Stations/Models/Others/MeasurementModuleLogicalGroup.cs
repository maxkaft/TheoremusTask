using System;
using System.Collections.Generic;

namespace Stations
{
    public partial class MeasurementModuleLogicalGroup
    {
        public Guid ModuleId { get; set; }
        public int GroupId { get; set; }

        public LogicalGroups Group { get; set; }
        public Modules Module { get; set; }
    }
}

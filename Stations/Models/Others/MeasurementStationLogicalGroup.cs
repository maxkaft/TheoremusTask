using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Stations
{
    public partial class MeasurementStationLogicalGroup
    {
        [Key]
        public Guid Id { get; set; }

        public Guid StationId { get; set; }
        public int GroupId { get; set; }

        public LogicalGroups Group { get; set; }
        public Station Station { get; set; }
    }
}

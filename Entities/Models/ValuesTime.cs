using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Models
{
    public partial class ValuesTime
    {
        public int ValTimesId { get; set; }
        public string Name { get; set; }
        public double? DuringTime { get; set; }
        public string MonFrom { get; set; }
        public string MonTo { get; set; }
        public int? MonListId { get; set; }
        public string MonNames { get; set; }

        public virtual MonitorList MonList { get; set; }
    }
}

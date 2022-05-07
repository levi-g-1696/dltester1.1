using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Models
{
    public partial class DataSchedual
    {
        public int SchedId { get; set; }
        public int? SessionId { get; set; }
        public bool? IsSent { get; set; }
        public bool? WasErrorOnSending { get; set; }
        public int? RepeatCounter { get; set; }
        public DateTime Time { get; set; }
        public string MonitorsVal { get; set; }
    }
}

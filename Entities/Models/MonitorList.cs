using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Models
{
    public partial class MonitorList
    {
        public MonitorList()
        {
            Sessions = new HashSet<Session>();
            ValuesTimes = new HashSet<ValuesTime>();
        }

        public int MonListId { get; set; }
        public string Name { get; set; }
        public string MonitorNames { get; set; }

        public virtual ICollection<Session> Sessions { get; set; }
        public virtual ICollection<ValuesTime> ValuesTimes { get; set; }
    }
}

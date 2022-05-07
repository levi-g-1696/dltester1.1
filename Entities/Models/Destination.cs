using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Models
{
    public partial class Destination
    {
        public Destination()
        {
            Sessions = new HashSet<Session>();
        }

        public int DestinationId { get; set; }
        public string Name { get; set; }
        public string ProtocolType { get; set; }
        public int Port { get; set; }
        public string SrvUser { get; set; }
        public string SrvPassword { get; set; }
        public int? Protocolid { get; set; }
        public string Ipaddress { get; set; }
        public string VirtualPath { get; set; }

        public virtual ICollection<Session> Sessions { get; set; }
    }
}

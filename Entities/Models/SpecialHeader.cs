using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Models
{
    public partial class SpecialHeader
    {
        public SpecialHeader()
        {
            Sessions = new HashSet<Session>();
        }

        public int SpecHeaderId { get; set; }
        public string Name { get; set; }
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string Line3 { get; set; }
        public string Line4 { get; set; }
        public string Line5 { get; set; }
        public string Line6 { get; set; }

        public virtual ICollection<Session> Sessions { get; set; }
    }
}

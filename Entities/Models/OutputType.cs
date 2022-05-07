using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Models
{
    public partial class OutputType
    {
        public OutputType()
        {
            Sessions = new HashSet<Session>();
        }

        public int OutputTypeId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Session> Sessions { get; set; }
    }
}

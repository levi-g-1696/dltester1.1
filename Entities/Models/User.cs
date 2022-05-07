using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Models
{
    public partial class User
    {
        public User()
        {
            Sessions = new HashSet<Session>();
        }

        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public DateTime? CreationDate { get; set; }
        public bool IsAdmin { get; set; }
        public bool IsEnable { get; set; }

        public virtual ICollection<Session> Sessions { get; set; }
    }
}

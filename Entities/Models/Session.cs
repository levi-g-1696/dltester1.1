using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Models
{
    public partial class Session
    {
        public int SessionId { get; set; }
        public string Name { get; set; }
        public int? OutputTypeId { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public bool? IsEnable { get; set; }
        public bool? HasConfirmation { get; set; }
        public int? MonitorListId { get; set; }
        public int? Repeat { get; set; }
        public double? Pause { get; set; }
        public int? TimingBase { get; set; }
        public DateTime? StartTime { get; set; }
        public int? UserId { get; set; }
        public bool? StartOnEnable { get; set; }
        public int? SpecHeaderId { get; set; }
        public int? ValTimesId { get; set; }
        public int? DestinationId { get; set; }

        public virtual Destination Destination { get; set; }
        public virtual MonitorList MonitorList { get; set; }
        public virtual OutputType OutputType { get; set; }
        public virtual SpecialHeader SpecHeader { get; set; }
        public virtual User User { get; set; }
    }
}

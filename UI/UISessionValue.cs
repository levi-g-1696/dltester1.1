using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Models;
namespace UI
{
   
    public static class UISessionValue
    {


        public static int SessionId { get; set; } = -1;
        public static string Name { get; set; } = "NoName";
        public static int? OutputTypeId { get; set; } = -1;
        public static DateTime? CreationDate { get; set; } = DateTime.Now;
        public static DateTime? ExpirationDate { get; set; } = DateTime.Now.AddHours(3);
        public static bool? IsEnable { get; set; } = false;
        public static bool? HasConfirmation { get; set; } = false;
        public static int? ValuesTimesId { get; set; } = -1;
        public static int? MonitorListId { get; set; } = -1;
        public static int? Repeat { get; set; } = 1;
        public static double? Pause { get; set; } = 0;
        public static int? TimingBase { get; set; } = 1;
        public static DateTime? StartTime { get; set; } = DateTime.Now;
        public static int? UserId { get; set; } = -1;
        public static bool? StartOnEnable { get; set; } = false;
        public static int? SpecHeaderId { get; set; } = -1;
        public static int? ValTimesId { get; set; } = -1;
        public static Session Session { get; set; } = new Session();
        public static Destination Destination { get; set; } = new Destination();
        public static MonitorList MonitorList { get; set; } = new MonitorList();
        public static OutputType OutputType { get; set; } = new OutputType();
        public static SpecialHeader SpecHeader { get; set; } = new SpecialHeader();
        public static User User { get; set; } = new User();
        public static ValuesTime ValTimes { get; set; } = new ValuesTime();
      
    }

}


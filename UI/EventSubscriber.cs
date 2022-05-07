using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Models;using Manage;

namespace UI
{
   
    public static class EventSubscriber
    {
        public static void Init()
        {
            DBconnection dbconnection = new DBconnection(); 
            UI.Form_Destination_NewEdit.SaveAction += dbconnection.SaveDestination ;
            UI.Form_MonList_NewEdit.SaveAction += dbconnection.SaveMonitorList;
          //  UI.Form_ValuesTimes_NewEdit.SaveToDB += dbconnection.SaveValuesTimes;
            UI.Form_ValuesTimes_NewEdit.GetFromDBMonitorNames += dbconnection.GetMonitorNames;
            UI.Form_DestinationsView.ReadAction += dbconnection.ReadDestinations;
        //    UI.Form_SessionsView.ReadFromDB += dbconnection.ReadSessions;
            UI.Form_SessionsView.ReadFromDB += dbconnection.ReadSessions2;
            UI.Form_MonListView.ReadFromDB += dbconnection.ReadMonList;
            UI.Form_MonListView.MonListIsUsedBySession+= dbconnection.CheckMonListIDExistInSessions;
            UI.Form_MonListView.MonListIsUsedByValTimes += dbconnection.CheckMonListIDExistInValTimes;
           UI.Form_Session_NewEdit.SaveAction += dbconnection.SaveSession;
            UI.Form_SessionsView.GetSession += dbconnection.FindSession;
            UI.Form_SessionsView.RemoveFromDB += dbconnection.RemoveSession;
            UI.Form_SessionsView.GetDestination += dbconnection.FindDestination;
            UI.Form_SessionsView.GetMonList += dbconnection.FindMonList;
            UI.Form_SessionsView.GetValTime += dbconnection.FindValTime;
            UI.Form_DestinationsView.RemoveFromDB += dbconnection.RemoveDestination;
            UI.Form_DestinationsView.DestinationIsUsedBySession += dbconnection.CheckDestinationIDExistInSessions;
            UI.Form_MonListView.RemoveFromDB += dbconnection.RemoveMonList;
            UI.Form_ValuesTimesView.ReadFromDBforThisMonList += dbconnection.ReadValTimeForOneSession;
            UI.Form_ValuesTimesView.ReadOneFromDB += dbconnection.FindValTime;
            UI.Form_ValuesTimesView.RemoveFromDB += dbconnection.RemoveValTime;

        }

        //   public static void Save(Destination dest)
        //   {
        //       //  using (var dbct = new DL_TesterContext())

        //       using (var db = new DL_TesterContext())
        //       {
        //           db.Destinations.Add(dest);
        //           db.SaveChanges();
        ////           Console.WriteLine("dest saved");

        //      }
        //   }
    }
}

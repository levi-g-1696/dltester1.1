using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Models;
using Entities;

namespace Manage
{
    // public delegate void DelSaveEventHanler();

    public class DBconnection
    {
        Session newsession = new Session();
        public DBconnection()
        {

        }

        //  UIdata uiData=new UIdata();
        //public Session ThisSession { get; set; }

        //public WriteToDB()
        //{
        //    ThisSession = new Session();
        //}

        public static void Init()
        {
            //  uiData = new UIdata();
        }
        //================= s a v e ======================================
        public void SaveSession(Session session, Entities.Editmode savemode)
        {

            using (var db = new DL_TesterContext())
            {
                //  uiData.Destination = dest;
                if (savemode == Entities.Editmode.New)
                {
                    session.SessionId = 0;
                    db.Sessions.Add(session);
                    db.SaveChanges();
                }
                else
                {
                    var mySession = db.Sessions.Find(session.SessionId);
                    Methods.CopyPropertiesTo<Session, Session>(session, mySession);
                }
                db.SaveChanges();
                Console.WriteLine("ses saved");

            }
        }
        //^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
        public void SaveDestination(Destination dest, Entities.Editmode savemode)
        {

            using (var db = new DL_TesterContext())
            {
                if (savemode == Entities.Editmode.New)
                {
                    db.Destinations.Add(dest);
                    db.SaveChanges();

                }
                else
                {
                    var myDest = db.Destinations.Find(dest.DestinationId);
                    if (myDest != null)
                    {

                        Methods.CopyPropertiesTo<Destination, Destination>(dest, myDest);

                        db.SaveChanges();
                    }
                }

            }
        }




        //^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
        public void SaveMonitorList(MonitorList monitorList, Entities.Editmode savemode)
        {
            using (var db = new DL_TesterContext())
            {
                if (savemode == Entities.Editmode.New)
                {
                    monitorList.MonListId = 0;
                    db.MonitorLists.Add(monitorList);
                    db.SaveChanges();

                }
                else
                {
                    var myMonList = db.MonitorLists.Find(monitorList.MonListId);
                    Methods.CopyPropertiesTo(monitorList, myMonList);
                    db.SaveChanges();

                }


                //    ThisSession.MonitorList = monitorList;
            }
        }
        //^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^6\

        public void SaveDataSched(DataSchedual dataSchedual)
        {
            using (var db = new DL_TesterContext())
            {

                
                   
                    db.DataScheduals.Add(dataSchedual);
                    db.SaveChanges();

                
                
                
            }

        }



        //=============================================================================

        //########    g e t  -  r e a d   ##############
        public void GetDestinations(User user)
        {
            using (var db = new DL_TesterContext())
            {
                ////             var qur = db.Destinations.Where(d => d.);
                //     fileTypesUsed = (from q in qur select q.OutputTypeId).ToList();
                //          var listOfMonitorList = (from q in qur select q.MonitorList).ToList();
                //             var destinationList = (from q in qur select q.Destination).ToList();
                //             db.MonitorLists.Add(monitorList);
                db.SaveChanges();
                Console.WriteLine("monlist saved");
            }


        }

        

        public string GetMonitorNames(int id)
        {
            using (var db = new DL_TesterContext())
            {
                ////             var qur = db.Destinations.Where(d => d.);
                //     fileTypesUsed = (from q in qur select q.OutputTypeId).ToList();
                //          var listOfMonitorList = (from q in qur select q.MonitorList).ToList();
                //             var destinationList = (from q in qur select q.Destination).ToList();
                //             db.MonitorLists.Add(monitorList);

                string res = db.MonitorLists.Find(id).MonitorNames;
                return res;
            }


        }
        public List<Destination> ReadDestinations()
        {

            using (var db = new DL_TesterContext())
            {

                var destDataTable = (from dest in db.Destinations select dest).ToList<Destination>();
                return destDataTable;

            }
        }
        public List<Session> ReadSessions(int userID)
        {

            using (var db = new DL_TesterContext())
            {
                var user = db.Users.Find(userID);
                if (user.IsAdmin) {
                var sessionsDataTable = (from ses in db.Sessions where ses.UserId == userID select ses).ToList();
                    return sessionsDataTable;
                }
                else
                {
                    var sessionsDataTable = (from ses in db.Sessions where ses.UserId == userID select ses).ToList();
                    return sessionsDataTable;
                }



            }
        }

        public List<dynamic> ReadSessions2(int userID)
        {

            using (var db = new DL_TesterContext())
            {
                var user = db.Users.Find(userID);
                if (user.IsAdmin)
                {
                    var sessionsDataTable = (from ses in db.Sessions
                                             select ses).ToList<dynamic>();
                    return sessionsDataTable;

                }
                else
                {
                    var sessionsDataTable = (from ses in db.Sessions
                                             join ds in db.Destinations  on ses.DestinationId equals ds.DestinationId
                                             join ml in db.MonitorLists on ses.MonitorListId  equals ml.MonListId
                                             join vt in db.ValuesTimes on ses.ValTimesId equals vt.ValTimesId
                                              

                                             //================
                    where ses.UserId == userID select
                                             new
                                             {
                                                 ID= ses.SessionId,
                                                 Name = ses.Name,
                                                 Destination = ds.Name,
                                                 MonitorList = ml.Name,
                                                 Values= vt.Name,
                                                 OutputType = "csv",


                                             }).ToList<dynamic>();
                    return sessionsDataTable;
                  
                    
                }



            }
        }

        public List<MonitorList> ReadMonList()
        {

            using (var db = new DL_TesterContext())
            {

                var monListTable = (from l in db.MonitorLists select l).ToList();
                return monListTable;

            }
        }

        public List<ValuesTime> ReadValTimeForOneSession(int id)
        {

            using (var db = new DL_TesterContext())
            {

                var valTimeListTable = (from v in db.ValuesTimes where v.MonListId == id select v).ToList();
                return valTimeListTable;

            }
        }
        //#################################################################

        //   **********  F I N D   ***********************8
        public int findLastValtimesID()
        {
            return 1003;
        }
        //public IQueryable ReadSessions()
        //{

        //    using (var db = new DL_TesterContext())
        //    {

        //        var sessionsDataTable = from ses in db.Sessions select ses ;
        //        return sessionsDataTable;

        //    }


        //}



        public Session FindSession(int id)
        {

            using (var db = new DL_TesterContext())
            {
                var res = db.Sessions.Find(id);

                return res;


            }
        }
        public MonitorList FindMonList(int id)
        {

            using (var db = new DL_TesterContext())
            {
                var res = db.MonitorLists.Find(id);

                return res;


            }
        }
        public Destination FindDestination(int id)
        {

            using (var db = new DL_TesterContext())
            {
                var res = db.Destinations.Find(id);

                return res;


            }
        }

        public ValuesTime FindValTime(int id)
        {

            using (var db = new DL_TesterContext())
            {
                var res = db.ValuesTimes.Find(id);

                return res;


            }
        }

        public static User FindUser(string uname)
        {

            using (var db = new DL_TesterContext())
            {
                var res = (from u in db.Users where u.UserName == uname select u).ToList();

                if (res.Count != 0) return res[0];
                else return null;


            }
        }


        // &&&&&&&&&&&&&&    R E M O V E   &&&&&&&&&&&&&&&&&&&&&&&
        /*   var employer = new Employ { Id = 1 };
           ctx.Employ.Attach(employer);
               ctx.Employ.Remove(employer);
               ctx.SaveChanges(  */

        public void RemoveSession(int id)
        {
            using (var db = new DL_TesterContext())
            {
                var sessionToRemove = FindSession(id);
                db.Sessions.Remove(sessionToRemove);
                db.SaveChanges();

            }

        }

        public void RemoveDestination(int id)
        {
            using (var db = new DL_TesterContext())
            {
                var destToRemove = FindDestination(id);
                db.Destinations.Remove(destToRemove);
                db.SaveChanges();

            }

        }
        public void RemoveMonList(int id)
        {
            using (var db = new DL_TesterContext())
            {
                var monlistToRemove = FindMonList(id);
                db.MonitorLists.Remove(monlistToRemove);
                db.SaveChanges();

            }

        }

        public void RemoveValTime(int id)
        {
            using (var db = new DL_TesterContext())
            {
                var valTimeToRemove = FindValTime(id);
                db.ValuesTimes.Remove(valTimeToRemove);
                db.SaveChanges();

            }

        }


        // %%%%%%%%%%  Check if Exist   %%%%%%%%%%%%%%%%%%%%%%%

        public bool CheckDestinationIDExistInSessions(int id)
        {
            using (var db = new DL_TesterContext())
            {
                var matchCount = (from s in db.Sessions where s.DestinationId == id select s).Count();
                if (matchCount > 0) return true;
                else return false;
            }

        }

        public bool CheckMonListIDExistInSessions(int id)
        {
            using (var db = new DL_TesterContext())
            {
                var matchCount = (from s in db.Sessions where s.MonitorListId == id select s).Count();
                if (matchCount > 0) return true;
                else return false;
            }

        }

        public bool CheckValTimesIDExistInSessions(int id)
        {
            using (var db = new DL_TesterContext())
            {
                var matchCount = (from s in db.Sessions where s.ValTimesId == id select s).Count();
                if (matchCount > 0) return true;
                else return false;
            }

        }

        public bool CheckMonListIDExistInValTimes(int id)
        {
            using (var db = new DL_TesterContext())
            {
                var matchCount = (from vt in db.ValuesTimes where vt.MonListId == id select vt).Count();
                if (matchCount > 0) return true;
                else return false;
            }

        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Entities.Models;

namespace Manage
{
   public enum LoginResult {OK,
    UserPswWrong,
    UserAccountExpired}
    public static class Methods
    {
       

       
        public static void CopyPropertiesTo<T, TU>(this T source, TU dest)
        {//this solution was token from "stackoverflow" portal

            var sourceProps = typeof(T).GetProperties().Where(x => x.CanRead).ToList();
            var destProps = typeof(TU).GetProperties()
                    .Where(x => x.CanWrite)
                    .ToList();

            foreach (var sourceProp in sourceProps)
            {




                if (destProps.Any(x => x.Name == sourceProp.Name))
                {
                    var p = destProps.First(x => x.Name == sourceProp.Name);
                    if ((p.CanWrite) && (sourceProp.GetValue(source, null) != null))
                    { // check if the property can be set or no.
                        p.SetValue(dest, sourceProp.GetValue(source, null), null);
                    }
                }

            }

        }
        public static LoginResult CheckLogin(string user, string psw)
        {
           
            var userOnDB = DBconnection.FindUser(user);
            if (userOnDB == null) return LoginResult.UserPswWrong;
            else if (userOnDB.Password != psw) return LoginResult.UserPswWrong;
            else if (userOnDB.ExpirationDate.Value < DateTime.Now) return LoginResult.UserAccountExpired;
            else { 
                return LoginResult.OK; }
           
        }

        public static List<DateTime> TimeValuesForMonValuesOnTimeInterval(DateTime start, double timeIntervalminutes,
                                    double timingBase)
        {
            List<DateTime> timeValues = new List<DateTime>();
            int n = (int)Math.Round(timeIntervalminutes / timingBase);
            int deltaSec = (int)Math.Round(60 * timeIntervalminutes / n);

            for (int i = 0; i < n; i++)
            {
                timeValues.Add(start.AddSeconds(i * deltaSec));
            }
            timeValues.Add(start.AddMinutes(timeIntervalminutes));


            return timeValues;
        }

        //public static DataSchedual CreateDataSchedualRow(List<double> monFrom, List<double> monTo,
        //                                                 double timeIntervalMin, double timingBase ,
        //                                                 DateTime start)
        //{
        //    DataSchedual dataSchedual = new DataSchedual();

        //    return dataSchedual;
        //}
    }
}

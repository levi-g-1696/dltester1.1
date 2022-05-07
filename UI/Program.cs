using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities.Models;
using Manage;

namespace UI
{
   
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        
        static void Main()
        {
            EventSubscriber.Init();

            DBconnection toDB = new DBconnection();
            Session thisSession = new Session();

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form_Login());

            //          Application.Run(new Form_SessionsView());
            //         Application.Run(new Form_Dest());

        }
    }
}

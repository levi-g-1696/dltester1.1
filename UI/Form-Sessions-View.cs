using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities.Models;
using Manage;

namespace UI
{
   // public delegate List<Session>  SessionTableReadEventHanler(int userID);
    public delegate List<dynamic> SessionTableReadEventHanler2(int userID);
    public delegate Session SessionFindEventHanler(int sessionID);
    public delegate Destination DestinationFindEventHanler(int ID);
    public delegate MonitorList MonListFindEventHanler(int ID);
    public delegate ValuesTime ValTimeFindEventHanler(int sessionID);
    public delegate void  SessionRemoveEventHanler(int sessionID);
    public partial class Form_SessionsView : Form
    {
        public Session session ;
        Form_Login fatherForm;
   //     public static event SessionTableReadEventHanler ReadFromDB;
        public static event SessionTableReadEventHanler2 ReadFromDB;
        public static event SessionFindEventHanler GetSession;
        public static event DestinationFindEventHanler GetDestination;
        public static event MonListFindEventHanler GetMonList;
        public static event ValTimeFindEventHanler GetValTime;
        public static event SessionRemoveEventHanler RemoveFromDB;
        public Form_SessionsView(Form_Login fatherFormArg)
        {
            session = new Session();
            InitializeComponent();
            fatherForm = fatherFormArg;
            fatherForm.Visible=false;
            SessionGridView.DataSource = ReadFromDB(UISessionValue.User.UserId);
            SessionGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            SessionGridView.ReadOnly = true;
    //        SessionGridView.Rows[0].Selected = true;
            DataGridViewRow row = this.SessionGridView.Rows[0];
            var cell0 = row.Cells[0].Value.ToString();
                        
            int firstID= int.Parse(cell0);
           Session firstSession = GetSession(firstID);
            Methods.CopyPropertiesTo<Session,Session>(firstSession, UISessionValue.Session);
            var stamU = UISessionValue.User;
            
            //load gridwiew     
        }
     

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Form_Session_NewEdit form_Session_NewEdit = new Form_Session_NewEdit(Entities.Editmode.New,this);
            form_Session_NewEdit.Show();
       
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {

            if (SessionGridView.SelectedRows.Count != 0)
            {
                DataGridViewRow row = this.SessionGridView.SelectedRows[0];
                var cell0 = row.Cells[0].Value.ToString();
                
                UISessionValue.Session.SessionId = int.Parse(cell0);
                session = GetSession(UISessionValue.Session.SessionId);
                Methods.CopyPropertiesTo<Session, Session>(session, UISessionValue.Session);
                var destinationSelected = GetDestination((int)UISessionValue.Session.DestinationId);
                var monListSelected = GetMonList((int)UISessionValue.Session.MonitorListId);
                var valtimeSelected = GetValTime((int)UISessionValue.Session.ValTimesId);
                              
                Methods.CopyPropertiesTo(destinationSelected, UISessionValue.Destination);
                Methods.CopyPropertiesTo(monListSelected, UISessionValue.MonitorList);
                Methods.CopyPropertiesTo(valtimeSelected, UISessionValue.ValTimes);
            }
            Form_Session_NewEdit form_Session_NewEdit = new Form_Session_NewEdit(Entities.Editmode.Edit, this);
            form_Session_NewEdit.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public void GridViewRefresh()
        {

            SessionGridView.DataSource = ReadFromDB(UISessionValue.User.UserId);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (SessionGridView.SelectedRows.Count != 0)
            {
                DataGridViewRow row = this.SessionGridView.SelectedRows[0];
                var cell0 = row.Cells[0].Value.ToString();

                int sessionIdToRemove = int.Parse(cell0);
                RemoveFromDB(sessionIdToRemove);
                GridViewRefresh();
            }
        }

        private void Form_SessionsView_Load(object sender, EventArgs e)
        {

        }

        private void Form_SessionsView_FormClosed(object sender, FormClosedEventArgs e)
        {
            fatherForm.Close();
        }
    }
}

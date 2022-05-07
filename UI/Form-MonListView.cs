using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Manage;
using Entities.Models;
using Entities;
namespace UI
{
    public delegate List<MonitorList> ReadMonListEventHandler();
    public delegate void MonListRemoveEventHandler(int id);
    public delegate bool MonListCheckForRemoveEventHandler(int id);
   
    public partial class Form_MonListView : Form
    {
        public static event ReadMonListEventHandler ReadFromDB;
        public static event MonListRemoveEventHandler RemoveFromDB;
        public static event MonListCheckForRemoveEventHandler MonListIsUsedBySession;
        public static event MonListCheckForRemoveEventHandler MonListIsUsedByValTimes;
        Form_Session_NewEdit fatherForm;
        public  Form_MonListView(Form_Session_NewEdit fatherFormArg)
        {
            InitializeComponent();
            gridMonitors.DataSource = ReadFromDB();
            fatherForm = fatherFormArg;
            gridMonitors.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridMonitors.ReadOnly = true;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Form_MonList_NewEdit form_MonList_NewEdit = new Form_MonList_NewEdit(Editmode.New, this);
            form_MonList_NewEdit.Show();


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (gridMonitors.SelectedRows.Count != 0)

            {
                DataGridViewRow row = this.gridMonitors.SelectedRows[0];
                //        var cell0 = row.Cells[0].Value.ToString();


                UISessionValue.MonitorList.MonListId = (int)row.Cells[0].Value;
                UISessionValue.MonitorList.Name = (string)row.Cells[1].Value;
                UISessionValue.MonitorList.MonitorNames = (string)row.Cells[2].Value;
                // UISessionValue.Session.MonitorListId = UISessionValue.MonitorList.MonListId;
                // UISessionValue.Session.MonitorList = UISessionValue.MonitorList;
                UISessionValue.ValTimes.MonListId = UISessionValue.MonitorList.MonListId;



                fatherForm.txtMonListRefresh();
                //   fatherForm.txt();
                this.Close();

            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (gridMonitors.SelectedRows.Count != 0)

            {
                DataGridViewRow row = this.gridMonitors.SelectedRows[0];
                //        var cell0 = row.Cells[0].Value.ToString();


                UISessionValue.MonitorList.MonListId = (int)row.Cells[0].Value;
                UISessionValue.MonitorList.Name = (string)row.Cells[1].Value;
                UISessionValue.MonitorList.MonitorNames = (string)row.Cells[2].Value;
                Form_MonList_NewEdit form_MonList_NewEdit = new Form_MonList_NewEdit(Editmode.Edit, this);
                form_MonList_NewEdit.Show();


            }

        }
        public void GridViewRefresh()
        {

            gridMonitors.DataSource = ReadFromDB();
        }



        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (gridMonitors.SelectedRows.Count != 0)
            {
                DataGridViewRow row = this.gridMonitors.SelectedRows[0];
                int monListIDtoRemove = (int)row.Cells[0].Value;
                if (MonListIsUsedBySession(monListIDtoRemove))
                {
                    MessageBox.Show("Cannot remove this one , becouse the monitor list is registered in sessions table", "",
MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (MonListIsUsedByValTimes(monListIDtoRemove))
                {
                    MessageBox.Show("Cannot remove this one , becouse the monitor list is registered in ValuesTimes table", "",
MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else { RemoveFromDB(monListIDtoRemove); }

               
                GridViewRefresh();
            }

        }
    }
}

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

namespace UI
{

    public delegate List<Destination> ReadDestinationsEventHandler( );
    public delegate void DestinationRemoveEventHandler(int id);
    public delegate bool DestinationCheckForRemoveEventHandler(int id);
    public partial class Form_DestinationsView : Form
    {
        public static event ReadDestinationsEventHandler ReadAction;
        public static event DestinationRemoveEventHandler RemoveFromDB;
        public static event DestinationCheckForRemoveEventHandler DestinationIsUsedBySession;
        Form_Session_NewEdit fatherForm;
        public Form_DestinationsView(Form_Session_NewEdit fatherFormArg)
        {
            fatherForm = fatherFormArg;
            InitializeComponent();
            gridDestination.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridDestination.ReadOnly = true;

            gridDestination.DataSource = ReadAction();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            bool createNew = true;
            Form_Destination_NewEdit form_New_Destination = new Form_Destination_NewEdit(Entities.Editmode.New, this);
            form_New_Destination.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (gridDestination.SelectedRows.Count != 0)
            {
                DataGridViewRow row = this.gridDestination.SelectedRows[0];
                var cell0 = row.Cells[0].Value.ToString();

                UISessionValue.Destination.DestinationId = int.Parse(cell0);
                UISessionValue.Destination.Name = (string)row.Cells[1].Value;
                UISessionValue.Destination.ProtocolType = (string)row.Cells[2].Value;
                UISessionValue.Destination.Ipaddress = (string)row.Cells[7].Value;
                UISessionValue.Destination.Port = int.Parse(row.Cells[3].Value.ToString());
                UISessionValue.Destination.VirtualPath = (string)row.Cells[8].Value;
                UISessionValue.Destination.SrvUser = (string)row.Cells[4].Value;
                UISessionValue.Destination.SrvPassword = (string)row.Cells[5].Value;
                UISessionValue.Session.DestinationId = UISessionValue.Destination.DestinationId;
                fatherForm.txtDestinationRefresh();
                this.Close();

            }

        }


        //dataGridView1.DataSource = (from dest in db.Destinations where dest.DestinationId< 304 
        //                                    select dest)
        //            .ToList<Destination>();

        private void gridDestination_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (gridDestination.SelectedRows.Count != 0)
            {
                DataGridViewRow row = this.gridDestination.SelectedRows[0];
                var cell0 = row.Cells[0].Value.ToString();

                UISessionValue.Destination.DestinationId = int.Parse(cell0);
                UISessionValue.Destination.Name = (string)row.Cells[1].Value;
                UISessionValue.Destination.ProtocolType = (string)row.Cells[2].Value;
                UISessionValue.Destination.Ipaddress = (string)row.Cells[7].Value;
                UISessionValue.Destination.Port = int.Parse(row.Cells[3].Value.ToString());
                UISessionValue.Destination.VirtualPath = (string)row.Cells[8].Value;
                UISessionValue.Destination.SrvUser = (string)row.Cells[4].Value;
                UISessionValue.Destination.SrvPassword = (string)row.Cells[5].Value;
            }



            Form_Destination_NewEdit form_New_Destination = new Form_Destination_NewEdit(Entities.Editmode.Edit, this);
            form_New_Destination.Show();
        }
        public void DestGridRefresh()
        {
            gridDestination.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridDestination.ReadOnly = true;

            gridDestination.DataSource = ReadAction();

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (gridDestination.SelectedRows.Count != 0)
            {
                DataGridViewRow row = this.gridDestination.SelectedRows[0];
                var cell0 = row.Cells[0].Value.ToString();
                int destIDtoRemove = int.Parse(cell0);
                if (DestinationIsUsedBySession(destIDtoRemove)) {
                    MessageBox.Show("Cannot remove this one , becouse the destination is registered in sessions table", "",
MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else { RemoveFromDB(destIDtoRemove); }
                
                DestGridRefresh();
            }
        }
    }
}

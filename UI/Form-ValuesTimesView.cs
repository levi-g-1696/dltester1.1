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
using Entities;
using Entities.Models;
namespace UI
{
    public delegate ValuesTime ValTimeFindOneEventHanler(int id);
    public delegate List<ValuesTime> ValTimeReadDBEventHandler(int monlistID);
    public delegate void ValTimeRemoveEventHandler(int id);
    public partial class Form_ValuesTimesView : Form
    {
        Form_Session_NewEdit fatherForm;
        Editmode savemode;
        public static event ValTimeFindOneEventHanler ReadOneFromDB;
        public static event ValTimeReadDBEventHandler ReadFromDBforThisMonList;
        public static event ValTimeRemoveEventHandler RemoveFromDB;
        public Form_ValuesTimesView(Editmode editmode, Form_Session_NewEdit fatherFormArg)
        {
           
            InitializeComponent();
            fatherForm = fatherFormArg;
            savemode = editmode;
            var s = UISessionValue.ValTimes;
            GridViewRefresh();
            gridValuesTimes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridValuesTimes.ReadOnly = true;


        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Form_ValuesTimes_NewEdit form_ValuesTimes_NewEdit = new Form_ValuesTimes_NewEdit(Entities.Editmode.New, this);

            form_ValuesTimes_NewEdit.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            if (gridValuesTimes.SelectedRows.Count != 0)
            {
                var row = this.gridValuesTimes.SelectedRows[0];
                var cell0 = row.Cells[0].Value.ToString();

                UISessionValue.ValTimes.ValTimesId = int.Parse(cell0);
                UISessionValue.ValTimes.DuringTime = 0;
                var valtimeRow = ReadOneFromDB(UISessionValue.ValTimes.ValTimesId);
                Methods.CopyPropertiesTo(valtimeRow, UISessionValue.ValTimes);
            }

            Form_ValuesTimes_NewEdit form_ValuesTimes_NewEdit = new Form_ValuesTimes_NewEdit(Entities.Editmode.Edit, this);
            form_ValuesTimes_NewEdit.Show();
        }


        private void btnOK_Click(object sender, EventArgs e)
        {
            if (gridValuesTimes.SelectedRows.Count != 0)

            {
                DataGridViewRow row = this.gridValuesTimes.SelectedRows[0];

                UISessionValue.ValTimes.ValTimesId = (int)row.Cells[0].Value;
                UISessionValue.ValTimes.Name = (string)row.Cells[1].Value;





                fatherForm.txtValTimesRefresh();
                //   fatherForm.txt();
                this.Close();
            }
        }
        public void GridViewRefresh()
        {
            if (UISessionValue.ValTimes.MonListId != null)
            {
            gridValuesTimes.DataSource = ReadFromDBforThisMonList((int)UISessionValue.ValTimes.MonListId);

            }
            else { gridValuesTimes.DataSource = ReadFromDBforThisMonList(0); }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (gridValuesTimes.SelectedRows.Count != 0)
            {
                var row = this.gridValuesTimes.SelectedRows[0];
                var cell0 = row.Cells[0].Value.ToString();

                int idToRemove = int.Parse(cell0);
                RemoveFromDB(idToRemove);
                GridViewRefresh();
            }
        }
    }
}

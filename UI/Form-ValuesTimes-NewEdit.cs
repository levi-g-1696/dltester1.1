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
using System.Text.RegularExpressions;
using Entities;

namespace UI
{

    public delegate void ValuesTimesSaveEventHandler(string m, string f, string t);
    public delegate void ValuesTimesSaveEventHandler1(ValuesTime valuesTime, Entities.Editmode savemode);
    public delegate string ValuesTimesReadEventHandler1(int id);
    public partial class Form_ValuesTimes_NewEdit : Form
    {
       public static event ValuesTimesSaveEventHandler SaveAction;
        public static event ValuesTimesSaveEventHandler1 SaveToDB;
        public static event ValuesTimesReadEventHandler1 GetFromDBMonitorNames;
        string monitorNames;
        string monitorsFromValues;
        string monitorsToValues;
        Editmode savemode;
        Form_ValuesTimesView fatherForm;
        ValuesTime valuesTime;


        public Form_ValuesTimes_NewEdit (Editmode editmode, Form_ValuesTimesView fatherFormArg)
        {
            InitializeComponent();
            savemode = editmode;
            fatherForm = fatherFormArg;
            if (editmode == Editmode.New) // empty form
            {

                valuesTime = new ValuesTime();
                
                monitorNames = UISessionValue.MonitorList.MonitorNames;  //zagluska1
                                                                         //string monitorNames = UISessionValue.MonitorList.MonitorNames;
                                                                         //
                valuesTime.MonNames = monitorNames;
                valuesTime.MonListId = UISessionValue.MonitorList.MonListId;
                txtMonlist.Text = UISessionValue.MonitorList.MonListId + " # " + UISessionValue.MonitorList.Name;


                //  *********  fill table  ************** 
                string[] monNamesArr = monitorNames.Split(',');
                gridValTimes.Rows.Add(monNamesArr.Length);
                for (int i = 0; i < monNamesArr.Length; i++)
                {
                    gridValTimes.Rows[i].Cells[0].Value = monNamesArr[i];
                }
                //****************************************

            }
            else  // edit an exist
            {
                /* valuesTime = new ValuesTime();
                 valuesTime.MonListId = UISessionValue.MonitorList.MonListId;
                 monitorNames = UISessionValue.MonitorList.MonitorNames;  //zagluska1
                                                                          //string monitorNames = UISessionValue.MonitorList.MonitorNames;
                                                                          //
                 valuesTime.MonNames = monitorNames;
                 valuesTime.MonListId = UISessionValue.MonitorList.MonListId;*/

                var d = UISessionValue.ValTimes;
                txtMonlist.Text = UISessionValue.ValTimes.MonListId + " # " + UISessionValue.MonitorList.Name;
                txtName.Text = UISessionValue.ValTimes.Name;
                if (UISessionValue.ValTimes.DuringTime != null)
                {
                    txtDuration.Text = Math.Round((decimal)UISessionValue.ValTimes.DuringTime, 1) + "";
                }
                else txtDuration.Text = "??";

                //  *********  fill table  ************** 
                string[] monNamesArr = UISessionValue.ValTimes.MonNames.Split(',');

                string[] monValuesFrom = UISessionValue.ValTimes.MonFrom.Split(',');
                string[] monValuesTo = UISessionValue.ValTimes.MonTo.Split(',');

                gridValTimes.Rows.Add(monNamesArr.Length);
                for (int i = 0; i < monNamesArr.Length; i++)
                {
                    gridValTimes.Rows[i].Cells[0].Value = monNamesArr[i];
                }
                for (int i = 0; i < monValuesFrom.Length; i++)
                {
                    gridValTimes.Rows[i].Cells[1].Value = monValuesFrom[i];
                    gridValTimes.Rows[i].Cells[2].Value = monValuesTo[i];
                }



                //****************************************
            }






        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            monitorsFromValues = string.Empty;
            
            for (int rows = 0; rows < gridValTimes.Rows.Count; rows++)
            {


                 monitorsFromValues += gridValTimes.Rows[rows].Cells[1].Value ;
                if (rows < gridValTimes.Rows.Count-2 ) monitorsFromValues += ",";
                
            }

             monitorsToValues = string.Empty;
           
            for (int rows = 0; rows < gridValTimes.Rows.Count; rows++)
            {


                monitorsToValues += gridValTimes.Rows[rows].Cells[2].Value;
                if (rows < gridValTimes.Rows.Count - 2) monitorsToValues += ",";

            }

            //  valuesTime.DuringTime = ValidateDouble( txtDuration.Text);


            //   UISessionValue.MonitorListId = 100;


            if (UIinputValidation())
            {
               
                UISessionValue.ValTimes.Name = txtName.Text;
                UISessionValue.ValTimes.MonFrom = monitorsFromValues;
                UISessionValue.ValTimes.MonTo = monitorsToValues;
                UISessionValue.ValTimes.DuringTime = double.Parse(txtDuration.Text);
                UISessionValue.ValTimes.MonListId = UISessionValue.MonitorList.MonListId;
                 SaveToDB(UISessionValue.ValTimes, savemode);
                fatherForm.GridViewRefresh();
                this.Close();


                //   valuesTime.MonNames = GetFromDBMonitorNames((int)UISessionValue.MonitorListId);
                //     SaveAction(monitorNames, monitorsFromValues, monitorsToValues);

            }
        }
        
       private bool UIinputValidation()
        {
            double d;
            bool isValid=true;
            
            string regexName = "^([a-zA-Z][a-zA-Z0-9' ]{0,49})$";
            if (!Regex.Match(txtName.Text, regexName).Success)
            {
                txtName.BackColor = Color.Salmon;
                isValid = false;
            }
           
            if (!double.TryParse(txtDuration.Text, out d)) { 
                txtDuration.BackColor = Color.Salmon;
                isValid = false; }
            
            
           
            return isValid;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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
using System.Text.RegularExpressions;
using Entities;

namespace UI
{
    public delegate void SessionSaveEventHandler(Session s, Editmode saveMode);
    public delegate void DestinationsReadEventHandler(Destination d);

    public partial class Form_Session_NewEdit : Form
    {
        public static event SessionSaveEventHandler SaveAction;
       
        Editmode saveMode;
        Form_SessionsView fatherForm;

        public Form_Session_NewEdit(Editmode editmode, Form_SessionsView fatherFormArg)
        {
            InitializeComponent();
            saveMode = editmode;
            fatherForm = fatherFormArg;

            if (editmode == Editmode.New) // empty form
            {
                cmbExpiration.Items.Insert(0, "Select");

                mtxtNumTiming.Text = "60";
                cmbSecMinHourTiming.SelectedIndex = 0;
                cmbExpiration.SelectedIndex = 2;
                if (UISessionValue.MonitorListId < 0) { btnValSchedEdit.Visible = false; }
                txtDestination.Text = UISessionValue.Destination.DestinationId.ToString() + "-" + UISessionValue.Destination.Name;
                UISessionValue.Session.CreationDate = DateTime.Now;
                txtCreationDate.Text = UISessionValue.Session.CreationDate.Value.ToString();







            }
            else  // edit an exist
            {

                txtName.Text = UISessionValue.Session.Name;
                //---------- restore timing base -------------------------
                var timingBaseSec = UISessionValue.Session.TimingBase.Value;
                if (timingBaseSec <= 99)
                {
                    mtxtNumTiming.Text = timingBaseSec + "";
                    cmbSecMinHourTiming.Text = "sec";
                }
                else if (timingBaseSec <= 99 * 60)
                {
                    int minutes = timingBaseSec / 60;
                    mtxtNumTiming.Text = minutes + "";
                    cmbSecMinHourTiming.Text = "min";
                }
                else if (timingBaseSec <= 99 * 3600)
                {

                    int hours = timingBaseSec / 3600;
                    mtxtNumTiming.Text = hours + "";
                    cmbSecMinHourTiming.Text = "hour";
                }
                //----------------------------------------------



                //^^^^^^  restore expiration after cmbbox  ^^^^^^^^^^^^^^^^^^^^^^
                var hour = Math.Round((UISessionValue.Session.ExpirationDate.Value - UISessionValue.Session.CreationDate.Value).TotalHours);
                int selection = 0;
                switch (hour)
                {
                    case 1: { selection = 0; break;}
                            case 3: { selection =1; break; }
                    case 6: { selection = 2; break; }
                    case 12:
                        { selection = 3; break; }
                    case 24:
                        { selection = 4; break; }
                    case 36:
                        { selection = 5; break; }
                    case 48: { selection = 6; break; }
                    default:
                        MessageBox.Show("The session is expired. You can use an option to update creation date.", "",
MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }

                cmbExpiration.SelectedIndex = selection;


                // ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^666
                txtDestination.Text = UISessionValue.Destination.DestinationId + " # " + UISessionValue.Destination.Name;
                
               txtCreationDate.Text = UISessionValue.Session.CreationDate.Value.ToString();
                cmbFileType.SelectedIndex = (int) UISessionValue.Session.OutputTypeId - 1;


                UISessionValue.ValTimes.MonListId = UISessionValue.MonitorList.MonListId;
                txtDestinationRefresh();
                txtValTimesRefresh();
                txtMonListRefresh();


            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void mtxtNumTiming_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            txtName.BackColor = Color.White;
        }

        private void btnDestEdit_Click(object sender, EventArgs e)
        {
            Form_DestinationsView form_Dest = new Form_DestinationsView(this);
            form_Dest.Show();



        }

        private void btnMonListEdit_Click(object sender, EventArgs e)
        {
            Form_MonListView form_MonListView = new Form_MonListView(this);
            form_MonListView.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {



            if (UIinputValidation())
            {
                UISessionValue.Name = txtName.Text;
                UISessionValue.Session.Name = txtName.Text;
                string[] strHours = cmbExpiration.SelectedItem.ToString().Split(' ');
                int hours = int.Parse(strHours[0]);
                UISessionValue.ExpirationDate = UISessionValue.CreationDate.Value.AddHours(hours);
                UISessionValue.Session.ExpirationDate = UISessionValue.CreationDate.Value.AddHours(hours);
                UISessionValue.StartTime = dtpStartTime.Value;
                UISessionValue.Session.StartTime = dtpStartTime.Value;
                //^^^^^^^^^^^^^^^^  file type   ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^

                UISessionValue.Session.OutputTypeId = (int) cmbFileType.SelectedIndex+1;
                //^^^^^^^^^  timing base  ^^^^^^^^^^
                if (cmbSecMinHourTiming.SelectedItem == "sec")
                {
                    UISessionValue.TimingBase = int.Parse(mtxtNumTiming.Text);
                    UISessionValue.Session.TimingBase = int.Parse(mtxtNumTiming.Text);
                }
                else if (cmbSecMinHourTiming.SelectedItem == "min")
                {
                    UISessionValue.TimingBase = int.Parse(mtxtNumTiming.Text) * 60;
                    UISessionValue.Session.TimingBase = int.Parse(mtxtNumTiming.Text) * 60;
                }
                else // if "hour " was selected
                {
                    UISessionValue.TimingBase = int.Parse(mtxtNumTiming.Text) * 3600;
                    UISessionValue.Session.TimingBase = int.Parse(mtxtNumTiming.Text) * 3600;
                }
                // UISessionValue.SessionId = 9009;
                //^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
                //%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
                // fatherForm.session = new Session(txtName.Text, 21, dtpStartTime.Value, dtpStartTime.Value.AddDays(2));
                fatherForm.session.Name = txtName.Text;
                fatherForm.session.CreationDate = dtpStartTime.Value;


                // Methods.CopyPropertiesTo(UISessionValue.Destination, UISessionValue.Session.Destination);
                // Methods.CopyPropertiesTo(UISessionValue.MonitorList, UISessionValue.Session.MonitorList);
                UISessionValue.Session.MonitorListId = UISessionValue.MonitorList.MonListId;
                UISessionValue.Session.DestinationId = UISessionValue.Destination.DestinationId;
                UISessionValue.Session.ValTimesId = UISessionValue.ValTimes.ValTimesId;
                UISessionValue.Session.UserId = UISessionValue.User.UserId;
             SaveAction(UISessionValue.Session, saveMode);
                fatherForm.GridViewRefresh();
                this.Close();


            }
            else { }


            //          for
            //          cmbDestination.Items.Add(nextItem);




            //        var s = cmbDestination.SelectedItem;
            //    session.DestinationId = cmbDestination.;


        }

        private void btnValSchedEdit_Click(object sender, EventArgs e)
        {

            Form_ValuesTimesView form_ValuesTimesView = new Form_ValuesTimesView (Editmode.Edit,this);
            form_ValuesTimesView.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private bool UIinputValidation()
        {
         
            bool isValid=true;
            string regexName = "^([a-zA-Z][a-zA-Z0-9' ]{0,49})$";
            //===================  name  ==========================
            if (!Regex.Match(txtName.Text, regexName).Success)
            {
                txtName.BackColor = Color.Salmon;
                isValid = false;
            }
            else isValid = isValid&&true;
            /*          // ===  timing base =============
                      if ()
                      {
                          txtValTimes.BackColor = Color.Salmon;
                          isValid = false;
                      }   */

            //==========       MonitorList  ===================
            /*    if (UISessionValue.MonitorListId < 0)
                {
                    txtMonList.Text = "???";

                    txtMonList.BackColor = Color.Salmon;
                    isValid = false;
                }
            */
            //================ expiration ==========
            if ((cmbExpiration.SelectedIndex == 0) || (cmbExpiration.SelectedItem == null))
            {
                cmbExpiration.BackColor = Color.Salmon;
                isValid = false;
            }

            //====================  destination ============================
            if (UISessionValue.Destination.DestinationId < 0)
            {
                txtDestination.BackColor = Color.Salmon;
                isValid = false;
            }
            //+==========  values times ==============

            if (UISessionValue.ValTimes.ValTimesId < 0 || UISessionValue.ValTimes.MonListId < 0)
            {
                txtValTimes.BackColor = Color.Salmon;
                isValid = false;
            }

            else isValid = isValid && true;
            return isValid;
        }

        private void cmbExpiration_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbExpiration.Text = cmbExpiration.SelectedItem.ToString();
        }
        public void txtDestinationRefresh()
        {
            txtDestination.Text = UISessionValue.Destination.DestinationId + "-" + UISessionValue.Destination.Name;
        }

        public void txtMonListRefresh()
        {
            txtMonList.Text = UISessionValue.MonitorList.MonListId + " # " + UISessionValue.MonitorList.Name;
            if (UISessionValue.MonitorList.MonListId > 0) btnValSchedEdit.Visible = true;
        }
        public void txtValTimesRefresh()
        {
            txtValTimes.Text = UISessionValue.ValTimes.ValTimesId + " # " + UISessionValue.ValTimes.Name;
        }

        private void btnCrDate_Click(object sender, EventArgs e)
        {

        }
    }
}
;
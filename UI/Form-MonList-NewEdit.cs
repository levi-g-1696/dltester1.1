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
using Entities;
using System.Text.RegularExpressions;

       
public delegate void  MonitorListSaveEventHandler(MonitorList ml,Editmode saveMode);
namespace UI
{
    public partial class Form_MonList_NewEdit : Form
    {
        //   public List<string> monNames { get; set; }
        string monNames = "";
		 Editmode saveMode;
        Form_MonListView fatherForm;
        MonitorList monitorList = UISessionValue.MonitorList;
        public static event MonitorListSaveEventHandler SaveAction; 
        //
        //List<string> monNames = new List<string>();

        public Form_MonList_NewEdit(Editmode editmode, Form_MonListView fatherFormArg)
        {
          		  
            InitializeComponent();
            fatherForm = fatherFormArg;
			saveMode = editmode;
			if (editmode== Editmode.New) // empty form
            {
                MakeTxtBoxUnvisible();
                InitMonNames();
            
            }
            else  // edit an exist
            {
                InitMonNames();
                RestoreTextBoxes();
			
			
                
               /* txtVirPath.Text = UISessionValue.Destination.VirtualPath;
                txtUser.Text = UISessionValue.Destination.SrvUser;
                txtPassword.Text=  UISessionValue.Destination.SrvPassword ;
                txtName.Text = UISessionValue.Destination.Name ;
                txtIP.Text = UISessionValue.Destination.Ipaddress ;
                cmbPotocol.Text = UISessionValue.Destination.ProtocolType;
                txtPort.Text = UISessionValue.Destination.Port.ToString() ;
*/
            }
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
//============================================
        private void btnSave_Click(object sender, EventArgs e)
        {

            if (UIinputValidation()) {
                monitorList.Name = txtName.Text;
                int monNum = Int32.Parse(cmbNumber.Text);
                //    destination.Ipaddress = txtIP.Text;

                switch (monNum)
                {
                    case (1):
                        monNames += txtMon1.Text;

                        break;
                    case (2):
                        monNames += txtMon1.Text;
                        monNames += "," + txtMon2.Text;

                        break;
                    case (3):
                        monNames += txtMon1.Text;
                        monNames += "," + txtMon2.Text;
                        monNames += "," + txtMon3.Text;


                        break;
                    case (4):
                        monNames += txtMon1.Text;
                        monNames += "," + txtMon2.Text;
                        monNames += "," + txtMon3.Text;
                        monNames += "," + txtMon4.Text;
                        break;
                    case (5):

                        monNames += txtMon1.Text;
                        monNames += "," + txtMon2.Text;
                        monNames += "," + txtMon3.Text;
                        monNames += "," + txtMon4.Text;
                        monNames += "," + txtMon5.Text;

                        break;

                    case (6):
                        monNames += txtMon1.Text;
                        monNames += "," + txtMon2.Text;
                        monNames += "," + txtMon3.Text;
                        monNames += "," + txtMon4.Text;
                        monNames += "," + txtMon5.Text;
                        monNames += "," + txtMon6.Text;
                        break;

                }
             
                monitorList.MonitorNames = monNames;
                monitorList.Name = txtName.Text;

                SaveAction(monitorList,saveMode);
            //    UISessionValue.MonitorList = monitorList;
                fatherForm.GridViewRefresh();

                this.Close();

            };
            
        }
        private void InitMonNames()
        {
            txtMon1.Text = "mon1";
            txtMon2.Text = "mon2";
            txtMon3.Text = "mon3";
            txtMon4.Text = "mon4";
            txtMon5.Text = "mon5";
            txtMon6.Text = "mon6";
            txtMon7.Text = "mon7";
            txtMon8.Text = "mon8";
            txtMon9.Text = "mon9";
            txtMon10.Text = "mon10";
            txtMon11.Text = "mon11";
            txtMon12.Text = "mon12";
            txtMon13.Text = "mon13";
            txtMon14.Text = "mon14";
            txtMon15.Text = "mon15";
            txtMon16.Text = "mon16";
        }
        private void MakeTxtBoxUnvisible()
        {
            txtMon1.Visible = false;
            txtMon2.Visible = false;
            txtMon3.Visible = false;
            txtMon4.Visible = false;
            txtMon5.Visible = false;
            txtMon6.Visible = false;
            txtMon7.Visible = false;
            txtMon8.Visible = false;
            txtMon9.Visible = false;
            txtMon10.Visible = false;
            txtMon11.Visible = false;
            txtMon12.Visible = false;
            txtMon13.Visible = false;
            txtMon14.Visible = false;
            txtMon15.Visible = false;
            txtMon16.Visible = false;
        }
        private void lblMon3_Click(object sender, EventArgs e)
        {

        }

        private void cmbNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            int monNum = Int32.Parse(cmbNumber.Text);
            switch (monNum)
            {
                case (1):
                    MakeTxtBoxUnvisible();
                    txtMon1.Visible = true;
                   

                    break;
                case (2):
                    MakeTxtBoxUnvisible();
                    txtMon1.Visible = true;
                    txtMon2.Visible = true;
                    
                    break;
                case (3):
                    MakeTxtBoxUnvisible();
                    txtMon1.Visible = true;
                    txtMon2.Visible = true;
                    txtMon3.Visible = true;
                    

                    break;
                case (4):
                    MakeTxtBoxUnvisible();
                    txtMon1.Visible = true;
                    txtMon2.Visible = true;
                    txtMon3.Visible = true;
                    txtMon4.Visible = true;
                    
                    break;
                case (5):
                    MakeTxtBoxUnvisible();
                    txtMon1.Visible = true;
                    txtMon2.Visible = true;
                    txtMon3.Visible = true;
                    txtMon4.Visible = true;
                    txtMon5.Visible = true;
                   
                    break;
                case (6):
                    MakeTxtBoxUnvisible();
                    txtMon1.Visible = true;
                    txtMon2.Visible = true;
                    txtMon3.Visible = true;
                    txtMon4.Visible = true;
                    txtMon5.Visible = true;
                    txtMon6.Visible = true;
                    break;

            }
        }

        private void txtMon3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMon3_TextChanged_1(object sender, EventArgs e)
        {

        }
        private bool UIinputValidation()
        {
         
            bool isValid=true;
            string regexName = "^([a-zA-Z][a-zA-Z0-9' ]{0,49})$";
            if (!Regex.Match(txtName.Text, regexName).Success)
            {
                txtName.BackColor = Color.Salmon;
                isValid = false;
            }
         
            if (!Regex.Match(txtMon1.Text, regexName).Success)
            {
                txtMon1.BackColor = Color.Salmon;
                isValid = false;
            }
           
            if (!Regex.Match(txtMon2.Text, regexName).Success)
            {
                txtMon2.BackColor = Color.Salmon;
                isValid = false;
            }
           
            if (!Regex.Match(txtMon3.Text, regexName).Success)
            {
                txtMon3.BackColor = Color.Salmon;
                isValid = false;
            }
           
            if (!Regex.Match(txtMon4.Text, regexName).Success)
            {
                txtMon4.BackColor = Color.Salmon;
                isValid = false;
            }
           
            if (!Regex.Match(txtMon5.Text, regexName).Success)
            {
                txtMon5.BackColor = Color.Salmon;
                isValid = false;
            }
           
            if (!Regex.Match(txtMon6.Text, regexName).Success)
            {
                txtMon6.BackColor = Color.Salmon;
                isValid = false;
            }
         
            if (!Regex.Match(txtMon7.Text, regexName).Success)
            {
                txtMon7.BackColor = Color.Salmon;
                isValid = false;
            }
          
            if (!Regex.Match(txtMon8.Text, regexName).Success)
            {
                txtMon8.BackColor = Color.Salmon;
                isValid = false;
            }
          
            if (!Regex.Match(txtMon9.Text, regexName).Success)
            {
                txtMon9.BackColor = Color.Salmon;
                isValid = false;
            }
           
            if (!Regex.Match(txtMon9.Text, regexName).Success)
            {
                txtMon9.BackColor = Color.Salmon;
                isValid = false;
            }
           
            if (!Regex.Match(txtMon10.Text, regexName).Success)
            {
                txtMon10.BackColor = Color.Salmon;
                isValid = false;
            }
          
            if (!Regex.Match(txtMon11.Text, regexName).Success)
            {
                txtMon12.BackColor = Color.Salmon;
                isValid = false;
            }
            
            if (!Regex.Match(txtMon13.Text, regexName).Success)
            {
                txtMon13.BackColor = Color.Salmon;
                isValid = false;
            }
           
            if (!Regex.Match(txtMon14.Text, regexName).Success)
            {
                txtMon14.BackColor = Color.Salmon;
                isValid = false;
            }

          
            if (!Regex.Match(txtMon15.Text, regexName).Success)
            {
                txtMon14.BackColor = Color.Salmon;
                isValid = false;
            }

            if (!Regex.Match(txtMon16.Text, regexName).Success)
            {
                txtMon14.BackColor = Color.Salmon;
                isValid = false;
            }

           
            return isValid;
			
        }
	private void	RestoreTextBoxes(){
		string[] monList= UISessionValue.MonitorList.MonitorNames.Split(',');
            int monNum = monList.Length;
            txtName.Text = UISessionValue.MonitorList.Name;
            cmbNumber.Text = monNum.ToString();
            switch (monNum)
            {
                case (1):
                    MakeTxtBoxUnvisible();
                    txtMon1.Visible = true;
                    txtMon1.Text = monList[0];
                    

                    break;
                case (2):
                    MakeTxtBoxUnvisible();
                    txtMon1.Visible = true;
                    txtMon2.Visible = true;
                    txtMon1.Text = monList[0];
                    txtMon2.Text = monList[1];
                    
                    break;
                case (3):
                    MakeTxtBoxUnvisible();
                    txtMon1.Visible = true;
                    txtMon2.Visible = true;
                    txtMon3.Visible = true;
                    txtMon1.Text = monList[0];
                    txtMon2.Text = monList[1]; 
                    txtMon3.Text = monList[2];
                    

                    break;
                case (4):
                    MakeTxtBoxUnvisible();
                    txtMon1.Visible = true;
                    txtMon2.Visible = true;
                    txtMon3.Visible = true;
                    txtMon4.Visible = true;
                    
                    break;
                case (5):
                    MakeTxtBoxUnvisible();
                    txtMon1.Visible = true;
                    txtMon2.Visible = true;
                    txtMon3.Visible = true;
                    txtMon4.Visible = true;
                    txtMon5.Visible = true;
                    
                    break;
                case (6):
                    MakeTxtBoxUnvisible();
                    txtMon1.Visible = true;
                    txtMon2.Visible = true;
                    txtMon3.Visible = true;
                    txtMon4.Visible = true;
                    txtMon5.Visible = true;
                    txtMon6.Visible = true;
                    break;

            }
        }
    }
}

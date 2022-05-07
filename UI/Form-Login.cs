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

namespace UI
{
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (Methods.CheckLogin(txtUser.Text, txtPsw.Text)== LoginResult.OK)
            {
                var userobj = Manage.DBconnection.FindUser(txtUser.Text);
                Methods.CopyPropertiesTo(userobj, UISessionValue.User);
                Form_SessionsView form_SessionsView = new Form_SessionsView(this);
                form_SessionsView.Show();
               

                // object= find user
                // copyProp obj,  UISessionValue.User 
                // run sessions
            }
            else  if (Methods.CheckLogin(txtUser.Text, txtPsw.Text) == LoginResult.UserPswWrong)
            {
                MessageBox.Show("Username not found or wrong password !", "Wrong credentials",
    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close(); }
            else if (Methods.CheckLogin(txtUser.Text, txtPsw.Text) == LoginResult.UserAccountExpired)
            {
                MessageBox.Show("User is expired. Connect your sysadmin", " ",
    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

            //session:
            // if user is admin - all sessions
            // else only current user
        }
    }
}

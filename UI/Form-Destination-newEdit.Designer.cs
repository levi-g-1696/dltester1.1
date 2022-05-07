
namespace UI
{
    partial class Form_Destination_NewEdit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtIPaddress = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtVirPath = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.cmbPotocol = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblAuthentication = new System.Windows.Forms.Label();
            this.lblPath = new System.Windows.Forms.Label();
            this.lblPort = new System.Windows.Forms.Label();
            this.lblIPaddress = new System.Windows.Forms.Label();
            this.lblProtocol = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblNewDest = new System.Windows.Forms.Label();
            this.txtIPaddress.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtIPaddress
            // 
            this.txtIPaddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtIPaddress.Controls.Add(this.btnCancel);
            this.txtIPaddress.Controls.Add(this.btnSave);
            this.txtIPaddress.Controls.Add(this.txtPassword);
            this.txtIPaddress.Controls.Add(this.txtUser);
            this.txtIPaddress.Controls.Add(this.txtVirPath);
            this.txtIPaddress.Controls.Add(this.txtPort);
            this.txtIPaddress.Controls.Add(this.txtIP);
            this.txtIPaddress.Controls.Add(this.cmbPotocol);
            this.txtIPaddress.Controls.Add(this.txtName);
            this.txtIPaddress.Controls.Add(this.lblPassword);
            this.txtIPaddress.Controls.Add(this.lblUser);
            this.txtIPaddress.Controls.Add(this.lblAuthentication);
            this.txtIPaddress.Controls.Add(this.lblPath);
            this.txtIPaddress.Controls.Add(this.lblPort);
            this.txtIPaddress.Controls.Add(this.lblIPaddress);
            this.txtIPaddress.Controls.Add(this.lblProtocol);
            this.txtIPaddress.Controls.Add(this.lblName);
            this.txtIPaddress.Controls.Add(this.lblNewDest);
            this.txtIPaddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtIPaddress.Location = new System.Drawing.Point(0, 0);
            this.txtIPaddress.Name = "txtIPaddress";
            this.txtIPaddress.Size = new System.Drawing.Size(436, 450);
            this.txtIPaddress.TabIndex = 0;
            this.txtIPaddress.Paint += new System.Windows.Forms.PaintEventHandler(this.txtIPaddress_Paint);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(304, 396);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(97, 23);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(131, 396);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(97, 23);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(107, 339);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(317, 23);
            this.txtPassword.TabIndex = 15;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(107, 299);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(317, 23);
            this.txtUser.TabIndex = 14;
            this.txtUser.CursorChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // txtVirPath
            // 
            this.txtVirPath.Location = new System.Drawing.Point(107, 220);
            this.txtVirPath.Name = "txtVirPath";
            this.txtVirPath.Size = new System.Drawing.Size(317, 23);
            this.txtVirPath.TabIndex = 13;
            this.txtVirPath.TextChanged += new System.EventHandler(this.txtVirPath_TextChanged);
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(107, 175);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(56, 23);
            this.txtPort.TabIndex = 12;
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(107, 129);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(317, 23);
            this.txtIP.TabIndex = 11;
            // 
            // cmbPotocol
            // 
            this.cmbPotocol.FormattingEnabled = true;
            this.cmbPotocol.Items.AddRange(new object[] {
            "Sharing (SMB)",
            "FTP ",
            "SFTP"});
            this.cmbPotocol.Location = new System.Drawing.Point(107, 87);
            this.cmbPotocol.Name = "cmbPotocol";
            this.cmbPotocol.Size = new System.Drawing.Size(121, 23);
            this.cmbPotocol.TabIndex = 10;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(107, 47);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(317, 23);
            this.txtName.TabIndex = 9;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(19, 342);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(57, 15);
            this.lblPassword.TabIndex = 8;
            this.lblPassword.Text = "Password";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(16, 302);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(60, 15);
            this.lblUser.TabIndex = 7;
            this.lblUser.Text = "Username";
            // 
            // lblAuthentication
            // 
            this.lblAuthentication.AutoSize = true;
            this.lblAuthentication.Location = new System.Drawing.Point(152, 269);
            this.lblAuthentication.Name = "lblAuthentication";
            this.lblAuthentication.Size = new System.Drawing.Size(92, 15);
            this.lblAuthentication.TabIndex = 6;
            this.lblAuthentication.Text = "Authentication  ";
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(14, 223);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(68, 15);
            this.lblPath.TabIndex = 5;
            this.lblPath.Text = "Virtual Path";
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(14, 178);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(29, 15);
            this.lblPort.TabIndex = 4;
            this.lblPort.Text = "Port";
            // 
            // lblIPaddress
            // 
            this.lblIPaddress.AutoSize = true;
            this.lblIPaddress.Location = new System.Drawing.Point(14, 132);
            this.lblIPaddress.Name = "lblIPaddress";
            this.lblIPaddress.Size = new System.Drawing.Size(62, 15);
            this.lblIPaddress.TabIndex = 3;
            this.lblIPaddress.Text = "IP Address";
            // 
            // lblProtocol
            // 
            this.lblProtocol.AutoSize = true;
            this.lblProtocol.Location = new System.Drawing.Point(13, 90);
            this.lblProtocol.Name = "lblProtocol";
            this.lblProtocol.Size = new System.Drawing.Size(55, 15);
            this.lblProtocol.TabIndex = 2;
            this.lblProtocol.Text = "Protocol ";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(13, 50);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(39, 15);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // lblNewDest
            // 
            this.lblNewDest.AutoSize = true;
            this.lblNewDest.Location = new System.Drawing.Point(13, 13);
            this.lblNewDest.Name = "lblNewDest";
            this.lblNewDest.Size = new System.Drawing.Size(150, 15);
            this.lblNewDest.TabIndex = 0;
            this.lblNewDest.Text = "Configure New Destination";
            // 
            // Form_Destination_NewEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 450);
            this.Controls.Add(this.txtIPaddress);
            this.Name = "Form_Destination_NewEdit";
            this.Text = "Form_Destination_NewEdit";
            this.txtIPaddress.ResumeLayout(false);
            this.txtIPaddress.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel txtIPaddress;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtVirPath;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.ComboBox cmbPotocol;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblAuthentication;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.Label lblIPaddress;
        private System.Windows.Forms.Label lblProtocol;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblNewDest;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
    }
}

namespace UI
{
    partial class Form_Session_NewEdit
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCreationDate = new System.Windows.Forms.TextBox();
            this.txtValTimes = new System.Windows.Forms.TextBox();
            this.txtMonList = new System.Windows.Forms.TextBox();
            this.txtDestination = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnValSchedEdit = new System.Windows.Forms.Button();
            this.btnMonListEdit = new System.Windows.Forms.Button();
            this.btnDestEdit = new System.Windows.Forms.Button();
            this.mtxtNumTiming = new System.Windows.Forms.MaskedTextBox();
            this.dtpStartTime = new System.Windows.Forms.DateTimePicker();
            this.cmbFileType = new System.Windows.Forms.ComboBox();
            this.cmbSecMinHourTiming = new System.Windows.Forms.ComboBox();
            this.cmbExpiration = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblDateValue = new System.Windows.Forms.Label();
            this.lblFileType = new System.Windows.Forms.Label();
            this.lblValSched = new System.Windows.Forms.Label();
            this.lblMonitorList = new System.Windows.Forms.Label();
            this.lblTimingBase = new System.Windows.Forms.Label();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.lblDestination = new System.Windows.Forms.Label();
            this.lblExpiration = new System.Windows.Forms.Label();
            this.lblCreationDate = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPanelName = new System.Windows.Forms.Label();
            this.btnCrDate = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.btnCrDate);
            this.panel1.Controls.Add(this.txtCreationDate);
            this.panel1.Controls.Add(this.txtValTimes);
            this.panel1.Controls.Add(this.txtMonList);
            this.panel1.Controls.Add(this.txtDestination);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnValSchedEdit);
            this.panel1.Controls.Add(this.btnMonListEdit);
            this.panel1.Controls.Add(this.btnDestEdit);
            this.panel1.Controls.Add(this.mtxtNumTiming);
            this.panel1.Controls.Add(this.dtpStartTime);
            this.panel1.Controls.Add(this.cmbFileType);
            this.panel1.Controls.Add(this.cmbSecMinHourTiming);
            this.panel1.Controls.Add(this.cmbExpiration);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.lblDateValue);
            this.panel1.Controls.Add(this.lblFileType);
            this.panel1.Controls.Add(this.lblValSched);
            this.panel1.Controls.Add(this.lblMonitorList);
            this.panel1.Controls.Add(this.lblTimingBase);
            this.panel1.Controls.Add(this.lblStartTime);
            this.panel1.Controls.Add(this.lblDestination);
            this.panel1.Controls.Add(this.lblExpiration);
            this.panel1.Controls.Add(this.lblCreationDate);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.lblPanelName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(501, 478);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtCreationDate
            // 
            this.txtCreationDate.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtCreationDate.Location = new System.Drawing.Point(133, 97);
            this.txtCreationDate.Name = "txtCreationDate";
            this.txtCreationDate.ReadOnly = true;
            this.txtCreationDate.Size = new System.Drawing.Size(272, 23);
            this.txtCreationDate.TabIndex = 30;
            // 
            // txtValTimes
            // 
            this.txtValTimes.Location = new System.Drawing.Point(133, 327);
            this.txtValTimes.Name = "txtValTimes";
            this.txtValTimes.Size = new System.Drawing.Size(272, 23);
            this.txtValTimes.TabIndex = 28;
            // 
            // txtMonList
            // 
            this.txtMonList.Location = new System.Drawing.Point(133, 288);
            this.txtMonList.Name = "txtMonList";
            this.txtMonList.Size = new System.Drawing.Size(272, 23);
            this.txtMonList.TabIndex = 27;
            // 
            // txtDestination
            // 
            this.txtDestination.Location = new System.Drawing.Point(133, 172);
            this.txtDestination.Name = "txtDestination";
            this.txtDestination.Size = new System.Drawing.Size(272, 23);
            this.txtDestination.TabIndex = 26;
            this.txtDestination.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(159, 426);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(95, 23);
            this.btnSave.TabIndex = 25;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(345, 426);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(95, 23);
            this.btnCancel.TabIndex = 24;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnValSchedEdit
            // 
            this.btnValSchedEdit.Location = new System.Drawing.Point(420, 327);
            this.btnValSchedEdit.Name = "btnValSchedEdit";
            this.btnValSchedEdit.Size = new System.Drawing.Size(63, 23);
            this.btnValSchedEdit.TabIndex = 22;
            this.btnValSchedEdit.Text = "...";
            this.btnValSchedEdit.UseVisualStyleBackColor = true;
            this.btnValSchedEdit.Click += new System.EventHandler(this.btnValSchedEdit_Click);
            // 
            // btnMonListEdit
            // 
            this.btnMonListEdit.Location = new System.Drawing.Point(420, 288);
            this.btnMonListEdit.Name = "btnMonListEdit";
            this.btnMonListEdit.Size = new System.Drawing.Size(63, 23);
            this.btnMonListEdit.TabIndex = 21;
            this.btnMonListEdit.Text = "...";
            this.btnMonListEdit.UseVisualStyleBackColor = true;
            this.btnMonListEdit.Click += new System.EventHandler(this.btnMonListEdit_Click);
            // 
            // btnDestEdit
            // 
            this.btnDestEdit.Location = new System.Drawing.Point(420, 172);
            this.btnDestEdit.Name = "btnDestEdit";
            this.btnDestEdit.Size = new System.Drawing.Size(63, 23);
            this.btnDestEdit.TabIndex = 20;
            this.btnDestEdit.Text = "...";
            this.btnDestEdit.UseVisualStyleBackColor = true;
            this.btnDestEdit.Click += new System.EventHandler(this.btnDestEdit_Click);
            // 
            // mtxtNumTiming
            // 
            this.mtxtNumTiming.Location = new System.Drawing.Point(133, 251);
            this.mtxtNumTiming.Mask = "00";
            this.mtxtNumTiming.Name = "mtxtNumTiming";
            this.mtxtNumTiming.Size = new System.Drawing.Size(49, 23);
            this.mtxtNumTiming.TabIndex = 19;
            this.mtxtNumTiming.ValidatingType = typeof(int);
            this.mtxtNumTiming.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtxtNumTiming_MaskInputRejected);
            // 
            // dtpStartTime
            // 
            this.dtpStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpStartTime.Location = new System.Drawing.Point(133, 208);
            this.dtpStartTime.Name = "dtpStartTime";
            this.dtpStartTime.Size = new System.Drawing.Size(121, 23);
            this.dtpStartTime.TabIndex = 18;
            // 
            // cmbFileType
            // 
            this.cmbFileType.FormattingEnabled = true;
            this.cmbFileType.Items.AddRange(new object[] {
            "csv",
            "json"});
            this.cmbFileType.Location = new System.Drawing.Point(133, 369);
            this.cmbFileType.Name = "cmbFileType";
            this.cmbFileType.Size = new System.Drawing.Size(121, 23);
            this.cmbFileType.TabIndex = 17;
            // 
            // cmbSecMinHourTiming
            // 
            this.cmbSecMinHourTiming.FormattingEnabled = true;
            this.cmbSecMinHourTiming.Items.AddRange(new object[] {
            "sec",
            "min",
            "hour"});
            this.cmbSecMinHourTiming.Location = new System.Drawing.Point(189, 251);
            this.cmbSecMinHourTiming.Name = "cmbSecMinHourTiming";
            this.cmbSecMinHourTiming.Size = new System.Drawing.Size(65, 23);
            this.cmbSecMinHourTiming.TabIndex = 14;
            // 
            // cmbExpiration
            // 
            this.cmbExpiration.FormattingEnabled = true;
            this.cmbExpiration.Items.AddRange(new object[] {
            "1   hour",
            "3   hours",
            "6   hours",
            "12 hours",
            "24 hours",
            "36 hours",
            "48 hours"});
            this.cmbExpiration.Location = new System.Drawing.Point(133, 134);
            this.cmbExpiration.Name = "cmbExpiration";
            this.cmbExpiration.Size = new System.Drawing.Size(121, 23);
            this.cmbExpiration.TabIndex = 12;
            this.cmbExpiration.SelectedIndexChanged += new System.EventHandler(this.cmbExpiration_SelectedIndexChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(133, 60);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(350, 23);
            this.txtName.TabIndex = 11;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // lblDateValue
            // 
            this.lblDateValue.AutoSize = true;
            this.lblDateValue.Location = new System.Drawing.Point(133, 100);
            this.lblDateValue.Name = "lblDateValue";
            this.lblDateValue.Size = new System.Drawing.Size(0, 15);
            this.lblDateValue.TabIndex = 10;
            // 
            // lblFileType
            // 
            this.lblFileType.AutoSize = true;
            this.lblFileType.Location = new System.Drawing.Point(12, 372);
            this.lblFileType.Name = "lblFileType";
            this.lblFileType.Size = new System.Drawing.Size(93, 15);
            this.lblFileType.TabIndex = 9;
            this.lblFileType.Text = "Output File Type";
            // 
            // lblValSched
            // 
            this.lblValSched.AutoSize = true;
            this.lblValSched.Location = new System.Drawing.Point(12, 331);
            this.lblValSched.Name = "lblValSched";
            this.lblValSched.Size = new System.Drawing.Size(102, 15);
            this.lblValSched.TabIndex = 8;
            this.lblValSched.Text = "Values Scheduling";
            // 
            // lblMonitorList
            // 
            this.lblMonitorList.AutoSize = true;
            this.lblMonitorList.Location = new System.Drawing.Point(12, 292);
            this.lblMonitorList.Name = "lblMonitorList";
            this.lblMonitorList.Size = new System.Drawing.Size(71, 15);
            this.lblMonitorList.TabIndex = 7;
            this.lblMonitorList.Text = "Monitor List";
            // 
            // lblTimingBase
            // 
            this.lblTimingBase.AutoSize = true;
            this.lblTimingBase.Location = new System.Drawing.Point(12, 254);
            this.lblTimingBase.Name = "lblTimingBase";
            this.lblTimingBase.Size = new System.Drawing.Size(71, 15);
            this.lblTimingBase.TabIndex = 6;
            this.lblTimingBase.Text = "Timing Base";
            // 
            // lblStartTime
            // 
            this.lblStartTime.AutoSize = true;
            this.lblStartTime.Location = new System.Drawing.Point(12, 214);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(60, 15);
            this.lblStartTime.TabIndex = 5;
            this.lblStartTime.Text = "Start Time";
            // 
            // lblDestination
            // 
            this.lblDestination.AutoSize = true;
            this.lblDestination.Location = new System.Drawing.Point(12, 175);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(67, 15);
            this.lblDestination.TabIndex = 4;
            this.lblDestination.Text = "Destination";
            // 
            // lblExpiration
            // 
            this.lblExpiration.AutoSize = true;
            this.lblExpiration.Location = new System.Drawing.Point(12, 137);
            this.lblExpiration.Name = "lblExpiration";
            this.lblExpiration.Size = new System.Drawing.Size(87, 15);
            this.lblExpiration.TabIndex = 3;
            this.lblExpiration.Text = "Expiration after";
            // 
            // lblCreationDate
            // 
            this.lblCreationDate.AutoSize = true;
            this.lblCreationDate.Location = new System.Drawing.Point(12, 100);
            this.lblCreationDate.Name = "lblCreationDate";
            this.lblCreationDate.Size = new System.Drawing.Size(79, 15);
            this.lblCreationDate.TabIndex = 2;
            this.lblCreationDate.Text = "Creation Date";
            this.lblCreationDate.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 63);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(39, 15);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // lblPanelName
            // 
            this.lblPanelName.AutoSize = true;
            this.lblPanelName.Location = new System.Drawing.Point(12, 19);
            this.lblPanelName.Name = "lblPanelName";
            this.lblPanelName.Size = new System.Drawing.Size(110, 15);
            this.lblPanelName.TabIndex = 0;
            this.lblPanelName.Text = "Create New Session";
            // 
            // btnCrDate
            // 
            this.btnCrDate.Location = new System.Drawing.Point(420, 96);
            this.btnCrDate.Name = "btnCrDate";
            this.btnCrDate.Size = new System.Drawing.Size(63, 23);
            this.btnCrDate.TabIndex = 31;
            this.btnCrDate.Text = "Update";
            this.btnCrDate.UseVisualStyleBackColor = true;
            this.btnCrDate.Click += new System.EventHandler(this.btnCrDate_Click);
            // 
            // Form_Session_NewEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 478);
            this.Controls.Add(this.panel1);
            this.Name = "Form_Session_NewEdit";
            this.Text = "Form_Session_NewEdit";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MaskedTextBox mtxtNumTiming;
        private System.Windows.Forms.DateTimePicker dtpStartTime;
        private System.Windows.Forms.ComboBox cmbFileType;
        private System.Windows.Forms.ComboBox cmbValSched;
        private System.Windows.Forms.ComboBox cmbMonitorList;
        private System.Windows.Forms.ComboBox cmbSecMinHourTiming;
        private System.Windows.Forms.ComboBox cmbDestination;
        private System.Windows.Forms.ComboBox cmbExpiration;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblDateValue;
        private System.Windows.Forms.Label lblFileType;
        private System.Windows.Forms.Label lblValSched;
        private System.Windows.Forms.Label lblMonitorList;
        private System.Windows.Forms.Label lblTimingBase;
        private System.Windows.Forms.Label lblStartTime;
        private System.Windows.Forms.Label lblDestination;
        private System.Windows.Forms.Label lblExpiration;
        private System.Windows.Forms.Label lblCreationDate;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPanelName;
        private System.Windows.Forms.Button btnValSchedEdit;
        private System.Windows.Forms.Button btnMonListEdit;
        private System.Windows.Forms.Button btnDestEdit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtValTimes;
        private System.Windows.Forms.TextBox txtMonList;
        private System.Windows.Forms.TextBox txtDestination;
        private System.Windows.Forms.TextBox txtCreationDate;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnCrDate;
    }
}

namespace UI
{
    partial class Form_ValuesTimes_NewEdit
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
            this.lblMin = new System.Windows.Forms.Label();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.txtMonlist = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblDuration = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.gridValTimes = new System.Windows.Forms.DataGridView();
            this.clMonitor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clFromVal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clToVal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCreateHeader = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridValTimes)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.lblMin);
            this.panel1.Controls.Add(this.txtDuration);
            this.panel1.Controls.Add(this.txtMonlist);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.lblDuration);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.gridValTimes);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.lblCreateHeader);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(401, 525);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Location = new System.Drawing.Point(163, 122);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(28, 15);
            this.lblMin.TabIndex = 10;
            this.lblMin.Text = "min";
            // 
            // txtDuration
            // 
            this.txtDuration.Location = new System.Drawing.Point(107, 119);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(50, 23);
            this.txtDuration.TabIndex = 9;
            // 
            // txtMonlist
            // 
            this.txtMonlist.Location = new System.Drawing.Point(107, 86);
            this.txtMonlist.Name = "txtMonlist";
            this.txtMonlist.Size = new System.Drawing.Size(215, 23);
            this.txtMonlist.TabIndex = 8;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(107, 51);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(215, 23);
            this.txtName.TabIndex = 7;
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Location = new System.Drawing.Point(24, 122);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(53, 15);
            this.lblDuration.TabIndex = 6;
            this.lblDuration.Text = "Duration";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(235, 471);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(47, 471);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // gridValTimes
            // 
            this.gridValTimes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridValTimes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clMonitor,
            this.clFromVal,
            this.clToVal});
            this.gridValTimes.Location = new System.Drawing.Point(24, 160);
            this.gridValTimes.Name = "gridValTimes";
            this.gridValTimes.RowTemplate.Height = 25;
            this.gridValTimes.Size = new System.Drawing.Size(345, 282);
            this.gridValTimes.TabIndex = 3;
            this.gridValTimes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // clMonitor
            // 
            this.clMonitor.HeaderText = "Monitor";
            this.clMonitor.Name = "clMonitor";
            // 
            // clFromVal
            // 
            this.clFromVal.HeaderText = "From Value";
            this.clFromVal.Name = "clFromVal";
            // 
            // clToVal
            // 
            this.clToVal.HeaderText = "To Value";
            this.clToVal.Name = "clToVal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Monitor List";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(24, 54);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(39, 15);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // lblCreateHeader
            // 
            this.lblCreateHeader.AutoSize = true;
            this.lblCreateHeader.Location = new System.Drawing.Point(24, 13);
            this.lblCreateHeader.Name = "lblCreateHeader";
            this.lblCreateHeader.Size = new System.Drawing.Size(120, 15);
            this.lblCreateHeader.TabIndex = 0;
            this.lblCreateHeader.Text = "Create new values list";
            // 
            // Form_ValuesTimes_NewEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 525);
            this.Controls.Add(this.panel1);
            this.Name = "Form_ValuesTimes_NewEdit";
            this.Text = "Form_ValuesTimes_NewEdit";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridValTimes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView gridValTimes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCreateHeader;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.TextBox txtMonlist;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMonitor;
        private System.Windows.Forms.DataGridViewTextBoxColumn clFromVal;
        private System.Windows.Forms.DataGridViewTextBoxColumn clToVal;
    }
}
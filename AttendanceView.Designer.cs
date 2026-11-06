namespace EMS
{
    partial class AttendanceView
    {
        private void InitializeComponent()
        {
            this.pnlActions = new System.Windows.Forms.Panel();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.cboEmployee = new System.Windows.Forms.ComboBox();
            this.btnOnTime = new System.Windows.Forms.Button();
            this.btnLate = new System.Windows.Forms.Button();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.btnLeave = new System.Windows.Forms.Button();
            this.btnAbsent = new System.Windows.Forms.Button();
            this.lblMsg = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.dgvAttendance = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendance)).BeginInit();
            this.pnlActions.SuspendLayout();
            this.SuspendLayout();
            // pnlActions
            this.pnlActions.Name = "pnlActions";
            this.pnlActions.TabIndex = 0;
            this.pnlActions.BackColor = System.Drawing.Color.White;
            this.pnlActions.Location = new System.Drawing.Point(24, 20);
            this.pnlActions.Size = new System.Drawing.Size(845, 110);
            this.pnlActions.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
            this.pnlActions.Controls.Add(this.lblEmployee);
            this.pnlActions.Controls.Add(this.cboEmployee);
            this.pnlActions.Controls.Add(this.btnOnTime);
            this.pnlActions.Controls.Add(this.btnLate);
            this.pnlActions.Controls.Add(this.btnCheckOut);
            this.pnlActions.Controls.Add(this.btnLeave);
            this.pnlActions.Controls.Add(this.btnAbsent);
            this.pnlActions.Controls.Add(this.lblMsg);
            // lblEmployee
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.TabIndex = 0;
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEmployee.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.lblEmployee.Location = new System.Drawing.Point(16, 12);
            this.lblEmployee.Text = "EMPLOYEE";
            // cboEmployee
            this.cboEmployee.Name = "cboEmployee";
            this.cboEmployee.TabIndex = 1;
            this.cboEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEmployee.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboEmployee.Location = new System.Drawing.Point(16, 34);
            this.cboEmployee.Size = new System.Drawing.Size(280, 28);
            // btnOnTime
            this.btnOnTime.Name = "btnOnTime";
            this.btnOnTime.TabIndex = 2;
            this.btnOnTime.BackColor = System.Drawing.Color.FromArgb(0, 48, 135);
            this.btnOnTime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOnTime.FlatAppearance.BorderSize = 0;
            this.btnOnTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOnTime.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOnTime.ForeColor = System.Drawing.Color.White;
            this.btnOnTime.Location = new System.Drawing.Point(320, 28);
            this.btnOnTime.Size = new System.Drawing.Size(100, 38);
            this.btnOnTime.Text = "On Time";
            this.btnOnTime.UseVisualStyleBackColor = false;
            this.btnOnTime.Click += new System.EventHandler(this.btnOnTime_Click);
            // btnLate
            this.btnLate.Name = "btnLate";
            this.btnLate.TabIndex = 3;
            this.btnLate.BackColor = System.Drawing.Color.White;
            this.btnLate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(0, 48, 135);
            this.btnLate.FlatAppearance.BorderSize = 1;
            this.btnLate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLate.ForeColor = System.Drawing.Color.FromArgb(0, 48, 135);
            this.btnLate.Location = new System.Drawing.Point(428, 28);
            this.btnLate.Size = new System.Drawing.Size(90, 38);
            this.btnLate.Text = "Late";
            this.btnLate.UseVisualStyleBackColor = false;
            this.btnLate.Click += new System.EventHandler(this.btnLate_Click);
            // btnCheckOut
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.TabIndex = 4;
            this.btnCheckOut.BackColor = System.Drawing.Color.White;
            this.btnCheckOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheckOut.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(0, 48, 135);
            this.btnCheckOut.FlatAppearance.BorderSize = 1;
            this.btnCheckOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckOut.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCheckOut.ForeColor = System.Drawing.Color.FromArgb(0, 48, 135);
            this.btnCheckOut.Location = new System.Drawing.Point(526, 28);
            this.btnCheckOut.Size = new System.Drawing.Size(100, 38);
            this.btnCheckOut.Text = "Check Out";
            this.btnCheckOut.UseVisualStyleBackColor = false;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // btnLeave
            this.btnLeave.Name = "btnLeave";
            this.btnLeave.TabIndex = 5;
            this.btnLeave.BackColor = System.Drawing.Color.White;
            this.btnLeave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLeave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(0, 48, 135);
            this.btnLeave.FlatAppearance.BorderSize = 1;
            this.btnLeave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeave.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLeave.ForeColor = System.Drawing.Color.FromArgb(0, 48, 135);
            this.btnLeave.Location = new System.Drawing.Point(634, 28);
            this.btnLeave.Size = new System.Drawing.Size(100, 38);
            this.btnLeave.Text = "On Leave";
            this.btnLeave.UseVisualStyleBackColor = false;
            this.btnLeave.Click += new System.EventHandler(this.btnLeave_Click);
            // btnAbsent
            this.btnAbsent.Name = "btnAbsent";
            this.btnAbsent.TabIndex = 6;
            this.btnAbsent.BackColor = System.Drawing.Color.White;
            this.btnAbsent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbsent.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(0, 48, 135);
            this.btnAbsent.FlatAppearance.BorderSize = 1;
            this.btnAbsent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbsent.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAbsent.ForeColor = System.Drawing.Color.FromArgb(0, 48, 135);
            this.btnAbsent.Location = new System.Drawing.Point(742, 28);
            this.btnAbsent.Size = new System.Drawing.Size(90, 38);
            this.btnAbsent.Text = "Absent";
            this.btnAbsent.UseVisualStyleBackColor = false;
            this.btnAbsent.Click += new System.EventHandler(this.btnAbsent_Click);
            // lblMsg
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.TabIndex = 7;
            this.lblMsg.AutoSize = true;
            this.lblMsg.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMsg.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            this.lblMsg.Location = new System.Drawing.Point(16, 80);
            this.lblMsg.Text = "";
            // lblDate
            this.lblDate.Name = "lblDate";
            this.lblDate.TabIndex = 1;
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            this.lblDate.Location = new System.Drawing.Point(24, 152);
            this.lblDate.Text = "DATE";
            // dtpDate
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.TabIndex = 2;
            this.dtpDate.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(70, 147);
            this.dtpDate.Size = new System.Drawing.Size(150, 27);
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // dgvAttendance
            this.dgvAttendance.Name = "dgvAttendance";
            this.dgvAttendance.TabIndex = 3;
            this.dgvAttendance.AllowUserToAddRows = false;
            this.dgvAttendance.AllowUserToDeleteRows = false;
            this.dgvAttendance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAttendance.BackgroundColor = System.Drawing.Color.White;
            this.dgvAttendance.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
            this.dgvAttendance.Location = new System.Drawing.Point(24, 186);
            this.dgvAttendance.ReadOnly = true;
            this.dgvAttendance.RowHeadersVisible = false;
            this.dgvAttendance.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAttendance.Size = new System.Drawing.Size(845, 340);
            // AttendanceView
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            // AttendanceView
            this.Name = "AttendanceView";
            this.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.Size = new System.Drawing.Size(900, 540);
            this.Controls.Add(this.pnlActions);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.dgvAttendance);
            this.Load += new System.EventHandler(this.AttendanceView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendance)).EndInit();
            this.pnlActions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Panel pnlActions;
        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.ComboBox cboEmployee;
        private System.Windows.Forms.Button btnOnTime;
        private System.Windows.Forms.Button btnLate;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.Button btnLeave;
        private System.Windows.Forms.Button btnAbsent;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.DataGridView dgvAttendance;
    }
}

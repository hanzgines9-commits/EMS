namespace EMS
{
    partial class EmployeeDialog
    {
        private void InitializeComponent()
        {
            this.lblFirst = new System.Windows.Forms.Label();
            this.txtFirst = new System.Windows.Forms.TextBox();
            this.lblLast = new System.Windows.Forms.Label();
            this.txtLast = new System.Windows.Forms.TextBox();
            this.lblDept = new System.Windows.Forms.Label();
            this.cboDept = new System.Windows.Forms.ComboBox();
            this.lblPosition = new System.Windows.Forms.Label();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // lblFirst
            this.lblFirst.Name = "lblFirst";
            this.lblFirst.TabIndex = 0;
            this.lblFirst.AutoSize = true;
            this.lblFirst.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFirst.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.lblFirst.Location = new System.Drawing.Point(24, 20);
            this.lblFirst.Text = "FIRST NAME";
            // txtFirst
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.TabIndex = 1;
            this.txtFirst.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFirst.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFirst.Location = new System.Drawing.Point(24, 42);
            this.txtFirst.Size = new System.Drawing.Size(360, 27);
            // lblLast
            this.lblLast.Name = "lblLast";
            this.lblLast.TabIndex = 2;
            this.lblLast.AutoSize = true;
            this.lblLast.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLast.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.lblLast.Location = new System.Drawing.Point(24, 84);
            this.lblLast.Text = "LAST NAME";
            // txtLast
            this.txtLast.Name = "txtLast";
            this.txtLast.TabIndex = 3;
            this.txtLast.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLast.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLast.Location = new System.Drawing.Point(24, 106);
            this.txtLast.Size = new System.Drawing.Size(360, 27);
            // lblDept
            this.lblDept.Name = "lblDept";
            this.lblDept.TabIndex = 4;
            this.lblDept.AutoSize = true;
            this.lblDept.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDept.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.lblDept.Location = new System.Drawing.Point(24, 148);
            this.lblDept.Text = "DEPARTMENT";
            // cboDept
            this.cboDept.Name = "cboDept";
            this.cboDept.TabIndex = 5;
            this.cboDept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDept.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboDept.Location = new System.Drawing.Point(24, 170);
            this.cboDept.Size = new System.Drawing.Size(360, 28);
            // lblPosition
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.TabIndex = 6;
            this.lblPosition.AutoSize = true;
            this.lblPosition.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPosition.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.lblPosition.Location = new System.Drawing.Point(24, 212);
            this.lblPosition.Text = "POSITION";
            // txtPosition
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.TabIndex = 7;
            this.txtPosition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPosition.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPosition.Location = new System.Drawing.Point(24, 234);
            this.txtPosition.Size = new System.Drawing.Size(360, 27);
            // btnSave
            this.btnSave.Name = "btnSave";
            this.btnSave.TabIndex = 8;
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(0, 48, 135);
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(24, 290);
            this.btnSave.Size = new System.Drawing.Size(170, 38);
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // btnCancel
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.TabIndex = 9;
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(0, 48, 135);
            this.btnCancel.FlatAppearance.BorderSize = 1;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(0, 48, 135);
            this.btnCancel.Location = new System.Drawing.Point(214, 290);
            this.btnCancel.Size = new System.Drawing.Size(170, 38);
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            // EmployeeDialog
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            // EmployeeDialog
            this.Name = "EmployeeDialog";
            this.AcceptButton = this.btnSave;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(408, 352);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Employee";
            this.Controls.Add(this.lblFirst);
            this.Controls.Add(this.txtFirst);
            this.Controls.Add(this.lblLast);
            this.Controls.Add(this.txtLast);
            this.Controls.Add(this.lblDept);
            this.Controls.Add(this.cboDept);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.txtPosition);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblFirst;
        private System.Windows.Forms.TextBox txtFirst;
        private System.Windows.Forms.Label lblLast;
        private System.Windows.Forms.TextBox txtLast;
        private System.Windows.Forms.Label lblDept;
        private System.Windows.Forms.ComboBox cboDept;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}

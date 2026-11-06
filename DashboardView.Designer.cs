namespace EMS
{
    partial class DashboardView
    {
        private void InitializeComponent()
        {
            this.pnlTotal = new System.Windows.Forms.Panel();
            this.lblTotalTitle = new System.Windows.Forms.Label();
            this.lblTotalValue = new System.Windows.Forms.Label();
            this.pnlPresent = new System.Windows.Forms.Panel();
            this.lblPresentTitle = new System.Windows.Forms.Label();
            this.lblPresentValue = new System.Windows.Forms.Label();
            this.pnlLeave = new System.Windows.Forms.Panel();
            this.lblLeaveTitle = new System.Windows.Forms.Label();
            this.lblLeaveValue = new System.Windows.Forms.Label();
            this.pnlLate = new System.Windows.Forms.Panel();
            this.lblLateTitle = new System.Windows.Forms.Label();
            this.lblLateValue = new System.Windows.Forms.Label();
            this.lblRecent = new System.Windows.Forms.Label();
            this.cboPeriod = new System.Windows.Forms.ComboBox();
            this.dgvRank = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRank)).BeginInit();
            this.pnlTotal.SuspendLayout();
            this.pnlPresent.SuspendLayout();
            this.pnlLeave.SuspendLayout();
            this.pnlLate.SuspendLayout();
            this.SuspendLayout();
            // pnlTotal
            this.pnlTotal.Name = "pnlTotal";
            this.pnlTotal.TabIndex = 0;
            this.pnlTotal.BackColor = System.Drawing.Color.White;
            this.pnlTotal.Location = new System.Drawing.Point(24, 20);
            this.pnlTotal.Size = new System.Drawing.Size(200, 92);
            this.pnlTotal.Controls.Add(this.lblTotalTitle);
            this.pnlTotal.Controls.Add(this.lblTotalValue);
            // lblTotalTitle
            this.lblTotalTitle.Name = "lblTotalTitle";
            this.lblTotalTitle.TabIndex = 0;
            this.lblTotalTitle.AutoSize = true;
            this.lblTotalTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalTitle.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.lblTotalTitle.Location = new System.Drawing.Point(14, 12);
            this.lblTotalTitle.Text = "TOTAL EMPLOYEES";
            // lblTotalValue
            this.lblTotalValue.Name = "lblTotalValue";
            this.lblTotalValue.TabIndex = 1;
            this.lblTotalValue.AutoSize = true;
            this.lblTotalValue.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalValue.ForeColor = System.Drawing.Color.FromArgb(0, 48, 135);
            this.lblTotalValue.Location = new System.Drawing.Point(14, 36);
            this.lblTotalValue.Text = "0";
            // pnlPresent
            this.pnlPresent.Name = "pnlPresent";
            this.pnlPresent.TabIndex = 1;
            this.pnlPresent.BackColor = System.Drawing.Color.White;
            this.pnlPresent.Location = new System.Drawing.Point(239, 20);
            this.pnlPresent.Size = new System.Drawing.Size(200, 92);
            this.pnlPresent.Controls.Add(this.lblPresentTitle);
            this.pnlPresent.Controls.Add(this.lblPresentValue);
            // lblPresentTitle
            this.lblPresentTitle.Name = "lblPresentTitle";
            this.lblPresentTitle.TabIndex = 0;
            this.lblPresentTitle.AutoSize = true;
            this.lblPresentTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPresentTitle.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.lblPresentTitle.Location = new System.Drawing.Point(14, 12);
            this.lblPresentTitle.Text = "PRESENT TODAY";
            // lblPresentValue
            this.lblPresentValue.Name = "lblPresentValue";
            this.lblPresentValue.TabIndex = 1;
            this.lblPresentValue.AutoSize = true;
            this.lblPresentValue.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPresentValue.ForeColor = System.Drawing.Color.FromArgb(16, 185, 129);
            this.lblPresentValue.Location = new System.Drawing.Point(14, 36);
            this.lblPresentValue.Text = "0";
            // pnlLeave
            this.pnlLeave.Name = "pnlLeave";
            this.pnlLeave.TabIndex = 2;
            this.pnlLeave.BackColor = System.Drawing.Color.White;
            this.pnlLeave.Location = new System.Drawing.Point(454, 20);
            this.pnlLeave.Size = new System.Drawing.Size(200, 92);
            this.pnlLeave.Controls.Add(this.lblLeaveTitle);
            this.pnlLeave.Controls.Add(this.lblLeaveValue);
            // lblLeaveTitle
            this.lblLeaveTitle.Name = "lblLeaveTitle";
            this.lblLeaveTitle.TabIndex = 0;
            this.lblLeaveTitle.AutoSize = true;
            this.lblLeaveTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLeaveTitle.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.lblLeaveTitle.Location = new System.Drawing.Point(14, 12);
            this.lblLeaveTitle.Text = "ON LEAVE TODAY";
            // lblLeaveValue
            this.lblLeaveValue.Name = "lblLeaveValue";
            this.lblLeaveValue.TabIndex = 1;
            this.lblLeaveValue.AutoSize = true;
            this.lblLeaveValue.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLeaveValue.ForeColor = System.Drawing.Color.FromArgb(245, 158, 11);
            this.lblLeaveValue.Location = new System.Drawing.Point(14, 36);
            this.lblLeaveValue.Text = "0";
            // pnlLate
            this.pnlLate.Name = "pnlLate";
            this.pnlLate.TabIndex = 3;
            this.pnlLate.BackColor = System.Drawing.Color.White;
            this.pnlLate.Location = new System.Drawing.Point(669, 20);
            this.pnlLate.Size = new System.Drawing.Size(200, 92);
            this.pnlLate.Controls.Add(this.lblLateTitle);
            this.pnlLate.Controls.Add(this.lblLateValue);
            // lblLateTitle
            this.lblLateTitle.Name = "lblLateTitle";
            this.lblLateTitle.TabIndex = 0;
            this.lblLateTitle.AutoSize = true;
            this.lblLateTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLateTitle.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.lblLateTitle.Location = new System.Drawing.Point(14, 12);
            this.lblLateTitle.Text = "LATE TODAY";
            // lblLateValue
            this.lblLateValue.Name = "lblLateValue";
            this.lblLateValue.TabIndex = 1;
            this.lblLateValue.AutoSize = true;
            this.lblLateValue.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLateValue.ForeColor = System.Drawing.Color.FromArgb(245, 158, 11);
            this.lblLateValue.Location = new System.Drawing.Point(14, 36);
            this.lblLateValue.Text = "0";
            // lblRecent
            this.lblRecent.Name = "lblRecent";
            this.lblRecent.TabIndex = 4;
            this.lblRecent.AutoSize = true;
            this.lblRecent.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRecent.ForeColor = System.Drawing.Color.FromArgb(0, 48, 135);
            this.lblRecent.Location = new System.Drawing.Point(24, 135);
            this.lblRecent.Text = "Employee Performance (best on top)";
            // cboPeriod
            this.cboPeriod.Name = "cboPeriod";
            this.cboPeriod.TabIndex = 5;
            this.cboPeriod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPeriod.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboPeriod.Location = new System.Drawing.Point(719, 131);
            this.cboPeriod.Size = new System.Drawing.Size(150, 28);
            this.cboPeriod.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            this.cboPeriod.Items.AddRange(new object[] { "This Month", "This Year", "All Time" });
            this.cboPeriod.SelectedIndexChanged += new System.EventHandler(this.cboPeriod_SelectedIndexChanged);
            // dgvRank
            this.dgvRank.Name = "dgvRank";
            this.dgvRank.TabIndex = 6;
            this.dgvRank.AllowUserToAddRows = false;
            this.dgvRank.AllowUserToDeleteRows = false;
            this.dgvRank.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRank.BackgroundColor = System.Drawing.Color.White;
            this.dgvRank.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
            this.dgvRank.Location = new System.Drawing.Point(24, 170);
            this.dgvRank.ReadOnly = true;
            this.dgvRank.RowHeadersVisible = false;
            this.dgvRank.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRank.Size = new System.Drawing.Size(845, 370);
            // DashboardView
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            // DashboardView
            this.Name = "DashboardView";
            this.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.Size = new System.Drawing.Size(900, 560);
            this.Controls.Add(this.pnlTotal);
            this.Controls.Add(this.pnlPresent);
            this.Controls.Add(this.pnlLeave);
            this.Controls.Add(this.pnlLate);
            this.Controls.Add(this.lblRecent);
            this.Controls.Add(this.cboPeriod);
            this.Controls.Add(this.dgvRank);
            this.Load += new System.EventHandler(this.DashboardView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRank)).EndInit();
            this.pnlTotal.ResumeLayout(false);
            this.pnlPresent.ResumeLayout(false);
            this.pnlLeave.ResumeLayout(false);
            this.pnlLate.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Panel pnlTotal;
        private System.Windows.Forms.Label lblTotalTitle;
        private System.Windows.Forms.Label lblTotalValue;
        private System.Windows.Forms.Panel pnlPresent;
        private System.Windows.Forms.Label lblPresentTitle;
        private System.Windows.Forms.Label lblPresentValue;
        private System.Windows.Forms.Panel pnlLeave;
        private System.Windows.Forms.Label lblLeaveTitle;
        private System.Windows.Forms.Label lblLeaveValue;
        private System.Windows.Forms.Panel pnlLate;
        private System.Windows.Forms.Label lblLateTitle;
        private System.Windows.Forms.Label lblLateValue;
        private System.Windows.Forms.Label lblRecent;
        private System.Windows.Forms.ComboBox cboPeriod;
        private System.Windows.Forms.DataGridView dgvRank;
    }
}

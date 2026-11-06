namespace EMS
{
    partial class AuditView
    {
        private void InitializeComponent()
        {
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dgvAudit = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAudit)).BeginInit();
            this.SuspendLayout();
            // btnRefresh
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.BackColor = System.Drawing.Color.White;
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(0, 48, 135);
            this.btnRefresh.FlatAppearance.BorderSize = 1;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRefresh.ForeColor = System.Drawing.Color.FromArgb(0, 48, 135);
            this.btnRefresh.Location = new System.Drawing.Point(24, 20);
            this.btnRefresh.Size = new System.Drawing.Size(110, 38);
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // dgvAudit
            this.dgvAudit.Name = "dgvAudit";
            this.dgvAudit.TabIndex = 1;
            this.dgvAudit.AllowUserToAddRows = false;
            this.dgvAudit.AllowUserToDeleteRows = false;
            this.dgvAudit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAudit.BackgroundColor = System.Drawing.Color.White;
            this.dgvAudit.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
            this.dgvAudit.Location = new System.Drawing.Point(24, 72);
            this.dgvAudit.ReadOnly = true;
            this.dgvAudit.RowHeadersVisible = false;
            this.dgvAudit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAudit.Size = new System.Drawing.Size(845, 440);
            // AuditView
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            // AuditView
            this.Name = "AuditView";
            this.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.Size = new System.Drawing.Size(900, 540);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dgvAudit);
            this.Load += new System.EventHandler(this.AuditView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAudit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dgvAudit;
    }
}

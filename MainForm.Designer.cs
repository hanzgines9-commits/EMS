namespace EMS
{
    partial class MainForm
    {
        private void InitializeComponent()
        {
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblAvatar = new System.Windows.Forms.Label();
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblSideLogo = new System.Windows.Forms.Label();
            this.lblSideSub = new System.Windows.Forms.Label();
            this.btnNavDashboard = new System.Windows.Forms.Button();
            this.btnNavEmployees = new System.Windows.Forms.Button();
            this.btnNavAttendance = new System.Windows.Forms.Button();
            this.btnNavReports = new System.Windows.Forms.Button();
            this.btnNavUsers = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.pnlSidebar.SuspendLayout();
            this.SuspendLayout();
            // pnlContent
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.TabIndex = 0;
            this.pnlContent.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(220, 60);
            this.pnlContent.Size = new System.Drawing.Size(880, 620);
            // pnlHeader
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.TabIndex = 1;
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(220, 0);
            this.pnlHeader.Size = new System.Drawing.Size(880, 60);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.lblUserName);
            this.pnlHeader.Controls.Add(this.lblAvatar);
            // lblTitle
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.TabIndex = 0;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(0, 48, 135);
            this.lblTitle.Location = new System.Drawing.Point(24, 16);
            this.lblTitle.Text = "Dashboard Overview";
            // lblUserName
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.TabIndex = 1;
            this.lblUserName.AutoSize = false;
            this.lblUserName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUserName.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            this.lblUserName.Location = new System.Drawing.Point(624, 12);
            this.lblUserName.Size = new System.Drawing.Size(200, 36);
            this.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblUserName.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            this.lblUserName.Text = "Administrator";
            // lblAvatar
            this.lblAvatar.Name = "lblAvatar";
            this.lblAvatar.TabIndex = 2;
            this.lblAvatar.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            this.lblAvatar.AutoSize = false;
            this.lblAvatar.BackColor = System.Drawing.Color.FromArgb(0, 48, 135);
            this.lblAvatar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAvatar.ForeColor = System.Drawing.Color.White;
            this.lblAvatar.Location = new System.Drawing.Point(832, 12);
            this.lblAvatar.Size = new System.Drawing.Size(36, 36);
            this.lblAvatar.Text = "AD";
            this.lblAvatar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // pnlSidebar
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.TabIndex = 2;
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(11, 31, 75);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Size = new System.Drawing.Size(220, 680);
            this.pnlSidebar.Controls.Add(this.btnLogout);
            this.pnlSidebar.Controls.Add(this.lblSideLogo);
            this.pnlSidebar.Controls.Add(this.lblSideSub);
            this.pnlSidebar.Controls.Add(this.btnNavDashboard);
            this.pnlSidebar.Controls.Add(this.btnNavEmployees);
            this.pnlSidebar.Controls.Add(this.btnNavAttendance);
            this.pnlSidebar.Controls.Add(this.btnNavReports);
            this.pnlSidebar.Controls.Add(this.btnNavUsers);
            // btnLogout
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.TabIndex = 0;
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(11, 31, 75);
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogout.ForeColor = System.Drawing.Color.FromArgb(252, 165, 165);
            this.btnLogout.Location = new System.Drawing.Point(0, 632);
            this.btnLogout.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnLogout.Size = new System.Drawing.Size(220, 48);
            this.btnLogout.Text = "Log Out";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // lblSideLogo
            this.lblSideLogo.Name = "lblSideLogo";
            this.lblSideLogo.TabIndex = 1;
            this.lblSideLogo.AutoSize = true;
            this.lblSideLogo.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSideLogo.ForeColor = System.Drawing.Color.White;
            this.lblSideLogo.Location = new System.Drawing.Point(20, 18);
            this.lblSideLogo.Text = "EMS";
            // lblSideSub
            this.lblSideSub.Name = "lblSideSub";
            this.lblSideSub.TabIndex = 2;
            this.lblSideSub.AutoSize = true;
            this.lblSideSub.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSideSub.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.lblSideSub.Location = new System.Drawing.Point(22, 54);
            this.lblSideSub.Text = "Monitoring System";
            // btnNavDashboard
            this.btnNavDashboard.Name = "btnNavDashboard";
            this.btnNavDashboard.TabIndex = 3;
            this.btnNavDashboard.BackColor = System.Drawing.Color.FromArgb(11, 31, 75);
            this.btnNavDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavDashboard.FlatAppearance.BorderSize = 0;
            this.btnNavDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavDashboard.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNavDashboard.ForeColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.btnNavDashboard.Location = new System.Drawing.Point(0, 90);
            this.btnNavDashboard.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnNavDashboard.Size = new System.Drawing.Size(220, 44);
            this.btnNavDashboard.Tag = "Dashboard";
            this.btnNavDashboard.Text = "Dashboard";
            this.btnNavDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavDashboard.UseVisualStyleBackColor = false;
            this.btnNavDashboard.Click += new System.EventHandler(this.Nav_Click);
            // btnNavEmployees
            this.btnNavEmployees.Name = "btnNavEmployees";
            this.btnNavEmployees.TabIndex = 4;
            this.btnNavEmployees.BackColor = System.Drawing.Color.FromArgb(11, 31, 75);
            this.btnNavEmployees.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavEmployees.FlatAppearance.BorderSize = 0;
            this.btnNavEmployees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavEmployees.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNavEmployees.ForeColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.btnNavEmployees.Location = new System.Drawing.Point(0, 136);
            this.btnNavEmployees.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnNavEmployees.Size = new System.Drawing.Size(220, 44);
            this.btnNavEmployees.Tag = "Employees";
            this.btnNavEmployees.Text = "Employee Records";
            this.btnNavEmployees.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavEmployees.UseVisualStyleBackColor = false;
            this.btnNavEmployees.Click += new System.EventHandler(this.Nav_Click);
            // btnNavAttendance
            this.btnNavAttendance.Name = "btnNavAttendance";
            this.btnNavAttendance.TabIndex = 5;
            this.btnNavAttendance.BackColor = System.Drawing.Color.FromArgb(11, 31, 75);
            this.btnNavAttendance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavAttendance.FlatAppearance.BorderSize = 0;
            this.btnNavAttendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavAttendance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNavAttendance.ForeColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.btnNavAttendance.Location = new System.Drawing.Point(0, 182);
            this.btnNavAttendance.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnNavAttendance.Size = new System.Drawing.Size(220, 44);
            this.btnNavAttendance.Tag = "Attendance";
            this.btnNavAttendance.Text = "Attendance";
            this.btnNavAttendance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavAttendance.UseVisualStyleBackColor = false;
            this.btnNavAttendance.Click += new System.EventHandler(this.Nav_Click);
            // btnNavReports
            this.btnNavReports.Name = "btnNavReports";
            this.btnNavReports.TabIndex = 6;
            this.btnNavReports.BackColor = System.Drawing.Color.FromArgb(11, 31, 75);
            this.btnNavReports.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavReports.FlatAppearance.BorderSize = 0;
            this.btnNavReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavReports.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNavReports.ForeColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.btnNavReports.Location = new System.Drawing.Point(0, 228);
            this.btnNavReports.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnNavReports.Size = new System.Drawing.Size(220, 44);
            this.btnNavReports.Tag = "Reports";
            this.btnNavReports.Text = "Reports";
            this.btnNavReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavReports.UseVisualStyleBackColor = false;
            this.btnNavReports.Click += new System.EventHandler(this.Nav_Click);
            // btnNavUsers
            this.btnNavUsers.Name = "btnNavUsers";
            this.btnNavUsers.TabIndex = 7;
            this.btnNavUsers.BackColor = System.Drawing.Color.FromArgb(11, 31, 75);
            this.btnNavUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavUsers.FlatAppearance.BorderSize = 0;
            this.btnNavUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavUsers.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNavUsers.ForeColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.btnNavUsers.Location = new System.Drawing.Point(0, 274);
            this.btnNavUsers.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnNavUsers.Size = new System.Drawing.Size(220, 44);
            this.btnNavUsers.Tag = "Users";
            this.btnNavUsers.Text = "User Management";
            this.btnNavUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavUsers.UseVisualStyleBackColor = false;
            this.btnNavUsers.Click += new System.EventHandler(this.Nav_Click);
            // MainForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            // MainForm
            this.Name = "MainForm";
            this.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.ClientSize = new System.Drawing.Size(1100, 680);
            this.MinimumSize = new System.Drawing.Size(1016, 640);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Monitoring System";
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlSidebar);
            this.pnlHeader.ResumeLayout(false);
            this.pnlSidebar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblAvatar;
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblSideLogo;
        private System.Windows.Forms.Label lblSideSub;
        private System.Windows.Forms.Button btnNavDashboard;
        private System.Windows.Forms.Button btnNavEmployees;
        private System.Windows.Forms.Button btnNavAttendance;
        private System.Windows.Forms.Button btnNavReports;
        private System.Windows.Forms.Button btnNavUsers;
    }
}

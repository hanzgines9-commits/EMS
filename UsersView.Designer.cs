namespace EMS
{
    partial class UsersView
    {
        private void InitializeComponent()
        {
            this.pnlNewUser = new System.Windows.Forms.Panel();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.cboRole = new System.Windows.Forms.ComboBox();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.pnlNewUser.SuspendLayout();
            this.SuspendLayout();
            // pnlNewUser
            this.pnlNewUser.Name = "pnlNewUser";
            this.pnlNewUser.TabIndex = 0;
            this.pnlNewUser.BackColor = System.Drawing.Color.White;
            this.pnlNewUser.Location = new System.Drawing.Point(24, 20);
            this.pnlNewUser.Size = new System.Drawing.Size(845, 90);
            this.pnlNewUser.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
            this.pnlNewUser.Controls.Add(this.lblUsername);
            this.pnlNewUser.Controls.Add(this.txtUsername);
            this.pnlNewUser.Controls.Add(this.lblPassword);
            this.pnlNewUser.Controls.Add(this.txtPassword);
            this.pnlNewUser.Controls.Add(this.lblRole);
            this.pnlNewUser.Controls.Add(this.cboRole);
            this.pnlNewUser.Controls.Add(this.btnAddUser);
            this.pnlNewUser.Controls.Add(this.btnDeleteUser);
            // lblUsername
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.TabIndex = 0;
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUsername.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.lblUsername.Location = new System.Drawing.Point(16, 12);
            this.lblUsername.Text = "USERNAME";
            // txtUsername
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.TabIndex = 1;
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUsername.Location = new System.Drawing.Point(16, 34);
            this.txtUsername.Size = new System.Drawing.Size(200, 27);
            // lblPassword
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.TabIndex = 2;
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.lblPassword.Location = new System.Drawing.Point(232, 12);
            this.lblPassword.Text = "PASSWORD";
            // txtPassword
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.TabIndex = 3;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPassword.Location = new System.Drawing.Point(232, 34);
            this.txtPassword.Size = new System.Drawing.Size(200, 27);
            this.txtPassword.UseSystemPasswordChar = true;
            // lblRole
            this.lblRole.Name = "lblRole";
            this.lblRole.TabIndex = 4;
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRole.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.lblRole.Location = new System.Drawing.Point(448, 12);
            this.lblRole.Text = "ROLE";
            // cboRole
            this.cboRole.Name = "cboRole";
            this.cboRole.TabIndex = 5;
            this.cboRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRole.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboRole.Location = new System.Drawing.Point(448, 34);
            this.cboRole.Size = new System.Drawing.Size(140, 28);
            this.cboRole.Items.AddRange(new object[] { "admin", "encoder" });
            // btnAddUser
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.TabIndex = 6;
            this.btnAddUser.BackColor = System.Drawing.Color.FromArgb(0, 48, 135);
            this.btnAddUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddUser.FlatAppearance.BorderSize = 0;
            this.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUser.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddUser.ForeColor = System.Drawing.Color.White;
            this.btnAddUser.Location = new System.Drawing.Point(610, 28);
            this.btnAddUser.Size = new System.Drawing.Size(100, 38);
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.UseVisualStyleBackColor = false;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // btnDeleteUser
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.TabIndex = 7;
            this.btnDeleteUser.BackColor = System.Drawing.Color.White;
            this.btnDeleteUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteUser.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(0, 48, 135);
            this.btnDeleteUser.FlatAppearance.BorderSize = 1;
            this.btnDeleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteUser.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteUser.ForeColor = System.Drawing.Color.FromArgb(0, 48, 135);
            this.btnDeleteUser.Location = new System.Drawing.Point(720, 28);
            this.btnDeleteUser.Size = new System.Drawing.Size(110, 38);
            this.btnDeleteUser.Text = "Delete Selected";
            this.btnDeleteUser.UseVisualStyleBackColor = false;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // dgvUsers
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.TabIndex = 1;
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsers.BackgroundColor = System.Drawing.Color.White;
            this.dgvUsers.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
            this.dgvUsers.Location = new System.Drawing.Point(24, 126);
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.RowHeadersVisible = false;
            this.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsers.Size = new System.Drawing.Size(845, 390);
            // UsersView
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            // UsersView
            this.Name = "UsersView";
            this.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.Size = new System.Drawing.Size(900, 540);
            this.Controls.Add(this.pnlNewUser);
            this.Controls.Add(this.dgvUsers);
            this.Load += new System.EventHandler(this.UsersView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.pnlNewUser.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Panel pnlNewUser;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.ComboBox cboRole;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.DataGridView dgvUsers;
    }
}

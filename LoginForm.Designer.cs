namespace EMS
{
    partial class LoginForm
    {
        private void InitializeComponent()
        {
            this.pnlForm = new System.Windows.Forms.Panel();
            this.lblSignIn = new System.Windows.Forms.Label();
            this.lblSub = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.lblForgot = new System.Windows.Forms.Label();
            this.pnlBrand = new System.Windows.Forms.Panel();
            this.lblLogo = new System.Windows.Forms.Label();
            this.lblBrand = new System.Windows.Forms.Label();
            this.lblBrand2 = new System.Windows.Forms.Label();
            this.lblTag = new System.Windows.Forms.Label();
            this.pnlForm.SuspendLayout();
            this.pnlBrand.SuspendLayout();
            this.SuspendLayout();
            // pnlForm
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.TabIndex = 0;
            this.pnlForm.BackColor = System.Drawing.Color.White;
            this.pnlForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlForm.Location = new System.Drawing.Point(380, 0);
            this.pnlForm.Size = new System.Drawing.Size(440, 500);
            this.pnlForm.Controls.Add(this.lblSignIn);
            this.pnlForm.Controls.Add(this.lblSub);
            this.pnlForm.Controls.Add(this.lblUser);
            this.pnlForm.Controls.Add(this.txtUser);
            this.pnlForm.Controls.Add(this.lblPass);
            this.pnlForm.Controls.Add(this.txtPass);
            this.pnlForm.Controls.Add(this.btnLogin);
            this.pnlForm.Controls.Add(this.lblError);
            this.pnlForm.Controls.Add(this.lblForgot);
            // lblSignIn
            this.lblSignIn.Name = "lblSignIn";
            this.lblSignIn.TabIndex = 0;
            this.lblSignIn.AutoSize = true;
            this.lblSignIn.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSignIn.ForeColor = System.Drawing.Color.FromArgb(0, 48, 135);
            this.lblSignIn.Location = new System.Drawing.Point(42, 70);
            this.lblSignIn.Text = "Sign In";
            // lblSub
            this.lblSub.Name = "lblSub";
            this.lblSub.TabIndex = 1;
            this.lblSub.AutoSize = true;
            this.lblSub.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSub.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            this.lblSub.Location = new System.Drawing.Point(44, 120);
            this.lblSub.Text = "Enter your credentials to access the dashboard.";
            // lblUser
            this.lblUser.Name = "lblUser";
            this.lblUser.TabIndex = 2;
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUser.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.lblUser.Location = new System.Drawing.Point(44, 170);
            this.lblUser.Text = "USERNAME";
            // txtUser
            this.txtUser.Name = "txtUser";
            this.txtUser.TabIndex = 3;
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUser.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUser.Location = new System.Drawing.Point(44, 192);
            this.txtUser.Size = new System.Drawing.Size(340, 27);
            this.txtUser.PlaceholderText = "Enter username";
            // lblPass
            this.lblPass.Name = "lblPass";
            this.lblPass.TabIndex = 4;
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPass.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.lblPass.Location = new System.Drawing.Point(44, 240);
            this.lblPass.Text = "PASSWORD";
            // txtPass
            this.txtPass.Name = "txtPass";
            this.txtPass.TabIndex = 5;
            this.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPass.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPass.Location = new System.Drawing.Point(44, 262);
            this.txtPass.Size = new System.Drawing.Size(340, 27);
            this.txtPass.PlaceholderText = "Enter password";
            this.txtPass.UseSystemPasswordChar = true;
            // btnLogin
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.TabIndex = 6;
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(0, 48, 135);
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(44, 320);
            this.btnLogin.Size = new System.Drawing.Size(340, 42);
            this.btnLogin.Text = "LOG IN";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // lblError
            this.lblError.Name = "lblError";
            this.lblError.TabIndex = 7;
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblError.ForeColor = System.Drawing.Color.FromArgb(239, 68, 68);
            this.lblError.Location = new System.Drawing.Point(44, 374);
            this.lblError.Text = "";
            // lblForgot
            this.lblForgot.Name = "lblForgot";
            this.lblForgot.TabIndex = 8;
            this.lblForgot.AutoSize = true;
            this.lblForgot.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblForgot.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.lblForgot.Location = new System.Drawing.Point(44, 440);
            this.lblForgot.Text = "Forgot password? Contact the system administrator.";
            // pnlBrand
            this.pnlBrand.Name = "pnlBrand";
            this.pnlBrand.TabIndex = 1;
            this.pnlBrand.BackColor = System.Drawing.Color.FromArgb(0, 48, 135);
            this.pnlBrand.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlBrand.Location = new System.Drawing.Point(0, 0);
            this.pnlBrand.Size = new System.Drawing.Size(380, 500);
            this.pnlBrand.Controls.Add(this.lblLogo);
            this.pnlBrand.Controls.Add(this.lblBrand);
            this.pnlBrand.Controls.Add(this.lblBrand2);
            this.pnlBrand.Controls.Add(this.lblTag);
            // lblLogo
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.TabIndex = 0;
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLogo.ForeColor = System.Drawing.Color.White;
            this.lblLogo.Location = new System.Drawing.Point(40, 150);
            this.lblLogo.Text = "EMS";
            // lblBrand
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.TabIndex = 1;
            this.lblBrand.AutoSize = true;
            this.lblBrand.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBrand.ForeColor = System.Drawing.Color.White;
            this.lblBrand.Location = new System.Drawing.Point(40, 238);
            this.lblBrand.Text = "Employee Monitoring\r\nSystem";
            // lblBrand2
            this.lblBrand2.Name = "lblBrand2";
            this.lblBrand2.TabIndex = 2;
            this.lblBrand2.AutoSize = true;
            this.lblBrand2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBrand2.ForeColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.lblBrand2.Location = new System.Drawing.Point(40, 318);
            this.lblBrand2.Text = "with Integrated Database";
            // lblTag
            this.lblTag.Name = "lblTag";
            this.lblTag.TabIndex = 3;
            this.lblTag.AutoSize = true;
            this.lblTag.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTag.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.lblTag.Location = new System.Drawing.Point(40, 440);
            this.lblTag.Text = "Secure \u00B7 Reliable \u00B7 Efficient";
            // LoginForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            // LoginForm
            this.Name = "LoginForm";
            this.AcceptButton = this.btnLogin;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(820, 500);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Monitoring System - Login";
            this.Controls.Add(this.pnlForm);
            this.Controls.Add(this.pnlBrand);
            this.pnlForm.ResumeLayout(false);
            this.pnlBrand.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Panel pnlForm;
        private System.Windows.Forms.Label lblSignIn;
        private System.Windows.Forms.Label lblSub;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblForgot;
        private System.Windows.Forms.Panel pnlBrand;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblBrand2;
        private System.Windows.Forms.Label lblTag;
    }
}

namespace Giaolang.FAP.V2.StudentMgt
{
    partial class Login
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
            label1 = new Label();
            lblUsername = new Label();
            txtUsername = new TextBox();
            btnLogin = new Button();
            lblPassword = new Label();
            txtPassword = new TextBox();
            grbForm = new GroupBox();
            grbForm.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(97, 44);
            label1.Name = "label1";
            label1.Size = new Size(570, 38);
            label1.TabIndex = 0;
            label1.Text = "Welcome to Student Management System";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(60, 38);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(75, 20);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(160, 31);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(169, 27);
            txtUsername.TabIndex = 0;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(255, 192, 192);
            btnLogin.Location = new Point(171, 155);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(136, 41);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += Authenticate;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(60, 95);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(70, 20);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(160, 88);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(169, 27);
            txtPassword.TabIndex = 1;
            // 
            // grbForm
            // 
            grbForm.BackColor = Color.FromArgb(128, 255, 128);
            grbForm.Controls.Add(txtPassword);
            grbForm.Controls.Add(lblPassword);
            grbForm.Controls.Add(btnLogin);
            grbForm.Controls.Add(txtUsername);
            grbForm.Controls.Add(lblUsername);
            grbForm.Location = new Point(162, 103);
            grbForm.Name = "grbForm";
            grbForm.Size = new Size(434, 211);
            grbForm.TabIndex = 6;
            grbForm.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(780, 394);
            Controls.Add(grbForm);
            Controls.Add(label1);
            Name = "Login";
            Text = "Login";
            grbForm.ResumeLayout(false);
            grbForm.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblUsername;
        private TextBox txtUsername;
        private Button btnLogin;
        private Label lblPassword;
        private TextBox txtPassword;
        private GroupBox grbForm;
    }
}
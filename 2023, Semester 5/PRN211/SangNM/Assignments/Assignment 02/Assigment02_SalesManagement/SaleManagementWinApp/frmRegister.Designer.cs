namespace SaleManagementWinApp
{
    partial class frmRegister
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
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            tbEmail = new System.Windows.Forms.TextBox();
            tbCity = new System.Windows.Forms.TextBox();
            tbCountry = new System.Windows.Forms.TextBox();
            tbPassword = new System.Windows.Forms.TextBox();
            tbRePassword = new System.Windows.Forms.TextBox();
            btnRegister = new System.Windows.Forms.Button();
            label8 = new System.Windows.Forms.Label();
            linkLogin = new System.Windows.Forms.LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(263, 32);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(74, 23);
            label1.TabIndex = 0;
            label1.Text = "FUStore";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Stencil", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(180, 81);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(253, 32);
            label2.TabIndex = 1;
            label2.Text = "Create account";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(140, 161);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(46, 20);
            label3.TabIndex = 2;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(140, 315);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(70, 20);
            label4.TabIndex = 3;
            label4.Text = "Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(140, 368);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(95, 20);
            label5.TabIndex = 4;
            label5.Text = "Re-password";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(140, 212);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(34, 20);
            label6.TabIndex = 5;
            label6.Text = "City";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(140, 263);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(60, 20);
            label7.TabIndex = 6;
            label7.Text = "Country";
            // 
            // tbEmail
            // 
            tbEmail.Location = new System.Drawing.Point(263, 158);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new System.Drawing.Size(204, 27);
            tbEmail.TabIndex = 7;
            // 
            // tbCity
            // 
            tbCity.Location = new System.Drawing.Point(263, 209);
            tbCity.Name = "tbCity";
            tbCity.Size = new System.Drawing.Size(204, 27);
            tbCity.TabIndex = 8;
            // 
            // tbCountry
            // 
            tbCountry.Location = new System.Drawing.Point(263, 256);
            tbCountry.Name = "tbCountry";
            tbCountry.Size = new System.Drawing.Size(204, 27);
            tbCountry.TabIndex = 9;
            // 
            // tbPassword
            // 
            tbPassword.Location = new System.Drawing.Point(263, 312);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new System.Drawing.Size(204, 27);
            tbPassword.TabIndex = 10;
            tbPassword.UseSystemPasswordChar = true;
            // 
            // tbRePassword
            // 
            tbRePassword.Location = new System.Drawing.Point(263, 368);
            tbRePassword.Name = "tbRePassword";
            tbRePassword.Size = new System.Drawing.Size(204, 27);
            tbRePassword.TabIndex = 11;
            tbRePassword.UseSystemPasswordChar = true;
            // 
            // btnRegister
            // 
            btnRegister.Location = new System.Drawing.Point(263, 443);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new System.Drawing.Size(94, 29);
            btnRegister.TabIndex = 12;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += createAccount;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(189, 518);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(178, 20);
            label8.TabIndex = 13;
            label8.Text = "Already have an account?";
            // 
            // linkLogin
            // 
            linkLogin.AutoSize = true;
            linkLogin.Location = new System.Drawing.Point(373, 518);
            linkLogin.Name = "linkLogin";
            linkLogin.Size = new System.Drawing.Size(46, 20);
            linkLogin.TabIndex = 14;
            linkLogin.TabStop = true;
            linkLogin.Text = "Login";
            linkLogin.Click += goToLogin;
            // 
            // frmRegister
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(636, 578);
            Controls.Add(linkLogin);
            Controls.Add(label8);
            Controls.Add(btnRegister);
            Controls.Add(tbRePassword);
            Controls.Add(tbPassword);
            Controls.Add(tbCountry);
            Controls.Add(tbCity);
            Controls.Add(tbEmail);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmRegister";
            Text = "frmRegister";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbCity;
        private System.Windows.Forms.TextBox tbCountry;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbRePassword;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.LinkLabel linkLogin;
    }
}
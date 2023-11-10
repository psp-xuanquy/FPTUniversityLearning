namespace SalesWinApp
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new System.Windows.Forms.Label();
            txtEmail = new System.Windows.Forms.TextBox();
            txtPassword = new System.Windows.Forms.TextBox();
            btLogin = new System.Windows.Forms.Button();
            btReset = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(148, 52);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(224, 54);
            label1.TabIndex = 0;
            label1.Text = "Login Form";
            // 
            // txtEmail
            // 
            txtEmail.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtEmail.Location = new System.Drawing.Point(85, 134);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Your Email";
            txtEmail.Size = new System.Drawing.Size(331, 36);
            txtEmail.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtPassword.Location = new System.Drawing.Point(85, 183);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Your Password";
            txtPassword.Size = new System.Drawing.Size(331, 36);
            txtPassword.TabIndex = 2;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btLogin
            // 
            btLogin.DialogResult = System.Windows.Forms.DialogResult.OK;
            btLogin.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btLogin.Location = new System.Drawing.Point(112, 257);
            btLogin.Name = "btLogin";
            btLogin.Size = new System.Drawing.Size(106, 51);
            btLogin.TabIndex = 3;
            btLogin.Text = "&Login";
            btLogin.UseVisualStyleBackColor = true;
            btLogin.Click += btLogin_Click;
            // 
            // btReset
            // 
            btReset.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btReset.Location = new System.Drawing.Point(283, 257);
            btReset.Name = "btReset";
            btReset.Size = new System.Drawing.Size(106, 51);
            btReset.TabIndex = 4;
            btReset.Text = "&Reset";
            btReset.UseVisualStyleBackColor = true;
            btReset.Click += btReset_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(476, 403);
            Controls.Add(btReset);
            Controls.Add(btLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(label1);
            Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Margin = new System.Windows.Forms.Padding(4);
            Name = "Login";
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "frmLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.Button btReset;
    }
}

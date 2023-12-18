namespace BookStore_DaoXuanQuy
{
    partial class LoginForm
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
            btnLogin = new Button();
            txtEmail = new TextBox();
            lblEmail = new Label();
            txtPassword = new TextBox();
            lblPassword = new Label();
            gbLoginForm = new GroupBox();
            btnCancel = new Button();
            lblSignIn = new Label();
            gbLoginForm.SuspendLayout();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.ScrollBar;
            btnLogin.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogin.Location = new Point(144, 253);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(103, 44);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Sign in";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(144, 133);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(271, 27);
            txtEmail.TabIndex = 0;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmail.Location = new Point(39, 136);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(51, 20);
            lblEmail.TabIndex = 10;
            lblEmail.Text = "Email";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(144, 188);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = 'x';
            txtPassword.Size = new Size(271, 27);
            txtPassword.TabIndex = 1;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblPassword.Location = new Point(39, 195);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(83, 20);
            lblPassword.TabIndex = 13;
            lblPassword.Text = "Password";
            // 
            // gbLoginForm
            // 
            gbLoginForm.BackColor = SystemColors.Control;
            gbLoginForm.Controls.Add(btnCancel);
            gbLoginForm.Controls.Add(lblSignIn);
            gbLoginForm.Controls.Add(txtPassword);
            gbLoginForm.Controls.Add(btnLogin);
            gbLoginForm.Controls.Add(lblPassword);
            gbLoginForm.Controls.Add(txtEmail);
            gbLoginForm.Controls.Add(lblEmail);
            gbLoginForm.FlatStyle = FlatStyle.Flat;
            gbLoginForm.Location = new Point(1, 2);
            gbLoginForm.Name = "gbLoginForm";
            gbLoginForm.Size = new Size(497, 360);
            gbLoginForm.TabIndex = 16;
            gbLoginForm.TabStop = false;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = SystemColors.ScrollBar;
            btnCancel.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancel.Location = new Point(318, 253);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(97, 44);
            btnCancel.TabIndex = 18;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblSignIn
            // 
            lblSignIn.AutoSize = true;
            lblSignIn.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point);
            lblSignIn.Location = new Point(211, 23);
            lblSignIn.Name = "lblSignIn";
            lblSignIn.Size = new Size(120, 50);
            lblSignIn.TabIndex = 17;
            lblSignIn.Text = "Login";
            // 
            // LoginForm
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(497, 362);
            Controls.Add(gbLoginForm);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            gbLoginForm.ResumeLayout(false);
            gbLoginForm.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnLogin;
        private TextBox txtEmail;
        private Label lblEmail;
        private TextBox txtPassword;
        private Label lblPassword;
        private GroupBox gbLoginForm;
        private Label lblSignIn;
        private Button btnCancel;
    }
}
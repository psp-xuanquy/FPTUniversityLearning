namespace BookManagement_HoangNgocTrinh
{
    partial class LoginForm
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
            grbAccountInfo = new GroupBox();
            btnCancel = new Button();
            txtPassword = new TextBox();
            btnLogin = new Button();
            txtEmail = new TextBox();
            lblPassword = new Label();
            lblEmail = new Label();
            lblHeader = new Label();
            grbAccountInfo.SuspendLayout();
            SuspendLayout();
            // 
            // grbAccountInfo
            // 
            grbAccountInfo.BackColor = Color.FromArgb(0, 192, 0);
            grbAccountInfo.Controls.Add(btnCancel);
            grbAccountInfo.Controls.Add(txtPassword);
            grbAccountInfo.Controls.Add(btnLogin);
            grbAccountInfo.Controls.Add(txtEmail);
            grbAccountInfo.Controls.Add(lblPassword);
            grbAccountInfo.Controls.Add(lblEmail);
            grbAccountInfo.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grbAccountInfo.ForeColor = Color.Yellow;
            grbAccountInfo.Location = new Point(94, 172);
            grbAccountInfo.Name = "grbAccountInfo";
            grbAccountInfo.Size = new Size(616, 351);
            grbAccountInfo.TabIndex = 0;
            grbAccountInfo.TabStop = false;
            grbAccountInfo.Text = " Account Info";
            // 
            // btnCancel
            // 
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Location = new Point(333, 222);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(147, 42);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(231, 130);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(320, 38);
            txtPassword.TabIndex = 1;
            // 
            // btnLogin
            // 
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Location = new Point(163, 222);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(147, 42);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(231, 69);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(320, 38);
            txtEmail.TabIndex = 0;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.BackColor = Color.FromArgb(0, 192, 0);
            lblPassword.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassword.ForeColor = Color.Yellow;
            lblPassword.Location = new Point(94, 133);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(114, 31);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Password";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.BackColor = Color.FromArgb(0, 192, 0);
            lblEmail.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.ForeColor = Color.Yellow;
            lblEmail.Location = new Point(94, 72);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(73, 31);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Email";
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.BackColor = Color.Red;
            lblHeader.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeader.ForeColor = Color.Yellow;
            lblHeader.Location = new Point(197, 62);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(448, 81);
            lblHeader.TabIndex = 2;
            lblHeader.Text = "Book Manager";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Red;
            ClientSize = new Size(808, 610);
            Controls.Add(grbAccountInfo);
            Controls.Add(lblHeader);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            grbAccountInfo.ResumeLayout(false);
            grbAccountInfo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grbAccountInfo;
        private Button btnCancel;
        private TextBox txtPassword;
        private Button btnLogin;
        private TextBox txtEmail;
        private Label lblPassword;
        private Label lblEmail;
        private Label lblHeader;
    }
}
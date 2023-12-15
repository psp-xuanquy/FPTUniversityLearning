namespace BookManagement_QuyDX
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
            btnShowCate = new Button();
            cboCategory = new ComboBox();
            btnLogin = new Button();
            btnExit = new Button();
            lblLogin = new Label();
            SuspendLayout();
            // 
            // btnShowCate
            // 
            btnShowCate.Location = new Point(12, 312);
            btnShowCate.Name = "btnShowCate";
            btnShowCate.Size = new Size(250, 41);
            btnShowCate.TabIndex = 0;
            btnShowCate.Text = "Show Category";
            btnShowCate.UseVisualStyleBackColor = true;
            btnShowCate.Click += btnShowCate_Click;
            // 
            // cboCategory
            // 
            cboCategory.Location = new Point(311, 319);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(426, 28);
            cboCategory.TabIndex = 0;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(233, 150);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 29);
            btnLogin.TabIndex = 1;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(420, 150);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 2;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Segoe UI", 39F, FontStyle.Bold, GraphicsUnit.Point);
            lblLogin.Location = new Point(187, 9);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(385, 87);
            lblLogin.TabIndex = 3;
            lblLogin.Text = "Login Form";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblLogin);
            Controls.Add(btnExit);
            Controls.Add(btnLogin);
            Controls.Add(cboCategory);
            Controls.Add(btnShowCate);
            Name = "LoginForm";
            Text = "Login Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnShowCate;
        private ComboBox cboCategory;
        private Button btnLogin;
        private Button btnExit;
        private Label lblLogin;
    }
}

namespace ProjectPrn211
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
            groupBox1 = new GroupBox();
            btn_register = new Button();
            btn_login = new Button();
            txt_password = new TextBox();
            label2 = new Label();
            txt_username = new TextBox();
            label1 = new Label();
            btn_close = new Button();
            label3 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_register);
            groupBox1.Controls.Add(btn_login);
            groupBox1.Controls.Add(txt_password);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txt_username);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(34, 112);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(967, 410);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // btn_register
            // 
            btn_register.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btn_register.Location = new Point(650, 284);
            btn_register.Name = "btn_register";
            btn_register.Size = new Size(167, 55);
            btn_register.TabIndex = 5;
            btn_register.Text = "Register";
            btn_register.UseVisualStyleBackColor = true;
            btn_register.Click += btn_register_Click;
            // 
            // btn_login
            // 
            btn_login.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btn_login.Location = new Point(303, 284);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(167, 55);
            btn_login.TabIndex = 4;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += btn_login_Click;
            // 
            // txt_password
            // 
            txt_password.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_password.Location = new Point(303, 180);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(514, 43);
            txt_password.TabIndex = 3;
            txt_password.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(150, 183);
            label2.Name = "label2";
            label2.Size = new Size(134, 37);
            label2.TabIndex = 2;
            label2.Text = "Password:";
            // 
            // txt_username
            // 
            txt_username.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_username.Location = new Point(303, 57);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(514, 43);
            txt_username.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(150, 57);
            label1.Name = "label1";
            label1.Size = new Size(147, 37);
            label1.TabIndex = 0;
            label1.Text = "UserName:";
            // 
            // btn_close
            // 
            btn_close.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_close.Location = new Point(855, 28);
            btn_close.Name = "btn_close";
            btn_close.Size = new Size(146, 44);
            btn_close.TabIndex = 6;
            btn_close.Text = "Close";
            btn_close.UseVisualStyleBackColor = true;
            btn_close.Click += btn_close_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(402, 28);
            label3.Name = "label3";
            label3.Size = new Size(250, 65);
            label3.TabIndex = 0;
            label3.Text = "Bird Shop";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1044, 574);
            Controls.Add(btn_close);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txt_username;
        private Label label1;
        private Label label2;
        private TextBox txt_password;
        private Button btn_login;
        private Button btn_close;
        private Button btn_register;
        private Label label3;
    }
}
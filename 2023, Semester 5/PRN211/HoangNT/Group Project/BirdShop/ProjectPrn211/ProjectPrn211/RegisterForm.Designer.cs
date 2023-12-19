namespace BSAPP
{
    partial class RegisterForm
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
            groupBox1 = new GroupBox();
            cb_Gender = new ComboBox();
            dtp_Birthday = new DateTimePicker();
            label9 = new Label();
            txt_zipcode = new TextBox();
            labela = new Label();
            txt_Phone = new TextBox();
            label7 = new Label();
            txt_Address = new TextBox();
            label6 = new Label();
            label5 = new Label();
            txt_Email = new TextBox();
            label3 = new Label();
            txt_FullName = new TextBox();
            label2 = new Label();
            btn_back = new Button();
            txt_password = new TextBox();
            txt_username = new TextBox();
            label4 = new Label();
            btn_Register = new Button();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cb_Gender);
            groupBox1.Controls.Add(dtp_Birthday);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(txt_zipcode);
            groupBox1.Controls.Add(labela);
            groupBox1.Controls.Add(txt_Phone);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txt_Address);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txt_Email);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txt_FullName);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btn_back);
            groupBox1.Controls.Add(txt_password);
            groupBox1.Controls.Add(txt_username);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(btn_Register);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(68, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(656, 725);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // cb_Gender
            // 
            cb_Gender.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            cb_Gender.FormattingEnabled = true;
            cb_Gender.Location = new Point(232, 318);
            cb_Gender.Name = "cb_Gender";
            cb_Gender.Size = new Size(152, 33);
            cb_Gender.TabIndex = 24;
            cb_Gender.SelectedIndexChanged += cb_Gender_SelectedIndexChanged;
            // 
            // dtp_Birthday
            // 
            dtp_Birthday.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dtp_Birthday.Location = new Point(232, 517);
            dtp_Birthday.Name = "dtp_Birthday";
            dtp_Birthday.Size = new Size(366, 33);
            dtp_Birthday.TabIndex = 23;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(98, 523);
            label9.Name = "label9";
            label9.Size = new Size(86, 25);
            label9.TabIndex = 22;
            label9.Text = "Birthday:";
            // 
            // txt_zipcode
            // 
            txt_zipcode.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_zipcode.Location = new Point(232, 583);
            txt_zipcode.Name = "txt_zipcode";
            txt_zipcode.Size = new Size(366, 33);
            txt_zipcode.TabIndex = 21;
            // 
            // labela
            // 
            labela.AutoSize = true;
            labela.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labela.Location = new Point(98, 586);
            labela.Name = "labela";
            labela.Size = new Size(84, 25);
            labela.TabIndex = 20;
            labela.Text = "Zipcode:";
            // 
            // txt_Phone
            // 
            txt_Phone.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Phone.Location = new Point(232, 452);
            txt_Phone.Name = "txt_Phone";
            txt_Phone.Size = new Size(366, 33);
            txt_Phone.TabIndex = 19;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(98, 455);
            label7.Name = "label7";
            label7.Size = new Size(70, 25);
            label7.TabIndex = 18;
            label7.Text = "Phone:";
            // 
            // txt_Address
            // 
            txt_Address.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Address.Location = new Point(232, 385);
            txt_Address.Name = "txt_Address";
            txt_Address.Size = new Size(366, 33);
            txt_Address.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(98, 388);
            label6.Name = "label6";
            label6.Size = new Size(79, 25);
            label6.TabIndex = 16;
            label6.Text = "Address";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(98, 321);
            label5.Name = "label5";
            label5.Size = new Size(78, 25);
            label5.TabIndex = 14;
            label5.Text = "Gender:";
            // 
            // txt_Email
            // 
            txt_Email.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Email.Location = new Point(232, 249);
            txt_Email.Name = "txt_Email";
            txt_Email.Size = new Size(366, 33);
            txt_Email.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(98, 252);
            label3.Name = "label3";
            label3.Size = new Size(62, 25);
            label3.TabIndex = 12;
            label3.Text = "Email:";
            // 
            // txt_FullName
            // 
            txt_FullName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_FullName.Location = new Point(232, 176);
            txt_FullName.Name = "txt_FullName";
            txt_FullName.Size = new Size(366, 33);
            txt_FullName.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(96, 179);
            label2.Name = "label2";
            label2.Size = new Size(106, 25);
            label2.TabIndex = 10;
            label2.Text = " Full Name:";
            // 
            // btn_back
            // 
            btn_back.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_back.Location = new Point(409, 636);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(113, 51);
            btn_back.TabIndex = 9;
            btn_back.Text = "Back";
            btn_back.UseVisualStyleBackColor = true;
            btn_back.Click += btn_back_Click;
            // 
            // txt_password
            // 
            txt_password.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_password.Location = new Point(232, 111);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(366, 33);
            txt_password.TabIndex = 8;
            txt_password.UseSystemPasswordChar = true;
            // 
            // txt_username
            // 
            txt_username.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_username.Location = new Point(232, 48);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(366, 33);
            txt_username.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(98, 114);
            label4.Name = "label4";
            label4.Size = new Size(95, 25);
            label4.TabIndex = 4;
            label4.Text = "Password:";
            // 
            // btn_Register
            // 
            btn_Register.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Register.Location = new Point(169, 636);
            btn_Register.Name = "btn_Register";
            btn_Register.Size = new Size(113, 51);
            btn_Register.TabIndex = 1;
            btn_Register.Text = "Register";
            btn_Register.UseVisualStyleBackColor = true;
            btn_Register.Click += btn_Register_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(98, 51);
            label1.Name = "label1";
            label1.Size = new Size(104, 25);
            label1.TabIndex = 0;
            label1.Text = "UserName:";
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 749);
            Controls.Add(groupBox1);
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegisterForm";
            Load += RegisterForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btn_Register;
        private Label label1;
        private Label label4;
        private TextBox txt_password;
        private TextBox txt_username;
        private Button btn_back;
        private TextBox txt_Phone;
        private Label label7;
        private TextBox txt_Address;
        private Label label6;
        private TextBox textBox3;
        private Label label5;
        private TextBox txt_Email;
        private Label label3;
        private TextBox txt_FullName;
        private Label label2;
        private ComboBox cb_Gender;
        private DateTimePicker dtp_Birthday;
        private Label label9;
        private TextBox txt_zipcode;
        private Label labela;
    }
}
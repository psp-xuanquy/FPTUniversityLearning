namespace BSAPP
{
    partial class ManageAccount
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
            cbb_Role = new ComboBox();
            labelrole = new Label();
            txt_password = new TextBox();
            label10 = new Label();
            txt_username = new TextBox();
            cbx_gender = new ComboBox();
            txt_zipcode = new TextBox();
            label8 = new Label();
            txt_email = new TextBox();
            label7 = new Label();
            txt_phone = new TextBox();
            txt_fullname = new TextBox();
            txt_address = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            dtp_dateofbird = new DateTimePicker();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btn_close = new Button();
            btnRefresh = new Button();
            btn_update = new Button();
            btn_delete = new Button();
            btn_add = new Button();
            groupBox3 = new GroupBox();
            dgv_accountlist = new DataGridView();
            groupBox4 = new GroupBox();
            label9 = new Label();
            txt_search = new TextBox();
            btn_search = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_accountlist).BeginInit();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbb_Role);
            groupBox1.Controls.Add(labelrole);
            groupBox1.Controls.Add(txt_password);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(txt_username);
            groupBox1.Controls.Add(cbx_gender);
            groupBox1.Controls.Add(txt_zipcode);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txt_email);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txt_phone);
            groupBox1.Controls.Add(txt_fullname);
            groupBox1.Controls.Add(txt_address);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(dtp_dateofbird);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(873, 267);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Account Info";
            // 
            // cbb_Role
            // 
            cbb_Role.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            cbb_Role.FormattingEnabled = true;
            cbb_Role.Location = new Point(551, 33);
            cbb_Role.Name = "cbb_Role";
            cbb_Role.Size = new Size(302, 33);
            cbb_Role.TabIndex = 21;
            // 
            // labelrole
            // 
            labelrole.AutoSize = true;
            labelrole.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelrole.Location = new Point(416, 42);
            labelrole.Name = "labelrole";
            labelrole.Size = new Size(52, 25);
            labelrole.TabIndex = 20;
            labelrole.Text = "Role:";
            // 
            // txt_password
            // 
            txt_password.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_password.Location = new Point(127, 79);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(264, 33);
            txt_password.TabIndex = 19;
            txt_password.UseSystemPasswordChar = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(16, 88);
            label10.Name = "label10";
            label10.Size = new Size(95, 25);
            label10.TabIndex = 18;
            label10.Text = "Password:";
            // 
            // txt_username
            // 
            txt_username.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_username.Location = new Point(127, 33);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(264, 33);
            txt_username.TabIndex = 17;
            // 
            // cbx_gender
            // 
            cbx_gender.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            cbx_gender.FormattingEnabled = true;
            cbx_gender.Location = new Point(551, 79);
            cbx_gender.Name = "cbx_gender";
            cbx_gender.Size = new Size(302, 33);
            cbx_gender.TabIndex = 16;
            // 
            // txt_zipcode
            // 
            txt_zipcode.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_zipcode.Location = new Point(127, 214);
            txt_zipcode.Name = "txt_zipcode";
            txt_zipcode.Size = new Size(264, 33);
            txt_zipcode.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(16, 221);
            label8.Name = "label8";
            label8.Size = new Size(82, 25);
            label8.TabIndex = 14;
            label8.Text = "zipcode:";
            // 
            // txt_email
            // 
            txt_email.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_email.Location = new Point(127, 170);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(264, 33);
            txt_email.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(416, 180);
            label7.Name = "label7";
            label7.Size = new Size(126, 25);
            label7.TabIndex = 12;
            label7.Text = "date_of_birth:";
            // 
            // txt_phone
            // 
            txt_phone.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_phone.Location = new Point(551, 214);
            txt_phone.Name = "txt_phone";
            txt_phone.Size = new Size(302, 33);
            txt_phone.TabIndex = 11;
            // 
            // txt_fullname
            // 
            txt_fullname.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_fullname.Location = new Point(127, 125);
            txt_fullname.Name = "txt_fullname";
            txt_fullname.Size = new Size(264, 33);
            txt_fullname.TabIndex = 10;
            // 
            // txt_address
            // 
            txt_address.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_address.Location = new Point(551, 125);
            txt_address.Name = "txt_address";
            txt_address.Size = new Size(302, 33);
            txt_address.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(416, 221);
            label6.Name = "label6";
            label6.Size = new Size(70, 25);
            label6.TabIndex = 8;
            label6.Text = "phone:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(16, 180);
            label5.Name = "label5";
            label5.Size = new Size(62, 25);
            label5.TabIndex = 7;
            label5.Text = "email:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(16, 134);
            label4.Name = "label4";
            label4.Size = new Size(98, 25);
            label4.TabIndex = 6;
            label4.Text = "full_name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(416, 88);
            label3.Name = "label3";
            label3.Size = new Size(76, 25);
            label3.TabIndex = 5;
            label3.Text = "gender:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(416, 134);
            label2.Name = "label2";
            label2.Size = new Size(81, 25);
            label2.TabIndex = 4;
            label2.Text = "address:";
            // 
            // dtp_dateofbird
            // 
            dtp_dateofbird.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dtp_dateofbird.Location = new Point(551, 167);
            dtp_dateofbird.Name = "dtp_dateofbird";
            dtp_dateofbird.Size = new Size(302, 33);
            dtp_dateofbird.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(16, 38);
            label1.Name = "label1";
            label1.Size = new Size(101, 25);
            label1.TabIndex = 0;
            label1.Text = "Username:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btn_close);
            groupBox2.Controls.Add(btnRefresh);
            groupBox2.Controls.Add(btn_update);
            groupBox2.Controls.Add(btn_delete);
            groupBox2.Controls.Add(btn_add);
            groupBox2.Location = new Point(902, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(257, 267);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // btn_close
            // 
            btn_close.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_close.Location = new Point(51, 208);
            btn_close.Name = "btn_close";
            btn_close.Size = new Size(167, 38);
            btn_close.TabIndex = 3;
            btn_close.Text = "Close";
            btn_close.UseVisualStyleBackColor = true;
            btn_close.Click += btn_close_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnRefresh.Location = new Point(51, 161);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(167, 38);
            btnRefresh.TabIndex = 2;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btn_update
            // 
            btn_update.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_update.Location = new Point(51, 117);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(167, 38);
            btn_update.TabIndex = 2;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // btn_delete
            // 
            btn_delete.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_delete.Location = new Point(51, 71);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(167, 38);
            btn_delete.TabIndex = 1;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_add
            // 
            btn_add.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_add.Location = new Point(51, 22);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(167, 38);
            btn_add.TabIndex = 0;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dgv_accountlist);
            groupBox3.Location = new Point(12, 355);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1147, 238);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Account List";
            // 
            // dgv_accountlist
            // 
            dgv_accountlist.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_accountlist.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_accountlist.Location = new Point(16, 22);
            dgv_accountlist.Name = "dgv_accountlist";
            dgv_accountlist.RowTemplate.Height = 25;
            dgv_accountlist.Size = new Size(1125, 201);
            dgv_accountlist.TabIndex = 0;
            dgv_accountlist.CellClick += dgv_accountlist_CellClick;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label9);
            groupBox4.Controls.Add(txt_search);
            groupBox4.Controls.Add(btn_search);
            groupBox4.Location = new Point(12, 267);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(1147, 82);
            groupBox4.TabIndex = 2;
            groupBox4.TabStop = false;
            groupBox4.Text = "Search:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(64, 27);
            label9.Name = "label9";
            label9.Size = new Size(123, 32);
            label9.TabIndex = 16;
            label9.Text = "full_name:";
            // 
            // txt_search
            // 
            txt_search.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txt_search.Location = new Point(206, 25);
            txt_search.Name = "txt_search";
            txt_search.Size = new Size(667, 39);
            txt_search.TabIndex = 16;
            txt_search.TextChanged += txt_search_TextChanged;
            // 
            // btn_search
            // 
            btn_search.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_search.Location = new Point(928, 22);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(115, 41);
            btn_search.TabIndex = 4;
            btn_search.Text = "Search";
            btn_search.UseVisualStyleBackColor = true;
            btn_search.Click += btn_search_Click;
            // 
            // ManageAccount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1171, 605);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "ManageAccount";
            Text = "ManageAccount";
            Load += ManageAccount_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_accountlist).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private DateTimePicker dtp_dateofbird;
        private Label label1;
        private Button btn_add;
        private DataGridView dgv_accountlist;
        private GroupBox groupBox4;
        private TextBox txt_phone;
        private TextBox txt_fullname;
        private TextBox txt_address;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label7;
        private TextBox txt_email;
        private TextBox txt_zipcode;
        private Label label8;
        private Label label9;
        private TextBox txt_search;
        private Button btn_search;
        private Button btn_close;
        private Button btn_update;
        private Button btn_delete;
        private ComboBox cbx_gender;
        private TextBox txt_password;
        private Label label10;
        private TextBox txt_username;
        private ComboBox cbb_Role;
        private Label labelrole;
        private Button btnRefresh;
    }
}
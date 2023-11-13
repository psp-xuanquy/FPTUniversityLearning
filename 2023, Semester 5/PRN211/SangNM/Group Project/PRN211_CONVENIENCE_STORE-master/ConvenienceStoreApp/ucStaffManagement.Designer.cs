
namespace ConvenienceStoreApp
{
    partial class ucStaffManagement
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            txtSearchStaffID = new System.Windows.Forms.TextBox();
            txtSearchStaffName = new System.Windows.Forms.TextBox();
            dgvStaffList = new System.Windows.Forms.DataGridView();
            btnSearch = new System.Windows.Forms.Button();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            txtStaffID = new System.Windows.Forms.TextBox();
            txtFullname = new System.Windows.Forms.TextBox();
            txtAddress = new System.Windows.Forms.TextBox();
            txtPhoneNumber = new System.Windows.Forms.TextBox();
            txtPassword = new System.Windows.Forms.TextBox();
            txtEmail = new System.Windows.Forms.TextBox();
            label11 = new System.Windows.Forms.Label();
            label12 = new System.Windows.Forms.Label();
            label13 = new System.Windows.Forms.Label();
            btnAdd = new System.Windows.Forms.Button();
            btnUpdate = new System.Windows.Forms.Button();
            btnRefresh = new System.Windows.Forms.Button();
            cboRoleID = new System.Windows.Forms.ComboBox();
            cboStatusID = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvStaffList).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(18, 141);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(59, 20);
            label1.TabIndex = 0;
            label1.Text = "Staff ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(18, 195);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(84, 20);
            label2.TabIndex = 1;
            label2.Text = "Staff Name";
            // 
            // txtSearchStaffID
            // 
            txtSearchStaffID.Location = new System.Drawing.Point(117, 139);
            txtSearchStaffID.Name = "txtSearchStaffID";
            txtSearchStaffID.Size = new System.Drawing.Size(233, 27);
            txtSearchStaffID.TabIndex = 2;
            // 
            // txtSearchStaffName
            // 
            txtSearchStaffName.Location = new System.Drawing.Point(117, 191);
            txtSearchStaffName.Name = "txtSearchStaffName";
            txtSearchStaffName.Size = new System.Drawing.Size(233, 27);
            txtSearchStaffName.TabIndex = 3;
            // 
            // dgvStaffList
            // 
            dgvStaffList.AllowUserToAddRows = false;
            dgvStaffList.AllowUserToDeleteRows = false;
            dgvStaffList.AllowUserToResizeColumns = false;
            dgvStaffList.AllowUserToResizeRows = false;
            dgvStaffList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvStaffList.BackgroundColor = System.Drawing.Color.White;
            dgvStaffList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStaffList.Location = new System.Drawing.Point(3, 375);
            dgvStaffList.Name = "dgvStaffList";
            dgvStaffList.ReadOnly = true;
            dgvStaffList.RowHeadersWidth = 51;
            dgvStaffList.RowTemplate.Height = 29;
            dgvStaffList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvStaffList.Size = new System.Drawing.Size(1234, 361);
            dgvStaffList.TabIndex = 4;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = System.Drawing.SystemColors.Highlight;
            btnSearch.ForeColor = System.Drawing.Color.White;
            btnSearch.Location = new System.Drawing.Point(117, 237);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new System.Drawing.Size(101, 39);
            btnSearch.TabIndex = 5;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(574, 139);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(59, 20);
            label3.TabIndex = 6;
            label3.Text = "Staff ID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(574, 184);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(69, 20);
            label4.TabIndex = 7;
            label4.Text = "Fullname";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(574, 235);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(62, 20);
            label5.TabIndex = 8;
            label5.Text = "Address";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(538, 283);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(105, 20);
            label6.TabIndex = 9;
            label6.Text = "Phone number";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(914, 133);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(70, 20);
            label7.TabIndex = 10;
            label7.Text = "Password";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(926, 181);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(58, 20);
            label8.TabIndex = 11;
            label8.Text = "Role ID";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(926, 229);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(68, 20);
            label9.TabIndex = 12;
            label9.Text = "Status ID";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(935, 283);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(46, 20);
            label10.TabIndex = 13;
            label10.Text = "Email";
            // 
            // txtStaffID
            // 
            txtStaffID.Location = new System.Drawing.Point(673, 135);
            txtStaffID.Name = "txtStaffID";
            txtStaffID.Size = new System.Drawing.Size(204, 27);
            txtStaffID.TabIndex = 14;
            // 
            // txtFullname
            // 
            txtFullname.Location = new System.Drawing.Point(673, 181);
            txtFullname.Name = "txtFullname";
            txtFullname.Size = new System.Drawing.Size(204, 27);
            txtFullname.TabIndex = 15;
            // 
            // txtAddress
            // 
            txtAddress.Location = new System.Drawing.Point(673, 231);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new System.Drawing.Size(204, 27);
            txtAddress.TabIndex = 16;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new System.Drawing.Point(673, 279);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new System.Drawing.Size(204, 27);
            txtPhoneNumber.TabIndex = 17;
            // 
            // txtPassword
            // 
            txtPassword.Location = new System.Drawing.Point(1021, 131);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new System.Drawing.Size(204, 27);
            txtPassword.TabIndex = 18;
            // 
            // txtEmail
            // 
            txtEmail.Location = new System.Drawing.Point(1021, 279);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new System.Drawing.Size(204, 27);
            txtEmail.TabIndex = 21;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label11.Location = new System.Drawing.Point(3, 0);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(412, 60);
            label11.TabIndex = 34;
            label11.Text = "Staff Management";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label12.ForeColor = System.Drawing.SystemColors.Highlight;
            label12.Location = new System.Drawing.Point(18, 68);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(124, 45);
            label12.TabIndex = 35;
            label12.Text = "Search";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label13.ForeColor = System.Drawing.SystemColors.Highlight;
            label13.Location = new System.Drawing.Point(574, 68);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(385, 45);
            label13.TabIndex = 36;
            label13.Text = "Staff detail information";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = System.Drawing.SystemColors.Highlight;
            btnAdd.ForeColor = System.Drawing.Color.White;
            btnAdd.Location = new System.Drawing.Point(673, 333);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(94, 35);
            btnAdd.TabIndex = 37;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += button1_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = System.Drawing.SystemColors.Highlight;
            btnUpdate.ForeColor = System.Drawing.Color.White;
            btnUpdate.Location = new System.Drawing.Point(795, 333);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new System.Drawing.Size(94, 35);
            btnUpdate.TabIndex = 38;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = System.Drawing.SystemColors.Highlight;
            btnRefresh.ForeColor = System.Drawing.Color.White;
            btnRefresh.Location = new System.Drawing.Point(18, 333);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new System.Drawing.Size(94, 35);
            btnRefresh.TabIndex = 39;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // cboRoleID
            // 
            cboRoleID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboRoleID.FormattingEnabled = true;
            cboRoleID.Items.AddRange(new object[] { "AD", "ST" });
            cboRoleID.Location = new System.Drawing.Point(1021, 179);
            cboRoleID.Name = "cboRoleID";
            cboRoleID.Size = new System.Drawing.Size(204, 28);
            cboRoleID.TabIndex = 40;
            // 
            // cboStatusID
            // 
            cboStatusID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboStatusID.FormattingEnabled = true;
            cboStatusID.Items.AddRange(new object[] { "Active", "Inactive" });
            cboStatusID.Location = new System.Drawing.Point(1021, 227);
            cboStatusID.Name = "cboStatusID";
            cboStatusID.Size = new System.Drawing.Size(204, 28);
            cboStatusID.TabIndex = 41;
            // 
            // ucStaffManagement
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(cboStatusID);
            Controls.Add(cboRoleID);
            Controls.Add(btnRefresh);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(txtEmail);
            Controls.Add(txtPassword);
            Controls.Add(txtPhoneNumber);
            Controls.Add(txtAddress);
            Controls.Add(txtFullname);
            Controls.Add(txtStaffID);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnSearch);
            Controls.Add(dgvStaffList);
            Controls.Add(txtSearchStaffName);
            Controls.Add(txtSearchStaffID);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ucStaffManagement";
            Size = new System.Drawing.Size(1240, 739);
            Load += ucStaffManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStaffList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearchStaffID;
        private System.Windows.Forms.TextBox txtSearchStaffName;
        private System.Windows.Forms.DataGridView dgvStaffList;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtStaffID;
        private System.Windows.Forms.TextBox txtFullname;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ComboBox cboRoleID;
        private System.Windows.Forms.ComboBox cboStatusID;
    }
}

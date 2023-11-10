namespace SalesWinApp
{
    partial class frmMemberManagement
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
            lbMemberID = new System.Windows.Forms.Label();
            lbEmail = new System.Windows.Forms.Label();
            lbCompanyName = new System.Windows.Forms.Label();
            lbCity = new System.Windows.Forms.Label();
            lbCountry = new System.Windows.Forms.Label();
            lbPassword = new System.Windows.Forms.Label();
            textBox1 = new System.Windows.Forms.TextBox();
            lbHeader = new System.Windows.Forms.Label();
            textBox2 = new System.Windows.Forms.TextBox();
            textBox3 = new System.Windows.Forms.TextBox();
            textBox4 = new System.Windows.Forms.TextBox();
            textBox5 = new System.Windows.Forms.TextBox();
            textBox6 = new System.Windows.Forms.TextBox();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            btCreate = new System.Windows.Forms.Button();
            btDelete = new System.Windows.Forms.Button();
            btUpdate = new System.Windows.Forms.Button();
            btBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lbMemberID
            // 
            lbMemberID.AutoSize = true;
            lbMemberID.Location = new System.Drawing.Point(152, 118);
            lbMemberID.Name = "lbMemberID";
            lbMemberID.Size = new System.Drawing.Size(88, 21);
            lbMemberID.TabIndex = 0;
            lbMemberID.Text = "Member ID";
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new System.Drawing.Point(152, 153);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new System.Drawing.Size(48, 21);
            lbEmail.TabIndex = 1;
            lbEmail.Text = "Email";
            // 
            // lbCompanyName
            // 
            lbCompanyName.AutoSize = true;
            lbCompanyName.Location = new System.Drawing.Point(152, 188);
            lbCompanyName.Name = "lbCompanyName";
            lbCompanyName.Size = new System.Drawing.Size(123, 21);
            lbCompanyName.TabIndex = 2;
            lbCompanyName.Text = "Company Name";
            // 
            // lbCity
            // 
            lbCity.AutoSize = true;
            lbCity.Location = new System.Drawing.Point(574, 118);
            lbCity.Name = "lbCity";
            lbCity.Size = new System.Drawing.Size(37, 21);
            lbCity.TabIndex = 3;
            lbCity.Text = "City";
            // 
            // lbCountry
            // 
            lbCountry.AutoSize = true;
            lbCountry.Location = new System.Drawing.Point(574, 153);
            lbCountry.Name = "lbCountry";
            lbCountry.Size = new System.Drawing.Size(66, 21);
            lbCountry.TabIndex = 4;
            lbCountry.Text = "Country";
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new System.Drawing.Point(574, 188);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new System.Drawing.Size(76, 21);
            lbPassword.TabIndex = 5;
            lbPassword.Text = "Password";
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(281, 115);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(222, 29);
            textBox1.TabIndex = 6;
            // 
            // lbHeader
            // 
            lbHeader.AutoSize = true;
            lbHeader.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbHeader.Location = new System.Drawing.Point(245, 9);
            lbHeader.Name = "lbHeader";
            lbHeader.Size = new System.Drawing.Size(564, 72);
            lbHeader.TabIndex = 7;
            lbHeader.Text = "Member Management";
            // 
            // textBox2
            // 
            textBox2.Location = new System.Drawing.Point(281, 150);
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(222, 29);
            textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.Location = new System.Drawing.Point(281, 185);
            textBox3.Name = "textBox3";
            textBox3.Size = new System.Drawing.Size(222, 29);
            textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            textBox4.Location = new System.Drawing.Point(656, 185);
            textBox4.Name = "textBox4";
            textBox4.Size = new System.Drawing.Size(222, 29);
            textBox4.TabIndex = 12;
            // 
            // textBox5
            // 
            textBox5.Location = new System.Drawing.Point(656, 150);
            textBox5.Name = "textBox5";
            textBox5.Size = new System.Drawing.Size(222, 29);
            textBox5.TabIndex = 11;
            // 
            // textBox6
            // 
            textBox6.Location = new System.Drawing.Point(656, 115);
            textBox6.Name = "textBox6";
            textBox6.Size = new System.Drawing.Size(222, 29);
            textBox6.TabIndex = 10;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new System.Drawing.Point(152, 284);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new System.Drawing.Size(726, 265);
            dataGridView1.TabIndex = 13;
            // 
            // btCreate
            // 
            btCreate.Location = new System.Drawing.Point(336, 230);
            btCreate.Name = "btCreate";
            btCreate.Size = new System.Drawing.Size(103, 38);
            btCreate.TabIndex = 14;
            btCreate.Text = "Create";
            btCreate.UseVisualStyleBackColor = true;
            // 
            // btDelete
            // 
            btDelete.Location = new System.Drawing.Point(706, 230);
            btDelete.Name = "btDelete";
            btDelete.Size = new System.Drawing.Size(103, 38);
            btDelete.TabIndex = 15;
            btDelete.Text = "Delete";
            btDelete.UseVisualStyleBackColor = true;
            // 
            // btUpdate
            // 
            btUpdate.Location = new System.Drawing.Point(518, 230);
            btUpdate.Name = "btUpdate";
            btUpdate.Size = new System.Drawing.Size(103, 38);
            btUpdate.TabIndex = 15;
            btUpdate.Text = "Update";
            btUpdate.UseVisualStyleBackColor = true;
            // 
            // btBack
            // 
            btBack.Location = new System.Drawing.Point(12, 12);
            btBack.Name = "btBack";
            btBack.Size = new System.Drawing.Size(103, 38);
            btBack.TabIndex = 16;
            btBack.Text = "Back ";
            btBack.UseVisualStyleBackColor = true;
            btBack.Click += btBack_Click;
            // 
            // frmMemberManagement
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1029, 630);
            Controls.Add(btBack);
            Controls.Add(btUpdate);
            Controls.Add(btDelete);
            Controls.Add(btCreate);
            Controls.Add(dataGridView1);
            Controls.Add(textBox4);
            Controls.Add(textBox5);
            Controls.Add(textBox6);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(lbHeader);
            Controls.Add(textBox1);
            Controls.Add(lbPassword);
            Controls.Add(lbCountry);
            Controls.Add(lbCity);
            Controls.Add(lbCompanyName);
            Controls.Add(lbEmail);
            Controls.Add(lbMemberID);
            Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Margin = new System.Windows.Forms.Padding(4);
            Name = "frmMemberManagement";
            Text = "frmMemberManagement";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lbMemberID;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbCompanyName;
        private System.Windows.Forms.Label lbCity;
        private System.Windows.Forms.Label lbCountry;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbHeader;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btCreate;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btBack;
    }
}
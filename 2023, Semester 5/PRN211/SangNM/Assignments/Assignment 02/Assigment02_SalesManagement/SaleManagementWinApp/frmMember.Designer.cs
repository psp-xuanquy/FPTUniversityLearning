namespace SaleManagementWinApp
{
    partial class frmMember
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
            txtRole = new System.Windows.Forms.TextBox();
            txtId = new System.Windows.Forms.TextBox();
            txtEmail = new System.Windows.Forms.TextBox();
            txtCity = new System.Windows.Forms.TextBox();
            txtCountry = new System.Windows.Forms.TextBox();
            btnSearchMember = new System.Windows.Forms.Button();
            btnDeleteMember = new System.Windows.Forms.Button();
            btnUpdate = new System.Windows.Forms.Button();
            dgvMemberList = new System.Windows.Forms.DataGridView();
            label6 = new System.Windows.Forms.Label();
            tbSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvMemberList).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(46, 131);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(22, 20);
            label1.TabIndex = 0;
            label1.Text = "Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(46, 184);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(46, 20);
            label2.TabIndex = 1;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(46, 235);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(116, 20);
            label3.TabIndex = 2;
            label3.Text = "Company Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(46, 283);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(34, 20);
            label4.TabIndex = 3;
            label4.Text = "City";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(46, 336);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(60, 20);
            label5.TabIndex = 4;
            label5.Text = "Country";
            // 
            // txtRole
            // 
            txtRole.Location = new System.Drawing.Point(178, 231);
            txtRole.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtRole.Name = "txtRole";
            txtRole.Size = new System.Drawing.Size(237, 27);
            txtRole.TabIndex = 5;
            // 
            // txtId
            // 
            txtId.Location = new System.Drawing.Point(178, 127);
            txtId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtId.Name = "txtId";
            txtId.Size = new System.Drawing.Size(237, 27);
            txtId.TabIndex = 6;
            // 
            // txtEmail
            // 
            txtEmail.Location = new System.Drawing.Point(178, 180);
            txtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new System.Drawing.Size(237, 27);
            txtEmail.TabIndex = 7;
            // 
            // txtCity
            // 
            txtCity.Location = new System.Drawing.Point(178, 279);
            txtCity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtCity.Name = "txtCity";
            txtCity.Size = new System.Drawing.Size(237, 27);
            txtCity.TabIndex = 8;
            // 
            // txtCountry
            // 
            txtCountry.Location = new System.Drawing.Point(178, 332);
            txtCountry.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new System.Drawing.Size(237, 27);
            txtCountry.TabIndex = 9;
            // 
            // btnSearchMember
            // 
            btnSearchMember.Location = new System.Drawing.Point(775, 42);
            btnSearchMember.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnSearchMember.Name = "btnSearchMember";
            btnSearchMember.Size = new System.Drawing.Size(155, 31);
            btnSearchMember.TabIndex = 10;
            btnSearchMember.Text = "Search";
            btnSearchMember.UseVisualStyleBackColor = true;
            btnSearchMember.Click += btnSearchMember_Click;
            // 
            // btnDeleteMember
            // 
            btnDeleteMember.Location = new System.Drawing.Point(202, 408);
            btnDeleteMember.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnDeleteMember.Name = "btnDeleteMember";
            btnDeleteMember.Size = new System.Drawing.Size(86, 31);
            btnDeleteMember.TabIndex = 12;
            btnDeleteMember.Text = "Delete";
            btnDeleteMember.UseVisualStyleBackColor = true;
            btnDeleteMember.Click += btnDeleteMember_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new System.Drawing.Point(330, 408);
            btnUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new System.Drawing.Size(86, 31);
            btnUpdate.TabIndex = 13;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // dgvMemberList
            // 
            dgvMemberList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMemberList.Location = new System.Drawing.Point(446, 115);
            dgvMemberList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dgvMemberList.Name = "dgvMemberList";
            dgvMemberList.RowHeadersWidth = 51;
            dgvMemberList.RowTemplate.Height = 25;
            dgvMemberList.Size = new System.Drawing.Size(484, 324);
            dgvMemberList.TabIndex = 14;
            dgvMemberList.CellClick += clickCellShowInfo;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label6.Location = new System.Drawing.Point(46, 38);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(356, 35);
            label6.TabIndex = 15;
            label6.Text = "Member Management";
            // 
            // tbSearch
            // 
            tbSearch.Location = new System.Drawing.Point(446, 44);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new System.Drawing.Size(297, 27);
            tbSearch.TabIndex = 16;
            // 
            // frmMember
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(966, 511);
            Controls.Add(tbSearch);
            Controls.Add(label6);
            Controls.Add(dgvMemberList);
            Controls.Add(btnUpdate);
            Controls.Add(btnDeleteMember);
            Controls.Add(btnSearchMember);
            Controls.Add(txtCountry);
            Controls.Add(txtCity);
            Controls.Add(txtEmail);
            Controls.Add(txtId);
            Controls.Add(txtRole);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "frmMember";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "frmMember";
            ((System.ComponentModel.ISupportInitialize)dgvMemberList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRole;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.Button btnSearchMember;
        private System.Windows.Forms.Button btnDeleteMember;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView dgvMemberList;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbSearch;
    }
}
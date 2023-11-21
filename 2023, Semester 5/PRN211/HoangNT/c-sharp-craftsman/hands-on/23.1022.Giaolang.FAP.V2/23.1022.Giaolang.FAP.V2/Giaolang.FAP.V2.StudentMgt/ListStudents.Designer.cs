namespace Giaolang.FAP.V2.StudentMgt
{
    partial class ListStudents
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
            dgvStudentList = new DataGridView();
            lblId = new Label();
            lblName = new Label();
            lblAddress = new Label();
            txtId = new TextBox();
            txtName = new TextBox();
            txtAddress = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnSearch = new Button();
            btnDelete = new Button();
            txtGpa = new TextBox();
            lblGpa = new Label();
            txtKeyword = new TextBox();
            dgvSearchResult = new DataGridView();
            grbSearch = new GroupBox();
            lblHeader = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvStudentList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSearchResult).BeginInit();
            grbSearch.SuspendLayout();
            SuspendLayout();
            // 
            // dgvStudentList
            // 
            dgvStudentList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudentList.Location = new Point(528, 109);
            dgvStudentList.Name = "dgvStudentList";
            dgvStudentList.RowHeadersWidth = 51;
            dgvStudentList.RowTemplate.Height = 29;
            dgvStudentList.Size = new Size(470, 288);
            dgvStudentList.TabIndex = 8;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(50, 113);
            lblId.Name = "lblId";
            lblId.Size = new Size(22, 20);
            lblId.TabIndex = 1;
            lblId.Text = "Id";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(49, 158);
            lblName.Name = "lblName";
            lblName.Size = new Size(49, 20);
            lblName.TabIndex = 2;
            lblName.Text = "Name";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(50, 207);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(62, 20);
            lblAddress.TabIndex = 3;
            lblAddress.Text = "Address";
            // 
            // txtId
            // 
            txtId.Location = new Point(147, 110);
            txtId.Name = "txtId";
            txtId.Size = new Size(253, 27);
            txtId.TabIndex = 0;
            // 
            // txtName
            // 
            txtName.Location = new Point(147, 158);
            txtName.Name = "txtName";
            txtName.Size = new Size(253, 27);
            txtName.TabIndex = 1;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(147, 200);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(253, 27);
            txtAddress.TabIndex = 2;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(45, 308);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(83, 34);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(147, 308);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(92, 34);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(128, 255, 128);
            btnSearch.Location = new Point(6, 25);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(83, 34);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(255, 192, 192);
            btnDelete.Location = new Point(260, 308);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(78, 34);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // txtGpa
            // 
            txtGpa.Location = new Point(147, 251);
            txtGpa.Name = "txtGpa";
            txtGpa.Size = new Size(253, 27);
            txtGpa.TabIndex = 3;
            // 
            // lblGpa
            // 
            lblGpa.AutoSize = true;
            lblGpa.Location = new Point(50, 258);
            lblGpa.Name = "lblGpa";
            lblGpa.Size = new Size(36, 20);
            lblGpa.TabIndex = 11;
            lblGpa.Text = "GPA";
            // 
            // txtKeyword
            // 
            txtKeyword.Location = new Point(108, 29);
            txtKeyword.Name = "txtKeyword";
            txtKeyword.Size = new Size(253, 27);
            txtKeyword.TabIndex = 0;
            // 
            // dgvSearchResult
            // 
            dgvSearchResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSearchResult.Location = new Point(45, 473);
            dgvSearchResult.Name = "dgvSearchResult";
            dgvSearchResult.RowHeadersWidth = 51;
            dgvSearchResult.RowTemplate.Height = 29;
            dgvSearchResult.Size = new Size(470, 113);
            dgvSearchResult.TabIndex = 9;
            // 
            // grbSearch
            // 
            grbSearch.Controls.Add(txtKeyword);
            grbSearch.Controls.Add(btnSearch);
            grbSearch.Location = new Point(50, 389);
            grbSearch.Name = "grbSearch";
            grbSearch.Size = new Size(418, 71);
            grbSearch.TabIndex = 7;
            grbSearch.TabStop = false;
            grbSearch.Text = " Search ";
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblHeader.Location = new Point(49, 26);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(432, 41);
            lblHeader.TabIndex = 12;
            lblHeader.Text = "Student Management System";
            // 
            // ListStudents
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1036, 623);
            Controls.Add(lblHeader);
            Controls.Add(grbSearch);
            Controls.Add(dgvSearchResult);
            Controls.Add(txtGpa);
            Controls.Add(lblGpa);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(txtAddress);
            Controls.Add(txtName);
            Controls.Add(txtId);
            Controls.Add(lblAddress);
            Controls.Add(lblName);
            Controls.Add(lblId);
            Controls.Add(dgvStudentList);
            Name = "ListStudents";
            Text = "List of Students";
            ((System.ComponentModel.ISupportInitialize)dgvStudentList).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvSearchResult).EndInit();
            grbSearch.ResumeLayout(false);
            grbSearch.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvStudentList;
        private Label lblId;
        private Label lblName;
        private Label lblAddress;
        private TextBox txtId;
        private TextBox txtName;
        private TextBox txtAddress;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnSearch;
        private Button btnDelete;
        private TextBox txtGpa;
        private Label lblGpa;
        private TextBox txtKeyword;
        private DataGridView dgvSearchResult;
        private GroupBox grbSearch;
        private Label lblHeader;
    }
}
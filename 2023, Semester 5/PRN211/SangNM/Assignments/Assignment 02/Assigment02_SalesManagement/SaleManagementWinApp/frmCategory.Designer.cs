namespace SaleManagementWinApp
{
    partial class frmCategory
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
            tbCategory = new System.Windows.Forms.TextBox();
            btnCreate = new System.Windows.Forms.Button();
            btnUpdate = new System.Windows.Forms.Button();
            btnDelete = new System.Windows.Forms.Button();
            dgvCategory = new System.Windows.Forms.DataGridView();
            label3 = new System.Windows.Forms.Label();
            tbId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvCategory).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(45, 34);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(374, 35);
            label1.TabIndex = 0;
            label1.Text = "Category Management";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(51, 187);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(69, 20);
            label2.TabIndex = 1;
            label2.Text = "Category";
            // 
            // tbCategory
            // 
            tbCategory.Location = new System.Drawing.Point(158, 184);
            tbCategory.Name = "tbCategory";
            tbCategory.Size = new System.Drawing.Size(233, 27);
            tbCategory.TabIndex = 2;
            // 
            // btnCreate
            // 
            btnCreate.Location = new System.Drawing.Point(54, 260);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new System.Drawing.Size(94, 29);
            btnCreate.TabIndex = 3;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += CreateCategory;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new System.Drawing.Point(177, 260);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new System.Drawing.Size(94, 29);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += UpdateCategory;
            // 
            // btnDelete
            // 
            btnDelete.Location = new System.Drawing.Point(297, 260);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(94, 29);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += DeleteCategory;
            // 
            // dgvCategory
            // 
            dgvCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategory.Location = new System.Drawing.Point(444, 34);
            dgvCategory.Name = "dgvCategory";
            dgvCategory.RowHeadersWidth = 51;
            dgvCategory.RowTemplate.Height = 29;
            dgvCategory.Size = new System.Drawing.Size(515, 370);
            dgvCategory.TabIndex = 6;
            dgvCategory.CellContentClick += ClickCellShowContent;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(54, 121);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(24, 20);
            label3.TabIndex = 7;
            label3.Text = "ID";
            // 
            // tbId
            // 
            tbId.Enabled = false;
            tbId.Location = new System.Drawing.Point(158, 121);
            tbId.Name = "tbId";
            tbId.Size = new System.Drawing.Size(233, 27);
            tbId.TabIndex = 8;
            // 
            // frmCategory
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(985, 450);
            Controls.Add(tbId);
            Controls.Add(label3);
            Controls.Add(dgvCategory);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnCreate);
            Controls.Add(tbCategory);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmCategory";
            Text = "frmCategory";
            ((System.ComponentModel.ISupportInitialize)dgvCategory).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbCategory;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvCategory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbId;
    }
}
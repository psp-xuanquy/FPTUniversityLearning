namespace SaleManagementWinApp
{
    partial class frmProducts
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
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            dgvProductList = new System.Windows.Forms.DataGridView();
            txtProductID = new System.Windows.Forms.MaskedTextBox();
            txtProductName = new System.Windows.Forms.TextBox();
            btnCreate = new System.Windows.Forms.Button();
            btnUpdate = new System.Windows.Forms.Button();
            btnDelete = new System.Windows.Forms.Button();
            txtUnitPrice = new System.Windows.Forms.TextBox();
            txtWeight = new System.Windows.Forms.TextBox();
            txtUnitInStock = new System.Windows.Forms.TextBox();
            txtSearchProduct = new System.Windows.Forms.TextBox();
            btnSearch = new System.Windows.Forms.Button();
            cbCategory = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvProductList).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(58, 156);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(79, 20);
            label1.TabIndex = 0;
            label1.Text = "Product ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(58, 227);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(104, 20);
            label2.TabIndex = 1;
            label2.Text = "Product Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(58, 295);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(72, 20);
            label3.TabIndex = 2;
            label3.Text = "Unit Price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(58, 365);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(88, 20);
            label4.TabIndex = 3;
            label4.Text = "Category ID";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(72, 61);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(385, 39);
            label5.TabIndex = 4;
            label5.Text = "Product Management";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(58, 432);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(56, 20);
            label6.TabIndex = 5;
            label6.Text = "Weight";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(58, 499);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(90, 20);
            label7.TabIndex = 6;
            label7.Text = "Unit in stock";
            // 
            // dgvProductList
            // 
            dgvProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductList.Location = new System.Drawing.Point(441, 152);
            dgvProductList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dgvProductList.Name = "dgvProductList";
            dgvProductList.RowHeadersWidth = 51;
            dgvProductList.RowTemplate.Height = 25;
            dgvProductList.Size = new System.Drawing.Size(610, 436);
            dgvProductList.TabIndex = 7;
            dgvProductList.CellContentClick += dgvProductList_CellContentClick;
            // 
            // txtProductID
            // 
            txtProductID.Location = new System.Drawing.Point(182, 152);
            txtProductID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtProductID.Name = "txtProductID";
            txtProductID.Size = new System.Drawing.Size(238, 27);
            txtProductID.TabIndex = 8;
            // 
            // txtProductName
            // 
            txtProductName.Location = new System.Drawing.Point(182, 223);
            txtProductName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new System.Drawing.Size(238, 27);
            txtProductName.TabIndex = 9;
            // 
            // btnCreate
            // 
            btnCreate.Location = new System.Drawing.Point(101, 548);
            btnCreate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new System.Drawing.Size(86, 31);
            btnCreate.TabIndex = 10;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new System.Drawing.Point(222, 548);
            btnUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new System.Drawing.Size(86, 31);
            btnUpdate.TabIndex = 11;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new System.Drawing.Point(335, 548);
            btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(86, 31);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new System.Drawing.Point(182, 291);
            txtUnitPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new System.Drawing.Size(238, 27);
            txtUnitPrice.TabIndex = 13;
            // 
            // txtWeight
            // 
            txtWeight.Location = new System.Drawing.Point(182, 428);
            txtWeight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new System.Drawing.Size(238, 27);
            txtWeight.TabIndex = 15;
            // 
            // txtUnitInStock
            // 
            txtUnitInStock.Location = new System.Drawing.Point(182, 495);
            txtUnitInStock.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtUnitInStock.Name = "txtUnitInStock";
            txtUnitInStock.Size = new System.Drawing.Size(238, 27);
            txtUnitInStock.TabIndex = 16;
            // 
            // txtSearchProduct
            // 
            txtSearchProduct.Location = new System.Drawing.Point(551, 76);
            txtSearchProduct.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtSearchProduct.Name = "txtSearchProduct";
            txtSearchProduct.Size = new System.Drawing.Size(407, 27);
            txtSearchProduct.TabIndex = 17;
            // 
            // btnSearch
            // 
            btnSearch.Location = new System.Drawing.Point(966, 75);
            btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new System.Drawing.Size(86, 31);
            btnSearch.TabIndex = 18;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // cbCategory
            // 
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new System.Drawing.Point(182, 362);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new System.Drawing.Size(239, 28);
            cbCategory.TabIndex = 19;
            // 
            // frmProducts
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1065, 604);
            Controls.Add(cbCategory);
            Controls.Add(btnSearch);
            Controls.Add(txtSearchProduct);
            Controls.Add(txtUnitInStock);
            Controls.Add(txtWeight);
            Controls.Add(txtUnitPrice);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnCreate);
            Controls.Add(txtProductName);
            Controls.Add(txtProductID);
            Controls.Add(dgvProductList);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "frmProducts";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "frmProducts";
            ((System.ComponentModel.ISupportInitialize)dgvProductList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvProductList;
        private System.Windows.Forms.MaskedTextBox txtProductID;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.TextBox txtUnitInStock;
        private System.Windows.Forms.TextBox txtSearchProduct;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cbCategory;
    }
}
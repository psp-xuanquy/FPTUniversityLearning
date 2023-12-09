
namespace ConvenienceStoreApp
{
    partial class ucProductManagement
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
            label11 = new System.Windows.Forms.Label();
            txtSearchValue = new System.Windows.Forms.TextBox();
            btnSearch = new System.Windows.Forms.Button();
            dgvProductList = new System.Windows.Forms.DataGridView();
            cboSelect = new System.Windows.Forms.ComboBox();
            label12 = new System.Windows.Forms.Label();
            btnRefresh = new System.Windows.Forms.Button();
            btnAvailable = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            lbCate = new System.Windows.Forms.Label();
            txtProductID = new System.Windows.Forms.TextBox();
            txtProductName = new System.Windows.Forms.TextBox();
            txtPrice = new System.Windows.Forms.TextBox();
            txtQuantity = new System.Windows.Forms.TextBox();
            btnAdd = new System.Windows.Forms.Button();
            btnUpdate = new System.Windows.Forms.Button();
            cboCategoryID = new System.Windows.Forms.ComboBox();
            lbStatus = new System.Windows.Forms.Label();
            cboStatusID = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvProductList).BeginInit();
            SuspendLayout();
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label11.Location = new System.Drawing.Point(3, 0);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(477, 60);
            label11.TabIndex = 35;
            label11.Text = "Product Management";
            // 
            // txtSearchValue
            // 
            txtSearchValue.Location = new System.Drawing.Point(136, 141);
            txtSearchValue.Name = "txtSearchValue";
            txtSearchValue.Size = new System.Drawing.Size(261, 27);
            txtSearchValue.TabIndex = 38;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = System.Drawing.SystemColors.Highlight;
            btnSearch.ForeColor = System.Drawing.Color.White;
            btnSearch.Location = new System.Drawing.Point(136, 184);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new System.Drawing.Size(94, 37);
            btnSearch.TabIndex = 40;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // dgvProductList
            // 
            dgvProductList.AllowUserToAddRows = false;
            dgvProductList.AllowUserToDeleteRows = false;
            dgvProductList.AllowUserToResizeColumns = false;
            dgvProductList.AllowUserToResizeRows = false;
            dgvProductList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvProductList.BackgroundColor = System.Drawing.Color.White;
            dgvProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductList.Location = new System.Drawing.Point(3, 323);
            dgvProductList.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            dgvProductList.Name = "dgvProductList";
            dgvProductList.ReadOnly = true;
            dgvProductList.RowHeadersWidth = 51;
            dgvProductList.RowTemplate.Height = 29;
            dgvProductList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvProductList.Size = new System.Drawing.Size(1234, 413);
            dgvProductList.TabIndex = 41;
            // 
            // cboSelect
            // 
            cboSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboSelect.FormattingEnabled = true;
            cboSelect.Items.AddRange(new object[] { "Product ID", "Product Name", "Category ID" });
            cboSelect.Location = new System.Drawing.Point(11, 140);
            cboSelect.Name = "cboSelect";
            cboSelect.Size = new System.Drawing.Size(118, 28);
            cboSelect.TabIndex = 42;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label12.ForeColor = System.Drawing.SystemColors.Highlight;
            label12.Location = new System.Drawing.Point(11, 69);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(124, 45);
            label12.TabIndex = 43;
            label12.Text = "Search";
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = System.Drawing.SystemColors.Highlight;
            btnRefresh.ForeColor = System.Drawing.Color.White;
            btnRefresh.Location = new System.Drawing.Point(3, 279);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new System.Drawing.Size(94, 37);
            btnRefresh.TabIndex = 44;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnAvailable
            // 
            btnAvailable.BackColor = System.Drawing.SystemColors.Highlight;
            btnAvailable.ForeColor = System.Drawing.Color.White;
            btnAvailable.Location = new System.Drawing.Point(103, 279);
            btnAvailable.Name = "btnAvailable";
            btnAvailable.Size = new System.Drawing.Size(118, 37);
            btnAvailable.TabIndex = 45;
            btnAvailable.Text = "In Stock";
            btnAvailable.UseVisualStyleBackColor = false;
            btnAvailable.Click += btnAvailable_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.SystemColors.Highlight;
            label1.Location = new System.Drawing.Point(637, 69);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(432, 45);
            label1.TabIndex = 46;
            label1.Text = "Product detail information";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(614, 133);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(79, 20);
            label2.TabIndex = 47;
            label2.Text = "Product ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(589, 184);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(104, 20);
            label3.TabIndex = 48;
            label3.Text = "Product Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(651, 236);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(41, 20);
            label4.TabIndex = 49;
            label4.Text = "Price";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(891, 133);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(65, 20);
            label5.TabIndex = 50;
            label5.Text = "Quantity";
            // 
            // lbCate
            // 
            lbCate.AutoSize = true;
            lbCate.Location = new System.Drawing.Point(869, 184);
            lbCate.Name = "lbCate";
            lbCate.Size = new System.Drawing.Size(88, 20);
            lbCate.TabIndex = 52;
            lbCate.Text = "Category ID";
            // 
            // txtProductID
            // 
            txtProductID.Location = new System.Drawing.Point(699, 131);
            txtProductID.Name = "txtProductID";
            txtProductID.Size = new System.Drawing.Size(148, 27);
            txtProductID.TabIndex = 54;
            // 
            // txtProductName
            // 
            txtProductName.Location = new System.Drawing.Point(699, 181);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new System.Drawing.Size(148, 27);
            txtProductName.TabIndex = 55;
            // 
            // txtPrice
            // 
            txtPrice.Location = new System.Drawing.Point(699, 233);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new System.Drawing.Size(148, 27);
            txtPrice.TabIndex = 56;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new System.Drawing.Point(962, 131);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new System.Drawing.Size(154, 27);
            txtQuantity.TabIndex = 57;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = System.Drawing.SystemColors.Highlight;
            btnAdd.ForeColor = System.Drawing.Color.White;
            btnAdd.Location = new System.Drawing.Point(699, 279);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(94, 37);
            btnAdd.TabIndex = 61;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = System.Drawing.SystemColors.Highlight;
            btnUpdate.ForeColor = System.Drawing.Color.White;
            btnUpdate.Location = new System.Drawing.Point(827, 279);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new System.Drawing.Size(94, 37);
            btnUpdate.TabIndex = 62;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // cboCategoryID
            // 
            cboCategoryID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboCategoryID.FormattingEnabled = true;
            cboCategoryID.Location = new System.Drawing.Point(962, 181);
            cboCategoryID.Name = "cboCategoryID";
            cboCategoryID.Size = new System.Drawing.Size(154, 28);
            cboCategoryID.TabIndex = 64;
            // 
            // lbStatus
            // 
            lbStatus.AutoSize = true;
            lbStatus.Location = new System.Drawing.Point(888, 236);
            lbStatus.Name = "lbStatus";
            lbStatus.Size = new System.Drawing.Size(68, 20);
            lbStatus.TabIndex = 53;
            lbStatus.Text = "Status ID";
            // 
            // cboStatusID
            // 
            cboStatusID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboStatusID.FormattingEnabled = true;
            cboStatusID.Items.AddRange(new object[] { "Available", "Not Avaiable" });
            cboStatusID.Location = new System.Drawing.Point(962, 232);
            cboStatusID.Name = "cboStatusID";
            cboStatusID.Size = new System.Drawing.Size(154, 28);
            cboStatusID.TabIndex = 63;
            // 
            // ucProductManagement
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(cboCategoryID);
            Controls.Add(cboStatusID);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(txtQuantity);
            Controls.Add(txtPrice);
            Controls.Add(txtProductName);
            Controls.Add(txtProductID);
            Controls.Add(lbStatus);
            Controls.Add(lbCate);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnAvailable);
            Controls.Add(btnRefresh);
            Controls.Add(label12);
            Controls.Add(cboSelect);
            Controls.Add(dgvProductList);
            Controls.Add(btnSearch);
            Controls.Add(txtSearchValue);
            Controls.Add(label11);
            Name = "ucProductManagement";
            Size = new System.Drawing.Size(1240, 739);
            Load += ucProductManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtSearchValue;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvProductList;
        private System.Windows.Forms.ComboBox cboSelect;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnAvailable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbCate;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox cboCategoryID;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.ComboBox cboStatusID;
    }
}

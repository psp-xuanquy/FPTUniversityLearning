
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
            this.label11 = new System.Windows.Forms.Label();
            this.txtSearchValue = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvProductList = new System.Windows.Forms.DataGridView();
            this.cboSelect = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnAvailable = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbCate = new System.Windows.Forms.Label();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.cboCategoryID = new System.Windows.Forms.ComboBox();
            this.lbStatus = new System.Windows.Forms.Label();
            this.cboStatusID = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductList)).BeginInit();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(3, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(381, 47);
            this.label11.TabIndex = 35;
            this.label11.Text = "Product Management";
            // 
            // txtSearchValue
            // 
            this.txtSearchValue.Location = new System.Drawing.Point(119, 106);
            this.txtSearchValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearchValue.Name = "txtSearchValue";
            this.txtSearchValue.Size = new System.Drawing.Size(229, 23);
            this.txtSearchValue.TabIndex = 38;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(119, 138);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(82, 28);
            this.btnSearch.TabIndex = 40;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvProductList
            // 
            this.dgvProductList.AllowUserToAddRows = false;
            this.dgvProductList.AllowUserToDeleteRows = false;
            this.dgvProductList.AllowUserToResizeColumns = false;
            this.dgvProductList.AllowUserToResizeRows = false;
            this.dgvProductList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductList.BackgroundColor = System.Drawing.Color.White;
            this.dgvProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductList.Location = new System.Drawing.Point(3, 242);
            this.dgvProductList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvProductList.Name = "dgvProductList";
            this.dgvProductList.ReadOnly = true;
            this.dgvProductList.RowHeadersWidth = 51;
            this.dgvProductList.RowTemplate.Height = 29;
            this.dgvProductList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductList.Size = new System.Drawing.Size(1080, 310);
            this.dgvProductList.TabIndex = 41;
            // 
            // cboSelect
            // 
            this.cboSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSelect.FormattingEnabled = true;
            this.cboSelect.Items.AddRange(new object[] {
            "Product ID",
            "Product Name",
            "Category ID"});
            this.cboSelect.Location = new System.Drawing.Point(10, 105);
            this.cboSelect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboSelect.Name = "cboSelect";
            this.cboSelect.Size = new System.Drawing.Size(104, 23);
            this.cboSelect.TabIndex = 42;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label12.Location = new System.Drawing.Point(10, 52);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(102, 37);
            this.label12.TabIndex = 43;
            this.label12.Text = "Search";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(3, 209);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(82, 28);
            this.btnRefresh.TabIndex = 44;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnAvailable
            // 
            this.btnAvailable.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAvailable.ForeColor = System.Drawing.Color.White;
            this.btnAvailable.Location = new System.Drawing.Point(90, 209);
            this.btnAvailable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAvailable.Name = "btnAvailable";
            this.btnAvailable.Size = new System.Drawing.Size(103, 28);
            this.btnAvailable.TabIndex = 45;
            this.btnAvailable.Text = "In Stock";
            this.btnAvailable.UseVisualStyleBackColor = false;
            this.btnAvailable.Click += new System.EventHandler(this.btnAvailable_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(557, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 37);
            this.label1.TabIndex = 46;
            this.label1.Text = "Product detail information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(537, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 47;
            this.label2.Text = "Product ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(515, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 15);
            this.label3.TabIndex = 48;
            this.label3.Text = "Product Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(570, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 15);
            this.label4.TabIndex = 49;
            this.label4.Text = "Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(780, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 15);
            this.label5.TabIndex = 50;
            this.label5.Text = "Quantity";
            // 
            // lbCate
            // 
            this.lbCate.AutoSize = true;
            this.lbCate.Location = new System.Drawing.Point(760, 138);
            this.lbCate.Name = "lbCate";
            this.lbCate.Size = new System.Drawing.Size(69, 15);
            this.lbCate.TabIndex = 52;
            this.lbCate.Text = "Category ID";
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(612, 98);
            this.txtProductID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(130, 23);
            this.txtProductID.TabIndex = 54;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(612, 136);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(130, 23);
            this.txtProductName.TabIndex = 55;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(612, 175);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(130, 23);
            this.txtPrice.TabIndex = 56;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(842, 98);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(135, 23);
            this.txtQuantity.TabIndex = 57;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(612, 209);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(82, 28);
            this.btnAdd.TabIndex = 61;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(724, 209);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(82, 28);
            this.btnUpdate.TabIndex = 62;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // cboCategoryID
            // 
            this.cboCategoryID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategoryID.FormattingEnabled = true;
            this.cboCategoryID.Items.AddRange(new object[] {
            "1. Drinks",
            "2. Food",
            "3. Electronics"});
            this.cboCategoryID.Location = new System.Drawing.Point(842, 136);
            this.cboCategoryID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboCategoryID.Name = "cboCategoryID";
            this.cboCategoryID.Size = new System.Drawing.Size(135, 23);
            this.cboCategoryID.TabIndex = 64;
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(777, 177);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(53, 15);
            this.lbStatus.TabIndex = 53;
            this.lbStatus.Text = "Status ID";
            // 
            // cboStatusID
            // 
            this.cboStatusID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatusID.FormattingEnabled = true;
            this.cboStatusID.Items.AddRange(new object[] {
            "Available"});
            this.cboStatusID.Location = new System.Drawing.Point(842, 174);
            this.cboStatusID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboStatusID.Name = "cboStatusID";
            this.cboStatusID.Size = new System.Drawing.Size(135, 23);
            this.cboStatusID.TabIndex = 63;
            // 
            // ucProductManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cboCategoryID);
            this.Controls.Add(this.cboStatusID);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.txtProductID);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.lbCate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAvailable);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cboSelect);
            this.Controls.Add(this.dgvProductList);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearchValue);
            this.Controls.Add(this.label11);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ucProductManagement";
            this.Size = new System.Drawing.Size(1085, 554);
            this.Load += new System.EventHandler(this.ucProductManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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

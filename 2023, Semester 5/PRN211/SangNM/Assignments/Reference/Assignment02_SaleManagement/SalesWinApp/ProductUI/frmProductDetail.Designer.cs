
namespace SalesWinApp.ProductUI
{
    partial class frmProductDetail
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
            lbProductID = new System.Windows.Forms.Label();
            lbProductName = new System.Windows.Forms.Label();
            lbCategory = new System.Windows.Forms.Label();
            lbWeight = new System.Windows.Forms.Label();
            lbUnitPrice = new System.Windows.Forms.Label();
            lbUnitsInStock = new System.Windows.Forms.Label();
            btnAction = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            txtProductId = new System.Windows.Forms.TextBox();
            txtProductName = new System.Windows.Forms.TextBox();
            cboCategory = new System.Windows.Forms.ComboBox();
            txtWeight = new System.Windows.Forms.TextBox();
            numUnitsInStock = new System.Windows.Forms.NumericUpDown();
            numUnitPrice = new System.Windows.Forms.NumericUpDown();
            lbNote = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)numUnitsInStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numUnitPrice).BeginInit();
            SuspendLayout();
            // 
            // lbProductID
            // 
            lbProductID.AutoSize = true;
            lbProductID.Location = new System.Drawing.Point(14, 25);
            lbProductID.Name = "lbProductID";
            lbProductID.Size = new System.Drawing.Size(79, 20);
            lbProductID.TabIndex = 0;
            lbProductID.Text = "Product ID";
            // 
            // lbProductName
            // 
            lbProductName.AutoSize = true;
            lbProductName.Location = new System.Drawing.Point(14, 79);
            lbProductName.Name = "lbProductName";
            lbProductName.Size = new System.Drawing.Size(104, 20);
            lbProductName.TabIndex = 1;
            lbProductName.Text = "Product Name";
            // 
            // lbCategory
            // 
            lbCategory.AutoSize = true;
            lbCategory.Location = new System.Drawing.Point(14, 136);
            lbCategory.Name = "lbCategory";
            lbCategory.Size = new System.Drawing.Size(69, 20);
            lbCategory.TabIndex = 2;
            lbCategory.Text = "Category";
            // 
            // lbWeight
            // 
            lbWeight.AutoSize = true;
            lbWeight.Location = new System.Drawing.Point(14, 196);
            lbWeight.Name = "lbWeight";
            lbWeight.Size = new System.Drawing.Size(56, 20);
            lbWeight.TabIndex = 3;
            lbWeight.Text = "Weight";
            // 
            // lbUnitPrice
            // 
            lbUnitPrice.AutoSize = true;
            lbUnitPrice.Location = new System.Drawing.Point(14, 257);
            lbUnitPrice.Name = "lbUnitPrice";
            lbUnitPrice.Size = new System.Drawing.Size(72, 20);
            lbUnitPrice.TabIndex = 4;
            lbUnitPrice.Text = "Unit Price";
            // 
            // lbUnitsInStock
            // 
            lbUnitsInStock.AutoSize = true;
            lbUnitsInStock.Location = new System.Drawing.Point(14, 319);
            lbUnitsInStock.Name = "lbUnitsInStock";
            lbUnitsInStock.Size = new System.Drawing.Size(98, 20);
            lbUnitsInStock.TabIndex = 5;
            lbUnitsInStock.Text = "Units In Stock";
            // 
            // btnAction
            // 
            btnAction.DialogResult = System.Windows.Forms.DialogResult.OK;
            btnAction.Location = new System.Drawing.Point(41, 399);
            btnAction.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnAction.Name = "btnAction";
            btnAction.Size = new System.Drawing.Size(111, 31);
            btnAction.TabIndex = 14;
            btnAction.Text = "&Add";
            btnAction.UseVisualStyleBackColor = true;
            btnAction.Click += btnAction_Click;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnCancel.Location = new System.Drawing.Point(214, 399);
            btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(111, 31);
            btnCancel.TabIndex = 15;
            btnCancel.Text = "&Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtProductId
            // 
            txtProductId.Enabled = false;
            txtProductId.Location = new System.Drawing.Point(157, 21);
            txtProductId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtProductId.Name = "txtProductId";
            txtProductId.Size = new System.Drawing.Size(209, 27);
            txtProductId.TabIndex = 8;
            // 
            // txtProductName
            // 
            txtProductName.Location = new System.Drawing.Point(157, 75);
            txtProductName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new System.Drawing.Size(209, 27);
            txtProductName.TabIndex = 9;
            // 
            // cboCategory
            // 
            cboCategory.FormattingEnabled = true;
            cboCategory.Location = new System.Drawing.Point(157, 132);
            cboCategory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new System.Drawing.Size(209, 28);
            cboCategory.TabIndex = 10;
            cboCategory.SelectedIndexChanged += cboCategory_SelectedIndexChanged;
            // 
            // txtWeight
            // 
            txtWeight.Location = new System.Drawing.Point(157, 192);
            txtWeight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new System.Drawing.Size(209, 27);
            txtWeight.TabIndex = 11;
            // 
            // numUnitsInStock
            // 
            numUnitsInStock.Location = new System.Drawing.Point(155, 316);
            numUnitsInStock.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            numUnitsInStock.Name = "numUnitsInStock";
            numUnitsInStock.Size = new System.Drawing.Size(210, 27);
            numUnitsInStock.TabIndex = 13;
            numUnitsInStock.ValueChanged += numUnitsInStock_ValueChanged;
            // 
            // numUnitPrice
            // 
            numUnitPrice.DecimalPlaces = 2;
            numUnitPrice.Location = new System.Drawing.Point(157, 255);
            numUnitPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            numUnitPrice.Name = "numUnitPrice";
            numUnitPrice.Size = new System.Drawing.Size(209, 27);
            numUnitPrice.TabIndex = 12;
            // 
            // lbNote
            // 
            lbNote.AutoSize = true;
            lbNote.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            lbNote.Location = new System.Drawing.Point(155, 351);
            lbNote.Name = "lbNote";
            lbNote.Size = new System.Drawing.Size(235, 19);
            lbNote.TabIndex = 16;
            lbNote.Text = "Enter Quantity you want to order < ";
            lbNote.Visible = false;
            // 
            // frmProductDetail
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(379, 445);
            Controls.Add(lbNote);
            Controls.Add(numUnitPrice);
            Controls.Add(numUnitsInStock);
            Controls.Add(txtWeight);
            Controls.Add(cboCategory);
            Controls.Add(txtProductName);
            Controls.Add(txtProductId);
            Controls.Add(btnCancel);
            Controls.Add(btnAction);
            Controls.Add(lbUnitsInStock);
            Controls.Add(lbUnitPrice);
            Controls.Add(lbWeight);
            Controls.Add(lbCategory);
            Controls.Add(lbProductName);
            Controls.Add(lbProductID);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "frmProductDetail";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Product Details";
            Load += frmProductDetail_Load;
            ((System.ComponentModel.ISupportInitialize)numUnitsInStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)numUnitPrice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lbProductID;
        private System.Windows.Forms.Label lbProductName;
        private System.Windows.Forms.Label lbCategory;
        private System.Windows.Forms.Label lbWeight;
        private System.Windows.Forms.Label lbUnitPrice;
        private System.Windows.Forms.Label lbUnitsInStock;
        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtProductId;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.NumericUpDown numUnitsInStock;
        private System.Windows.Forms.NumericUpDown numUnitPrice;
        private System.Windows.Forms.Label lbNote;
    }
}
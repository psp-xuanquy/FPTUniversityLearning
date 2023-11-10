namespace AirConditionerShop_DaoXuanQuy
{
    partial class frmAirConditionerManagement
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
            txtPrice = new System.Windows.Forms.TextBox();
            txtAirConditionerName = new System.Windows.Forms.TextBox();
            txtWarranty = new System.Windows.Forms.TextBox();
            txtSound = new System.Windows.Forms.TextBox();
            txtFeatureFunction = new System.Windows.Forms.TextBox();
            txtAirConditionerID = new System.Windows.Forms.TextBox();
            SupplierName = new System.Windows.Forms.Label();
            DollarPrice = new System.Windows.Forms.Label();
            FeatureFunction = new System.Windows.Forms.Label();
            SoundPressureLevel = new System.Windows.Forms.Label();
            Warranty = new System.Windows.Forms.Label();
            AirConditionerName = new System.Windows.Forms.Label();
            AirConditionerID = new System.Windows.Forms.Label();
            btnExit = new System.Windows.Forms.Button();
            btnDelete = new System.Windows.Forms.Button();
            btnUpdate = new System.Windows.Forms.Button();
            btnSave = new System.Windows.Forms.Button();
            btnNew = new System.Windows.Forms.Button();
            dgvList = new System.Windows.Forms.DataGridView();
            cboSupplierCompany = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvList).BeginInit();
            SuspendLayout();
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(172, 294);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(265, 27);
            txtPrice.TabIndex = 38;
            // 
            // txtAirConditionerName
            // 
            txtAirConditionerName.Location = new Point(172, 61);
            txtAirConditionerName.Name = "txtAirConditionerName";
            txtAirConditionerName.Size = new Size(265, 27);
            txtAirConditionerName.TabIndex = 36;
            // 
            // txtWarranty
            // 
            txtWarranty.Location = new Point(172, 106);
            txtWarranty.Name = "txtWarranty";
            txtWarranty.Size = new Size(265, 27);
            txtWarranty.TabIndex = 35;
            // 
            // txtSound
            // 
            txtSound.Location = new Point(172, 140);
            txtSound.Name = "txtSound";
            txtSound.Size = new Size(265, 27);
            txtSound.TabIndex = 34;
            // 
            // txtFeatureFunction
            // 
            txtFeatureFunction.Location = new Point(172, 180);
            txtFeatureFunction.Margin = new System.Windows.Forms.Padding(9);
            txtFeatureFunction.Name = "txtFeatureFunction";
            txtFeatureFunction.Size = new Size(265, 27);
            txtFeatureFunction.TabIndex = 33;
            // 
            // txtAirConditionerID
            // 
            txtAirConditionerID.Location = new Point(172, 23);
            txtAirConditionerID.Name = "txtAirConditionerID";
            txtAirConditionerID.Size = new Size(265, 27);
            txtAirConditionerID.TabIndex = 32;
            // 
            // SupplierName
            // 
            SupplierName.AutoSize = true;
            SupplierName.Location = new Point(19, 346);
            SupplierName.Name = "SupplierName";
            SupplierName.Size = new Size(131, 20);
            SupplierName.TabIndex = 31;
            SupplierName.Text = "Supplier Company";
            // 
            // DollarPrice
            // 
            DollarPrice.AutoSize = true;
            DollarPrice.Location = new Point(19, 297);
            DollarPrice.Name = "DollarPrice";
            DollarPrice.Size = new Size(86, 20);
            DollarPrice.TabIndex = 30;
            DollarPrice.Text = "Dollar Price";
            // 
            // FeatureFunction
            // 
            FeatureFunction.AutoSize = true;
            FeatureFunction.Location = new Point(19, 183);
            FeatureFunction.Name = "FeatureFunction";
            FeatureFunction.Size = new Size(124, 20);
            FeatureFunction.TabIndex = 29;
            FeatureFunction.Text = "Feature Functions";
            // 
            // SoundPressureLevel
            // 
            SoundPressureLevel.AutoSize = true;
            SoundPressureLevel.Location = new Point(19, 143);
            SoundPressureLevel.Name = "SoundPressureLevel";
            SoundPressureLevel.Size = new Size(147, 20);
            SoundPressureLevel.TabIndex = 28;
            SoundPressureLevel.Text = "Sound Pressure Level";
            // 
            // Warranty
            // 
            Warranty.AutoSize = true;
            Warranty.Location = new Point(19, 109);
            Warranty.Name = "Warranty";
            Warranty.Size = new Size(68, 20);
            Warranty.TabIndex = 27;
            Warranty.Text = "Warranty";
            // 
            // AirConditionerName
            // 
            AirConditionerName.AutoSize = true;
            AirConditionerName.Location = new Point(19, 64);
            AirConditionerName.Name = "AirConditionerName";
            AirConditionerName.Size = new Size(72, 20);
            AirConditionerName.TabIndex = 26;
            AirConditionerName.Text = "AC Name";
            // 
            // AirConditionerID
            // 
            AirConditionerID.AutoSize = true;
            AirConditionerID.Location = new Point(19, 26);
            AirConditionerID.Name = "AirConditionerID";
            AirConditionerID.Size = new Size(24, 20);
            AirConditionerID.TabIndex = 25;
            AirConditionerID.Text = "ID";
            // 
            // btnExit
            // 
            btnExit.Location = new Point(351, 395);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(77, 33);
            btnExit.TabIndex = 24;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click_1;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(268, 395);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(77, 33);
            btnDelete.TabIndex = 23;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click_1;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(185, 395);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(77, 33);
            btnUpdate.TabIndex = 22;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click_1;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(102, 395);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(77, 33);
            btnSave.TabIndex = 21;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click_1;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(19, 395);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(77, 33);
            btnNew.TabIndex = 20;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click_1;
            // 
            // dgvList
            // 
            dgvList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvList.Location = new Point(458, 26);
            dgvList.Name = "dgvList";
            dgvList.RowHeadersWidth = 51;
            dgvList.RowTemplate.Height = 29;
            dgvList.Size = new Size(324, 402);
            dgvList.TabIndex = 19;
            // 
            // cboSupplierCompany
            // 
            cboSupplierCompany.FormattingEnabled = true;
            cboSupplierCompany.Location = new Point(172, 343);
            cboSupplierCompany.Name = "cboSupplierCompany";
            cboSupplierCompany.Size = new Size(265, 28);
            cboSupplierCompany.TabIndex = 39;
            // 
            // frmAirConditionerManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cboSupplierCompany);
            Controls.Add(txtPrice);
            Controls.Add(txtAirConditionerName);
            Controls.Add(txtWarranty);
            Controls.Add(txtSound);
            Controls.Add(txtFeatureFunction);
            Controls.Add(txtAirConditionerID);
            Controls.Add(SupplierName);
            Controls.Add(DollarPrice);
            Controls.Add(FeatureFunction);
            Controls.Add(SoundPressureLevel);
            Controls.Add(Warranty);
            Controls.Add(AirConditionerName);
            Controls.Add(AirConditionerID);
            Controls.Add(btnExit);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnSave);
            Controls.Add(btnNew);
            Controls.Add(dgvList);
            Name = "frmAirConditionerManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Air-Conditioner Management";
            Load += frmAirConditionerManagement_Load;
            FormClosing += frmAirConditionerManagement_FormClosing;
            ((System.ComponentModel.ISupportInitialize)dgvList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtAirConditionerName;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtWarranty;
        private System.Windows.Forms.TextBox txtSound;
        private System.Windows.Forms.TextBox txtFeatureFunction;
        private System.Windows.Forms.TextBox txtAirConditionerID;
        private System.Windows.Forms.Label SupplierName;
        private System.Windows.Forms.Label DollarPrice;
        private System.Windows.Forms.Label FeatureFunction;
        private System.Windows.Forms.Label SoundPressureLevel;
        private System.Windows.Forms.Label Warranty;
        private System.Windows.Forms.Label AirConditionerName;
        private System.Windows.Forms.Label AirConditionerID;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.ComboBox cboSupplierCompany;
    }
}
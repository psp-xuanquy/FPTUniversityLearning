namespace BookStore_HoangNT
{
    partial class SunglassesForm
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
            lblFormTitle = new Label();
            gbSunGlassesInfo = new GroupBox();
            lblMaterial = new Label();
            lblFeature = new Label();
            txtMaterial = new TextBox();
            txtFeature = new TextBox();
            mtbQuantity = new MaskedTextBox();
            mtbPrice = new MaskedTextBox();
            cboCategory = new ComboBox();
            dtpReleasedDate = new DateTimePicker();
            txtShape = new TextBox();
            txtName = new TextBox();
            txtId = new TextBox();
            lblManufacturerId = new Label();
            lblShape = new Label();
            lblPrice = new Label();
            lblQuantity = new Label();
            lblCreatedDate = new Label();
            lblName = new Label();
            lblId = new Label();
            btnCancel = new Button();
            btnSave = new Button();
            gbSunGlassesInfo.SuspendLayout();
            SuspendLayout();
            // 
            // lblFormTitle
            // 
            lblFormTitle.AutoSize = true;
            lblFormTitle.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            lblFormTitle.ForeColor = Color.SkyBlue;
            lblFormTitle.Location = new Point(53, 18);
            lblFormTitle.Name = "lblFormTitle";
            lblFormTitle.Size = new Size(369, 46);
            lblFormTitle.TabIndex = 21;
            lblFormTitle.Text = "Add/Update SunGlass";
            // 
            // gbSunGlassesInfo
            // 
            gbSunGlassesInfo.Controls.Add(lblMaterial);
            gbSunGlassesInfo.Controls.Add(lblFeature);
            gbSunGlassesInfo.Controls.Add(txtMaterial);
            gbSunGlassesInfo.Controls.Add(txtFeature);
            gbSunGlassesInfo.Controls.Add(mtbQuantity);
            gbSunGlassesInfo.Controls.Add(mtbPrice);
            gbSunGlassesInfo.Controls.Add(cboCategory);
            gbSunGlassesInfo.Controls.Add(dtpReleasedDate);
            gbSunGlassesInfo.Controls.Add(txtShape);
            gbSunGlassesInfo.Controls.Add(txtName);
            gbSunGlassesInfo.Controls.Add(txtId);
            gbSunGlassesInfo.Controls.Add(lblManufacturerId);
            gbSunGlassesInfo.Controls.Add(lblShape);
            gbSunGlassesInfo.Controls.Add(lblPrice);
            gbSunGlassesInfo.Controls.Add(lblQuantity);
            gbSunGlassesInfo.Controls.Add(lblCreatedDate);
            gbSunGlassesInfo.Controls.Add(lblName);
            gbSunGlassesInfo.Controls.Add(lblId);
            gbSunGlassesInfo.ForeColor = Color.Black;
            gbSunGlassesInfo.Location = new Point(53, 101);
            gbSunGlassesInfo.Name = "gbSunGlassesInfo";
            gbSunGlassesInfo.Size = new Size(514, 445);
            gbSunGlassesInfo.TabIndex = 22;
            gbSunGlassesInfo.TabStop = false;
            gbSunGlassesInfo.Text = " SunGlass Info ";
            // 
            // lblMaterial
            // 
            lblMaterial.AutoSize = true;
            lblMaterial.Location = new Point(17, 174);
            lblMaterial.Name = "lblMaterial";
            lblMaterial.Size = new Size(64, 20);
            lblMaterial.TabIndex = 12;
            lblMaterial.Text = "Material";
            // 
            // lblFeature
            // 
            lblFeature.AutoSize = true;
            lblFeature.Location = new Point(17, 129);
            lblFeature.Name = "lblFeature";
            lblFeature.Size = new Size(58, 20);
            lblFeature.TabIndex = 11;
            lblFeature.Text = "Feature";
            // 
            // txtMaterial
            // 
            txtMaterial.Location = new Point(146, 171);
            txtMaterial.Name = "txtMaterial";
            txtMaterial.Size = new Size(353, 27);
            txtMaterial.TabIndex = 10;
            // 
            // txtFeature
            // 
            txtFeature.Location = new Point(146, 126);
            txtFeature.Name = "txtFeature";
            txtFeature.Size = new Size(353, 27);
            txtFeature.TabIndex = 8;
            // 
            // mtbQuantity
            // 
            mtbQuantity.Location = new Point(146, 279);
            mtbQuantity.Mask = "0000";
            mtbQuantity.Name = "mtbQuantity";
            mtbQuantity.Size = new Size(140, 27);
            mtbQuantity.TabIndex = 4;
            mtbQuantity.ValidatingType = typeof(int);
            // 
            // mtbPrice
            // 
            mtbPrice.Location = new Point(359, 279);
            mtbPrice.Mask = "0000000.00";
            mtbPrice.Name = "mtbPrice";
            mtbPrice.Size = new Size(140, 27);
            mtbPrice.TabIndex = 5;
            // 
            // cboCategory
            // 
            cboCategory.FormattingEnabled = true;
            cboCategory.Location = new Point(146, 393);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(353, 28);
            cboCategory.TabIndex = 7;
            // 
            // dtpReleasedDate
            // 
            dtpReleasedDate.CustomFormat = "dd/MM/yyyy";
            dtpReleasedDate.Format = DateTimePickerFormat.Custom;
            dtpReleasedDate.Location = new Point(146, 328);
            dtpReleasedDate.Name = "dtpReleasedDate";
            dtpReleasedDate.Size = new Size(152, 27);
            dtpReleasedDate.TabIndex = 3;
            // 
            // txtShape
            // 
            txtShape.Location = new Point(146, 220);
            txtShape.Name = "txtShape";
            txtShape.Size = new Size(353, 27);
            txtShape.TabIndex = 6;
            // 
            // txtName
            // 
            txtName.Location = new Point(146, 86);
            txtName.Name = "txtName";
            txtName.Size = new Size(353, 27);
            txtName.TabIndex = 1;
            // 
            // txtId
            // 
            txtId.BackColor = SystemColors.ControlLightLight;
            txtId.BorderStyle = BorderStyle.FixedSingle;
            txtId.Location = new Point(146, 43);
            txtId.Name = "txtId";
            txtId.Size = new Size(125, 27);
            txtId.TabIndex = 0;
            // 
            // lblManufacturerId
            // 
            lblManufacturerId.AutoSize = true;
            lblManufacturerId.Location = new Point(17, 396);
            lblManufacturerId.Name = "lblManufacturerId";
            lblManufacturerId.Size = new Size(116, 20);
            lblManufacturerId.TabIndex = 7;
            lblManufacturerId.Text = "Manufacturer ID";
            // 
            // lblShape
            // 
            lblShape.AutoSize = true;
            lblShape.Location = new Point(17, 223);
            lblShape.Name = "lblShape";
            lblShape.Size = new Size(50, 20);
            lblShape.TabIndex = 6;
            lblShape.Text = "Shape";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(309, 282);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(41, 20);
            lblPrice.TabIndex = 5;
            lblPrice.Text = "Price";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(17, 282);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(65, 20);
            lblQuantity.TabIndex = 4;
            lblQuantity.Text = "Quantity";
            // 
            // lblCreatedDate
            // 
            lblCreatedDate.AutoSize = true;
            lblCreatedDate.Location = new Point(17, 333);
            lblCreatedDate.Name = "lblCreatedDate";
            lblCreatedDate.Size = new Size(97, 20);
            lblCreatedDate.TabIndex = 3;
            lblCreatedDate.Text = "Created Date";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(17, 89);
            lblName.Name = "lblName";
            lblName.Size = new Size(49, 20);
            lblName.TabIndex = 1;
            lblName.Text = "Name";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.ForeColor = Color.Black;
            lblId.Location = new Point(17, 45);
            lblId.Name = "lblId";
            lblId.Size = new Size(24, 20);
            lblId.TabIndex = 0;
            lblId.Text = "ID";
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Aqua;
            btnCancel.ForeColor = Color.Red;
            btnCancel.Location = new Point(473, 565);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Aqua;
            btnSave.ForeColor = Color.Black;
            btnSave.Location = new Point(362, 565);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // SunglassesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(633, 618);
            Controls.Add(lblFormTitle);
            Controls.Add(gbSunGlassesInfo);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SunglassesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add | Update SunGlass";
            Load += SunglassesForm_Load;
            gbSunGlassesInfo.ResumeLayout(false);
            gbSunGlassesInfo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFormTitle;
        private GroupBox gbSunGlassesInfo;
        private MaskedTextBox mtbQuantity;
        private MaskedTextBox mtbPrice;
        private ComboBox cboCategory;
        private DateTimePicker dtpReleasedDate;
        private TextBox txtShape;
        private TextBox txtName;
        private TextBox txtId;
        private Label lblManufacturerId;
        private Label lblShape;
        private Label lblPrice;
        private Label lblQuantity;
        private Label lblCreatedDate;
        private Label lblName;
        private Label lblId;
        private Button btnCancel;
        private Button btnSave;
        private TextBox txtMaterial;
        private TextBox txtFeature;
        private Label lblMaterial;
        private Label lblFeature;
    }
}
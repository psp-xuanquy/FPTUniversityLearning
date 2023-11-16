namespace BookStore_HoangNT
{
    partial class SunglassesManagerForm
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
            txtKeyword = new TextBox();
            lblKeyword = new Label();
            gbTask = new GroupBox();
            btnExit = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            gbSearch = new GroupBox();
            btnSearch = new Button();
            dgvSunglassesList = new DataGridView();
            lblSunglassesList = new Label();
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
            gbTask.SuspendLayout();
            gbSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSunglassesList).BeginInit();
            gbSunGlassesInfo.SuspendLayout();
            SuspendLayout();
            // 
            // txtKeyword
            // 
            txtKeyword.Location = new Point(91, 34);
            txtKeyword.Name = "txtKeyword";
            txtKeyword.Size = new Size(221, 27);
            txtKeyword.TabIndex = 0;
            // 
            // lblKeyword
            // 
            lblKeyword.AutoSize = true;
            lblKeyword.Location = new Point(18, 37);
            lblKeyword.Name = "lblKeyword";
            lblKeyword.Size = new Size(67, 20);
            lblKeyword.TabIndex = 18;
            lblKeyword.Text = "Keyword";
            // 
            // gbTask
            // 
            gbTask.Controls.Add(btnExit);
            gbTask.Controls.Add(btnDelete);
            gbTask.Controls.Add(btnUpdate);
            gbTask.Controls.Add(btnAdd);
            gbTask.ForeColor = Color.Black;
            gbTask.Location = new Point(25, 548);
            gbTask.Name = "gbTask";
            gbTask.Size = new Size(500, 80);
            gbTask.TabIndex = 20;
            gbTask.TabStop = false;
            gbTask.Text = " Task ";
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Aqua;
            btnExit.Location = new Point(388, 35);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 3;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Aqua;
            btnDelete.Location = new Point(264, 35);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Aqua;
            btnUpdate.Location = new Point(141, 35);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Aqua;
            btnAdd.Location = new Point(17, 35);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // gbSearch
            // 
            gbSearch.Controls.Add(btnSearch);
            gbSearch.Controls.Add(lblKeyword);
            gbSearch.Controls.Add(txtKeyword);
            gbSearch.ForeColor = Color.Black;
            gbSearch.Location = new Point(564, 91);
            gbSearch.Name = "gbSearch";
            gbSearch.Size = new Size(451, 80);
            gbSearch.TabIndex = 21;
            gbSearch.TabStop = false;
            gbSearch.Text = " Search ";
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Aqua;
            btnSearch.Location = new Point(331, 33);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // dgvSunglassesList
            // 
            dgvSunglassesList.BackgroundColor = Color.White;
            dgvSunglassesList.BorderStyle = BorderStyle.Fixed3D;
            dgvSunglassesList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSunglassesList.Location = new Point(564, 242);
            dgvSunglassesList.Name = "dgvSunglassesList";
            dgvSunglassesList.RowHeadersWidth = 51;
            dgvSunglassesList.RowTemplate.Height = 29;
            dgvSunglassesList.Size = new Size(523, 370);
            dgvSunglassesList.TabIndex = 0;
            dgvSunglassesList.SelectionChanged += dgvSunglassesList_SelectionChanged;
            // 
            // lblSunglassesList
            // 
            lblSunglassesList.AutoSize = true;
            lblSunglassesList.ForeColor = Color.Black;
            lblSunglassesList.Location = new Point(564, 210);
            lblSunglassesList.Name = "lblSunglassesList";
            lblSunglassesList.Size = new Size(107, 20);
            lblSunglassesList.TabIndex = 23;
            lblSunglassesList.Text = "SunGlasses List";
            // 
            // lblFormTitle
            // 
            lblFormTitle.AutoSize = true;
            lblFormTitle.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            lblFormTitle.ForeColor = Color.SkyBlue;
            lblFormTitle.Location = new Point(25, 18);
            lblFormTitle.Name = "lblFormTitle";
            lblFormTitle.Size = new Size(348, 46);
            lblFormTitle.TabIndex = 18;
            lblFormTitle.Text = "SunGlasses Manager";
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
            gbSunGlassesInfo.Location = new Point(25, 91);
            gbSunGlassesInfo.Name = "gbSunGlassesInfo";
            gbSunGlassesInfo.Size = new Size(514, 445);
            gbSunGlassesInfo.TabIndex = 24;
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
            // SunglassesManagerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(1109, 645);
            Controls.Add(gbSunGlassesInfo);
            Controls.Add(lblFormTitle);
            Controls.Add(lblSunglassesList);
            Controls.Add(dgvSunglassesList);
            Controls.Add(gbSearch);
            Controls.Add(gbTask);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SunglassesManagerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SunGlasses Manager";
            FormClosed += SunglassesManagerForm_FormClosed;
            Load += SunglassesManagerForm_Load;
            gbTask.ResumeLayout(false);
            gbSearch.ResumeLayout(false);
            gbSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSunglassesList).EndInit();
            gbSunGlassesInfo.ResumeLayout(false);
            gbSunGlassesInfo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtKeyword;
        private Label lblKeyword;
        private GroupBox gbTask;
        private Button btnExit;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private GroupBox gbSearch;
        private Button btnSearch;
        private DataGridView dgvSunglassesList;
        private Label lblSunglassesList;
        private Label lblFormTitle;
        private GroupBox gbSunGlassesInfo;
        private Label lblMaterial;
        private Label lblFeature;
        private TextBox txtMaterial;
        private TextBox txtFeature;
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
    }
}
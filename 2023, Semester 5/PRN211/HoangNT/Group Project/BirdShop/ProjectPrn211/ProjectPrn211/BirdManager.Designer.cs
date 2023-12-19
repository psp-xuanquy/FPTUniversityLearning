namespace BSAPP
{
    partial class BirdManager
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
            btn_Back = new Button();
            btn_Delete = new Button();
            btn_Create = new Button();
            groupBox3 = new GroupBox();
            btn_Update = new Button();
            dtg_BirdList = new DataGridView();
            groupBox1 = new GroupBox();
            label10 = new Label();
            groupBox2 = new GroupBox();
            cbb_Species = new ComboBox();
            label9 = new Label();
            label1 = new Label();
            cmb_Status = new ComboBox();
            label8 = new Label();
            rtb_Description = new RichTextBox();
            lb_Id = new Label();
            label2 = new Label();
            dtp_Birth = new DateTimePicker();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            txt_Image = new TextBox();
            txt_price = new TextBox();
            cmb_gender = new ComboBox();
            label3 = new Label();
            txt_Name = new TextBox();
            txt_SpeciesID = new TextBox();
            c = new Label();
            label11 = new Label();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_BirdList).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btn_Back
            // 
            btn_Back.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Back.Location = new Point(40, 202);
            btn_Back.Name = "btn_Back";
            btn_Back.Size = new Size(347, 52);
            btn_Back.TabIndex = 3;
            btn_Back.Text = "Back";
            btn_Back.UseVisualStyleBackColor = true;
            btn_Back.Click += btn_Back_Click;
            // 
            // btn_Delete
            // 
            btn_Delete.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Delete.Location = new Point(40, 86);
            btn_Delete.Name = "btn_Delete";
            btn_Delete.Size = new Size(347, 52);
            btn_Delete.TabIndex = 1;
            btn_Delete.Text = "Delete";
            btn_Delete.UseVisualStyleBackColor = true;
            btn_Delete.Click += btn_Delete_Click;
            // 
            // btn_Create
            // 
            btn_Create.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Create.Location = new Point(40, 28);
            btn_Create.Name = "btn_Create";
            btn_Create.Size = new Size(347, 52);
            btn_Create.TabIndex = 0;
            btn_Create.Text = "Create";
            btn_Create.UseVisualStyleBackColor = true;
            btn_Create.Click += btn_Create_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btn_Back);
            groupBox3.Controls.Add(btn_Update);
            groupBox3.Controls.Add(btn_Delete);
            groupBox3.Controls.Add(btn_Create);
            groupBox3.Location = new Point(805, 27);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(428, 275);
            groupBox3.TabIndex = 29;
            groupBox3.TabStop = false;
            // 
            // btn_Update
            // 
            btn_Update.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Update.Location = new Point(40, 144);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new Size(347, 52);
            btn_Update.TabIndex = 2;
            btn_Update.Text = "Update";
            btn_Update.UseVisualStyleBackColor = true;
            btn_Update.Click += btn_Update_Click;
            // 
            // dtg_BirdList
            // 
            dtg_BirdList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtg_BirdList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_BirdList.Location = new Point(21, 63);
            dtg_BirdList.Name = "dtg_BirdList";
            dtg_BirdList.RowTemplate.Height = 25;
            dtg_BirdList.Size = new Size(1246, 150);
            dtg_BirdList.TabIndex = 0;
            dtg_BirdList.CellClick += dtg_BirdList_CellClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(dtg_BirdList);
            groupBox1.Location = new Point(42, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1290, 234);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(600, 19);
            label10.Name = "label10";
            label10.Size = new Size(118, 32);
            label10.TabIndex = 53;
            label10.Text = "Birds List";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cbb_Species);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(cmb_Status);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(rtb_Description);
            groupBox2.Controls.Add(lb_Id);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(dtp_Birth);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txt_Image);
            groupBox2.Controls.Add(txt_price);
            groupBox2.Controls.Add(cmb_gender);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(txt_Name);
            groupBox2.Controls.Add(txt_SpeciesID);
            groupBox2.Controls.Add(c);
            groupBox2.Controls.Add(groupBox3);
            groupBox2.Location = new Point(42, 305);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1290, 319);
            groupBox2.TabIndex = 30;
            groupBox2.TabStop = false;
            // 
            // cbb_Species
            // 
            cbb_Species.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbb_Species.FormattingEnabled = true;
            cbb_Species.Location = new Point(503, 95);
            cbb_Species.Name = "cbb_Species";
            cbb_Species.Size = new Size(269, 29);
            cbb_Species.TabIndex = 52;
            cbb_Species.SelectedIndexChanged += cbb_Species_SelectedIndexChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(411, 98);
            label9.Name = "label9";
            label9.Size = new Size(77, 25);
            label9.TabIndex = 51;
            label9.Text = "Species";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(85, 42);
            label1.Name = "label1";
            label1.Size = new Size(32, 25);
            label1.TabIndex = 46;
            label1.Text = "ID";
            // 
            // cmb_Status
            // 
            cmb_Status.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmb_Status.FormattingEnabled = true;
            cmb_Status.Location = new Point(503, 263);
            cmb_Status.Name = "cmb_Status";
            cmb_Status.Size = new Size(269, 29);
            cmb_Status.TabIndex = 50;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(382, 266);
            label8.Name = "label8";
            label8.Size = new Size(115, 25);
            label8.TabIndex = 49;
            label8.Text = "Status_Sold";
            // 
            // rtb_Description
            // 
            rtb_Description.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rtb_Description.Location = new Point(503, 145);
            rtb_Description.Name = "rtb_Description";
            rtb_Description.Size = new Size(269, 62);
            rtb_Description.TabIndex = 48;
            rtb_Description.Text = "";
            // 
            // lb_Id
            // 
            lb_Id.AutoSize = true;
            lb_Id.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lb_Id.Location = new Point(146, 50);
            lb_Id.Name = "lb_Id";
            lb_Id.Size = new Size(20, 15);
            lb_Id.TabIndex = 47;
            lb_Id.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(59, 154);
            label2.Name = "label2";
            label2.Size = new Size(64, 25);
            label2.TabIndex = 34;
            label2.Text = "Name";
            // 
            // dtp_Birth
            // 
            dtp_Birth.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtp_Birth.Location = new Point(503, 45);
            dtp_Birth.Name = "dtp_Birth";
            dtp_Birth.Size = new Size(269, 29);
            dtp_Birth.TabIndex = 45;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(426, 50);
            label7.Name = "label7";
            label7.Size = new Size(56, 25);
            label7.TabIndex = 44;
            label7.Text = "Birth";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(380, 145);
            label6.Name = "label6";
            label6.Size = new Size(114, 25);
            label6.TabIndex = 43;
            label6.Text = "Description";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(427, 213);
            label5.Name = "label5";
            label5.Size = new Size(56, 25);
            label5.TabIndex = 42;
            label5.Text = "Price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(26, 265);
            label4.Name = "label4";
            label4.Size = new Size(112, 25);
            label4.TabIndex = 41;
            label4.Text = "Bird_Image";
            // 
            // txt_Image
            // 
            txt_Image.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Image.Location = new Point(146, 266);
            txt_Image.Name = "txt_Image";
            txt_Image.Size = new Size(193, 29);
            txt_Image.TabIndex = 40;
            // 
            // txt_price
            // 
            txt_price.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_price.Location = new Point(503, 214);
            txt_price.Name = "txt_price";
            txt_price.Size = new Size(269, 29);
            txt_price.TabIndex = 39;
            // 
            // cmb_gender
            // 
            cmb_gender.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmb_gender.FormattingEnabled = true;
            cmb_gender.Location = new Point(146, 214);
            cmb_gender.Name = "cmb_gender";
            cmb_gender.Size = new Size(193, 29);
            cmb_gender.TabIndex = 36;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(50, 214);
            label3.Name = "label3";
            label3.Size = new Size(78, 25);
            label3.TabIndex = 35;
            label3.Text = "Gender";
            // 
            // txt_Name
            // 
            txt_Name.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Name.Location = new Point(146, 154);
            txt_Name.Name = "txt_Name";
            txt_Name.Size = new Size(193, 29);
            txt_Name.TabIndex = 33;
            // 
            // txt_SpeciesID
            // 
            txt_SpeciesID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_SpeciesID.Location = new Point(146, 95);
            txt_SpeciesID.Name = "txt_SpeciesID";
            txt_SpeciesID.ReadOnly = true;
            txt_SpeciesID.Size = new Size(193, 29);
            txt_SpeciesID.TabIndex = 32;
            // 
            // c
            // 
            c.AutoSize = true;
            c.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            c.Location = new Point(34, 98);
            c.Name = "c";
            c.Size = new Size(97, 25);
            c.TabIndex = 31;
            c.Text = "SpeciesID";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(659, 270);
            label11.Name = "label11";
            label11.Size = new Size(92, 32);
            label11.TabIndex = 54;
            label11.Text = "Details";
            // 
            // BirdManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 665);
            Controls.Add(label11);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "BirdManager";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BirdManager";
            Load += BirdManager_Load;
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtg_BirdList).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Back;
        private Button btn_Delete;
        private Button btn_Create;
        private GroupBox groupBox3;
        private Button btn_Update;
        private DataGridView dtg_BirdList;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox txt_Name;
        private TextBox txt_SpeciesID;
        private Label c;
        private Label label2;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox txt_Image;
        private TextBox txt_price;
        private ComboBox cmb_gender;
        private Label label3;
        private DateTimePicker dtp_Birth;
        private RichTextBox rtb_Description;
        private Label lb_Id;
        private Label label1;
        private ComboBox cmb_Status;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private ComboBox cbb_Species;
    }
}
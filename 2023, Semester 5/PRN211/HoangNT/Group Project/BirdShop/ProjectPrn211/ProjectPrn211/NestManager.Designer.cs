namespace BSAPP
{
    partial class NestManager
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
            groupBox1 = new GroupBox();
            label12 = new Label();
            dtg_BirdList = new DataGridView();
            label1 = new Label();
            dtg_NestList = new DataGridView();
            groupBox2 = new GroupBox();
            lb_Id = new Label();
            label2 = new Label();
            cmb_Status = new ComboBox();
            label11 = new Label();
            cmb_type = new ComboBox();
            groupBox3 = new GroupBox();
            btn_Back = new Button();
            btn_Update = new Button();
            btn_Delete = new Button();
            btn_Create = new Button();
            txt_price = new TextBox();
            txt_quantity = new TextBox();
            txt_BirdImage = new TextBox();
            txt_name = new TextBox();
            txt_des = new TextBox();
            txt_idfemale = new TextBox();
            txt_idmale = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_BirdList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtg_NestList).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(dtg_BirdList);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(dtg_NestList);
            groupBox1.Location = new Point(5, -1);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1197, 357);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(522, 171);
            label12.Name = "label12";
            label12.Size = new Size(96, 30);
            label12.TabIndex = 3;
            label12.Text = "BirdsList";
            // 
            // dtg_BirdList
            // 
            dtg_BirdList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtg_BirdList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_BirdList.Location = new Point(24, 210);
            dtg_BirdList.Name = "dtg_BirdList";
            dtg_BirdList.RowTemplate.Height = 25;
            dtg_BirdList.Size = new Size(1150, 135);
            dtg_BirdList.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(522, 9);
            label1.Name = "label1";
            label1.Size = new Size(92, 30);
            label1.TabIndex = 1;
            label1.Text = "NestList";
            // 
            // dtg_NestList
            // 
            dtg_NestList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtg_NestList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_NestList.Location = new Point(24, 42);
            dtg_NestList.Name = "dtg_NestList";
            dtg_NestList.RowTemplate.Height = 25;
            dtg_NestList.Size = new Size(1150, 126);
            dtg_NestList.TabIndex = 0;
            dtg_NestList.CellClick += dtg_NestList_CellClick;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lb_Id);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(cmb_Status);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(cmb_type);
            groupBox2.Controls.Add(groupBox3);
            groupBox2.Controls.Add(txt_price);
            groupBox2.Controls.Add(txt_quantity);
            groupBox2.Controls.Add(txt_BirdImage);
            groupBox2.Controls.Add(txt_name);
            groupBox2.Controls.Add(txt_des);
            groupBox2.Controls.Add(txt_idfemale);
            groupBox2.Controls.Add(txt_idmale);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(5, 362);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1197, 230);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // lb_Id
            // 
            lb_Id.AutoSize = true;
            lb_Id.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lb_Id.Location = new Point(42, 37);
            lb_Id.Name = "lb_Id";
            lb_Id.Size = new Size(20, 15);
            lb_Id.TabIndex = 30;
            lb_Id.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(11, 33);
            label2.Name = "label2";
            label2.Size = new Size(25, 20);
            label2.TabIndex = 29;
            label2.Text = "ID";
            // 
            // cmb_Status
            // 
            cmb_Status.FormattingEnabled = true;
            cmb_Status.Location = new Point(522, 194);
            cmb_Status.Name = "cmb_Status";
            cmb_Status.Size = new Size(121, 23);
            cmb_Status.TabIndex = 28;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(406, 194);
            label11.Name = "label11";
            label11.Size = new Size(53, 20);
            label11.TabIndex = 27;
            label11.Text = "Status";
            // 
            // cmb_type
            // 
            cmb_type.FormattingEnabled = true;
            cmb_type.Location = new Point(120, 150);
            cmb_type.Name = "cmb_type";
            cmb_type.Size = new Size(226, 23);
            cmb_type.TabIndex = 26;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btn_Back);
            groupBox3.Controls.Add(btn_Update);
            groupBox3.Controls.Add(btn_Delete);
            groupBox3.Controls.Add(btn_Create);
            groupBox3.Location = new Point(769, 9);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(388, 215);
            groupBox3.TabIndex = 25;
            groupBox3.TabStop = false;
            // 
            // btn_Back
            // 
            btn_Back.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Back.Location = new Point(58, 164);
            btn_Back.Name = "btn_Back";
            btn_Back.Size = new Size(299, 41);
            btn_Back.TabIndex = 3;
            btn_Back.Text = "Back";
            btn_Back.UseVisualStyleBackColor = true;
            btn_Back.Click += btn_Back_Click;
            // 
            // btn_Update
            // 
            btn_Update.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Update.Location = new Point(58, 113);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new Size(299, 41);
            btn_Update.TabIndex = 2;
            btn_Update.Text = "Update";
            btn_Update.UseVisualStyleBackColor = true;
            btn_Update.Click += btn_Update_Click;
            // 
            // btn_Delete
            // 
            btn_Delete.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Delete.Location = new Point(58, 68);
            btn_Delete.Name = "btn_Delete";
            btn_Delete.Size = new Size(299, 41);
            btn_Delete.TabIndex = 1;
            btn_Delete.Text = "Delete";
            btn_Delete.UseVisualStyleBackColor = true;
            btn_Delete.Click += btn_Delete_Click;
            // 
            // btn_Create
            // 
            btn_Create.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Create.Location = new Point(58, 20);
            btn_Create.Name = "btn_Create";
            btn_Create.Size = new Size(299, 41);
            btn_Create.TabIndex = 0;
            btn_Create.Text = "Create";
            btn_Create.UseVisualStyleBackColor = true;
            btn_Create.Click += btn_Create_Click;
            // 
            // txt_price
            // 
            txt_price.Location = new Point(522, 72);
            txt_price.Name = "txt_price";
            txt_price.Size = new Size(184, 23);
            txt_price.TabIndex = 24;
            // 
            // txt_quantity
            // 
            txt_quantity.Location = new Point(522, 112);
            txt_quantity.Name = "txt_quantity";
            txt_quantity.Size = new Size(184, 23);
            txt_quantity.TabIndex = 23;
            // 
            // txt_BirdImage
            // 
            txt_BirdImage.Location = new Point(522, 153);
            txt_BirdImage.Name = "txt_BirdImage";
            txt_BirdImage.Size = new Size(184, 23);
            txt_BirdImage.TabIndex = 22;
            // 
            // txt_name
            // 
            txt_name.Location = new Point(120, 188);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(226, 23);
            txt_name.TabIndex = 21;
            // 
            // txt_des
            // 
            txt_des.Location = new Point(522, 30);
            txt_des.Name = "txt_des";
            txt_des.Size = new Size(184, 23);
            txt_des.TabIndex = 20;
            // 
            // txt_idfemale
            // 
            txt_idfemale.Location = new Point(120, 112);
            txt_idfemale.Name = "txt_idfemale";
            txt_idfemale.Size = new Size(226, 23);
            txt_idfemale.TabIndex = 19;
            // 
            // txt_idmale
            // 
            txt_idmale.Location = new Point(120, 72);
            txt_idmale.Name = "txt_idmale";
            txt_idmale.Size = new Size(226, 23);
            txt_idmale.TabIndex = 17;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(406, 152);
            label10.Name = "label10";
            label10.Size = new Size(82, 20);
            label10.TabIndex = 15;
            label10.Text = "BirdImage";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(406, 75);
            label9.Name = "label9";
            label9.Size = new Size(43, 20);
            label9.TabIndex = 14;
            label9.Text = "Price";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(406, 111);
            label8.Name = "label8";
            label8.Size = new Size(70, 20);
            label8.TabIndex = 13;
            label8.Text = "Quantity";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(10, 191);
            label7.Name = "label7";
            label7.Size = new Size(51, 20);
            label7.TabIndex = 12;
            label7.Text = "Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(406, 33);
            label6.Name = "label6";
            label6.Size = new Size(89, 20);
            label6.TabIndex = 11;
            label6.Text = "Description";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(10, 151);
            label5.Name = "label5";
            label5.Size = new Size(89, 20);
            label5.TabIndex = 10;
            label5.Text = "BirdSpecies";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(11, 75);
            label4.Name = "label4";
            label4.Size = new Size(88, 20);
            label4.TabIndex = 9;
            label4.Text = "BirdIDMale";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(10, 115);
            label3.Name = "label3";
            label3.Size = new Size(104, 20);
            label3.TabIndex = 8;
            label3.Text = "BirdIDFemale";
            // 
            // NestManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1214, 604);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "NestManager";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManagerNest";
            Load += NestManager_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_BirdList).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtg_NestList).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private DataGridView dtg_NestList;
        private GroupBox groupBox2;
        private Label label9;
        private Label label8;
        private Label label6;
        private Label label10;
        private TextBox txt_price;
        private TextBox txt_quantity;
        private TextBox txt_BirdImage;
        private TextBox txt_des;
        private GroupBox groupBox3;
        private Button btn_Update;
        private Button btn_Delete;
        private Button btn_Create;
        private Button btn_Back;
        private Label label11;
        private DataGridView dtg_BirdList;
        private ComboBox cmb_type;
        private TextBox txt_name;
        private TextBox txt_idfemale;
        private TextBox txt_idmale;
        private Label label7;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private ComboBox cmb_Status;
        private Label label12;
        private Label lb_Id;
    }
}
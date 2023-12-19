namespace BSAPP
{
    partial class CreateOrder
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            label_Fullname = new Label();
            cbb_Provider = new ComboBox();
            cbb_PaymentMethod = new ComboBox();
            dtp_EstimatedDate = new DateTimePicker();
            dtp_CreateDate = new DateTimePicker();
            txt_Address = new TextBox();
            txt_Phone = new TextBox();
            label_Total = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label_Provider = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btn_Create = new Button();
            btn_Cancel = new Button();
            groupBox2 = new GroupBox();
            dtg_ViewProducts = new DataGridView();
            label6 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_ViewProducts).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(102, 9);
            label1.Name = "label1";
            label1.Size = new Size(412, 65);
            label1.TabIndex = 0;
            label1.Text = "Order Information";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label_Fullname);
            groupBox1.Controls.Add(cbb_Provider);
            groupBox1.Controls.Add(cbb_PaymentMethod);
            groupBox1.Controls.Add(dtp_EstimatedDate);
            groupBox1.Controls.Add(dtp_CreateDate);
            groupBox1.Controls.Add(txt_Address);
            groupBox1.Controls.Add(txt_Phone);
            groupBox1.Controls.Add(label_Total);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label_Provider);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 77);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(595, 479);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // label_Fullname
            // 
            label_Fullname.AutoSize = true;
            label_Fullname.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label_Fullname.ForeColor = SystemColors.ActiveCaptionText;
            label_Fullname.Location = new Point(196, 39);
            label_Fullname.Name = "label_Fullname";
            label_Fullname.Size = new Size(0, 21);
            label_Fullname.TabIndex = 16;
            // 
            // cbb_Provider
            // 
            cbb_Provider.FormattingEnabled = true;
            cbb_Provider.Location = new Point(434, 224);
            cbb_Provider.Name = "cbb_Provider";
            cbb_Provider.Size = new Size(121, 23);
            cbb_Provider.TabIndex = 15;
            // 
            // cbb_PaymentMethod
            // 
            cbb_PaymentMethod.FormattingEnabled = true;
            cbb_PaymentMethod.Location = new Point(196, 224);
            cbb_PaymentMethod.Name = "cbb_PaymentMethod";
            cbb_PaymentMethod.Size = new Size(145, 23);
            cbb_PaymentMethod.TabIndex = 14;
            cbb_PaymentMethod.SelectedIndexChanged += cbb_PaymentMethod_SelectedIndexChanged;
            // 
            // dtp_EstimatedDate
            // 
            dtp_EstimatedDate.Location = new Point(196, 365);
            dtp_EstimatedDate.Name = "dtp_EstimatedDate";
            dtp_EstimatedDate.Size = new Size(200, 23);
            dtp_EstimatedDate.TabIndex = 13;
            // 
            // dtp_CreateDate
            // 
            dtp_CreateDate.Location = new Point(196, 296);
            dtp_CreateDate.Name = "dtp_CreateDate";
            dtp_CreateDate.Size = new Size(200, 23);
            dtp_CreateDate.TabIndex = 12;
            // 
            // txt_Address
            // 
            txt_Address.Location = new Point(196, 159);
            txt_Address.Name = "txt_Address";
            txt_Address.Size = new Size(359, 23);
            txt_Address.TabIndex = 11;
            // 
            // txt_Phone
            // 
            txt_Phone.Location = new Point(196, 99);
            txt_Phone.Name = "txt_Phone";
            txt_Phone.Size = new Size(145, 23);
            txt_Phone.TabIndex = 10;
            // 
            // label_Total
            // 
            label_Total.AutoSize = true;
            label_Total.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label_Total.ForeColor = Color.Red;
            label_Total.Location = new Point(196, 417);
            label_Total.Name = "label_Total";
            label_Total.Size = new Size(0, 25);
            label_Total.TabIndex = 9;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(114, 421);
            label9.Name = "label9";
            label9.Size = new Size(45, 21);
            label9.TabIndex = 8;
            label9.Text = "Total:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(44, 367);
            label8.Name = "label8";
            label8.Size = new Size(115, 21);
            label8.TabIndex = 7;
            label8.Text = "Estimated date:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(67, 296);
            label7.Name = "label7";
            label7.Size = new Size(92, 21);
            label7.TabIndex = 6;
            label7.Text = "Create date:";
            // 
            // label_Provider
            // 
            label_Provider.AutoSize = true;
            label_Provider.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label_Provider.Location = new Point(356, 222);
            label_Provider.Name = "label_Provider";
            label_Provider.Size = new Size(72, 21);
            label_Provider.TabIndex = 5;
            label_Provider.Text = "Provider:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(28, 226);
            label5.Name = "label5";
            label5.Size = new Size(131, 21);
            label5.TabIndex = 4;
            label5.Text = "Payment method:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(90, 157);
            label4.Name = "label4";
            label4.Size = new Size(69, 21);
            label4.TabIndex = 3;
            label4.Text = "Address:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(102, 97);
            label3.Name = "label3";
            label3.Size = new Size(57, 21);
            label3.TabIndex = 2;
            label3.Text = "Phone:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(78, 43);
            label2.Name = "label2";
            label2.Size = new Size(81, 21);
            label2.TabIndex = 1;
            label2.Text = "Full name:";
            // 
            // btn_Create
            // 
            btn_Create.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Create.Location = new Point(653, 494);
            btn_Create.Name = "btn_Create";
            btn_Create.Size = new Size(146, 58);
            btn_Create.TabIndex = 17;
            btn_Create.Text = "Create";
            btn_Create.UseVisualStyleBackColor = true;
            btn_Create.Click += btn_Create_Click;
            // 
            // btn_Cancel
            // 
            btn_Cancel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Cancel.Location = new Point(985, 494);
            btn_Cancel.Name = "btn_Cancel";
            btn_Cancel.Size = new Size(146, 58);
            btn_Cancel.TabIndex = 18;
            btn_Cancel.Text = "Cancel";
            btn_Cancel.UseVisualStyleBackColor = true;
            btn_Cancel.Click += btn_Cancel_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dtg_ViewProducts);
            groupBox2.Location = new Point(636, 77);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(507, 388);
            groupBox2.TabIndex = 19;
            groupBox2.TabStop = false;
            // 
            // dtg_ViewProducts
            // 
            dtg_ViewProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_ViewProducts.Location = new Point(17, 22);
            dtg_ViewProducts.Name = "dtg_ViewProducts";
            dtg_ViewProducts.RowTemplate.Height = 25;
            dtg_ViewProducts.Size = new Size(478, 347);
            dtg_ViewProducts.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(714, 9);
            label6.Name = "label6";
            label6.Size = new Size(213, 65);
            label6.TabIndex = 20;
            label6.Text = "Products";
            // 
            // CreateOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1168, 576);
            Controls.Add(label6);
            Controls.Add(btn_Cancel);
            Controls.Add(groupBox2);
            Controls.Add(btn_Create);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "CreateOrder";
            Text = "CreateOrder";
            Load += CreateOrder_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtg_ViewProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label_Provider;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label_Total;
        private Label label_Fullname;
        private ComboBox cbb_Provider;
        private ComboBox cbb_PaymentMethod;
        private DateTimePicker dtp_EstimatedDate;
        private DateTimePicker dtp_CreateDate;
        private TextBox txt_Address;
        private TextBox txt_Phone;
        private Button btn_Create;
        private Button btn_Cancel;
        private GroupBox groupBox2;
        private DataGridView dtg_ViewProducts;
        private Label label6;
    }
}
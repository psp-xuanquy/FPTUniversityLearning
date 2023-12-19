namespace BSAPP
{
    partial class PurchasedOrders
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
            label21 = new Label();
            dtg_ViewOrder = new DataGridView();
            groupBox1 = new GroupBox();
            txt_Provider = new TextBox();
            txt_PaymentMethod = new TextBox();
            label_Total = new Label();
            label_Fullname = new Label();
            txt_EstimatedDate = new TextBox();
            txt_CreateDate = new TextBox();
            txt_Phone = new TextBox();
            label18 = new Label();
            label19 = new Label();
            label20 = new Label();
            label17 = new Label();
            label16 = new Label();
            label15 = new Label();
            txt_Address = new TextBox();
            label9 = new Label();
            label_Provider = new Label();
            groupBox3 = new GroupBox();
            label22 = new Label();
            dtg_ViewProduct = new DataGridView();
            panel2 = new Panel();
            label10 = new Label();
            txt_NameNest = new TextBox();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            txt_QuantityNest = new TextBox();
            txt_PriceNest = new TextBox();
            rtb_DescriptonNest = new RichTextBox();
            txt_SpeciesNest = new TextBox();
            label8 = new Label();
            groupBox4 = new GroupBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            rtb_DescriptionBird = new RichTextBox();
            txt_NameBird = new TextBox();
            txt_SpeciesNameBird = new TextBox();
            txt_GenderBird = new TextBox();
            txt_AgeBird = new TextBox();
            txt_PriceBird = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dtg_ViewOrder).BeginInit();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_ViewProduct).BeginInit();
            panel2.SuspendLayout();
            groupBox4.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("UD Digi Kyokasho NP-B", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label21.Location = new Point(708, 23);
            label21.Name = "label21";
            label21.Size = new Size(95, 28);
            label21.TabIndex = 26;
            label21.Text = "Orders";
            // 
            // dtg_ViewOrder
            // 
            dtg_ViewOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_ViewOrder.Location = new Point(587, 59);
            dtg_ViewOrder.Name = "dtg_ViewOrder";
            dtg_ViewOrder.RowTemplate.Height = 25;
            dtg_ViewOrder.Size = new Size(319, 182);
            dtg_ViewOrder.TabIndex = 27;
            dtg_ViewOrder.CellClick += dtg_ViewOrder_CellClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txt_Provider);
            groupBox1.Controls.Add(txt_PaymentMethod);
            groupBox1.Controls.Add(label_Total);
            groupBox1.Controls.Add(label_Fullname);
            groupBox1.Controls.Add(txt_EstimatedDate);
            groupBox1.Controls.Add(txt_CreateDate);
            groupBox1.Controls.Add(txt_Phone);
            groupBox1.Controls.Add(label18);
            groupBox1.Controls.Add(label19);
            groupBox1.Controls.Add(label20);
            groupBox1.Controls.Add(label17);
            groupBox1.Controls.Add(label16);
            groupBox1.Controls.Add(label15);
            groupBox1.Controls.Add(txt_Address);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label_Provider);
            groupBox1.Location = new Point(10, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(571, 237);
            groupBox1.TabIndex = 25;
            groupBox1.TabStop = false;
            // 
            // txt_Provider
            // 
            txt_Provider.Location = new Point(420, 62);
            txt_Provider.Name = "txt_Provider";
            txt_Provider.Size = new Size(141, 23);
            txt_Provider.TabIndex = 40;
            // 
            // txt_PaymentMethod
            // 
            txt_PaymentMethod.Location = new Point(420, 15);
            txt_PaymentMethod.Name = "txt_PaymentMethod";
            txt_PaymentMethod.Size = new Size(141, 23);
            txt_PaymentMethod.TabIndex = 39;
            // 
            // label_Total
            // 
            label_Total.AutoSize = true;
            label_Total.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label_Total.ForeColor = Color.Red;
            label_Total.Location = new Point(122, 209);
            label_Total.Name = "label_Total";
            label_Total.Size = new Size(0, 25);
            label_Total.TabIndex = 38;
            // 
            // label_Fullname
            // 
            label_Fullname.AutoSize = true;
            label_Fullname.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label_Fullname.ForeColor = SystemColors.ActiveCaptionText;
            label_Fullname.Location = new Point(122, 20);
            label_Fullname.Name = "label_Fullname";
            label_Fullname.Size = new Size(0, 21);
            label_Fullname.TabIndex = 37;
            // 
            // txt_EstimatedDate
            // 
            txt_EstimatedDate.Location = new Point(420, 160);
            txt_EstimatedDate.Name = "txt_EstimatedDate";
            txt_EstimatedDate.Size = new Size(145, 23);
            txt_EstimatedDate.TabIndex = 36;
            // 
            // txt_CreateDate
            // 
            txt_CreateDate.Location = new Point(117, 161);
            txt_CreateDate.Name = "txt_CreateDate";
            txt_CreateDate.Size = new Size(145, 23);
            txt_CreateDate.TabIndex = 35;
            // 
            // txt_Phone
            // 
            txt_Phone.Location = new Point(117, 64);
            txt_Phone.Name = "txt_Phone";
            txt_Phone.Size = new Size(145, 23);
            txt_Phone.TabIndex = 34;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("UD Digi Kyokasho NP-B", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label18.Location = new Point(61, 211);
            label18.Name = "label18";
            label18.Size = new Size(55, 17);
            label18.TabIndex = 33;
            label18.Text = "Total:";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("UD Digi Kyokasho NP-B", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label19.Location = new Point(286, 163);
            label19.Name = "label19";
            label19.Size = new Size(134, 17);
            label19.TabIndex = 32;
            label19.Text = "Estimated date:";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("UD Digi Kyokasho NP-B", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label20.Location = new Point(8, 166);
            label20.Name = "label20";
            label20.Size = new Size(108, 17);
            label20.TabIndex = 31;
            label20.Text = "Create date:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("UD Digi Kyokasho NP-B", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label17.Location = new Point(25, 20);
            label17.Name = "label17";
            label17.Size = new Size(91, 17);
            label17.TabIndex = 24;
            label17.Text = "Full name:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("UD Digi Kyokasho NP-B", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label16.Location = new Point(53, 69);
            label16.Name = "label16";
            label16.Size = new Size(63, 17);
            label16.TabIndex = 25;
            label16.Text = "Phone:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("UD Digi Kyokasho NP-B", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label15.Location = new Point(39, 116);
            label15.Name = "label15";
            label15.Size = new Size(77, 17);
            label15.TabIndex = 26;
            label15.Text = "Address:";
            // 
            // txt_Address
            // 
            txt_Address.Location = new Point(117, 114);
            txt_Address.Name = "txt_Address";
            txt_Address.Size = new Size(359, 23);
            txt_Address.TabIndex = 30;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("UD Digi Kyokasho NP-B", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(277, 19);
            label9.Name = "label9";
            label9.Size = new Size(146, 17);
            label9.TabIndex = 27;
            label9.Text = "Payment method:";
            // 
            // label_Provider
            // 
            label_Provider.AutoSize = true;
            label_Provider.Font = new Font("UD Digi Kyokasho NP-B", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label_Provider.Location = new Point(343, 64);
            label_Provider.Name = "label_Provider";
            label_Provider.Size = new Size(80, 17);
            label_Provider.TabIndex = 28;
            label_Provider.Text = "Provider:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(panel1);
            groupBox3.Location = new Point(10, 247);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(571, 353);
            groupBox3.TabIndex = 28;
            groupBox3.TabStop = false;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("UD Digi Kyokasho NP-B", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label22.Location = new Point(1000, 23);
            label22.Name = "label22";
            label22.Size = new Size(121, 28);
            label22.TabIndex = 31;
            label22.Text = "Products";
            // 
            // dtg_ViewProduct
            // 
            dtg_ViewProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_ViewProduct.Location = new Point(912, 59);
            dtg_ViewProduct.Name = "dtg_ViewProduct";
            dtg_ViewProduct.RowTemplate.Height = 25;
            dtg_ViewProduct.Size = new Size(292, 182);
            dtg_ViewProduct.TabIndex = 30;
            dtg_ViewProduct.CellClick += dtg_ViewProduct_CellClick;
            // 
            // panel2
            // 
            panel2.Controls.Add(label8);
            panel2.Controls.Add(txt_SpeciesNest);
            panel2.Controls.Add(rtb_DescriptonNest);
            panel2.Controls.Add(txt_PriceNest);
            panel2.Controls.Add(txt_QuantityNest);
            panel2.Controls.Add(label14);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(txt_NameNest);
            panel2.Controls.Add(label10);
            panel2.Location = new Point(6, 23);
            panel2.Name = "panel2";
            panel2.Size = new Size(605, 312);
            panel2.TabIndex = 21;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("UD Digi Kyokasho NP-B", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(33, 118);
            label10.Name = "label10";
            label10.Size = new Size(73, 17);
            label10.TabIndex = 11;
            label10.Text = "Species:";
            // 
            // txt_NameNest
            // 
            txt_NameNest.Location = new Point(115, 71);
            txt_NameNest.Name = "txt_NameNest";
            txt_NameNest.Size = new Size(149, 23);
            txt_NameNest.TabIndex = 11;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("UD Digi Kyokasho NP-B", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(48, 71);
            label11.Name = "label11";
            label11.Size = new Size(58, 17);
            label11.TabIndex = 12;
            label11.Text = "Name:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("UD Digi Kyokasho NP-B", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(343, 120);
            label12.Name = "label12";
            label12.Size = new Size(104, 17);
            label12.TabIndex = 13;
            label12.Text = "Description:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("UD Digi Kyokasho NP-B", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(343, 72);
            label13.Name = "label13";
            label13.Size = new Size(54, 17);
            label13.TabIndex = 14;
            label13.Text = "Price:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("UD Digi Kyokasho NP-B", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(22, 162);
            label14.Name = "label14";
            label14.Size = new Size(84, 17);
            label14.TabIndex = 15;
            label14.Text = "Quantity:";
            // 
            // txt_QuantityNest
            // 
            txt_QuantityNest.Location = new Point(115, 162);
            txt_QuantityNest.Name = "txt_QuantityNest";
            txt_QuantityNest.Size = new Size(149, 23);
            txt_QuantityNest.TabIndex = 17;
            // 
            // txt_PriceNest
            // 
            txt_PriceNest.Location = new Point(401, 69);
            txt_PriceNest.Name = "txt_PriceNest";
            txt_PriceNest.Size = new Size(127, 23);
            txt_PriceNest.TabIndex = 18;
            // 
            // rtb_DescriptonNest
            // 
            rtb_DescriptonNest.Location = new Point(343, 150);
            rtb_DescriptonNest.Name = "rtb_DescriptonNest";
            rtb_DescriptonNest.Size = new Size(238, 82);
            rtb_DescriptonNest.TabIndex = 11;
            rtb_DescriptonNest.Text = "";
            // 
            // txt_SpeciesNest
            // 
            txt_SpeciesNest.Location = new Point(115, 118);
            txt_SpeciesNest.Name = "txt_SpeciesNest";
            txt_SpeciesNest.Size = new Size(149, 23);
            txt_SpeciesNest.TabIndex = 20;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("UD Digi Kyokasho NP-B", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(183, 3);
            label8.Name = "label8";
            label8.Size = new Size(151, 28);
            label8.TabIndex = 21;
            label8.Text = "Nest Detail";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(panel2);
            groupBox4.Location = new Point(587, 247);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(617, 353);
            groupBox4.TabIndex = 29;
            groupBox4.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("UD Digi Kyokasho NP-B", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(66, 56);
            label2.Name = "label2";
            label2.Size = new Size(58, 17);
            label2.TabIndex = 0;
            label2.Text = "Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("UD Digi Kyokasho NP-B", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(4, 97);
            label3.Name = "label3";
            label3.Size = new Size(120, 17);
            label3.TabIndex = 1;
            label3.Text = "Species name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("UD Digi Kyokasho NP-B", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(53, 138);
            label4.Name = "label4";
            label4.Size = new Size(71, 17);
            label4.TabIndex = 2;
            label4.Text = "Gender:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("UD Digi Kyokasho NP-B", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(80, 178);
            label5.Name = "label5";
            label5.Size = new Size(44, 17);
            label5.TabIndex = 3;
            label5.Text = "Age:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("UD Digi Kyokasho NP-B", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(308, 103);
            label6.Name = "label6";
            label6.Size = new Size(104, 17);
            label6.TabIndex = 4;
            label6.Text = "Description:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("UD Digi Kyokasho NP-B", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(358, 60);
            label7.Name = "label7";
            label7.Size = new Size(54, 17);
            label7.TabIndex = 5;
            label7.Text = "Price:";
            // 
            // rtb_DescriptionBird
            // 
            rtb_DescriptionBird.Location = new Point(308, 136);
            rtb_DescriptionBird.Name = "rtb_DescriptionBird";
            rtb_DescriptionBird.Size = new Size(242, 82);
            rtb_DescriptionBird.TabIndex = 6;
            rtb_DescriptionBird.Text = "";
            // 
            // txt_NameBird
            // 
            txt_NameBird.Location = new Point(130, 54);
            txt_NameBird.Name = "txt_NameBird";
            txt_NameBird.Size = new Size(191, 23);
            txt_NameBird.TabIndex = 7;
            // 
            // txt_SpeciesNameBird
            // 
            txt_SpeciesNameBird.Location = new Point(130, 97);
            txt_SpeciesNameBird.Name = "txt_SpeciesNameBird";
            txt_SpeciesNameBird.Size = new Size(111, 23);
            txt_SpeciesNameBird.TabIndex = 8;
            // 
            // txt_GenderBird
            // 
            txt_GenderBird.Location = new Point(130, 136);
            txt_GenderBird.Name = "txt_GenderBird";
            txt_GenderBird.Size = new Size(85, 23);
            txt_GenderBird.TabIndex = 9;
            // 
            // txt_AgeBird
            // 
            txt_AgeBird.Location = new Point(130, 175);
            txt_AgeBird.Name = "txt_AgeBird";
            txt_AgeBird.Size = new Size(58, 23);
            txt_AgeBird.TabIndex = 10;
            // 
            // txt_PriceBird
            // 
            txt_PriceBird.Location = new Point(418, 54);
            txt_PriceBird.Name = "txt_PriceBird";
            txt_PriceBird.Size = new Size(114, 23);
            txt_PriceBird.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("UD Digi Kyokasho NP-B", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(206, 0);
            label1.Name = "label1";
            label1.Size = new Size(146, 28);
            label1.TabIndex = 11;
            label1.Text = "Bird Detail";
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txt_PriceBird);
            panel1.Controls.Add(txt_AgeBird);
            panel1.Controls.Add(txt_GenderBird);
            panel1.Controls.Add(txt_SpeciesNameBird);
            panel1.Controls.Add(txt_NameBird);
            panel1.Controls.Add(rtb_DescriptionBird);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(11, 28);
            panel1.Name = "panel1";
            panel1.Size = new Size(554, 309);
            panel1.TabIndex = 2;
            // 
            // PurchasedOrders
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1214, 604);
            Controls.Add(label22);
            Controls.Add(label21);
            Controls.Add(dtg_ViewProduct);
            Controls.Add(dtg_ViewOrder);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Name = "PurchasedOrders";
            Text = "PurchasedOrders";
            Load += PurchasedOrders_Load;
            ((System.ComponentModel.ISupportInitialize)dtg_ViewOrder).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtg_ViewProduct).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBox4.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label21;
        private DataGridView dtg_ViewOrder;
        private GroupBox groupBox1;
        private TextBox txt_Provider;
        private TextBox txt_PaymentMethod;
        private Label label_Total;
        private Label label_Fullname;
        private TextBox txt_EstimatedDate;
        private TextBox txt_CreateDate;
        private TextBox txt_Phone;
        private Label label18;
        private Label label19;
        private Label label20;
        private Label label17;
        private Label label16;
        private Label label15;
        private TextBox txt_Address;
        private Label label9;
        private Label label_Provider;
        private GroupBox groupBox3;
        private Panel panel1;
        private Label label1;
        private TextBox txt_PriceBird;
        private TextBox txt_AgeBird;
        private TextBox txt_GenderBird;
        private TextBox txt_SpeciesNameBird;
        private TextBox txt_NameBird;
        private RichTextBox rtb_DescriptionBird;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label22;
        private DataGridView dtg_ViewProduct;
        private Panel panel2;
        private Label label8;
        private TextBox txt_SpeciesNest;
        private RichTextBox rtb_DescriptonNest;
        private TextBox txt_PriceNest;
        private TextBox txt_QuantityNest;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private TextBox txt_NameNest;
        private Label label10;
        private GroupBox groupBox4;
    }
}
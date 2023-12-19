namespace BSAPP
{
    partial class HomePage
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
            label1 = new Label();
            groupBox2 = new GroupBox();
            Link_Orders = new LinkLabel();
            link_ViewCart = new LinkLabel();
            link_Home = new LinkLabel();
            link_Register = new LinkLabel();
            link_Login = new LinkLabel();
            linkL_LogOut = new LinkLabel();
            groupBox3 = new GroupBox();
            cb_SpeciesBird = new ComboBox();
            label15 = new Label();
            label8 = new Label();
            dtg_ViewBirds = new DataGridView();
            panel1 = new Panel();
            btn_AddToCartBird = new Button();
            txt_PriceBird = new TextBox();
            txt_AgeBird = new TextBox();
            txt_GenderBird = new TextBox();
            txt_SpeciesNameBird = new TextBox();
            txt_NameBird = new TextBox();
            rtb_DescriptionBird = new RichTextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox4 = new GroupBox();
            label16 = new Label();
            cb_SpeciesNest = new ComboBox();
            panel2 = new Panel();
            txt_SpeciesNest = new TextBox();
            btn_ViewParents = new Button();
            btn_AddToCartNest = new Button();
            rtb_DescriptonNest = new RichTextBox();
            txt_PriceNest = new TextBox();
            txt_QuantityNest = new TextBox();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            txt_NameNest = new TextBox();
            label10 = new Label();
            dtg_ViewNests = new DataGridView();
            label9 = new Label();
            groupBox5 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_ViewBirds).BeginInit();
            panel1.SuspendLayout();
            groupBox4.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_ViewNests).BeginInit();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1190, 67);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("UD Digi Kyokasho NP-B", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(422, 19);
            label1.Name = "label1";
            label1.Size = new Size(428, 34);
            label1.TabIndex = 0;
            label1.Text = "Welcome to Bird Farm Shop";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(Link_Orders);
            groupBox2.Controls.Add(link_ViewCart);
            groupBox2.Controls.Add(link_Home);
            groupBox2.Location = new Point(12, 77);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(130, 215);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // Link_Orders
            // 
            Link_Orders.AutoSize = true;
            Link_Orders.Font = new Font("UD Digi Kyokasho NP-B", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            Link_Orders.Location = new Point(10, 147);
            Link_Orders.Name = "Link_Orders";
            Link_Orders.Size = new Size(110, 31);
            Link_Orders.TabIndex = 6;
            Link_Orders.TabStop = true;
            Link_Orders.Text = "Orders";
            Link_Orders.LinkClicked += Link_Orders_LinkClicked;
            // 
            // link_ViewCart
            // 
            link_ViewCart.AutoSize = true;
            link_ViewCart.Font = new Font("UD Digi Kyokasho NP-B", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            link_ViewCart.Location = new Point(26, 88);
            link_ViewCart.Name = "link_ViewCart";
            link_ViewCart.Size = new Size(76, 31);
            link_ViewCart.TabIndex = 3;
            link_ViewCart.TabStop = true;
            link_ViewCart.Text = "Cart";
            link_ViewCart.LinkClicked += link_ViewCart_LinkClicked;
            // 
            // link_Home
            // 
            link_Home.AutoSize = true;
            link_Home.Font = new Font("UD Digi Kyokasho NP-B", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            link_Home.Location = new Point(20, 31);
            link_Home.Name = "link_Home";
            link_Home.Size = new Size(91, 31);
            link_Home.TabIndex = 1;
            link_Home.TabStop = true;
            link_Home.Text = "Home";
            link_Home.LinkClicked += link_Home_LinkClicked;
            // 
            // link_Register
            // 
            link_Register.AutoSize = true;
            link_Register.Font = new Font("UD Digi Kyokasho NP-B", 18F, FontStyle.Bold, GraphicsUnit.Point);
            link_Register.Location = new Point(9, 175);
            link_Register.Name = "link_Register";
            link_Register.Size = new Size(115, 28);
            link_Register.TabIndex = 5;
            link_Register.TabStop = true;
            link_Register.Text = "Register";
            link_Register.LinkClicked += link_Register_LinkClicked;
            // 
            // link_Login
            // 
            link_Login.AutoSize = true;
            link_Login.Font = new Font("UD Digi Kyokasho NP-B", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            link_Login.Location = new Point(18, 102);
            link_Login.Name = "link_Login";
            link_Login.Size = new Size(98, 31);
            link_Login.TabIndex = 4;
            link_Login.TabStop = true;
            link_Login.Text = "Log in";
            link_Login.LinkClicked += link_Login_LinkClicked;
            // 
            // linkL_LogOut
            // 
            linkL_LogOut.AutoSize = true;
            linkL_LogOut.Font = new Font("UD Digi Kyokasho NP-B", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            linkL_LogOut.Location = new Point(6, 236);
            linkL_LogOut.Name = "linkL_LogOut";
            linkL_LogOut.Size = new Size(117, 31);
            linkL_LogOut.TabIndex = 2;
            linkL_LogOut.TabStop = true;
            linkL_LogOut.Text = "Log out";
            linkL_LogOut.LinkClicked += linkL_LogOut_LinkClicked;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(cb_SpeciesBird);
            groupBox3.Controls.Add(label15);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(dtg_ViewBirds);
            groupBox3.Controls.Add(panel1);
            groupBox3.Location = new Point(148, 77);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(576, 515);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            // 
            // cb_SpeciesBird
            // 
            cb_SpeciesBird.FormattingEnabled = true;
            cb_SpeciesBird.Location = new Point(456, 26);
            cb_SpeciesBird.Name = "cb_SpeciesBird";
            cb_SpeciesBird.Size = new Size(105, 23);
            cb_SpeciesBird.TabIndex = 12;
            cb_SpeciesBird.SelectedIndexChanged += cb_SpeciesBird_SelectedIndexChanged;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("UD Digi Kyokasho NP-B", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label15.Location = new Point(324, 27);
            label15.Name = "label15";
            label15.Size = new Size(125, 18);
            label15.TabIndex = 13;
            label15.Text = "Filter Species:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("UD Digi Kyokasho NP-B", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(53, 19);
            label8.Name = "label8";
            label8.Size = new Size(96, 34);
            label8.TabIndex = 1;
            label8.Text = "Birds";
            // 
            // dtg_ViewBirds
            // 
            dtg_ViewBirds.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtg_ViewBirds.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_ViewBirds.Location = new Point(9, 63);
            dtg_ViewBirds.Name = "dtg_ViewBirds";
            dtg_ViewBirds.RowTemplate.Height = 25;
            dtg_ViewBirds.Size = new Size(551, 174);
            dtg_ViewBirds.TabIndex = 2;
            dtg_ViewBirds.CellClick += dtg_ViewBirds_CellClick;
            // 
            // panel1
            // 
            panel1.Controls.Add(btn_AddToCartBird);
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
            panel1.Location = new Point(9, 243);
            panel1.Name = "panel1";
            panel1.Size = new Size(551, 266);
            panel1.TabIndex = 1;
            // 
            // btn_AddToCartBird
            // 
            btn_AddToCartBird.Font = new Font("UD Digi Kyokasho NP-B", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_AddToCartBird.Location = new Point(424, 105);
            btn_AddToCartBird.Name = "btn_AddToCartBird";
            btn_AddToCartBird.Size = new Size(105, 49);
            btn_AddToCartBird.TabIndex = 11;
            btn_AddToCartBird.Text = "Add To Cart";
            btn_AddToCartBird.UseVisualStyleBackColor = true;
            btn_AddToCartBird.Click += btn_AddToCartBird_Click;
            // 
            // txt_PriceBird
            // 
            txt_PriceBird.Location = new Point(424, 62);
            txt_PriceBird.Name = "txt_PriceBird";
            txt_PriceBird.Size = new Size(105, 23);
            txt_PriceBird.TabIndex = 8;
            // 
            // txt_AgeBird
            // 
            txt_AgeBird.Location = new Point(137, 131);
            txt_AgeBird.Name = "txt_AgeBird";
            txt_AgeBird.Size = new Size(112, 23);
            txt_AgeBird.TabIndex = 10;
            // 
            // txt_GenderBird
            // 
            txt_GenderBird.Location = new Point(137, 92);
            txt_GenderBird.Name = "txt_GenderBird";
            txt_GenderBird.Size = new Size(242, 23);
            txt_GenderBird.TabIndex = 9;
            // 
            // txt_SpeciesNameBird
            // 
            txt_SpeciesNameBird.Location = new Point(137, 53);
            txt_SpeciesNameBird.Name = "txt_SpeciesNameBird";
            txt_SpeciesNameBird.Size = new Size(242, 23);
            txt_SpeciesNameBird.TabIndex = 8;
            // 
            // txt_NameBird
            // 
            txt_NameBird.Location = new Point(137, 10);
            txt_NameBird.Name = "txt_NameBird";
            txt_NameBird.Size = new Size(242, 23);
            txt_NameBird.TabIndex = 7;
            // 
            // rtb_DescriptionBird
            // 
            rtb_DescriptionBird.Location = new Point(137, 169);
            rtb_DescriptionBird.Name = "rtb_DescriptionBird";
            rtb_DescriptionBird.Size = new Size(242, 82);
            rtb_DescriptionBird.TabIndex = 6;
            rtb_DescriptionBird.Text = "";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("UD Digi Kyokasho NP-B", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(450, 32);
            label7.Name = "label7";
            label7.Size = new Size(54, 17);
            label7.TabIndex = 5;
            label7.Text = "Price:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("UD Digi Kyokasho NP-B", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(27, 171);
            label6.Name = "label6";
            label6.Size = new Size(104, 17);
            label6.TabIndex = 4;
            label6.Text = "Description:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("UD Digi Kyokasho NP-B", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(87, 134);
            label5.Name = "label5";
            label5.Size = new Size(44, 17);
            label5.TabIndex = 3;
            label5.Text = "Age:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("UD Digi Kyokasho NP-B", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(60, 94);
            label4.Name = "label4";
            label4.Size = new Size(71, 17);
            label4.TabIndex = 2;
            label4.Text = "Gender:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("UD Digi Kyokasho NP-B", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(11, 53);
            label3.Name = "label3";
            label3.Size = new Size(120, 17);
            label3.TabIndex = 1;
            label3.Text = "Species name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("UD Digi Kyokasho NP-B", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(73, 12);
            label2.Name = "label2";
            label2.Size = new Size(58, 17);
            label2.TabIndex = 0;
            label2.Text = "Name:";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label16);
            groupBox4.Controls.Add(cb_SpeciesNest);
            groupBox4.Controls.Add(panel2);
            groupBox4.Controls.Add(dtg_ViewNests);
            groupBox4.Controls.Add(label9);
            groupBox4.Location = new Point(730, 77);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(472, 515);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("UD Digi Kyokasho NP-B", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label16.Location = new Point(219, 24);
            label16.Name = "label16";
            label16.Size = new Size(125, 18);
            label16.TabIndex = 14;
            label16.Text = "Filter Species:";
            // 
            // cb_SpeciesNest
            // 
            cb_SpeciesNest.FormattingEnabled = true;
            cb_SpeciesNest.Location = new Point(350, 23);
            cb_SpeciesNest.Name = "cb_SpeciesNest";
            cb_SpeciesNest.Size = new Size(116, 23);
            cb_SpeciesNest.TabIndex = 13;
            cb_SpeciesNest.SelectedIndexChanged += cb_SpeciesNest_SelectedIndexChanged;
            // 
            // panel2
            // 
            panel2.Controls.Add(txt_SpeciesNest);
            panel2.Controls.Add(btn_ViewParents);
            panel2.Controls.Add(btn_AddToCartNest);
            panel2.Controls.Add(rtb_DescriptonNest);
            panel2.Controls.Add(txt_PriceNest);
            panel2.Controls.Add(txt_QuantityNest);
            panel2.Controls.Add(label14);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(txt_NameNest);
            panel2.Controls.Add(label10);
            panel2.Location = new Point(6, 243);
            panel2.Name = "panel2";
            panel2.Size = new Size(460, 266);
            panel2.TabIndex = 4;
            // 
            // txt_SpeciesNest
            // 
            txt_SpeciesNest.Location = new Point(135, 62);
            txt_SpeciesNest.Name = "txt_SpeciesNest";
            txt_SpeciesNest.Size = new Size(172, 23);
            txt_SpeciesNest.TabIndex = 20;
            // 
            // btn_ViewParents
            // 
            btn_ViewParents.Font = new Font("UD Digi Kyokasho NP-B", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_ViewParents.Location = new Point(339, 105);
            btn_ViewParents.Name = "btn_ViewParents";
            btn_ViewParents.Size = new Size(105, 49);
            btn_ViewParents.TabIndex = 19;
            btn_ViewParents.Text = "View Parents";
            btn_ViewParents.UseVisualStyleBackColor = true;
            btn_ViewParents.Click += btn_ViewParents_Click;
            // 
            // btn_AddToCartNest
            // 
            btn_AddToCartNest.Font = new Font("UD Digi Kyokasho NP-B", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_AddToCartNest.Location = new Point(339, 17);
            btn_AddToCartNest.Name = "btn_AddToCartNest";
            btn_AddToCartNest.Size = new Size(105, 49);
            btn_AddToCartNest.TabIndex = 12;
            btn_AddToCartNest.Text = "Add To Cart";
            btn_AddToCartNest.UseVisualStyleBackColor = true;
            btn_AddToCartNest.Click += btn_AddToCartNest_Click;
            // 
            // rtb_DescriptonNest
            // 
            rtb_DescriptonNest.Location = new Point(135, 181);
            rtb_DescriptonNest.Name = "rtb_DescriptonNest";
            rtb_DescriptonNest.Size = new Size(238, 70);
            rtb_DescriptonNest.TabIndex = 11;
            rtb_DescriptonNest.Text = "";
            // 
            // txt_PriceNest
            // 
            txt_PriceNest.Location = new Point(135, 137);
            txt_PriceNest.Name = "txt_PriceNest";
            txt_PriceNest.Size = new Size(172, 23);
            txt_PriceNest.TabIndex = 18;
            // 
            // txt_QuantityNest
            // 
            txt_QuantityNest.Location = new Point(135, 98);
            txt_QuantityNest.Name = "txt_QuantityNest";
            txt_QuantityNest.Size = new Size(172, 23);
            txt_QuantityNest.TabIndex = 17;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("UD Digi Kyokasho NP-B", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(42, 98);
            label14.Name = "label14";
            label14.Size = new Size(84, 17);
            label14.TabIndex = 15;
            label14.Text = "Quantity:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("UD Digi Kyokasho NP-B", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(68, 137);
            label13.Name = "label13";
            label13.Size = new Size(54, 17);
            label13.TabIndex = 14;
            label13.Text = "Price:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("UD Digi Kyokasho NP-B", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(22, 179);
            label12.Name = "label12";
            label12.Size = new Size(104, 17);
            label12.TabIndex = 13;
            label12.Text = "Description:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("UD Digi Kyokasho NP-B", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(68, 16);
            label11.Name = "label11";
            label11.Size = new Size(58, 17);
            label11.TabIndex = 12;
            label11.Text = "Name:";
            // 
            // txt_NameNest
            // 
            txt_NameNest.Location = new Point(135, 16);
            txt_NameNest.Name = "txt_NameNest";
            txt_NameNest.Size = new Size(172, 23);
            txt_NameNest.TabIndex = 11;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("UD Digi Kyokasho NP-B", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(53, 55);
            label10.Name = "label10";
            label10.Size = new Size(73, 17);
            label10.TabIndex = 11;
            label10.Text = "Species:";
            // 
            // dtg_ViewNests
            // 
            dtg_ViewNests.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtg_ViewNests.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_ViewNests.Location = new Point(6, 63);
            dtg_ViewNests.Name = "dtg_ViewNests";
            dtg_ViewNests.RowTemplate.Height = 25;
            dtg_ViewNests.Size = new Size(460, 174);
            dtg_ViewNests.TabIndex = 3;
            dtg_ViewNests.CellClick += dtg_ViewNests_CellClick;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("UD Digi Kyokasho NP-B", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(48, 19);
            label9.Name = "label9";
            label9.Size = new Size(100, 34);
            label9.TabIndex = 3;
            label9.Text = "Nests";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(link_Register);
            groupBox5.Controls.Add(linkL_LogOut);
            groupBox5.Controls.Add(link_Login);
            groupBox5.Location = new Point(12, 298);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(130, 294);
            groupBox5.TabIndex = 7;
            groupBox5.TabStop = false;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1214, 604);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "HomePage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HomePage";
            Load += HomePage_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_ViewBirds).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_ViewNests).EndInit();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private LinkLabel link_ViewCart;
        private LinkLabel linkL_LogOut;
        private LinkLabel link_Home;
        private GroupBox groupBox3;
        private Label label1;
        private Panel panel1;
        private DataGridView dtg_ViewBirds;
        private Label label3;
        private Label label2;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox txt_PriceBird;
        private TextBox txt_AgeBird;
        private TextBox txt_GenderBird;
        private TextBox txt_SpeciesNameBird;
        private TextBox txt_NameBird;
        private RichTextBox rtb_DescriptionBird;
        private GroupBox groupBox4;
        private Label label8;
        private DataGridView dtg_ViewNests;
        private Label label9;
        private Panel panel2;
        private Label label13;
        private Label label12;
        private Label label11;
        private TextBox txt_NameNest;
        private Label label10;
        private Label label14;
        private RichTextBox rtb_DescriptonNest;
        private TextBox txt_PriceNest;
        private TextBox txt_QuantityNest;
        private Button btn_AddToCartBird;
        private Button btn_ViewParents;
        private Button btn_AddToCartNest;
        private Label label15;
        private ComboBox cb_SpeciesBird;
        private ComboBox cb_SpeciesNest;
        private Label label16;
        private TextBox txt_SpeciesNest;
        private LinkLabel link_Login;
        private LinkLabel link_Register;
        private LinkLabel Link_Orders;
        private GroupBox groupBox5;
    }
}
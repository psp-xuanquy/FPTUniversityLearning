namespace BSAPP
{
    partial class ViewCart
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
            dtg_ViewCart = new DataGridView();
            panel1 = new Panel();
            label1 = new Label();
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
            panel2 = new Panel();
            label8 = new Label();
            txt_SpeciesNest = new TextBox();
            rtb_DescriptonNest = new RichTextBox();
            txt_PriceNest = new TextBox();
            txt_QuantityNest = new TextBox();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            txt_NameNest = new TextBox();
            label10 = new Label();
            btn_Back = new Button();
            txt_Total = new TextBox();
            label9 = new Label();
            label15 = new Label();
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            btn_Remove = new Button();
            btn_Order = new Button();
            groupBox3 = new GroupBox();
            groupBox4 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dtg_ViewCart).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // dtg_ViewCart
            // 
            dtg_ViewCart.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtg_ViewCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_ViewCart.Location = new Point(392, 16);
            dtg_ViewCart.Margin = new Padding(3, 4, 3, 4);
            dtg_ViewCart.Name = "dtg_ViewCart";
            dtg_ViewCart.RowHeadersWidth = 51;
            dtg_ViewCart.RowTemplate.Height = 25;
            dtg_ViewCart.Size = new Size(633, 200);
            dtg_ViewCart.TabIndex = 0;
            dtg_ViewCart.CellClick += dtg_ViewCart_CellClick;
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
            panel1.Location = new Point(13, 37);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(633, 412);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(235, 0);
            label1.Name = "label1";
            label1.Size = new Size(163, 36);
            label1.TabIndex = 11;
            label1.Text = "Bird Detail";
            // 
            // txt_PriceBird
            // 
            txt_PriceBird.Location = new Point(478, 72);
            txt_PriceBird.Margin = new Padding(3, 4, 3, 4);
            txt_PriceBird.Name = "txt_PriceBird";
            txt_PriceBird.Size = new Size(130, 27);
            txt_PriceBird.TabIndex = 8;
            // 
            // txt_AgeBird
            // 
            txt_AgeBird.Location = new Point(149, 233);
            txt_AgeBird.Margin = new Padding(3, 4, 3, 4);
            txt_AgeBird.Name = "txt_AgeBird";
            txt_AgeBird.Size = new Size(114, 27);
            txt_AgeBird.TabIndex = 10;
            // 
            // txt_GenderBird
            // 
            txt_GenderBird.Location = new Point(149, 181);
            txt_GenderBird.Margin = new Padding(3, 4, 3, 4);
            txt_GenderBird.Name = "txt_GenderBird";
            txt_GenderBird.Size = new Size(218, 27);
            txt_GenderBird.TabIndex = 9;
            // 
            // txt_SpeciesNameBird
            // 
            txt_SpeciesNameBird.Location = new Point(149, 129);
            txt_SpeciesNameBird.Margin = new Padding(3, 4, 3, 4);
            txt_SpeciesNameBird.Name = "txt_SpeciesNameBird";
            txt_SpeciesNameBird.Size = new Size(218, 27);
            txt_SpeciesNameBird.TabIndex = 8;
            // 
            // txt_NameBird
            // 
            txt_NameBird.Location = new Point(149, 72);
            txt_NameBird.Margin = new Padding(3, 4, 3, 4);
            txt_NameBird.Name = "txt_NameBird";
            txt_NameBird.Size = new Size(218, 27);
            txt_NameBird.TabIndex = 7;
            // 
            // rtb_DescriptionBird
            // 
            rtb_DescriptionBird.Location = new Point(149, 284);
            rtb_DescriptionBird.Margin = new Padding(3, 4, 3, 4);
            rtb_DescriptionBird.Name = "rtb_DescriptionBird";
            rtb_DescriptionBird.Size = new Size(276, 108);
            rtb_DescriptionBird.TabIndex = 6;
            rtb_DescriptionBird.Text = "";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(409, 80);
            label7.Name = "label7";
            label7.Size = new Size(64, 24);
            label7.TabIndex = 5;
            label7.Text = "Price:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(23, 287);
            label6.Name = "label6";
            label6.Size = new Size(121, 24);
            label6.TabIndex = 4;
            label6.Text = "Description:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(91, 237);
            label5.Name = "label5";
            label5.Size = new Size(54, 24);
            label5.TabIndex = 3;
            label5.Text = "Age:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(61, 184);
            label4.Name = "label4";
            label4.Size = new Size(86, 24);
            label4.TabIndex = 2;
            label4.Text = "Gender:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(5, 129);
            label3.Name = "label3";
            label3.Size = new Size(149, 24);
            label3.TabIndex = 1;
            label3.Text = "Species name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(75, 75);
            label2.Name = "label2";
            label2.Size = new Size(71, 24);
            label2.TabIndex = 0;
            label2.Text = "Name:";
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
            panel2.Location = new Point(681, 251);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(526, 416);
            panel2.TabIndex = 5;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(209, 4);
            label8.Name = "label8";
            label8.Size = new Size(170, 36);
            label8.TabIndex = 21;
            label8.Text = "Nest Detail";
            // 
            // txt_SpeciesNest
            // 
            txt_SpeciesNest.Location = new Point(131, 157);
            txt_SpeciesNest.Margin = new Padding(3, 4, 3, 4);
            txt_SpeciesNest.Name = "txt_SpeciesNest";
            txt_SpeciesNest.Size = new Size(189, 27);
            txt_SpeciesNest.TabIndex = 20;
            // 
            // rtb_DescriptonNest
            // 
            rtb_DescriptonNest.Location = new Point(131, 275);
            rtb_DescriptonNest.Margin = new Padding(3, 4, 3, 4);
            rtb_DescriptonNest.Name = "rtb_DescriptonNest";
            rtb_DescriptonNest.Size = new Size(271, 121);
            rtb_DescriptonNest.TabIndex = 11;
            rtb_DescriptonNest.Text = "";
            // 
            // txt_PriceNest
            // 
            txt_PriceNest.Location = new Point(351, 125);
            txt_PriceNest.Margin = new Padding(3, 4, 3, 4);
            txt_PriceNest.Name = "txt_PriceNest";
            txt_PriceNest.Size = new Size(145, 27);
            txt_PriceNest.TabIndex = 18;
            // 
            // txt_QuantityNest
            // 
            txt_QuantityNest.Location = new Point(131, 216);
            txt_QuantityNest.Margin = new Padding(3, 4, 3, 4);
            txt_QuantityNest.Name = "txt_QuantityNest";
            txt_QuantityNest.Size = new Size(189, 27);
            txt_QuantityNest.TabIndex = 17;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(25, 216);
            label14.Name = "label14";
            label14.Size = new Size(92, 24);
            label14.TabIndex = 15;
            label14.Text = "Quantity:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(351, 91);
            label13.Name = "label13";
            label13.Size = new Size(64, 24);
            label13.TabIndex = 14;
            label13.Text = "Price:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(2, 272);
            label12.Name = "label12";
            label12.Size = new Size(121, 24);
            label12.TabIndex = 13;
            label12.Text = "Description:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(55, 95);
            label11.Name = "label11";
            label11.Size = new Size(71, 24);
            label11.TabIndex = 12;
            label11.Text = "Name:";
            // 
            // txt_NameNest
            // 
            txt_NameNest.Location = new Point(131, 95);
            txt_NameNest.Margin = new Padding(3, 4, 3, 4);
            txt_NameNest.Name = "txt_NameNest";
            txt_NameNest.Size = new Size(189, 27);
            txt_NameNest.TabIndex = 11;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(38, 157);
            label10.Name = "label10";
            label10.Size = new Size(91, 24);
            label10.TabIndex = 11;
            label10.Text = "Species:";
            // 
            // btn_Back
            // 
            btn_Back.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Back.Location = new Point(208, 131);
            btn_Back.Margin = new Padding(3, 4, 3, 4);
            btn_Back.Name = "btn_Back";
            btn_Back.Size = new Size(107, 55);
            btn_Back.TabIndex = 6;
            btn_Back.Text = "Back";
            btn_Back.UseVisualStyleBackColor = true;
            btn_Back.Click += btn_Back_Click;
            // 
            // txt_Total
            // 
            txt_Total.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txt_Total.Location = new Point(25, 47);
            txt_Total.Margin = new Padding(3, 4, 3, 4);
            txt_Total.Multiline = true;
            txt_Total.Name = "txt_Total";
            txt_Total.Size = new Size(140, 28);
            txt_Total.TabIndex = 12;
            txt_Total.TextAlign = HorizontalAlignment.Center;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(71, 19);
            label9.Name = "label9";
            label9.Size = new Size(61, 25);
            label9.TabIndex = 12;
            label9.Text = "Total";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label15.Location = new Point(35, 16);
            label15.Name = "label15";
            label15.Size = new Size(297, 69);
            label15.TabIndex = 14;
            label15.Text = "View Cart";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.shopping_cart_removebg_preview;
            pictureBox1.Location = new Point(35, 99);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(96, 105);
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_Back);
            groupBox1.Controls.Add(label15);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Location = new Point(8, 4);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(374, 212);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btn_Remove);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(btn_Order);
            groupBox2.Controls.Add(txt_Total);
            groupBox2.Location = new Point(1032, 4);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(185, 212);
            groupBox2.TabIndex = 17;
            groupBox2.TabStop = false;
            // 
            // btn_Remove
            // 
            btn_Remove.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Remove.Location = new Point(25, 147);
            btn_Remove.Margin = new Padding(3, 4, 3, 4);
            btn_Remove.Name = "btn_Remove";
            btn_Remove.Size = new Size(141, 55);
            btn_Remove.TabIndex = 17;
            btn_Remove.Text = "Remove";
            btn_Remove.UseVisualStyleBackColor = true;
            btn_Remove.Click += btn_Remove_Click;
            // 
            // btn_Order
            // 
            btn_Order.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Order.Location = new Point(25, 84);
            btn_Order.Margin = new Padding(3, 4, 3, 4);
            btn_Order.Name = "btn_Order";
            btn_Order.Size = new Size(141, 55);
            btn_Order.TabIndex = 16;
            btn_Order.Text = "Order";
            btn_Order.UseVisualStyleBackColor = true;
            btn_Order.Click += btn_Order_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(panel1);
            groupBox3.Location = new Point(8, 217);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(653, 464);
            groupBox3.TabIndex = 12;
            groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            groupBox4.Location = new Point(667, 217);
            groupBox4.Margin = new Padding(3, 4, 3, 4);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(3, 4, 3, 4);
            groupBox4.Size = new Size(550, 464);
            groupBox4.TabIndex = 18;
            groupBox4.TabStop = false;
            // 
            // ViewCart
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1226, 697);
            Controls.Add(groupBox2);
            Controls.Add(panel2);
            Controls.Add(dtg_ViewCart);
            Controls.Add(groupBox1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox4);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ViewCart";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewCart";
            Load += ViewCart_Load;
            ((System.ComponentModel.ISupportInitialize)dtg_ViewCart).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dtg_ViewCart;
        private Panel panel1;
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
        private Panel panel2;
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
        private Label label1;
        private Label label8;
        private Button btn_Back;
        private TextBox txt_Total;
        private Label label9;
        private Label label15;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private Button btn_Order;
        private Button btn_Remove;
    }
}
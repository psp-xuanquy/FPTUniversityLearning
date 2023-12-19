namespace BSAPP
{
    partial class ManageProducts
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
            pictureBox1 = new PictureBox();
            btn_BirdManager = new Button();
            label1 = new Label();
            groupBox2 = new GroupBox();
            pictureBox2 = new PictureBox();
            btn_NestManager = new Button();
            label2 = new Label();
            btn_Back = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(btn_BirdManager);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(23, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(317, 413);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.bird;
            pictureBox1.Location = new Point(28, 75);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(256, 236);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // btn_BirdManager
            // 
            btn_BirdManager.Font = new Font("UD Digi Kyokasho NP-B", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_BirdManager.Location = new Point(74, 326);
            btn_BirdManager.Name = "btn_BirdManager";
            btn_BirdManager.Size = new Size(126, 57);
            btn_BirdManager.TabIndex = 1;
            btn_BirdManager.Text = "Manage";
            btn_BirdManager.UseVisualStyleBackColor = true;
            btn_BirdManager.Click += btn_BirdManager_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("UD Digi Kyokasho NP-B", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(28, 32);
            label1.Name = "label1";
            label1.Size = new Size(232, 37);
            label1.TabIndex = 0;
            label1.Text = "Manage Bird";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(pictureBox2);
            groupBox2.Controls.Add(btn_NestManager);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(482, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(296, 413);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.nest;
            pictureBox2.Location = new Point(18, 75);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(263, 224);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // btn_NestManager
            // 
            btn_NestManager.Font = new Font("UD Digi Kyokasho NP-B", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_NestManager.Location = new Point(87, 326);
            btn_NestManager.Name = "btn_NestManager";
            btn_NestManager.Size = new Size(126, 57);
            btn_NestManager.TabIndex = 2;
            btn_NestManager.Text = "Manage";
            btn_NestManager.UseVisualStyleBackColor = true;
            btn_NestManager.Click += btn_NestManager_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("UD Digi Kyokasho NP-B", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(28, 32);
            label2.Name = "label2";
            label2.Size = new Size(236, 37);
            label2.TabIndex = 1;
            label2.Text = "Manage Nest";
            // 
            // btn_Back
            // 
            btn_Back.Font = new Font("UD Digi Kyokasho NP-B", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Back.Location = new Point(348, 186);
            btn_Back.Name = "btn_Back";
            btn_Back.Size = new Size(126, 57);
            btn_Back.TabIndex = 3;
            btn_Back.Text = "Back";
            btn_Back.UseVisualStyleBackColor = true;
            btn_Back.Click += btn_Back_Click;
            // 
            // ManageProducts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_Back);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "ManageProducts";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManageProducts";
            Load += ManageProducts_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btn_BirdManager;
        private Label label1;
        private GroupBox groupBox2;
        private Button btn_NestManager;
        private Label label2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button btn_Back;
    }
}
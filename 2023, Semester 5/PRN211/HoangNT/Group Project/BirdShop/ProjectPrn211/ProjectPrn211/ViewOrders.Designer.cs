namespace BSAPP
{
    partial class ViewOrders
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
            groupBox2 = new GroupBox();
            btn_Purchased = new Button();
            label2 = new Label();
            groupBox1 = new GroupBox();
            btn_Pending = new Button();
            label1 = new Label();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_Back
            // 
            btn_Back.Font = new Font("UD Digi Kyokasho NP-B", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Back.Location = new Point(348, 193);
            btn_Back.Name = "btn_Back";
            btn_Back.Size = new Size(126, 57);
            btn_Back.TabIndex = 6;
            btn_Back.Text = "Back";
            btn_Back.UseVisualStyleBackColor = true;
            btn_Back.Click += btn_Back_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btn_Purchased);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(482, 19);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(296, 413);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            // 
            // btn_Purchased
            // 
            btn_Purchased.Font = new Font("UD Digi Kyokasho NP-B", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Purchased.Location = new Point(91, 174);
            btn_Purchased.Name = "btn_Purchased";
            btn_Purchased.Size = new Size(126, 57);
            btn_Purchased.TabIndex = 2;
            btn_Purchased.Text = "View";
            btn_Purchased.UseVisualStyleBackColor = true;
            btn_Purchased.Click += btn_Purchased_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("UD Digi Kyokasho NP-B", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(58, 32);
            label2.Name = "label2";
            label2.Size = new Size(192, 37);
            label2.TabIndex = 1;
            label2.Text = "Purchased";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_Pending);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(23, 19);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(317, 413);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            // 
            // btn_Pending
            // 
            btn_Pending.Font = new Font("UD Digi Kyokasho NP-B", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Pending.Location = new Point(85, 174);
            btn_Pending.Name = "btn_Pending";
            btn_Pending.Size = new Size(126, 57);
            btn_Pending.TabIndex = 1;
            btn_Pending.Text = "View";
            btn_Pending.UseVisualStyleBackColor = true;
            btn_Pending.Click += btn_Pending_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("UD Digi Kyokasho NP-B", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(74, 32);
            label1.Name = "label1";
            label1.Size = new Size(153, 37);
            label1.TabIndex = 0;
            label1.Text = "Pending";
            // 
            // ViewOrders
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_Back);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "ViewOrders";
            Text = "ViewOrders";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_Back;
        private GroupBox groupBox2;
        private Button btn_Purchased;
        private Label label2;
        private GroupBox groupBox1;
        private Button btn_Pending;
        private Label label1;
    }
}
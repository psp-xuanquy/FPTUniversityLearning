namespace SaleManagementWinApp
{
    partial class frmCheckOut
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
            dgvListCart = new System.Windows.Forms.DataGridView();
            btnCheckout = new System.Windows.Forms.Button();
            dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            btnRemoveCart = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)dgvListCart).BeginInit();
            SuspendLayout();
            // 
            // dgvListCart
            // 
            dgvListCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListCart.Location = new System.Drawing.Point(15, 156);
            dgvListCart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dgvListCart.Name = "dgvListCart";
            dgvListCart.RowHeadersWidth = 51;
            dgvListCart.RowTemplate.Height = 25;
            dgvListCart.Size = new System.Drawing.Size(887, 356);
            dgvListCart.TabIndex = 0;
            dgvListCart.CellDoubleClick += dgvListCart_CellDoubleClick;
            // 
            // btnCheckout
            // 
            btnCheckout.Location = new System.Drawing.Point(483, 547);
            btnCheckout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnCheckout.Name = "btnCheckout";
            btnCheckout.Size = new System.Drawing.Size(113, 51);
            btnCheckout.TabIndex = 1;
            btnCheckout.Text = "Checkout";
            btnCheckout.UseVisualStyleBackColor = true;
            btnCheckout.Click += btnCheckout_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new System.Drawing.Point(725, 111);
            dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new System.Drawing.Size(177, 27);
            dateTimePicker1.TabIndex = 2;
            // 
            // btnRemoveCart
            // 
            btnRemoveCart.Location = new System.Drawing.Point(303, 547);
            btnRemoveCart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnRemoveCart.Name = "btnRemoveCart";
            btnRemoveCart.Size = new System.Drawing.Size(113, 51);
            btnRemoveCart.TabIndex = 3;
            btnRemoveCart.Text = "Remove";
            btnRemoveCart.UseVisualStyleBackColor = true;
            btnRemoveCart.Click += btnRemoveCart_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Cooper Black", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(369, 54);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(192, 39);
            label1.TabIndex = 4;
            label1.Text = "Checkout";
            // 
            // frmCheckOut
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(914, 646);
            Controls.Add(label1);
            Controls.Add(btnRemoveCart);
            Controls.Add(dateTimePicker1);
            Controls.Add(btnCheckout);
            Controls.Add(dgvListCart);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "frmCheckOut";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Checkout";
            ((System.ComponentModel.ISupportInitialize)dgvListCart).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListCart;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnRemoveCart;
        private System.Windows.Forms.Label label1;
    }
}
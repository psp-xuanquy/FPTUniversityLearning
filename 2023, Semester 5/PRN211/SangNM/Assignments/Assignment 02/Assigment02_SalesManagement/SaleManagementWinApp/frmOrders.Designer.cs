namespace SaleManagementWinApp
{
    partial class frmOrders
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
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            dtpStartDate = new System.Windows.Forms.DateTimePicker();
            dtpEndDate = new System.Windows.Forms.DateTimePicker();
            btnSearchOrder = new System.Windows.Forms.Button();
            dgvListOrder = new System.Windows.Forms.DataGridView();
            label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)dgvListOrder).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(46, 117);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(76, 20);
            label1.TabIndex = 0;
            label1.Text = "Start Date";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(353, 117);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(70, 20);
            label2.TabIndex = 1;
            label2.Text = "End Date";
            // 
            // dtpStartDate
            // 
            dtpStartDate.Location = new System.Drawing.Point(46, 141);
            dtpStartDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new System.Drawing.Size(228, 27);
            dtpStartDate.TabIndex = 2;
            // 
            // dtpEndDate
            // 
            dtpEndDate.Location = new System.Drawing.Point(353, 141);
            dtpEndDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new System.Drawing.Size(228, 27);
            dtpEndDate.TabIndex = 3;
            // 
            // btnSearchOrder
            // 
            btnSearchOrder.Location = new System.Drawing.Point(621, 137);
            btnSearchOrder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnSearchOrder.Name = "btnSearchOrder";
            btnSearchOrder.Size = new System.Drawing.Size(115, 31);
            btnSearchOrder.TabIndex = 4;
            btnSearchOrder.Text = "Search";
            btnSearchOrder.UseVisualStyleBackColor = true;
            btnSearchOrder.Click += btnSearchOrder_Click;
            // 
            // dgvListOrder
            // 
            dgvListOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListOrder.Location = new System.Drawing.Point(47, 195);
            dgvListOrder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dgvListOrder.Name = "dgvListOrder";
            dgvListOrder.RowHeadersWidth = 51;
            dgvListOrder.RowTemplate.Height = 25;
            dgvListOrder.Size = new System.Drawing.Size(689, 393);
            dgvListOrder.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(46, 39);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(111, 35);
            label3.TabIndex = 6;
            label3.Text = "Order";
            // 
            // frmOrders
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(771, 633);
            Controls.Add(label3);
            Controls.Add(dgvListOrder);
            Controls.Add(btnSearchOrder);
            Controls.Add(dtpEndDate);
            Controls.Add(dtpStartDate);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "frmOrders";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "frmOrders";
            ((System.ComponentModel.ISupportInitialize)dgvListOrder).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Button btnSearchOrder;
        private System.Windows.Forms.DataGridView dgvListOrder;
        private System.Windows.Forms.Label label3;
    }
}
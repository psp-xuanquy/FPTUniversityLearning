
namespace SalesWinApp.OrderUI
{
    partial class frmOrderDetails
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
            lbOrderID = new System.Windows.Forms.Label();
            txtOderID = new System.Windows.Forms.Label();
            lbOrderDate = new System.Windows.Forms.Label();
            txtOrderDate = new System.Windows.Forms.Label();
            lbOrderTotal = new System.Windows.Forms.Label();
            txtOrderTotal = new System.Windows.Forms.Label();
            dgvOrderDetailList = new System.Windows.Forms.DataGridView();
            btnClose = new System.Windows.Forms.Button();
            lbMember = new System.Windows.Forms.Label();
            txtMemberName = new System.Windows.Forms.Label();
            btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dgvOrderDetailList).BeginInit();
            SuspendLayout();
            // 
            // lbOrderID
            // 
            lbOrderID.AutoSize = true;
            lbOrderID.Location = new System.Drawing.Point(14, 39);
            lbOrderID.Name = "lbOrderID";
            lbOrderID.Size = new System.Drawing.Size(66, 20);
            lbOrderID.TabIndex = 0;
            lbOrderID.Text = "Order ID";
            // 
            // txtOderID
            // 
            txtOderID.AutoSize = true;
            txtOderID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            txtOderID.Location = new System.Drawing.Point(96, 39);
            txtOderID.Name = "txtOderID";
            txtOderID.Size = new System.Drawing.Size(69, 20);
            txtOderID.TabIndex = 1;
            txtOderID.Text = "Order ID";
            // 
            // lbOrderDate
            // 
            lbOrderDate.AutoSize = true;
            lbOrderDate.Location = new System.Drawing.Point(14, 76);
            lbOrderDate.Name = "lbOrderDate";
            lbOrderDate.Size = new System.Drawing.Size(83, 20);
            lbOrderDate.TabIndex = 2;
            lbOrderDate.Text = "Order Date";
            // 
            // txtOrderDate
            // 
            txtOrderDate.AutoSize = true;
            txtOrderDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            txtOrderDate.Location = new System.Drawing.Point(96, 76);
            txtOrderDate.Name = "txtOrderDate";
            txtOrderDate.Size = new System.Drawing.Size(86, 20);
            txtOrderDate.TabIndex = 3;
            txtOrderDate.Text = "Order Date";
            // 
            // lbOrderTotal
            // 
            lbOrderTotal.AutoSize = true;
            lbOrderTotal.Location = new System.Drawing.Point(14, 113);
            lbOrderTotal.Name = "lbOrderTotal";
            lbOrderTotal.Size = new System.Drawing.Size(84, 20);
            lbOrderTotal.TabIndex = 4;
            lbOrderTotal.Text = "Order Total";
            // 
            // txtOrderTotal
            // 
            txtOrderTotal.AutoSize = true;
            txtOrderTotal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            txtOrderTotal.Location = new System.Drawing.Point(96, 113);
            txtOrderTotal.Name = "txtOrderTotal";
            txtOrderTotal.Size = new System.Drawing.Size(88, 20);
            txtOrderTotal.TabIndex = 5;
            txtOrderTotal.Text = "Order Total";
            // 
            // dgvOrderDetailList
            // 
            dgvOrderDetailList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderDetailList.Location = new System.Drawing.Point(14, 161);
            dgvOrderDetailList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dgvOrderDetailList.Name = "dgvOrderDetailList";
            dgvOrderDetailList.ReadOnly = true;
            dgvOrderDetailList.RowHeadersWidth = 51;
            dgvOrderDetailList.RowTemplate.Height = 25;
            dgvOrderDetailList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvOrderDetailList.Size = new System.Drawing.Size(429, 283);
            dgvOrderDetailList.TabIndex = 6;
            dgvOrderDetailList.CellContentClick += dgvOrderDetailList_CellContentClick;
            // 
            // btnClose
            // 
            btnClose.Location = new System.Drawing.Point(177, 464);
            btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(115, 31);
            btnClose.TabIndex = 7;
            btnClose.Text = "&Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // lbMember
            // 
            lbMember.AutoSize = true;
            lbMember.Location = new System.Drawing.Point(222, 39);
            lbMember.Name = "lbMember";
            lbMember.Size = new System.Drawing.Size(65, 20);
            lbMember.TabIndex = 8;
            lbMember.Text = "Member";
            // 
            // txtMemberName
            // 
            txtMemberName.AutoSize = true;
            txtMemberName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            txtMemberName.Location = new System.Drawing.Point(288, 39);
            txtMemberName.Name = "txtMemberName";
            txtMemberName.Size = new System.Drawing.Size(114, 20);
            txtMemberName.TabIndex = 9;
            txtMemberName.Text = "Member Name";
            // 
            // btnDelete
            // 
            btnDelete.Location = new System.Drawing.Point(222, 107);
            btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(117, 32);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "&Delete Order";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Visible = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // frmOrderDetails
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(459, 507);
            Controls.Add(btnDelete);
            Controls.Add(txtMemberName);
            Controls.Add(lbMember);
            Controls.Add(btnClose);
            Controls.Add(dgvOrderDetailList);
            Controls.Add(txtOrderTotal);
            Controls.Add(lbOrderTotal);
            Controls.Add(txtOrderDate);
            Controls.Add(lbOrderDate);
            Controls.Add(txtOderID);
            Controls.Add(lbOrderID);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "frmOrderDetails";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Order Details";
            Load += frmOrderDetails_Load;
            ((System.ComponentModel.ISupportInitialize)dgvOrderDetailList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lbOrderID;
        private System.Windows.Forms.Label txtOderID;
        private System.Windows.Forms.Label lbOrderDate;
        private System.Windows.Forms.Label txtOrderDate;
        private System.Windows.Forms.Label lbOrderTotal;
        private System.Windows.Forms.Label txtOrderTotal;
        private System.Windows.Forms.DataGridView dgvOrderDetailList;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lbMember;
        private System.Windows.Forms.Label txtMemberName;
        private System.Windows.Forms.Button btnDelete;
    }
}
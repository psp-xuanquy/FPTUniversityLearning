
namespace ConvenienceStoreApp
{
    partial class OrderInfo
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
            this.lbOrderDetails = new System.Windows.Forms.Label();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.lbOrderDate = new System.Windows.Forms.Label();
            this.lbStaffID = new System.Windows.Forms.Label();
            this.lbOrderID = new System.Windows.Forms.Label();
            this.dgvDetails = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtOrderDate = new System.Windows.Forms.TextBox();
            this.txtStaffID = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.lbStatus = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtPayment = new System.Windows.Forms.TextBox();
            this.lbPayment = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // lbOrderDetails
            // 
            this.lbOrderDetails.AutoSize = true;
            this.lbOrderDetails.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbOrderDetails.Location = new System.Drawing.Point(584, 17);
            this.lbOrderDetails.Name = "lbOrderDetails";
            this.lbOrderDetails.Size = new System.Drawing.Size(98, 21);
            this.lbOrderDetails.TabIndex = 87;
            this.lbOrderDetails.Text = "Order detail";
            // 
            // txtOrderID
            // 
            this.txtOrderID.Enabled = false;
            this.txtOrderID.Location = new System.Drawing.Point(135, 21);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.Size = new System.Drawing.Size(207, 23);
            this.txtOrderID.TabIndex = 77;
            // 
            // lbOrderDate
            // 
            this.lbOrderDate.AutoSize = true;
            this.lbOrderDate.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbOrderDate.Location = new System.Drawing.Point(19, 156);
            this.lbOrderDate.Name = "lbOrderDate";
            this.lbOrderDate.Size = new System.Drawing.Size(91, 21);
            this.lbOrderDate.TabIndex = 74;
            this.lbOrderDate.Text = "Order Date";
            // 
            // lbStaffID
            // 
            this.lbStaffID.AutoSize = true;
            this.lbStaffID.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbStaffID.Location = new System.Drawing.Point(19, 109);
            this.lbStaffID.Name = "lbStaffID";
            this.lbStaffID.Size = new System.Drawing.Size(65, 21);
            this.lbStaffID.TabIndex = 73;
            this.lbStaffID.Text = "Staff ID";
            // 
            // lbOrderID
            // 
            this.lbOrderID.AutoSize = true;
            this.lbOrderID.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbOrderID.Location = new System.Drawing.Point(19, 19);
            this.lbOrderID.Name = "lbOrderID";
            this.lbOrderID.Size = new System.Drawing.Size(73, 21);
            this.lbOrderID.TabIndex = 72;
            this.lbOrderID.Text = "Order ID";
            // 
            // dgvDetails
            // 
            this.dgvDetails.AllowUserToAddRows = false;
            this.dgvDetails.AllowUserToDeleteRows = false;
            this.dgvDetails.AllowUserToResizeColumns = false;
            this.dgvDetails.AllowUserToResizeRows = false;
            this.dgvDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetails.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetails.Location = new System.Drawing.Point(385, 54);
            this.dgvDetails.Name = "dgvDetails";
            this.dgvDetails.ReadOnly = true;
            this.dgvDetails.RowTemplate.Height = 25;
            this.dgvDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetails.Size = new System.Drawing.Size(503, 224);
            this.dgvDetails.TabIndex = 90;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(397, 311);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(102, 33);
            this.btnClose.TabIndex = 91;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtOrderDate
            // 
            this.txtOrderDate.Enabled = false;
            this.txtOrderDate.Location = new System.Drawing.Point(135, 160);
            this.txtOrderDate.Name = "txtOrderDate";
            this.txtOrderDate.Size = new System.Drawing.Size(207, 23);
            this.txtOrderDate.TabIndex = 92;
            // 
            // txtStaffID
            // 
            this.txtStaffID.Enabled = false;
            this.txtStaffID.Location = new System.Drawing.Point(135, 113);
            this.txtStaffID.Name = "txtStaffID";
            this.txtStaffID.Size = new System.Drawing.Size(207, 23);
            this.txtStaffID.TabIndex = 93;
            // 
            // txtStatus
            // 
            this.txtStatus.Enabled = false;
            this.txtStatus.Location = new System.Drawing.Point(135, 67);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(207, 23);
            this.txtStatus.TabIndex = 95;
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbStatus.Location = new System.Drawing.Point(19, 63);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(55, 21);
            this.lbStatus.TabIndex = 94;
            this.lbStatus.Text = "Status";
            // 
            // txtPrice
            // 
            this.txtPrice.Enabled = false;
            this.txtPrice.Location = new System.Drawing.Point(135, 208);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(207, 23);
            this.txtPrice.TabIndex = 99;
            // 
            // txtPayment
            // 
            this.txtPayment.Enabled = false;
            this.txtPayment.Location = new System.Drawing.Point(135, 255);
            this.txtPayment.Name = "txtPayment";
            this.txtPayment.Size = new System.Drawing.Size(207, 23);
            this.txtPayment.TabIndex = 98;
            // 
            // lbPayment
            // 
            this.lbPayment.AutoSize = true;
            this.lbPayment.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbPayment.Location = new System.Drawing.Point(19, 251);
            this.lbPayment.Name = "lbPayment";
            this.lbPayment.Size = new System.Drawing.Size(73, 21);
            this.lbPayment.TabIndex = 97;
            this.lbPayment.Text = "Payment";
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbPrice.Location = new System.Drawing.Point(19, 204);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(46, 21);
            this.lbPrice.TabIndex = 96;
            this.lbPrice.Text = "Price";
            // 
            // OrderInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 363);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtPayment);
            this.Controls.Add(this.lbPayment);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.txtStaffID);
            this.Controls.Add(this.txtOrderDate);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvDetails);
            this.Controls.Add(this.lbOrderDetails);
            this.Controls.Add(this.txtOrderID);
            this.Controls.Add(this.lbOrderDate);
            this.Controls.Add(this.lbStaffID);
            this.Controls.Add(this.lbOrderID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OrderInfo";
            this.Text = "OrderInfo";
            this.Load += new System.EventHandler(this.OrderInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbOrderDetails;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.Label lbOrderDate;
        private System.Windows.Forms.Label lbStaffID;
        private System.Windows.Forms.Label lbOrderID;
        private System.Windows.Forms.DataGridView dgvDetails;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtOrderDate;
        private System.Windows.Forms.TextBox txtStaffID;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtPayment;
        private System.Windows.Forms.Label lbPayment;
        private System.Windows.Forms.Label lbPrice;
    }
}
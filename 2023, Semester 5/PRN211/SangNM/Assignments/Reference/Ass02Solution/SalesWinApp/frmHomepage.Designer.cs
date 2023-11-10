namespace SalesWinApp
{
    partial class frmHomepage
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
            btMember = new System.Windows.Forms.Button();
            btProduct = new System.Windows.Forms.Button();
            btOrder = new System.Windows.Forms.Button();
            btLogOut = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // btMember
            // 
            btMember.Location = new System.Drawing.Point(144, 107);
            btMember.Margin = new System.Windows.Forms.Padding(4);
            btMember.Name = "btMember";
            btMember.Size = new System.Drawing.Size(431, 108);
            btMember.TabIndex = 0;
            btMember.Text = "Member Management";
            btMember.UseVisualStyleBackColor = true;
            btMember.Click += btMember_Click;
            // 
            // btProduct
            // 
            btProduct.Location = new System.Drawing.Point(144, 223);
            btProduct.Margin = new System.Windows.Forms.Padding(4);
            btProduct.Name = "btProduct";
            btProduct.Size = new System.Drawing.Size(431, 108);
            btProduct.TabIndex = 1;
            btProduct.Text = "Product Management";
            btProduct.UseVisualStyleBackColor = true;
            btProduct.Click += btProduct_Click;
            // 
            // btOrder
            // 
            btOrder.Location = new System.Drawing.Point(144, 339);
            btOrder.Margin = new System.Windows.Forms.Padding(4);
            btOrder.Name = "btOrder";
            btOrder.Size = new System.Drawing.Size(431, 108);
            btOrder.TabIndex = 2;
            btOrder.Text = "Order Management";
            btOrder.UseVisualStyleBackColor = true;
            btOrder.Click += btOrder_Click;
            // 
            // btLogOut
            // 
            btLogOut.Location = new System.Drawing.Point(12, 12);
            btLogOut.Name = "btLogOut";
            btLogOut.Size = new System.Drawing.Size(106, 47);
            btLogOut.TabIndex = 3;
            btLogOut.Text = "Log Out";
            btLogOut.UseVisualStyleBackColor = true;
            btLogOut.Click += btLogOut_Click;
            // 
            // frmHomepage
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(719, 514);
            Controls.Add(btLogOut);
            Controls.Add(btOrder);
            Controls.Add(btProduct);
            Controls.Add(btMember);
            Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Margin = new System.Windows.Forms.Padding(4);
            Name = "frmHomepage";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "frmHomepage";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btMember;
        private System.Windows.Forms.Button btProduct;
        private System.Windows.Forms.Button btOrder;
        private System.Windows.Forms.Button btLogOut;
    }
}
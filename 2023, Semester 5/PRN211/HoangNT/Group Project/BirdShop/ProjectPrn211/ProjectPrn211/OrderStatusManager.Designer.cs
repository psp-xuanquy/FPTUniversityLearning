namespace BSAPP
{
    partial class OrderStatusManager
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            dtg_Pending = new DataGridView();
            dtg_CancelRequest = new DataGridView();
            dtg_Purchased = new DataGridView();
            btn_Close = new Button();
            btn_CancelPending = new Button();
            btn_ConfirmPending = new Button();
            btn_DenyCancellation = new Button();
            ((System.ComponentModel.ISupportInitialize)dtg_Pending).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtg_CancelRequest).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtg_Purchased).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(55, 76);
            label1.Name = "label1";
            label1.Size = new Size(85, 25);
            label1.TabIndex = 0;
            label1.Text = "Pending:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(55, 272);
            label2.Name = "label2";
            label2.Size = new Size(192, 25);
            label2.TabIndex = 1;
            label2.Text = "Request Cancellation:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(55, 467);
            label3.Name = "label3";
            label3.Size = new Size(100, 25);
            label3.TabIndex = 2;
            label3.Text = "Purchased";
            // 
            // dtg_Pending
            // 
            dtg_Pending.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtg_Pending.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_Pending.Location = new Point(254, 18);
            dtg_Pending.Name = "dtg_Pending";
            dtg_Pending.RowTemplate.Height = 25;
            dtg_Pending.Size = new Size(680, 150);
            dtg_Pending.TabIndex = 3;
            dtg_Pending.CellContentClick += dtg_Pending_CellContentClick;
            // 
            // dtg_CancelRequest
            // 
            dtg_CancelRequest.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtg_CancelRequest.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_CancelRequest.Location = new Point(254, 215);
            dtg_CancelRequest.Name = "dtg_CancelRequest";
            dtg_CancelRequest.RowTemplate.Height = 25;
            dtg_CancelRequest.Size = new Size(680, 150);
            dtg_CancelRequest.TabIndex = 4;
            // 
            // dtg_Purchased
            // 
            dtg_Purchased.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtg_Purchased.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_Purchased.Location = new Point(254, 406);
            dtg_Purchased.Name = "dtg_Purchased";
            dtg_Purchased.RowTemplate.Height = 25;
            dtg_Purchased.Size = new Size(680, 150);
            dtg_Purchased.TabIndex = 5;
            // 
            // btn_Close
            // 
            btn_Close.Location = new Point(968, 511);
            btn_Close.Name = "btn_Close";
            btn_Close.Size = new Size(113, 45);
            btn_Close.TabIndex = 6;
            btn_Close.Text = "Close";
            btn_Close.UseVisualStyleBackColor = true;
            btn_Close.Click += btn_Close_Click;
            // 
            // btn_CancelPending
            // 
            btn_CancelPending.Location = new Point(968, 123);
            btn_CancelPending.Name = "btn_CancelPending";
            btn_CancelPending.Size = new Size(113, 45);
            btn_CancelPending.TabIndex = 7;
            btn_CancelPending.Text = "Cancel";
            btn_CancelPending.UseVisualStyleBackColor = true;
            btn_CancelPending.Click += btn_CancelPending_Click;
            // 
            // btn_ConfirmPending
            // 
            btn_ConfirmPending.Location = new Point(968, 18);
            btn_ConfirmPending.Name = "btn_ConfirmPending";
            btn_ConfirmPending.Size = new Size(113, 45);
            btn_ConfirmPending.TabIndex = 8;
            btn_ConfirmPending.Text = "Confirm";
            btn_ConfirmPending.UseVisualStyleBackColor = true;
            btn_ConfirmPending.Click += btn_ConfirmPending_Click;
            // 
            // btn_DenyCancellation
            // 
            btn_DenyCancellation.Location = new Point(968, 202);
            btn_DenyCancellation.Name = "btn_DenyCancellation";
            btn_DenyCancellation.Size = new Size(113, 45);
            btn_DenyCancellation.TabIndex = 9;
            btn_DenyCancellation.Text = "Deny";
            btn_DenyCancellation.UseVisualStyleBackColor = true;
            btn_DenyCancellation.Click += btn_DenyCancellation_Click;
            // 
            // OrderStatusManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1093, 608);
            Controls.Add(btn_DenyCancellation);
            Controls.Add(btn_ConfirmPending);
            Controls.Add(btn_CancelPending);
            Controls.Add(btn_Close);
            Controls.Add(dtg_Purchased);
            Controls.Add(dtg_CancelRequest);
            Controls.Add(dtg_Pending);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "OrderStatusManager";
            Text = "OrderStatusManager";
            Load += OrderStatusManager_Load;
            ((System.ComponentModel.ISupportInitialize)dtg_Pending).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtg_CancelRequest).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtg_Purchased).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private DataGridView dtg_Pending;
        private DataGridView dtg_CancelRequest;
        private DataGridView dtg_Purchased;
        private Button btn_ConfirmCancellation;
        private Button btn_CancelPending;
        private Button btn_ConfirmPending;
        private Button btn_DenyCancellation;
        private Button btn_Close;
    }
}
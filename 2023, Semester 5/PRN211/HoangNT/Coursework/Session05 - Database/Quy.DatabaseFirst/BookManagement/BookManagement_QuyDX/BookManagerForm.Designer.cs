namespace BookManagement_QuyDX
{
    partial class BookManagerForm
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
            lblMainName = new Label();
            dgvBooks = new DataGridView();
            btnNew = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            btnExit = new Button();
            lblKeyword = new Label();
            grbSearch = new GroupBox();
            btnSearch = new Button();
            txtKeyword = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).BeginInit();
            grbSearch.SuspendLayout();
            SuspendLayout();
            // 
            // lblMainName
            // 
            lblMainName.AutoSize = true;
            lblMainName.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Millimeter);
            lblMainName.Location = new Point(142, -3);
            lblMainName.Name = "lblMainName";
            lblMainName.Size = new Size(708, 127);
            lblMainName.TabIndex = 0;
            lblMainName.Text = "Book Manager";
            // 
            // dgvBooks
            // 
            dgvBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBooks.Location = new Point(51, 246);
            dgvBooks.Name = "dgvBooks";
            dgvBooks.RowHeadersWidth = 51;
            dgvBooks.RowTemplate.Height = 29;
            dgvBooks.Size = new Size(875, 357);
            dgvBooks.TabIndex = 5;
            // 
            // btnNew
            // 
            btnNew.ForeColor = SystemColors.ControlText;
            btnNew.Location = new Point(51, 634);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(129, 29);
            btnNew.TabIndex = 1;
            btnNew.Text = "New Book";
            btnNew.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.ForeColor = SystemColors.ControlText;
            btnDelete.Location = new Point(293, 634);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(117, 29);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.ForeColor = SystemColors.ControlText;
            btnEdit.Location = new Point(557, 634);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(118, 29);
            btnEdit.TabIndex = 3;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.ForeColor = SystemColors.ControlText;
            btnExit.Location = new Point(803, 634);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(123, 29);
            btnExit.TabIndex = 4;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // lblKeyword
            // 
            lblKeyword.AutoSize = true;
            lblKeyword.Location = new Point(78, 39);
            lblKeyword.Name = "lblKeyword";
            lblKeyword.Size = new Size(67, 20);
            lblKeyword.TabIndex = 0;
            lblKeyword.Text = "Keyword";
            // 
            // grbSearch
            // 
            grbSearch.Controls.Add(btnSearch);
            grbSearch.Controls.Add(txtKeyword);
            grbSearch.Controls.Add(lblKeyword);
            grbSearch.Location = new Point(130, 152);
            grbSearch.Name = "grbSearch";
            grbSearch.Size = new Size(720, 88);
            grbSearch.TabIndex = 0;
            grbSearch.TabStop = false;
            grbSearch.Text = "  Search  ";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(531, 34);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtKeyword
            // 
            txtKeyword.Location = new Point(151, 36);
            txtKeyword.Name = "txtKeyword";
            txtKeyword.Size = new Size(359, 27);
            txtKeyword.TabIndex = 1;
            // 
            // BookManagerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(972, 703);
            Controls.Add(grbSearch);
            Controls.Add(btnExit);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(btnNew);
            Controls.Add(dgvBooks);
            Controls.Add(lblMainName);
            Name = "BookManagerForm";
            Text = "BookManagerForm";
            Load += BookManagerForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBooks).EndInit();
            grbSearch.ResumeLayout(false);
            grbSearch.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMainName;
        private DataGridView dgvBooks;
        private Button btnNew;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnExit;
        private Label lblKeyword;
        private GroupBox grbSearch;
        private TextBox txtKeyword;
        private Button btnSearch;
    }
}
namespace Giaolang.FAP.StudentMgt
{
    partial class StudentListForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSayHello = new Button();
            btnExit = new Button();
            dlgOpenFile = new OpenFileDialog();
            btnImage = new Button();
            picAvatar = new PictureBox();
            lblFileName = new Label();
            pnlImage = new Panel();
            dgvStudentList = new DataGridView();
            btnLoadData = new Button();
            ((System.ComponentModel.ISupportInitialize)picAvatar).BeginInit();
            pnlImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStudentList).BeginInit();
            SuspendLayout();
            // 
            // btnSayHello
            // 
            btnSayHello.Location = new Point(36, 30);
            btnSayHello.Name = "btnSayHello";
            btnSayHello.Size = new Size(113, 33);
            btnSayHello.TabIndex = 0;
            btnSayHello.Text = "Say Hello";
            btnSayHello.UseVisualStyleBackColor = true;
            btnSayHello.Click += SayHello;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(179, 30);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(113, 33);
            btnExit.TabIndex = 1;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += SayGoodbye;
            // 
            // dlgOpenFile
            // 
            dlgOpenFile.Filter = "JPEG files |*.jpg;*.jpeg|PNG files|*.png";
            // 
            // btnImage
            // 
            btnImage.Location = new Point(36, 101);
            btnImage.Name = "btnImage";
            btnImage.Size = new Size(113, 33);
            btnImage.TabIndex = 2;
            btnImage.Text = "Choose image";
            btnImage.UseVisualStyleBackColor = true;
            btnImage.Click += OpenImage;
            // 
            // picAvatar
            // 
            picAvatar.BorderStyle = BorderStyle.Fixed3D;
            picAvatar.Location = new Point(15, 13);
            picAvatar.Name = "picAvatar";
            picAvatar.Size = new Size(523, 403);
            picAvatar.SizeMode = PictureBoxSizeMode.AutoSize;
            picAvatar.TabIndex = 3;
            picAvatar.TabStop = false;
            // 
            // lblFileName
            // 
            lblFileName.AutoSize = true;
            lblFileName.Location = new Point(166, 107);
            lblFileName.Name = "lblFileName";
            lblFileName.Size = new Size(58, 20);
            lblFileName.TabIndex = 4;
            lblFileName.Text = "Image: ";
            // 
            // pnlImage
            // 
            pnlImage.AutoScroll = true;
            pnlImage.Controls.Add(picAvatar);
            pnlImage.Location = new Point(36, 139);
            pnlImage.Name = "pnlImage";
            pnlImage.Size = new Size(541, 430);
            pnlImage.TabIndex = 5;
            // 
            // dgvStudentList
            // 
            dgvStudentList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudentList.Location = new Point(619, 152);
            dgvStudentList.Name = "dgvStudentList";
            dgvStudentList.RowHeadersWidth = 51;
            dgvStudentList.RowTemplate.Height = 29;
            dgvStudentList.Size = new Size(474, 366);
            dgvStudentList.TabIndex = 6;
            // 
            // btnLoadData
            // 
            btnLoadData.Location = new Point(619, 30);
            btnLoadData.Name = "btnLoadData";
            btnLoadData.Size = new Size(113, 33);
            btnLoadData.TabIndex = 7;
            btnLoadData.Text = "Load data";
            btnLoadData.UseVisualStyleBackColor = true;
            btnLoadData.Click += LoadData;
            // 
            // StudentListForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1120, 655);
            Controls.Add(btnLoadData);
            Controls.Add(dgvStudentList);
            Controls.Add(pnlImage);
            Controls.Add(lblFileName);
            Controls.Add(btnImage);
            Controls.Add(btnExit);
            Controls.Add(btnSayHello);
            Name = "StudentListForm";
            Text = "Student List";
            Load += StudentListForm_Load;
            ((System.ComponentModel.ISupportInitialize)picAvatar).EndInit();
            pnlImage.ResumeLayout(false);
            pnlImage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStudentList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSayHello;
        private Button btnExit;
        private OpenFileDialog dlgOpenFile;
        private Button btnImage;
        private PictureBox picAvatar;
        private Label lblFileName;
        private Panel pnlImage;
        private DataGridView dgvStudentList;
        private Button btnLoadData;
    }
}
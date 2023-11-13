
namespace ConvenienceStoreApp
{
    partial class frmHenry
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
            this.ucStaffManagement1 = new ConvenienceStoreApp.ucStaffManagement();
            this.SuspendLayout();
            // 
            // ucStaffManagement1
            // 
            this.ucStaffManagement1.Location = new System.Drawing.Point(0, -4);
            this.ucStaffManagement1.Name = "ucStaffManagement1";
            this.ucStaffManagement1.Size = new System.Drawing.Size(1550, 924);
            this.ucStaffManagement1.TabIndex = 0;
            // 
            // frmHenry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 747);
            this.Controls.Add(this.ucStaffManagement1);
            this.Name = "frmHenry";
            this.Text = "frmHenry";
            this.ResumeLayout(false);

        }

        #endregion

        private ucStaffManagement ucStaffManagement1;
    }
}
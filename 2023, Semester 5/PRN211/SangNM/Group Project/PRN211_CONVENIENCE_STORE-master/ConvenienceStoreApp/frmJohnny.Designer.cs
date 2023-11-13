
namespace ConvenienceStoreApp
{
    partial class frmJohnny
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
            this.ucOrder1 = new ConvenienceStoreApp.ucOrder();
            this.SuspendLayout();
            // 
            // ucOrder1
            // 
            this.ucOrder1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ucOrder1.Location = new System.Drawing.Point(3, 13);
            this.ucOrder1.loggedStaff = null;
            this.ucOrder1.Name = "ucOrder1";
            this.ucOrder1.Size = new System.Drawing.Size(1085, 554);
            this.ucOrder1.TabIndex = 0;
            // 
            // frmJohnny
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 600);
            this.Controls.Add(this.ucOrder1);
            this.Name = "frmJohnny";
            this.Text = "frmJohnny";
            this.Load += new System.EventHandler(this.frmJohnny_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ucOrder ucOrder1;
    }
}
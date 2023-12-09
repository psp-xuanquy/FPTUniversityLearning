
namespace ConvenienceStoreApp
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label_currentUser = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label_permission = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label_storeName = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.hlightBtn1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.hlightBtn5 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.hlightBtn3 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.hlightBtn2 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.orderManagement1 = new ConvenienceStoreApp.OrderManagement();
            this.ucOrder1 = new ConvenienceStoreApp.ucOrder();
            this.ucSelfOrdersView1 = new ConvenienceStoreApp.ucSelfOrdersView();
            this.ucStaffManagement1 = new ConvenienceStoreApp.ucStaffManagement();
            this.ucProductManagement1 = new ConvenienceStoreApp.ucProductManagement();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.hlightBtn1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.hlightBtn5.SuspendLayout();
            this.hlightBtn3.SuspendLayout();
            this.hlightBtn2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnClose);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(215, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1085, 57);
            this.panel4.TabIndex = 2;
            this.panel4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.Location = new System.Drawing.Point(1040, 11);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(33, 33);
            this.btnClose.TabIndex = 4;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel5.Controls.Add(this.label_currentUser);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.label_permission);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(215, 57);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1085, 109);
            this.panel5.TabIndex = 2;
            // 
            // label_currentUser
            // 
            this.label_currentUser.AutoSize = true;
            this.label_currentUser.Font = new System.Drawing.Font("Century Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label_currentUser.ForeColor = System.Drawing.Color.White;
            this.label_currentUser.Location = new System.Drawing.Point(184, 55);
            this.label_currentUser.Name = "label_currentUser";
            this.label_currentUser.Size = new System.Drawing.Size(119, 30);
            this.label_currentUser.TabIndex = 8;
            this.label_currentUser.Text = "Fullname";
            this.label_currentUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(17, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 30);
            this.label5.TabIndex = 7;
            this.label5.Text = "Current User:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_permission
            // 
            this.label_permission.AutoSize = true;
            this.label_permission.Font = new System.Drawing.Font("Century Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label_permission.ForeColor = System.Drawing.Color.Red;
            this.label_permission.Location = new System.Drawing.Point(184, 19);
            this.label_permission.Name = "label_permission";
            this.label_permission.Size = new System.Drawing.Size(63, 30);
            this.label_permission.TabIndex = 6;
            this.label_permission.Text = "Role";
            this.label_permission.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(36, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 30);
            this.label3.TabIndex = 5;
            this.label3.Text = "Permission:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label_storeName);
            this.panel3.Controls.Add(this.logo);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(215, 166);
            this.panel3.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(20, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Convenience Store";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_storeName
            // 
            this.label_storeName.AutoSize = true;
            this.label_storeName.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label_storeName.ForeColor = System.Drawing.Color.White;
            this.label_storeName.Location = new System.Drawing.Point(52, 112);
            this.label_storeName.Name = "label_storeName";
            this.label_storeName.Size = new System.Drawing.Size(94, 21);
            this.label_storeName.TabIndex = 3;
            this.label_storeName.Text = "Akihabara";
            this.label_storeName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // logo
            // 
            this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(52, 12);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(93, 97);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 3;
            this.logo.TabStop = false;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(12, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 59);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            this.button1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button1_MouseMove);
            // 
            // hlightBtn1
            // 
            this.hlightBtn1.BackColor = System.Drawing.Color.White;
            this.hlightBtn1.Controls.Add(this.panel6);
            this.hlightBtn1.Location = new System.Drawing.Point(0, 183);
            this.hlightBtn1.Name = "hlightBtn1";
            this.hlightBtn1.Size = new System.Drawing.Size(14, 59);
            this.hlightBtn1.TabIndex = 3;
            this.hlightBtn1.Visible = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Location = new System.Drawing.Point(-97, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(21, 59);
            this.panel6.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.hlightBtn5);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.hlightBtn3);
            this.panel1.Controls.Add(this.hlightBtn2);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.hlightBtn1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(215, 720);
            this.panel1.TabIndex = 0;
            // 
            // hlightBtn5
            // 
            this.hlightBtn5.BackColor = System.Drawing.Color.White;
            this.hlightBtn5.Controls.Add(this.panel8);
            this.hlightBtn5.Location = new System.Drawing.Point(0, 649);
            this.hlightBtn5.Name = "hlightBtn5";
            this.hlightBtn5.Size = new System.Drawing.Size(14, 59);
            this.hlightBtn5.TabIndex = 8;
            this.hlightBtn5.Visible = false;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.White;
            this.panel8.Location = new System.Drawing.Point(-97, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(21, 59);
            this.panel8.TabIndex = 4;
            // 
            // btnLogout
            // 
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(15, 649);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(200, 59);
            this.btnLogout.TabIndex = 8;
            this.btnLogout.Text = "Log out";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            this.btnLogout.MouseLeave += new System.EventHandler(this.button5_MouseLeave);
            this.btnLogout.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button5_MouseMove);
            // 
            // hlightBtn3
            // 
            this.hlightBtn3.BackColor = System.Drawing.Color.White;
            this.hlightBtn3.Controls.Add(this.panel9);
            this.hlightBtn3.Location = new System.Drawing.Point(0, 313);
            this.hlightBtn3.Name = "hlightBtn3";
            this.hlightBtn3.Size = new System.Drawing.Size(14, 59);
            this.hlightBtn3.TabIndex = 6;
            this.hlightBtn3.Visible = false;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.White;
            this.panel9.Location = new System.Drawing.Point(-97, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(21, 59);
            this.panel9.TabIndex = 4;
            // 
            // hlightBtn2
            // 
            this.hlightBtn2.BackColor = System.Drawing.Color.White;
            this.hlightBtn2.Controls.Add(this.panel7);
            this.hlightBtn2.Location = new System.Drawing.Point(0, 248);
            this.hlightBtn2.Name = "hlightBtn2";
            this.hlightBtn2.Size = new System.Drawing.Size(14, 59);
            this.hlightBtn2.TabIndex = 5;
            this.hlightBtn2.Visible = false;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Location = new System.Drawing.Point(-97, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(21, 59);
            this.panel7.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(12, 313);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 59);
            this.button3.TabIndex = 5;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.MouseLeave += new System.EventHandler(this.button3_MouseLeave);
            this.button3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button3_MouseMove);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(12, 248);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 59);
            this.button2.TabIndex = 4;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.MouseLeave += new System.EventHandler(this.button2_MouseLeave);
            this.button2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button2_MouseMove);
            // 
            // orderManagement1
            // 
            this.orderManagement1.Location = new System.Drawing.Point(215, 166);
            this.orderManagement1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.orderManagement1.Name = "orderManagement1";
            this.orderManagement1.Size = new System.Drawing.Size(1085, 554);
            this.orderManagement1.TabIndex = 9;
            // 
            // ucOrder1
            // 
            this.ucOrder1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ucOrder1.Location = new System.Drawing.Point(215, 166);
            this.ucOrder1.loggedStaff = null;
            this.ucOrder1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ucOrder1.Name = "ucOrder1";
            this.ucOrder1.Size = new System.Drawing.Size(1085, 554);
            this.ucOrder1.TabIndex = 9;
            // 
            // ucSelfOrdersView1
            // 
            this.ucSelfOrdersView1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ucSelfOrdersView1.Location = new System.Drawing.Point(215, 166);
            this.ucSelfOrdersView1.loggedStaff = null;
            this.ucSelfOrdersView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ucSelfOrdersView1.Name = "ucSelfOrdersView1";
            this.ucSelfOrdersView1.Size = new System.Drawing.Size(1085, 554);
            this.ucSelfOrdersView1.TabIndex = 11;
            // 
            // ucStaffManagement1
            // 
            this.ucStaffManagement1.Location = new System.Drawing.Point(215, 166);
            this.ucStaffManagement1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ucStaffManagement1.Name = "ucStaffManagement1";
            this.ucStaffManagement1.Size = new System.Drawing.Size(1356, 693);
            this.ucStaffManagement1.TabIndex = 12;
            // 
            // ucProductManagement1
            // 
            this.ucProductManagement1.Location = new System.Drawing.Point(215, 166);
            this.ucProductManagement1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ucProductManagement1.Name = "ucProductManagement1";
            this.ucProductManagement1.Size = new System.Drawing.Size(1356, 693);
            this.ucProductManagement1.TabIndex = 13;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(1300, 720);
            this.Controls.Add(this.ucProductManagement1);
            this.Controls.Add(this.ucStaffManagement1);
            this.Controls.Add(this.ucSelfOrdersView1);
            this.Controls.Add(this.ucOrder1);
            this.Controls.Add(this.orderManagement1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Convenience Store Management";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.hlightBtn1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.hlightBtn5.ResumeLayout(false);
            this.hlightBtn3.ResumeLayout(false);
            this.hlightBtn2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_storeName;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel hlightBtn1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel hlightBtn2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel hlightBtn4;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel hlightBtn3;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label label_permission;
        private System.Windows.Forms.Label label_currentUser;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel hlightBtn5;
        private System.Windows.Forms.Panel panel8;
        private OrderManagement orderManagement1;
        private ucOrder ucOrder1;
        private ucSelfOrdersView ucSelfOrdersView1;
        private ucStaffManagement ucStaffManagement1;
        private ucProductManagement ucProductManagement1;
    }
}


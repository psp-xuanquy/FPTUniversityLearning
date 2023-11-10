
namespace MyStoreWinApp
{
    partial class frmMemberDetails
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
            txtCountry = new System.Windows.Forms.TextBox();
            lbCountry = new System.Windows.Forms.Label();
            txtCity = new System.Windows.Forms.TextBox();
            lbCity = new System.Windows.Forms.Label();
            txtPassword = new System.Windows.Forms.TextBox();
            lbPassword = new System.Windows.Forms.Label();
            txtEmail = new System.Windows.Forms.TextBox();
            lbEmail = new System.Windows.Forms.Label();
            txtMemberName = new System.Windows.Forms.TextBox();
            lbMemberName = new System.Windows.Forms.Label();
            txtMemberID = new System.Windows.Forms.TextBox();
            lbMemberID = new System.Windows.Forms.Label();
            btnAdd = new System.Windows.Forms.Button();
            btnUpdate = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // txtCountry
            // 
            txtCountry.Location = new System.Drawing.Point(142, 316);
            txtCountry.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new System.Drawing.Size(210, 27);
            txtCountry.TabIndex = 23;
            // 
            // lbCountry
            // 
            lbCountry.AutoSize = true;
            lbCountry.Location = new System.Drawing.Point(23, 319);
            lbCountry.Name = "lbCountry";
            lbCountry.Size = new System.Drawing.Size(60, 20);
            lbCountry.TabIndex = 22;
            lbCountry.Text = "Country";
            // 
            // txtCity
            // 
            txtCity.Location = new System.Drawing.Point(142, 250);
            txtCity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtCity.Name = "txtCity";
            txtCity.Size = new System.Drawing.Size(210, 27);
            txtCity.TabIndex = 21;
            // 
            // lbCity
            // 
            lbCity.AutoSize = true;
            lbCity.Location = new System.Drawing.Point(23, 253);
            lbCity.Name = "lbCity";
            lbCity.Size = new System.Drawing.Size(34, 20);
            lbCity.TabIndex = 20;
            lbCity.Text = "City";
            // 
            // txtPassword
            // 
            txtPassword.Location = new System.Drawing.Point(142, 194);
            txtPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new System.Drawing.Size(210, 27);
            txtPassword.TabIndex = 18;
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new System.Drawing.Point(23, 197);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new System.Drawing.Size(70, 20);
            lbPassword.TabIndex = 18;
            lbPassword.Text = "Password";
            // 
            // txtEmail
            // 
            txtEmail.Location = new System.Drawing.Point(142, 135);
            txtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new System.Drawing.Size(210, 27);
            txtEmail.TabIndex = 17;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new System.Drawing.Point(23, 138);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new System.Drawing.Size(46, 20);
            lbEmail.TabIndex = 16;
            lbEmail.Text = "Email";
            // 
            // txtMemberName
            // 
            txtMemberName.Location = new System.Drawing.Point(142, 82);
            txtMemberName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtMemberName.Name = "txtMemberName";
            txtMemberName.Size = new System.Drawing.Size(210, 27);
            txtMemberName.TabIndex = 15;
            // 
            // lbMemberName
            // 
            lbMemberName.AutoSize = true;
            lbMemberName.Location = new System.Drawing.Point(23, 85);
            lbMemberName.Name = "lbMemberName";
            lbMemberName.Size = new System.Drawing.Size(109, 20);
            lbMemberName.TabIndex = 14;
            lbMemberName.Text = "Member Name";
            // 
            // txtMemberID
            // 
            txtMemberID.Location = new System.Drawing.Point(142, 20);
            txtMemberID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtMemberID.Name = "txtMemberID";
            txtMemberID.Size = new System.Drawing.Size(210, 27);
            txtMemberID.TabIndex = 13;
            // 
            // lbMemberID
            // 
            lbMemberID.AutoSize = true;
            lbMemberID.Location = new System.Drawing.Point(23, 24);
            lbMemberID.Name = "lbMemberID";
            lbMemberID.Size = new System.Drawing.Size(84, 20);
            lbMemberID.TabIndex = 12;
            lbMemberID.Text = "Member ID";
            // 
            // btnAdd
            // 
            btnAdd.DialogResult = System.Windows.Forms.DialogResult.OK;
            btnAdd.Location = new System.Drawing.Point(37, 425);
            btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(107, 31);
            btnAdd.TabIndex = 24;
            btnAdd.Text = "&Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.DialogResult = System.Windows.Forms.DialogResult.OK;
            btnUpdate.Location = new System.Drawing.Point(37, 425);
            btnUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new System.Drawing.Size(107, 31);
            btnUpdate.TabIndex = 25;
            btnUpdate.Text = "&Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnCancel.Location = new System.Drawing.Point(222, 425);
            btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(107, 31);
            btnCancel.TabIndex = 26;
            btnCancel.Text = "&Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // frmMemberDetails
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(392, 473);
            Controls.Add(btnCancel);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(txtCountry);
            Controls.Add(lbCountry);
            Controls.Add(txtCity);
            Controls.Add(lbCity);
            Controls.Add(txtPassword);
            Controls.Add(lbPassword);
            Controls.Add(txtEmail);
            Controls.Add(lbEmail);
            Controls.Add(txtMemberName);
            Controls.Add(lbMemberName);
            Controls.Add(txtMemberID);
            Controls.Add(lbMemberID);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "frmMemberDetails";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "frmMemberDetails";
            Load += frmMemberDetails_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.Label lbCountry;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lbCity;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox txtMemberName;
        private System.Windows.Forms.Label lbMemberName;
        private System.Windows.Forms.TextBox txtMemberID;
        private System.Windows.Forms.Label lbMemberID;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCancel;
    }
}
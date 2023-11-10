using BusinessObject;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesWinApp
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            IConfiguration config = new ConfigurationBuilder()
                                    .SetBasePath(Directory.GetCurrentDirectory())
                                    .AddJsonFile("appsettings.json", true, true)
                                    .Build();

            var adminEmail = config["AdminAccount:Email"];
            var adminPassword = config["AdminAccount:Password"];

            // Compare admin credentials
            if (txtEmail.Text.Equals(adminEmail) && txtPassword.Text.Equals(adminPassword))
            {
                frmHomepage frmHomepage = new frmHomepage();
                frmHomepage.Show();
                this.Hide();
                MessageBox.Show("Welcome admin", "Xin Chao");
                return; // Exit the method if admin login is successful
            }

            // If not an admin, check against the database
            var dbContext = new FStoreContext();
            var member = dbContext.Members.FirstOrDefault(c => c.Email == txtEmail.Text);

            if (member != null && txtPassword.Text == member.Password)
            {
                frmHomepage frmHomepage = new frmHomepage();
                frmHomepage.Show();
                this.Hide();
                MessageBox.Show("Welcome " + member.Email);
            }
            else
            {
                MessageBox.Show("Login failed. Please check your credentials.");
            }

        }

        private void btReset_Click(object sender, EventArgs e)
        {
            txtEmail.Text = string.Empty;
            txtPassword.Text = string.Empty;    
        }
    }
}

using Repositories.Entities;
using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManagement_HoangNgocTrinh
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //chửi khi ko nhập gì cả mà nhấn login
            //validation
            if (string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Pleae input both email & password", "Input plz.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            UserAccountService service = new();
            UserAccount? acc = service.CheckLogin(txtEmail.Text, txtPassword.Text);

            if (acc == null)
            {
                MessageBox.Show("Login failed. Check the email and password again!", "Wrong credentials", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //acc okie rồi, khác null
            if (acc.Role != 1)
            {
                MessageBox.Show("You have no permission to access this function!", "Wrong privilege", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            //ngon với đúng rồi
            //mở form main
            BookManagerMainForm f = new();
            f.Show();
            this.Hide();
        }
    }
}

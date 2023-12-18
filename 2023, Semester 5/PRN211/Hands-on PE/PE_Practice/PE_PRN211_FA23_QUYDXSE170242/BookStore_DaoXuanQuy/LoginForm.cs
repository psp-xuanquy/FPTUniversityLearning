using Microsoft.Extensions.Configuration;
using Repositories.Entities;
using Services;
using System.Configuration;

namespace BookStore_DaoXuanQuy
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Email and password are required fields.",
                                 "Empty Fields", MessageBoxButtons.OK,
                                 MessageBoxIcon.Warning);
                return;
            }

            BookManagementMemberService se = new BookManagementMemberService();

            BookManagementMember account = se.CheckLogin(email, password);
            if (account == null)
            {
                MessageBox.Show("Login failed. Please check your credentials",
                                 "Wrong Credentials", MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
                return;
            }

            if (account.MemberRole != 1)
            {
                MessageBox.Show("You are not allowed to access this function!",
                                "Access Denied", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Login successfully", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
            BookManagementForm bookMgt = new BookManagementForm();
            bookMgt.Show();
            this.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
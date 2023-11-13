using DataAccessObjects;
using Repositories.Models;
using System;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;

namespace SaleManagementWinApp
{
    public partial class frmLogin : Form
    {
        MemberDAO memberDAO;
        public frmLogin()
        {
            memberDAO = new MemberDAO();
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {


            var email = txtEmail.Text;
            var password = txtPassword.Text;

            var account = memberDAO.GetAll().Where(p => p.Email.Equals(email.Trim()) && p.Password.Equals(password.Trim())).FirstOrDefault();
            if (account == null)
            {
                MessageBox.Show("Invalid email or password", "Warning", MessageBoxButtons.OK);
            }
            else if (account.Role == "USER")
            {
                frmCreateOrder frmOrder = new frmCreateOrder();
                frmOrder.Show();

                this.Hide();
            }
            else if (account.Role == "ADMIN")
            {
                frmMain mainForm = new frmMain();
                mainForm.Show();

                this.Hide();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) => Application.Exit();

        private void goToRegister(object sender, MouseEventArgs e)
        {
            this.Hide();

            frmRegister frmRegister = new frmRegister();
            frmRegister.Show();
        }
    }
}
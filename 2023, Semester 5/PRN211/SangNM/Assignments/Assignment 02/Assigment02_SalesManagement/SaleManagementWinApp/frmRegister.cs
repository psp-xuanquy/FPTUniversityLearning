using DataAccessObjects;
using Repositories.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleManagementWinApp
{
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        private void createAccount(object sender, EventArgs e)
        {
            string email = tbEmail.Text.Trim();
            string city = tbCity.Text.Trim();
            string country = tbCountry.Text.Trim();
            string password = tbPassword.Text.Trim();
            string rePassword = tbRePassword.Text.Trim();

            if (password.Length == 0)
            {
                MessageBox.Show("Password is required", "Error");
                return;
            }

            if (!password.Equals(rePassword))
            {
                MessageBox.Show("Password and re-password not same", "Error");
                return;
            }

            Member member = new Member();
            member.Email = email;
            member.City = city;
            member.Country = country;
            member.Password = password;
            member.Role = "USER";

            MemberDAO memberDAO = new MemberDAO();
            memberDAO.Create(member);

            frmLogin frmLogin = new frmLogin();
            this.Hide();
            frmLogin.Show();
        }

        private void goToLogin(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            this.Hide();
            frmLogin.Show();
        }
    }
}

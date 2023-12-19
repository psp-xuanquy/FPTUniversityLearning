using BSRepositories;
using BusinessObject;
using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BSAPP
{
    public partial class RegisterForm : Form
    {
        private IAccountRepository accountRepository = null;
        public RegisterForm()
        {
            InitializeComponent();
            accountRepository = new AccountRepository();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            try
            {
                TbAccount account = new TbAccount();
                TbUser user = new TbUser();
                var id = Guid.NewGuid().ToString();

                account.UserId = id;
                account.Password = txt_password.Text.Trim();
                account.Username = txt_username.Text.Trim();
                account.Role = "Customer";

                user.UserId = id;
                user.FullName = txt_FullName.Text.Trim();
                user.Address = txt_Address.Text.Trim();
                user.Email = txt_Email.Text.Trim();
                user.Phone = txt_Phone.Text.Trim();
                user.DateOfBird = dtp_Birthday.Value;
                user.Zipcode = txt_zipcode.Text.Trim();
                user.Gender = cb_Gender.Text.Trim();
                user.TbAccount = account;

                accountRepository.RegistraionAccount(user);

                this.Close();
            }
            catch
            {
                MessageBox.Show("Cannot Create Account");
            }
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            var gender = new List<string>();
            gender.Add("male");
            gender.Add("female");
            cb_Gender.DataSource = gender;
        }

        private void cb_Gender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

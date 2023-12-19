using BSRepositories;
using BusinessObject;
using BusinessObject.Models;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class ManageAccount : Form
    {
        private IAccountRepository accountRepository = null;

        public ManageAccount()
        {
            InitializeComponent();
            accountRepository = new AccountRepository();
        }

        private void ManageAccount_Load(object sender, EventArgs e)
        {
            dgv_accountlist.DataSource = accountRepository.GetAllAccounts().Select(a => new { a.UserId, a.Username, a.Password, a.Role, a.User.FullName, a.User.Email, a.User.Gender, a.User.Address, a.User.Phone, a.User.DateOfBird, a.User.Zipcode }).ToList();

            //dgv_accountlist.Columns.Add("FullName", "Full Name");
            //dgv_accountlist.Columns.Add("Email", "Email");
            //dgv_accountlist.Columns.Add("Gender", "Gender");
            //dgv_accountlist.Columns.Add("Address", "Address");
            //dgv_accountlist.Columns.Add("Phone", "Phone");
            //dgv_accountlist.Columns.Add("DateOfBird", "Date Of Birth");
            //dgv_accountlist.Columns.Add("Zipcode", "Zipcode");

            //LoadFormating(accountRepository.GetAllAccounts(), sender, e);

            var gender = new List<string>();
            gender.Add("male");
            gender.Add("female");
            cbx_gender.DataSource = gender;

            var role = new List<string>();
            role.Add("Admin");
            role.Add("Manager");
            role.Add("Customer");
            role.Add("Staff");
            cbb_Role.DataSource = role;
        }

        private void dgv_accountlist_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_username.Text = dgv_accountlist.CurrentRow.Cells["Username"].Value.ToString();
            txt_password.Text = dgv_accountlist.CurrentRow.Cells["Password"].Value.ToString();
            cbb_Role.Text = dgv_accountlist.CurrentRow.Cells["Role"].Value.ToString();
            txt_fullname.Text = dgv_accountlist.CurrentRow.Cells["FullName"].Value.ToString();
            txt_email.Text = dgv_accountlist.CurrentRow.Cells["Email"].Value.ToString();
            cbx_gender.Text = dgv_accountlist.CurrentRow.Cells["Gender"].Value.ToString();
            txt_address.Text = dgv_accountlist.CurrentRow.Cells["Address"].Value.ToString();
            txt_phone.Text = dgv_accountlist.CurrentRow.Cells["Phone"].Value.ToString();
            dtp_dateofbird.Text = dgv_accountlist.CurrentRow.Cells["DateOfBird"].Value.ToString();
            txt_zipcode.Text = dgv_accountlist.CurrentRow.Cells["Zipcode"].Value.ToString();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {

                TbAccount account = new TbAccount();
                TbUser user = new TbUser();
                var id = Guid.NewGuid().ToString();

                account.UserId = id;
                account.Password = txt_password.Text.Trim();
                account.Username = txt_username.Text.Trim();
                account.Role = cbb_Role.Text.Trim();

                user.UserId = id;
                user.FullName = txt_fullname.Text.Trim();
                user.Address = txt_address.Text.Trim();
                user.DateOfBird = dtp_dateofbird.Value;
                user.Email = txt_email.Text.Trim();
                user.Phone = txt_phone.Text.Trim();
                user.Zipcode = txt_zipcode.Text.Trim();
                user.Gender = cbx_gender.Text.Trim();
                user.TbAccount = account;

                accountRepository.RegistraionAccount(user);

                ManageAccount_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                accountRepository.DeleteAccount(dgv_accountlist.CurrentRow.Cells["UserId"].Value.ToString());
                ManageAccount_Load(sender, e);
            }
            catch
            {
                MessageBox.Show("Cannot Remove Account");
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {

                TbAccount account = new TbAccount();
                TbUser user = new TbUser();


                account.UserId = dgv_accountlist.CurrentRow.Cells["UserId"].Value.ToString();
                account.Password = txt_password.Text.Trim();
                account.Username = txt_username.Text.Trim();
                account.Role = cbb_Role.Text.Trim();

                user.UserId = dgv_accountlist.CurrentRow.Cells["UserId"].Value.ToString();
                user.FullName = txt_fullname.Text.Trim();
                user.Address = txt_address.Text.Trim();
                user.DateOfBird = dtp_dateofbird.Value;
                user.Email = txt_email.Text.Trim();
                user.Phone = txt_phone.Text.Trim();
                user.Zipcode = txt_zipcode.Text.Trim();
                user.Gender = cbx_gender.Text.Trim();
                user.TbAccount = account;

                accountRepository.UpdateAccount(user);

                ManageAccount_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                dgv_accountlist.DataSource = accountRepository.GetAccountByFullName(txt_search.Text.Trim()).Select(a => new { a.UserId, a.Username, a.Password, a.Role, a.User.FullName, a.User.Email, a.User.Gender, a.User.Address, a.User.Phone, a.User.DateOfBird, a.User.Zipcode }).ToList();
            }
            catch
            {
                MessageBox.Show("Cannot Find User");
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dgv_accountlist.DataSource = accountRepository.GetAccountByFullName(txt_search.Text.Trim()).Select(a => new { a.UserId, a.Username, a.Password, a.Role, a.User.FullName, a.User.Email, a.User.Gender, a.User.Address, a.User.Phone, a.User.DateOfBird, a.User.Zipcode }).ToList();
            }
            catch
            {
                MessageBox.Show("Cannot Find User");
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgv_accountlist.DataSource = accountRepository.GetAllAccounts().Select(a => new { a.UserId, a.Username, a.Password, a.Role, a.User.FullName, a.User.Email, a.User.Gender, a.User.Address, a.User.Phone, a.User.DateOfBird, a.User.Zipcode }).ToList();
        }
    }
}

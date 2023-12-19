using BSAPP;
using BSRepositories;
using BusinessObject;
using BusinessObject.Models;

namespace ProjectPrn211
{
    public partial class LoginForm : Form
    {
        private IAccountRepository accountRepository;
        public LoginForm()
        {
            InitializeComponent();
            accountRepository = new AccountRepository();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {

            try
            {
                TbAccount account = accountRepository.GetAccountByUsername(txt_username.Text.Trim());
                if (account != null && txt_password.Text.Trim() == account.Password)
                {
                    AuthenticatedUser.UserId = account.UserId;

                    switch (account.Role)
                    {
                        case "Admin":
                            ManageAccount accountsManagement = new ManageAccount();
                            this.Hide();
                            accountsManagement.ShowDialog();
                            this.Show();
                            break;

                        case "Manager":
                            ManageProducts productsManagement = new ManageProducts();
                            this.Hide();
                            productsManagement.ShowDialog();
                            this.Show();
                            break;

                        case "Customer":
                            HomePage customerView = new HomePage();
                            this.Hide();
                            customerView.ShowDialog();
                            this.Show();
                            break;
                        case "Staff":
                            OrderStatusManager orderStatusManager = new OrderStatusManager();
                            this.Hide();
                            orderStatusManager.ShowDialog();
                            this.Show();
                            break;
                        default:
                            MessageBox.Show("You dont have permission");
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Please check Username and Password");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            this.Hide();
            registerForm.ShowDialog();
            this.Show();
        }
    }
}
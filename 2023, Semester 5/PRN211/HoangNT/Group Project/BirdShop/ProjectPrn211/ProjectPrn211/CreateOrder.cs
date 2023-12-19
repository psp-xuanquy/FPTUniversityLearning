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
    public partial class CreateOrder : Form
    {
        private IPaymentMethodRepositories paymentMethodRepositories;
        private IProviderRepositories providerRepositories;
        private IAccountRepository accountRepository;
        private ICartRepositories cartRepositories;
        private IOrderRepositories orderRepositories;
        public CreateOrder()
        {
            InitializeComponent();
            paymentMethodRepositories = new PaymentMethodRepository();
            providerRepositories = new ProviderRepository();
            accountRepository = new AccountRepository();
            cartRepositories = new CartRepository();
            orderRepositories = new OrderRepository();
        }

        private void CreateOrder_Load(object sender, EventArgs e)
        {
            string userId = AuthenticatedUser.UserId;

            #region View Products
            var productInCart = cartRepositories.ViewCart(userId);

            dtg_ViewProducts.DataSource = productInCart;
            dtg_ViewProducts.Columns["ProductId"].Visible = false;

            #endregion

            #region View Order Information

            var user = accountRepository.GetAccountById(userId);

            label_Fullname.Text = user.FullName.ToString();
            txt_Phone.Text = user.Phone.ToString();
            txt_Address.Text = user.Address.ToString();
            dtp_CreateDate.Text = DateTime.Now.ToString();
            dtp_EstimatedDate.Text = DateTime.Now.AddDays(15).ToString();

            decimal total = 0;
            foreach (var product in productInCart)
            {
                total += product.Price;
            }
            label_Total.Text = total.ToString();

            cbb_PaymentMethod.DataSource = paymentMethodRepositories.GetPaymentMethods();
            cbb_PaymentMethod.DisplayMember = "PaymentMethodName";

            cbb_Provider.DataSource = providerRepositories.GetProviders();
            cbb_Provider.DisplayMember = "ProviderName";

            //cbb_Provider.Visible = false;
            //label_Provider.Visible = false;

            #endregion
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            try
            {

                var order = new TbOrder();
                string userId = AuthenticatedUser.UserId;

                string address = txt_Address.Text.Trim();
                string phone = txt_Phone.Text.Trim();
                string paymentMethod = ((TbPaymentMethod)cbb_PaymentMethod.SelectedValue).PaymentMethodId.ToString();

                order.OrderId = Guid.NewGuid().ToString();
                order.UserId = userId;
                if (!Ultils.IsEmptyString(address))
                {
                    if (Ultils.CheckLengthString(address, 10, 200))
                    {
                        order.Address = address;
                    }
                    else
                    {
                        throw new Exception("Address length from 10 - 200 character");
                    }
                }
                else
                {
                    throw new Exception("Address is required");
                }
                if (!Ultils.IsEmptyString(phone))
                {
                    if (Ultils.CheckLengthString(phone, 9, 11))
                    {
                        order.Phone = phone;
                    }
                    else
                    {
                        throw new Exception("Phone number length from 9 - 11 numbers");
                    }
                }
                else
                {
                    throw new Exception("Phone number is required");
                }
                order.PaymentMethodId = paymentMethod;
                if (paymentMethod == "CASH001")
                {
                    order.ProviderId = "PVD000";
                }
                order.ProviderId = ((TbProvider)cbb_Provider.SelectedValue).ProviderId.ToString();
                order.Total = Convert.ToDecimal(label_Total.Text);
                order.CreateAt = DateTime.Now;
                order.EstimatedDate = DateTime.Now.AddDays(15);
                order.Status = true;

                orderRepositories.CreateOrder(order, userId);
                MessageBox.Show("Create Order Sucessfuly!");
                this.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbb_PaymentMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedPaymentMethod = ((TbPaymentMethod)cbb_PaymentMethod.SelectedItem).PaymentMethodName.ToString();
            if (selectedPaymentMethod == "Card")
            {
                cbb_Provider.Visible = true;
                label_Provider.Visible = true;

            }
            else
            {
                cbb_Provider.Visible = false;
                label_Provider.Visible = false;
            }

        }


    }
}

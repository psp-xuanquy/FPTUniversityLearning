using BSRepositories;
using BusinessObject;
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
    public partial class ViewCart : Form
    {
        private ICartRepositories cartRepositories;
        private IBirdRepositories birdRepositories;
        private INestRepositories nestRepositories;
        private IOrderRepositories orderRepositories;

        public ViewCart()
        {
            InitializeComponent();
            cartRepositories = new CartRepository();
            birdRepositories = new BirdRepository();
            nestRepositories = new NestRepository();
            orderRepositories = new OrderRepository();
        }

        private void ViewCart_Load(object sender, EventArgs e)
        {
            string userId = AuthenticatedUser.UserId;
            var cartList = cartRepositories.ViewCart(userId);
            decimal total = 0;
            dtg_ViewCart.DataSource = cartList;
            foreach (var item in cartList)
            {
                total += item.Price;
            }
            txt_Total.Text = total.ToString();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dtg_ViewCart_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string productId = dtg_ViewCart.CurrentRow.Cells[0].Value.ToString();
            if (productId.StartsWith("BIRD"))
            {
                var bird = birdRepositories.GetBirdById(productId);
                txt_NameBird.Text = bird.Name.ToString();
                txt_SpeciesNameBird.Text = bird.BirdSpecies.BirdSpeciesName.ToString();
                txt_GenderBird.Text = bird.Gender.ToString();
                txt_AgeBird.Text = bird.Age.ToString();
                rtb_DescriptionBird.Text = bird.Description.ToString();
                txt_PriceBird.Text = bird.Price.ToString();
            }
            else
            {
                var nest = nestRepositories.GetNestById(productId);

                txt_NameNest.Text = nest.Name.ToString();
                txt_SpeciesNest.Text = nest.BirdSpecies.ToString();
                txt_QuantityNest.Text = nest.Quantity.ToString();
                rtb_DescriptonNest.Text = nest.Description.ToString();
                txt_PriceNest.Text = nest.Price.ToString();
            }
        }

        private void btn_Order_Click(object sender, EventArgs e)
        {
            try
            {
                string userId = AuthenticatedUser.UserId;
                var cartList = cartRepositories.ViewCart(userId);


                if (cartList.Count > 0)
                {
                    if (orderRepositories.CheckProductsStatus(userId))
                    {
                        CreateOrder createOrder = new CreateOrder();
                        this.Hide();
                        createOrder.ShowDialog();
                        this.Show();
                        dtg_ViewCart.DataSource = cartRepositories.ViewCart(userId);
                    }
                }
                else
                {
                    MessageBox.Show("Your Cart is empty");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            string productId = dtg_ViewCart.CurrentRow.Cells[0].Value.ToString();
            string userId = AuthenticatedUser.UserId;
            if (cartRepositories.RemoveProductFromCart(userId, productId))
            {
                dtg_ViewCart.DataSource = cartRepositories.ViewCart(userId);
                MessageBox.Show("Remove sucessfully");
            }
            else
            {
                MessageBox.Show("Remove unsucessfully");
            }
        }
    }
}

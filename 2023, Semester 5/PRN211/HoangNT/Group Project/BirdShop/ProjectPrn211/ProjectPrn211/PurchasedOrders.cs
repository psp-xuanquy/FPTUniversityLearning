using BSRepositories;
using BusinessObject;
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
    public partial class PurchasedOrders : Form
    {
        private IOrderRepositories orderRepositories;
        private IBirdRepositories birdRepositories;
        private INestRepositories nestRepositories;
        public PurchasedOrders()
        {
            InitializeComponent();
            orderRepositories = new OrderRepository();
            birdRepositories = new BirdRepository();
            nestRepositories = new NestRepository();
        }

        private void PurchasedOrders_Load(object sender, EventArgs e)
        {
            string userId = AuthenticatedUser.UserId;
            dtg_ViewOrder.DataSource = orderRepositories.GetPurchasedOrders(userId).Select(o => new { o.User.FullName, o.Address, o.Phone, o.PaymentMethod.PaymentMethodName, o.Provider.ProviderName, o.Total, o.CreateAt, o.EstimatedDate }).ToList();
        }

        private void dtg_ViewOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dtg_ViewProduct.DataSource = orderRepositories.GetPurchasedProducts(dtg_ViewOrder.CurrentRow.Cells[0].Value.ToString());
            dtg_ViewProduct.Columns["ProductId"].Visible = false;

            label_Fullname.Text = dtg_ViewOrder.CurrentRow.Cells[0].Value.ToString();
            txt_Address.Text = dtg_ViewOrder.CurrentRow.Cells[1].Value.ToString();
            txt_Phone.Text = dtg_ViewOrder.CurrentRow.Cells[2].Value.ToString();
            txt_PaymentMethod.Text = dtg_ViewOrder.CurrentRow.Cells[3].Value.ToString();
            txt_Provider.Text = dtg_ViewOrder.CurrentRow.Cells[4].Value.ToString();
            label_Total.Text = dtg_ViewOrder.CurrentRow.Cells[5].Value.ToString();
            txt_CreateDate.Text = dtg_ViewOrder.CurrentRow.Cells[6].Value.ToString();
            txt_EstimatedDate.Text = dtg_ViewOrder.CurrentRow.Cells[7].Value.ToString();
        }

        private void dtg_ViewProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string productId = dtg_ViewProduct.CurrentRow.Cells[0].Value.ToString();
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
    }
}

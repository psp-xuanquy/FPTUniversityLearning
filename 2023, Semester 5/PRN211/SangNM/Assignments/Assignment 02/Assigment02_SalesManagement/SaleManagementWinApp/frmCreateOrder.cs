using Repositories.Models;
using System;
using DataAccessObjects;
using System.Windows.Forms;
using System.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.ComponentModel;
using System.Windows.Forms.VisualStyles;
using System.Collections.Generic;
using Repositories;

namespace SaleManagementWinApp
{
    public partial class frmCreateOrder : Form
    {
        OrderDetailRepository OrderDetailRepository = new OrderDetailRepository();
        ProductDAO productDAO = new ProductDAO();
        public frmCreateOrder()
        {
            InitializeComponent();// lấy data dưới database lên
            var list = productDAO.GetAll().Select(p => new { p.ProductId, p.ProductName, p.UnitPrice, p.UnitsInStock }).ToList();
            dgvListProduct.DataSource = list;

            txtProductID.Enabled = false;
            txtProductName.Enabled = false;
            txtUnitPrice.Enabled = false;
            txtUnitInStock.Enabled = false;
        }



        private void btnCart_Click(object sender, EventArgs e)
        {
            frmCheckOut frmCheckOut = new frmCheckOut();
            frmCheckOut.ShowDialog();
        }

        private void btnSearchProduct_Click(object sender, EventArgs e)
        {
            ProductDAO dao = new ProductDAO();
            var list = dao.GetAll().Select(p => new { p.ProductId, p.ProductName, p.UnitPrice, p.UnitsInStock }).ToList();
            dgvListProduct.DataSource = list;
        }


        private void dgvListProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = dgvListProduct.Rows[e.RowIndex];

                // Retrieve the values from the desired columns of the clicked row
                string ProductId = row.Cells["ProductId"].Value.ToString();
                string ProductName = row.Cells["ProductName"].Value.ToString();
                string UnitPrice = row.Cells["UnitPrice"].Value.ToString();
                string UnitsInStock = row.Cells["UnitsInStock"].Value.ToString();

                // Assign the values to different text boxes
                txtProductID.Text = ProductId;
                txtProductName.Text = ProductName;
                txtUnitPrice.Text = UnitPrice;
                txtUnitInStock.Text = UnitsInStock;
            }
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            var quantityTxt = txtQuantity.Text;
            int quantity;

            if (int.TryParse(quantityTxt, out quantity))
            {
                if (quantity <= 0) MessageBox.Show("Quantity cannot <= 0", "Warning", MessageBoxButtons.OK);
                else if (txtProductID.Text.ToString() != "")
                {

                    Random random = new Random();
                    var products = (new OrderDetail
                    {
                        OrderId = random.Next(),
                        ProductId = Int16.Parse(txtProductID.Text),
                        UnitPrice = Decimal.Parse(txtUnitPrice.Text),
                        Quantity = quantity,
                        Discount = 0
                    });
                    OrderDetailRepository.Create(products);
                    MessageBox.Show("Add a product done", "Notification", MessageBoxButtons.OK);
                }
                else MessageBox.Show("Please select a product", "Warning", MessageBoxButtons.OK);

            }
            else MessageBox.Show("Please input a number", "Warning", MessageBoxButtons.OK);

        }

        private void logout(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            this.Hide();
            frmLogin.Show();
        }
    }
}

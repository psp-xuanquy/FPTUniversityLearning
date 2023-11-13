using DataAccessObjects;
using Repositories;
using Repositories.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SaleManagementWinApp
{
    public partial class frmCheckOut : Form
    {
        OrderDetailDAO orderDetailDAO = new OrderDetailDAO();
        OrderDetailRepository _orderDetailRepository = new OrderDetailRepository();
        public frmCheckOut()
        {
            InitializeComponent();
            var list = orderDetailDAO.GetAll().Where(p => p.Discount != 1)
                .Select(p => new { p.OrderId, p.ProductId, p.UnitPrice, p.Quantity, p.Discount }).ToList();
            
            dgvListCart.DataSource = list;

        }

        private void frmCheckOut_Load(object sender, EventArgs e)
        {
            var list = orderDetailDAO.GetAll().Where(p => p.Discount != 1)
                .Select(p => new { p.OrderId, p.ProductId, p.UnitPrice, p.Quantity, p.Discount }).ToList();
            
            dgvListCart.DataSource = list;

        }

        private void dgvListCart_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var rowSelected = this.dgvListCart.Rows[e.RowIndex];
                // rowSelected.Cells["City"].Value;
                //rowSelected.Cells[3].Value;

            }
            btnCheckout.Enabled = false;// bam vo la o check out bi mo di ko cho sai nua
            btnRemoveCart.Enabled = true;//duoc cho phep nhan khi remove cart
        }

        private void btnRemoveCart_Click(object sender, EventArgs e)
        {
            if (dgvListCart.SelectedCells.Count == 0)
            {
                MessageBox.Show("Please select a row to remove.", "No Row Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int selectedRowIndex = dgvListCart.SelectedCells[0].RowIndex;
            DataGridViewRow row = dgvListCart.Rows[selectedRowIndex];
            List<string> cellValues = new List<string>();
            foreach (DataGridViewCell cell in row.Cells)
            {
                string cellValue = cell.Value?.ToString() ?? string.Empty;
                cellValues.Add(cellValue);
            }

            var order = new OrderDetail
            {
                OrderId = int.Parse(cellValues[0]),
                ProductId = int.Parse(cellValues[1]),
                UnitPrice = decimal.Parse(cellValues[2]),
                Quantity = int.Parse(cellValues[3]),
                Discount = 0
            };

            _orderDetailRepository.Delete(order);
            frmCheckOut_Load(null, null);
            MessageBox.Show("Remove a product done", "Notification", MessageBoxButtons.OK);


        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            ProductDAO productDAO = new ProductDAO();

            if (dgvListCart.SelectedCells.Count == 0)
            {
                MessageBox.Show("Please select a row to checkout.", "No Row Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int selectedRowIndex = dgvListCart.SelectedCells[0].RowIndex;
            // DataGridViewRow row = dgvListCart.Rows[selectedRowIndex];
            List<string> cellValues = new List<string>();
            foreach (DataGridViewRow row in dgvListCart.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    string cellValue = cell.Value?.ToString() ?? string.Empty;
                    cellValues.Add(cellValue);
                }

                var order = new OrderDetail
                {
                    OrderId = int.Parse(cellValues[0]),
                    ProductId = int.Parse(cellValues[1]),
                    UnitPrice = decimal.Parse(cellValues[2]),
                    Quantity = int.Parse(cellValues[3]),
                    Discount = 1
                };

                Product product = productDAO.GetAll().FirstOrDefault(p => p.ProductId == int.Parse(cellValues[1]));
                if (product != null)
                {
                    product.UnitsInStock -= int.Parse(cellValues[3]);
                    productDAO.Update(product);
                }

                _orderDetailRepository.Update(order);
                cellValues.Clear();


            };

            MessageBox.Show("Pay a product done", "Notification", MessageBoxButtons.OK);
            dgvListCart.Update();

            OrderDetailDAO orDeDAO = new OrderDetailDAO();
            var list = orDeDAO.GetAll().Where(p => p.Discount != 1)
                .Select(p => new { p.OrderId, p.ProductId, p.UnitPrice, p.Quantity, p.Discount }).ToList();
            dgvListCart.DataSource = list;
        }
    }
}

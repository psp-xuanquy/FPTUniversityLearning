using DataAccessObjects;
using Repositories.Models;
using System.Linq;
using System.Windows.Forms;

namespace SaleManagementWinApp
{
    public partial class frmProducts : Form
    {
        ProductDAO productsDAO = new ProductDAO();
        CategoryDAO categoryDAO = new CategoryDAO();

        public frmProducts()
        {
            InitializeComponent();

            var categoryList = categoryDAO.GetAll().ToList();
            cbCategory.DataSource = categoryList;
            cbCategory.DisplayMember = "CategoryName";

            var list = productsDAO.GetAll().Select(p => new { p.ProductId, p.ProductName, p.UnitPrice, p.CategoryId, p.Weight, p.UnitsInStock }).ToList();
            dgvProductList.DataSource = list;

        }

        private void button1_Click(object sender, System.EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, System.EventArgs e)
        {

            var list = productsDAO.GetAll().Where(p => p.ProductName.ToLower().Contains(txtSearchProduct.Text.ToLower())).ToList();
            if (list != null)
            {
                dgvProductList.DataSource = list;
            }
            else
            {
                MessageBox.Show("Cannot Find Any Product. Please Try again !", "Notification", MessageBoxButtons.OK);
            }
        }

        private void dgvProductList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            //var productId = dgvProductList.Rows[e.RowIndex].Cells[0].Value;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            if (e.RowIndex >= 0)
            {
                txtProductID.Enabled = false;
                var rowSelected = this.dgvProductList.Rows[e.RowIndex];
                txtProductID.Text = rowSelected.Cells["ProductId"].Value.ToString();
                txtProductName.Text = rowSelected.Cells["ProductName"].Value.ToString();
                txtUnitPrice.Text = rowSelected.Cells["UnitPrice"].Value.ToString();
                cbCategory.SelectedItem = categoryDAO.GetAll().FirstOrDefault(c => c.CategoryId == (int)rowSelected.Cells["CategoryId"].Value);
                txtWeight.Text = rowSelected.Cells["Weight"].Value.ToString();
                txtUnitInStock.Text = rowSelected.Cells["UnitsInStock"].Value.ToString();
            }
            //var obj = productsDAO.GetAll().Where(p => p.ProductId.Equals(productId)).FirstOrDefault();

            btnCreate.Enabled = false;
            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;
        }

        private void btnCreate_Click(object sender, System.EventArgs e)
        {
            var Product = new Product();
            productsDAO = new ProductDAO();
            Product.ProductId = int.Parse(txtProductID.Text);
            if (productsDAO.GetAll().Where(p => p.ProductId.Equals(Product.ProductId)).FirstOrDefault() != null)
            {
                MessageBox.Show("ProductId Existed ", "hello", MessageBoxButtons.OK);
                return;
            }
            Product.ProductId = int.Parse(txtProductID.Text);
            Product.ProductName = txtProductName.Text;
            Product.UnitPrice = decimal.Parse(txtUnitPrice.Text);
            Category selected = (Category)cbCategory.SelectedItem;
            Product.CategoryId = selected.CategoryId;
            Product.Weight = txtWeight.Text;
            Product.UnitsInStock = int.Parse(txtUnitInStock.Text);
            productsDAO.Create(Product);
            MessageBox.Show("Product Added!");

            var list = productsDAO.GetAll().Select(p => new { p.ProductId, p.ProductName, p.UnitPrice, p.CategoryId, p.Weight, p.UnitsInStock }).ToList();
            dgvProductList.DataSource = list;
        }

        private void btnDelete_Click(object sender, System.EventArgs e)
        {
            var Id = int.Parse(txtProductID.Text);

            var obj = productsDAO.GetAll().Where(p => p.ProductId == Id).FirstOrDefault();
            productsDAO = new ProductDAO();
            if (obj != null)
            {
                var dialog = MessageBox.Show("Do you want to delete it?", "Warning", MessageBoxButtons.OKCancel);
                if (dialog == DialogResult.OK)
                {
                    productsDAO.Delete(obj);
                }
                else
                {
                    return;
                }
            }

            var list = productsDAO.GetAll().Select(p => new { p.ProductId, p.ProductName, p.UnitPrice, p.CategoryId, p.Weight, p.UnitsInStock }).ToList();
            dgvProductList.DataSource = list;
        }

        private void btnUpdate_Click(object sender, System.EventArgs e)
        {
            productsDAO = new ProductDAO();
            var product = new Product();

            product.ProductId = int.Parse(txtProductID.Text);
            product.ProductName = txtProductName.Text;
            product.UnitPrice = decimal.Parse(txtUnitPrice.Text);

            Category selected = (Category)cbCategory.SelectedItem;
            product.CategoryId = selected.CategoryId;

            product.Weight = txtWeight.Text;
            product.UnitsInStock = int.Parse(txtUnitInStock.Text);
            productsDAO.Update(product);

            var list = productsDAO.GetAll().Select(p => new { p.ProductId, p.ProductName, p.UnitPrice, p.CategoryId, p.Weight, p.UnitsInStock }).ToList();
            dgvProductList.DataSource = list;
        }
    }
}
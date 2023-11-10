using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess;
using DataAccess.Repository;
using BusinessObject.Models;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace ConvenienceStoreApp
{
    public partial class ucProductManagement : UserControl
    {
        public ucProductManagement()
        {
            InitializeComponent();
        }

        IProductRepository repoProduct = new ProductRepository();
        BindingSource source;

        private void ucProductManagement_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                LoadAllProductList();
                cboSelect.SelectedIndex = 0;
                cboCategoryID.SelectedIndex = 0;

                lbCate.Hide();
                lbStatus.Hide();
                cboCategoryID.Hide();
                cboStatusID.Hide();

                txtProductID.Enabled = false;
                txtProductID.ReadOnly = true;
                txtProductName.ReadOnly = true;
                txtPrice.ReadOnly = true;
                txtQuantity.ReadOnly = true;
                cboCategoryID.Enabled = false;
                cboStatusID.Enabled = false;
            }
        }
        public void LoadAllProductList()
        {
            List<TblProduct> products = null;
            try
            {
                products = repoProduct.GetAllProduct().OrderBy(pro => pro.ProductId).ToList();
                List<object> loadList = new List<object>();
                products.ForEach(product => loadList.Add(new
                {
                    ProductId = product.ProductId,
                    ProductName =  product.ProductName,
                    Price = product.Price,
                    Quantity = product.Quantity,
                    CategoryId = product.CategoryId,
                    StatusId = product.StatusId,
                }));
                source = new BindingSource();
                source.DataSource = loadList;

                txtProductID.DataBindings.Clear();
                txtProductName.DataBindings.Clear();
                txtPrice.DataBindings.Clear();
                txtQuantity.DataBindings.Clear();
                cboCategoryID.DataBindings.Clear();
                cboStatusID.DataBindings.Clear();

                txtProductID.DataBindings.Add("Text", source, "ProductId");
                txtProductName.DataBindings.Add("Text", source, "ProductName");
                txtPrice.DataBindings.Add("Text", source, "Price");
                txtQuantity.DataBindings.Add("Text", source, "Quantity");
                cboCategoryID.DataBindings.Add("Text", source, "CategoryId");
                cboStatusID.DataBindings.Add("Text", source, "StatusId");


                dgvProductList.DataSource = null;
                dgvProductList.DataSource = source;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load Staff List", MessageBoxButtons.OK);
            }

        }

        public void LoadAllAvailableProduct()
        {
            List<TblProduct> products = null;
            try
            {
                products = repoProduct.GetAllAvailableProduct().OrderBy(pro => pro.ProductId).ToList();

                List<object> loadList = new List<object>();
                products.ForEach(product => loadList.Add(new
                {
                    ProductId = product.ProductId,
                    ProductName = product.ProductName,
                    Price = product.Price,
                    Quantity = product.Quantity,
                    CategoryId = product.CategoryId,
                    StatusId = product.StatusId,
                }));

                source = new BindingSource();
                source.DataSource = loadList;

                txtProductID.DataBindings.Clear();
                txtProductName.DataBindings.Clear();
                txtPrice.DataBindings.Clear();
                txtQuantity.DataBindings.Clear();
                cboCategoryID.DataBindings.Clear();
                cboStatusID.DataBindings.Clear();

                txtProductID.DataBindings.Add("Text", source, "ProductId");
                txtProductName.DataBindings.Add("Text", source, "ProductName");
                txtPrice.DataBindings.Add("Text", source, "Price");
                txtQuantity.DataBindings.Add("Text", source, "Quantity");
                cboCategoryID.DataBindings.Add("Text", source, "CategoryId");
                cboStatusID.DataBindings.Add("Text", source, "StatusId");

                dgvProductList.DataSource = null;
                dgvProductList.DataSource = source;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load Staff List", MessageBoxButtons.OK);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearchValue.Clear();
            LoadAllProductList();
        }

        private void btnAvailable_Click(object sender, EventArgs e)
        {
            txtSearchValue.Clear();
            LoadAllAvailableProduct();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                List<TblProduct> products = new List<TblProduct>();
                TblProduct product = null;

                if (!cboSelect.SelectedItem.ToString().Equals("") && !txtSearchValue.Text.Trim().Equals(""))
                {
                    if (cboSelect.SelectedItem.ToString().Equals("Product ID"))
                    {
                        product = repoProduct.GetProductByID(txtSearchValue.Text);
                    }
                    else if (cboSelect.SelectedItem.ToString().Equals("Product Name"))
                    {
                        if (!Regex.IsMatch(txtSearchValue.Text.Trim(), @"^[a-zA-Z ]+$"))
                        {
                            MessageBox.Show("Invalid name input", "Search", MessageBoxButtons.OK);
                        }
                        else
                        {
                            products = repoProduct.GetAllProductByName(txtSearchValue.Text);
                        }
                        
                    }
                    else if (cboSelect.SelectedItem.ToString().Equals("Category ID"))
                    {
                        products = repoProduct.GetAllProductByCategory(txtSearchValue.Text);
                    }
                    if (product != null || products.Count > 0)
                    {
                        source = new BindingSource();
                        if (product != null)
                        {
                            source.DataSource = product;
                        }
                        else if(products.Count > 0)
                        {
                            List<object> loadList = new List<object>();
                            products.ForEach(product => loadList.Add(new
                            {
                                ProductId = product.ProductId,
                                ProductName = product.ProductName,
                                Price = product.Price,
                                Quantity = product.Quantity,
                                CategoryId = product.CategoryId,
                                StatusId = product.StatusId,

                            }));
                            source.DataSource = loadList;
                        }
                        dgvProductList.DataSource = null;
                        dgvProductList.DataSource = source;
                    }
                    else
                    {
                        MessageBox.Show("Product not found", "Search", MessageBoxButtons.OK);
                        LoadAllProductList();
                    }
                }
                else
                {
                    MessageBox.Show("Empty input are not allow", "Search", MessageBoxButtons.OK);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Search Product", MessageBoxButtons.OK);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (btnAdd.Text.Equals("Add"))
            {
                btnAdd.Text = "Save";
                btnUpdate.Text = "Cancel";

                txtProductID.Clear();
                txtProductName.Clear();
                txtPrice.Clear();
                txtQuantity.Clear();
                cboCategoryID.SelectedIndex = 0;
                cboStatusID.SelectedIndex = 0;

                txtProductID.DataBindings.Clear();
                txtProductName.DataBindings.Clear();
                txtPrice.DataBindings.Clear();
                txtQuantity.DataBindings.Clear();
                cboCategoryID.DataBindings.Clear();
                cboStatusID.DataBindings.Clear();

                txtProductID.Enabled = true;
                txtProductID.ReadOnly = false;
                txtProductName.ReadOnly = false;
                txtPrice.ReadOnly = false;
                txtQuantity.ReadOnly = false;
                cboCategoryID.Enabled = true;
                cboStatusID.Enabled = true;

                dgvProductList.Enabled = false;
                dgvProductList.ClearSelection();
                dgvProductList.CurrentCell = null;

                txtSearchValue.ReadOnly = true;
                btnSearch.Enabled = false;
                btnRefresh.Enabled = false;
                btnAvailable.Enabled = false;

                lbCate.Show();
                cboCategoryID.Show();

            }
            else if (btnAdd.Text.Equals("Save"))
            {
                if (txtProductID.Text.Trim().Equals("") || txtProductName.Text.Trim().Equals("") || txtPrice.Text.Trim().Equals("") || txtQuantity.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Empty input are not allow", "Add", MessageBoxButtons.OK);
                }
                else
                {
                    if (!txtProductID.Text.Trim().Equals("") && repoProduct.GetProductByID(txtProductID.Text) != null && txtProductID.Enabled)
                    {
                        MessageBox.Show("Product already exist", "Add", MessageBoxButtons.OK);
                    }
                    else if (!Regex.IsMatch(txtProductName.Text.Trim(), @"^[a-zA-Z ]+$"))
                    {
                        MessageBox.Show("Invalid name input", "Add", MessageBoxButtons.OK);
                    }
                    else if (!Regex.IsMatch(txtPrice.Text.Trim(), @"^[0-9]+$"))
                    {
                        MessageBox.Show("Invalid price input", "Add", MessageBoxButtons.OK);
                    }
                    else if (!Regex.IsMatch(txtQuantity.Text.Trim(), @"^[0-9]+$"))
                    {
                        MessageBox.Show("Invalid quantity input", "Add", MessageBoxButtons.OK);
                    }
                    else
                    {
                        try
                        {
                            int CrtIndex = cboCategoryID.SelectedIndex + 1;
                            TblProduct product = new TblProduct
                            {
                                ProductId = txtProductID.Text,
                                ProductName = txtProductName.Text,
                                Price = double.Parse(txtPrice.Text),
                                Quantity = Int32.Parse(txtQuantity.Text),
                                CategoryId = CrtIndex.ToString(),
                                StatusId = cboStatusID.Text.ToString(),
                                ImageSrc = null,
                            };
                            if (txtProductID.Enabled)
                            {
                                repoProduct.Add(product);
                            }
                            else
                            {
                                repoProduct.Update(product);
                            }

                            txtProductID.Enabled = false;
                            txtProductID.ReadOnly = true;
                            txtProductName.ReadOnly = true;
                            txtPrice.ReadOnly = true;
                            txtQuantity.ReadOnly = true;
                            cboCategoryID.Enabled = false;
                            cboStatusID.Enabled = false;

                            dgvProductList.Enabled = true;
                            LoadAllProductList();

                            btnAdd.Text = "Add";
                            btnUpdate.Text = "Update";

                            txtSearchValue.ReadOnly = false;
                            btnSearch.Enabled = true;
                            btnRefresh.Enabled = true;
                            btnAvailable.Enabled = true;

                            lbCate.Hide();
                            cboCategoryID.Hide();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Add product", MessageBoxButtons.OK);
                        }
                    }
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (btnUpdate.Text.Equals("Update"))
            {
                txtProductID.DataBindings.Clear();
                txtProductName.DataBindings.Clear();
                txtPrice.DataBindings.Clear();
                txtQuantity.DataBindings.Clear();
                cboCategoryID.DataBindings.Clear();
                cboStatusID.DataBindings.Clear();

                txtProductID.Enabled = false;
                txtProductID.ReadOnly = true;
                txtProductName.ReadOnly = false;
                txtPrice.ReadOnly = false;
                txtQuantity.ReadOnly = false;
                cboCategoryID.Enabled = true;
                cboStatusID.Enabled = true;

                btnAdd.Text = "Save";
                btnUpdate.Text = "Cancel";

                txtSearchValue.ReadOnly = true;
                btnSearch.Enabled = false;
                btnRefresh.Enabled = false;
                btnAvailable.Enabled = false;

                lbCate.Show();
                cboCategoryID.Show();
            }
            else if(btnUpdate.Text.Equals("Cancel"))
            {
                txtProductID.Enabled = false;
                txtProductID.ReadOnly = true;
                txtProductName.ReadOnly = true;
                txtPrice.ReadOnly = true;
                txtQuantity.ReadOnly = true;
                cboCategoryID.Enabled = false;
                cboStatusID.Enabled = false;

                btnAdd.Text = "Add";
                btnUpdate.Text = "Update";

                dgvProductList.Enabled = true;
                LoadAllProductList();

                txtSearchValue.ReadOnly = false;
                btnSearch.Enabled = true;
                btnRefresh.Enabled = true;
                btnAvailable.Enabled = true;

                lbCate.Hide();
                lbStatus.Hide();
                cboCategoryID.Hide();
                cboStatusID.Hide();
            }
        }
    }
}

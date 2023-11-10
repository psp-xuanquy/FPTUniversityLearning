using BusinessObject.Models;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Media;
using System.Windows.Forms;

namespace ConvenienceStoreApp
{
    public partial class ucOrder : UserControl
    {
        class DataGridViewOrderDetailObject
        {
            public string ProductId { get; set; }
            public string ProductName { get; set; }
            public int? Quantity { get; set; }
        }

        class DataGridViewProductObject
        {
            public string ProductId { get; set; }
            public string ProductName { get; set; }
            public int? Quantity { get; set; }
            public double? Price { get; set; }
            public string Category { get; set; }
        }

        IOrderRepository orderRepository = new OrderRepository();
        IOrderDetailRepository orderDetailRepository = new OrderDetailRepository();
        IProductRepository productRepository = new ProductRepository();
        IStaffRepository staffRepository = new StaffRepository();
        prn211group4Context context = new prn211group4Context();

        Guid orderId;
        List<TblOrderDetail> orderDetails = new List<TblOrderDetail>();
        List<TblProduct> products = new List<TblProduct>();
        List<TblCategory> categories = new List<TblCategory>();

        public TblStaff loggedStaff { get; set; }
        //Dictionary<TblProduct, Int32> orderList = new Dictionary<TblProduct, Int32>();

        public ucOrder()
        {
            InitializeComponent();
        }

        //----------------------------------Product---------------------------------------------------
        private void RefreshProductDatabase()
        {
            products = productRepository.GetAllProduct();
            RefreshProductLocal();
        }

        private void RefreshProductLocal()
        {
            List<TblProduct> showProducts = new List<TblProduct>();
            showProducts = products.Where(p => p.Quantity > 0).ToList();
            UpdateGridViewProducts(showProducts);
        }

        private void SearchProducts(string productName, string categoryValue)
        {
            try
            {
                List<TblProduct> searchResult = new List<TblProduct>();
                searchResult = products.FindAll(prod => prod.ProductName.Contains(productName, StringComparison.OrdinalIgnoreCase) && prod.Quantity > 0);

                if (categoryValue != null && categoryValue != "All")
                {
                    string catId = context.TblCategories.SingleOrDefault(c => c.CategoryName == categoryValue).CategoryId;
                    searchResult = searchResult.Where(p => p.CategoryId == catId).ToList();
                }

                UpdateGridViewProducts(searchResult);
            }
            catch (Exception ex)
            {

            }
        }

        private void UpdateGridViewProducts(List<TblProduct> products)
        {
            List<DataGridViewProductObject> listObj = products
                .Select(o => new DataGridViewProductObject()
                {
                    ProductId = o.ProductId,
                    ProductName = o.ProductName,
                    Quantity = o.Quantity,
                    Price = o.Price,
                    Category = context.TblCategories.SingleOrDefault(c => c.CategoryId == o.CategoryId).CategoryName ?? "Undefined"

                }).ToList();

            dgvProducts.DataSource = null;
            dgvProducts.DataSource = listObj;
        }

        //----------------------------------OrderDetail---------------------------------------------------
        private void RefreshOrderLocal()
        {
            try
            {
                double total = CalculateTotal();
                UpdateGridViewOrder(orderDetails);
            }
            catch
            {
                return;
            }




        }
        int? oldIndex = null;

        private void UpdateGridViewOrder(List<TblOrderDetail> orderDetails)
        {
            using (var row = dgvOrderDetails.CurrentRow)
            {
                if (row != null)
                {
                    oldIndex = row.Index;
                }
            }

            List<DataGridViewOrderDetailObject> listObj = orderDetails
                .Select(o => new DataGridViewOrderDetailObject()
                {
                    ProductId = o.ProductId,
                    ProductName = products.Single(pr => pr.ProductId == o.ProductId).ProductName,
                    Quantity = o.Quantity,
                }).ToList();

            //dgvOrderDetails.DataSource = null;
            dgvOrderDetails.DataSource = listObj;
            dgvOrderDetails.ClearSelection();

            if (oldIndex != null && oldIndex >= 0 && orderDetails.Count > 0)
            {
                using (var row = dgvOrderDetails.Rows[(int)oldIndex])
                {
                    if (row != null)
                    {
                        dgvOrderDetails.CurrentCell = row.Cells[0];
                    }
                }
            }
        }

        //-----------------------------------Load and Miscs-----------------------------------------------------------
        private double CalculateTotal()
        {
            double total = 0;
            if (orderDetails.Count > 0)
            {
                orderDetails.ForEach(od => total += (double)od.TotalPrice);
            }
            lblTotalPrice.Text = total.ToString();
            return total;
        }

        private void GenerateNewOrder()
        {
            // Clean out orderDetails
            orderDetails.Clear();
            RefreshOrderLocal();
            txtCustomerName.Text = "";

            // Refresh Product Lists
            RefreshProductDatabase();

            // Get a new Guid
            orderId = Guid.NewGuid();

            // Generate Guid until it unique
            while (null != orderRepository.GetByID(orderId))
            {
                orderId = Guid.NewGuid();
            }

            cboPaymentMethod.SelectedIndex = 0;
            cboCategory.Items.Clear();
            categories = context.TblCategories.ToList<TblCategory>();
            cboCategory.Items.Add("All");
            categories.ForEach(cat => cboCategory.Items.Add(cat.CategoryName));
            cboCategory.SelectedIndex = 0;

            lblOrderId.Text = $"Order Id: {orderId.ToString()}";
            rtbAction.Text = $"New Order";
        }

        private void ChangeButtonState()
        {
            // Order Detail Button
            if (orderDetails.Count == 0)
            {
                btnPlus.Enabled = false;
                btnMinus.Enabled = false;
                btnRemove.Enabled = false;
                btnCheckout.Enabled = false;
            }
            else
            {
                btnPlus.Enabled = true;
                btnMinus.Enabled = true;
                btnRemove.Enabled = true;
                btnCheckout.Enabled = true;
            }
        }

        private void Order_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                GenerateNewOrder();
                ChangeButtonState();
                // Get ME :D
                loggedStaff = staffRepository.GetCurrentAccount();
            }
        }

        //----------------------------------------Normal Event----------------------------------------------------

        private TblProduct GetCurrentProduct()
        {
            TblProduct product = null;
            try
            {
                var obj = dgvProducts.CurrentRow;
                if (null != obj)
                {
                    var row = obj.DataBoundItem;
                    DataGridViewProductObject dataObj = (DataGridViewProductObject)row;
                    product = products.SingleOrDefault(p => p.ProductId.Equals(dataObj.ProductId));
                }
            }
            catch (Exception)
            {
                MessageBox.Show($"Missing Data", "Order - Get Product", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return product;
        }

        private TblOrderDetail GetCurrentOrderDetail()
        {
            TblOrderDetail orderDetail = null;
            try
            {
                var obj = dgvOrderDetails.CurrentRow;
                if (null != obj)
                {
                    var row = obj.DataBoundItem;
                    DataGridViewOrderDetailObject dataObj = (DataGridViewOrderDetailObject)row;
                    orderDetail = orderDetails.SingleOrDefault(o => o.ProductId.Equals(dataObj.ProductId));
                }
            }
            catch (Exception)
            {
                MessageBox.Show($"Missing Data", "Order - Get Order", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return orderDetail;
        }

        //-----------------------------------------------------------------------------------------------------
        private void TryAddProduct()
        {


            try
            {
                TblProduct product = GetCurrentProduct();
                int quantity = (int)txtQuantity.Value;

                // Get Product Successfully
                if (product != null)
                {
                    TblOrderDetail od = orderDetails.SingleOrDefault(p => p.ProductId == product.ProductId);
                    //TblOrderDetail od = orderList.GetValueOrDefault(product);
                    // Order doesn't contains product
                    if (od == null)
                    {
                        TblOrderDetail newOd = new()
                        {
                            OrderId = orderId,
                            ProductId = product.ProductId,
                            Quantity = 0,
                            TotalPrice = product.Price,
                        };

                        int newQuantity = (int)(newOd.Quantity + quantity);
                        // Check Quantity
                        if (newQuantity > product.Quantity)
                        {
                            MessageBox.Show($"There isn't enough product to be added!{Environment.NewLine}[{product.ProductName}'s left : {product.Quantity}]", "Order - Add Product", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            newOd.Quantity = newQuantity;
                            newOd.TotalPrice = product.Price * newQuantity;
                            orderDetails.Add(newOd);
                            rtbAction.Text = $"Added {quantity} {product.ProductName}";
                        }
                    }
                    // Order contains product
                    else
                    {
                        int newQuantity = (int)(od.Quantity + quantity);

                        // New quanity exceed product's quantity
                        if (newQuantity > product.Quantity)
                        {
                            MessageBox.Show($"There isn't enough product to be added!{Environment.NewLine}[{product.ProductName}'s left : {product.Quantity}]", "Order - Add Product", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        // Quantity enough
                        else
                        {
                            od.Quantity = newQuantity;
                            od.TotalPrice = product.Price * newQuantity;
                            rtbAction.Text = $"Added {quantity} {product.ProductName}";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Order - Add Product", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                txtQuantity.Value = 1;
                RefreshOrderLocal();
                ChangeButtonState();
            }

        }

        private void TryRemoveOrderDetail()
        {
            TblOrderDetail orderDetail = GetCurrentOrderDetail();
            try
            {
                if (null != orderDetail)
                {
                    TblProduct product = products.SingleOrDefault(p => p.ProductId.Equals(orderDetail.ProductId));
                    int? newQuantity = orderDetail.Quantity - 1;
                    if (newQuantity == 0)
                    {
                        orderDetails.Remove(orderDetail);
                        rtbAction.Text = $"Removed {product.ProductName}";
                        RefreshOrderLocal();
                    }
                    else
                    {
                        orderDetail.Quantity = newQuantity;
                        orderDetail.TotalPrice = product.Price * newQuantity;
                        rtbAction.Text = $"Removed 1 {product.ProductName}";
                        RefreshOrderLocal();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Order - Remove 1 Product", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ChangeButtonState();
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshProductDatabase();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            TryAddProduct();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            TblOrderDetail orderDetail = GetCurrentOrderDetail();
            try
            {
                if (null != orderDetail)
                {
                    orderDetails.Remove(orderDetail);
                    TblProduct product = products.SingleOrDefault(p => p.ProductId.Equals(orderDetail.ProductId));
                    rtbAction.Text = $"Removed {product.ProductName}";
                    RefreshOrderLocal();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Order - Remove Product", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ChangeButtonState();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            TblOrderDetail orderDetail = GetCurrentOrderDetail();
            try
            {
                if (null != orderDetail)
                {
                    TblProduct product = products.SingleOrDefault(p => p.ProductId.Equals(orderDetail.ProductId));
                    if ((orderDetail.Quantity + 1) <= product.Quantity)
                    {
                        int? newQuantity = orderDetail.Quantity + 1;
                        orderDetail.Quantity = newQuantity;
                        orderDetail.TotalPrice = product.Price * newQuantity;
                        rtbAction.Text = $"Added 1 {product.ProductName}";
                        RefreshOrderLocal();
                    }
                    else
                    {
                        {
                            MessageBox.Show($"There isn't enough product to be added!{Environment.NewLine}[{product.ProductName}'s left : {product.Quantity}]", "Order - Add 1 Product", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Order - Add 1 Product", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ChangeButtonState();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            TryRemoveOrderDetail();
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            string paymentMethod = (string)(cboPaymentMethod.SelectedItem ?? "Cash");

            DialogResult f = MessageBox.Show("Do you want to checkout", "Checkout", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (f == DialogResult.OK)
            {
                RefreshProductDatabase();

                bool isEnough = true;

                foreach (var od in orderDetails)
                {
                    if (od.Quantity > products.Single(p => p.ProductId == od.ProductId).Quantity)
                    {
                        isEnough = false;
                    }
                }

                if (isEnough)
                {
                    if (orderDetails.Count > 0)
                    {
                        TblOrder checkoutOrder = new()
                        {
                            OrderId = orderId,
                            StaffId = loggedStaff.StaffId,
                            CustomerName = txtCustomerName.Text,
                            Date = DateTime.Now,
                            OrderPrice = CalculateTotal(),
                            StatusId = "CheckedOut",
                            PaymentMethod = paymentMethod,
                        };

                        orderRepository.Add(checkoutOrder);

                        // Just make sure products is up to date
                        RefreshProductDatabase();

                        foreach (TblOrderDetail od in orderDetails)
                        {
                            orderDetailRepository.Add(od);

                            // Get Product out and ready to update
                            TblProduct product = products.Single(p => p.ProductId == od.ProductId);
                            product.Quantity -= od.Quantity;
                            productRepository.Update(product);
                        }

                        ucBill uch = new ucBill()
                        {
                            order = checkoutOrder,
                            orderDetails = orderDetails,
                            loggedStaff = loggedStaff,
                            customerName = txtCustomerName.Text,
                            products = products,
                        };

                        uch.Show();
                        SystemSounds.Beep.Play();
                        GenerateNewOrder();
                    }
                    else
                    {
                        MessageBox.Show($"You must first add item before checkout!", "Order - Checkout", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    ChangeButtonState();
                }
                else
                {
                    // Database unsycned
                    MessageBox.Show($"Products is not enough under database!", "Order - Checkout", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    foreach (var od in orderDetails.ToList())
                    {
                        TblProduct prod = products.Single(p => p.ProductId == od.ProductId);
                        if (od.Quantity > prod.Quantity)
                        {
                            if (((int)prod.Quantity) == 0)
                            {
                                orderDetails.RemoveAll(odTotalPrice => od.ProductId == prod.ProductId);
                            }
                            else
                            {
                                od.Quantity = prod.Quantity;
                            }
                        }
                    }
                    RefreshOrderLocal();
                    ChangeButtonState();
                }


            }
        }

        private void dgvProducts_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            TryAddProduct();
        }

        private void dgvOrderDetails_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            TryRemoveOrderDetail();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            String searchValue = txtSearch.Text;
            String categoryValue = (string)cboCategory.SelectedItem ?? "ALL";
            SearchProducts(searchValue, categoryValue);

        }
        private void cboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            String searchValue = txtSearch.Text ?? "";
            String categoryValue = (string)cboCategory.SelectedItem ?? "ALL";
            SearchProducts(searchValue, categoryValue);
        }
    }
}

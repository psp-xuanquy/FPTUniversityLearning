using BusinessObject.Models;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConvenienceStoreApp
{
    public partial class ucBill : Form
    {
        class DataGridCheckoutObject
        {
            public string ProductName { get; set; }
            public double? ProductPrice { get; set; }
            public int? Quantity { get; set; }
            public double? Total { get; set; }
        }

        public TblOrder order { get; set; }
        public List<TblOrderDetail> orderDetails { get; set; }
        public TblStaff loggedStaff { get; set; }
        public String customerName { get; set; }
        public List<TblProduct> products = new List<TblProduct>();

        public ucBill()
        {
            InitializeComponent();
        }

        private double CalculateTotal()
        {
            double total = 0;
            orderDetails.ForEach(od => total += (double) od.TotalPrice);
            return total;
        }

        private void parseAllText()
        {
            lblOrderIdValue.Text = orderDetails.First().OrderId.ToString();
            lblTotalValue.Text = CalculateTotal().ToString();

            lblCustomerName.Text = customerName;
            lblDateValue.Text = order.Date.ToString();
        }

        private void UpdateGridView()
        {
            List<DataGridCheckoutObject> dataObj = new List<DataGridCheckoutObject>();
            orderDetails.ForEach(od =>
            {
                TblProduct prod = products.Single(p => p.ProductId == od.ProductId);
                dataObj.Add(new()
                {
                    ProductName = prod.ProductName,
                    ProductPrice = prod.Price,
                    Quantity = od.Quantity,
                    Total = od.TotalPrice
                });
            });

            dgvOrderDetails.DataSource = null;
            dgvOrderDetails.DataSource = dataObj;
        }

        private void ucBill_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                parseAllText();
                UpdateGridView();
            }
        }
    }
}

using BusinessObject.Models;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConvenienceStoreApp
{
    public partial class ucSelfOrdersView : UserControl
    {
        class DataGridViewOrderDetailObject
        {
            public string ProductName { get; set; }
            public double? ProductPrice { get; set; }
            public int? Quantity { get; set; }
            public double? Total { get; set; }
        }

        class DataGridViewOrderObject
        {
            public Guid OrderId { get; set; }
            public string CustomerName { get; set; }
            public DateTime? Date { get; set; }
            public double? OrderPrice { get; set; }
            public string StatusId { get; set; }
            public string PaymentMethod { get; set; }
        }

        IOrderRepository orderRepository = new OrderRepository();
        IOrderDetailRepository orderDetailRepository = new OrderDetailRepository();
        IProductRepository productRepository = new ProductRepository();
        IStaffRepository staffRepository = new StaffRepository();

        public TblStaff loggedStaff { get; set; }

        private List<TblProduct> products;
        private List<TblOrder> orders;
        private Dictionary<Guid, List<TblOrderDetail>> orderDetailsCache = new Dictionary<Guid, List<TblOrderDetail>>();

        // -----------------------------------------------------------------------------------------------------------

        private void RefreshOrderDatabase()
        {
            orders = orderRepository.GetAll();
            RefreshOrderLocal();
        }

        private void RefreshOrderLocal()
        {
            orders = orders.Where(o => o.StaffId == loggedStaff.StaffId).ToList();
            orders = orders.OrderBy(o => o.Date).ToList();

            if (orders.Count > 0)
            {
                dtpStart.Value = (DateTime)orders.First().Date;
                dtpEnd.Value = (DateTime)orders.Last().Date;
            }


            UpdateGridViewOrder(orders);
        }

        private void RefreshOrderLocalInDateRange(DateTime start, DateTime end)
        {
            List<TblOrder> ordersShow = new List<TblOrder>();
            ordersShow = orders.Where(o => o.StaffId == loggedStaff.StaffId
            && ((DateTime) o.Date).Date >= start.Date
            && ((DateTime) o.Date).Date <= end.Date).ToList();

            ordersShow = ordersShow.OrderBy(o => o.Date).ToList();

            UpdateGridViewOrder(ordersShow);
        }

        private void UpdateGridViewOrder(List<TblOrder> orders)
        {
            double total = 0d;
            orders.ForEach(o => total += (double)o.OrderPrice);
            lblTotalValue.Text = total.ToString();

            List<DataGridViewOrderObject> dataObj = orders.Select(o => new DataGridViewOrderObject()
            {
                OrderId = o.OrderId,
                CustomerName = o.CustomerName,
                Date = o.Date,
                OrderPrice = o.OrderPrice,
                StatusId = o.StatusId,
                PaymentMethod = o.PaymentMethod
            }).ToList();

            dgvOrder.DataSource = null;
            dgvOrder.DataSource = dataObj;
        }


        // -----------------------------------------------------------------------------------------------------------
        private void RefreshOrderDetailCache()
        {
            List<TblOrderDetail> orderDetails;
            TblOrder currentSelectedOrder = GetCurrentOrder();
            if (currentSelectedOrder != null)
            {
                if (orderDetailsCache.ContainsKey(currentSelectedOrder.OrderId))
                {
                    orderDetails = orderDetailsCache.GetValueOrDefault(currentSelectedOrder.OrderId);
                }
                else
                {
                    orderDetails = orderDetailRepository.GetListByID(currentSelectedOrder.OrderId);
                }

                UpdateGridViewOrderDetail(orderDetails);
            }
        }

        private void UpdateGridViewOrderDetail(List<TblOrderDetail> orderDetails)
        {
            lblOrderTotal.Text = orders.Single(o => o.OrderId == orderDetails.First().OrderId).OrderPrice.ToString();

            List<DataGridViewOrderDetailObject> dataObj = new List<DataGridViewOrderDetailObject>();
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
        
        // -----------------------------------------------------------------------------------------------------------
        private TblOrder GetCurrentOrder()
        {
            TblOrder order = null;
            try
            {
                Object obj = dgvOrder.CurrentRow.DataBoundItem;
                if (null != obj)
                {
                    DataGridViewOrderObject dataObj = (DataGridViewOrderObject)obj;
                    order = orders.SingleOrDefault(o => o.OrderId.Equals(dataObj.OrderId));
                }
            }
            catch (Exception)
            {
                MessageBox.Show($"Missing Data", "Order Self View - Get Order", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return order;
        }
        // -----------------------------------------------------------------------------------------------------------
        public ucSelfOrdersView()
        {
            InitializeComponent();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshOrderDatabase();
        }

        private void ucSelfOrdersView_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                products = productRepository.GetAllProduct();
                loggedStaff = staffRepository.GetCurrentAccount();
                RefreshOrderDatabase();
            }
        }

        private void dgvOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            RefreshOrderDetailCache();
        }

        private void dtpStart_ValueChanged(object sender, EventArgs e)
        {
            if (dtpStart.Value > dtpEnd.Value)
            {
                dtpEnd.Value = dtpStart.Value;
            }
            RefreshOrderLocalInDateRange(dtpStart.Value, dtpEnd.Value);

        }

        private void dtpEnd_ValueChanged(object sender, EventArgs e)
        {
            if (dtpEnd.Value < dtpStart.Value)
            {
                dtpStart.Value = dtpEnd.Value;
            }
            RefreshOrderLocalInDateRange(dtpStart.Value, dtpEnd.Value);
        }
    }
}

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
    public partial class OrderManagement : UserControl
    {
        IOrderRepository OrderRepository = new OrderRepository();
        BindingSource source;
        public OrderManagement()
        {
            InitializeComponent();
        }

        public void ClearText()
        {
            txtStaffID.Text = "";
            txtOrderDate.Text = "";
            txtPrice.Text = "";
            txtStatus.Text = "";
        }

        public void LoadOrderList()
        {
            List<TblOrder> listOrder = new List<TblOrder>();
            try
            {
                listOrder = OrderRepository.GetAll();
                List<object> viewOrderList = new List<object>();
                listOrder.ForEach(order => viewOrderList.Add(new
                {
                    OrderId = order.OrderId,
                    StaffId = order.StaffId,
                    CustomerName = order.CustomerName,
                    Date = order.Date,
                    OrderPrice = order.OrderPrice,
                    StatusId = order.StatusId,
                    PaymentMethod = order.PaymentMethod,
                }));

                source = new BindingSource();
                source.DataSource = viewOrderList;


                txtStaffID.DataBindings.Clear();
                txtOrderDate.DataBindings.Clear();
                txtPrice.DataBindings.Clear();
                txtStatus.DataBindings.Clear();

                txtStaffID.DataBindings.Add("Text", source, "StaffId");
                txtOrderDate.DataBindings.Add("Text", source, "Date");
                txtPrice.DataBindings.Add("Text", source, "OrderPrice");
                txtStatus.DataBindings.Add("Text", source, "StatusId");

                dgvOrders.DataSource = null;
                dgvOrders.DataSource = source;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load order list");
            }
        }

        public void LoadOrderListWithData(List<TblOrder> listOrder)
        {
            try
            {
                List<object> viewOrderList = new List<object>();
                listOrder.ForEach(order => viewOrderList.Add(new
                {
                    OrderId = order.OrderId,
                    StaffId = order.StaffId,
                    CustomerName = order.CustomerName,
                    Date = order.Date,
                    OrderPrice = order.OrderPrice,
                    StatusId = order.StatusId,
                    PaymentMethod = order.PaymentMethod,
                }));

                source = new BindingSource();
                source.DataSource = viewOrderList;

                dgvOrders.DataSource = null;
                dgvOrders.DataSource = source;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load order list");
            }
        }

        public TblOrder GetOrderObject()
        {
            TblOrder order = null;
            try
            {
                order = (TblOrder)dgvOrders.CurrentRow.DataBoundItem;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get order information");
            }
            return order;
        }

        private void OrderManagement_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                ClearText();
                LoadOrderList();
                cboType.SelectedIndex = 0;
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<TblOrder> listOrder = new List<TblOrder>();
            try
            {
                if (cboType.SelectedItem.ToString().Equals("Order ID"))
                {
                    TblOrder order = OrderRepository.GetByID(Guid.Parse(txtSearch.Text));
                    listOrder.Add(order);

                }
                else if (cboType.SelectedItem.ToString().Equals("Staff ID"))
                {
                    listOrder = OrderRepository.GetByStaff(txtSearch.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Search orders");
            }
            finally
            {
                LoadOrderListWithData(listOrder);
            }

        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            ClearText();
            LoadOrderList();
        }

        private void dgvOrders_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnViewDetail_Click(object sender, EventArgs e)
        {
            Guid orderID = Guid.Parse(dgvOrders.CurrentRow.Cells[0].Value.ToString());
            OrderInfo orderInfo = new OrderInfo()
            {
                OrderInformation = OrderRepository.GetByID(orderID)
            };

            orderInfo.Show();
        }
    }
}

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
    public partial class OrderInfo : Form
    {
        IOrderDetailRepository OrderDetailRepository = new OrderDetailRepository();
        BindingSource source;
        public TblOrder OrderInformation { get; set; }
        public OrderInfo()
        {
            InitializeComponent();
        }

        public void LoadOrderInformation()
        {
            txtOrderID.Text = OrderInformation.OrderId.ToString();
            txtOrderDate.Text = OrderInformation.Date.ToString();
            txtPayment.Text = OrderInformation.PaymentMethod;
            txtPrice.Text = OrderInformation.OrderPrice.ToString();
            txtStaffID.Text = OrderInformation.StaffId;
            txtStatus.Text = OrderInformation.StaffId;

        }

        public void LoadOrderDetailsInformation()
        {
            List<TblOrderDetail> listOrderDetail = null;
            try
            {
                listOrderDetail = OrderDetailRepository.GetListByID(OrderInformation.OrderId);
                List<object> viewOrderList = new List<object>();
                listOrderDetail.ForEach(orderDetail => viewOrderList.Add(new
                {
                    ProductID = orderDetail.ProductId,
                    Quantity = orderDetail.Quantity,
                    TotalPrice = orderDetail.TotalPrice
                }));

                source = new BindingSource();
                source.DataSource = viewOrderList;

                dgvDetails.DataSource = null;
                dgvDetails.DataSource = source;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load Order Detail");
            }
            source = new BindingSource();
            source.DataSource = OrderInformation;

            txtOrderID.DataBindings.Clear();
            txtOrderDate.DataBindings.Clear();
            txtPayment.DataBindings.Clear();
            txtPrice.DataBindings.Clear();
            txtStaffID.DataBindings.Clear();
            txtStatus.DataBindings.Clear();

            txtOrderID.DataBindings.Add("Text", source, "OrderId");
            txtOrderDate.DataBindings.Add("Text", source, "date");
            txtPayment.DataBindings.Add("Text", source, "PaymentMethod");
            txtPrice.DataBindings.Add("Text", source, "OrderPrice");
            txtStaffID.DataBindings.Add("Text", source, "StaffID");
            txtStatus.DataBindings.Add("Text", source, "StatusID");
        }

        private void OrderInfo_Load(object sender, EventArgs e)
        {
            LoadOrderInformation();
            LoadOrderDetailsInformation();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

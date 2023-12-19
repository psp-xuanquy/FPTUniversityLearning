using BSDAO;
using BSRepositories;
using BusinessObject.Models;
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
    public partial class OrderStatusManager : Form
    {
        private IOrderRepositories orderRepositories;
        public OrderStatusManager()
        {
            InitializeComponent();
            orderRepositories = new OrderRepository();
        }

        private void OrderStatusManager_Load(object sender, EventArgs e)
        {
            dtg_Pending.DataSource = orderRepositories.GetProductsIsPending();
            dtg_CancelRequest.DataSource = orderRepositories.GetProductsCancelled();
            dtg_Purchased.DataSource = orderRepositories.GetProductsPurchased();
        }

        private void dtg_Pending_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_ConfirmPending_Click(object sender, EventArgs e)
        {
            orderRepositories.OrderItemConfirmation(dtg_Pending.CurrentRow.Cells[0].Value.ToString());
            OrderStatusManager_Load(sender, e);
        }

        private void btn_CancelPending_Click(object sender, EventArgs e)
        {
            orderRepositories.OrderItemIsCancelling(dtg_Pending.CurrentRow.Cells[0].Value.ToString());
            OrderStatusManager_Load(sender, e);
        }

        private void btn_ConfirmCancellation_Click(object sender, EventArgs e)
        {
            orderRepositories.OrderItemIsCancelling(dtg_CancelRequest.CurrentRow.Cells[0].Value.ToString());
            OrderStatusManager_Load(sender, e);
        }

        private void btn_DenyCancellation_Click(object sender, EventArgs e)
        {
            orderRepositories.OrderItemDenyCancelling(dtg_CancelRequest.CurrentRow.Cells[0].Value.ToString());
            OrderStatusManager_Load(sender, e);
        }

        private void btn_Close_Click(object sender, EventArgs e) => Close();
    }
}

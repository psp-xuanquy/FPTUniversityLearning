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
    public partial class ViewOrders : Form
    {
        public ViewOrders()
        {
            InitializeComponent();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_Pending_Click(object sender, EventArgs e)
        {
            PendingOrders pendingOrders = new PendingOrders();
            this.Hide();
            pendingOrders.ShowDialog();
            this.Show();
        }

        private void btn_Purchased_Click(object sender, EventArgs e)
        {
            PurchasedOrders purchasedOrders = new PurchasedOrders();
            this.Hide();
            purchasedOrders.ShowDialog();
            this.Show();
        }
    }
}

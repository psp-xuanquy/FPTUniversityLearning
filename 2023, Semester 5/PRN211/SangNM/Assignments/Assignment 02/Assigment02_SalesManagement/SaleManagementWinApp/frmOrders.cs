using DataAccessObjects;
using System.Linq;
using System.Windows.Forms;

namespace SaleManagementWinApp
{
    public partial class frmOrders : Form
    {
        OrderDAO orderDAO = new OrderDAO();
        public frmOrders()
        {
            InitializeComponent();
            var list = orderDAO.GetAll().Select(p => new { p.OrderId, p.OrderDate, p.MemberId, p.RequiredDate, p.ShippedDate, p.Freight }).ToList();
            dgvListOrder.DataSource = list;
        }

        private void btnSearchOrder_Click(object sender, System.EventArgs e)
        {
            var list = orderDAO.GetAll().Where(p => p.OrderDate <= dtpEndDate.Value.Date && p.OrderDate >= dtpStartDate.Value.Date).ToList();
            if (list != null)
            {
                dgvListOrder.DataSource = list;
            }
            else
            {
                MessageBox.Show("Cannot Find Any Order. Please Try again !", "Notification", MessageBoxButtons.OK);
            }
        }
    }
}
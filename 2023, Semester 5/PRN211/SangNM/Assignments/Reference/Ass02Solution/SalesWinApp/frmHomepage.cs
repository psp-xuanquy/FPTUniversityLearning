using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesWinApp
{
    public partial class frmHomepage : Form
    {
        public frmHomepage()
        {
            InitializeComponent();
        }

        private void btLogOut_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void btMember_Click(object sender, EventArgs e)
        {
            frmMemberManagement frmMemberManagement = new frmMemberManagement();
            frmMemberManagement.Show();
            this.Close();
        }

        private void btProduct_Click(object sender, EventArgs e)
        {
            frmProductManagement frmProductManagement = new frmProductManagement(); 
            frmProductManagement.Show();
            this.Close();
        }

        private void btOrder_Click(object sender, EventArgs e)
        {
            frmOrderManagement frmOrderManagement = new frmOrderManagement();  
            frmOrderManagement.Show();
            this.Close();
        }
    }
}

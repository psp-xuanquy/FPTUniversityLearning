using Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirConditionerShop_DaoXuanQuy
{
    public partial class frmLogin : Form
    {
        IStaffMemberRepository _staffRepository = new StaffMemberRepository();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var tmp = _staffRepository.CheckLogin(txtUsername.Text, txtPassword.Text);
            if (tmp != null && tmp.Role == 1)
            {
                frmAirConditionerManagement f = new frmAirConditionerManagement();
                f.ShowDialog();
                this.Hide();
            }
            else
                MessageBox.Show("You have no permission to do this function!",
                    "Air Conditioner Management");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

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
    public partial class frmLogin : Form
    {
        IStaffRepository StaffRepository = new StaffRepository();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            if (null!=StaffRepository.Login(txtUsername.Text, txtPassword.Text))
            {
                TblStaff CurrentAccount = StaffRepository.GetCurrentAccount();
                Trace.WriteLine(CurrentAccount.ToString());
                frmMain frmMain = new frmMain
                {
                    frmLogin = this,
                    CurrentAccount = CurrentAccount
                };
                this.Hide();
                frmMain.Show();
            }
            else
            {
                MessageBox.Show("Email or Password not exist!");
            }
        }

        private void btnClose_Click(object sender, EventArgs e) => Application.Exit();

        //Moving form

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Form1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
    
}

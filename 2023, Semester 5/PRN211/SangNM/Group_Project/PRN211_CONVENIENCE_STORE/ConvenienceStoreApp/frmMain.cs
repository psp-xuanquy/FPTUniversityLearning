using BusinessObject.Models;
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
    public partial class frmMain : Form
    {
        public TblStaff CurrentAccount { get; set; }

        public frmLogin frmLogin;

        public int clickedBtn = 0;

        public frmMain()
        {
            InitializeComponent();

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            LoadOtherUI();
            LoadButtonUI();
            HideUC();
        }

        // Admin function1:
        private void button1_ADfunc1_Click(object sender, EventArgs e)
        {
            HlightBtn(1);
            orderManagement1.Show();
        }

        //Staff function1:
        private void button1_STfunc1_Click(object sender, EventArgs e)
        {
            HlightBtn(1);
            ucOrder1.Show();
        }

        private void button2_ADfunc2_Click(object sender, EventArgs e)
        {
            HlightBtn(2);
            ucStaffManagement1.Show();
        }

        private void button2_STfunc2_Click(object sender, EventArgs e)
        {
            HlightBtn(2);
            ucSelfOrdersView1.Show();
        }

        private void button3_ADfunc3_Click(object sender, EventArgs e)
        {
            HlightBtn(3);
            ucProductManagement1.Show();
        }


        private void btnLogout_Click(object sender, EventArgs e)
        {
            HlightBtn(5);
            DialogResult result = MessageBox.Show("Do you want to Logout?", "Logout", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                frmLogin.Show();
            }

        }


        private void btnClose_Click(object sender, EventArgs e) => Application.Exit();




        //----------------- UI Design -------------------//

        private void LoadOtherUI()
        {
            label_currentUser.Text = CurrentAccount.FullName;
            label_permission.Text = CurrentAccount.RoleId;
        }
        private void HideUC()
        {
            ucStaffManagement1.Hide();
            ucSelfOrdersView1.Hide();
            ucProductManagement1.Hide();
            orderManagement1.Hide();
            ucOrder1.Hide();
        }


        private void LoadButtonUI()
        {
            if (CurrentAccount.RoleId.Trim().Equals("AD"))
            {
                button1.Click += button1_ADfunc1_Click;
                button2.Click += button2_ADfunc2_Click;
                button3.Click += button3_ADfunc3_Click;
                button1.Text = "Orders History";
                button2.Text = "Staff Management";
                button3.Text = "Product Management";
                button1.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
            }
            if (CurrentAccount.RoleId.Trim().Equals("ST"))
            {
                button1.Click += button1_STfunc1_Click;
                button2.Click += button2_STfunc2_Click;
                button1.Text = "Order";
                button2.Text = "Self Orders History";
                button1.Visible = true;
                button2.Visible = true;
            }
        }

        private void HlightBtn(int i)
        {
            if (clickedBtn == i)
            {
                clickedBtn = 0;
            }
            else
            {
                clickedBtn = i;
                switch (i)
                {
                    case 1:
                        hlightBtn1.Visible = true;
                        hlightBtn2.Visible = false;
                        hlightBtn3.Visible = false;
                        hlightBtn5.Visible = false;
                        HideUC();

                        break;
                    case 2:
                        hlightBtn1.Visible = false;
                        hlightBtn2.Visible = true;
                        hlightBtn3.Visible = false;
                        hlightBtn5.Visible = false;
                        HideUC();

                        break;
                    case 3:
                        hlightBtn1.Visible = false;
                        hlightBtn2.Visible = false;
                        hlightBtn3.Visible = true;
                        hlightBtn5.Visible = false;
                        HideUC();

                        break;
                    case 5:
                        hlightBtn1.Visible = false;
                        hlightBtn2.Visible = false;
                        hlightBtn3.Visible = false;
                        hlightBtn5.Visible = true;
                        HideUC();

                        break;
                }
            }
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {

            hlightBtn1.Visible = true;

        }
        private void button1_MouseLeave(object sender, EventArgs e)
        {
            if (clickedBtn != 1)
            {
                hlightBtn1.Visible = false;
            }
        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            hlightBtn2.Visible = true;
        }
        private void button2_MouseLeave(object sender, EventArgs e)
        {
            if (clickedBtn != 2)
            {
                hlightBtn2.Visible = false;
            }
        }

        private void button3_MouseMove(object sender, MouseEventArgs e)
        {
            hlightBtn3.Visible = true;
        }
        private void button3_MouseLeave(object sender, EventArgs e)
        {
            if (clickedBtn != 3)
            {
                hlightBtn3.Visible = false;
            }
        }


        private void button5_MouseMove(object sender, MouseEventArgs e)
        {
            hlightBtn5.Visible = true;
        }
        private void button5_MouseLeave(object sender, EventArgs e)
        {
            if (clickedBtn != 5)
            {
                hlightBtn5.Visible = false;
            }
        }

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

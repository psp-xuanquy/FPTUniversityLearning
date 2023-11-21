using Giaolang.FAP.V2.Business;
using Giaolang.FAP.V2.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Giaolang.FAP.V2.StudentMgt
{
    public partial class Login : Form
    {

        //private IUserAccountRepository _acc;
        private UserAccountService service = new UserAccountService();
        public Login()
        {
            InitializeComponent();
            //khởi động đọc bảng User từ MySQL
            //_acc = new UserAccountRepositoryMySQL(); //TA CÓ DATA TỪ MYSQL CỦA
            //TABLE USERACCOUNT 

        }

        private void Authenticate(object sender, EventArgs e)
        {

            bool loginStatus = service.CheckLogin(txtUsername.Text, txtPassword.Text);
            if (loginStatus == false)
                MessageBox.Show("Invalid user/password!!!", "Wrong!!!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                ListStudents mainForm = new ListStudents();
                mainForm.Show();
                //this.Close(); ///giết cái app luôn
                this.Hide();
            }

        }

        //private void Authenticate(object sender, EventArgs e)
        //{

        //    UserAccount account = _acc.Search(txtUsername.Text);
        //    if (account != null)
        //    {
        //        if (account.Password != txtPassword.Text)
        //            MessageBox.Show("Invalid password!!!", "Wrong!!!",
        //                MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        else
        //        {
        //            ListStudents mainForm = new ListStudents();
        //            mainForm.Show();
        //            //this.Close(); ///giết cái app luôn
        //            this.Hide();
        //        }
        //    }
        //    else
        //        MessageBox.Show("Invalid username!!!", "Wrong!!!",
        //               MessageBoxButtons.OK, MessageBoxIcon.Error);


        //}
    }
}

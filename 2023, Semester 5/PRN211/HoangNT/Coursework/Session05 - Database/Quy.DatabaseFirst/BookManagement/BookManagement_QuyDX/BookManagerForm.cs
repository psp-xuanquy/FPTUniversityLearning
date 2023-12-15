using Microsoft.VisualBasic.Devices;
using Repositories.Entities;
using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManagement_QuyDX
{
    public partial class BookManagerForm : Form
    {
        //Form là 1 class như mọi class bth
        //Nhưng nó đc render thành cửa sổ
        //Xem như HTML

        private BookService _service = new BookService();

        public BookManagerForm()
        {
            InitializeComponent();
        }

        private void BookManagerForm_Load(object sender, EventArgs e)
        {
            //khi mở màn hình lên thì load data lên GridView
            dgvBooks.DataSource = null;
            dgvBooks.DataSource = _service.GetAllBooks();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<Book> result = _service.SearchBooks(txtKeyword.Text.ToLower());

            dgvBooks.DataSource = null;
            dgvBooks.DataSource = result;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

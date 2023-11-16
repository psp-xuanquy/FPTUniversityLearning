using Repositories;
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

namespace BookStore_HoangNT
{
    public partial class SunglassesManagerForm : Form
    {
        private SunglassesService _sunglassesService = new SunglassesService();
        private ManufacturerService _categoryService = new ManufacturerService();
        public SunglassesManagerForm()
        {
            InitializeComponent();
        }

        private void SunglassesManagerForm_Load(object sender, EventArgs e)
        {
            var result = _sunglassesService.GetAllBooks();
            dgvSunglassesList.DataSource = null;
            dgvSunglassesList.DataSource = result;
            dgvSunglassesList.Columns["BookCategory"].Visible = false;

            cboCategory.DataSource = _categoryService.GetAllCategories();
            cboCategory.DisplayMember = "BookGenreType";
            cboCategory.ValueMember = "BookCategoryId";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void SunglassesManagerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void dgvSunglassesList_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSunglassesList.SelectedRows.Count > 0)
            {
                var selectedBook = (Sunglass)dgvSunglassesList.SelectedRows[0].DataBoundItem;
                //có trong tay 1 object/1 cuốn sách đang được lựa chọn rồi
                //chấm từng field của nó đổ vào form
                txtId.Text = selectedBook.BookId.ToString();
                txtName.Text = selectedBook.BookName;
                txtDescription.Text = selectedBook.Description;
                dtpReleasedDate.Value = selectedBook.ReleaseDate;
                txtQuantity.Text = selectedBook.Quantity.ToString();
                txtPrice.Text = selectedBook.Price.ToString();
                cboCategory.SelectedValue = selectedBook.BookCategoryId;
                txtAuthor.Text = selectedBook.Author;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKeyword.Text))
            {
                MessageBox.Show("The search keyword is required!!!",
                    "Search keyword required",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var result = _sunglassesService.SearchBooks(txtKeyword.Text.Trim());

            dgvSunglassesList.DataSource = null;
            dgvSunglassesList.DataSource = result;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SunglassesForm sunglassesForm = new SunglassesForm();
            sunglassesForm.SunglassesId = null;
            sunglassesForm.ShowDialog();
            
            var result = _sunglassesService.GetAllBooks();
            dgvSunglassesList.DataSource = null;    
            dgvSunglassesList.DataSource = result;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id;
            if (string.IsNullOrWhiteSpace(txtId.Text) || !int.TryParse(txtId.Text, out id))
            {
                MessageBox.Show("The Book ID is invalid. Please select a row in the grid to edit or input a number!!!",
                    "Invalid Book ID",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            SunglassesForm sunglassesForm = new SunglassesForm();
            sunglassesForm.SunglassesId = null;
            sunglassesForm.ShowDialog();

            var result = _sunglassesService.GetAllBooks();
            dgvSunglassesList.DataSource = null;
            dgvSunglassesList.DataSource = result;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id;

            if (string.IsNullOrWhiteSpace(txtId.Text) || !int.TryParse(txtId.Text, out id))
            {
                MessageBox.Show("The Book ID is invalid. Please input a number!!!",
                    "Invalid Book ID",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            _sunglassesService.DeleteABook(id);

            //load cái danh sách Sách vào grid
            var result = _sunglassesService.GetAllBooks();
            dgvSunglassesList.DataSource = null;    //vip, xoá lưới, lấy danh sách mới
            dgvSunglassesList.DataSource = result;
        }
    }
}

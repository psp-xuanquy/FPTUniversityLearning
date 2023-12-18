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

namespace BookStore_DaoXuanQuy
{
    public partial class BookManagementForm : Form
    {

        private BookService _bookService = new BookService();
        private BookCategoryService _categoryService = new BookCategoryService();

        public BookManagementForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BookManagerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void BookManagerForm_Load(object sender, EventArgs e)
        {
            var result = _bookService.GetAllBooks();
            dgvBookList.DataSource = null;
            dgvBookList.DataSource = result;
            dgvBookList.Columns["BookCategory"].Visible = false;

            cboCategory.DataSource = _categoryService.GetAllCategories();
            cboCategory.DisplayMember = "BookGenreType";
            cboCategory.ValueMember = "BookCategoryId"; 
        }

        private void dgvBookList_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvBookList.SelectedRows.Count > 0)
            {
                var selectedBook = (Book)dgvBookList.SelectedRows[0].DataBoundItem;
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

            var result = _bookService.SearchBooks(txtKeyword.Text.Trim());

            if (result == null || result.Count == 0)
            {
                MessageBox.Show("No books found for the provided keyword.",
                    "No Results",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                dgvBookList.DataSource = null;
                dgvBookList.DataSource = result;
            }
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

            try
            {
                _bookService.DeleteABook(id);

                ClearInputFields();

                RefreshBookList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting book: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearInputFields()
        {
            txtId.Clear();
            txtName.Clear();
            txtDescription.Clear();
            dtpReleasedDate.Value = DateTime.Now;
            txtAuthor.Clear();
            txtQuantity.Clear();
            txtPrice.Clear();
            cboCategory.SelectedIndex = -1;
        }

        private void RefreshBookList()
        {
            var result = _bookService.GetAllBooks();
            dgvBookList.DataSource = null;
            dgvBookList.DataSource = result;
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

            var existingBook = _bookService.GetABook(id);
            if (existingBook == null)
            {
                MessageBox.Show("The selected book does not exist!",
                    "Book Not Found",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            BookForm bookForm = new BookForm();
            bookForm.BookId = int.Parse(txtId.Text);
            bookForm.ShowDialog();

            RefreshBookList();

            txtId.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            BookForm bookForm = new BookForm();
            bookForm.BookId = null;
            bookForm.ShowDialog();

            var result = _bookService.GetAllBooks();
            dgvBookList.DataSource = null;  
            dgvBookList.DataSource = result;
        }
    }
}

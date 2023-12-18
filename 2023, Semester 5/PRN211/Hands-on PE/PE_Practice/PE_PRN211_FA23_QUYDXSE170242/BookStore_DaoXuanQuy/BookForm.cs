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
    public partial class BookForm : Form
    {
        public int? BookId { get; set; }
        private BookService _bookService = new();
        private BookCategoryService _categoryService = new();

        public BookForm()
        {
            InitializeComponent();
        }

        private void BookForm_Load(object sender, EventArgs e)
        {

            cboCategory.DataSource = _categoryService.GetAllCategories();
            cboCategory.DisplayMember = "BookGenreType";
            cboCategory.ValueMember = "BookCategoryId";

            if (this.BookId != null)
            {
                var book = _bookService.GetABook((int)BookId);

                txtId.Text = book.BookId.ToString();
                txtName.Text = book.BookName;
                txtDescription.Text = book.Description;
                dtpReleasedDate.Value = book.ReleaseDate;
                txtQuantity.Text = book.Quantity.ToString();
                txtPrice.Text = book.Price.ToString();
                cboCategory.SelectedValue = book.BookCategoryId;
                txtAuthor.Text = book.Author;
                lblFormTitle.Text = "Update a Book...";
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
            {
                return;
            }

            Book book = new()
            {
                BookId = int.Parse(txtId.Text.Trim()),
                BookName = txtName.Text.Trim(),
                Description = txtDescription.Text.Trim(),
                ReleaseDate = dtpReleasedDate.Value.Date,
                Author = txtAuthor.Text.Trim(),
                Quantity = int.Parse(txtQuantity.Text.Trim()),
                Price = double.Parse(txtPrice.Text.Trim()),
                BookCategoryId = int.Parse(cboCategory.SelectedValue.ToString())
            };

            if (BookId != null)
                _bookService.UpdateABook(book);
            else
                _bookService.AddABook(book);

            Close();

        }

        private bool ValidateInput()
        {
            if (!int.TryParse(txtId.Text.Trim(), out _))
            {
                MessageBox.Show("Invalid Book ID. Please enter a valid numeric value.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Book Name cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
    }
}

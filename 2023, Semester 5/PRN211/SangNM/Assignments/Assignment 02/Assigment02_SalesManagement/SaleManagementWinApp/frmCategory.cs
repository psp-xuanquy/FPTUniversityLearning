using DataAccessObjects;
using Repositories.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleManagementWinApp
{

    public partial class frmCategory : Form
    {
        CategoryDAO categoryDAO = new CategoryDAO();
        public frmCategory()
        {
            InitializeComponent();
            var list = categoryDAO.GetAll().ToList();
            dgvCategory.DataSource = list;
        }

        private void CreateCategory(object sender, EventArgs e)
        {
            Category category = new Category();
            category.CategoryName = tbCategory.Text;
            categoryDAO.Create(category);
            MessageBox.Show("Category Added!");

            var list = categoryDAO.GetAll().ToList();
            dgvCategory.DataSource = list;
        }

        private void UpdateCategory(object sender, EventArgs e)
        {
            int categoryId = int.Parse(tbId.Text);
            string categoryName = tbCategory.Text.Trim();

            Category category = categoryDAO.GetAll().FirstOrDefault(p => p.CategoryId == categoryId);
            if (category == null)
            {
                MessageBox.Show("Can't find that category ID");
            }

            category.CategoryName = categoryName;
            categoryDAO.Update(category);

            MessageBox.Show("Category Updated!");


            var list = categoryDAO.GetAll().ToList();
            dgvCategory.DataSource = list;
        }

        private void DeleteCategory(object sender, EventArgs e)
        {
            int categoryId = int.Parse(tbId.Text.Trim());

            Category category = categoryDAO.GetAll().FirstOrDefault(p => p.CategoryId == categoryId);
            if (category == null)
            {
                MessageBox.Show("Can't find that category");
                return;
            }

            categoryDAO.Delete(category);
            MessageBox.Show("Category Deleted!");

            var list = categoryDAO.GetAll().ToList();
            dgvCategory.DataSource = list;

        }

        private void ClickCellShowContent(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var rowSelected = this.dgvCategory.Rows[e.RowIndex];
                tbId.Text = rowSelected.Cells["CategoryID"].Value.ToString();
                tbCategory.Text = rowSelected.Cells["CategoryName"].Value.ToString();
            }

            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;
        }
    }
}

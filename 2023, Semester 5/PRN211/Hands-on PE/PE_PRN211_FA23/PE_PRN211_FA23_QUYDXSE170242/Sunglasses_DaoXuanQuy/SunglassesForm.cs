using Repositories;
using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore_HoangNT
{
    public partial class SunglassesForm : Form
    {
        public int? SunglassId { get; set; }
        private SunglassesService _sunglassesService = new(); 
        private ManufacturerService _manufacturerService = new();

        public SunglassesForm()
        {
            InitializeComponent();
        }

        private void SunglassesForm_Load(object sender, EventArgs e)
        {
            cboCategory.DataSource = _manufacturerService.GetAllCategories();
            cboCategory.DisplayMember = "BookGenreType";
            cboCategory.ValueMember = "BookCategoryId";

            if (this.SunglassId != null)
            {
                var sunglass = _sunglassesService.GetABook((int)SunglassId);

                txtId.Text = sunglass.SunglassId.ToString();
                txtName.Text = sunglass.SunglassName;
                txtFeature.Text = sunglass.Feature;
                dtpCraetedDate.Value = sunglass.CreatedDate;
                txtQuantity.Text = sunglass.Quantity.ToString();
                txtPrice.Text = sunglass.Price.ToString();
                cboCategory.SelectedValue = sunglass.BookCategoryId;
                txtShape.Text = sunglass.Shape;
                lblFormTitle.Text = "Update a Book...";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Sunglass sunglass = new()
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

            if (SunglassId != null)
                _sunglassesService.UpdateABook(sunglass);
            else
                _sunglassesService.AddABook(sunglass);

            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

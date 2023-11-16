using Repositories;
using BusinessObject;

namespace AirConditionerShop_DaoXuanQuy
{
    public partial class frmAirConditionerManagement : Form
    {
        IAirConditionerRepository repo = new AirConditionerRepository();
        bool CreateOrUpdate = false;
        public frmAirConditionerManagement()
        {
            InitializeComponent();
        }
        private void frmAirConditionerManagement_Load(object sender, EventArgs e)
        {
            LoadSupplierCompanyList();
            LoadAirConditionerList();
            EnableText(false);
        }
        public void LoadSupplierCompanyList()
        {
            try
            {
                var categoryList = repo.GetSupplierCompanies();
                cboSupplierCompany.DataSource = categoryList;
                cboSupplierCompany.DisplayMember = "SupplierName";
                cboSupplierCompany.ValueMember = "SupplierID";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR on load list of categories");
            }
        }
        public void LoadAirConditionerList()
        {
            try
            {
                var aList = repo.GetAirConditioners();
                BindingSource source = new BindingSource();
                source.DataSource = aList;

                txtAirConditionerID.DataBindings.Clear();
                txtAirConditionerName.DataBindings.Clear();
                txtWarranty.DataBindings.Clear();
                txtSound.DataBindings.Clear();
                txtFeatureFunction.DataBindings.Clear();
                txtPrice.DataBindings.Clear();
                cboSupplierCompany.DataBindings.Clear();

                txtAirConditionerID.DataBindings.Add("Text", source, "AirConditionerID");
                txtAirConditionerName.DataBindings.Add("Text", source, "AirConditionerName");
                txtWarranty.DataBindings.Add("Text", source, "AirConditionerID");
                txtSound.DataBindings.Add("Text", source, "Warranty");
                txtFeatureFunction.DataBindings.Add("Text", source, "SoundPressureLevel");
                txtPrice.DataBindings.Add("Text", source, "DollarPrice");
                cboSupplierCompany.DataBindings.Add("Text", source, "Supplier.SupplierName");

                dgvList.DataSource = null;
                dgvList.DataSource = source;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR on load list of air conditioners");
            }
        }
        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            DialogResult d;
            d = MessageBox.Show("Do you really want to delete this record?", "Air Conditioner Management",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);

            if (d == DialogResult.OK)
            {
                var airConditioner = new AirConditioner
                {
                    AirConditionerID = int.Parse(txtAirConditionerID.Text),
                };
                repo.Delete(airConditioner);
                LoadAirConditionerList();
            }
        }
        private void btnNew_Click_1(object sender, EventArgs e)
        {
            if (btnNew.Text == "New")
            {
                btnNew.Text = "Cancel";
                btnSave.Enabled = true;
                EnableText(true);

                //Clear DataBinding
                txtAirConditionerID.DataBindings.Clear();
                txtAirConditionerName.DataBindings.Clear();
                txtWarranty.DataBindings.Clear();
                txtSound.DataBindings.Clear();
                txtFeatureFunction.DataBindings.Clear();
                txtPrice.DataBindings.Clear();
                cboSupplierCompany.DataBindings.Clear();
                dgvList.ClearSelection();

                ClearText();
                CreateOrUpdate = true;
            }
            else
            {
                btnNew.Text = "New";
                btnSave.Enabled = false;
                EnableText(false);
                LoadAirConditionerList();
            }
        }
        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (txtAirConditionerID.Text.Trim() == "" ||
                txtAirConditionerName.Text.Trim() == "" ||
                txtWarranty.Text.Trim() == "" ||
                txtSound.Text.Trim() == "" ||
                txtFeatureFunction.Text.Trim() == "" ||
                txtPrice.Text.Trim() == "")
            {
                MessageBox.Show("All fields are required!", "Air Conditioner Management System",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var airConditioner = new AirConditioner
                {
                    AirConditionerID = int.Parse(txtAirConditionerID.Text),
                    AirConditionerName = txtAirConditionerName.Text,
                    Warranty = txtWarranty.Text,
                    SoundPressureLevel = txtSound.Text,
                    FeatureFunction = txtFeatureFunction.Text,
                    DollarPrice = int.Parse(txtPrice.Text),
                    SupplierId = cboSupplierCompany.SelectedValue.ToString()
                };
                if (CreateOrUpdate) //create a new air conditioner
                {
                    repo.Save(airConditioner);
                    btnNew.Text = "New";
                }
                else
                {
                    repo.Update(airConditioner);
                    btnUpdate.Text = "Update";
                }
                EnableText(false);
                btnSave.Enabled = false;
                LoadAirConditionerList();
            }
        }
        private void ClearText()
        {
            txtAirConditionerID.Text = "";
            txtAirConditionerName.Text = "";
            txtWarranty.Text = "";
            txtSound.Text = "";
            txtFeatureFunction.Text = "";
            txtPrice.Text = "";
            cboSupplierCompany.SelectedIndex = 0;
        }
        private void EnableText(bool status)
        {
            txtAirConditionerID.Enabled = status;
            txtAirConditionerName.Enabled = status;
            txtWarranty.Enabled = status;
            txtSound.Enabled = status;
            txtFeatureFunction.Enabled = status;
            txtPrice.Enabled = status;
            cboSupplierCompany.Enabled = status;
        }
        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            EnableText(true);
            txtAirConditionerID.Enabled = false;

            btnUpdate.Text = "Cancel";
            btnSave.Enabled = true;
            CreateOrUpdate = false;
        }
        private void frmAirConditionerManagement_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult d;
            d = MessageBox.Show("Are you sure you want to exit?", "Air Conditioner Management",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);
            if (d == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess;
using DataAccess.Repository;
using BusinessObject.Models;
using System.Text.RegularExpressions;

namespace ConvenienceStoreApp
{
    public partial class ucStaffManagement : UserControl
    {
        public class DataGridViewStaffObject
        {
            public string StaffId { get; set; }
            public string FullName { get; set; }
            public string Address { get; set; }
            public string PhoneNumber { get; set; }
            public string Password { get; set; }
            public string RoleId { get; set; }
            public string StatusId { get; set; }
            public string Email { get; set; }
        }

        public ucStaffManagement()
        {
            InitializeComponent();
        }

        IStaffRepository repoStaff = new StaffRepository();
        BindingSource source;

        private void ucStaffManagement_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                LoadStaffList();
                txtStaffID.ReadOnly = true;
                txtFullname.ReadOnly = true;
                txtAddress.ReadOnly = true;
                txtPhoneNumber.ReadOnly = true;
                txtPassword.ReadOnly = true;
                cboRoleID.Enabled = false;
                cboStatusID.Enabled = false;
                txtEmail.ReadOnly = true;
            }
        }

        public void LoadStaffList()
        {
            List<TblStaff> staffs = null;
            List<DataGridViewStaffObject> staffsCut = new List<DataGridViewStaffObject>();

            try
            {
                staffs = repoStaff.GetAllStaff().OrderBy(staff => staff.StaffId).ToList();

                staffs.ForEach(staff => staffsCut.Add(new()
                {
                    FullName = staff.FullName,
                    Address = staff.Address,
                    Email = staff.Email,
                    Password = staff.Password,
                    PhoneNumber = staff.PhoneNumber,
                    RoleId = staff.RoleId,
                    StaffId = staff.StaffId,
                    StatusId = staff.StatusId,
                }));

                source = new BindingSource();
                source.DataSource = staffsCut;

                txtStaffID.DataBindings.Clear();
                txtFullname.DataBindings.Clear();
                txtAddress.DataBindings.Clear();
                txtPhoneNumber.DataBindings.Clear();
                txtPassword.DataBindings.Clear();
                cboRoleID.DataBindings.Clear();
                cboStatusID.DataBindings.Clear();
                txtEmail.DataBindings.Clear();

                txtStaffID.DataBindings.Add("Text", source, "StaffId");
                txtFullname.DataBindings.Add("Text", source, "Fullname");
                txtAddress.DataBindings.Add("Text", source, "Address");
                txtPhoneNumber.DataBindings.Add("Text", source, "PhoneNumber");
                txtPassword.DataBindings.Add("Text", source, "Password");
                cboRoleID.DataBindings.Add("Text", source, "RoleId");
                cboStatusID.DataBindings.Add("Text", source, "StatusId");
                txtEmail.DataBindings.Add("Text", source, "Email");

                dgvStaffList.DataSource = null;
                dgvStaffList.DataSource = source;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load Staff List", MessageBoxButtons.OK);
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string id = txtSearchStaffID.Text;
            string name = txtSearchStaffName.Text;
            TblStaff staff = null;
            List<TblStaff> staffs = new List<TblStaff>();
            try
            {
                if (!id.Trim().Equals("") && !name.Trim().Equals(""))
                {
                    staffs = repoStaff.SearchByIdAndName(id, name);
                    if (staffs.Count > 0)
                    {
                        source = new BindingSource();
                        source.DataSource = staffs;
                        dgvStaffList.DataSource = null;
                        dgvStaffList.DataSource = source;
                    }
                    else
                    {
                        MessageBox.Show("Not found", "Search", MessageBoxButtons.OK);
                        txtSearchStaffID.Clear();
                        txtSearchStaffName.Clear();
                        LoadStaffList();
                    }
                }
                else if (!id.Trim().Equals("") || !name.Trim().Equals(""))
                {
                    if (!name.Trim().Equals(""))
                    {
                        staffs = repoStaff.SearchByName(name);
                    }
                    else
                    {
                        staff = repoStaff.GetStaffByID(id);
                    }

                    if (staffs.Count == 0 && staff == null)
                    {
                        MessageBox.Show("Not found", "Search", MessageBoxButtons.OK);
                        txtSearchStaffID.Clear();
                        txtSearchStaffName.Clear();
                        LoadStaffList();
                    }
                    else
                    {
                        if (staff != null)
                        {
                            source = new BindingSource();
                            source.DataSource = staff;
                            dgvStaffList.DataSource = null;
                            dgvStaffList.DataSource = source;
                        }
                        else if (staffs.Count > 0)
                        {
                            source = new BindingSource();
                            source.DataSource = staffs;
                            dgvStaffList.DataSource = null;
                            dgvStaffList.DataSource = source;
                        }

                    }
                }
                else
                {
                    MessageBox.Show("Empty search input", "Search", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Search Staff", MessageBoxButtons.OK);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearchStaffID.Clear();
            txtSearchStaffName.Clear();
            LoadStaffList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (btnAdd.Text == "Add")
            {
                btnRefresh.Enabled = false;
                btnSearch.Enabled = false;
                txtSearchStaffID.ReadOnly = true;
                txtSearchStaffName.ReadOnly = true;

                dgvStaffList.ClearSelection();
                dgvStaffList.CurrentCell = null;

                txtStaffID.Clear();
                txtFullname.Clear();
                txtAddress.Clear();
                txtPhoneNumber.Clear();
                txtPassword.Clear();
                txtEmail.Clear();

                txtStaffID.DataBindings.Clear();
                txtFullname.DataBindings.Clear();
                txtAddress.DataBindings.Clear();
                txtPhoneNumber.DataBindings.Clear();
                txtPassword.DataBindings.Clear();
                cboRoleID.DataBindings.Clear();
                cboStatusID.DataBindings.Clear();
                txtEmail.DataBindings.Clear();

                txtStaffID.Enabled = true;
                txtStaffID.ReadOnly = false;
                txtFullname.ReadOnly = false;
                txtAddress.ReadOnly = false;
                txtPhoneNumber.ReadOnly = false;
                txtPassword.ReadOnly = false;
                cboRoleID.Enabled = true;
                cboStatusID.Enabled = false;
                txtEmail.ReadOnly = false;

                dgvStaffList.Enabled = false;

                btnAdd.Text = "Save";
                btnUpdate.Text = "Cancel";
            }
            else if (btnAdd.Text == "Save")
            {
                if (txtStaffID.Text.Trim().Equals("") || txtFullname.Text.Trim().Equals("") || txtAddress.Text.Trim().Equals("") || txtPhoneNumber.Text.Trim().Equals("") || txtPassword.Text.Trim().Equals("") || txtEmail.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Blank input are not allow", "Input error", MessageBoxButtons.OK);
                }
                else
                {
                    int parseValue;
                    Regex emailRegex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                    Match match = emailRegex.Match(txtEmail.Text.Trim());

                    if (repoStaff.GetStaffByID(txtStaffID.Text.Trim()) != null && txtStaffID.Enabled)
                    {
                        MessageBox.Show("ID already exist", "Input error", MessageBoxButtons.OK);
                    }
                    else if (!Regex.IsMatch(txtFullname.Text.Trim(), @"^[a-zA-Z ]+$"))
                    {
                        MessageBox.Show("Invalid name input", "Input error", MessageBoxButtons.OK);
                    }
                    else if (!int.TryParse(txtPhoneNumber.Text.Trim(), out parseValue) || txtPhoneNumber.Text.Trim().Length != 10)
                    {
                        MessageBox.Show("Invalid phone number input", "Input error", MessageBoxButtons.OK);
                    }
                    else if (txtPassword.Text.Length < 6)
                    {
                        MessageBox.Show("Password too weak. Please enter more than 6 character !", "Input error", MessageBoxButtons.OK);
                    }
                    else if (!match.Success)
                    {
                        MessageBox.Show("Invalid email", "Input error", MessageBoxButtons.OK);
                    }
                    else
                    {
                        try
                        {
                            TblStaff staff = new TblStaff
                            {
                                StaffId = txtStaffID.Text,
                                FullName = txtFullname.Text,
                                Address = txtAddress.Text,
                                PhoneNumber = txtPhoneNumber.Text,
                                Password = txtPassword.Text,
                                RoleId = cboRoleID.SelectedItem.ToString(),
                                StatusId = cboStatusID.SelectedItem.ToString(),
                                Email = txtEmail.Text,
                            };

                            if (txtStaffID.Enabled)
                            {
                                repoStaff.Add(staff);
                            }
                            else
                            {
                                repoStaff.Update(staff);
                            }

                            btnAdd.Text = "Add";
                            btnUpdate.Text = "Update";

                            txtStaffID.ReadOnly = true;
                            txtFullname.ReadOnly = true;
                            txtAddress.ReadOnly = true;
                            txtPhoneNumber.ReadOnly = true;
                            txtPassword.ReadOnly = true;
                            cboRoleID.Enabled = false;
                            cboStatusID.Enabled = false;
                            txtEmail.ReadOnly = true;

                            dgvStaffList.Enabled = true;

                            btnRefresh.Enabled = true;
                            btnSearch.Enabled = true;
                            txtSearchStaffID.ReadOnly = false;
                            txtSearchStaffName.ReadOnly = false;

                            LoadStaffList();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Add new staff", MessageBoxButtons.OK);
                        }
                    }
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (btnUpdate.Text == "Update")
            {
                btnRefresh.Enabled = false;
                btnSearch.Enabled = false;
                txtSearchStaffID.ReadOnly = true;
                txtSearchStaffName.ReadOnly = true;

                txtStaffID.Enabled = false;
                txtFullname.ReadOnly = false;
                txtAddress.ReadOnly = false;
                txtPhoneNumber.ReadOnly = false;
                txtPassword.ReadOnly = false;
                cboRoleID.Enabled = true;
                cboStatusID.Enabled = true;
                txtEmail.ReadOnly = false;

                btnAdd.Text = "Save";
                btnUpdate.Text = "Cancel";
            }
            else if (btnUpdate.Text == "Cancel")
            {
                btnRefresh.Enabled = true;
                btnSearch.Enabled = true;
                txtSearchStaffID.ReadOnly = false;
                txtSearchStaffName.ReadOnly = false;

                txtStaffID.Enabled = true;
                txtStaffID.ReadOnly = true;
                txtFullname.ReadOnly = true;
                txtAddress.ReadOnly = true;
                txtPhoneNumber.ReadOnly = true;
                txtPassword.ReadOnly = true;
                cboRoleID.Enabled = false;
                cboStatusID.Enabled = false;
                txtEmail.ReadOnly = true;

                dgvStaffList.Enabled = true;

                btnAdd.Text = "Add";
                btnUpdate.Text = "Update";

                LoadStaffList();
            }
        }
    }
}

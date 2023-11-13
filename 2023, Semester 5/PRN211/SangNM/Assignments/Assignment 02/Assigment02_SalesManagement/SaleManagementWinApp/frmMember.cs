using DataAccessObjects;
using Microsoft.VisualBasic.Devices;
using Repositories.Models;
using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SaleManagementWinApp
{
    public partial class frmMember : Form
    {
        MemberDAO memberDAO = new MemberDAO();
        public frmMember()
        {
            InitializeComponent();
            var list = memberDAO.GetAll()
                    .Select(p => new { p.MemberId, p.Email, p.Role, p.City, p.Country }).ToList();
            dgvMemberList.DataSource = list;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearchMember_Click(object sender, EventArgs e)
        {
            string keyword = tbSearch.Text.Trim().ToLower();
            var list = memberDAO.GetAll().Where(p => p.Email.ToLower().Contains(keyword))
                    .Select(p => new { p.MemberId, p.Email, p.Role, p.City, p.Country }).ToList();
            dgvMemberList.DataSource = list;
        }

        private void btnAddMember_Click(object sender, EventArgs e)
        {
            var member = new Member();
            memberDAO = new MemberDAO();
            member.MemberId = int.Parse(txtId.Text);
            if (memberDAO.GetAll().Where(p => p.MemberId.Equals(member.MemberId)).FirstOrDefault() != null)
            {
                MessageBox.Show("MemberId Existed ", "hello", MessageBoxButtons.OK);
                return;
            }
            member.MemberId = int.Parse(txtId.Text);
            member.Email = txtEmail.Text;
            member.Role = txtRole.Text;
            member.City = txtCity.Text;
            member.Country = txtCountry.Text;
            member.Password = "1";
            memberDAO.Create(member);
            MessageBox.Show("Member Added!");
        }

        private void btnDeleteMember_Click(object sender, EventArgs e)
        {
            var Id = int.Parse(txtId.Text);
            var obj = memberDAO.GetAll().Where(p => p.MemberId == Id).FirstOrDefault();
            memberDAO = new MemberDAO();
            if (obj != null)
            {
                var dialog = MessageBox.Show("Do you want to delete it?", "Warning", MessageBoxButtons.OKCancel);
                if (dialog == DialogResult.OK)
                {
                    memberDAO.Delete(obj);
                }
                else
                {
                    return;
                }
            }

            var list = memberDAO.GetAll().Select(p => new { p.MemberId, p.Email, p.Role, p.City, p.Country }).ToList();
            dgvMemberList.DataSource = list;
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int memberId = int.Parse(txtId.Text);
            memberDAO = new MemberDAO();
            var member = new Member();
            member.MemberId = memberId;
            member.Email = txtEmail.Text;
            member.Role = txtRole.Text;
            member.City = txtCity.Text;
            member.Country = txtCountry.Text;
            member.Password = "1";
            memberDAO.Update(member);

            var list = memberDAO.GetAll().Select(p => new { p.MemberId, p.Email, p.Role, p.City, p.Country }).ToList();
            dgvMemberList.DataSource = list;
        }

        private void clickCellShowInfo(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtId.Enabled = false;
                var rowSelected = this.dgvMemberList.Rows[e.RowIndex];
                txtId.Text = rowSelected.Cells["MemberId"].Value.ToString();
                txtEmail.Text = rowSelected.Cells["Email"].Value.ToString();
                txtRole.Text = rowSelected.Cells["Role"].Value.ToString();
                txtCity.Text = rowSelected.Cells["City"].Value.ToString();
                txtCountry.Text = rowSelected.Cells["Country"].Value.ToString();
            }
            //var obj = productsDAO.GetAll().Where(p => p.ProductId.Equals(productId)).FirstOrDefault();

            btnDeleteMember.Enabled = true;
            btnUpdate.Enabled = true;
        }
    }
}
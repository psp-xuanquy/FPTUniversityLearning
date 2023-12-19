using BSRepositories;
using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BSAPP
{
    public partial class NestManager : Form
    {
        private INestRepositories nestRepositories;
        private IBirdRepositories birdRepositories;
        public NestManager()
        {
            InitializeComponent();
            nestRepositories = new NestRepository();
            birdRepositories = new BirdRepository();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            try
            {
                int price = Convert.ToInt32(txt_price.Text);
                TbNest nest = new TbNest
                {
                    NestId = lb_Id.Text.Trim(),
                    BirdIdMale = txt_idmale.Text.Trim(),
                    BirdIdFemale = txt_idfemale.Text.Trim(),
                    Name = txt_name.Text.Trim(),
                    Description = txt_des.Text.Trim(),
                    Price = Convert.ToInt32(txt_price.Text),
                    Quantity = Convert.ToInt32(txt_quantity.Text),
                    BirdImage = txt_BirdImage.Text.Trim(),
                    BirdSpecies = cmb_type.Text.Trim(),
                    Status = Convert.ToBoolean(cmb_Status.Text)
                };

                nestRepositories.UpdateNest(nest);

                NestManager_Load(sender, e);

            }
            catch (Exception ex)
            {
                // Xử lý lỗi nếu có.
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            try
            {
                int price = Convert.ToInt32(txt_price.Text);

                TbNest nest = new TbNest
                {
                    NestId = "NEST" + Guid.NewGuid().ToString(),
                    BirdIdMale = txt_idmale.Text.Trim(),
                    BirdIdFemale = txt_idfemale.Text.Trim(),
                    Name = txt_name.Text.Trim(),
                    Description = txt_des.Text.Trim(),
                    Price = Convert.ToInt32(txt_price.Text),
                    Quantity = Convert.ToInt32(txt_quantity.Text),
                    BirdImage = txt_BirdImage.Text.Trim(),
                    BirdSpecies = cmb_type.Text.Trim(),
                    Status = false
                };

                nestRepositories.AddNest(nest);

                NestManager_Load(sender, e);

            }
            catch (Exception ex)
            {
                // Xử lý lỗi nếu có.
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                nestRepositories.DeleteNest(lb_Id.Text.Trim());

                NestManager_Load(sender, e);
            }
            catch
            {
                MessageBox.Show("Cannot Edit Pet");
            }
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void NestManager_Load(object sender, EventArgs e)
        {
            dtg_NestList.DataSource = nestRepositories.GetAllNests().Select(n => new { n.NestId, n.BirdIdMale, n.BirdIdFemale, n.BirdSpecies, n.Name, n.Description, n.Price, n.Quantity, n.BirdImage, n.Status }).ToList();

            dtg_BirdList.DataSource = birdRepositories.GetAllBirds().Select(b => new { b.BirdId, b.BirdSpeciesId, b.Name, b.Gender, b.BirthMonthYear, b.Description, b.BirdImage, b.Price, b.BirdSpecies.BirdSpeciesName, b.StatusSold }).ToList();

            List<TbBirdCategory> birdCategories = birdRepositories.GetAllBirdCategories();
            foreach (var category in birdCategories)
            {
                cmb_type.Items.Add(category.BirdSpeciesName);
            }

            var status = new List<string>();
            status.Add("true");
            status.Add("false");
            cmb_Status.DataSource = status;
        }

        private void dtg_NestList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lb_Id.Text = dtg_NestList.CurrentRow.Cells[0].Value.ToString();
            txt_idmale.Text = dtg_NestList.CurrentRow.Cells[1].Value.ToString();
            txt_idfemale.Text = dtg_NestList.CurrentRow.Cells[2].Value.ToString();
            cmb_type.Text = dtg_NestList.CurrentRow.Cells[3].Value.ToString();
            txt_name.Text = dtg_NestList.CurrentRow.Cells[4].Value.ToString();
            txt_des.Text = dtg_NestList.CurrentRow.Cells[5].Value.ToString();
            txt_price.Text = dtg_NestList.CurrentRow.Cells[6].Value.ToString();
            txt_quantity.Text = dtg_NestList.CurrentRow.Cells[7].Value.ToString();
            txt_BirdImage.Text = dtg_NestList.CurrentRow.Cells[8].Value.ToString();
            cmb_Status.Text = dtg_NestList.CurrentRow.Cells[9].Value.ToString();
        }
    }
}

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
    public partial class BirdManager : Form
    {
        private IBirdRepositories birdRepositories;
        public BirdManager()
        {
            InitializeComponent();
            birdRepositories = new BirdRepository();

        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            try
            {
                int price = Convert.ToInt32(txt_price.Text);
                DateTime monthYear = dtp_Birth.Value;

                TbBird bird = new TbBird
                {
                    Name = txt_Name.Text.Trim(),
                    BirthMonthYear = dtp_Birth.Value,
                    BirdSpeciesId = ((TbBirdCategory)cbb_Species.SelectedItem).BirdSpeciesId.ToString(),
                    Description = rtb_Description.Text.Trim(),
                    Price = Convert.ToInt32(txt_price.Text),
                    Gender = cmb_gender.Text.Trim(),
                    BirdImage = txt_Image.Text.Trim(),
                    OffspringAvailable = true,
                    StatusSold = false
                };

                birdRepositories.AddBird(bird);

                BirdManager_Load(sender, e);

            }
            catch (Exception ex)
            {
                // Xử lý lỗi nếu có.
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            try
            {

                int price = Convert.ToInt32(txt_price.Text);
                DateTime monthYear = dtp_Birth.Value;

                TbBird bird = new TbBird
                {
                    BirdId = lb_Id.Text.Trim(),
                    Name = txt_Name.Text.Trim(),
                    BirthMonthYear = dtp_Birth.Value,
                    BirdSpeciesId = ((TbBirdCategory)cbb_Species.SelectedItem).BirdSpeciesId.ToString(),
                    Description = rtb_Description.Text.Trim(),
                    Price = Convert.ToInt32(txt_price.Text),
                    Gender = cmb_gender.Text.Trim(),
                    BirdImage = txt_Image.Text.Trim(),
                    OffspringAvailable = true,
                    StatusSold = Convert.ToBoolean(cmb_Status.Text.Trim()),
                };

                birdRepositories.UpdateBird(bird);

                BirdManager_Load(sender, e);

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
                birdRepositories.DeleteBird(lb_Id.Text.Trim());

                BirdManager_Load(sender, e);
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

        private void BirdManager_Load(object sender, EventArgs e)
        {
            dtg_BirdList.DataSource = birdRepositories.GetAllBirds().Select(b => new { b.BirdId, b.BirdSpeciesId, b.Name, b.Gender, b.BirthMonthYear, b.Description, b.BirdImage, b.Price, b.BirdSpecies.BirdSpeciesName, b.StatusSold }).ToList();
            dtg_BirdList.Columns["BirdId"].ReadOnly = true;


            var birdGender = new List<string>();
            birdGender.Add("male");
            birdGender.Add("female");
            cmb_gender.DataSource = birdGender;

            var status = new List<string>();
            status.Add("true");
            status.Add("false");
            cmb_Status.DataSource = status;

            cbb_Species.DataSource = birdRepositories.GetAllBirdCategories();
            cbb_Species.DisplayMember = "BirdSpeciesName";
        }

        private void dtg_BirdList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lb_Id.Text = dtg_BirdList.CurrentRow.Cells[0].Value.ToString();
            txt_Name.Text = dtg_BirdList.CurrentRow.Cells[2].Value.ToString();
            txt_SpeciesID.Text = dtg_BirdList.CurrentRow.Cells[1].Value.ToString();
            cmb_gender.Text = dtg_BirdList.CurrentRow.Cells[3].Value.ToString();
            dtp_Birth.Text = dtg_BirdList.CurrentRow.Cells[4].Value.ToString();
            rtb_Description.Text = dtg_BirdList.CurrentRow.Cells[5].Value.ToString();
            txt_Image.Text = dtg_BirdList.CurrentRow.Cells[6].Value.ToString();
            txt_price.Text = dtg_BirdList.CurrentRow.Cells[7].Value.ToString();
            cmb_Status.Text = dtg_BirdList.CurrentRow.Cells[9].Value.ToString();
            cbb_Species.Text = dtg_BirdList.CurrentRow.Cells[8].Value.ToString();
        }

        private void cbb_Species_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_SpeciesID.Text = ((TbBirdCategory)cbb_Species.SelectedItem).BirdSpeciesId.ToString();
        }
    }
}

using BSRepositories;
using BusinessObject;
using BusinessObject.Models;
using ProjectPrn211;
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
    public partial class HomePage : Form
    {
        private IBirdRepositories birdRepositories;
        private INestRepositories nestRepositories;
        private ICartRepositories cartRepositories;

        private string UserId { get; set; }

        public HomePage()
        {
            InitializeComponent();
            birdRepositories = new BirdRepository();
            nestRepositories = new NestRepository();
            cartRepositories = new CartRepository();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            string userId = AuthenticatedUser.UserId;
            if (userId == null)
            {
                link_Login.Visible = true;
                linkL_LogOut.Visible = false;
            }
            else
            {
                link_Login.Visible = false;
                linkL_LogOut.Visible = true;
            }

            dtg_ViewBirds.DataSource = birdRepositories.GetAvailableBirds();
            dtg_ViewBirds.Columns["BirdId"].Visible = false;
            dtg_ViewBirds.Columns["BirdSpeciesId"].Visible = false;
            dtg_ViewBirds.Columns["BirdImage"].Visible = false;
            dtg_ViewBirds.Columns["OffspringAvailable"].Visible = false;
            dtg_ViewBirds.Columns["StatusSelling"].Visible = false;
            dtg_ViewBirds.Columns["StatusSold"].Visible = false;
            dtg_ViewBirds.Columns["BirdSpecies"].Visible = false;
            dtg_ViewBirds.Columns["BirthMonthYear"].Visible = false;
            dtg_ViewBirds.Columns["Description"].Visible = false;
            dtg_ViewBirds.Columns["TbBreedingBirdFemales"].Visible = false;
            dtg_ViewBirds.Columns["TbBreedingBirdMales"].Visible = false;
            dtg_ViewBirds.Columns["TbNestBirdIdFemaleNavigations"].Visible = false;
            dtg_ViewBirds.Columns["TbNestBirdIdMaleNavigations"].Visible = false;

            #region Get All Species For Bird Combobox

            var speciesList = birdRepositories.GetAllBirdCategories();
            var speciesBirdNameList = new List<string>();
            speciesBirdNameList.Add("All");
            foreach (var item in speciesList)
            {
                speciesBirdNameList.Add(item.BirdSpeciesName);
            }

            #endregion

            cb_SpeciesBird.DataSource = speciesBirdNameList;


            dtg_ViewNests.DataSource = nestRepositories.GetAllNestsAvailable();
            dtg_ViewNests.Columns["NestId"].Visible = false;
            dtg_ViewNests.Columns["BirdIdMale"].Visible = false;
            dtg_ViewNests.Columns["BirdIdFemale"].Visible = false;
            dtg_ViewNests.Columns["Description"].Visible = false;
            dtg_ViewNests.Columns["BirdImage"].Visible = false;
            dtg_ViewNests.Columns["Status"].Visible = false;
            dtg_ViewNests.Columns["BirdIdMaleNavigation"].Visible = false;
            dtg_ViewNests.Columns["BirdIdFemaleNavigation"].Visible = false;

            #region Get All Species For Nest Combobox

            var speciesNestNameList = new List<string>();
            speciesNestNameList.Add("All");
            foreach (var item in speciesList)
            {
                speciesNestNameList.Add(item.BirdSpeciesName);
            }

            #endregion

            cb_SpeciesNest.DataSource = speciesNestNameList;
        }

        private void dtg_ViewBirds_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            txt_NameBird.Text = dtg_ViewBirds.CurrentRow.Cells[2].Value.ToString();
            txt_SpeciesNameBird.Text = ((TbBirdCategory)dtg_ViewBirds.CurrentRow.Cells[12].Value).BirdSpeciesName.ToString();
            txt_GenderBird.Text = dtg_ViewBirds.CurrentRow.Cells[3].Value.ToString();
            txt_AgeBird.Text = dtg_ViewBirds.CurrentRow.Cells[5].Value.ToString();
            rtb_DescriptionBird.Text = dtg_ViewBirds.CurrentRow.Cells[6].Value.ToString();
            txt_PriceBird.Text = dtg_ViewBirds.CurrentRow.Cells[8].Value.ToString();
        }

        private void dtg_ViewNests_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            txt_NameNest.Text = dtg_ViewNests.CurrentRow.Cells[4].Value.ToString();
            txt_SpeciesNest.Text = dtg_ViewNests.CurrentRow.Cells[3].Value.ToString();
            txt_QuantityNest.Text = dtg_ViewNests.CurrentRow.Cells[7].Value.ToString();
            rtb_DescriptonNest.Text = dtg_ViewNests.CurrentRow.Cells[5].Value.ToString();
            txt_PriceNest.Text = dtg_ViewNests.CurrentRow.Cells[6].Value.ToString();
        }

        private void cb_SpeciesBird_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedSpecies = cb_SpeciesBird.SelectedItem.ToString();

            if (selectedSpecies == "All")
            {
                dtg_ViewBirds.DataSource = birdRepositories.GetAvailableBirds();
            }
            else
            {
                dtg_ViewBirds.DataSource = birdRepositories.GetAllBirdByCategories(selectedSpecies);
            }
        }

        private void cb_SpeciesNest_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedSpecies = cb_SpeciesNest.SelectedItem.ToString();

            if (selectedSpecies == "All")
            {
                dtg_ViewNests.DataSource = nestRepositories.GetAllNestsAvailable();
            }
            else
            {
                dtg_ViewNests.DataSource = nestRepositories.GetAllNestsByCategories(selectedSpecies);
            }
        }

        private void btn_AddToCartBird_Click(object sender, EventArgs e)
        {
            try
            {
                string selectedProductId = dtg_ViewBirds.CurrentRow.Cells[0].Value.ToString();
                if (selectedProductId != null)
                {
                    string userId = AuthenticatedUser.UserId;
                    if (userId != null)
                    {
                        cartRepositories.AddToCart(userId, selectedProductId);
                        MessageBox.Show("Add to cart sucessfully");
                    }
                    else
                    {
                        MessageBox.Show("You need to login first to add this bird to your cart");
                    }
                }
                else
                {
                    MessageBox.Show("Please select a bird");
                }
            }
            catch
            {
                MessageBox.Show("Cannot add too cart. Please check again");
            }


        }

        private void btn_AddToCartNest_Click(object sender, EventArgs e)
        {
            try
            {
                string selectedProductId = dtg_ViewNests.CurrentRow.Cells[0].Value.ToString();
                if (selectedProductId != null)
                {
                    string userId = AuthenticatedUser.UserId;
                    if (userId != null)
                    {
                        cartRepositories.AddToCart(userId, selectedProductId);
                        MessageBox.Show("Add to cart sucessfully");
                    }
                    else
                    {
                        MessageBox.Show("You need to login first to add this bird to your cart");
                    }
                }
                else
                {
                    MessageBox.Show("Please select a nest");
                }
            }
            catch
            {
                MessageBox.Show("Cannot add too cart. Please check again");
            }

        }

        private void link_ViewCart_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            string userId = AuthenticatedUser.UserId;
            if (userId != null)
            {
                ViewCart viewCart = new ViewCart();
                this.Hide();
                viewCart.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("You need to login first to view your cart");
            }

            if (userId == null)
            {
                linkL_LogOut.Visible = false;
            }

            dtg_ViewBirds.DataSource = birdRepositories.GetAvailableBirds();
            dtg_ViewBirds.Columns["BirdId"].Visible = false;
            dtg_ViewBirds.Columns["BirdSpeciesId"].Visible = false;
            dtg_ViewBirds.Columns["BirdImage"].Visible = false;
            dtg_ViewBirds.Columns["OffspringAvailable"].Visible = false;
            dtg_ViewBirds.Columns["StatusSelling"].Visible = false;
            dtg_ViewBirds.Columns["StatusSold"].Visible = false;
            dtg_ViewBirds.Columns["BirdSpecies"].Visible = false;
            dtg_ViewBirds.Columns["BirthMonthYear"].Visible = false;
            dtg_ViewBirds.Columns["Description"].Visible = false;
            dtg_ViewBirds.Columns["TbBreedingBirdFemales"].Visible = false;
            dtg_ViewBirds.Columns["TbBreedingBirdMales"].Visible = false;
            dtg_ViewBirds.Columns["TbNestBirdIdFemaleNavigations"].Visible = false;
            dtg_ViewBirds.Columns["TbNestBirdIdMaleNavigations"].Visible = false;

            #region Get All Species For Bird Combobox

            var speciesList = birdRepositories.GetAllBirdCategories();
            var speciesBirdNameList = new List<string>();
            speciesBirdNameList.Add("All");
            foreach (var item in speciesList)
            {
                speciesBirdNameList.Add(item.BirdSpeciesName);
            }

            #endregion

            cb_SpeciesBird.DataSource = speciesBirdNameList;


            dtg_ViewNests.DataSource = nestRepositories.GetAllNestsAvailable();
            dtg_ViewNests.Columns["NestId"].Visible = false;
            dtg_ViewNests.Columns["BirdIdMale"].Visible = false;
            dtg_ViewNests.Columns["BirdIdFemale"].Visible = false;
            dtg_ViewNests.Columns["Description"].Visible = false;
            dtg_ViewNests.Columns["BirdImage"].Visible = false;
            dtg_ViewNests.Columns["Status"].Visible = false;
            dtg_ViewNests.Columns["BirdIdMaleNavigation"].Visible = false;
            dtg_ViewNests.Columns["BirdIdFemaleNavigation"].Visible = false;

            #region Get All Species For Nest Combobox

            var speciesNestNameList = new List<string>();
            speciesNestNameList.Add("All");
            foreach (var item in speciesList)
            {
                speciesNestNameList.Add(item.BirdSpeciesName);
            }

            #endregion

            cb_SpeciesNest.DataSource = speciesNestNameList;
        }

        private void btn_ViewParents_Click(object sender, EventArgs e)
        {
            string selectedProductId = dtg_ViewNests.CurrentRow.Cells[0].Value.ToString();
            ViewParents viewParents = new ViewParents();
            viewParents.SelectedProductId = selectedProductId;
            this.Hide();
            viewParents.ShowDialog();
            this.Show();
        }

        private void link_Home_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string userId = AuthenticatedUser.UserId;
            if (userId == null)
            {
                linkL_LogOut.Visible = false;
            }

            dtg_ViewBirds.DataSource = birdRepositories.GetAvailableBirds();
            dtg_ViewBirds.Columns["BirdId"].Visible = false;
            dtg_ViewBirds.Columns["BirdSpeciesId"].Visible = false;
            dtg_ViewBirds.Columns["BirdImage"].Visible = false;
            dtg_ViewBirds.Columns["OffspringAvailable"].Visible = false;
            dtg_ViewBirds.Columns["StatusSelling"].Visible = false;
            dtg_ViewBirds.Columns["StatusSold"].Visible = false;
            dtg_ViewBirds.Columns["BirdSpecies"].Visible = false;
            dtg_ViewBirds.Columns["BirthMonthYear"].Visible = false;
            dtg_ViewBirds.Columns["Description"].Visible = false;
            dtg_ViewBirds.Columns["TbBreedingBirdFemales"].Visible = false;
            dtg_ViewBirds.Columns["TbBreedingBirdMales"].Visible = false;
            dtg_ViewBirds.Columns["TbNestBirdIdFemaleNavigations"].Visible = false;
            dtg_ViewBirds.Columns["TbNestBirdIdMaleNavigations"].Visible = false;

            #region Get All Species For Bird Combobox

            var speciesList = birdRepositories.GetAllBirdCategories();
            var speciesBirdNameList = new List<string>();
            speciesBirdNameList.Add("All");
            foreach (var item in speciesList)
            {
                speciesBirdNameList.Add(item.BirdSpeciesName);
            }

            #endregion

            cb_SpeciesBird.DataSource = speciesBirdNameList;


            dtg_ViewNests.DataSource = nestRepositories.GetAllNestsAvailable();
            dtg_ViewNests.Columns["NestId"].Visible = false;
            dtg_ViewNests.Columns["BirdIdMale"].Visible = false;
            dtg_ViewNests.Columns["BirdIdFemale"].Visible = false;
            dtg_ViewNests.Columns["Description"].Visible = false;
            dtg_ViewNests.Columns["BirdImage"].Visible = false;
            dtg_ViewNests.Columns["Status"].Visible = false;
            dtg_ViewNests.Columns["BirdIdMaleNavigation"].Visible = false;
            dtg_ViewNests.Columns["BirdIdFemaleNavigation"].Visible = false;

            #region Get All Species For Nest Combobox

            var speciesNestNameList = new List<string>();
            speciesNestNameList.Add("All");
            foreach (var item in speciesList)
            {
                speciesNestNameList.Add(item.BirdSpeciesName);
            }

            #endregion

            cb_SpeciesNest.DataSource = speciesNestNameList;
        }

        private void Link_Orders_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string userId = AuthenticatedUser.UserId;
            if (userId != null)
            {
                ViewOrders viewOrders = new ViewOrders();
                this.Hide();
                viewOrders.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("You need to login first to view your orders");
            }
        }

        private void link_Login_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            this.Hide();
            loginForm.ShowDialog();
            this.Close();
        }

        private void linkL_LogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AuthenticatedUser.UserId = null;
            LoginForm loginForm = new LoginForm();
            this.Hide();
            loginForm.ShowDialog();
            this.Close();
        }

        private void link_Register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm loginForm = new RegisterForm();
            this.Hide();
            loginForm.ShowDialog();
            this.Show();
        }


    }
}

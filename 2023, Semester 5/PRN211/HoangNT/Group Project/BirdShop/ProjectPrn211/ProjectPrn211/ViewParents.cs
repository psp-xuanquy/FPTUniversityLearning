using BSRepositories;
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
    public partial class ViewParents : Form
    {
        public string SelectedProductId { get; set; }

        private IBirdRepositories birdRepositories;
        private INestRepositories nestRepositories;
        public ViewParents()
        {
            InitializeComponent();
            birdRepositories = new BirdRepository();
            nestRepositories = new NestRepository();
        }

        private void ViewParents_Load(object sender, EventArgs e)
        {
            var nest = nestRepositories.GetNestById(this.SelectedProductId);

            int monthsDiffMale = (DateTime.Now.Year - nest.BirdIdMaleNavigation.BirthMonthYear.Year) * 12 + (DateTime.Now.Month - nest.BirdIdMaleNavigation.BirthMonthYear.Month);
            double ageMale = monthsDiffMale / 12.0;
            ageMale = Math.Round(ageMale, 1);

            txt_NameBirdMale.Text = nest.BirdIdMaleNavigation.Name;
            txt_SpeciesNameBirdMale.Text = nest.BirdIdMaleNavigation.BirdSpecies.BirdSpeciesName;
            txt_GenderBirdMale.Text = nest.BirdIdMaleNavigation.Gender;
            txt_AgeBirdMale.Text = ageMale.ToString();
            rtb_DescriptionBirdMale.Text = nest.BirdIdMaleNavigation.Description.ToString();
            txt_PriceBirdMale.Text = nest.BirdIdMaleNavigation.Price.ToString();

            int monthsDiffFemale = (DateTime.Now.Year - nest.BirdIdFemaleNavigation.BirthMonthYear.Year) * 12 + (DateTime.Now.Month - nest.BirdIdFemaleNavigation.BirthMonthYear.Month);
            double ageFemale = monthsDiffFemale / 12.0;
            ageFemale = Math.Round(ageFemale, 1);

            txt_NameBirdFemale.Text = nest.BirdIdFemaleNavigation.Name;
            txt_SpeciesNameBirdFemale.Text = nest.BirdIdFemaleNavigation.BirdSpecies.BirdSpeciesName;
            txt_GenderBirdFemale.Text = nest.BirdIdFemaleNavigation.Gender;
            txt_AgeBirdFemale.Text = ageFemale.ToString();
            rtb_DescriptionBirdFemale.Text = nest.BirdIdFemaleNavigation.Description.ToString();
            txt_PriceBirdFemale.Text = nest.BirdIdFemaleNavigation.Price.ToString();

            txt_NameNest.Text = nest.Name.ToString();
            txt_SpeciesNest.Text = nest.BirdSpecies.ToString();
            txt_QuantityNest.Text = nest.Quantity.ToString();
            rtb_DescriptonNest.Text = nest.Description.ToString();
            txt_PriceNest.Text = nest.Price.ToString();
        }
    }
}

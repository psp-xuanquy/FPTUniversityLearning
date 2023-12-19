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
    public partial class ManageProducts : Form
    {
        public ManageProducts()
        {
            InitializeComponent();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_BirdManager_Click(object sender, EventArgs e)
        {
            BirdManager birdManager = new BirdManager();
            this.Hide();
            birdManager.ShowDialog();
            this.Show();
        }

        private void btn_NestManager_Click(object sender, EventArgs e)
        {
            NestManager nestManager = new NestManager();
            this.Hide();
            nestManager.ShowDialog();
            this.Show();

        }

        private void ManageProducts_Load(object sender, EventArgs e)
        {

        }
    }
}

using Microsoft.Extensions.Configuration.Json;
using Microsoft.Extensions.Configuration;

namespace DemoLogin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            IConfiguration config = new ConfigurationBuilder()
                 .SetBasePath(Directory.GetCurrentDirectory())
                 .AddJsonFile("appsettings.json", true, true)
                 .Build();
            var adminUser = config["AdminAccount:Email"];
            var adminPassword = config["AdminAccount:Password"];
            if(adminUser == txtEmail.Text && adminPassword == txtPass.Text)
            {
                frmManagement f = new frmManagement();
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Login fail!!!");
            }
        }
    }
}
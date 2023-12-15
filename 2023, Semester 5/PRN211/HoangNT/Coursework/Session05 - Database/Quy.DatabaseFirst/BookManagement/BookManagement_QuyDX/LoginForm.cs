using Repositories.Entities;
using Services;

namespace BookManagement_QuyDX
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnShowCate_Click(object sender, EventArgs e)
        {
            CategoryService ser = new CategoryService();
            cboCategory.DataSource = ser.GetAllCategories();
            cboCategory.DisplayMember = "BookGenreType";
            cboCategory.ValueMember = "BookCategoryId";    //Drop-down hiển thị cột nào từ table/class Category
            cboCategory.SelectedValue = 4;  //Set dedault cuốn/loại nào đc sẵn và show ra

            //CategoryService ser = new CategoryService();
            //string listOfCate = "";
            //List<BookCategory> list = ser.GetAllCategories();
            //for (int i = 0; i < list.Count; i++)
            //{
            //    listOfCate += list[i].BookCategoryId + " | "
            //                + list[i].Description + " | "
            //                + list[i].BookGenreType + "\n";
            //    MessageBox.Show(listOfCate);
            //}

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //ẩn màn hình login nếu thành công
            //và show màn hình BookManager lên
            this.Hide();
            BookManagerForm mainForm = new BookManagerForm();
            mainForm.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();     //tắt app luôn
        }
    }
}

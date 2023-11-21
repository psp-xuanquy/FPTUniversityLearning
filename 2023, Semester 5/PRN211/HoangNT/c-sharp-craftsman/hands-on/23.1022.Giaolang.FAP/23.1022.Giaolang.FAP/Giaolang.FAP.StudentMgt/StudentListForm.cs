namespace Giaolang.FAP.StudentMgt
{
    public partial class StudentListForm : Form
    {
        public StudentListForm()
        {
            InitializeComponent();
        }

        private void StudentListForm_Load(object sender, EventArgs e)
        {

        }

        private void SayHello(object sender, EventArgs e)
        {
            MessageBox.Show("Xin chào. This is 1st message that comes from VS2022 & .NET6.0",
                "Notification!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
        }

        private void SayGoodbye(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Goodbye. Do you really want to exit?",
                "Confirm!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }

        }

        private void OpenImage(object sender, EventArgs e)
        {
            DialogResult result = dlgOpenFile.ShowDialog();
            if (result == DialogResult.OK)
            {
                //MessageBox.Show(dlgOpenFile.FileName);
                lblFileName.Text = "Image: " + dlgOpenFile.FileName;

                picAvatar.Image = new Bitmap(dlgOpenFile.FileName);
            }
        }

        private void LoadData(object sender, EventArgs e)
        {
            List<Student> ds = new List<Student>();
            ds.Add(new Student() { Id = "SE1", Name = "An", Address = "Dương Đông" });
            ds.Add(new Student() { Id = "SE2", Name = "Dương", Address = "Tân Bình" });
            ds.Add(new Student() { Id = "SE3", Name = "Dũng", Address = "Tân An" });

            dgvStudentList.DataSource = ds;
        }

        private void ShowAStudent(object sender, EventArgs e)
        {
            //ta sẽ xài các hàm, thuộc tính của dgv qua dấm .
            //toàn bộ những gì trên form đều là các biến object trỏ vùng new
            //DataGridView dgv = new DataGridView();
            //             dgv.DataSource = danh sách sv;
            //             dgv.Click += chừa chỗ cái hàm của ai đó
            //             dgv.Click thì làm gì, gọi hàm này
            //             xài các chấm khác để biết dòng nào đc chọn, lấy từng cell
            //             
            if (dgvStudentList.SelectedRows.Count > 0)
            {
                //lấy ra dòng đầu tiên trong nhiều dòng vừa chọn, trích từng cell ra, 3 cells
                DataGridViewRow selectedRow = dgvStudentList.SelectedRows[0];
                txtId.Text = selectedRow.Cells[0].Value.ToString();
                txtName.Text = selectedRow.Cells[1].Value.ToString();
                txtAddress.Text = selectedRow.Cells[2].Value.ToString();
            }

        }
    }
}
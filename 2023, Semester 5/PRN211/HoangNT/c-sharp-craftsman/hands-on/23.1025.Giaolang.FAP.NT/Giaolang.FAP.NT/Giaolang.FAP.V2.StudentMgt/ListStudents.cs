using Giaolang.FAP.V2.Repositories;

namespace Giaolang.FAP.V2.StudentMgt
{
    public partial class ListStudents : Form
    {

        private IStudentRepository _repo;  //tuyệt đỉnh
        //xài kho dữ liệu lấy từ đâu đó miễn là có GetAll() Add() Update() Delete() Search()
        public ListStudents()
        {
            InitializeComponent();
            InitializeStudntRepository();
        }

        private void InitializeStudntRepository()
        {
            _repo = new StudentRepositorySqlserver(); //tuyệt đỉnh
            dgvStudentList.DataSource = _repo.GetAll();
        }

        private void AddStudent(object sender, EventArgs e)
        {
            Student x = new();
            x.Id = txtId.Text;
            x.Name = txtName.Text;
            x.Address = txtAddress.Text;
            x.Gpa = double.Parse(txtGpa.Text);
            _repo.Add(x);

            //refresh grid
            dgvStudentList.DataSource = null; //xoá lưới
            dgvStudentList.DataSource = _repo.GetAll();
        }

        private void UpdateStudent(object sender, EventArgs e)
        {
            Student x = new();
            x.Id = txtId.Text;
            x.Name = txtName.Text;
            x.Address = txtAddress.Text;
            x.Gpa = double.Parse(txtGpa.Text);
            _repo.Update(x);

            //refresh grid
            dgvStudentList.DataSource = null; //xoá lưới
            dgvStudentList.DataSource = _repo.GetAll();
        }

        private void ViewAStudent(object sender, EventArgs e)
        {
            if (dgvStudentList.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvStudentList.SelectedRows[0];
                txtId.Text = row.Cells[0].Value.ToString();
                txtName.Text = row.Cells[1].Value.ToString();
                txtAddress.Text = row.Cells[2].Value.ToString();
                txtGpa.Text = row.Cells[3].Value.ToString();
            }
        }

        private void DeleteAStudent(object sender, EventArgs e)
        {
            _repo.Delete(txtId.Text); //validation, chửi nếu chưa nhập
            //refresh lại grid 
            dgvStudentList.DataSource = null;
            dgvStudentList.DataSource = _repo.GetAll();
        }

        private void SearchStudents(object sender, EventArgs e)
        {
            dgvSearchResult.DataSource = null;
            dgvSearchResult.DataSource = _repo.Search(txtKeyword.Text);
            //vì hàm Search() trả về danh sách sv tìm thấy, ta đưa luôn vào grid
        }

        private void KillApp(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); //giết app, giết form ẩn Login
        }

        private void ListStudents_Load(object sender, EventArgs e)
        {

        }
    }
}
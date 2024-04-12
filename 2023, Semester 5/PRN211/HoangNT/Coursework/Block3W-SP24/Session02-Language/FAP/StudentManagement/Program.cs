using StudentManagement.Entities;

namespace StudentManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CreateStudentbjectV2();
            CallToString();
        }

        static void CreateStudentbjectsV1()
        {
            Student tuan = new Student("SE173039", "Tuấn Phạm Nguyễn Trọng", "tuan@", 2003, 8.6);

            Console.WriteLine("Tuan's grade: " + tuan.GetGpa());

            tuan.SetGpa(9.9);

            Console.WriteLine("Tuan's grade again: " + tuan.GetGpa());
        }

        static void CreateStudentbjectV2()
        {
            Student tuan = new Student("SE173039", "Tuấn Phạm Nguyễn Trọng", "tuan@", 2003, 8.6);

            // named-argument: kĩ thuật gọi hàm đi kèm tên biến; cho phép lộn xộn thứ tự, miễn là chỉ ra tên biến/ tham số tương ứng
            Student dat = new Student(id: "SE173081", name: "Đạt Nguyễn Quốc", email: "dat@", yob: 2003, gpa: 8.8);
            // Có thể cắt bớt kiểu dữ liệu từ bên tay phải, ta suy từ tay trái
            Student dang = new(id: "SE180262", name: "Đăng Võ Quang", email: "dang@", yob: 2004, gpa: 8.9);
            // suy luận kiểu dựa trên value - type inference
            var dang1 = new Student(id: "SE1802621", name: "Đăng1 Võ Quang", email: "dang1@", yob: 2004, gpa: 8.9);

            dat.ShowProfile();
        }

        static void CallToString()
        {
            var tuan = new Student("SE173039", "Tuấn Phạm Nguyễn Trọng", "tuan@", 2003, 8.6);

            Console.WriteLine("Information of student: " + tuan.ToString());
            // => .ToString() luôn được ngầm gọi nếu nó tham gia vào trong việc ghép chuỗi

            Console.WriteLine("Information of student: " + tuan);
        }
    }
}

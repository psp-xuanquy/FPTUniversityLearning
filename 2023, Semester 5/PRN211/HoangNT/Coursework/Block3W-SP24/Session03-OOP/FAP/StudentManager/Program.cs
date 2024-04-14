using StudentManager.Entities;
//~ import java.util.Scanner;
namespace StudentManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CreateStudentObjectV1();
            //CreateStudentObjectV2();
            CallToString();
        }

        static void CallToString()
        {
            var tuan = new Student("SE173039", "Tuấn Phạm Nguyễn Trọng ", "tuan@", 2003, 8.6);

            Console.WriteLine("Tuan's full ko che: " + tuan.ToString());

            Console.WriteLine("Tuan's full ko che: " + tuan);
            //gọi thầm tên em - .ToString() luôn được ngầm gọi nếu nó tham gia vào trong việc ghép chuỗi !!!


            // Câu hỏi : điều gì xảy ra nếu, class ko có hàm TOSTRING()???
        }
        static void CreateStudentObjectV2()
        {
            Student tuan = new Student("SE173039", "Tuấn Phạm Nguyễn Trọng ", "tuan@", 2003, 8.6);
            //data type 
            //      biến oject      object/value phức tạp

            Student dat = new Student(id: "SE173081", name: "Đạt Nguyễn Quốc", yob: 2003, gpa: 8.8, email: "dat@");
            //named-argument:kĩ thuật gọi hàm đi kèm tên biến; cho phép lộn xộn thứ tự, miễn là chỉ ra tên Biến/ tham số tương ứng

            Student dang = new(id: "SE180262", name: "Đăng Võ Quang", yob: 2004, gpa: 8.9, email: "dang@");
            //có thể cắt bớt kiểu dữ liệu bên tay phải , ta suy từ tay trai

            var dang1 = new Student(id: "SE180266", name: "Đắng Võ Quang", yob: 2004, gpa: 8.9, email: "dang@");
            //suy luận kiểu dữ liệu dựa trên trên value - type inferrent

            //var dang2 = new (id: "SE180266", name: "Đắng Võ Quang", yob: 2004, gpa: 8.9, email: "dang@");//TOANG , ko biết nói về data nào!!!

            //còn 1 món new nữa !!! Cực kỳ hay dùng , đó là... ngày mai sẽ rõ
            dang1.ShowProfile();

        }
        static void CreateStudentObjectV1()
        {
            Student tuan = new Student("SE173039", "Tuấn Phạm Nguyễn Trọng", "tuan@", 2003, 8.6);
            // int  yob = 2003; 
            // data type    tên gọi     data - type
            //                biến
            //OOP: TẠO RA DATA TYPE PHỨC TẠP ĐỂ LƯU TRỮ INFO PHỨC TẠP 
            Console.WriteLine("Tuan's grade: " + tuan.Getgpa());
            tuan.SetGpa(10.0);
            Console.WriteLine("Tuan's grade again: " + tuan.Getgpa());
        }
    }
}

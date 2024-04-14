using StudentManagerV5.Entities;

namespace StudentManagerV5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student anh = new Student("SE1", "Anh");
            Student dang = new Student(id: "SE2", name: "Đăng");
            Student tuan = new Student("SE3", "Tuấn") { Yob = 2004, Gpa = 8.6 };

            Console.WriteLine("Anh: " + anh);
            Console.WriteLine("Đăng: {0}", dang);
            Console.WriteLine($"Tuan: {tuan.ToString()}");
            //ToString() ko cần thiết 



            //1.CONSTRUCTOR: DÙNG ĐỂ ĐÚC 1 OBJECT, NHẬN DATA ĐƯA VÀO KHUÔN ĐỂ THÀNH OBJECT. MÚN ĐÚC/TẠO OBJECT THÌ CẦN CONSTRUCTOR
            //2. NẾU CLASS/KHUÔN KO CÓ CONSTRUCTOR , MẶC ĐỊNH SDK SẼ CUNG CẤP 1 PHỄU TRỐNG /DEFAULT
            //KO NHẬN ĐẦU VÀO KO LÀM GÌ CẢ public Student() { }
            // phễu tượng trưng nói về hành động đúc
            // NẾU CLASS KO CÓ THÌ MẶC ĐỊNH SẼ CÓ 
            //3. NẾU 1 CLASS CÓ SẴN CONSTRUCTOR CO THAM SỐ RỒI
            // THÌ SDK KO TẠO RA CONSTRUCTOR RỖNG NỮA VÌ ÍT NHẤT LÀ ĐÃ CÓ PHỄU ĐỂ ĐÚC - CHỈ CẦN CÓ PHỄU
            //4. VẬY EM CHỦ ĐỘNG TẠO RA 1 CONSTRUCTOR RỖNG ĐC KO -> ĐC 
            // TA CÓ NHIỂU CÁCH ĐÚC !!! 100% y chang java
            Student dat = new Student() { Id = "SE4", Name = "Đạt" };
            Console.WriteLine(dat);//gọi thầm tên em ToString()
                                   //CONSTRUCTOR RỖNG, HOẶC CONSTRUCTOR CÓ THAM SỐ ĐI KÈM VỚI OBJECT INITIALIZER GIÚP TA LINH HOẠT TRONG VIỆC TẠO OBJECT VỚI CÁC INFO KHỞI ĐẦU, KO CẦN LÀM QUÁ NHIỀU TỔ HỢP CONSTRUCTOR

            ;

        }
    }
}

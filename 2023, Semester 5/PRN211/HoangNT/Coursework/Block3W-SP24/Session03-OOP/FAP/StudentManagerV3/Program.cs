using StudentManagerV3.Entities;
//import java.util.Scanner;

namespace StudentManagerV3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student anh = new Student();  //ta gọi constructor default, là constructor tự động được tạo ra bởi SDK 
                                          //để giúp diễn tả cái ý nghĩa: đem khuôn ra lấy phễu rót vật liệu - đúc obj
                                          //constructor này ko nhận đầu vào, () trong code chẳng có gì Student() {}
                                          //đảm bảo cơ chế: có phễu để new để đổ vật liệu
                                          //khi đó object ko có info đổ vào, vậy nó mang giá trị mặc định, Khuôn chứa sẵn ko khí
                                          //mua bộ hồ sơ, xin phiếu ghi thông tin, từ từ điền vào, tờ giấy, hồ sơ vẫn là 1 object default

            //in thử xem info bên trong default object
            Console.WriteLine("Anh's id: " + anh.Id);
            Console.WriteLine("Anh's name: " + anh.Name);
            Console.WriteLine("Anh's yob: " + anh.Yob);
            anh.Id = "SE180643";
            anh.Name = "Anh Đinh Vũ Tuấn";
            anh.Yob = 2004;

            Console.WriteLine($"Anh's profile : {anh.Id} {anh.Name} {anh.Yob}");

            //    KĨ THUẬT NEW THỨ 5 - OBJECT INITIALIZATION
            Student dang = new Student() { Id = "SE180262", Name = "Đặng Võ Quang", Yob = 2004 };
            //Gọi Set ngay khi new , đổ lun vào vùng default
            //ko nhầm lẫn với NAMED-ARGUMENT
            //
            Console.WriteLine($"Đăng's profile : {dang.Id} {dang.Name} {dang.Yob}");
        }
    }
}
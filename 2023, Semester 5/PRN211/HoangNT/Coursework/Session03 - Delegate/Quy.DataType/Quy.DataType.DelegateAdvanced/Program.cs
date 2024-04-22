using Quy.DataType.DelegateAdvanced;
using System.Security.Cryptography.X509Certificates;

//Tạo delegate cũng tương tự như tạo ra 1 Class, 1 DataType mới
//Cho nên ta sẽ đặt câu lệnh tạo ra 1 delegate nằm ngoài class - mạnh ngang class, interface 
//nhưng cú pháp ngắn gọn hơn, do nó chỉ chọn để lưu, trỏ đến 1 loại hàm nào đó

public delegate void Say();   //Tui sẽ nói về 1 loạt các hàm có cùng style/format
                              //khuôn chứa bên trong nhiều tên hàm

internal class Program
{

    private static void Main(string[] args)
    {
        //HÀM ẨN DANH - ANONYMOUS FUNCTION
        //Say f = ???   //Ta cần gán 1 hàm nào đó có style void Tên-hàm
        //??? là tên 1 hàm đâu đó có sẵn, có style void Tên-hàm

        //Hàm bản chất là xử lí bên trong, thay vì ta cần tạo 1 hàm nào đó sẵn
        //Ta có thể tạo hàm style Take-away, On-the-go
        //f chỉ cần trỏ đén xử lí, có thể lược bớt tên hàm
        Say f1 = delegate () { Console.WriteLine("This message comes from Anonymous function"); };
        f1();

        //Có thể lược bớt dấu ()
        Say f2 = delegate { Console.WriteLine("This message comes from Anonymous function"); };
        f2();

        //Cách viết ngắn gọn hơn - Lambda Expression
            //Cú pháp rút gọn tên hàm
            //Chỉ chơi vs delegate
            //Khác Expresion body (vì expression body phải giữ nguyên tên hàm)
        Say f3 = () => { Console.WriteLine("This message comes from Anonymous function"); };
        f3();
    }


    //private static void Main(string[] args)
    //{
    //    //Delegate có thể trỏ đến 1 hàm bất kì cùng style ở class khác

    //    Student s = new Student() { Id = "SE01", Name = "An", Yob = 2003 };
    //    Say f = s.SayHello;
    //    f += Student.SayMath;
    //}


    //private static void Main(string[] args)
    //{
    //    //Say f = ???;   //Tên hàm nào đó có style void Tên-hàm()
    //                     //Tên hàm bây giờ đc xem là value cho 1 biến nào đó - biến kiểu delegate

    //    Say f = SayHello;   //Ko có (), vì nếu có () thì nó sẽ hiểu là run hàm
    //    f();

    //    //Chơi theo kiểu static
    //    //f += SayHelloCSharp;
    //    //f();

    //    //Chơi theo kiểu non-static
    //    Program program = new Program();
    //    f += program.SayHelloCSharp;
    //    f();
    //}

    //Tạo ra các hàm cùng style để lát nhét đc vào trong biến f
    public static void SayHello() => Console.WriteLine("Hey Saturday morning!");

    //public static void SayHelloCSharp() => Console.WriteLine("Hello C# and Hello Delegate!");   
    public void SayHelloCSharp() => Console.WriteLine("Hello C# and Hello Delegate!");   



}
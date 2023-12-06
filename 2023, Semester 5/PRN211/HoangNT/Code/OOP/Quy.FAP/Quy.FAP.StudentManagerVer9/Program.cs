using Quy.FAP.StudentManagerVer9;

internal class Program
{
    //private static void Main(string[] args)
    //{

    //    Student s2 = new Student(id: "SE02") { Name = "Binh", Yob = 2002 };
    //    Student s1 = new Student("SE01") { Name = "An", Yob = 2001 };
    //    Student quy = new Student("SE42") { Name = "Quy", Yob = 2003 };

    //    Console.WriteLine("Student 1: " + s1.ToString());
    //    Console.WriteLine("Student 2: " + s2);   //gọi thầm ToString()
    //    Console.WriteLine("Quy: " + quy);

    //    //Static là vùng nhớ dùng chung cho các object

    //    Console.WriteLine("Id chung: " + Student.Id);
    //    //Id lúc này dùng chung cho mọi vung new Student
    //    //Vì vậy muốn lấy Id thay vì gọi từng biến Id ra từng giá trị, ta chỉ cần dùng Student.Id là đủ
    //    //Vì mọi object.Id cùng 1 value
    //    //Id này là của chung của mọi SV
    //}


    static void Main(string[] args)
    {
        SayHelloV2();                //Gọi đc, static chỉ chơi đc vs static
        //SayHelloV1();              //Ko thể gọi được vì là non-static
        Program x = new Program();   //Nếu vẫn muốn chơi SayHelloV1() thì phải đi qua con đường new
        x.SayHelloV1();                 //non-static phải chơi qua object new
        Program.SayHelloV2();           //static, chơi qua tên class

        //Chơi luôn hàm tính giai thừa vì là hàm static
        MyToy getFactorial = new MyToy();
        Console.WriteLine("5! = " + MyToy.ComputerFactorial(5));

        //Tương tự, tính căn bậc 2 của 25
        Console.WriteLine("Square root of 25 is: " + System.Math.Sqrt(25));

        //int.Parse: đổi từ chuỗi sang số
        //Convert.To...(): hàm static để convert thông tin từ dạng này sang dạng khác
        //GÕ tên class và CHẤM thử, nếu xổ ra, tức là có static để chơi
        //nếu ko xổ, hoặc có xổ, ta đi theo đường new thì là chơi vs non-static
    }

    //Test thử static
    public void SayHelloV1()   //non-static
    {
        Console.WriteLine("This message comes from non-static method");
    }

    public static void SayHelloV2()   //static
    {
        Console.WriteLine("This message comes from static method");
    }
}
using Quy.FAP.StudentManagerVer4;

internal class Program
{
    private static void Main(string[] args)
    {
        //Student s = new Student();
        //Console.WriteLine("Before  setting: " + s.ToString());

        //Console.WriteLine("\n");

        //s.Id = "SE170242";
        //s.Name = "Quy";
        //Console.WriteLine("After setting: " + s.ToString());

        //Student s2 = s;
        //s = new Student();
        //Console.WriteLine(s.ToString());  
        //Console.WriteLine(s2.ToString()); 
        //s = s2;
        //Console.WriteLine(s2.ToString());

//--------------------------------------------------------------------------------------------------------
        //Nếu class có empty constructor, ta new() xong rồi ta phải set() thì mới có infor bên trong
        //nếu ko set() thì là default value
        //C# hỗ trợ new kiểu mới, vừa new vừa set value
        //Class Initializer(new và khởi động luôn, gán luôn infor bên trong qua Set())

        Student s = new Student() { Id = "SE-01", Name = "Alpha", Yob = 2003 };
        Console.WriteLine(s.ToString());

        //Nếu ta in biến con trỏ, biến object, ToString() tự gọi
        //Điều này cũng tương tự vs các ngôn ngữ OOP khác
        Student s2 = new() { Id = "SE-02", Name = "Beta", Yob = 2003 };
        Console.WriteLine(s2);

        //var tên-biến: khai báo data type trễ,chưa thèm xác định data type của biến là gì
        //              cho đến khi gán giá trị thì mới biết tên biến là gì
        var s3 = new Student() { Id = "SE-03", Name = "Caesar", Yob = 2003 };
        Console.WriteLine(s3.ToString());
    }
}
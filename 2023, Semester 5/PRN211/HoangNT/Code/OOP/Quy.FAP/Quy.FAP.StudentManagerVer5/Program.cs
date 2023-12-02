using Quy.FAP.StudentManagerVer5;

internal class Program
{
    private static void Main(string[] args)
    {

        var s = new Student();
        //Nếu 1 class ko có contructor nào; mặc định C# và Java; sẽ tạo ngầm 1 constructor rỗng
        //ta cứ thoải mái new con đường rỗng
        //Ta new và set bình thường
        //hoặc new và Initializer - set luôn trên lệnh new
        s = new Student() { Id = "SE-01", Name = "Alpha", Yob = 2003 };
        Console.WriteLine(s);
        //constructor rỗng mà C# tạo giúp đc gọi là DEFAULT CONSTRUCTOR 
        //Những nếu class đã có sẵn constructor trước đó thì C# ko thèm tạo giúp Default Constructor
        //Có bao nhiêu constructor thì có bấy nhiêu cách new - cách đổ infor vào bên trong object
        //Ngoài ra còn có cách đổ qua setter/initializer
    }
}
using Quy.FAP.StudentManagerVer7;

internal class Program
{
    private static void Main(string[] args)
    {
        //Tư duy OOP là tư duy mà ở hàm Main(), nơi bắt đầu app, chỉ là nơi khai báo các object và gọi hàm

        MyList listSE = new MyList();
        listSE.addNew(new Student() { Id = "SE01", Name = "An", Yob = 2003, Gpa = 9.0 });
        Student s = new Student() { Id = "SE10", Name = "Binh", Yob = 2004, Gpa = 5.0 };
        listSE.addNew(s);
        //listSE.printByIDAsc();


        //OOP đã ở chỗ có thể new() tủ mới mà ko cần viết lại nhiều
        //MyList listBiz = new MyList();
        //listBiz.addNew(new Student() { Id = "SS01", Name = "An", Yob = 2005 });
        //Student sS = new Student() { Id = "SS10", Name = "Binh", Yob = 2006 };
        //listBiz.addNew(sS);
        //listBiz.printByIDAsc();

        //s = new Student() { Id = "SE09", Name = "Cuong", Yob = 2004 };
        //listSE.addNew(s);

        //Console.WriteLine("listSE again: ");
        //listSE.printByIDAsc();  //3 sv

        //Console.WriteLine("listBiz again: ");
        //listBiz.printByIDAsc(); // vẫn 2 sv
        ////Tủ này ko ảnh hưởng đến tủ kia, ENCAPSULATE/ENCAPSULATION

        s = new Student() { Id = "SE09", Name = "Cuong", Yob = 2004, Gpa = 10.0 };
        listSE.addNew(s);
        listSE.printByGpaDesc();
    }
}
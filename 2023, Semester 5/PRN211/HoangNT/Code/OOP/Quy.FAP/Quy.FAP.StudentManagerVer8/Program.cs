using Quy.FAP.StudentManagerVer8;
using System.Xml.Linq;

internal class Program
{
    private static void Main(string[] args)
    {
        MyList<Student> sMyList = new MyList<Student>();
        Student s = new Student() { Id = "SE01", Name = "An", Yob = 2003, Gpa = 9.0 };
        sMyList.AddNew(s);   //Hàm AddNew() cần 1 vùng new student
        //In sau, để chứng minh có thêm tủ mới đựng hồ sơ GV ko ảnh hưởng đến tủ cũ đựng hồ sơ SV

        //MyList<Lecturer> lMyList = new MyList<Lecturer>();
        MyList<Lecturer> lMyList = new();   //rút gọn
                                            //bỏ luôn Tên-Class lúc new()
        lMyList.AddNew(new Lecturer() { Id = "LE01", Name = "Mr.Nguyen" });
        lMyList.AddNew(new Lecturer() { Id = "LE02", Name = "Ms.The" });
        Console.WriteLine("Student List");
        sMyList.PrintList();
        Console.WriteLine("Lecturer List:");
        lMyList.PrintList();
    }
}
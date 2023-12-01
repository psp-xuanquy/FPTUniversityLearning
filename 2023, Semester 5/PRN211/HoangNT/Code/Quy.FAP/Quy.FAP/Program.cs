using Quy.FAP.StudentManager;

internal class Program
{
    private static void Main(string[] args)
    {
        CreateStudents();
    }

    public static void CreateStudents()
    {
        //Lấy khuôn(class Student) chuẩn bị vật liệu(id, name, yob, gpa), sau đó gọi phễu(constructor) đổ vào
        Student s1 = new Student("SE-1", "Dao", 2003, 6.9); //new kiểu normal

        Student s2 = new Student(id: "SE-2", name: "Xuan", yob: 2003, gpa: 9.6); //new theo kiểu chỉ ra biến(tham số) đầu vào của constructor
                                                                                 //=> Argument Style
                                                                                 //=> Đẹp, dễ đọc, rõ nghĩa

        Student s3 = new ("SE-3", "Quy", 2003, 6.6); //new kiểu rút gọn, ko cần khai báo tên class

        s1.GetAllInfor();
        s2.GetAllInfor();
        s3.GetAllInfor();
    }
}
using Quy.FAP.StudentManagerVer6;
using System.Xml.Linq;

internal class Program
{
    //static void Main(string[] args)
    //{
    //    //Student s = new Student(id: "SE-01", name: "Alpha") { Yob = 2003 }; //name argument: chỉ ra tham số của hàm
    //    //Console.WriteLine(s.Id + " | " + s.Name + " | " + s.Yob + " | " + s.Gpa);
    //}

//--------------Ta sẽ lưu 1 mảng các sinh viên---------------------
    static void Main(string[] args)
    {
        Student s1 = new Student(id: "SE-11", name: "Dao");
        Student s2 = new Student(id: "SE-12", name: "Xuan");
        Student s3 = new Student(id: "SE-13", name: "Quy");
        //Muốn lưu đc nhiều sinh viên hơn, ta phải khai báo rất nhiều biến
        //Muốn khai báo biến hiệu quả hơn, ta dùng MẢNG - Kĩ thuật khai báo nhiều biến
        Student[] s = new Student[30]; //Chỉ tạo ra 30 biến
        //Chưa có sv cụ thể nào, nếu muốn có sv cụ thể thì phải new Student();
        s[0] = new Student() { Id = "SE-00", Name = "Alpha", Yob = 2003 };
        s[1] = new Student() { Id = "SE-01", Name = "Beta", Yob = 2003 };
        s[2] = new Student() { Id = "SE-02", Name = "Caesar", Yob = 2003 };
        s[3] = new Student() { Id = "SE-03", Name = "Delta", Yob = 2003 };
        s[4] = new Student() { Id = "SE-04", Name = "Gamma", Yob = 2003 };
        s[5] = new Student() { Id = "SE-05", Name = "Epsilon", Yob = 2003 };
        s[6] = new Student() { Id = "SE-06", Name = "Zeta", Yob = 2003 };
        s[7] = new Student() { Id = "SE-07", Name = "Eta", Yob = 2003 };
        s[8] = new Student() { Id = "SE-08", Name = "Theta", Yob = 2003 };
        s[9] = new Student() { Id = "SE-09", Name = "Iota", Yob = 2003 };
        //s[10] = new Student() { Id = "SE-03", Name = "Kappa", Yob = 2003 };
        s[10] = new Student(id: "SE-10", name: "Kappa", yob: 2003, gpa: 6.0);

        s[11] = s[10]; //2 biến cùng trả 1 vùng new
                       //danh sách bị trùng, thấy 2 tên, thật ra chỉ là 1
          //CHỨNG MINH    
        s[11].Name = "Ahihi";

        s[12] = s1;

        //In ra danh sách toàn bộ sinh viên
            //---"For" loop:
        //for (int i = 0; i < s.Length; i++)
        //{
        //    Console.WriteLine(s[i]);
        //}
            //---"Foreach" loop:
        foreach (Student student in s)
        {
            Console.WriteLine(student);
        }
    }
}
namespace Quy.CodeFirst.StudentMgt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentDb db = new StudentDb();

            List<Student> result = db.Students.ToList();
            //foreach (Student student in result)
            //{
            //    Console.WriteLine(student.ToString());
            //}
            result.ForEach(student => Console.WriteLine(student));

        //search thông tin ng có tên "An"
            Console.WriteLine("\nStudent Name start with Quy:");
            result.Where(student =>
            {
                if (student.Name.ToLower().Contains("quy"))
                    return true;
                return false;
            }).ToList().ForEach(student => Console.WriteLine(student));
        }




        //    static void Main(string[] args)
        //    {
        //        Student s1 = new Student() { Id = "SE01", Name = "An Nguyen" };
        //        Student s2 = new Student() { Id = "SE02", Name = "Binh Le" };
        //        Student s3 = new Student() { Id = "SE03", Name = "Cuong Vo" };
        //        Student s4 = new Student() { Id = "SE04", Name = "An Tran" };
        //        Student s5 = new Student() { Id = "SE05", Name = "Quy Dao" };
        //        Student s6 = new Student() { Id = "SE06", Name = "Quy Xuan" };

        //        //Để kết nối và đẩy data xuống CSDL, ta phải new class StudentDb mà chứa bên trong kết nối CSDL mà ta vừa cấu hình
        //        StudentDb db = new StudentDb();
        //        db.Database.EnsureCreated();    //Xài các hàm của class CHA - DbContext
        //                                        //Tạo Db nếu chưa tồn tại
        //        db.Students.Add(s1);
        //        db.Students.Add(s2);
        //        db.Students.Add(s3);
        //        db.Students.Add(s4);
        //        db.Students.Add(s5);
        //        db.Students.Add(s6);
        //        db.SaveChanges();   //lưu xuống DB
        //    }
        //}
    }
}

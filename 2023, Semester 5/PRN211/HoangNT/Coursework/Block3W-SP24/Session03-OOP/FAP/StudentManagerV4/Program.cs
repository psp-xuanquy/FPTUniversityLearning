using StudentManagerV4.Entities;

namespace StudentManagerV4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student anh = new Student() { Id = "SE1", Name = "Anh Đinh", Yob = 2004, Gpa = 8.6 };
            Student dang = new Student() { Id = "SE2", Name = "Dang Vo", Yob = 2004, Gpa = 8.7 };
            Console.WriteLine("Anh's profile: " + anh.ToString());
            Console.WriteLine("Dang's profile: " + dang);
        }
    }
}

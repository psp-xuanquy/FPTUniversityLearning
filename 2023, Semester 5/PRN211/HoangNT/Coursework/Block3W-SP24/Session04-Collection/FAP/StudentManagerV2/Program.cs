using StudentManagerV2.Entities;
using StudentManagerV2.Services;

namespace StudentManagerV2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cabinet tuSE = new Cabinet();
            Cabinet tuGD = new Cabinet();

            Student s1 = new Student() { Id = "SE1", Name = "An" };
            Student s2 = new Student() { Id = "SE2", Name = "Binh" };
            tuSE.AddStudent(s1);
            tuSE.AddStudent(s2);

            Student s3 = new Student() { Id = "GD1", Name = "Cuong" };
            tuGD.AddStudent(s3);
            tuGD.AddStudent(new Student() { Id = "GD2", Name = "Dung" });


            tuSE.PrintStudentList();
            tuGD.PrintStudentList();

        }
    }
}

namespace Quy.LinqIntro.Collection
{
    public class Student
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Yob { get; set; }
        public double Gpa { get; set; }

        public override string ToString() => $"{Id} | {Name} | {Yob} | {Gpa}";
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            students.Add(new Student { Id = "SE10", Name = "Muoi", Yob = 2010, Gpa = 10.0 });
            students.Add(new Student { Id = "SE09", Name = "Chin", Yob = 1999, Gpa = 9.0 });
            students.Add(new Student { Id = "SE01", Name = "Mot", Yob = 2001, Gpa = 1.0 });
            students.Add(new Student { Id = "SE05", Name = "Nam", Yob = 2005, Gpa = 5.0 });
            students.Add(new Student { Id = "SE04", Name = "Bon", Yob = 2004, Gpa = 4.0 });
            students.Add(new Student { Id = "SE08", Name = "Tam", Yob = 1998, Gpa = 8.0 });
            students.Add(new Student { Id = "SE07", Name = "Bay", Yob = 1997, Gpa = 7.0 });
            students.Add(new Student { Id = "SE06", Name = "Sau", Yob = 1996, Gpa = 6.0 });
            students.Add(new Student { Id = "SE02", Name = "Hai", Yob = 2002, Gpa = 2.0 });
            students.Add(new Student { Id = "SE03", Name = "Ba", Yob = 2003, Gpa = 3.0 });

        //tui muốn in ra danh sách sv
            //Cách 1: For Truyền thống
            Console.WriteLine("\nFull Student List (using For loop):");
            for (int i = 0; i < students.Count; i++)
            {
                Console.WriteLine(students[i].ToString());
            }

            //Cách 2: Foreach Truyền thống
            Console.WriteLine("\nFull Student List (using Foreach loop):");
            foreach (Student student in students)
            {
                Console.WriteLine(student.ToString());
            }

            //Cách 3: LINQ, nhận vào 1 delegate, nhận vào 1 hàm CheckVar(đầu vào 1 sv), trả ra True nếu thỏa mãn 
            Console.WriteLine("\nFull Student List (using LINQ):");
            //students.ForEach(student => Console.WriteLine(student.ToString()));
            students.ForEach(ShowStudent);

        //in ra danh sách sv vs GPA >= 5
            Console.WriteLine("\nStudent List with GPA >= 5:");
            students.ForEach(student =>
            {
                if (student.Gpa >= 5) { Console.WriteLine(student.ToString()); }
            });

        //in ra danh sách sv vs Yob < 2000
          //1 hàm CheckVar student theo cách của bạn
          //giỏ tủ sẽ add sv thỏa vào list và return list cho mình
            Console.WriteLine("\nStudent List with Yob < 2000:");
            //List<Student> result = students.Where(CheckVar).ToList();
            //result.ForEach(student => Console.WriteLine(student));
            students.Where(CheckVar).ToList().ForEach(student => Console.WriteLine(student));

        //in ra danh sách sv vs Yob >= 2000
            Console.WriteLine("\nStudent List with Yob >= 2000:");
            students.Where(student => 
            {
                if (student.Yob >= 2000) return true;
                return false;
            }).ToList().ForEach(student => Console.WriteLine(student));

        //in ra danh sách sv vs Yob >= 2000 && Gpa >= 8
            Console.WriteLine("\nStudent List with Yob >= 2000:");
            students.Where(student =>
            {
                if (student.Yob >= 2000 && student.Gpa >= 8) return true;
                return false;
            }).ToList().ForEach(student => Console.WriteLine(student));
        }

        public static bool CheckVar(Student student)
        {
            if (student.Yob < 2000) return true;
            return false;
        }

        public static void ShowStudent(Student student)
        {
            Console.WriteLine(student);
        }
    }

    
}

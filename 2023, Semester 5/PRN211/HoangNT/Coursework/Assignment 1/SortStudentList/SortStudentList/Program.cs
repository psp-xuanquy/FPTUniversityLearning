using StudentManagement;
using System.Buffers.Text;
using System.Diagnostics.Metrics;

internal class Program
{
    static void Main(string[] args)
    {
        Student[] students = new Student[] {
                new Student(){ Id = 2, Name="Adam", Yob = 1980},
                new Student(){ Id = 5, Name="Bill", Yob = 2000},
                new Student(){ Id = 6, Name="Christian", Yob = 2010},
                new Student(){ Id = 3, Name="David", Yob = 1965},
                new Student(){ Id = 4, Name="Eva", Yob = 1970},
                new Student(){ Id = 7, Name="Frank", Yob = 2003},
                new Student(){ Id = 9, Name="Grace", Yob = 1995},
                new Student(){ Id = 1, Name="Hannah", Yob = 1975},
                new Student(){ Id = 8, Name="Iris", Yob = 2005},
                new Student(){ Id = 14, Name="Alice", Yob = 1867},
                new Student(){ Id = 12, Name="Ronaldo", Yob = 1983},
                new Student(){ Id = 10, Name="Messi", Yob = 1985},
                new Student(){ Id = 13, Name="Bob", Yob = 1997},
                new Student(){ Id = 15, Name="Julia", Yob = 1962},
                new Student(){ Id = 11, Name="Beckham", Yob = 1979}
            };

//BUBBLE SORT---------------------------------------------------------------------------------------------------------------
        Console.WriteLine("Student List before sorting: ");
        foreach (var student in students)
        {
            Console.WriteLine(student);
        }
        Console.WriteLine("\n");

    //Sorting students based on student ID in ascending order:
        for (int i = 0; i < students.Length - 1; i++)
        {
            for (int j = 0; j < students.Length - 1 - i; j++)
            {
                if (students[j].Id > students[j + 1].Id)
                {
                    Student temp = students[j];
                    students[j] = students[j + 1];
                    students[j + 1] = temp;
                }
            }
        }

        Console.WriteLine("Student List after sorting based on student ID in ascending order: ");
        foreach (var student in students)
        {
            Console.WriteLine(student);
        }
        Console.WriteLine("\n");

    //Sorting students based on Year of Birth in descending order:
        for (int i = 0; i < students.Length - 1; i++)
        {
            for (int j = 0; j < students.Length - 1 - i; j++)
            {
                if (students[j].Yob < students[j + 1].Yob)
                {
                    Student temp = students[j];
                    students[j] = students[j + 1];
                    students[j + 1] = temp;
                }
            }
        }

        Console.WriteLine("Student List after sorting based on Year of Birth in descending order: ");
        foreach (var student in students)
        {
            Console.WriteLine(student);
        }
        Console.WriteLine("\n");

    //BONUS: Sorting students based on Name in alphabetical order:
        for (int i = 0; i < students.Length - 1; i++)
        {
            for (int j = 0; j < students.Length - 1 - i; j++)
            {
                if (students[j].Name.CompareTo(students[j + 1].Name) > 0)
                {
                    Student temp = students[j];
                    students[j] = students[j + 1];
                    students[j + 1] = temp;
                }
            }
        }

        Console.WriteLine("Student List after sorting based on Name in alphabetical order: ");
        foreach (var student in students)
        {
            Console.WriteLine(student);
        }
        Console.WriteLine("\n");
    }
}
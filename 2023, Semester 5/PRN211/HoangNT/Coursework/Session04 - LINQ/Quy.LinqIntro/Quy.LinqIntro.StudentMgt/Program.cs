using Quy.LinqIntro.StudentMgt;

internal class Program
{
    private static void Main(string[] args)
    {
        //Student s = new Student() { Id = "SE01", Name = "An", Yob = 2003, Gpa = 8.0 };
        Student s = new () { Id = "SE01", Name = "An", Yob = 2003, Gpa = 8.0 };
        s.SayHello("Merry Christmas 2024!!!");

        Console.WriteLine();

        //In bảng cửu chương 2
          //s.DoSomethingInFuture(cần 1 hàm void ở đâu đó đưa vào đây)
        //Action action = PrintMultiplicationTable;
        s.DoSomethingInFuture(PrintMultiplicationTable);

        Console.WriteLine();

        //Tính tổng của các số từ 1 -> 100
        s.DoSomethingInFuture(() =>
        {
            Console.WriteLine("Tong cua cac so tu 1 -> 100: ");
            int sum = 0;
            for (int i = 1; i <= 100; i++)
            {
                sum += i;
                Console.Write(i + " ");
            }
            Console.WriteLine("\nSum = " + sum);
        });
    }

    static void PrintMultiplicationTable()
    {
        Console.WriteLine("Bang cuu chuong 2: ");
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"2 x {i} = {i * 2}");
        }
    }
}
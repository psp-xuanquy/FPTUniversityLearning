
using System.Security.Cryptography;

public delegate double F(int a, double b);
//F là tên gọi đại diện cho nhóm các hàm, có tên và ko tên, có style double Tên-hàm(int, double)

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("5 + 10 = " + Sum(5, 10));
        Console.WriteLine("5 * 10 = " + Multiply(5, 10));

        //Delegate
        F x = Sum;
        Console.WriteLine("10 + 3.14 = " + x(10, 3.14)); 
        x = Multiply;
        Console.WriteLine("10 * 3.14 = " + x(10, 3.14)); 

        //Anonymous & Lambda
        F y = delegate (int a, double b) {  return Math.Pow(a, b); };
        Console.WriteLine("10 ^ 2 = " + y(10, 2));

        y = (a, b) => 
        {
            double sum = 0;
            for (int i = 0; i < b; i++)
            {
                sum += a;
            }
            return sum;
        };
        Console.WriteLine("20 + 20 + 20 + 20 + 20 = " + y(20, 5));


    }

    public static double Sum(int x, double y) => x + y;
    public static double Multiply(int x, double y) => x * y;
}
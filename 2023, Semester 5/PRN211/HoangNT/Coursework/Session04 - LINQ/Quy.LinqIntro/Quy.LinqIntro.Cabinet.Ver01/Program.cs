using Quy.LinqIntro.StudentMgt;

public class MyIntegerList
{
    //đây là 1 hộp chứa sẵn bên trong rất nhiều con số
    //Ta sẽ cung cấp dịch vụ ra bên ngoài, in list theo nhu cầu

    private static int[] _list = { -100, -5, -4, -1, -3, 0, 1, 2, 3, 5, 6, 8, 10, 11, 13, 15, 16, 20, 30, 44, 60 };

    //Tui muốn làm hàm cung cấp dịch vụ về con số cho ai đó cần
    //2 STYLE thiết kế
      //STYLE 1:
        //Class này tự cung cấp ra 1 loạt các hàm

    public static void PrintEvenNumber()
    {
        Console.WriteLine("In so chan");
        for (int i = 1; i <= 100; i++)
        {
            if (i % 2 == 0)
            {
                Console.Write($"{i}\t");
            }
        }
        Console.WriteLine();
    }
          //Vô số hàm như thế này mà ta, tác giả class phải viết, phải cung cấp cho user xài
          //Style này dở vì ko đoán hết đc nhu cầu của ai đó sẽ xài class này

        //STYLE 2:
    public static void PrintOnDemand(Action<int> f)   //f = hàm void Fxx(int x) {...}
    {
        foreach (int x in _list)
        {
            f(x);   //Đưa con x trong mảng cho hàm ở xa muốn làm gì thì làm
            //Tui có rất nhiều số nguyên gọi nó là x nằm trong mảng _list 
            //Tui đưa x cho hàm bên ngoài để xử lí nó
        }
    }
}

internal class Program
{
    private static void Main(string[] args)
    {
        //MyIntegerList.PrintOnDemand(Cần đưa cho nó 1 hàm F(int))

        //In số nguyên chẵn, xài hàm lẻ
        MyIntegerList.PrintOnDemand(PrintEvens);

        Console.WriteLine();

        //In số nguyên lẻ, Delegate
        MyIntegerList.PrintOnDemand(delegate (int n) 
        {
            if (n > 0 && n % 2 != 0)
            {
                Console.Write(n + "   ");
            }
        });

        Console.WriteLine();

        //In các số nguyên chia hết cho 5, Lambda
        MyIntegerList.PrintOnDemand(n =>
        {
            if (n > 0 && n % 5 == 0)
            {
                Console.Write(n + "   ");
            }
        });
    }

    public static void PrintEvens(int n)
    {
        if (n > 0 && n % 2 == 0)
        {
            Console.Write(n + "   ");
        }
    }

}
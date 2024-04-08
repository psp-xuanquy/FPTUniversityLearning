internal class Program
{
    static void Main(string[] args)
    {
        //Trả về ArrayList theo nhu cầu
        //MyIntegerList.Where(delegate(int n) { return true; });
        List<int> r = MyIntegerList.Where(n => true);
        Console.WriteLine("Where nothing, show all: ");
        foreach (int i in r)
        {
            Console.Write(i + "   ");
        }

        Console.WriteLine("\n");

        List<int> r1 = MyIntegerList.Where(n => 
        { 
            if(n < 0) return true; 
            return false;
        });
        Console.WriteLine("Where n < 0, show all: ");
        foreach (int i in r1)
        {
            Console.Write(i + "   ");
        }
    }

    //private static void Main(string[] args)
    //{
    //    MyIntegerList.Sum(CheckVarNum); //f = tên hàm, chưa gọi hàm checkvar

    //    //Anonymous & Lambda
    //    Console.Write("Sum of all numbers in list: ");
    //    MyIntegerList.Sum(delegate (int n) { return true; });

    //    Console.Write("Sum of all negative numbers in list: ");
    //    MyIntegerList.Sum(n =>
    //    {
    //        if (n < 0)
    //            return true;

    //        return false;
    //    });
    //}

    public static bool CheckVarNum(int num)
    {
        if (num > 0 && num % 2 == 0) 
            return true;

        return false;
    }
}

public class MyIntegerList
{
    private static int[] _list = { -100, -5, -4, -1, -3, 0, 1, 2, 3, 5, 6, 8, 10, 11, 13, 15, 16, 20, 30, 44, 60 };

    //Cung cấp hàm Sum style ĐỘ theo nhu cầu
    //1 hàm tính tổng đáp ứng mọi nhu cầu từ bên ngoài đưa vào - DI (DEPENDENCY INJECTION)

    
    public static void Sum(Func<int, bool> f)  //f = hàm CheckVarNum() bên ngoài
    {
        int sum = 0;
        for (int i = 0; i < _list.Length; i++)
        {
            if (f(_list[i]) == true) ;   //Con x sẽ dùng để tính tổng,
                                         //nhưng có đúng là x cần tính hay ko, ta đi hỏi hàm F(x) do bên ngoài đưa vào
                                         //trả về True/False theo nhu cầu bên ngoài
                sum += _list[i];
        }
        //in tổng hoặc return
        Console.WriteLine("Sum = " + sum);
        //Tổng là tính những con số [i] đã đc check var bởi hàm f bên ngoài

        //hàm f() gọi là hàm check var, nó check thế nào thì tổng như thế
    }

    //Ta chế thêm 1 hàm, thay vì tính tổng theo nhu cầu thì lọc/filter ra các số theo nhu cầu

    public static List<int> Where(Func<int, bool> f)    //Tương đương mệnh đề Where trong CSDL
    {
        //Quét qua hết mảng, kiểm tra từng đứa
        //Nếu thỏa mãn, ném vào ArrayList

        List<int> result = new();
        for (int i = 0; i < _list.Length;i++)
        {
            if (f(_list[i]) == true)
                result.Add(_list[i]);
        }
        return result;
    }
}
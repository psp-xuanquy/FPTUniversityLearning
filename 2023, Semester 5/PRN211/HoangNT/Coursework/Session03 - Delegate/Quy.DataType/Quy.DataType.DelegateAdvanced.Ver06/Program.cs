
public delegate int Fn();   //tạo ra DataType, gom/đặt tên chung cho 1 nhóm hàm có cùng style int

public delegate char Fc(string s, int i);

internal class Program
{
    //private static void Main(string[] args)
    //{
    //    //Gọi hàm trực tiếp
    //    Console.WriteLine("Call function directly: " + Fx());

    //    //Gọi hàm gián tiếp
    //    //Normal 
    //    Fn f = Fx;
    //    Console.WriteLine("Call function indirectly: " + f());

    //    //Using Anonymous Func, Lambda
    //    f = delegate () { return 100; };
    //    f = () => { return 100; };
    //    f = () => 100;

    //    Console.WriteLine("Call function indirectly using Lambda expression: " + f());
    //}

    //private static void Main(string[] args)
    //{
    //    Func<int> f = Fx;
    //    Console.WriteLine("Call function directly but using Func<>: " + f());
    //}

    static char ExtractCharacter(string s, int i)
    {
        char result = s[i];
        return result;
    }

    private static void Main(string[] args)
    {

        //Tôi muốn chơi vs hàm nhận vào 2 tham số (chuối, số) trả về kiểu Char
        Fc f = ExtractCharacter;
        char result = f("Happy New Year", 6);
        Console.WriteLine("The character at position 6 of string Happy New Year is: " + result);

        //Ko dùng Delegate Fc mà xài hàm chuẩn của Microsoft
        Func<string, int, char> fc = ExtractCharacter;
        Console.WriteLine("The character at position 6 of string Merry Christmas is: " + result);
    }

    static int Fx() => 100;

}

//Thứ tự chơi DELEGATE
//1. Xác định style loại hàm, định dạng hàm, đầu vào đầu ra của hàm 
//2. Định nghĩa/tạo ra nhóm Delegate, DataType trỏ tới style hàm bằng cách dùng lệnh 'delegate' format hàm bao gồm tên delegate
//Ex: delegate int F(int x, int y)
//3. Tạo biến có kiểu delegate vừa tạo, dùng phép gán để trỏ đến 1 hàm nào đó cùng style
//Ex: F x = ?? hàm nào đó cùng style ở đây. KO dùng dấu (), kẻo hiểu nhầm thành gọi hàm
//Có thể dùng x += để trỏ 1 loạt hàm - multicast delegate
//Có thể dùng anonymous hoặc lambda expression nếu muốn dùng hàm rút gọn
//4. Gọi hàm qua 1 trong 2 cú pháp:
//Cú pháp 1: Tên-biến(tham số)
//Cú pháp 2: Tên-biến
//5. In ra kết quả giống như hàm bth

using System.Threading.Channels;

public delegate void Say();

public delegate void SaySth(string msg); 

internal class Program
{
    private static void Main(string[] args)
    {
        Say x = SayCS;
        x();
        
        //Anonymous & Lambda
        SaySth y = SayMsg;
        y("Code through day & night");
        y = msg => Console.WriteLine(msg);
        y("F*ck Lambda");

        //Microsoft, có tham số
        Action<string> z = SayMsg;   //Trỏ đến hàm có style 1 đầu vào là chuỗi
                                     //void Action là void, lambda như bth
        z("F*ck Microsoft");
        z = (ahihi) => Console.WriteLine(ahihi);   //void FNaoDo(string ahihi) {Console.WriteLine(ahihi)}
    }

    public static void SayCS() => Console.WriteLine("Hello C# at afternoon");
    public static void SayMsg(string msg) => Console.WriteLine(msg);
}
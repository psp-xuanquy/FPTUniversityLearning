using System;

delegate void Say();      //   biến để nói về hàm nào đó cụ thể
                          //-> biến Say() f = tên-hàm-cụ-thể-nào-đó
                          //-> biến Say() f = SayHello() (f là hàm có dtyle void và cụ thể là hàm SayHello())

//LƯU Ý: Khi gán value cho Delegate, cấm ko dùng dấu () ở tên hàm đc gán
//vì () hiểu rằng gọi hàm, chứ ko phải gán
//mà gọi hàm là hàm trc, mình đang gán value trc đã

//Từ khóa Delegate mạnh ngang từ khóa class Interface
//vì nó giúp ta định nghĩa ra 1 dự liệu mới hoàn toàn:
//KIỂU DỮ LIỆU DÙNG ĐỂ ĐẶT/GỌI TÊN CHO CÁC VALUE THUỘC STYLE/FORMAT/DỊNH DẠNG NÀO Đ

//Nếu ta có trong tay rất nhiều hàm đông dạng cùng style, vậy ta muốn đặt tên cho đám này,
//muốn tạo data type mới và chỉ tập trung vào các hàm mà thôi, thì ta dùng từ khóa DELEGATE

//Bản chất Delegate chính là 1 calss mà chỉ tập trung vào việc lưu trữ thông tin của các hàm cùng style nằm rải rác

internal class Program
{
    //Xài Say() như mọi data type khác, chỉ có điều gán value, thì gán tên của hàm khác
    //generic: đại diện co bất kì class nào
    //delegate: đại diện cho bất kì hàm nào cùng style

    private static void Main(string[] args)
    {
        Say f = SayHelloDoctor;

        f();   //gọi f() chính là gọi SayHelloDoctor() 
               //Hàm SayHelloDoctor() đc gọi gián tiếp, nó đã ủy quyền cho thg f() gọi giùm, thay vì gọi trực tiếp

        f.Invoke();   //Cách gọi thứ 2 - triệu hồi các hàm mà f() đang trỏ, nhắm tới
                      //f() đang trỏ/đại diện/tham chiếu đến SayHelloDoctor()
                      //Nói cách khác, Delegate là kĩ thuật con trỏ hàm dùng 1 tên khác để trỏ đến cái hàm gốc cũng như gọi hàm trực tiếp

        f = SayHelloWorld;
        f();   //In ra nội dụng hàm SayHelloWorld

        //
        //
        //
        //

        //Hiện tại, f() đang lưu/trỏ/đại diện cho hàm SayHelloWorld(), ko quan tâm đến hàm SayHelloDoctor() ở trên 

    }



    //Ta có nhiều hàm cùng style, ví dụ void Tên-hàm(ko nhận đầu vào)
    //Hàm ko nhận đầu vào và ko trả đầu ra
    //Bài này ta thử 1 style: void F (void)



    public static void SayHello()
    {
        Console.WriteLine("This message is come from SayHello() method");
    }

    public static void SayHelloEverybody()
    {
        Console.WriteLine("This message is come from SayHelloEverybody() method");
    }

    public static void SayHelloEveryone()
    {
        Console.WriteLine("This message is come from SayHelloEveryone() method");
    }

    public static void SayHelloWorld()
    {
        Console.WriteLine("This message is come from SayHelloWorld() method");
    }

    public static void SayHelloDoctor() => Console.WriteLine("Hello Doctor, C# is SoSo tired");   //expression body

}
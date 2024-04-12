namespace NumberCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //PlayWithIntegers();

            //int x = 6868;
            //PassByValue(x);
            //// sau khi gọi hàm , n = mấy ???
            //Console.WriteLine($"after calling the method, x = {x}");

            Console.WriteLine("Play with out keyword");
            int n = 9999;// khai báo lẻ
            Console.WriteLine($"1st: n = {n}");

            PassByOut(out n);
            Console.WriteLine($"2nd: after calling PassOut(), n = {n} ");

            // cách xài out style ON - THE - GO, TAKE AWAY
            PassByOut(out int y); // khai báo gộp 
            Console.WriteLine($"y after calling PassByOut(): {y}");
        }

        //PASS BY REFERENCE -TRUYỀN THAM CHIẾU,TRUYỀN ĐỊA CHỈ,TRUYỀN CON TRỎ
        //JAVA DÙNG TRONG BIẾN OBJECT
        //C# OBJECT , VÀ PRIMITIVE NAY GỌI LÀ VALUE TYPE , CHƠI LUN CẢ 2
        //C# dùng 2 keyword đặt biệt out, REF trên tham số hàm để 
        //trong hàm mà sửa, ngoài kia ăn hành luôn!!!
        //sửa bàn gốc!!! đưa chìa khóa nhà, địa chỉ nhà cho hàm nó bán nhà luôn!!! 
        static void PassByOut(out int x)
        {
            x = 6789;
        }
        //OUT: truyền tham chiếu 
        //1. Biến out trong hàm sẽ nhận /  trỏ đến biến ở đâu đó ngoài kia 
        //2. Mọi sự thay đổi value trong trong biến out , biến ngoài kia bị thay đổi theo ngay . Sửa bản gốc, ko xin value  làm riêng như pass by value 
        //3.có thể xài out theo style ON-THE-GO, TAKE AWAY, khai báo biến để hứng value từ hàm OUT trả ra , ngay khi dùng hàm OUT 
        // thay vì khai báo lẻ sẵn trước đó .Lúc nào dùng thì khai báo biến OUT . Cách mà CHATGPT hay dùng !!!
        //4.OUT còn mang 1 ý nghĩa:...
        //OUT : tao hứa , hàm của tao sẽ có 1 value cho biến out ở đâu đó ngoài kia , hứa sẽ có 1 value đưa ra ngoài (gọi hàm out sẽ lun có value bên ngoài )

        //PASS BY VALUE  -DÙNG CHO PRIMITIVE , VALUE TYPE IN DEFAULT
        // value ở đâu đó đc truyền vào qua ngả / hướng rẽ THAM SỐ hàm , truyền qua tham số , chỉ lấy value đem đi , bản coppy của data đc đem vào hàm
        //hàm làm gì, kệ hàm, ko ảnh hưởng bản gốc bên ngoài 
        static void PassByValue(int x) // tao xin bản coppy data đổ vào đây
        {
            Console.WriteLine("In method, at first x = " + x);
            x = 6789;
            Console.WriteLine("In method, later x= {0}", x);
        } // hàm nhận vào x ,thay đổi giá trị của x
        //Pascal Case Notation vs. camel Case Notation 
        static void PlayWithIntegers()
        {
            // java : int, long, float, double, char, boolean
            //         primitive data type 
            //C#    : int, long, float, double, char, boolean
            //          value type data type
            // CẢ HAI CHỈ TỐN 1 VÙNG RAM ĐỂ LƯU VALUE

            //NGUCO75 LẠI VỚI OBJECT TYPE , REFERENCE TYPE  TỐN 2 VÙNG RAM ĐỂ LƯU VALUE !!!
            //
            int yob = 2023;   // 4 byte trong ram dùng lưu con số 2003

            Console.WriteLine("yob: {0}", yob);
            Console.WriteLine($"yob: {yob}");
            Console.WriteLine("yob: " + yob);

            Console.WriteLine(@$"yob: {yob}");


            long vietlott = 300_000_000_000;

            //int dayOfWeek = 0;
            int? dayOfWeek = null; //map trực tiếp với cột trong DB mà cho phép null - NULLABLE

            Console.WriteLine("day of week: " + dayOfWeek);
        }
    }
}

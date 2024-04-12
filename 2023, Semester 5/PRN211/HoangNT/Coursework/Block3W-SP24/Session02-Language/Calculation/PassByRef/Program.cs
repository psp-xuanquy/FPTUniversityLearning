namespace PassByRef
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //xài  ON THE GO - ko đc vì ko đảm bảo đc biến có value hay ko sau khi gọi hàm do thằng REF nó lỏng lẻo dễ dãi 
            // nó ko bị ép phải có value đem ra ngoài
            //PassByRef(ref int x);

            int x = 9999;
            PassByRef(ref x);
            Console.WriteLine($"X AFTER CALLING REF METHOD: {x}");
        }

        static void PassByRef(ref int x)
        {
            //x = 6789
        }
        //REF từ kháo REF cũng dùng ở tham số hàm tương tự IN, OUT,nhưng cách hành xử và cách sử dụng khác OUT
        // nó cũng khiến cho biến bên ngoài bị thay đổi VALUE như OUT nhưng .... lỏng lẻo ơn OUT , thích thì thay đổi bên ngoài  bằng lệnh gán, ko thích thì ko làm , ko bị báo lỗi 
        //1. ko chơi ON THE GO vì ko chắc sau khi gọi hàm có value nào trả về hay ko do REF ko cam kết mạnh như OUT
        //2. phài xài khai báo biến lẻ và phải gán DEFAULT VALUE nào đó trước khi gọi hàm REF 
        // hoặc là trả về DEFAULT , hoặc REF thay VALUE 
        // sau khi xài REF, OUT : biến đều phải có VALUE!!!
    }
}

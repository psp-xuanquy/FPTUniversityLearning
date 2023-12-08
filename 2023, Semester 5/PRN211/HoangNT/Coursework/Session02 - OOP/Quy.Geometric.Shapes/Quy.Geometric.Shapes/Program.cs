using Quy.Geometric.Shapes;

internal class Program
{
    private static void Main(string[] args)
    {
        //Chơi ĐA HÌNH luôn, gọi 1 hàm CHA nhưng 3 hàm CON chạy theo
        //Phải khai báo CHA new CON, CON chạy override CHA
        Shape[] list = new Shape[9];
        //Có 9 hình nào đó sắp xuất hiện, gọi chung là Shape, nhưng thực tế có thể là Triangle, Rectangle, Disk
        list[0] = new Disk("D1", "Red", 2);
        list[1] = new Disk("D2", "Pink", 1);
        list[2] = new Disk("D3", "Purple", 3);
        list[3] = new Triangle("T1", "Blue", 3, 4, 5);
        list[4] = new Triangle("T2", "Green", 8, 9, 10);
        list[5] = new Triangle("T3", "Orange", 6, 8, 10);
        list[6] = new Rectangle("R1", "Yellow", 1, 2);
        list[7] = new Rectangle("R2", "White", 4, 5);
        list[8] = new Rectangle("R3", "Black", 10, 20);

        foreach (var shape in list)
        {
            Console.WriteLine(shape.getArea());
        }


    }
}
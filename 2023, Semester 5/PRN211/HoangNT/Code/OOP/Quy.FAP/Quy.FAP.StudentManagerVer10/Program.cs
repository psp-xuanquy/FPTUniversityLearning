using Quy.FAP.StudentManagerVer10;

internal class Program
{
    private static void Main(string[] args)
    {
        //Có 2 cách new khi chơi vs kế thừa CHA-CON

            //Khai CON new CON
        Student s1 = new Student("SE01", "An", 2003, 1.1);

            //Khai CHA new CON
        Person s2 = new Student("SE02", "Binh", 2003, 2.2);

        Person l1 = new Lecturer("LE01", "Mr.A", 1993, 5_000_000);
        Lecturer l2 = new Lecturer("LE02", "Mr.B", 1994, 6_000_000);

        s1.ShowProfile();
        s2.ShowProfile();
        l1.ShowProfile();
        l2.ShowProfile();

        //Đưa các CON và chung 1 mảng CHA
        //Gọi hàm CHA, các CON hưởng ứng (override) -> tính đa hình xuất hiện
        //1 tên hàm có nhiều cách thực thi/chạy khác nhau
        //Từ 1 hàm của CHA (ShowProfile()), có nhiều hàm CON hưởng ứng -> Tính đa hình (Polymorphism)

        Console.WriteLine();

        //Person[] list = new Person[4];
        //list[0] = s1;
        //list[1] = s2;
        //list[2] = l1;
        //list[3] = l2;
        Person[] list = new Person[] { s1, s2, l1, l2, new Student("SE99", "999", 1999, 9.9) };

        foreach (Person p in list)
        {
            p.ShowProfile();   //Gọi 1 hàm CHA nhưng nhiều hàm CON khác nhau chạy
        }
    }
}
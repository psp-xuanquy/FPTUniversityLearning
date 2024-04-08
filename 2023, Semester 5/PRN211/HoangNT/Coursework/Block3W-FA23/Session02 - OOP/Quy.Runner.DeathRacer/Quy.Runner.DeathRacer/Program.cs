using Quy.Runner.DeathRacer;

internal class Program
{
    //private static void Main(string[] args)
    //{
    //    Student s1 = new Student() { Id = "SE242", Name = "Quy", Yob = 2003 };
    //    Console.WriteLine("s1 - racer: " + s1.RunToDeath()); 

    //    Drone d1 = new Drone() { Name = "Anihc", Model = "2023", Manifacture = "China" };
    //    Console.WriteLine("d1 - normal speed: " + d1.Run()); //chưa là đua thủ
    //    Console.WriteLine("d1 - racer: " + d1.RunToDeath()); //đã là đua thủ

    //    //HẤP DẪN ĐA HÌNH --- CUỘC ĐUA KÌ THÚ
    //    Racer[] racer = new Racer[4];
    //    //Khai CHA new CON, giống như abstract class
    //    racer[0] = new Student() { Id = "SE6789", Name = "San Bằng Tất Cả"};
    //    racer[1] = new Drone() { Name = "Anihc", Model = "2024", Manifacture = "RPC" };
    //    racer[2] = d1;
    //    racer[3] = s1;

    //    Racer[] r = { d1, s1, new Student() { Id = "SE6789", Name = "San Bằng Tất Cả" } };

    //    foreach (var x in racer)
    //    {
    //        Console.WriteLine("Speed: " + x.RunToDeath()); 
    //    }
    //}

    private static void Main(string[] args)
    {
        Drone d1 = new Drone() { Name = "I Factor 1", Model = "2023", Manifacture = "China" };
        Racer d2 = new Drone() { Name = "I Factor 2", Model = "2024", Manifacture = "China" };
        //Nếu muốn khai CHA new CON và xài thông tin của riêng CON thì phải dùng cách "ÉP KIỂU"
        Drone d3 = (Drone)d2;   //Cách 1
        Console.WriteLine(d3.Name);
        Console.WriteLine(((Drone)d2).Name);   //Cách 2

        Console.WriteLine("In full thông tin d2 theo style Drone thay vì style Racer: "
                                + ((Drone)d2).Name + " | "
                                + ((Drone)d2).Model + " | "
                                + ((Drone)d2).Manifacture);
    }
}
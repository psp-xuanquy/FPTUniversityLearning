using Quy.Runner.DeathRacer.Ass3;

internal class Program
{
    private static void Main(string[] args)
    {
        Student s1 = new Student() { Id = "SE242", Name = "Quy", Yob = 2003 };
        Console.WriteLine("s1 - racer: " + s1.RunToDeath()); 

        Drone d1 = new Drone() { Name = "Anihc", Model = "2023", Manifacture = "China" };
        Console.WriteLine("d1 - normal speed: " + d1.Run());
        Console.WriteLine("d1 - racer: " + d1.RunToDeath());

        Racer[] racer = new Racer[4];
        racer[0] = new Student() { Id = "SE6789", Name = "San Bằng Tất Cả"};
        racer[1] = new Drone() { Name = "Anihc", Model = "2024", Manifacture = "RPC" };
        racer[2] = d1;
        racer[3] = s1;

        Console.WriteLine(racer[0].GetType());

        Racer[] r = { d1, s1, new Student() { Id = "SE6789", Name = "San Bằng Tất Cả" } };

        foreach (var x in racer)
        {
            Console.WriteLine("Speed: " + x.RunToDeath()); 
        }
    }
}
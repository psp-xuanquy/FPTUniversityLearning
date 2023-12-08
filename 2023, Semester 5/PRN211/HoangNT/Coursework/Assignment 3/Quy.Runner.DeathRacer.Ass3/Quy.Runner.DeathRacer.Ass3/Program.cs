using Quy.Runner.DeathRacer.Ass3;

internal class Program
{
    private static void Main(string[] args)
    {
        Racer[] racer = new Racer[6];
        racer[0] = new Student() { Id = "SE01", Name = "An", Yob = 2002 };
        racer[1] = new Student() { Id = "SE02", Name = "Binh", Yob = 2004 };
        racer[2] = new Drone() { Name = "A Factor", Model = "2024", Manifacture = "RPC" };
        racer[3] = new Drone() { Name = "B Factor", Model = "2025", Manifacture = "USA" };
        racer[4] = new Employee() { Id = "E001", Name = "Xuan", Yob = 2003 };
        racer[5] = new Employee() { Id = "E002", Name = "Quy", Yob = 2003 };

        foreach (var x in racer)
        {
            Console.WriteLine($"Name: {x.GetType().Name}, Speed: {x.RunToDeath()}"); 
        }
    }
}
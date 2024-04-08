
public delegate void Say();

internal class Program
{
    private static void Main(string[] args)
    {
        Say f = () =>
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.Write(i + " ");
            }
        };
        f();
    }
}
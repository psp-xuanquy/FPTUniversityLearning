
public delegate void Say();
internal class Program
{
    private static void Main(string[] args)
    {
        //PrintIntList();

        //Say f = PrintIntList;
        //f();

        Say f1 = delegate ()
        {
            int i = 0;
            do
            {
                Console.Write(i + " ");
                i++;
            } while (i <= 100);
        };
        f1();
        Console.WriteLine("\n");
        Say f2 = () =>
        {
            int i = 0;
            do
            {
                Console.Write(i + " ");
                i++;
            } while (i <= 100);
        };
        f2();

    }

    public static void PrintIntList()
    {
        int i = 0;
        do 
        {
            Console.Write(i + " ");
            i++; 
        } while (i <= 100);
    }
}
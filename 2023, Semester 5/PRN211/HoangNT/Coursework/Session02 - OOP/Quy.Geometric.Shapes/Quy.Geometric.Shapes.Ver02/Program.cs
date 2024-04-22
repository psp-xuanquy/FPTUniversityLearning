using Quy.Geometric.Shapes.Ver02;

internal class Program
{
    private static void Main(string[] args)
    {
        Shape[] listShapes = new Shape[9];
        listShapes[0] = new Disk("D1", "Red", 2);
        listShapes[1] = new Disk("D2", "Pink", 4);
        listShapes[2] = new Disk("D3", "Purple", 6);
        listShapes[3] = new Triangle("T1", "Blue", 3, 4, 5);
        listShapes[4] = new Triangle("T2", "Green", 8, 9, 10);
        listShapes[5] = new Triangle("T3", "Orange", 6, 8, 10);
        listShapes[6] = new Rectangle("R1", "Yellow", 1, 2);
        listShapes[7] = new Rectangle("R2", "White", 4, 5);
        listShapes[8] = new Rectangle("R3", "Black", 10, 20);

        foreach (var shapes in listShapes)
        {
            Console.WriteLine(shapes.Area);
        }


    }
}
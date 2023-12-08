using Quy.Geometric.Shapes.Ass2;

internal class Program
{
    private static void Main(string[] args)
    {
        Shape[] listShapes = new Shape[9];
        listShapes[0] = new Disk("Disk", "Red", 2);
        listShapes[1] = new Disk("Disk", "Pink", 4);
        listShapes[2] = new Disk("Disk", "Purple", 6);
        listShapes[3] = new Triangle("Triangle", "Blue", 3, 4, 5);
        listShapes[4] = new Triangle("Triangle", "Green", 8, 9, 10);
        listShapes[5] = new Triangle("Triangle", "Orange", 6, 8, 10);
        listShapes[6] = new Rectangle("Rectangle", "Yellow", 1, 2);
        listShapes[7] = new Rectangle("Rectangle", "White", 4, 5);
        listShapes[8] = new Rectangle("Rectangle", "Black", 10, 20);

    //Show Information
        Console.WriteLine("------Show Information of each shape------");
        foreach (var shape in listShapes)
        {
            shape.ShowInfo();
            Console.WriteLine();
        }


    //Sorting Area in descending order using Bubble Sort
        Console.WriteLine("------List before Sorting------");
        foreach (var shape in listShapes)
        {
            Console.WriteLine(shape.Area);
        }

        for (int i = 0; i < listShapes.Length - 1; i++)
        {
            for (int j = 0; j < listShapes.Length - 1 - i; j++)
            {
                if (listShapes[j].Area < listShapes[j + 1].Area)
                {
                    Shape temp = listShapes[j];
                    listShapes[j] = listShapes[j + 1];
                    listShapes[j + 1] = temp;
                }
            }
        }

        Console.WriteLine();

        Console.WriteLine("------List after Sorting------");
        foreach (var shape in listShapes)
        {
            Console.WriteLine(shape.Area);
        }

    }
}
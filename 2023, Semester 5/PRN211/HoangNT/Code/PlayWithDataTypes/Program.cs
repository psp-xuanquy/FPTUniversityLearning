using System;

public class Program
{
    public static void PlayWithNull()
    {
        int yob;
        yob = 2003;

        int? age;
        age = null;

        Console.WriteLine("Year of Birth: " + yob);
        Console.WriteLine("Age: " + age);
    }

    public static int PlayWithOut(out int o1, out int o2)
    {
        o1 = 2;
        o2 = 3;
        return 1;
    }

    static int PlayWithRef(ref int r1, ref int r2)
    {
        //r1 = 39;
        //r2 = 79;
        return 5;
    }

    static void Sum(out int ans)
    {
        ans = 0;
        for (int i = 0; i <= 100; i++)
        {
            ans += i;
        }
        Console.WriteLine(ans);
    }

    static void PlayWithArray()
    {
        int[] arr = new int[] { 5, 10, 15, 20, 25, 30, 35, 40, 45, 50 };

        //Console.WriteLine($"Print out array: {arr[0]}, {arr[1]}, {arr[2]}, {arr[3]}, {arr[4]}, {arr[5]}");

        //for (int i = 0; i < arr.Length; i++)
        //{
        //    Console.Write(arr[i] + " ");
        //}

        foreach (int i in arr)
        {
            Console.Write(i + " ");
        }
    }

    public static void Main()
    {
        //int a, b, c;
        //a = PlayWithOut(out b, out c);
        //Console.WriteLine($"PlayWithOut: a-b-c has value of: {a} {b} {c}");
        //------PlayWithOut-----------------------------------------
        //int d = PlayWithOut(out int e, out int f);
        //Console.WriteLine($"PlayWithOut: d-e-f has value of: {d} {e} {f}");
        //------PlayWithRef-----------------------------------------
        //int a, b = 68, c = 69;       
        //Console.WriteLine($"Before PlayWithRef: b-c has value of: {b} {c}");

        //a = PlayWithRef(ref b, ref c);
        //Console.WriteLine($"After PlayWithRef: a-b-c has value of: {a} {b} {c}");

        //------"For" loop------------------------------------------
        //int ans = 0;
        //for (int i = 0; i <= 100; i++) 
        //{
        //    ans += i;
        //}
        //Console.WriteLine(ans);

        //------"While" loop-----------------------------------------
        //int ans = 0;
        //int i = 0;
        //while (i <= 100)
        //{
        //    ans += i;
        //    i++;
        //}
        //Console.WriteLine(ans);

        //------"Do-while" loop---------------------------------------
        //int ans = 0;
        //int i = 0;
        //do
        //{
        //    ans += i;
        //    i++;
        //}
        //while (i <= 100);
        //Console.WriteLine(ans);

        //Sum(out int ans);
        //Console.WriteLine($"Sum 1-->100 is: {ans}");

        PlayWithArray();
    }
}
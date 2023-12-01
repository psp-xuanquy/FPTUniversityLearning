using Quy.FAP.StudentManagerVer2;
using System.Security.Cryptography;
using System.Xml.Linq;

internal class Program
{
    private static void Main(string[] args)
    {
        Student s1 = new Student("SE-1", "Dao", 2003, 6.9);
        Console.WriteLine(s1.ToString());
    }
}
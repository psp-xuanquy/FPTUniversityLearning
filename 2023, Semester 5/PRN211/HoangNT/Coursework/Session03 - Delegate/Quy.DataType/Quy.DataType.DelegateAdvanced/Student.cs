using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quy.DataType.DelegateAdvanced
{
    internal class Student
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Yob { get; set; }
        public double Gpa { get; set; }

        //static
        public void SayHello() => Console.WriteLine("Hello, my name is " + Name);

        //non-static
        public static void SayMath() => Console.WriteLine("I am a student. You know that PI is actually 3.1415");

    }
}

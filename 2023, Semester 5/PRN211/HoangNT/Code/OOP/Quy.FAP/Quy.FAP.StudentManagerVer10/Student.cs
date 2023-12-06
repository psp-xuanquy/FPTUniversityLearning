using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quy.FAP.StudentManagerVer10
{
    internal class Student : Person
    {
        public double Gpa { get; set; }

        public Student(string id, string name, int yob, double gpa) : base(id, name, yob)
        {
            Gpa = gpa;
        }

        public override void ShowProfile()
        {
            Console.WriteLine($"ID: {Id} || Name: {Name} || Yob: {Yob} || GPA: {Gpa}");
        }
    }
}

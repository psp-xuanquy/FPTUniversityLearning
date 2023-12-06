using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quy.FAP.StudentManagerVer10
{
    internal class Lecturer : Person
    {
        public double Salary { get; set; }

        public Lecturer(string id, string name, int yob, double salary) : base(id, name, yob)
        {
            Salary = salary;
        }

        public override void ShowProfile()
        {
            Console.WriteLine($"ID: {Id} || Name: {Name} || Yob: {Yob} || Salary: {Salary}");
        }
    }
}

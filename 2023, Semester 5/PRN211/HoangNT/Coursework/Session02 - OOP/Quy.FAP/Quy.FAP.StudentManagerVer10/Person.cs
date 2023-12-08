using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quy.FAP.StudentManagerVer10
{
    internal class Person
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Yob { get; set; }

        public Person(string id, string name, int yob)
        {
            Id = id;
            Name = name;
            Yob = yob;
        }

        public virtual void ShowProfile()
        {
            Console.WriteLine($"ID: {Id} || Name: {Name} || Yob: {Yob}");
        }
    }
}

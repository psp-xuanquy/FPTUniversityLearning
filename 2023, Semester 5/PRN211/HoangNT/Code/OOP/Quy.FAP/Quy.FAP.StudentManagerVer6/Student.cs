using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Quy.FAP.StudentManagerVer6
{
    internal class Student
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Yob { get; set; }
        public double Gpa { get; set; }

        public Student(string id, string name)
        {
            Id = id;
            Name = name;
        }

        public Student(string id, string name, int yob, double gpa) : this(id, name)
        {
            Yob = yob;
            Gpa = gpa;
        }

        public Student()
        {
            
        }

        public override string? ToString()
        {
            return $"ID: {Id} || Name: {Name} || Yob: {Yob} || GPA: {Gpa}";
            //@$: chuỗi bên trong có gì in đấy
        }
    }
}

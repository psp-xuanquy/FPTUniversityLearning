using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Quy.FAP.StudentManagerVer5
{
    internal class Student
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Yob { get; set; }
        public double Gpa { get; set; }

        public override string? ToString()
        {
            return @$"Student Profile: ID: {Id}
                 Name: {Name}
                 Year Of Birth: {Yob}
                 GPA: {Gpa}";
            //@$: chuỗi bên trong có gì in đấy
        }

    }
}

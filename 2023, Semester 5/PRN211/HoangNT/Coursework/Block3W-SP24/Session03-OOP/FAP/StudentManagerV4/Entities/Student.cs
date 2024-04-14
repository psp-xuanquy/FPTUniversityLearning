using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagerV4.Entities
{
    internal class Student
    {
        private string _id;

        public string Id
        {
            get => _id;
            set => _id = value;
        }

        private string _name;

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        private int _yob;

        public int Yob
        {
            get => _yob;
            set => _yob = value;
        }

        private double _gpa;

        public double Gpa
        {
            get => _gpa;
            set => _gpa = value;
        }

        public override string ToString()
        {
            return $"{_id} {_name} {_yob} {_gpa}";
        }


        // ko có ToString() mà ráng gọi , thì sẽ in ra Data Type - tui là ai - class gì 


    }
}

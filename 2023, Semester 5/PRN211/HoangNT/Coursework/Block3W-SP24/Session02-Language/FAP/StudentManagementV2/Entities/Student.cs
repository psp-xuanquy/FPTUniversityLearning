using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementV2.Entities
{
    internal class Student
    {
        private string _id;
        private string _name;
        private string _email;
        private int _yob;
        private double _gpa;

        public Student(string id, string name, string email, int yob, double gpa)
        {
            _id = id;
            _name = name;
            _email = email;
            _yob = yob;
            _gpa = gpa;
        }

        public string GetId() { return _id; }
        public void SetId(string id) { _id = id; }

        public string GetName() { return _name; }
        public void SetName(string name) { _name = name; }


        public string GetEmail() { return _email; }
        public void SetEmail(string email) { _email = email; }



        public int Yob
        {
            get { return _yob; }
            set { _yob = value; }
        }

        public double Gpa //property - thuộc tính của object  
        {
            get => _gpa; 
            set =>  _gpa = value; 
        }
    }
}

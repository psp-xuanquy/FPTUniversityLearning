using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quy.FAP.StudentManagerVer2
{
    internal class Student
    {
        private string _id;
        private string _name;
        private int _yob;
        private double _gpa;

        public Student(string id, string name, int yob, double gpa)
        {
            _id = id;
            _name = name;
            _yob = yob;
            _gpa = gpa;
        }

        //Style truyền thống của C#
        //public string Id => _id;
        //public string Name => _name;
        //public int Yob => _yob;
        //public double Ggpa => _gpa;

        //public void SetId(string id) => _id = id; 

        //Get và Set chơi với Backfield để bàn về đặc tính của 1 object
        //trả ra infor, thay đổi infor
        //Xuất hiện trong mọi object

        public string Id { get => _id; set => _id = value; }
        //Id là 1 hàm bao hàm (cách viết gộp) cho GetId() và SetId() để mô tả Student.Id 1 cách tự nhiên hơn
        public string Name { get => _name; set => _name = value; }
        public int Yob { get => _yob; set => _yob = value; }
        public double Gpa { get => _gpa; set => _gpa = value; }
        //public double Gpa
        //{
        //    get
        //    {
        //        return _gpa;
        //    }

        //    set
        //    {
        //        _gpa = value;
        //    }
        //}

        public override string? ToString()
        {
            return @$"Student Profile: ID: {_id}
                 Name: {_name}
                 Year Of Birth: {_yob}
                 GPA: {_gpa}";
            //@$: chuỗi bên trong có gì in đấy
        }
    }
}

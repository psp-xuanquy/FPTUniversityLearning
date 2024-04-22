using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quy.FAP.StudentManager
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

        //Có thể có nhiều cách đúc để điền infor cho mỗi object => 1 task
        //Mặc định các infor cho mỗi object sẽ là private 
        //và khi ta muốn public info, ta có 2 cách:
        //1. Dùng public khi khai báo đặc tính
        //2. Get() Method

        //Nếu hàm chỉ có 1 lệnh, cho phép đc rút gọn
        public double GetGPA() 
        { 
            return _gpa;
        }
        public string GetId() { return _id;}
        public string GetName() => _name; //Cú pháp viết hàm STYLE EXPRESSION BODY

        //Ta có nhu cầu ĐỘ infor của 1 object => Set() Method giúp thay đổi info của 1 object nào đó
        public void SetName(string name) { this._name = name; }
        public void SetGPA(double gpa) { this._gpa = gpa; }
        public void SetYob(int yob) => _yob = yob; //EXPRESSION BODY

        //Show infor
        public void GetAllInfor()
        {
            Console.WriteLine(@$"Student Profile: ID: {_id}
                 Name: {_name}
                 Year Of Birth: {_yob}
                 GPA: {_gpa}");
            //@$: chuỗi bên trong có gì in đấy
            Console.WriteLine("\n");
        }
    }
}

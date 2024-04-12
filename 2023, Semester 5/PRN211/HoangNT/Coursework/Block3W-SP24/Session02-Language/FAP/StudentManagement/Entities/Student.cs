using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Entities
{
    // class là cái khuôn , Template , Form, phôi ( bằng) thẻ 
    //      bản thiết kế , BluePrint để dùng clone , nhân bản ra các project , thứ cụ thể chung nhóm class
    // OOP: phương pháp lập trình mà ta đi tìm project object...-> sau đó tìm ra các class -> từ class Clone ra các object cũ và mới => kỉ thuật quản lí info quanh ta
    internal class Student
    {
        // mô tả chung cho các object, đặc tính của nhóm object và hành vi của các object (hàm xử lí info)
        // mình có năm sinh (đặc tính), khi ai đó hỏi tuổi thì mình tính tuổi và trả ra kết quả (hàm - method, behaviour)

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
        public string GetName()
        {
            return _name;
        }
        public string GetEmail() => _email;
        public int GetYob() { return _yob; }
        public double GetGpa() => _gpa;

        // hàm Set() là hàm, hành động thay đổi info của 1 object đã tồn tại trc đó
        // nguyên tắc của hàm Set() là đưa đầu vào để fill vào bên trong
        public void SetGpa(double gpa) { _gpa = gpa; }

        public void ShowProfile()
        {
            Console.WriteLine($"Information of student ({_name}): {_id} - {_name} - {_email} - {_yob} - {_gpa}");
        }

        public override string ToString() => $"{_id} - {_name} - {_email} - {_yob} - {_gpa}";
    }
}

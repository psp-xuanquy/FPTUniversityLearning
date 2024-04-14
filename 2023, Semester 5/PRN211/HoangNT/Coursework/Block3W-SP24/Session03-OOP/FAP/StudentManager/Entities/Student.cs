using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManager.Entities
{
    // class là cái khuôn , Template , Form, phôi ( bằng) thẻ 
    //      bản thiết kế , BluePrint để dùng clone , nhân bản ra các project , thứ cụ thể chung nhóm class
    // OOP: phương pháp lập trình mà ta đi tìm project object...-> sau đó tìm ra các class -> từ class Clone ra các object cũ và mới => kỉ thuật quản lí info quanh ta  
    internal class Student
    {
        // mô tả cho các object, đặc tính của nhóm object
        // và hành vi của các object (hàm xử lí info)
        //mình có năm sinh ( đặc tính ), thì ai đó hỏi tuổi , mình tính tuổi và trả ra kq (hàm - method, behaviour)
        private string _id;     //____________
        private string _name;   //____________       
        private string _email;  //____________
        private int _yob;
        private double _gpa;    // java dùng camel Case Notation
                                //C# cùng dùng con lạc đà, nhưng thêm _
        public Student(string id, string name, string email, int yob, double gpa)
        {
            _id = id;
            _name = name;
            _email = email;
            _yob = yob;
            _gpa = gpa;
            //this._gpa = gpa;       //dư ko sai vì 2 biến đâu có lộn tên
        }

        public string GetId() { return _id; }
        public string GetName() { return _name; }
        public string GetEmail() => _email; //expression body ( bài cũ chỉ có 1 câu lệnh)
        public int GetYob() { return _yob; }
        public double Getgpa() => _gpa;


        // hàm Set() là hàm, hành động mà thay đổi info của 1 project đã tồn tại trước đó!!! tương tự set màn hình nền cho 1 cái điện thoại đã new trước đó
        //nguyên tắc hàm Set(đưa đầu vào để fill vào bên trong )

        public void SetGpa(double gpa) { _gpa = gpa; } // khác ở chỗ ko trả về thì chọn void 

        public void ShowProfile()
        {
            Console.WriteLine($"| {_id} | {_name} | {_email} | {_yob} | {_gpa} |");
        }

        //@Override
        public override string ToString() => $"| {_id} | {_name} | {_email} | {_yob} | {_gpa} |";


    }
}

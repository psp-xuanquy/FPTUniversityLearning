using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagerV2.Entities
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
        // ctrl . : tạo constructor


        //get và set 

        public string GetId() { return _id; }
        public void SetId(string id) { _id = id; }

        public string GetName() { return _name; }
        public void SetName(string name) { _name = name; }

        public string GetEmail() { return _email; }
        public void SetEmail(string email) { _email = email; }

        public string Email   // property - thuộc tính của object
        {
            get { return _email; }   // backing field. back field
            set { _email = value; }  // biến hậu trường lưu trữ value
                                     // biến nắm giữ 1 phần info của 1 object
        }
        // xài: hãy coi Email là 1 biến như mọi biến khác
        //trong nó bao hàm 2 hàm GetEmail() và SetEmail() tùy ngữ cảnh đụng vào biến Email

        //.Email = "an@"  ~~~~ SetEmail( "an@") {_email = "an@"}
        //.Email tương đương GetEmail(return back field_email)
        //GIÚP TƯƠNG TÁC OBJECT TỰ NHIÊN HƠN
        // dat.Email = "dat@" //set
        //cw(dat.Email) -> get

        //kĩ thuật viết get set kiểu này gọi là FULL PROPERTY
        // XÀI 1 BIẾN CHE GET SET BÊN TRONG , BÊN TRONG DÙNG _BACK FIELD

        public int Yob
        {
            get => _yob;
            set => _yob = value;    //.Yob = 2k2
        }
        // ctrl + k + d : giống căn lề code cho đẹp bên java 
        //Full property: hàm get và hàm set viết gộp qua 1 biến 
        //che Yob,Email, phía hậu trường xài _BACK FIELD

    }
}

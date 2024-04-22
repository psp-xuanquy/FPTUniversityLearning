using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Quy.FAP.StudentManagerVer4
{
    internal class Student
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Yob { get; set; }
        public double Gpa { get; set; }
        //prop + tab + tab tạo ra property stype viết tắt

        //Nếu 1 class ko có phễu(constructor), về logic, các khuôn - class nếu đem ra đúc object thì ta sẽ có object ko khí
        //Tức là 1 khuôn ko đổ value thì sẽ tạo ra 1 object mang giá trị mặc định(default)
        //1 class - 1 cái khuôn ta ko cần tạo constrcutor nhưng ta vẫn có thể tạo object
        //Bê cái khuôn ra, ta có sẵn 1 object ko khí
        //new class mà ko có contructor == bê khuôn ra ko đổ value gì cả
         
        //Default: number = 0; string = rỗng || null; bool = fault

        //Constructor rổng là constructor ko có tham số,tạo 1 object rỗng, default value

        public Student()
        {
        }

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

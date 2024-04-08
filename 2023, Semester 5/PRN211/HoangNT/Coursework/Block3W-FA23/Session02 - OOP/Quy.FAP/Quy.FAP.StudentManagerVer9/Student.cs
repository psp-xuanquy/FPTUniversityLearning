using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Quy.FAP.StudentManagerVer9
{
    internal class Student
    {
        public static string Id { get; set; }   //Đây là thiết kê SAI, các đặc tính của object ko đc dùng static
        public string Name { get; set; }
        public int Yob { get; set; }
        public double Gpa { get; set; }

        public Student(string id)
        {
            Id = id;
        }

        public override string? ToString() => $"ID: {Id} || Name: {Name} || Yob: {Yob}";

        public static void SayHello()
        {
            //Console.WriteLine("Hello, my name is: " + Name);
            Console.WriteLine("By the way, my Id is: " + Id);
        }


        //LƯU Ý:
            //KO được dùng static cho những đặc tính mà của riêng object
            //Muốn vào vùng static: Tên-class.tên-biến-static (vì nó dùng chung cho mọi object)
            //static CHỈ chơi với static, non-static chơi đc với non-static và cả static
            //Chỉ dùng static khi dùng các method mang ý nghĩa thư viện xài chung cho nhiều nơi
                //ex: Math.(các hàm toán học) 
            //Còn khi muốn lưu thông tin riêng cho từng object, ta dùng non-static  
            //static: khỏi new 1 vùng ram, xử lí xong trả về
    }
}

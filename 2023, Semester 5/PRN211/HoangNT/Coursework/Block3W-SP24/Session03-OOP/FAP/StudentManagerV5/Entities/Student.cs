using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagerV5.Entities
{
    internal class Student
    {
        //propfull tab -> property full kiểu style _backing field
        //prop tab tab  style gọn , AUTO -GENERATED PROPERTY
        //Java thì phải cài thêm thư viện bên ngoài  - DEPENDENCY LOMBOK
        public string Id { get; set; }
        public string Name { get; set; }  // = "Ngọc Trinh"
        public int Yob { get; set; }
        public double Gpa { get; set; }

        public Student(string id, string name)
        {
            Id = id;
            Name = name;
        }
        // ctor tab : tạo hàm rỗng 
        public Student()
        {

        }

        public override string ToString() => $"{Id} {Name} {Yob} {Gpa}"; // Get()


        //kĩ thuật Property kiểu này giúp tối ưu công việc viết code, tránh viết những đoạn code nhàm chán kiểu get => ... set => ...
        //đoạn thân hàm của get set rất giống nhau, mắc mớ gì viết, viết get set SDK đảm nhận thêm việc generate nốt phần giống nhau
        //KĨ THUẬT NÀY TA BỎ LUÔN CẢ _BACKING FIELD CHO GỌN
        //SDK SẼ TỰ SINH RA _BACKING FIELD DỰA TRÊN TÊN PROPERTY
        //KĨ THUẬT NÀY ĐƯỢC GỌI LÀ AUTO GENERATED PROPERTY
        //KĨ THUẬT XÀI _BACKING ĐC GỌI LÀ FULL PROPERTY

        //MAP CLASS NÀY XUỐNG TABLE, THÌ DÙNG AUTO GENERATED CHO GỌN CODE, DỄ KIỂM SOÁT CODE
        //TƯỞNG TƯỢNG STUDENT CÓ 20 CỘT DATA
    }
}
/*
 private string _id;
		private string _name;
		private int _yob;
		private double _gpa;

		public string Id
		{
            get;//=> _id; 
            set;//{ _id = value; }
		}

        public string Name
        {
            get ;
            set;
        }
        public int Yob
        {
            get;
            set;
        }
public double Gpa{ get;set;}
 */
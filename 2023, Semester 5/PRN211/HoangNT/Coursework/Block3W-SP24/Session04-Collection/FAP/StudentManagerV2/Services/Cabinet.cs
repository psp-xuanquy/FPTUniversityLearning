using StudentManagerV2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagerV2.Services
{
    internal class Cabinet   // Là cái tủ chứa nhiều bộ hồ sơ
                             // 1 mảng student - giống như không gian của cái tủ ngoài đời
                             // mảng chưa nhiều hồ sơ value là tương đương
                             // new Cabinet() tức là ta có 1 mảng riêng cho từng cabinet

    {
        // property, backing field
        private Student[] _students = new Student[30]; //new Student[size];

        //public Cabinet(int size) { _students = new Student[size]; }

        private int _count = 0;

        // In toàn bộ danh sách sinh viên
        public void PrintStudentList()
        {
            Console.WriteLine($"There is/are {_count} student(s) in the list");
            for (int i = 0; i < _count; i++)
            {
                Console.WriteLine(_students[i]);
            }
        }

        // Cái tủ có các hành động CRUD (Create - Retrieve/Read - Update - Delete)

        public void AddStudent(Student s)
        {
            _students[_count] = s;  // trỏ đến 1 new Student() ở chỗ nào đó
            _count++;

            // TODO: Mảng đầy thì sao???
            // If kiểm tra count đã full
        } 
    }
}

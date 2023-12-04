using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quy.FAP.StudentManagerVer7
{
    /// <summary>
    /// Class này dùng để lưu trữ tối đa 30 hồ sơ sv
    /// Class này cung cấp các hàm cung cấp hồ sơ sv
    /// </summary>
    internal class MyList
    {
        //Thay vì khai báo mảng bên Main(), ta đưa mảng vào tủ
        //Main() sau này có thể khai báo nhiều tủ theo nhu cầu
        //OOP ngon: new tủ, CRUD trong tủ

        private Student[] _list = new Student[30];
        private int _count = 0;

        //Tủ sẽ có CRUD hồ sơ sinh viên
        /// <summary>
        /// Hàm này sẽ lưu 1 hồ sơ sv vào bên trong tối đa 30 sv
        /// Bạn cần cung cấp 1 object sv đã đc lưu ở đâu đó trc
        /// </summary>
        /// <param name="s"></param>
        public void addNew(Student s) //Nhập đâu đó, new đâu đó, đưa nguyên new Student, object tham chiếu vào
        {
            //_list[i] = new Student(...);
            _list[_count] = s;
            _count++;
        }

        /// <summary>
        ///  Hàm này dùng để in ra danh sách các hồ sơ đang đc lưu trữ
        /// </summary>
        public void printByIDAsc()
        {
            Console.WriteLine($"There are {_count} student(s) in the list (Sorting by ID ascending)");

            //Sắp xếp ID trc khi in
            for (int i = 0; i < _count - 1; i++)
            {
                for (int j = i + 1; j < _count; j++)
                {
                    if (_list[i].Id.CompareTo(_list[j].Id) > 0)
                    {
                        var tmp = _list[i];
                        _list[i] = _list[j];
                        _list[j] = tmp;
                    }
                }
            }

            //Ta ko in bằng "foreach" vì ko biết mảng đã full chưa
            for (int i = 0; i < _count; i++)
            {
                Console.WriteLine(_list[i]); //Gọi ngầm ToString() của từng sv
                //[i] chỉ mới là biến sv
            }
        }

        public void printByGpaDesc()
        {
            Console.WriteLine($"There are {_count} student(s) in the list (Sorting by GPA descending)");

            //Sắp xếp ID trc khi in
            for (int i = 0; i < _count - 1; i++)
            {
                for (int j = i + 1; i < _count; i++)
                {
                    if (_list[i].Gpa < _list[j].Gpa)
                    {
                        var tmp = _list[i];
                        _list[i] = _list[j];
                        _list[j] = tmp;
                    }
                }
            }

            //Ta ko in bằng "foreach" vì ko biết mảng đã full chưa
            for (int i = 0; i < _count; i++)
            {
                Console.WriteLine(_list[i]); //Gọi ngầm ToString() của từng sv
                //[i] chỉ mới là biến sv
            }
        }

        public void addNew() //Hàm này đc gọi thì sẽ có lệnh nhập info từng sv
        {
            //    //_list[i] = new Student(...);
        }
    }
}

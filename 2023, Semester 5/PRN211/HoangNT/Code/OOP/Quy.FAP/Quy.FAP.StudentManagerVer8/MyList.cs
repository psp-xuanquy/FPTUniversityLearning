using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quy.FAP.StudentManagerVer8
{
    internal class MyList<T>  //T = Type: 1 loại class nào đó đưa vào
                              //T có thể là <Lecturer>, <Student>, <Customer> 
                              //Kỹ thuật Generic: khi Data type là 1 tham số, xài Data type nào thì đưa Data type đó vào
                              //mảng sẽ là mảng của Data type tương ứng
    {
        //private Student[] _list = new Student[30];
        //private Lecturer[] _list = new Lecturer[30];
        private T[] _list = new T[20];
        private int _count = 0; //dùng để đếm số object đã đưa vào mảng

        public void AddNew(T s)
        {
            _list[_count] = s;
            _count++;
        }

        public void PrintList()
        {
            Console.WriteLine($"There are {_count} person(s) in the list");
            //Ko thể dùng "Foreach" loop vì mảng có thể chưa đầy, ta chỉ for đến _count
            for (int i = 0; i < _count; i++)
            {
                Console.WriteLine(_list[i].ToString());
            }
        }
        //Tại thời điểm này ta ko thể làm hàm Sort đc 
        //vì chưa biết object đưa vào là GV, SV, Customers,... Mỗi loại này có property khác nhau

        //Để vẫn Sort đc chấp T là gì, ta dùng kĩ thuật DEPENDENCY INJECTION kết hợp vs DELEGATE
        //                                       (Java: DEPENDENCY INJECTION + FUNCTIONAL INTERFACE  + LAMBDA EXPRESSION)


    }
}

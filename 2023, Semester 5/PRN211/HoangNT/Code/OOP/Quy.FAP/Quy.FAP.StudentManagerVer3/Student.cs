using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quy.FAP.StudentManagerVer3
{
    internal class Student
    {
        //gõ propfull + tab + tab giúp tự động generate backed field + get/set chuẩn mới
        private int myVar;

        public int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }
        //get/set có backed field gọi là full property


    }
}

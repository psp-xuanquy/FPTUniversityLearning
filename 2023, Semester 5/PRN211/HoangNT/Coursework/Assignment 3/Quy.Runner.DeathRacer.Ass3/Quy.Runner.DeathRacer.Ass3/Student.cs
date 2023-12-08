using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quy.Runner.DeathRacer.Ass3
{
    internal class Student : Racer
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Yob { get; set; }
        public double Gpa { get; set; }

        //1 student vẫn là nó, nhưng có các đặc tính riêng 
        public void DoQuiz()   //1 hành động bth của 1 Student
        {
            Console.WriteLine("Hi proctor, I'm doing PRN211 quizzes");
        }

        //Vì sv đã tham gia vào clb đua Racer thì phải cam kết có hàm RunToDeath()
        public double RunToDeath() => System.Random.Shared.NextDouble() + 100;
    }
}

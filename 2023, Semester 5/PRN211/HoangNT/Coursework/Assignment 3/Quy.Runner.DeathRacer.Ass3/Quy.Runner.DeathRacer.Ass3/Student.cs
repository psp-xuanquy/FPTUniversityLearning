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

        public void DoQuiz()
        {
            Console.WriteLine("Hi proctor, I'm doing PRN211 quizzes");
        }

        public double RunToDeath() => System.Random.Shared.NextDouble() + 100;
    }
}

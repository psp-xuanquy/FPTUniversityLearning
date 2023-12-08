using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quy.Runner.DeathRacer.Ass3
{
    internal class Employee : Racer
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Yob { get; set; }
        public double Salary { get; set; }

        public void DoWork()
        {
            Console.WriteLine("Hi proctor, I'm working like a horse");
        }

        public double RunToDeath() => System.Random.Shared.NextDouble() + 200;
    }
}

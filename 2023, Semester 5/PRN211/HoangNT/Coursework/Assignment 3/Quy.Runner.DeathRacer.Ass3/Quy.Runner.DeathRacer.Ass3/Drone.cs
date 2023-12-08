using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quy.Runner.DeathRacer.Ass3
{
    internal class Drone : Racer
    {
        public string Name { get; set; }    
        public string Model { get; set; }
        public string Manifacture { get; set; }

        public double Run()
        {
            return System.Random.Shared.NextDouble();
        }
        
        public double RunToDeath() => System.Random.Shared.NextDouble() + 300;
    }
}

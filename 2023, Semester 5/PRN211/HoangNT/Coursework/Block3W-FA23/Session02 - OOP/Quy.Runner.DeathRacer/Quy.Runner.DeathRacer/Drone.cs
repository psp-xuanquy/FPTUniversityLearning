using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quy.Runner.DeathRacer
{
    internal class Drone : Racer
    {
        public string Name { get; set; }    
        public string Model { get; set; }
        public string Manifacture { get; set; }

        //1 con drone vẫn là nó, nhưng có các đặc tính riêng 
        public double Run()   //1 hành động bth của 1 con Drone
        {
            return System.Random.Shared.NextDouble();
        }
        //Để tham gia đua thì phải độ cấu hình để có tốc độ cao
        //Để tham gia đua thì phải cam kết có tốc độ cao và tham gia vào clb đua - Racer
        //Drone vừa là Drone, vừa là Racer

        //Vì tham gia clb đua Racer thì phải cam kết có hàm RunToDeath()
        public double RunToDeath() => System.Random.Shared.NextDouble() + 300;
    }
}

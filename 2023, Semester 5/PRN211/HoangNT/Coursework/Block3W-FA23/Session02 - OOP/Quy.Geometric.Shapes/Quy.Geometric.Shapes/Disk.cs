using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quy.Geometric.Shapes
{
    internal class Disk : Shape
    {
        public double Radius {  get; set; }

        public Disk(string name, string color, double radius) : base(name, color)
        {
            Radius = radius;
        }

        public override double getArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}

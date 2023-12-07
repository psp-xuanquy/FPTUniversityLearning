using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quy.Geometric.Shapes.Ver02
{
    internal class Disk : Shape
    {
        public double Radius {  get; set; }

        public Disk(string name, string color, double radius) : base(name, color)
        {
            Radius = radius;
        }

        public override double Area => Math.PI * Math.Pow(Radius, 2);

        public override string ShowInfo() => $"The area of a {Color} {Name} with radius {Radius} cm is: {Area}";
    }
}

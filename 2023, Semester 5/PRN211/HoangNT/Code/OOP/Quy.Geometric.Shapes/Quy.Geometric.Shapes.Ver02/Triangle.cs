using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quy.Geometric.Shapes.Ver02
{
    internal class Triangle : Shape
    {
        public double Side1 { get; set; }
        public double Side2 { get; set; }
        public double Side3 { get; set; }

        public Triangle(string name, string color, double side1, double side2, double side3) : base(name, color)
        {
            Side1 = side1;
            Side2 = side2;
            Side3 = side3;
        }

        public override double Area
        {
            get
            {
                double p = (Side1 + Side2 + Side3) / 2;
                return Math.Sqrt(p * (p - Side1) * (p - Side2) * (p - Side3));
            }
        }
    }
}

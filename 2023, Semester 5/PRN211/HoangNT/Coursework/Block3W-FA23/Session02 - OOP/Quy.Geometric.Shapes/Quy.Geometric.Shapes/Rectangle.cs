using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quy.Geometric.Shapes
{
    internal class Rectangle :Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(string name, string color, double width, double height) : base(name, color)
        {
            Height = height;
            Width = width;
        }

        public override double getArea()
        {
            return Width * Height;
        }
    }
}

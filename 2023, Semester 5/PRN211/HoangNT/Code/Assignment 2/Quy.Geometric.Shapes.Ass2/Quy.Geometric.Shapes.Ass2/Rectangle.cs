using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quy.Geometric.Shapes.Ass2
{
    internal class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(string name, string color, double width, double height) : base(name, color)
        {
            Width = width;
            Height = height;
        }

        public override double Area => Width * Height;

        public override void ShowInfo()
        {
            Console.WriteLine($"The area of a {Color} {Name} with width {Width} and height {Height} is: {Area}");
        }
    }
}

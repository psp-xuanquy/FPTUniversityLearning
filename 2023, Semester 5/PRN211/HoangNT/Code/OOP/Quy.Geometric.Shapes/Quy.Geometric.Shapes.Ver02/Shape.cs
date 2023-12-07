using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quy.Geometric.Shapes.Ver02
{
    internal abstract class Shape
    {
        //CHA là nhân tử chung của các CON
        //CON nào cũng có đặc điểm của CHA --> Thừa kế
        //Các hình nói chung có info gì, hành động gì, các class CON sẽ có những hành động y chang vậy
        public string Name { get; set; }
        public string Color { get; set; }

        protected Shape(string name, string color)
        {
            Name = name;
            Color = color;
        }

        public abstract double Area { get; }
    }
}

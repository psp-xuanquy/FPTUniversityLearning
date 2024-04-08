using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quy.Geometric.Shapes
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

        public abstract double getArea();   //Là khái niệm về đo diện tích bề mặt của 1 hình
                                           //Phải có hình cụ thể mới có thể đo cụ thể ra sao.
                                           //Ta để tên hàm ở đây vì nó là khái niệm cho mọi hình,
                                           //nhưng ta chưa thể tính đc cụ thể số liệu do Hình chung chung



    }
}

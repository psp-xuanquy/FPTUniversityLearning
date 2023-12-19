using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    public class ViewProduct
    {
        public string ProductId { get; set; } = null!;
        public string ProductName { get; set; } = null!;
        public string ProductSpecies { get; set; } = null!;
        public string ProductType { get; set; } = null!;
        public decimal Price { get; set; }
    }
}

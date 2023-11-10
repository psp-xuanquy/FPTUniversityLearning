using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObject.Models
{
    public partial class TblProduct
    {
        public TblProduct()
        {
            TblOrderDetails = new HashSet<TblOrderDetail>();
        }

        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public double? Price { get; set; }
        public int? Quantity { get; set; }
        public string ImageSrc { get; set; }
        public string CategoryId { get; set; }
        public string StatusId { get; set; }

        public virtual TblCategory Category { get; set; }
        public virtual TblStatus Status { get; set; }
        public virtual ICollection<TblOrderDetail> TblOrderDetails { get; set; }
    }
}

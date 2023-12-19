using System;
using System.Collections.Generic;

namespace BusinessObject.Models
{
    public partial class TbOrderItem
    {
        public string OrderItemId { get; set; } = null!;
        public string ProductId { get; set; } = null!;
        public string OrderId { get; set; } = null!;
        public decimal Price { get; set; }
        public bool StatusPending { get; set; }
        public bool StatusProcess { get; set; }
        public bool StatusCancel { get; set; }

        public virtual TbOrder Order { get; set; } = null!;
    }
}

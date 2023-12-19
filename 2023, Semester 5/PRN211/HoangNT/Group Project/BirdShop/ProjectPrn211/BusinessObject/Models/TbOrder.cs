using System;
using System.Collections.Generic;

namespace BusinessObject.Models
{
    public partial class TbOrder
    {
        public TbOrder()
        {
            TbOrderItems = new HashSet<TbOrderItem>();
        }

        public string OrderId { get; set; } = null!;
        public string UserId { get; set; } = null!;
        public string Address { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public string PaymentMethodId { get; set; } = null!;
        public string ProviderId { get; set; } = null!;
        public decimal Total { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime EstimatedDate { get; set; }
        public bool Status { get; set; }

        public virtual TbPaymentMethod PaymentMethod { get; set; } = null!;
        public virtual TbProvider Provider { get; set; } = null!;
        public virtual TbUser User { get; set; } = null!;
        public virtual ICollection<TbOrderItem> TbOrderItems { get; set; }
    }
}

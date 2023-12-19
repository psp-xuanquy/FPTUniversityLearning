using System;
using System.Collections.Generic;

namespace BusinessObject.Models
{
    public partial class TbPaymentMethod
    {
        public TbPaymentMethod()
        {
            TbOrders = new HashSet<TbOrder>();
        }

        public string PaymentMethodId { get; set; } = null!;
        public string PaymentMethodName { get; set; } = null!;

        public virtual ICollection<TbOrder> TbOrders { get; set; }
    }
}

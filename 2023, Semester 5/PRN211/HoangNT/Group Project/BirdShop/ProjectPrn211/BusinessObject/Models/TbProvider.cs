using System;
using System.Collections.Generic;

namespace BusinessObject.Models
{
    public partial class TbProvider
    {
        public TbProvider()
        {
            TbOrders = new HashSet<TbOrder>();
        }

        public string ProviderId { get; set; } = null!;
        public string? ProviderName { get; set; }

        public virtual ICollection<TbOrder> TbOrders { get; set; }
    }
}

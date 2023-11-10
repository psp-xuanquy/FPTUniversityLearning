using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObject.Models
{
    public partial class TblStatus
    {
        public TblStatus()
        {
            TblOrders = new HashSet<TblOrder>();
            TblProducts = new HashSet<TblProduct>();
            TblStaffs = new HashSet<TblStaff>();
        }

        public string StatusId { get; set; }
        public string StatusName { get; set; }

        public virtual ICollection<TblOrder> TblOrders { get; set; }
        public virtual ICollection<TblProduct> TblProducts { get; set; }
        public virtual ICollection<TblStaff> TblStaffs { get; set; }
    }
}

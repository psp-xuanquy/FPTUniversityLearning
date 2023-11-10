using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObject.Models
{
    public partial class TblStaff
    {
        public TblStaff()
        {
            TblOrders = new HashSet<TblOrder>();
        }

        public string StaffId { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        public string RoleId { get; set; }
        public string StatusId { get; set; }
        public string Email { get; set; }

        public virtual TblRole Role { get; set; }
        public virtual TblStatus Status { get; set; }
        public virtual ICollection<TblOrder> TblOrders { get; set; }
    }
}

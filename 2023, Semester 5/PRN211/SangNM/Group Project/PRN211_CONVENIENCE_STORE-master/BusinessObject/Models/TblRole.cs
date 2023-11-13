using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObject.Models
{
    public partial class TblRole
    {
        public TblRole()
        {
            TblStaffs = new HashSet<TblStaff>();
        }

        public string RoleId { get; set; }
        public string RoleName { get; set; }

        public virtual ICollection<TblStaff> TblStaffs { get; set; }
    }
}

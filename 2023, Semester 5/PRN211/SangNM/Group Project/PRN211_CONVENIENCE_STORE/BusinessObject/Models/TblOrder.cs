using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObject.Models
{
    public partial class TblOrder
    {
        public TblOrder()
        {
            TblOrderDetails = new HashSet<TblOrderDetail>();
        }

        public Guid OrderId { get; set; }
        public string StaffId { get; set; }
        public string CustomerName { get; set; }
        public DateTime? Date { get; set; }
        public double? OrderPrice { get; set; }
        public string StatusId { get; set; }
        public string PaymentMethod { get; set; }

        public virtual TblStaff Staff { get; set; }
        public virtual TblStatus Status { get; set; }
        public virtual ICollection<TblOrderDetail> TblOrderDetails { get; set; }

        public override string ToString()
        {
            return $"{{{nameof(OrderId)}={OrderId.ToString()}, {nameof(StaffId)}={StaffId}, {nameof(CustomerName)}={CustomerName}, {nameof(Date)}={Date.ToString()}, {nameof(OrderPrice)}={OrderPrice.ToString()}, {nameof(StatusId)}={StatusId}, {nameof(PaymentMethod)}={PaymentMethod}, {nameof(Staff)}={Staff}, {nameof(Status)}={Status}, {nameof(TblOrderDetails)}={TblOrderDetails}}}";
        }
    }
}

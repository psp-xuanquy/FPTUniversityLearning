using System;
using System.Collections.Generic;

namespace BusinessObject
{
    public partial class AirConditioner
    {
        public int AirConditionerID { get; set; }
        public string AirConditionerName { get; set; } = null!;
        public string? Warranty { get; set; }
        public string? SoundPressureLevel { get; set; }
        public string? FeatureFunction { get; set; }
        public int? Quantity { get; set; }
        public double? DollarPrice { get; set; }
        public string? SupplierId { get; set; }

        public virtual SupplierCompany? Supplier { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Repositories;

public partial class Manufacturer
{
    public string ManufacturerId { get; set; } = null!;

    public string ManufacturerName { get; set; } = null!;

    public string ManufacturerDescription { get; set; } = null!;

    public virtual ICollection<Sunglass> Sunglasses { get; set; } = new List<Sunglass>();
}

using System;
using System.Collections.Generic;

namespace BusinessObject.Models
{
    public partial class TbBreeding
    {
        public string BreedingId { get; set; } = null!;
        public string BirdMaleId { get; set; } = null!;
        public string BirdFemaleId { get; set; } = null!;
        public bool StatusDone { get; set; }

        public virtual TbBird BirdFemale { get; set; } = null!;
        public virtual TbBird BirdMale { get; set; } = null!;
    }
}

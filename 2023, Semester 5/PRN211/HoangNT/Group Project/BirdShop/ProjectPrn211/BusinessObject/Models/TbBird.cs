using System;
using System.Collections.Generic;

namespace BusinessObject.Models
{
    public partial class TbBird
    {
        public TbBird()
        {
            TbBreedingBirdFemales = new HashSet<TbBreeding>();
            TbBreedingBirdMales = new HashSet<TbBreeding>();
            TbNestBirdIdFemaleNavigations = new HashSet<TbNest>();
            TbNestBirdIdMaleNavigations = new HashSet<TbNest>();
        }

        public string BirdId { get; set; } = null!;
        public string BirdSpeciesId { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string Gender { get; set; } = null!;
        public DateTime BirthMonthYear { get; set; }
        public double Age
        {
            get
            {
                int monthsDiff = (DateTime.Now.Year - BirthMonthYear.Year) * 12 + (DateTime.Now.Month - BirthMonthYear.Month);
                double age = monthsDiff / 12.0;
                return Math.Round(age, 1);
            }
        }
        public string? Description { get; set; }
        public string BirdImage { get; set; } = null!;
        public decimal Price { get; set; }
        public bool OffspringAvailable { get; set; }
        public bool StatusSelling { get; set; }
        public bool StatusSold { get; set; }

        public virtual TbBirdCategory BirdSpecies { get; set; } = null!;
        public virtual ICollection<TbBreeding> TbBreedingBirdFemales { get; set; }
        public virtual ICollection<TbBreeding> TbBreedingBirdMales { get; set; }
        public virtual ICollection<TbNest> TbNestBirdIdFemaleNavigations { get; set; }
        public virtual ICollection<TbNest> TbNestBirdIdMaleNavigations { get; set; }
    }
}

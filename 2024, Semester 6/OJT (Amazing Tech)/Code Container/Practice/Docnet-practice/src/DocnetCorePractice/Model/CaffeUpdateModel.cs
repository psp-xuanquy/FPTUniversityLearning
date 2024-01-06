using System.ComponentModel.DataAnnotations;

namespace DocnetCorePractice.Model
{
    public class CaffeUpdateModel
    {
        [Required]
        public string Id { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Price must be greater than or equal to 0.")]
        public double Price { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Discount must be greater than or equal to 0.")]
        public int Discount { get; set; }
    }
}

using BookAPI.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookAPI.Models
{
    public class BookModel
    {
        public Guid BookId { get; set; }

        [Required]
        [MaxLength(100)]
        public string Title { get; set; }

        [Required]
        [MaxLength(100)]
        public string GenreName { get; set; }

        public Genre Genre { get; set; }

        public string Description { get; set; }

        [Required]
        [MaxLength(100)]
        public string AuthorName { get; set; }

        public Author Author { get; set; }

        [Range(0, double.MaxValue)]
        public double Price { get; set; }

        public byte Discount { get; set; }

        public ICollection<OrderDetail> OrderDetails { get; set; }

        public BookModel()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }
    }
}

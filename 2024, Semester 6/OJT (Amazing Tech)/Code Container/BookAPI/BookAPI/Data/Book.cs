using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookAPI.Data
{
    [Table("Book")]
    public class Book
    {
        [Key]
        public Guid BookId { get; set; }

        [Required]
        [MaxLength(100)]
        public string? Title { get; set; }

        [Required]
        [MaxLength(100)]
        public string? GenreName { get; set; }

        [ForeignKey("GenreName")]
        public Genre Genre { get; set; }

        public string? Description { get; set; }

        [Required]
        [MaxLength(100)]
        public string? AuthorName { get; set; }

        [ForeignKey("AuthorName")]
        public Author Author { get; set; }

        [Range(0, double.MaxValue)]
        public double Price { get; set; }

        public byte Discount { get; set; }


        public ICollection<OrderDetail> OrderDetails { get; set; }

        public Book()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }
    }
}

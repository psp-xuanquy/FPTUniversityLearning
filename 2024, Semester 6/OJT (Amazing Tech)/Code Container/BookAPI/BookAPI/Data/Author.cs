using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookAPI.Data
{
    [Table("Author")]
    public class Author
    {
        [Key]
        public int AuthorId { get; set; }

        [Required]
        [MaxLength(100)]
        public string AuthorName { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}

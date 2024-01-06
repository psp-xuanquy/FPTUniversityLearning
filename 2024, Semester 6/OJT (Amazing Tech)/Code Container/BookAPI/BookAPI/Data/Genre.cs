using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookAPI.Data
{
    [Table("Genre")]
    public class Genre
    {
        [Key]
        public int GenreId { get; set; }

        [Required]
        [MaxLength(100)]
        public string GenreName { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}

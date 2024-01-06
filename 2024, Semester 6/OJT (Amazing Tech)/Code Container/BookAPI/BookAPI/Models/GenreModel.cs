using BookAPI.Data;
using System.ComponentModel.DataAnnotations;

namespace BookAPI.Models
{
    public class GenreModel
    {
        public int GenreId { get; set; }

        [Required]
        [MaxLength(100)]
        public string GenreName { get; set; }

        public ICollection<BookModel> Books { get; set; }
    }
}

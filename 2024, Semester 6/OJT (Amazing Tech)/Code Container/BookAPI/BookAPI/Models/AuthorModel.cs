using BookAPI.Data;
using System.ComponentModel.DataAnnotations;

namespace BookAPI.Models
{
    public class AuthorModel
    {
        public int AuthorId { get; set; }

        [Required]
        [MaxLength(100)]
        public string AuthorName { get; set; }

        public ICollection<BookModel> Books { get; set; }
    }
}

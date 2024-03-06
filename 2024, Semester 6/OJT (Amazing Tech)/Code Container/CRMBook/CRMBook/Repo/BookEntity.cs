using CRMBook.Models;

namespace CRMBook.Repo
{
    public class BookEntity
    {
        public int  Book_id { get; set; }
        public string? Name { get; set; }
        public string? Author { get; set; }
        public string Description { get; set; } = null!;
        public string? Category { get; set; }
        public decimal? Price { get; set; }
        public string? Accout_id { get; set; }
    }
}

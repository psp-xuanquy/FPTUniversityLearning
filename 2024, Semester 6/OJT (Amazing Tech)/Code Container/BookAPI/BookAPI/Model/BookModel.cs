using BookAPI.Enum;

namespace BookAPI.Model
{
    public class BookModel
    {
        public int BookId { get; set; }
        public string BookName { get; set; }
        public GenreType BookGenreType { get; set; }
        public string Author { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public int Discount { get; set; }
    }
}

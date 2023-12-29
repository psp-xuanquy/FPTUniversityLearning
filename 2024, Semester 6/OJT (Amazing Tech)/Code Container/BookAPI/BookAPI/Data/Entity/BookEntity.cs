using BookAPI.Enum;

namespace BookAPI.Data.Entity
{
    public class BookEntity : Entity
    {
        public string BookName { get; set; }
        public GenreType BookGenreType { get; set; }
        public string Author { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public int Discount { get; set; }
        public bool IsActive { get; set; }
    }
}

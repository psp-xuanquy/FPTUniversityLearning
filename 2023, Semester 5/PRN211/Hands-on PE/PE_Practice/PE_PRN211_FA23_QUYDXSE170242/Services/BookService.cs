using Repositories;
using Repositories.Entities;

namespace Services
{
    public class BookService
    {
        private BookRepository _repo = new BookRepository();
        
        public List<Book> GetAllBooks()
        {
            return _repo.GetAll();
        }

        public List<Book> SearchBooks(string keyword)
        {
            return _repo.GetAll().Where(b => b.BookName.ToLower().Contains(keyword.ToLower()) ||
                                             b.Description.ToLower().Contains(keyword.ToLower())).ToList();
        }

        public void DeleteABook(int id)
        {
            _repo.Delete(id);
        }

        public Book? GetABook(int id)
        {
            return _repo.Get(id);
        }

        public void AddABook(Book book)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(book.BookName) || string.IsNullOrWhiteSpace(book.Description) ||
                    string.IsNullOrWhiteSpace(book.Author) || book.ReleaseDate == DateTime.MinValue ||
                    book.Quantity <= 0 || book.Price <= 0 || book.BookCategoryId <= 0)
                {
                    throw new ArgumentException("All input fields must be filled.", nameof(book));
                }

                if (_repo.Get(book.BookId) != null)
                {
                    throw new InvalidOperationException($"Book with ID {book.BookId} already exists.");
                }

                _repo.Create(book);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error adding book: {ex.Message}");
                throw;
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"Error adding book: {ex.Message}");
                throw;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error adding book: {ex.Message}");
                throw;
            }
        }

        public void UpdateABook(Book book)
        {
            try
            {
                if (book.BookId <= 0 || string.IsNullOrWhiteSpace(book.BookName) ||
                    string.IsNullOrWhiteSpace(book.Description) || string.IsNullOrWhiteSpace(book.Author) ||
                    book.ReleaseDate == DateTime.MinValue || book.Quantity <= 0 || book.Price <= 0 ||
                    book.BookCategoryId <= 0)
                {
                    throw new ArgumentException("Invalid book data. Please check the input values.", nameof(book));
                }

                _repo.Update(book);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error updating book: {ex.Message}");
                throw;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error updating book: {ex.Message}");
                throw; 
            }
        }
    }
}
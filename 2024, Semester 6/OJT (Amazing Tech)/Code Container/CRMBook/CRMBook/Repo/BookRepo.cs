
using CRMBook.Models;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace CRMBook.Repo
{
    public interface IBookRepo
    {

        List<Book>? GetAllBook();

        int AddNewBook(Book entity);

        Book getBookById(int id);

        int UpdateBook(Book entity, int id);

        int DeleteBook(int id);

    }
    public class BookRepo : IBookRepo
    {
        private DbSet<Book> _Dbset;
        public BookRepo()
        {

        }

        public List<Book>? GetAllBook()
        {
            using (var contetx = new cmdBookContext())
            {
                var book = contetx.Set<Book>().ToList();
                return book;
            }

        }

        public int AddNewBook(Book entity)
        {
            using (var context = new cmdBookContext())
            {
                var user = context.Set<User>().Where(x => x.Accout_id == entity.Book_Accout_id).FirstOrDefault();
                if (user == null)
                {
                    return 0;
                }
                context.Set<Book>().Add(entity);
                return context.SaveChanges();
            }
        }

        public Book getBookById(int id)
        {
            using (var context = new cmdBookContext())
            {
                var book = context.Set<Book>().AsNoTracking().Where(x => x.Book_id == id).FirstOrDefault();
                return book;

            }

        }

        public int UpdateBook(Book entity, int id)
        {
            using (var context = new cmdBookContext())
            {
                var book = getBookById(id);
                if (book == null)
                {
                    return 0;
                }
                context.Set<Book>().Update(entity);
                return context.SaveChanges();
            }
        }
        public int DeleteBook(int id)
        {
            using (var context = new cmdBookContext())
            {
                var book = getBookById(id);
                if (book == null)
                {
                    return 0;
                }
                context.Set<Book>().Remove(book);
                return context.SaveChanges();
            }
        }

    }
}

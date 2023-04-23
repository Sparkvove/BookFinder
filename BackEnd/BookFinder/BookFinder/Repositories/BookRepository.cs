using BookFinder.Models;
using BookFinder.DataProvider;

namespace BookFinder.Repositories
{
    public class BookRepository : IBookRepository
    {
        public Book? GetBookById(int id)
        {
            var book = BookDB.BookList!.Find(x => x.Id == id);
            return book;
        }

        public IEnumerable<Book> GetBooks()
        {
            return BookDB.BookList!;
        }
    }
}

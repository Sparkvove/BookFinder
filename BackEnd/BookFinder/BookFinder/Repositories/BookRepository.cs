using BookFinder.Models;
namespace BookFinder.Repositories
{
    public class BookRepository : IBookRepository
    {
        public Book? GetBookById(int id)
        {
            return DataProvider.BookList.Find(x => x.Id == id);
        }

        public IEnumerable<Book> GetBooks()
        {
            return DataProvider.BookList;
        }
    }
}

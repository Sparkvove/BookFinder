using BookFinder.Domain;

namespace BookFinder.Repositories
{
    public interface IBookRepository
    {
        public IEnumerable<Book> GetBooks();
        public Book? GetBookById(int id);
    }
}

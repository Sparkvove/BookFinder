using BookFinder.Core.Domain;

namespace BookFinder.Core.Repositories
{
    public interface IBookRepository
    {
        Book Get(Guid id);
        IEnumerable<Book> GetAll();
        Book Find(string title);
    }
}

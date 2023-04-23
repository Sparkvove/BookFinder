using BookFinder.Core.Domain;
using BookFinder.Core.Repositories;

namespace BookFinder.Infrastructure.Repository
{
    public class InMemoryBookRepository : IBookRepository
    {
        private static ISet<Book> _books = new HashSet<Book>
        {
            new Book("title1", "author1", "desc1"),
            new Book("title2", "author2", "desc2"),
            new Book("title3", "author3", "desc3")
        };
        public Book Find(string title)
        {
            return _books.Single(x => x.Title == title);
        }

        public Book Get(Guid id)
        {
            return _books.Single(x => x.Id== id);
        }

        public IEnumerable<Book> GetAll()
        {
            return _books;
        }
    }
}

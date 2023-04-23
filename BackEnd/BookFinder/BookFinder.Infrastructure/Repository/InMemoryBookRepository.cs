using BookFinder.Core.Domain;
using BookFinder.Core.Domain.ValueObjects;
using BookFinder.Core.Repositories;

namespace BookFinder.Infrastructure.Repository
{
    public class InMemoryBookRepository : IBookRepository
    {
        private static ISet<Book> _books = new HashSet<Book>
        {
            new Book(Guid.NewGuid(),"title2", Person.CreatePerson(Guid.NewGuid(), "Branderson", null, null), "desc2", null, null, 4),
            new Book(Guid.NewGuid(),"title1", Person.CreatePerson(Guid.NewGuid(),"Antionio","banderas", "autor1"), "desc1", null, null, 5),
            new Book(Guid.NewGuid(),"title2", Person.CreatePersonWithOnlyAlias(Guid.NewGuid(), "autor2"), "desc2", null, null, 4),
            new Book(Guid.NewGuid(),"title3", Person.CreatePersonWithOnlyAlias(Guid.NewGuid(), "autor3"), "desc3", null, null, 3)
        };
        public Book Find(string title)
        {
            return _books.Single(x => x.Title == title);
        }

        public Book Get(Guid guid)
        {
            return _books.Single(x => x.Id== guid);
        }

        public IEnumerable<Book> GetAll()
        {
            return _books;
        }
    }
}

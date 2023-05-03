using BookFinder.Core.Domain;
using BookFinder.Core.Domain.ValueObjects;
using BookFinder.Core.Repositories;

namespace BookFinder.Infrastructure.Repository
{
    public class InMemoryBookRepository : IBookRepository
    {
        private static ISet<Book> _books = new HashSet<Book>
        {
            new Book(Guid.NewGuid(),"title2", Person.CreatePerson(Guid.NewGuid(), "Branderson", null, null), "desc2", new List<string>{"Fantasy","History"}, new List<string>{""}, 4),
            new Book(Guid.NewGuid(),"title1", Person.CreatePerson(Guid.NewGuid(),"Antionio","banderas", "autor1"), "desc1",  new List<string>{"Fantasy"}, new List<string>{""}, 5),
            new Book(Guid.NewGuid(),"title4", Person.CreatePersonWithOnlyAlias(Guid.NewGuid(), "autor2"), "desc2", new List<string>{""}, new List<string>{"Action"}, 4),
            new Book(Guid.NewGuid(),"title3", Person.CreatePersonWithOnlyAlias(Guid.NewGuid(), "autor3"), "desc3", new List<string>{""}, new List<string>{""}, 3)
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

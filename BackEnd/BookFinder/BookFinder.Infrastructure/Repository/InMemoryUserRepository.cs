
using BookFinder.Core.Domain;
using BookFinder.Core.Repositories;

namespace BookFinder.Infrastructure.Repository
{
    public class InMemoryUserRepository : IUserRepository
    {
        private static ISet<User> _users = new HashSet<User>
        {
            new User("spark", new List<Book>())
        };
        public void Add(User user)
        {
            _users.Add(user);
        }

        public User Get(Guid id)
        {
            return _users.Single(x => x.Id == id);
        }

        public User GetByUsername(string username)
        {
            return _users.Single(x => x.Name == username);
        }

        public User GetByEmail(string email)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetAll()
        {
            return _users;
        }

        public void Remove(User user)
        {
            throw new NotImplementedException();
        }

        public void Update(User user)
        {
            throw new NotImplementedException();
        }

        public void AddBook(User user, Book book)
        {
            user.BookList.Add(book);
        }
    }
}


using BookFinder.Core.Domain;
using BookFinder.Core.Repositories;

namespace BookFinder.Infrastructure.Repository
{
    public class InMemoryUserRepository : IUserRepository
    {
        private static ISet<User> _users = new HashSet<User>();
        public void Add(User user)
        {
            _users.Add(user);
        }

        public User Get(Guid Id)
        {
            return _users.Single(x => x.Id == Id);
        }

        public User Get(string email)
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
    }
}

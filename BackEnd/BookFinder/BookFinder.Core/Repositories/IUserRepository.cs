using BookFinder.Core.Domain;

namespace BookFinder.Core.Repositories
{
    public interface IUserRepository
    {
        User Get(Guid Id);
        User GetByUsername(string username);
        User GetByEmail(string email);
        IEnumerable<User> GetAll();
        void Add(User user);
        void Remove(User user);
        void Update(User user);

        void AddBook(User user,Book book);
    }
}

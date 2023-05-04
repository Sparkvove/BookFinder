using BookFinder.Core.Domain;

namespace BookFinder.Core.Repositories
{
    public interface IUserRepository
    {
        User Get(Guid Id);
        User GetByUsername(string username);
        IEnumerable<User> GetAll();
        void Add(User user);
        void AddBook(User user,Book book);
    }
}

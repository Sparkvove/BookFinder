using BookFinder.Core.Domain;
using BookFinder.Core.Domain.ValueObjects;

namespace BookFinder.Infrastructure.Services
{
    public interface IBookService
    {
        IEnumerable<Book> GetAll();
        Book GetByGuid(Guid id);
        IEnumerable<Book> GetRecommended();
        Book Find(string? title, string? description, Person? author);

    }
}

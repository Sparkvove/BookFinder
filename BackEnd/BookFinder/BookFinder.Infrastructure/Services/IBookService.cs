using BookFinder.Core.Domain;
using BookFinder.Core.Domain.ValueObjects;

namespace BookFinder.Infrastructure.Services
{
    public interface IBookService
    {
        IEnumerable<Book> GetAll();
        Book GetByGuid(Guid id);
        Book GetByTitle(string title);
        IEnumerable<Book> GetRecommended();
        Book Find(string? title, string? description, Person? author);

    }
}

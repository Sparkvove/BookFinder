using BookFinder.Core.Domain;


namespace BookFinder.Infrastructure.Services
{
    public interface IBookService
    {
        IEnumerable<Book> GetAll();
        IEnumerable<Book> GetRecommended();
        Book Find(string? title, string? description, string? author);

    }
}

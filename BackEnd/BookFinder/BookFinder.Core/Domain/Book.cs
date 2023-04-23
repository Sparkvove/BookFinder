using BookFinder.Core.Domain.ValueObjects;

namespace BookFinder.Core.Domain
{
    public record Book(Guid Id, string Title, Person Author, string Description, IEnumerable<string> Genres, IEnumerable<string> Tags, float Score);
    
}

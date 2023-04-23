using BookFinder.Models;
using MediatR;

namespace BookFinder.Queries
{
    public record SearchBookQuery(string? title, string? desc, string? author) : IRequest<IEnumerable<Book>>;
    public class SearchBookQueryHandler : IRequestHandler<SearchBookQuery, IEnumerable<Book>>
    {
        public async Task<IEnumerable<Book>> Handle(SearchBookQuery request, CancellationToken cancellationToken)
        {
           return await Task.FromResult(
               DataProvider.BookList.FindAll(x => 
               x.Title == request.title ||
               x.Description == request.desc ||
               x.Author == request.author));
        }
    }
}

using BookFinder.Models;
using MediatR;

namespace BookFinder.Queries
{
    public record GetAllBooksQuery() : IRequest<IEnumerable<Book>>;

    public class GetAllBooksQueryHandler : IRequestHandler<GetAllBooksQuery, IEnumerable<Book>>
    {
        public async Task<IEnumerable<Book>> Handle(GetAllBooksQuery request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(DataProvider.BookList);
        }
    }
}

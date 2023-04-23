using BookFinder.Domain;
using MediatR;

namespace BookFinder.Queries
{
    public record GetBookByIdQuery(int Id) : IRequest<Book>;
    public class GetBookByIdQueryHandler : IRequestHandler<GetBookByIdQuery, Book>
    {
        public async Task<Book> Handle(GetBookByIdQuery request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(DataProvider.BookList.SingleOrDefault(x => x.Id == request.Id)!); 
        }
    }
}

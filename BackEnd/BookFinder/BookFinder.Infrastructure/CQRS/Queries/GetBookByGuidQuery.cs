using BookFinder.Core.Domain;
using BookFinder.Infrastructure.Services;
using MediatR;

namespace BookFinder.API.CQRS.Queries
{
    public record GetBookByGuidQuery(Guid guid) : IRequest<Book>;

    public class GetBookByGuidQuerHandler : IRequestHandler<GetBookByGuidQuery,Book>
    {
        private readonly IBookService _bookService;
        public GetBookByGuidQuerHandler(IBookService bookService)
        {
            _bookService = bookService;
        }

        public async Task<Book> Handle(GetBookByGuidQuery request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(_bookService.GetByGuid(request.guid));
        }
    }
}

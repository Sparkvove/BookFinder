using BookFinder.Core.Domain;
using BookFinder.Infrastructure.Services;
using MediatR;

namespace BookFinder.Infrastructure.CQRS.Queries
{
    public class GetAllBooksQuery : IRequest<IEnumerable<Book>>
    {
    }

    public class GetAllBooksQueryHandler : IRequestHandler<GetAllBooksQuery, IEnumerable<Book>>
    {
        private readonly IBookService _bookService;
        public GetAllBooksQueryHandler(IBookService bookService)
        {
            _bookService = bookService;
        }

        public async Task<IEnumerable<Book>> Handle(GetAllBooksQuery request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(_bookService.GetAll());
        }
    }
}

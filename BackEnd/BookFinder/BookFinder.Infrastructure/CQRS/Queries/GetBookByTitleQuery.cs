using BookFinder.Core.Domain;
using BookFinder.Infrastructure.Services;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookFinder.Infrastructure.CQRS.Queries
{
    public record GetBookByTitleQuery(string title) : IRequest<Book>;

    public class GetBookByTitleQueryHandler : IRequestHandler<GetBookByTitleQuery, Book>
    {
        private readonly IBookService _bookService;
        public GetBookByTitleQueryHandler(IBookService bookService)
        {
            _bookService = bookService;
        }

        public async Task<Book> Handle(GetBookByTitleQuery request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(_bookService.GetByTitle(request.title));
        }
    }
}

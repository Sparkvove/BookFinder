using BookFinder.Core.Domain;
using BookFinder.Infrastructure.Services;
using MediatR;
using System.Linq;

namespace BookFinder.API.CQRS.Queries
{
    public record SearchBooksQuery(IEnumerable<string>? Genres, IEnumerable<string>? Tags) : IRequest<IEnumerable<Book>>;
    public class SearchBooksQueryHandler : IRequestHandler<SearchBooksQuery, IEnumerable<Book>>
    {
        private readonly IBookService _bookService;
        public SearchBooksQueryHandler(IBookService bookService)
        {
            _bookService = bookService;
        }

        public async Task<IEnumerable<Book>> Handle(SearchBooksQuery request, CancellationToken cancellationToken)
        {
            var allBooks = await Task.FromResult(_bookService.GetAll());
            var books = new List<Book>();

            if(request.Genres is not null)
            {
                var match = allBooks.Where(book => book.Genres.Any(genre => request.Genres.Contains(genre)));
                books.AddRange(match);
            }

            if (request.Tags is not null)
            {
                var match = allBooks.Where(book => book.Tags.Any(genre => request.Tags.Contains(genre)));
                books.AddRange(match);
            }

            return await Task.FromResult(books);
        }
    }
}

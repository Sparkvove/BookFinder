using BookFinder.Core.Domain;
using BookFinder.Core.Repositories;
using MediatR;

namespace BookFinder.API.CQRS.Commands
{
    public record AddBookToUserBookListCommand(string bookTitle, string username) : IRequest<Unit>;

    public class AddBookToUserBookListCommandHandler : IRequestHandler<AddBookToUserBookListCommand, Unit>
    {
        private readonly IUserRepository _userRepository;
        private readonly IBookRepository _bookRepository;
        public AddBookToUserBookListCommandHandler(IUserRepository userRepository, IBookRepository bookRepository)
        {
            _userRepository = userRepository;
            _bookRepository = bookRepository;
        }

        public async Task<Unit> Handle(AddBookToUserBookListCommand request, CancellationToken cancellationToken)
        {
            Unit unit;
            var book = _bookRepository.Find(request.bookTitle);
            var user = _userRepository.GetByUsername(request.username);
            _userRepository.AddBook(user, book);
            return await Task.FromResult(unit);
        }
    }
}

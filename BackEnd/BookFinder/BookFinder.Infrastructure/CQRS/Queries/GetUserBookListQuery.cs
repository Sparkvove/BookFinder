using BookFinder.Core.Domain;
using BookFinder.Core.Repositories;
using MediatR;

namespace BookFinder.API.CQRS.Queries
{
    public record GetUserBookListQuery(string username) : IRequest<IEnumerable<Book>>;
    public class GetUserBookListQueryHandler : IRequestHandler<GetUserBookListQuery, IEnumerable<Book>>
    {
        private readonly IUserRepository _userRepository;
        public GetUserBookListQueryHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<IEnumerable<Book>> Handle(GetUserBookListQuery request, CancellationToken cancellationToken)
        {
            var user = _userRepository.GetByUsername(request.username);
            return await Task.FromResult(user.BookList);
        }
    }
}

using BookFinder.Models;
using MediatR;

namespace BookFinder.Queries
{
    public record  GetRecommendedBooksQuery(int userId) : IRequest<IEnumerable<Book>>;

    public class GetRecommendedBooksQueryHandler : IRequestHandler<GetRecommendedBooksQuery, IEnumerable<Book>>
    {
        public async Task<IEnumerable<Book>> Handle(GetRecommendedBooksQuery request, CancellationToken cancellationToken)
        {
            var user = DataProvider.UserList.SingleOrDefault(x => x.Id == request.userId);
            if (user is null)
            {
                throw new Exception("User Not found");
            }

            // Create Service to get recommended books
            // RecommendService(user)

            return await Task.FromResult(DataProvider.BookList);
        }
    }

}

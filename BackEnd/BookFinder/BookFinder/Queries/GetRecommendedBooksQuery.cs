﻿using BookFinder.Domain;
using MediatR;

namespace BookFinder.Queries
{
    public record  GetRecommendedBooksQuery(int userId) : IRequest<IEnumerable<Book>>;

    public class GetRecommendedBooksQueryHandler : IRequestHandler<GetRecommendedBooksQuery, IEnumerable<Book>>
    {
        public async Task<IEnumerable<Book>> Handle(GetRecommendedBooksQuery request, CancellationToken cancellationToken)
        {
            var user = DataProvider.UserList.SingleOrDefault(x => x.Id == request.userId);

            var recommender = new Recommender();
            recommender.GetBookRecommendations(user, DataProvider.BookList);

            return await Task.FromResult(DataProvider.BookList);
        }
    }

}

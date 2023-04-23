using BookFinder.Domain;

namespace BookFinder.Services
{
    public class RecommenderService : IRecommenderService
    {
        public IEnumerable<Book> GetBookRecommendation(IEnumerable<Book>? BookList)
        {
            return DataProvider.BookList;
        }
    }
}

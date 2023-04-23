using BookFinder.Domain;

namespace BookFinder.Services
{
    public interface IRecommenderService
    {
        public IEnumerable<Book> GetBookRecommendation(IEnumerable<Book>? BookList);
    }
}

namespace BookFinder.Domain
{
    public class Recommender
    {
        public IEnumerable<Book> GetBookRecommendations(User? user, IEnumerable<Book> booksToRecommendFrom)
        {
            if (user is null)
            {
                throw new ArgumentNullException(nameof(user));
            }

            if(user.BookList is null)
            {
                return booksToRecommendFrom;
            }

            return booksToRecommendFrom;
        }
    }
}

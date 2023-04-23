using BookFinder.Core.Domain;
using BookFinder.Core.Repositories;

namespace BookFinder.Infrastructure.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepository;

        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public IEnumerable<Book> GetAll()
        {
            var books = _bookRepository.GetAll();
            if(books is null)
            {
                throw new Exception("There is no books in dataProvider");
            }
            return books;
        }

        public Book Find(string? title, string? description, string? author)
        {
            var books = _bookRepository.GetAll();
            return books.SingleOrDefault(x => x.Title == title || x.Description == description || x.Author == author);
        }

 
        public IEnumerable<Book> GetRecommended()
        {
            throw new NotImplementedException();
        }
    }
}

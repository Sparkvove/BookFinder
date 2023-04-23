using BookFinder.Models;
using BookFinder.Repositories;
using BookFinder.Services;
using Microsoft.AspNetCore.Mvc;


namespace BookFinder.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private IBookRepository _bookRepository;
        private IRecommenderService _recommender;

        public BooksController(IBookRepository bookRepository, IRecommenderService recommender)
        {
            _bookRepository = bookRepository;
            _recommender = recommender;
        }
        // GET: api/<BooksController>
        [HttpGet]
        public IEnumerable<Book> Get()
        {
            return _bookRepository.GetBooks();
        }

        // GET api/<BooksController>/5
        [HttpGet("{id}")]
        public Book? Get(int id)
        {
            return _bookRepository.GetBookById(id);
        }

        // GET api/<BooksController>/Recommended/{id}
        [HttpGet("/Recommended/{id}")]
        public IEnumerable<Book> Recommended(int id)
        {
            var user = DataProvider.UserList.SingleOrDefault(x => x.Id == id);
            if(user is null)
            {
                return _bookRepository.GetBooks();
            }
            return _recommender.GetBookRecommendation(user.BookList);

        }

        // GET api/<BooksController>/Search
        [HttpPost("/Search")]
        public IEnumerable<Book> Search(SearchBody search)
        {
            var foundBooks = DataProvider.BookList.FindAll(x => x.Title == search.title || x.Description == search.desc || x.Author == search.author);
            return foundBooks;
        }

        public record SearchBody(string? title, string? desc, string? author);

    }
}

using BookFinder.Models;
using BookFinder.Repositories;
using Microsoft.AspNetCore.Mvc;


namespace BookFinder.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private IBookRepository _bookRepository;

        public BooksController(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
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

    }
}

using BookFinder.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;


namespace BookFinder.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IMediator _mediator;

        public BooksController(IMediator mediator)
        {
            _mediator = mediator;
        }
        // GET: api/<BooksController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
           var query  = new GetAllBooksQuery();
           return Ok(await _mediator.Send(query));
        }

        // GET api/<BooksController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var query = new GetBookByIdQuery(id);
            return Ok(await _mediator.Send(query));
        }
        // GET api/<BooksController>/Recommended/{id}
        [HttpGet("/Recommended/{userId}")]
        public async Task<IActionResult> GetRecommended(int userId)
        {
            var query = new GetRecommendedBooksQuery(userId);
            return Ok(await _mediator.Send(query));

        }

        // GET api/<BooksController>/Search
        [HttpPost("/Search")]
        public async Task<IActionResult> Search(SearchBookQuery query)
        {
            return Ok(await _mediator.Send(query));
        }

    }
}

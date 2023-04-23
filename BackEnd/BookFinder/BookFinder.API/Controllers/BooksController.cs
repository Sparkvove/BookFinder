using BookFinder.API.CQRS.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BookFinder.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IMediator _mediator;
        public BooksController(IMediator mediator)
        {
            _mediator = mediator;
        }
        // GET: <BooksController>
        [HttpGet]
        public IActionResult Get()
        {
            var query = new GetAllBooksQuery();
            return Ok(_mediator.Send(query));
        }

        [HttpGet("{guid}")]
        public IActionResult Get(Guid guid)
        {
            var query = new GetBookByGuidQuery(guid);
            return Ok(_mediator.Send(query));
        }

        [HttpPost("/Search")]
        public IActionResult Search(SearchBody search)
        {
            var query = new SearchBooksQuery(search.Genres, search.Tags);
            return Ok(_mediator.Send(query));
        }

        public record SearchBody(IEnumerable<string>? Genres, IEnumerable<string>? Tags);

    }
}

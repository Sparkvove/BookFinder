using BookFinder.API.CQRS.Commands;
using BookFinder.API.CQRS.Queries;
using BookFinder.Core.Domain;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BookFinder.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BookListController : ControllerBase
    {
        private readonly IMediator _mediator;
        public BookListController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // GET: api/<BookListController>
        [HttpGet("{username}")]
        public IActionResult Get(string username)
        {
            var query = new GetUserBookListQuery(username);
            return Ok(_mediator.Send(query));
        }

        // GET: api/<BookListController>
        [HttpPost]
        public IActionResult AddToList([FromBody] AddBookToUserBookListCommand request)
        {
            return Ok(_mediator.Send(request));
        }

    }
}

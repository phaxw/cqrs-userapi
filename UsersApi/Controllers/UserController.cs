using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using UsersApi.Commands;
using UsersApi.Dtos;
using UsersApi.Queries;

namespace UsersApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IMediator _mediator;

        public UserController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllUsers()
        {
            var query = new GetAllUsersQuery();
            var result = await _mediator.Send(query);
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetUserById(int id)
        {
            var query = new GetUserByIdQuery(id);
            var result = await _mediator.Send(query);
            return result != null ? (IActionResult) Ok(result) : NotFound(null);
            
           
            
            
        }

        [HttpPost()]
        public async Task<IActionResult> InsertUser([FromBody] User value)
        {
            var query = new InsertUserCommand(value.Name, value.Email);
            var result = await _mediator.Send(query);
            return Ok(result);
        }
    }
}
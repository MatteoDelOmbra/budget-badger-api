using Application.Commands;
using Application.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

[Route("[controller]")]
public class UserController(IMediator mediator) : ControllerBase
{
    private readonly IMediator _mediator = mediator;

    [HttpPost]
    public async Task<IActionResult> Signup([FromBody] SignupBody body)
    {
        var command = new SignupCommand(body);
        var result = await _mediator.Send(command);
        return Ok(result);
    }

    [HttpGet]
    public async Task<IActionResult> GetUsers()
    {
        var q = new GetUsersQuery();
        var res = await _mediator.Send(q);
        return Ok(res);
    }
}

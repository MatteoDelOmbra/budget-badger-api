using Application.Commands;
using Application.Queries;
using Domain.DTOs;
using Domain.Enitities;
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
        SignupCommand command = new(body);
        Guid result = await _mediator.Send(command);
        return Ok(result);
    }

    [HttpGet]
    public async Task<IActionResult> GetUsers()
    {
        GetUsersQuery query = new();
        List<User> result = await _mediator.Send(query);
        return Ok(result);
    }
}

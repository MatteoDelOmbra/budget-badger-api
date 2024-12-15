using Application.Commands;
using Domain.DTOs.Requests;
using Domain.DTOs.Responses;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

[Route("[controller]")]
public class UserController(IMediator mediator) : ControllerBase
{
    private readonly IMediator _mediator = mediator;

    [HttpPost]
    [Route("create")]
    public async Task<ActionResult<Response<CreateUserResponse>>> CreateUser(
        [FromBody] CreateUserRequest body
    )
    {
        CreateUserCommand command = new(body);
        Response<CreateUserResponse> result = await _mediator.Send(command);
        return StatusCode((int)result.StatusCode, result.Data);
    }
}

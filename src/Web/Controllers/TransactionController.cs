using Application.Queries;
using Domain.Enitities;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

[Route("[controller]")]
public class TransactionController(IMediator mediator) : ControllerBase
{
    private readonly IMediator _mediator = mediator;

    [HttpGet]
    public async Task<IActionResult> GetTransactions()
    {
        GetTransactionsQuery query = new();
        List<Transaction> result = await _mediator.Send(query);
        return Ok(result);
    }
}

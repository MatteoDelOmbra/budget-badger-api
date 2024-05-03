using Domain.Enitities;
using MediatR;

namespace Application.Queries;

public record GetTransactionsQuery() : IRequest<List<Transaction>>;

public class GetTransactionsQueryHandler()
    : IRequestHandler<GetTransactionsQuery, List<Transaction>>
{
    public Task<List<Transaction>> Handle(
        GetTransactionsQuery request,
        CancellationToken cancellationToken
    )
    {
        var transactions = new List<Transaction>();
        return Task.FromResult(transactions);
    }
}

using Application.Interfaces;
using Domain.Enitities;
using MediatR;

namespace Application.Queries;

public record GetTransactionsQuery() : IRequest<List<Transaction>>;

public class GetTransactionsQueryHandler(IAppDbContext context)
    : IRequestHandler<GetTransactionsQuery, List<Transaction>>
{
    public Task<List<Transaction>> Handle(
        GetTransactionsQuery request,
        CancellationToken cancellationToken
    )
    {
        var transactions = context.Transactions.ToList();
        return Task.FromResult(transactions);
    }
}

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
        var transaction = new Transaction
        {
            Id = "foo",
            Name = "bar",
            Date = DateTime.UtcNow,
            Type = Domain.Enums.TransactionType.Expense,
            Value = 10,
            AccountId = "xd"
        };
        transactions.Add(transaction);
        return Task.FromResult(transactions);
    }
}

using MediatR;

namespace Application.Queries
{
    public class GetTransactionsQueryHandler() : IRequestHandler<GetTransactionsQuery, string>
    {
        public Task<string> Handle(
            GetTransactionsQuery request,
            CancellationToken cancellationToken
        )
        {
            return Task.FromResult("foo");
        }
    }
}

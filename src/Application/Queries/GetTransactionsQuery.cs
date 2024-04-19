using MediatR;
namespace Application.Queries;
public record GetTransactionsQuery() : IRequest<string>;
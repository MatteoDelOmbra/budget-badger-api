using Application.Interfaces;
using Domain.Enitities;
using MediatR;

namespace Application.Queries;

public record GetUsersQuery() : IRequest<List<User>>;

public class GetUsersQueryHandler(IAppDbContext context)
    : IRequestHandler<GetUsersQuery, List<User>>
{
    public Task<List<User>> Handle(GetUsersQuery request, CancellationToken cancellationToken)
    {
        List<User> users = [.. context.Users];
        return Task.FromResult(users);
    }
}

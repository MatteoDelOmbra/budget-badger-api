using Application.Interfaces;
using Domain.DTOs;
using Domain.Enitities;
using MediatR;

namespace Application.Commands;

public record SignupCommand(SignupBody Body) : IRequest<Guid>;

public class SignupCommandHandler(IAppDbContext context) : IRequestHandler<SignupCommand, Guid>
{
    public async Task<Guid> Handle(SignupCommand request, CancellationToken cancellationToken)
    {
        User user =
            new()
            {
                Id = Guid.NewGuid(),
                Email = request.Body.Email,
                Name = request.Body.Name,
                Password = request.Body.HashedPassword,
                IsAnonym = false,
            };
        _ = context.Users.Add(user);
        _ = await context.SaveChangesAsync(cancellationToken);

        return user.Id;
    }
}

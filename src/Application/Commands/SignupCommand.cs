using Application.Interfaces;
using Domain.Enitities;
using MediatR;
using Microsoft.VisualBasic;

namespace Application.Commands;

public record SignupCommand(SignupBody body) : IRequest<Guid>;

public class SignupCommandHandler(IAppDbContext context) : IRequestHandler<SignupCommand, Guid>
{
    public async Task<Guid> Handle(SignupCommand request, CancellationToken cancellationToken)
    {
        var user = new User()
        {
            Id = Guid.NewGuid(),
            Email = request.body.Email,
            Name = request.body.Name,
            Password = request.body.HashedPassword,
            IsAnonym = false,
        };
        context.Users.Add(user);
        await context.SaveChangesAsync(cancellationToken);

        return user.Id;
    }
}

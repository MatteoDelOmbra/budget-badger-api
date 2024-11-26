using Application.Interfaces;
using Application.Validators;
using Domain.DTOs;
using Domain.Enitities;
using FluentValidation.Results;
using MediatR;

namespace Application.Commands;

public record CreateUserCommand(CreateUserBody Body) : IRequest<Guid>;

public class CreateUserCommandHandler(IAppDbContext context)
    : IRequestHandler<CreateUserCommand, Guid>
{
    public async Task<Guid> Handle(CreateUserCommand request, CancellationToken cancellationToken)
    {
        CreateUserValidator validator = new();
        ValidationResult validation = validator.Validate(request.Body);
        if (!validation.IsValid)
        {
            return Guid.Empty;
        }
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

using Application.Interfaces;
using Application.Validators;
using Domain.DTOs.Requests;
using Domain.DTOs.Responses;
using Domain.Enitities;
using FluentValidation.Results;
using MediatR;

namespace Application.Commands;

public record CreateUserCommand(CreateUserRequest Body) : IRequest<Response<CreateUserResponse>>;

public class CreateUserCommandHandler(IAppDbContext context)
    : IRequestHandler<CreateUserCommand, Response<CreateUserResponse>>
{
    public async Task<Response<CreateUserResponse>> Handle(
        CreateUserCommand request,
        CancellationToken cancellationToken
    )
    {
        CreateUserValidator validator = new();
        ValidationResult validation = validator.Validate(request.Body);
        if (!validation.IsValid)
        {
            return new()
            {
                StatusCode = System.Net.HttpStatusCode.BadRequest,
                Data = new() { Message = "Validation failed" },
            };
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
        context.Users.Add(user);
        try
        {
            await context.SaveChangesAsync(cancellationToken);
        }
        catch
        {
            return new()
            {
                StatusCode = System.Net.HttpStatusCode.BadRequest,
                Data = new() { Message = "Failed to save in database" },
            };
        }

        return new()
        {
            StatusCode = System.Net.HttpStatusCode.OK,
            Data = new() { Message = "User created successfully", UserId = user.Id },
        };
    }
}

using Domain.DTOs.Requests;
using FluentValidation;

namespace Application.Validators;

public class CreateUserValidator : AbstractValidator<CreateUserRequest>
{
    public CreateUserValidator()
    {
        _ = RuleFor(body => body.Email).EmailAddress();
    }
}

using Domain.DTOs.Requests;
using FluentValidation;

namespace Application.Validators;

public class CreateUserValidator : AbstractValidator<CreateUserRequest>
{
    public CreateUserValidator()
    {
        RuleFor(body => body.Email).EmailAddress();
    }
}

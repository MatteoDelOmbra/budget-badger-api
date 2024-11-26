using Domain.DTOs;
using FluentValidation;

namespace Application.Validators;

public class CreateUserValidator : AbstractValidator<CreateUserBody>
{
    public CreateUserValidator()
    {
        RuleFor(body => body.Email).EmailAddress();
    }
}

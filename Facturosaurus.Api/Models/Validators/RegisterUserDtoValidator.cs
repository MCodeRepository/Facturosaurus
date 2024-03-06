using Facturosaurus.Api.Entities;
using FluentValidation;
using System.Linq;

namespace Facturosaurus.Api.Models.Validators
{
    public class RegisterUserDtoValidator : AbstractValidator<UserRegisterDto>
    {
        public RegisterUserDtoValidator(FacturosaurusDbContext dbContext)
        {
            RuleFor(x => x.Email)
                .NotEmpty()
                .EmailAddress();

            RuleFor(x => x.Password)
                .NotEmpty()
                .MinimumLength(6);

            RuleFor(x => x.ConfirmPassword)
                .Equal(e => e.Password);

            RuleFor(x => x.Email)
                .Custom((value, context) =>
                {
                    var emailIsUse = dbContext.Users.Any(u => u.Email == value);

                    if (emailIsUse)
                    {
                        context.AddFailure("Email", "The mail address already exists.");
                    }
                });

        }
    }
}

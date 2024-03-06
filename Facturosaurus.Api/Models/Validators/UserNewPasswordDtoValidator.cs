using Facturosaurus.Api.Entities;
using FluentValidation;
using System.Linq;

namespace Facturosaurus.Api.Models.Validators
{
    public class UserNewPasswordDtoValidator : AbstractValidator<UserNewPasswordDto>
    {
        public UserNewPasswordDtoValidator(FacturosaurusDbContext dbContext)
        {
            RuleFor(x => x.Id)
                .Custom((value, context) =>
                {
                    var userExists = dbContext.Users.Any(x => x.Id == value);

                    if (!userExists)
                    {
                        context.AddFailure("Id", "User ID not Exists.");

                    }
                });

            RuleFor(x => x.Password)
                .NotEmpty()
                .MinimumLength(6);

            RuleFor(x => x.ConfirmPassword)
                .Equal(e => e.Password);
        }
    }
}

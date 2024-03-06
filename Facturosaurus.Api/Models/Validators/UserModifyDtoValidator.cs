using Facturosaurus.Api.Entities;
using FluentValidation;
using System;
using System.Linq;

namespace Facturosaurus.Api.Models.Validators
{
    public class UserModifyDtoValidator : AbstractValidator<UserModifyDto>
    {
        private Guid userId;

        public UserModifyDtoValidator(FacturosaurusDbContext dbContext)
        {
            RuleFor(x => x.Id)
                .Custom((value, context) =>
                {
                    userId = value;
                    var userIdExists = dbContext.Users.Any(u => u.Id == value);
                    if (!userIdExists)
                    {
                        context.AddFailure("Id", "Id not exists.");
                    }
                });

            RuleFor(x => x.Email)
               .NotEmpty()
               .EmailAddress();

            //RuleFor(x => x.Email)
            //    .Custom((value, context) =>
            //    {
            //        var emailIsUse = dbContext.Users.Any(u => u.Email == value && u.Id != userId);

            //        if (emailIsUse)
            //        {
            //            context.AddFailure("Email", "The mail address already exists.");
            //        }
            //    });
        }
    }
}

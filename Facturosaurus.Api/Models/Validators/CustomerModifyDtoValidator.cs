using Facturosaurus.Api.Entities;
using FluentValidation;
using System.Linq;

namespace Facturosaurus.Api.Models.Validators
{
    public class CustomerModifyDtoValidator : AbstractValidator<CustomerModifyDto>
    {
        int customerId;

        public CustomerModifyDtoValidator(FacturosaurusDbContext dbContext)
        {
            RuleFor(c => c.Id)
                .Custom((value, context) =>
                {
                    customerId = value;
                    var userIdExists = dbContext.Cutomers.Any(u => u.Id == value);
                    if (!userIdExists)
                    {
                        context.AddFailure("Id", "Id not exists.");
                    }
                });

            RuleFor(c => c.ShortCustomerName)
                .NotNull();
            RuleFor(c => c.CustomerName)
                .NotNull();
            RuleFor(c => c.NipNumber)
                .Custom((value, context) =>
                {
                    var nipIsUse = dbContext.Cutomers.Any(c => c.NipNumber == value && c.Id != customerId);
                    if (nipIsUse)
                    {
                        context.AddFailure("NIP", "Podany NIP jest już przypisany do innego kontrahenta.");
                    }
                });

            RuleFor(x => x.NipNumber)
                .Matches(@"^[0-9]{10}$");
            RuleFor(x => x.StreetName)
                .NotEmpty()
                .MaximumLength(100);
            RuleFor(x => x.BildingNumber)
                .NotEmpty()
                .MaximumLength(10);
            RuleFor(x => x.ApartmentNumber)
                .MaximumLength(10);
            RuleFor(x => x.City)
                .NotEmpty()
                .MaximumLength(100);
            RuleFor(x => x.ZipCode)
                .NotEmpty()
                .MaximumLength(8);
        }
    }
}

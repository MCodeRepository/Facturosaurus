using Facturosaurus.Api.Entities;
using FluentValidation;
using System.Linq;

namespace Facturosaurus.Api.Models.Validators
{
    public class CustomerCreateDtoValidator : AbstractValidator<CustomerCreateDto>
    {
        public CustomerCreateDtoValidator(FacturosaurusDbContext dbContext)
        {
            RuleFor(c => c.ShortCustomerName)
                .NotNull();
            RuleFor(c => c.CustomerName)
                .NotNull();
            RuleFor(c => c.NipNumber)
                .Custom((value, context) =>
                {
                    var nipIsUse = dbContext.Cutomers.Any(c => c.NipNumber == value);
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

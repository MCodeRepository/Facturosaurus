using FluentValidation;

namespace Facturosaurus.Api.Models.Validators
{
    public class CompanyDetailsCreateDtoValidator : AbstractValidator<CompanyDetailsCreateDto>
    {
        public CompanyDetailsCreateDtoValidator()
        {
            RuleFor(x => x.ShortCompanyName)
                .NotEmpty()
                .MaximumLength(150);
            RuleFor(x => x.CompanyName)
                .NotEmpty()
                .MaximumLength(300);
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
            RuleFor(x => x.BankName)
                .NotEmpty()
                .MaximumLength(100);
            RuleFor(x => x.Currency)
                .NotEmpty()
                .MaximumLength(3);
            RuleFor(x => x.BankAccountNumber)
                .Matches(@"\d{26}");
            RuleFor(x => x.PhoneNumber)
                .MaximumLength(15)
                .Matches(@"^[\\+]?[(]?[0-9]{3}[)]?[-\\s\\.]?[0-9]{3}[-\\s\\.]?[0-9]{4,6}$");
            RuleFor(x => x.AddressEmail)
                .EmailAddress()
                .MaximumLength(100);
        }
    }
}

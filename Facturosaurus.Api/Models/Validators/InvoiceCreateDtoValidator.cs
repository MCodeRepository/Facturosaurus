using FluentValidation;

namespace Facturosaurus.Api.Models.Validators
{
    public class InvoiceCreateDtoValidator : AbstractValidator<InvoiceCreateDto>
    {
        public InvoiceCreateDtoValidator()
        {
            RuleFor(i => i.Type).NotEmpty();
            RuleFor(i => i.Month).NotEmpty();
            RuleFor(i => i.Type).NotEmpty();
            RuleFor(i => i.ExecutionDate).NotEmpty();
            RuleFor(i => i.PaymentTypeId).NotEmpty();
            RuleFor(i => i.CompanyDetailsId)
                .Custom((value, context) =>
                {
                    if (value == 0)
                        context.AddFailure("CompanyDetails", "CompanyDetails of customer are empty.");
                });
            RuleFor(i => i.CustomerId)
                .Custom((value, context) =>
                {
                    if (value == 0)
                        context.AddFailure("Customer", "Details of customer are empty.");
                });
            RuleFor(i => i.Author).NotEmpty();
        }
    }
}

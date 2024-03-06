using FluentValidation;

namespace Facturosaurus.Api.Models.Validators
{
    public class InvoiceItemDtoValidator : AbstractValidator<InvoiceItemDto>
    {
        public InvoiceItemDtoValidator()
        {
            RuleFor(i => i.ItemName).NotEmpty();
            RuleFor(i => i.Quantity).GreaterThan(1);
            RuleFor(i => i.UnitPrice).GreaterThan(0);
            RuleFor(i => i.NetValue).GreaterThan(0);
            RuleFor(i => i.Vat).NotNull();
            RuleFor(i => i.GrossValue).GreaterThan(0);

        }
    }
}

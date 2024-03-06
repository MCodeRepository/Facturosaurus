using System;
using System.Linq;

namespace Facturosaurus.Forms.Forms.Invoice
{
    internal class InvoiceItem
    {
        public int OrderNumber { get; set; }
        public string ItemName { get; set; }
        public UnitType Unit { get; set; }
        public string UnitDescription { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal NetValue { get; set; }
        public Vat Vat { get; set; }
        public decimal VatValue { get; set; }
        public decimal GrossValue { get; set; }
        public string VatRate { get; set; }


        public InvoiceItem(InvoiceItemDto invoiceItemDto)
        {
            OrderNumber = invoiceItemDto.OrderNumber;
            ItemName = invoiceItemDto.ItemName;
            Unit = UnitTypes.getUnitTypesList().Where(i => i.Id == invoiceItemDto.Unit).FirstOrDefault();
            UnitDescription = Unit.ShortName;
            Quantity = invoiceItemDto.Quantity;
            UnitPrice = invoiceItemDto.UnitPrice;
            NetValue = invoiceItemDto.NetValue;
            Vat = invoiceItemDto.Vat;//VatRates.getVatRatesList().Where(i => i.Id ==  invoiceItemDto.Vat.Id).FirstOrDefault();
            VatRate = Vat.Description;
            VatValue = invoiceItemDto.VatValue;
            GrossValue = invoiceItemDto.GrossValue;
        }

        public InvoiceItem()
        {
            ItemName = "";
            Unit = UnitTypes.getDefaultUnitType();
            UnitDescription = Unit.ShortName;
            Quantity = 0;
            UnitPrice = 0;
            NetValue = 0;
            Vat = VatRates.getDefaultVat();
            VatRate = Vat.Description;
            VatValue = 0;
            GrossValue = 0;
        }

        public void setVatRate(Vat vat)
        {
            Vat = vat;
            VatRate = Vat.Description;
            calculateItem();
        }

        public void setQuantity(int quantity)
        {
            Quantity = quantity;
            calculateItem();
        }

        public void setUnitPrice(Decimal unitPrice)
        {
            UnitPrice = unitPrice;
            calculateItem();
        }
        public void setUnit(UnitType unitType)
        {
            Unit = unitType;
            UnitDescription = Unit.ShortName;
        }

        private void calculateItem()
        {

            if (Quantity > 0 && UnitPrice > 0)
            {
                NetValue = Quantity * UnitPrice;
                GrossValue = Vat.Rate == 0 ? (Quantity * UnitPrice) : (Quantity * UnitPrice * (1 + Vat.Rate));
                VatValue = GrossValue - NetValue;
            }
            else
            {
                NetValue = 0;
                GrossValue = 0;
                VatValue = 0;
            }
        }

        public InvoiceItemDto getInvoiceItemDto(InvoiceItem invoiceItem)
        {
            InvoiceItemDto invoiceItemDto = new InvoiceItemDto()
            {

                OrderNumber = invoiceItem.OrderNumber,
                ItemName = invoiceItem.ItemName,
                Unit = invoiceItem.Unit.Id,
                Quantity = invoiceItem.Quantity,
                UnitPrice = invoiceItem.UnitPrice,
                NetValue = invoiceItem.NetValue,
                Vat = invoiceItem.Vat,
                //VatName = invoiceItem.Vat.Description,
                //VatRate = invoiceItem.Vat.Rate,
                VatValue = invoiceItem.VatValue,
                GrossValue = invoiceItem.GrossValue
            };
            return invoiceItemDto;
        }
    }
}

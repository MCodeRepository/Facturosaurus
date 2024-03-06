using System.Collections.Generic;

namespace Facturosaurus.Forms.Forms.Invoice
{
    internal class InvoiceTypes
    {
        private static List<InvoiceType> invoiceTypesList = new List<InvoiceType>()
        {
             new InvoiceType() { Id = 1, ShortName = "FV", Description = "Faktura VAT" },
             new InvoiceType() { Id = 2, ShortName = "FK", Description = "Korekta faktury VAT" },
        };

        public static List<InvoiceType> getInvoiceTypesList()
        {
            return invoiceTypesList;
        }
    }

    public class InvoiceType
    {
        public int Id { get; set; }
        public string ShortName { get; set; }
        public string Description { get; set; }
    }
}

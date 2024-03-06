using System;

namespace Facturosaurus.Forms.Lists
{
    internal class InvoicesList
    {
        public int Id { get; set; }
        public string InvoiceTypes { get; set; }
        public string WholeNumber { get; set; }
        public DateTime CreateDate { get; set; }
        //public string CreateDate { get; set; }
        public string ShortCompanyName { get; set; }
        public decimal NetAmount { get; set; }
        public decimal GrossAmount { get; set; }
        public DateTime PaymentDate { get; set; }
        public DateTime PaidDate { get; set; }
        public bool Paid { get; set; }
    }
}

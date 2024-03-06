using System;
using System.Collections.Generic;

namespace Facturosaurus.Forms.Models
{
    internal class InvoiceCreateDto
    {
        public int Type { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ExecutionDate { get; set; }
        public int PaymentTypeId { get; set; }
        public DateTime PaymentDate { get; set; }
        public int CompanyDetailsId { get; set; }
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerNipNumber { get; set; }
        public string CustomerStreetName { get; set; }
        public string CustomerBildingNumber { get; set; }
        public string CustomerApartmentNumber { get; set; }
        public string CustomerZipCode { get; set; }
        public string CustomerCity { get; set; }
        public decimal NetAmount { get; set; }
        public decimal GrossAmount { get; set; }
        public decimal VatAmount { get; set; }
        public bool Paid { get; set; }
        public DateTime PaidDate { get; set; }
        public Guid UserId { get; set; }
        public string Author { get; set; }

        public List<InvoiceItemDto> Items { get; set; }
    }
}

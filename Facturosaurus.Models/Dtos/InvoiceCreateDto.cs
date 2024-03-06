using System.Collections.Generic;
using System;

namespace Facturosaurus.Models.Dtos
{
    public class InvoiceCreateDto
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
        public string CustomeryName { get; set; }
        public string NipNumber { get; set; }
        public string StreetName { get; set; }
        public string BildingNumber { get; set; }
        public string ApartmentNumber { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public decimal NetAmount { get; set; }
        public decimal GrossAmount { get; set; }
        public decimal VatAmount { get; set; }
        public bool Paid { get; set; }
        public DateTime PaidDate { get; set; }

        public List<InvoiceItemDto> Items { get; set; }
    }
}

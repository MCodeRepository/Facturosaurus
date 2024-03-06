﻿namespace Facturosaurus.Models.Dtos
{
    public class CompanyDetailsCreateDto
    {
        public string ShortCompanyName { get; set; }
        public string CompanyName { get; set; }
        public string NipNumber { get; set; }
        public string StreetName { get; set; }
        public string BildingNumber { get; set; }
        public string ApartmentNumber { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string BankName { get; set; }
        public string Currency { get; set; }
        public string BankAccountNumber { get; set; }
        public string PhoneNumber { get; set; }
        public string AddressEmail { get; set; }
    }
}

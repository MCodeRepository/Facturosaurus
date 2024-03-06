namespace Facturosaurus.Forms
{
    public class CustomerCreateDto
    {
        public string ShortCustomerName { get; set; }
        public string CustomerName { get; set; }
        public string NipNumber { get; set; }
        public string StreetName { get; set; }
        public string BildingNumber { get; set; }
        public string ApartmentNumber { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string BankName { get; set; }
        public int AccountCurrency { get; set; }
        public string AccountNumber { get; set; }
        public string AddressEmail { get; set; }
        public string PhoneNumber { get; set; }
        public bool Active { get; set; }
    }
}

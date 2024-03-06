using Facturosaurus.Forms.Models;
using Facturosaurus.Forms.Printing;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Facturosaurus.Forms.Forms.Invoice
{
    internal class Invoice
    {
        public int Id { get; set; }
        public InvoiceType Type { get; set; }
        public int Number { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ExecutionDate { get; set; }
        public PaymentType PaymentType { get; set; }
        public DateTime PaymentDate { get; set; }
        public int CompanyDetailsId { get; set; }
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

        public List<InvoiceItem> Items { get; set; } = new List<InvoiceItem>();

        public Guid UserId { get; set; }
        public string Author { get; set; }
        private AppSettings appSettings { get; set; }


        public Invoice(CompanyDetailsDto companyDetailsDto)
        {
            appSettings = AppSettings.GetInstance();
            Type = InvoiceTypes.getInvoiceTypesList().Where(i => i.Id == 1).First();
            ExecutionDate = DateTime.Now;
            Month = ExecutionDate.Month;
            Year = ExecutionDate.Year;
            PaymentType = PaymentTypes.getPaymentTypesList().Where(p => p.Id == 1).First();
            PaymentDate = PaymentTypes.getPaymentDate(PaymentType, ExecutionDate);
            PaidDate = default;

            CompanyDetailsId = companyDetailsDto.Id;
            ShortCompanyName = companyDetailsDto.ShortCompanyName;
            CompanyName = companyDetailsDto.CompanyName;
            NipNumber = companyDetailsDto.NipNumber;
            StreetName = companyDetailsDto.StreetName;
            BildingNumber = companyDetailsDto.BildingNumber;
            ApartmentNumber = companyDetailsDto.ApartmentNumber;
            ZipCode = companyDetailsDto.ZipCode;
            City = companyDetailsDto.City;
            BankName = companyDetailsDto.BankName;
            Currency = companyDetailsDto.Currency;
            BankAccountNumber = companyDetailsDto.BankAccountNumber;
            PhoneNumber = companyDetailsDto.PhoneNumber;
            AddressEmail = companyDetailsDto.AddressEmail;

            UserId = appSettings.getLoggedUserId();
            Author = appSettings.getLoggedUserName();

            Items = new List<InvoiceItem>();
        }

        public Invoice(InvoiceDto invoiceDto)
        {
            appSettings = AppSettings.GetInstance();
            Id = invoiceDto.Id;
            Type = InvoiceTypes.getInvoiceTypesList().Where(i => i.Id == invoiceDto.Type).First();
            Number = invoiceDto.Number;
            Month = invoiceDto.Month;
            Year = invoiceDto.Year;
            CreateDate = invoiceDto.CreateDate;
            ExecutionDate = invoiceDto.ExecutionDate;
            PaymentType = PaymentTypes.getPaymentTypesList().Where(p => p.Id == invoiceDto.PaymentTypeId).First();
            PaymentDate = invoiceDto.PaymentDate;
            CompanyDetailsId = invoiceDto.CompanyDetailsId;
            ShortCompanyName = invoiceDto.ShortCompanyName;
            CompanyName = invoiceDto.CompanyName;
            NipNumber = invoiceDto.NipNumber;
            StreetName = invoiceDto.StreetName;
            BildingNumber = invoiceDto.BildingNumber;
            ApartmentNumber = invoiceDto.ApartmentNumber;
            ZipCode = invoiceDto.ZipCode;
            City = invoiceDto.City;
            BankName = invoiceDto.BankName;
            Currency = invoiceDto.Currency;
            BankAccountNumber = invoiceDto.BankAccountNumber;
            PhoneNumber = invoiceDto.PhoneNumber;
            AddressEmail = invoiceDto.AddressEmail;
            CustomerId = invoiceDto.CustomerId;
            CustomerName = invoiceDto.CustomerName;
            CustomerNipNumber = invoiceDto.CustomerNipNumber;
            CustomerStreetName = invoiceDto.CustomerStreetName;
            CustomerBildingNumber = invoiceDto.CustomerBildingNumber;
            CustomerApartmentNumber = invoiceDto.CustomerApartmentNumber;
            CustomerZipCode = invoiceDto.CustomerZipCode;
            CustomerCity = invoiceDto.CustomerCity;
            NetAmount = invoiceDto.NetAmount;
            GrossAmount = invoiceDto.GrossAmount;
            VatAmount = invoiceDto.VatAmount;
            Paid = invoiceDto.Paid;
            PaidDate = invoiceDto.PaidDate;
            Items = getItemsFromItemsDto(invoiceDto.Items);
            UserId = invoiceDto.UserId;
            Author = invoiceDto.Author;
        }

        private List<InvoiceItem> getItemsFromItemsDto(List<InvoiceItemDto> itemsDto)
        {
            if (itemsDto != null)
            {
                List<InvoiceItem> items = new List<InvoiceItem>();

                foreach (InvoiceItemDto item in itemsDto)
                {
                    items.Add(new InvoiceItem(item));
                }
                return items;
            }
            return null;
        }

        private List<InvoiceItemDto> getItemsToItemsDto(List<InvoiceItem> items)
        {
            if (items != null)
            {
                List<InvoiceItemDto> itemsDto = new List<InvoiceItemDto>();

                foreach (InvoiceItem item in items)
                {
                    itemsDto.Add(item.getInvoiceItemDto(item));
                }
                return itemsDto;
            }
            return null;
        }

        private void CalculateItemsAmounts(List<InvoiceItem> invoiceItems)
        {
            decimal netAmound = 0;
            decimal vatAmount = 0;
            decimal grossAmound = 0;

            foreach (var item in invoiceItems)
            {
                netAmound += item.NetValue;
                vatAmount += item.VatValue;
                grossAmound += item.GrossValue;
            }

            NetAmount = netAmound;
            VatAmount = vatAmount;
            GrossAmount = grossAmound;
        }

        public void setPaymentType(PaymentType paymentType)
        {
            PaymentType = paymentType;
            PaymentDate = PaymentTypes.getPaymentDate(PaymentType, ExecutionDate);
        }

        public void setExecutionDate(DateTime executionDate)
        {
            ExecutionDate = executionDate;
            Month = ExecutionDate.Month;
            Year = ExecutionDate.Year;
            PaymentDate = PaymentTypes.getPaymentDate(PaymentType, ExecutionDate);
        }

        public void setCustomer(CustomerDto customer)
        {
            CustomerId = customer.Id;
            CustomerName = customer.CustomerName;
            CustomerNipNumber = customer.NipNumber;
            CustomerStreetName = customer.StreetName;
            CustomerBildingNumber = customer.BildingNumber;
            CustomerApartmentNumber = customer.ApartmentNumber;
            CustomerZipCode = customer.ZipCode;
            CustomerCity = customer.City;
        }

        public void addInvoiceItem(InvoiceItem invoiceItem)
        {
            bool itemExists = Items.Where(i => i.Equals(invoiceItem)).FirstOrDefault() == null ? false : true;

            if (!itemExists)
            {
                invoiceItem.OrderNumber = Items.Count > 0 ? Items.Max(x => x.OrderNumber) + 1 : 1;
                Items.Add(invoiceItem);
            }

            CalculateItemsAmounts(Items);
        }

        public InvoiceDto GetInvoiceDto()
        {
            InvoiceDto invoiceDto = new InvoiceDto()
            {
                Id = this.Id,
                Type = this.Type.Id,
                Number = this.Number,
                Month = this.Month,
                Year = this.Year,
                CreateDate = this.CreateDate,
                ExecutionDate = this.ExecutionDate,
                PaymentTypeId = this.PaymentType.Id,
                PaymentDate = this.PaymentDate,
                CompanyDetailsId = this.CompanyDetailsId,
                ShortCompanyName = this.ShortCompanyName,
                CompanyName = this.CompanyName,
                NipNumber = this.NipNumber,
                StreetName = this.StreetName,
                BildingNumber = this.BildingNumber,
                ApartmentNumber = this.ApartmentNumber,
                ZipCode = this.ZipCode,
                City = this.City,
                BankName = this.BankName,
                Currency = this.Currency,
                BankAccountNumber = this.BankAccountNumber,
                PhoneNumber = this.PhoneNumber,
                AddressEmail = this.AddressEmail,
                CustomerId = this.CustomerId,
                CustomerName = this.CustomerName,
                CustomerNipNumber = this.CustomerNipNumber,
                CustomerStreetName = this.CustomerStreetName,
                CustomerBildingNumber = this.CustomerBildingNumber,
                CustomerApartmentNumber = this.CustomerApartmentNumber,
                CustomerZipCode = this.CustomerZipCode,
                CustomerCity = this.CustomerCity,
                NetAmount = this.NetAmount,
                GrossAmount = this.GrossAmount,
                VatAmount = this.VatAmount,
                Paid = this.Paid,
                PaidDate = this.PaidDate,
                UserId = this.UserId,
                Author = this.Author,

                Items = getItemsToItemsDto(this.Items)
            };

            return invoiceDto;
        }

        public InvoiceCreateDto GetInvoiceCreateDto()
        {
            InvoiceCreateDto invoiceDto = new InvoiceCreateDto()
            {
                Type = this.Type.Id,
                Month = this.Month,
                Year = this.Year,
                CreateDate = this.CreateDate,
                ExecutionDate = this.ExecutionDate,
                PaymentTypeId = this.PaymentType.Id,
                PaymentDate = this.PaymentDate,
                CompanyDetailsId = this.CompanyDetailsId,
                CustomerId = this.CustomerId,
                CustomerName = this.CustomerName,
                CustomerNipNumber = this.CustomerNipNumber,
                CustomerStreetName = this.CustomerStreetName,
                CustomerBildingNumber = this.CustomerBildingNumber,
                CustomerApartmentNumber = this.CustomerApartmentNumber,
                CustomerZipCode = this.CustomerZipCode,
                CustomerCity = this.CustomerCity,
                NetAmount = this.NetAmount,
                GrossAmount = this.GrossAmount,
                VatAmount = this.VatAmount,
                Paid = this.Paid,
                PaidDate = this.PaidDate,
                UserId = this.UserId,
                Author = this.Author,

                Items = getItemsToItemsDto(this.Items)
            };

            return invoiceDto;
        }

        internal void setPaidDate(bool paid)
        {
            Paid = paid;

            var date = PaidDate != default ? PaidDate : ExecutionDate;

            PaidDate = paid ? date : default;
        }

        internal void deleteItem(InvoiceItem itemToDelete)
        {
            //bool itemExists = Items.Where(i => i.Equals(invoiceItem)).FirstOrDefault() == null ? false : true;

            //if (!itemExists)
            //{
            //    invoiceItem.OrderNumber = Items.Count > 0 ? Items.Max(x => x.OrderNumber) + 1 : 1;
            //    Items.Add(invoiceItem);
            //    CalculateItemsAmounts(Items);
            //}
            Items.Remove(itemToDelete);
            remumerateOrdersNumbersOfItems(Items);
        }

        private void remumerateOrdersNumbersOfItems(List<InvoiceItem> items)
        {
            List<InvoiceItem> orderedList = Items.OrderBy(x => x.OrderNumber).ToList();
            int i = 1;

            foreach (var item in orderedList)
            {
                item.OrderNumber = i++;
            }
        }

        public string getFullInvoiceNumber()
        {
            return Number.ToString() + "/" + Month.ToString() + "/" + Year.ToString();
        }

        public string getCompanyNipNumber()
        {
            return "NIP: " + NipNumber;
        }

        public string getCompanyFullStreet()
        {
            return $"ul. {StreetName} {BildingNumber}/{ApartmentNumber}";
        }

        public string getCustomerNipNumber()
        {
            return "NIP: " + CustomerNipNumber;
        }

        public string getCompanyZipAndCity()
        {
            return $"{ZipCode} {City.ToUpper()}";
        }

        public string getCustomerFullStreet()
        {
            var apartmentNo = CustomerApartmentNumber.Trim() == "" ? "" : "/" + CustomerApartmentNumber.Trim();
            return $"ul. {CustomerStreetName} {CustomerBildingNumber}{apartmentNo}";
        }
        public string getCustomerZipAndCity()
        {
            return $"{CustomerZipCode} {CustomerCity.ToUpper()}";
        }

        public string getValueInWords()
        {
            decimal gross = GrossAmount;
            decimal integer = Math.Truncate(GrossAmount);
            decimal fractional = (gross - Math.Truncate(gross)) * 100;
            var integerNum = ValueToWords.LiczbaSlownie(Decimal.ToInt32(GrossAmount));

            var integerStr = ValueToWords.LiczbaSlownie(Decimal.ToInt32(integer));
            var fractionalStr = ValueToWords.LiczbaSlownie(Decimal.ToInt32(fractional));

            return $"{integerStr} zł {fractionalStr} gr";
        }

    }
}

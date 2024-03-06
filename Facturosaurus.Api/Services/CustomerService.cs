using AutoMapper;
using Facturosaurus.Api.Entities;
using Facturosaurus.Api.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Facturosaurus.Api.Services
{
    public interface ICustomerService
    {
        IEnumerable<CustomerDto> GetCustomersAllDetails();
        IEnumerable<CustomerShortListDto> GetCustomersShortList();
        CustomerDto GetCustomerDetails(int customerId);
        int CreateCustomer(CustomerCreateDto customer);
        bool UpadateCustomer(CustomerModifyDto customer);
        bool DeleteCustomer(int customerId);
    }

    public class CustomerService : ICustomerService
    {
        private readonly FacturosaurusDbContext _dbContext;
        private readonly IMapper _mapper;

        public CustomerService(FacturosaurusDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public IEnumerable<CustomerDto> GetCustomersAllDetails()
        {
            var customers = _dbContext.Cutomers
                .Include(c => c.BankAccounts)
                .Include(c => c.Adresses)
                .Include(c => c.Phones)
                .Include(c => c.EmailAdresses)
                .ToList();

            var customersDto = _mapper.Map<List<CustomerDto>>(customers);

            return customersDto;
        }

        public IEnumerable<CustomerShortListDto> GetCustomersShortList()
        {
            var customers = _dbContext.Cutomers.ToList();
            var customersShortListDto = _mapper.Map<List<CustomerShortListDto>>(customers);

            return customersShortListDto;
        }

        public CustomerDto GetCustomerDetails(int customerId)
        {
            var customer = _dbContext
                .Cutomers
                .Include(a => a.Adresses)
                .Include(a => a.BankAccounts)
                .Include(a => a.EmailAdresses)
                .Include(a => a.Phones)
                .FirstOrDefault(c => c.Id == customerId);

            var customersDto = _mapper.Map<CustomerDto>(customer);

            return customersDto;
        }

        public int CreateCustomer(CustomerCreateDto customer)
        {
            var nipIsUse = _dbContext.Cutomers.Any(c => c.NipNumber == customer.NipNumber);

            if (!nipIsUse)
            {
                var newCustomer = _mapper.Map<Customer>(customer);

                newCustomer.UpdatedDate = DateTime.Now.Date;

                var address = _mapper.Map<CustomerAddress>(customer);
                var bank = _mapper.Map<CustomerBankAccount>(customer);
                var email = _mapper.Map<CustomerEmailAddress>(customer);
                var phone = _mapper.Map<CustomerPhone>(customer);

                newCustomer.Adresses.Add(address);
                newCustomer.BankAccounts.Add(bank);
                newCustomer.EmailAdresses.Add(email);
                newCustomer.Phones.Add(phone);

                _dbContext.Cutomers.Add(newCustomer);
                _dbContext.SaveChanges();

                return newCustomer.Id;
            }
            return 0;
        }

        public bool UpadateCustomer(CustomerModifyDto customer)
        {
            var customerToUpdate = _dbContext.Cutomers.FirstOrDefault(c => c.Id == customer.Id);


            if (customerToUpdate != null)
            {
                customerToUpdate.ShortCustomerName = customer.ShortCustomerName;
                customerToUpdate.CustomerName = customer.CustomerName;
                customerToUpdate.UpdatedDate = DateTime.Now;
                customerToUpdate.Active = customer.Active;

                _dbContext.Cutomers.Update(customerToUpdate);
                _dbContext.SaveChanges();


                CustomerAddress addressToUpdate = _dbContext.Addresses.FirstOrDefault(c => c.CustomerId == customer.Id && c.Default == true);

                if (addressToUpdate != null)
                {
                    addressToUpdate.CustomerId = customer.Id;
                    addressToUpdate.OrderNumber = 1;
                    addressToUpdate.StreetName = customer.StreetName;
                    addressToUpdate.BildingNumber = customer.BildingNumber;
                    addressToUpdate.ApartmentNumber = customer.ApartmentNumber;
                    addressToUpdate.ZipCode = customer.ZipCode;
                    addressToUpdate.City = customer.City;
                    addressToUpdate.Default = true;
                    _dbContext.Addresses.Update(addressToUpdate);

                }
                else if (customerToUpdate.Id > 0)
                {
                    var newAddress = new CustomerAddress()
                    {
                        Id = addressToUpdate.Id,
                        CustomerId = customer.Id,
                        OrderNumber = 1,
                        StreetName = customer.StreetName,
                        BildingNumber = customer.BildingNumber,
                        ApartmentNumber = customer.ApartmentNumber,
                        ZipCode = customer.ZipCode,
                        City = customer.City,
                        Default = true
                    };
                    _dbContext.Addresses.Add(newAddress);
                }

                CustomerBankAccount bankAccountToUpdate = _dbContext.BankAccounts.FirstOrDefault(c => c.CustomerId == customer.Id && c.Default == true);

                if (bankAccountToUpdate != null)
                {
                    bankAccountToUpdate.CustomerId = customer.Id;
                    bankAccountToUpdate.OrderNumber = 1;
                    bankAccountToUpdate.BankName = customer.BankName;
                    bankAccountToUpdate.AccountCurrency = customer.AccountCurrency;
                    bankAccountToUpdate.AccountNumber = customer.AccountNumber;
                    bankAccountToUpdate.Default = true;

                    _dbContext.BankAccounts.Update(bankAccountToUpdate);
                }
                else if (customerToUpdate.Id > 0)
                {
                    var newBankAccount = new CustomerBankAccount()
                    {
                        CustomerId = customer.Id,
                        OrderNumber = 1,
                        BankName = customer.BankName,
                        AccountCurrency = customer.AccountCurrency,
                        AccountNumber = customer.AccountNumber,
                        Default = true
                    };
                    _dbContext.BankAccounts.Add(newBankAccount);
                }

                CustomerEmailAddress emailAddressToUpdate = _dbContext.EmailAddresses.FirstOrDefault(c => c.CustomerId == customer.Id && c.Default == true);

                if (emailAddressToUpdate != null)
                {
                    emailAddressToUpdate.CustomerId = customer.Id;
                    emailAddressToUpdate.OrderNumber = 1;
                    emailAddressToUpdate.AddressEmail = customer.AddressEmail;
                    emailAddressToUpdate.Default = true;
                    _dbContext.EmailAddresses.Update(emailAddressToUpdate);
                }
                else if (customerToUpdate.Id > 0)
                {
                    var newEmailAddress = new CustomerEmailAddress()
                    {
                        CustomerId = customer.Id,
                        OrderNumber = 1,
                        AddressEmail = customer.AddressEmail,
                        Default = true
                    };
                    _dbContext.EmailAddresses.Add(newEmailAddress);
                }

                CustomerPhone phoneToUpdate = _dbContext.Phones.FirstOrDefault(c => c.CustomerId == customer.Id && c.Default == true);
                if (phoneToUpdate != null)
                {
                    phoneToUpdate.CustomerId = customer.Id;
                    phoneToUpdate.OrderNumber = 1;
                    phoneToUpdate.PhoneNumber = customer.PhoneNumber;
                    phoneToUpdate.Default = true;

                    _dbContext.Phones.Update(phoneToUpdate);

                }
                else if (customerToUpdate.Id > 0)
                {
                    var newPhone = new CustomerPhone()
                    {
                        CustomerId = customer.Id,
                        OrderNumber = 1,
                        PhoneNumber = customer.PhoneNumber,
                        Default = true
                    };
                    _dbContext.Phones.Add(newPhone);
                }

                _dbContext.SaveChanges();

                return true;
            }

            return false;
        }

        public bool DeleteCustomer(int customerId)
        {
            var customerToDelete = _dbContext.Cutomers.FirstOrDefault(c => c.Id == customerId);


            if (customerToDelete != null)
            {
                _dbContext.Cutomers.Remove(customerToDelete);

                var addressToDelete = _dbContext.Addresses.Where(c => c.CustomerId == customerId).ToList();

                if (addressToDelete != null)
                {
                    _dbContext.Addresses.RemoveRange(addressToDelete);
                }

                var bankAccountToDelete = _dbContext.BankAccounts.Where(c => c.CustomerId == customerId).ToList();

                if (bankAccountToDelete != null)
                {
                    _dbContext.BankAccounts.RemoveRange(bankAccountToDelete);
                }

                var emailAddressToDelete = _dbContext.EmailAddresses.Where(c => c.CustomerId == customerId).ToList();

                if (emailAddressToDelete != null)
                {
                    _dbContext.EmailAddresses.RemoveRange(emailAddressToDelete);
                }

                var phoneToDelete = _dbContext.Phones.Where(c => c.CustomerId == customerId).ToList();
                if (phoneToDelete != null)
                {
                    _dbContext.Phones.RemoveRange(phoneToDelete);
                }

                _dbContext.SaveChanges();

                return true;
            }

            return false;
        }
    }
}

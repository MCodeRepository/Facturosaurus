using AutoMapper;
using Facturosaurus.Api.Entities;
using Facturosaurus.Api.Models;
using System.Linq;

namespace Facturosaurus.Api
{
    public class FacturosaurusMappingProfile : Profile
    {
        public FacturosaurusMappingProfile()
        {
            CreateMap<User, UserDto>()
                .ForMember(m => m.RoleName, c => c.MapFrom(s => s.Role.Name));

            CreateMap<UserRegisterDto, User>();
            CreateMap<CompanyDetails, CompanyDetailsDto>();
            CreateMap<CompanyDetailsCreateDto, CompanyDetails>();
            CreateMap<Customer, CustomerDto>()
                .ForMember(c => c.StreetName, c => c.MapFrom(a => a.Adresses.Where(d => d.Default == true).FirstOrDefault().StreetName))
                .ForMember(c => c.BildingNumber, c => c.MapFrom(a => a.Adresses.Where(d => d.Default == true).FirstOrDefault().BildingNumber))
                .ForMember(c => c.ApartmentNumber, c => c.MapFrom(a => a.Adresses.Where(d => d.Default == true).FirstOrDefault().ApartmentNumber))
                .ForMember(c => c.ZipCode, c => c.MapFrom(a => a.Adresses.Where(d => d.Default == true).FirstOrDefault().ZipCode))
                .ForMember(c => c.City, c => c.MapFrom(a => a.Adresses.Where(d => d.Default == true).FirstOrDefault().City))
                .ForMember(c => c.BankName, c => c.MapFrom(a => a.BankAccounts.Where(d => d.Default == true).FirstOrDefault().BankName))
                .ForMember(c => c.AccountCurrency, c => c.MapFrom(a => a.BankAccounts.Where(d => d.Default == true).FirstOrDefault().AccountCurrency))
                .ForMember(c => c.AccountNumber, c => c.MapFrom(a => a.BankAccounts.Where(d => d.Default == true).FirstOrDefault().AccountNumber))
                .ForMember(c => c.AddressEmail, c => c.MapFrom(a => a.EmailAdresses.Where(d => d.Default == true).FirstOrDefault().AddressEmail))
                .ForMember(c => c.PhoneNumber, c => c.MapFrom(a => a.Phones.Where(d => d.Default == true).FirstOrDefault().PhoneNumber));
            CreateMap<Customer, CustomerShortListDto>();

            CreateMap<CustomerCreateDto, Customer>();

            CreateMap<CustomerCreateDto, CustomerAddress>()
                .ForMember(c => c.StreetName, c => c.MapFrom(a => a.StreetName))
                .ForMember(c => c.BildingNumber, c => c.MapFrom(a => a.BildingNumber))
                .ForMember(c => c.ApartmentNumber, c => c.MapFrom(a => a.ApartmentNumber))
                .ForMember(c => c.BildingNumber, c => c.MapFrom(a => a.BildingNumber))
                .ForMember(c => c.ZipCode, c => c.MapFrom(a => a.ZipCode))
                .ForMember(c => c.City, c => c.MapFrom(a => a.City));

            CreateMap<CustomerCreateDto, CustomerBankAccount>()
                .ForMember(c => c.BankName, c => c.MapFrom(a => a.BankName))
                .ForMember(c => c.AccountCurrency, c => c.MapFrom(a => a.AccountCurrency))
                .ForMember(c => c.AccountNumber, c => c.MapFrom(a => a.AccountNumber));

            CreateMap<CustomerCreateDto, CustomerEmailAddress>()
                .ForMember(c => c.AddressEmail, c => c.MapFrom(a => a.AddressEmail));

            CreateMap<CustomerCreateDto, CustomerPhone>()
                .ForMember(c => c.PhoneNumber, c => c.MapFrom(a => a.PhoneNumber));

            CreateMap<Invoice, InvoiceDto>()
                .ForMember(c => c.CompanyName, c => c.MapFrom(a => a.CompanyDetails.CompanyName))
                .ForMember(c => c.ShortCompanyName, c => c.MapFrom(a => a.CompanyDetails.ShortCompanyName))
                .ForMember(c => c.NipNumber, c => c.MapFrom(a => a.CompanyDetails.NipNumber))
                .ForMember(c => c.StreetName, c => c.MapFrom(a => a.CompanyDetails.StreetName))
                .ForMember(c => c.BildingNumber, c => c.MapFrom(a => a.CompanyDetails.BildingNumber))
                .ForMember(c => c.ApartmentNumber, c => c.MapFrom(a => a.CompanyDetails.ApartmentNumber))
                .ForMember(c => c.ZipCode, c => c.MapFrom(a => a.CompanyDetails.ZipCode))
                .ForMember(c => c.City, c => c.MapFrom(a => a.CompanyDetails.City))
                .ForMember(c => c.BankName, c => c.MapFrom(a => a.CompanyDetails.BankName))
                .ForMember(c => c.Currency, c => c.MapFrom(a => a.CompanyDetails.Currency))
                .ForMember(c => c.BankAccountNumber, c => c.MapFrom(a => a.CompanyDetails.BankAccountNumber))
                .ForMember(c => c.PhoneNumber, c => c.MapFrom(a => a.CompanyDetails.PhoneNumber))
                .ForMember(c => c.AddressEmail, c => c.MapFrom(a => a.CompanyDetails.AddressEmail))
                .ForMember(c => c.Author, c => c.MapFrom(a => a.User.FirstName + " " + a.User.LastName));

            CreateMap<InvoiceItems, InvoiceItemDto>();
            CreateMap<InvoiceDto, Invoice>();
            CreateMap<InvoiceCreateDto, Invoice>();
            CreateMap<InvoiceItemDto, InvoiceItems>();

            CreateMap<Role, RoleDto>();
        }
    }
}
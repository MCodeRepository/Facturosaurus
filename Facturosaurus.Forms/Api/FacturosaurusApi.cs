using Facturosaurus.Forms.Api.Services;
using Facturosaurus.Forms.dtos;
using Facturosaurus.Forms.Forms.Invoice;
using Facturosaurus.Forms.Models;
using Facturosaurus.Forms.SubbClases;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facturosaurus.Forms.api
{
    internal class FacturosaurusApi
    {
        public bool HasConnection { get; set; }

        AppSettings appSettings;
        HttpClient client;
        AccountService accountService;
        CompanyDetailsService companyDetailsService;
        InvoiceService invoiceService;
        CustomerService customerService;
        ReportsService reportsService;

        public FacturosaurusApi()
        {
            appSettings = AppSettings.GetInstance();
            SetBaseAddres();
            setAccesToken();
        }

        public void SetBaseAddres()
        {
            string baseUrl = appSettings.GetApiBaseUrl();

            if (baseUrl != "")
            {
                client = new HttpClient();
                client.BaseAddress = new Uri(baseUrl);
                accountService = new AccountService(client);
                companyDetailsService = new CompanyDetailsService(client);
                invoiceService = new InvoiceService(client);
                customerService = new CustomerService(client);
                reportsService = new ReportsService(client);
            }

            HasConnection = TestConnection();
        }

        public void setAccesToken()
        {
            if (client != null && client.BaseAddress != null)
            {
                string accessToken = appSettings.getTokenFromLoggedUser();
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

                HasConnection = TestConnection();
            }
            else
            {
                HasConnection = false;
            }
        }

        private bool TestConnection()
        {
            if (client != null && client.BaseAddress != null)
            {
                try
                {
                    Result<bool> result = accountService.Connected();

                    if (result.Value)
                    {
                        return true;
                    }
                }
                catch (Exception) { }
            }
            return false;
        }

        public List<CustomerDto> GetCustomersList()
        {
            if (HasConnection)
            {
                Result<List<CustomerDto>> result = customerService.GetCustomersList();

                if (result.Status != 200)
                    MessageBox.Show(StatusCodes.GetErrorInfo(result.Status));

                return result.Value;
            }
            return null;
        }

        public bool CreateNewCustomer(string shortCustomerName, string customerName, string nipNumber, string streetName, string bildingNumber,
            string apartmentNumber, string zipCode, string city, string bankName, int currency, string bankAccountNumber, string phoneNumber, string addressEmail, bool active)
        {
            if (HasConnection)
            {
                CustomerCreateDto customer = new CustomerCreateDto()
                {
                    ShortCustomerName = shortCustomerName,
                    CustomerName = customerName,
                    NipNumber = nipNumber,
                    StreetName = streetName,
                    BildingNumber = bildingNumber,
                    ApartmentNumber = apartmentNumber,
                    ZipCode = zipCode,
                    City = city,
                    BankName = bankName,
                    AccountCurrency = currency,
                    AccountNumber = bankAccountNumber,
                    PhoneNumber = phoneNumber,
                    AddressEmail = addressEmail,
                    Active = active
                };

                Result<bool> result = customerService.CreateNewCustomer(customer);

                if (result.Status != 201)
                {
                    var errorInfo = result.Info != "" ? result.Info : StatusCodes.GetErrorInfo(result.Status);
                    MessageBox.Show(errorInfo);
                }


                return result.Value;
            }
            return false;
        }

        public bool ModifyCustomer(int customerId, string shortCustomerName, string customerName, string nipNumber, string streetName, string bildingNumber,
            string apartmentNumber, string zipCode, string city, string bankName, int currency, string bankAccountNumber, string phoneNumber, string addressEmail, bool active)
        {
            if (client.BaseAddress != null)
            {
                CustomerModifyDto customer = new CustomerModifyDto()
                {
                    Id = customerId,
                    ShortCustomerName = shortCustomerName,
                    CustomerName = customerName,
                    NipNumber = nipNumber,
                    StreetName = streetName,
                    BildingNumber = bildingNumber,
                    ApartmentNumber = apartmentNumber,
                    ZipCode = zipCode,
                    City = city,
                    BankName = bankName,
                    AccountCurrency = currency,
                    AccountNumber = bankAccountNumber,
                    PhoneNumber = phoneNumber,
                    AddressEmail = addressEmail,
                    Active = active
                };


                Result<bool> result = customerService.ModifyCustomer(customer);

                if (result.Status != 200)
                    MessageBox.Show(StatusCodes.GetErrorInfo(result.Status));

                return result.Value;
            }
            return false;
        }

        public bool DeleteCustomer(int customerId)
        {
            if (HasConnection)
            {
                Result<bool> result = customerService.DeleteCustomer(customerId);

                if (result.Status != 200)
                    MessageBox.Show(StatusCodes.GetErrorInfo(result.Status));

                return result.Value;
            }
            return false;
        }

        public List<InvoiceDto> GetInvoicesList()
        {
            if (HasConnection)
            {
                Result<List<InvoiceDto>> result = invoiceService.GetInvoicesList();

                if (result.Status != 200)
                    MessageBox.Show(StatusCodes.GetErrorInfo(result.Status));

                return result.Value;
            }
            return null;
        }


        public bool CreateNewInvoice(InvoiceCreateDto invoiceDto)
        {
            if (HasConnection)
            {
                Result<bool> result = invoiceService.CreateNewInvoice(invoiceDto);

                if (result.Status != 201)
                    MessageBox.Show(StatusCodes.GetErrorInfo(result.Status));

                return result.Value;
            }
            return false;
        }

        internal bool ModifyInvoice(InvoiceDto invoiceDto)
        {
            if (HasConnection)
            {
                Result<bool> result = invoiceService.ModifyInvoice(invoiceDto);

                if (result.Status != 200)
                    MessageBox.Show(StatusCodes.GetErrorInfo(result.Status));

                return result.Value;
            }
            return false;
        }

        public List<UserDto> GetUsersList()
        {
            if (HasConnection)
            {
                Result<List<UserDto>> result = accountService.GetUsersList();

                if (result.Status != 200)
                    MessageBox.Show(StatusCodes.GetErrorInfo(result.Status));

                return result.Value;
            }
            return null;
        }

        public List<RoleDto> GetRolesList()
        {
            if (HasConnection)
            {
                Result<List<RoleDto>> result = accountService.GetRolesList();

                if (result.Status != 200)
                    MessageBox.Show(StatusCodes.GetErrorInfo(result.Status));

                return result.Value;
            }
            return null;
        }

        public UserDto GetUser(Guid id)
        {
            if (HasConnection)
            {
                Result<UserDto> result = accountService.GetUser(id);

                if (result.Status != 200)
                    MessageBox.Show(StatusCodes.GetErrorInfo(result.Status));

                return result.Value;
            }
            return null;
        }

        public UserDto GetUser(string email)
        {
            if (HasConnection)
            {
                Result<UserDto> result = accountService.GetUser(email);

                if (result.Status != 200)
                    MessageBox.Show(StatusCodes.GetErrorInfo(result.Status));

                return result.Value;
            }
            return null;
        }

        public void DeleteUser(Guid id)
        {
            if (HasConnection)
            {
                Result<UserDto> result = accountService.DeleteUser(id);

                if (result.Status != 200)
                    MessageBox.Show(StatusCodes.GetErrorInfo(result.Status));
            }
        }

        public void RegisterUser(UserRegisterDto userRegisterDto)
        {
            if (HasConnection)
            {
                Result<UserDto> result = accountService.RegisterUser(userRegisterDto);

                if (result.Status != 201)
                    MessageBox.Show(StatusCodes.GetErrorInfo(result.Status));
            }
        }

        internal void ModifyUser(UserModifyDto userModifyDto)
        {
            if (HasConnection)
            {
                Result<UserDto> result = accountService.ModifyUser(userModifyDto);

                if (result.Status != 200)
                {
                    MessageBox.Show(StatusCodes.GetErrorInfo(result.Status));
                }
            }
        }

        internal void ChangePassword(UserNewPasswordDto userNewPasswordDto)
        {
            if (HasConnection)
            {
                Result<UserDto> result = accountService.ChangePassword(userNewPasswordDto);

                if (result.Status != 200)
                {
                    MessageBox.Show(StatusCodes.GetErrorInfo(result.Status));
                }
            }
        }

        internal string Login(LoginDto loginDto)
        {
            if (HasConnection)
            {
                Result<string> result = accountService.Login(loginDto);

                if (result.Status != 200)
                {
                    MessageBox.Show(result.Value);
                    return String.Empty;
                }
                return result.Value;
            }

            return String.Empty;
        }



        public CompanyDetailsDto GetCurrentCompanyDetails()
        {
            if (HasConnection)
            {
                Result<CompanyDetailsDto> result = companyDetailsService.GetCurrentCompanyDetails();

                if (result.Status != 200 && result.Status != 204)
                {
                    MessageBox.Show(StatusCodes.GetErrorInfo(result.Status));
                }
                return result.Value;
            }

            return null;
        }

        public CompanyDetailsDto GetCompanyDetailsForDate(Invoice invoice)
        {
            if (HasConnection)
            {
                Result<CompanyDetailsDto> result = companyDetailsService.GetCompanyDetailsForDate(invoice);

                if (result.Status != 200)
                {
                    MessageBox.Show(StatusCodes.GetErrorInfo(result.Status));
                }
                return result.Value;
            }

            return null;
        }

        public bool CreateNewCompanyDetails(string shortCompanyName, string companyName, string nipNumber, string streetName, string bildingNumber,
            string apartmentNumber, string zipCode, string city, string bankName, string currency, string bankAccountNumber, string phoneNumber, string addressEmail)
        {
            if (HasConnection)
            {
                CompanyDetailsCreateDto companyDetails = new CompanyDetailsCreateDto()
                {
                    ShortCompanyName = shortCompanyName,
                    CompanyName = companyName,
                    NipNumber = nipNumber,
                    StreetName = streetName,
                    BildingNumber = bildingNumber,
                    ApartmentNumber = apartmentNumber,
                    ZipCode = zipCode,
                    City = city,
                    BankName = bankName,
                    Currency = currency,
                    BankAccountNumber = bankAccountNumber,
                    PhoneNumber = phoneNumber,
                    AddressEmail = addressEmail
                };

                Result<CompanyDetailsCreateDto> result = companyDetailsService.CreateNewCompanyDetails(companyDetails);

                if (result.Status != 201)
                {
                    MessageBox.Show(StatusCodes.GetErrorInfo(result.Status));
                    return false;
                }
                else
                    return true;
            }
            return false;
        }


        public async Task GetReportNotPaidInvoices()
        {
            await reportsService.GetNotPaidInvoicesReport();
        }

        public async Task GetCustomerReport()
        {
            await reportsService.GetCustomerReport();
        }

        public async Task GetCustomerInvoicesReport(int customerId)
        {
            await reportsService.GetCustomerInvoicesReport(customerId);
        }
    }
}
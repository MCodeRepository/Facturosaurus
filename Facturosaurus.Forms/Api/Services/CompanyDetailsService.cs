using Facturosaurus.Forms.Forms.Invoice;
using System;
using System.Net.Http;

namespace Facturosaurus.Forms.Api.Services
{
    internal class CompanyDetailsService
    {
        private readonly HttpClient _httpClient;

        public CompanyDetailsService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public Result<CompanyDetailsDto> GetCurrentCompanyDetails()
        {
            if (_httpClient.BaseAddress != null)
            {
                CompanyDetailsDto companyDetails;

                try
                {
                    HttpResponseMessage response = _httpClient.GetAsync("/api/companyDetails/recent").Result;
                    companyDetails = response.Content.ReadAsAsync<CompanyDetailsDto>().Result;

                    return new Result<CompanyDetailsDto> { Value = companyDetails, Status = (int)response.StatusCode };
                }
                catch (Exception)
                {
                    return new Result<CompanyDetailsDto> { Status = 1200 };
                }
            }
            else
                return new Result<CompanyDetailsDto> { Status = 1001 };
        }

        public Result<CompanyDetailsDto> GetCompanyDetailsForDate(Invoice invoice)
        {
            if (_httpClient.BaseAddress != null)
            {
                CompanyDetailsDto companyDetails;
                try
                {
                    var date = invoice.ExecutionDate.ToString("yyyy-MM-dd");
                    HttpResponseMessage response = _httpClient.GetAsync($"api/companyDetails/forDate/{date}").Result;

                    companyDetails = response.Content.ReadAsAsync<CompanyDetailsDto>().Result;

                    if ((int)response.StatusCode == 204)
                        return new Result<CompanyDetailsDto> { Status = 1204 };

                    return new Result<CompanyDetailsDto> { Value = companyDetails, Status = (int)response.StatusCode };
                }
                catch (Exception)
                {
                    return new Result<CompanyDetailsDto> { Status = 1201 };
                }
            }
            else
                return new Result<CompanyDetailsDto> { Status = 1001 };
        }

        public Result<CompanyDetailsCreateDto> CreateNewCompanyDetails(CompanyDetailsCreateDto companyDetails)
        {
            if (_httpClient.BaseAddress != null)
            {
                if (companyDetails != null)
                {
                    try
                    {
                        var response = _httpClient.PostAsJsonAsync<CompanyDetailsCreateDto>("api/companyDetails", companyDetails).Result;

                        return new Result<CompanyDetailsCreateDto> { Status = (int)response.StatusCode };
                    }
                    catch (Exception)
                    {
                        return new Result<CompanyDetailsCreateDto> { Status = 1202 };
                    }
                }
                else
                    return new Result<CompanyDetailsCreateDto> { Status = 1203 };
            }
            else
                return new Result<CompanyDetailsCreateDto> { Status = 1001 };
        }
    }
}

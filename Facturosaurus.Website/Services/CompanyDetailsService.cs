using Facturosaurus.Models.Dtos;
using Facturosaurus.Website.Services.Contracts;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Facturosaurus.Website.Services
{
    public class CompanyDetailsService : ICompanyDetailsService
    {
        private readonly HttpClient httpClient;

        public CompanyDetailsService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<IEnumerable<CompanyDetailsDto>> GetAllDetails()
        {
            try
            {
                var details = await httpClient.GetFromJsonAsync<IEnumerable<CompanyDetailsDto>>("api/company");
                return details;
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        public Task<CompanyDetailsDto> GetRecentDtails()
        {
            throw new System.NotImplementedException();
        }
    }
}

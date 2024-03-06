using Facturosaurus.Models.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Facturosaurus.Website.Services.Contracts
{
    public interface ICompanyDetailsService
    {
        Task<IEnumerable<CompanyDetailsDto>> GetAllDetails();
        Task<CompanyDetailsDto> GetRecentDtails();
    }
}

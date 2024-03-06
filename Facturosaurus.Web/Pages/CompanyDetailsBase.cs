using Facturosaurus.Models.Dtos;
using Facturosaurus.Web.Services.Contracts;
using Microsoft.AspNetCore.Components;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Facturosaurus.Web.Pages
{
    public class CompanyDetailsBase : ComponentBase
    {
        [Inject]
        public ICompanyDetailsService CompanyDetailsService { get; set; }

        public IEnumerable<CompanyDetailsDto> CompanyDetails { get; set; }

        protected override async Task OnInitializedAsync()
        {
            CompanyDetails = await CompanyDetailsService.GetAllDetails();
        }
    }
}

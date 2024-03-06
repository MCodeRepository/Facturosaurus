using AutoMapper;
using Facturosaurus.Api.Entities;
using Facturosaurus.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Facturosaurus.Api.Services
{
    public interface ICompanyService
    {
        IEnumerable<CompanyDetailsDto> GetAll();
        CompanyDetailsDto GetCompanyDetailsForTheDate(DateTime date);
        CompanyDetailsDto GetLast();
        CompanyDetails SaveNewCompanyDetails(CompanyDetailsCreateDto companyDetailsCreateDto);
    }

    public class CompanyService : ICompanyService
    {
        private readonly FacturosaurusDbContext _dbContext;
        private readonly IMapper _mapper;

        public CompanyService(FacturosaurusDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public IEnumerable<CompanyDetailsDto> GetAll()
        {
            var companyDetails = _dbContext.CompanyDetails.ToList();

            var companyDetailsDto = _mapper.Map<List<CompanyDetailsDto>>(companyDetails);

            return companyDetailsDto;
        }

        public CompanyDetailsDto GetLast()
        {
            var companyDetails = _dbContext.CompanyDetails.ToList();

            var lastCompanyDetails = (from companyDetal in companyDetails
                                      orderby companyDetal.UpdateDate
                                      select companyDetal).LastOrDefault();

            if (lastCompanyDetails != null)
            {
                var lastCompanyDetailsDto = _mapper.Map<CompanyDetailsDto>(lastCompanyDetails);

                return lastCompanyDetailsDto;
            }

            return null;
        }

        public CompanyDetailsDto GetCompanyDetailsForTheDate(DateTime date)
        {
            var companyDetails = _dbContext.CompanyDetails.ToList();


            var sortedCompanyDetails = (from companyDetal in companyDetails
                                        orderby companyDetal.UpdateDate
                                        select companyDetal).ToList();

            var sortedCompanyDetailsDto = _mapper.Map<List<CompanyDetailsDto>>(sortedCompanyDetails);

            CompanyDetailsDto companyDetailsForDate = null;

            foreach (var companyDetal in sortedCompanyDetailsDto)
            {
                if (companyDetal.UpdateDate.Date <= date.Date)
                    companyDetailsForDate = companyDetal;
            }

            return companyDetailsForDate;
        }

        public CompanyDetails SaveNewCompanyDetails(CompanyDetailsCreateDto companyDetailsCreateDto)
        {
            var companyDetails = _mapper.Map<CompanyDetails>(companyDetailsCreateDto);

            _dbContext.CompanyDetails.Add(companyDetails);
            _dbContext.SaveChanges();

            return companyDetails;
        }
    }
}

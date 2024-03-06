using Facturosaurus.Api.Entities;
using Facturosaurus.Api.Models;
using Facturosaurus.Api.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Facturosaurus.Api.Controllers
{
    [Route("api/companyDetails")]
    [ApiController]
    [Authorize]
    public class CompanyController : ControllerBase
    {
        private readonly ICompanyService _companyService;

        public CompanyController(ICompanyService companyService)
        {
            _companyService = companyService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<CompanyDetails>> GetAll()
        {
            var companyDetailsDto = _companyService.GetAll();
            return Ok(companyDetailsDto);
        }

        [HttpGet]
        [Route("recent")]
        public ActionResult<CompanyDetails> GetLast()
        {
            var companyDetailsDto = _companyService.GetLast();
            return Ok(companyDetailsDto);
        }

        [HttpGet]
        [Route("forDate/{date:datetime}")]
        public ActionResult<CompanyDetails> GetCompanyDetailsForTheDate(DateTime date)
        {
            var companyDetailsForDate = _companyService.GetCompanyDetailsForTheDate(date);
            return Ok(companyDetailsForDate);
        }

        [HttpPost]
        public ActionResult UpdateCompanyDetails([FromBody] CompanyDetailsCreateDto companyDetailsCreateDto)
        {
            _companyService.SaveNewCompanyDetails(companyDetailsCreateDto);
            return Created($"api/companyDetails/recent", null);
        }
    }
}

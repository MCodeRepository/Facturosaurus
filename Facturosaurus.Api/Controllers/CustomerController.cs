using Facturosaurus.Api.Entities;
using Facturosaurus.Api.Models;
using Facturosaurus.Api.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Facturosaurus.Api.Controllers
{
    [Route("api/customers")]
    [ApiController]
    [Authorize(Roles = "Użytkownik")]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;

        public CustomerController(FacturosaurusDbContext dbContext, ICustomerService customerService)
        {
            _customerService = customerService;
        }


        [HttpGet]
        public ActionResult<IEnumerable<CustomerDto>> GetCustomersAllDetails()
        {
            var customersDto = _customerService.GetCustomersAllDetails();
            return Ok(customersDto);
        }


        [HttpGet]
        [Route("/shortList")]
        public ActionResult<IEnumerable<CustomerShortListDto>> GetCustomersShortList()
        {

            var customersShortListDto = _customerService.GetCustomersShortList();
            return Ok(customersShortListDto);
        }


        [HttpGet("{customerId}")]
        public ActionResult<CustomerDto> GetCustomerDetails([FromRoute] int customerId)
        {
            var customersDto = _customerService.GetCustomerDetails(customerId);
            return Ok(customersDto);
        }

        [HttpPost]
        public ActionResult CreateCustomer([FromBody] CustomerCreateDto customer)
        {
            int customerId = _customerService.CreateCustomer(customer);
            if (customerId > 0)
            {
                return Created($"api/customer/{customerId}", customerId);
            }

            return BadRequest();
        }

        [HttpPut]
        public ActionResult UpadateCustomer([FromBody] CustomerModifyDto customer)
        {
            var isModified = _customerService.UpadateCustomer(customer);

            if (isModified)
                return Ok();
            return BadRequest();
        }

        [HttpDelete("{customerId}")]
        public ActionResult<CustomerDto> DeleteCustomer([FromRoute] int customerId)
        {
            var isDeleted = _customerService.DeleteCustomer(customerId);

            if (isDeleted)
                return Ok();
            return NoContent();
        }
    }
}



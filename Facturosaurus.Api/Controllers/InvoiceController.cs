using Facturosaurus.Api.Models;
using Facturosaurus.Api.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Facturosaurus.Api.Controllers
{
    [Route("api/invoice")]
    [ApiController]
    [Authorize(Roles = "Użytkownik")]
    public class InvoiceController : ControllerBase
    {
        private readonly IInvoiceService _invoiceService;

        public InvoiceController(IInvoiceService invoiceService)
        {
            _invoiceService = invoiceService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<InvoiceDto>> GetAllInvoices()
        {
            var invoicesDbo = _invoiceService.GetAllInvoices();

            return Ok(invoicesDbo);
        }

        [HttpPost]
        public ActionResult CreateNewInvoice([FromBody] InvoiceCreateDto newInvoice)
        {
            var invoiceId = _invoiceService.CreateNewInvoice(newInvoice);
            if (invoiceId > 0)
                return Created($"api/invoice/{invoiceId}", "");
            return BadRequest();
        }

        [HttpPut]
        public ActionResult modifyInvoice([FromBody] InvoiceDto invoice)
        {
            var invoiceId = _invoiceService.ModifyInvoice(invoice);

            if (invoiceId > 0)
                return Ok();
            return BadRequest();
        }
    }
}

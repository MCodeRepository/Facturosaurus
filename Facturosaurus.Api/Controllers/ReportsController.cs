using Facturosaurus.Api.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Facturosaurus.Api.Controllers
{
    [Route("api/reports")]
    [ApiController]
    [Authorize(Roles = "Użytkownik")]
    public class ReportsController : ControllerBase
    {
        private readonly IReportService _reportService;

        public ReportsController(IReportService reportService)
        {
            _reportService = reportService;
        }

        [HttpGet("notpaidinvoices")]
        public IActionResult NotPaidInvoices()
        {
            try
            {
                var htmlFile = _reportService.GetNotPaidInvoicesReport();
                var byteArray = System.Text.Encoding.UTF8.GetBytes(htmlFile);


                return File(byteArray, "text/html", "file.html");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpGet("customers")]
        public IActionResult DownloadFile()
        {
            try
            {
                var htmlFile = _reportService.GetCustomersReport();
                var byteArray = System.Text.Encoding.UTF8.GetBytes(htmlFile);


                return File(byteArray, "text/html", "file.html");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpGet("customerinvoices/{CustomerId}")]
        public IActionResult CustomerInvoices([FromRoute] int customerId)
        {
            try
            {
                var htmlFile = _reportService.GetCustomerInvoicesReport(customerId);
                var byteArray = System.Text.Encoding.UTF8.GetBytes(htmlFile);


                return File(byteArray, "text/html", "file.html");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }


    }
}

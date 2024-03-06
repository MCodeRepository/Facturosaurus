using AutoMapper;
using Facturosaurus.Api.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace Facturosaurus.Api.Services
{
    public interface IReportService
    {
        string GetNotPaidInvoicesReport();
        string GetCustomersReport();
        string GetCustomerInvoicesReport(int customerId);
    }

    public class ReportService : IReportService
    {
        private readonly FacturosaurusDbContext _dbContext;

        public ReportService(FacturosaurusDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
        }

        public string GetNotPaidInvoicesReport()
        {
            var invoices = _dbContext
            .Invoices
            .Include(c => c.Customer)
            .Where(i => i.Paid == false)
            .ToList();

            var htmlHeader = "<!DOCTYPE html>\r\n<html>\r\n<head>\r\n<style>\r\ntable {\r\n  border-collapse: collapse;\r\n  width: 100%;\r\n}\r\n\r\nth, td {\r\n  padding: 8px;\r\n  text-align: left;\r\n  border-bottom: 1px solid #DDD;\r\n}\r\n\r\ntr:hover {background-color: #D6EEEE;}\r\n</style>\r\n</head>\r\n<body>\r\n\r\n<h2>Raport przeterminowanych płatności faktur</h2>\r\n<p>Lista faktur z odroczonym typem płatności na dzień [0]</p>\r\n\r\n<table>\r\n\r\n  <tr>\r\n    <th>Numer faktury</th>\r\n    <th>Data wystawienia</th>\r\n    <th>Kontahent</th>\r\n    <th>Typ płatności</th>\r\n    <th>Termin płatności</th>\t\r\n  </tr>\r\n  ";
            var htmlItem = "<tr>\r\n    <td>[1]</td>\r\n    <td>[2]</td>\r\n    <td>[3]</td>\r\n    <td>[4]</td>\r\n    <td>[5]</td>\r\n  </tr>\r\n ";
            var htmlFooter = "</table>\r\n\r\n</body>\r\n</html>";

            var htmlItems = "";

            htmlHeader = htmlHeader.Replace("[0]", DateTime.Now.ToShortDateString());

            foreach (var invoice in invoices)
            {
                var item = htmlItem;
                item = item.Replace("[1]", $"{invoice.Number}/{invoice.Month}/{invoice.Year}");
                item = item.Replace("[2]", $"{invoice.CreateDate.ToShortDateString()}");
                item = item.Replace("[3]", $"{invoice.Customer.ShortCustomerName}");
                item = item.Replace("[4]", $"{invoice.PaymentTypeId}");
                item = item.Replace("[5]", $"{invoice.PaymentDate.ToShortDateString()}");

                htmlItems += item;
            }

            return htmlHeader + htmlItems + htmlFooter;
        }


        public string GetCustomersReport()
        {
            var customers = _dbContext
            .Cutomers
            .Include(a => a.Adresses)
            .Include(e => e.EmailAdresses)
            .Include(p => p.Phones)
            .Include(c => c.BankAccounts)
            .ToList();


            var invoicesSum = _dbContext
                .Invoices
                .GroupBy(i => i.CustomerId)
                .Select(group => new { Value = group.Key, sumInvoices = group.Count() });

            var valueInvoicesSum = _dbContext
                .Invoices
                .GroupBy(i => i.CustomerId)
                .Select(group => new { Value = group.Key, amountValueInvoices = group.Sum(i => i.GrossAmount) });

            var dateOdLastInvoice = _dbContext
                .Invoices
                .GroupBy(i => i.CustomerId)
                .Select(group => new { Value = group.Key, lastInvoice = group.Max(i => i.ExecutionDate) });


            var htmlHeader = "<!DOCTYPE html>\r\n<html>\r\n<head>\r\n<style>\r\ntable {\r\n  border: 1px solid black;\r\n  border-radius: 10px;\r\n}\r\n\r\nth, td {\r\n  padding: 8px;\r\n  text-align: left;\r\n  border-bottom: 1px solid #DDD;\r\n}\r\n\r\ntr:hover {background-color: #D6EEEE;}\r\n</style>\r\n</head>\r\n<body>\r\n\r\n<h2>Raport kontrahentów</h2>\r\n<p>Lista kontrahentów wraz ze szczegółami na dzień <B>[0]</B></p>\r\n\r\n";
            var htmlItem = "<table>\r\n  <tr>\r\n    <td>Id</td>\r\n    <td><B>[1]</B></td>\r\n    <td>NIP</td>\r\n    <td><B>[2]</B></td>\r\n    <td>Aktywny</td>\r\n    <td><B>[3]</B></td>\r\n  </tr>\r\n  <tr>\r\n    <td>Pełna nazwa kontrahenta</td>\r\n    <td colspan=\"5\"><B>[4]</B></td>\r\n  </tr>\r\n  <tr>\r\n    <td>Skrócona nazwa kontrahenta</td>\r\n    <td colspan=\"5\"><B>[5]</B></td>\r\n  </tr>\r\n  <tr>\r\n    <td>Adres</td>\r\n    <td colspan=\"5\"><B>[6]</B></td>\r\n  </tr>\r\n  <tr>\r\n    <td>Liczba wystawionych faktur</td>\r\n    <td><B>[7]</B></td>\r\n    <td>Wartość wystawionych faktur</td>\r\n    <td><B>[8]</B></td>\r\n    <td>Data wystawienia ostatniej faktury</td>\r\n    <td><B>[9]</B></td>\r\n  </tr>\r\n</table>\r\n<br>\r\n";
            var htmlFooter = "</body>\r\n</html>";

            var htmlItems = "";

            htmlHeader = htmlHeader.Replace("[0]", DateTime.Now.ToShortDateString());

            foreach (var customer in customers)
            {
                var active = customer.Active ? "Tak" : "Nie";
                var count = invoicesSum.Where(g => g.Value == customer.Id).Select(a => a.sumInvoices).FirstOrDefault();
                var amount = valueInvoicesSum.Where(g => g.Value == customer.Id).Select(a => a.amountValueInvoices).FirstOrDefault();
                var lastInvoice = dateOdLastInvoice.Where(g => g.Value == customer.Id).Select(a => a.lastInvoice).FirstOrDefault();

                var item = htmlItem;
                item = item.Replace("[1]", $"{customer.Id}");
                item = item.Replace("[2]", $"{customer.NipNumber}");
                item = item.Replace("[3]", $"{active}");
                item = item.Replace("[4]", $"{customer.CustomerName}");
                item = item.Replace("[5]", $"{customer.ShortCustomerName}");
                item = item.Replace("[6]", $"{customer.Adresses[0].StreetName} {customer.Adresses[0].BildingNumber}/{customer.Adresses[0].ApartmentNumber}, {customer.Adresses[0].ZipCode} {customer.Adresses[0].City}");
                item = item.Replace("[7]", $"{count}");
                item = item.Replace("[8]", $"{amount}");
                item = item.Replace("[9]", $"{lastInvoice.Date.ToShortDateString()}");

                htmlItems += item;
            }

            return htmlHeader + htmlItems + htmlFooter;
        }

        public string GetCustomerInvoicesReport(int customerId)
        {
            var customer = _dbContext.Cutomers.Where(c => c.Id == customerId).FirstOrDefault();

            var invoices = _dbContext
            .Invoices
            .Where(c => c.CustomerId == customerId)
            .ToList();

            var htmlHeader = "<!DOCTYPE html>\r\n<html>\r\n<head>\r\n<style>\r\ntable {\r\n  border-collapse: collapse;\r\n  width: 100%;\r\n}\r\n\r\nth, td {\r\n  padding: 8px;\r\n  text-align: left;\r\n  border-bottom: 1px solid #DDD;\r\n}\r\n\r\ntr:hover {background-color: #D6EEEE;}\r\n</style>\r\n</head>\r\n<body>\r\n<h2>Raport faktur</h2>\r\n<p>Lista faktur kontrahenta [0] na dzień [1]</p>\r\n<table>\r\n\t<tr>\r\n\t\t<th>Numer faktury</th>\r\n\t\t<th>Data wystawienia</th>\r\n\t\t<th>Wartość netto</th>\r\n\t\t<th>Wartość brutto</th>\r\n\t\t<th>Termin płatności</th>\r\n\t\t<th>Data opłacenia</th>\r\n\t</tr>";
            var htmlItem = "<tr>\r\n\t\t<td>[2]</td>\r\n\t\t<td>[3]</td>\r\n\t\t<td>[4]</td>\r\n\t\t<td>[5]</td>\r\n\t\t<td>[6]</td>\r\n\t\t<td>[7]</td>\r\n\t</tr>";
            var htmlFooter = "</table>\r\n\r\n</body>\r\n</html>";

            var htmlItems = "";

            htmlHeader = htmlHeader.Replace("[0]", $"{customer.CustomerName}");
            htmlHeader = htmlHeader.Replace("[1]", DateTime.Now.ToShortDateString());

            foreach (var invoice in invoices)
            {
                var paidDate = invoice.PaidDate == DateTime.MinValue ? "" : invoice.PaidDate.ToShortDateString();

                var item = htmlItem;
                item = item.Replace("[2]", $"{invoice.Number}/{invoice.Month}/{invoice.Year}");
                item = item.Replace("[3]", $"{invoice.CreateDate.ToShortDateString()}");
                item = item.Replace("[4]", $"{invoice.NetAmount}");
                item = item.Replace("[5]", $"{invoice.GrossAmount}");
                item = item.Replace("[6]", $"{invoice.PaymentDate.ToShortDateString()}");
                item = item.Replace("[7]", $"{paidDate}");

                htmlItems += item;
            }

            return htmlHeader + htmlItems + htmlFooter;
        }
    }
}

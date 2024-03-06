using AutoMapper;
using Facturosaurus.Api.Entities;
using Facturosaurus.Api.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Facturosaurus.Api.Services
{
    public interface IInvoiceService
    {
        int CreateNewInvoice(InvoiceCreateDto newInvoice);
        IEnumerable<InvoiceDto> GetAllInvoices();
        int ModifyInvoice(InvoiceDto invoice);
    }

    public class InvoiceService : IInvoiceService
    {
        private readonly FacturosaurusDbContext _dbContext;
        private readonly IMapper _mapper;

        public InvoiceService(FacturosaurusDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public IEnumerable<InvoiceDto> GetAllInvoices()
        {
            var invoices = _dbContext
            .Invoices
            .Include(i => i.CompanyDetails)
            .Include(c => c.Customer)
            .Include(p => p.Items)
            .Include(u => u.User)
            .ToList();

            var invoicesDto = new List<InvoiceDto>();

            foreach (var invoice in invoices)
            {
                var invoiceDto = _mapper.Map<InvoiceDto>(invoice);
                invoiceDto.Items = _mapper.Map<List<InvoiceItemDto>>(invoice.Items);
                invoicesDto.Add(invoiceDto);
            }

            return invoicesDto;
        }

        public int CreateNewInvoice(InvoiceCreateDto newInvoice)
        {
            var invoice = _mapper.Map<Invoice>(newInvoice);

            invoice.CreateDate = DateTime.Now.Date;
            invoice.Number = GetLastNumberOfInvoice(invoice);

            //foreach (InvoiceItemDto item in newInvoice.Items)
            //{
            //    var newItem = _mapper.Map<InvoiceItems>(item);
            //    invoice.Items.Add(newItem);
            //};

            _dbContext.Invoices.Add(invoice);
            _dbContext.SaveChanges();

            return invoice.Id;
        }


        public int ModifyInvoice(InvoiceDto invoice)
        {

            var invoiceToModify = _dbContext.Invoices.Where(x => x.Id == invoice.Id).FirstOrDefault();
            var itemsToDelete = _dbContext.InvoiceItems.Where(x => x.InvoiceId == invoice.Id).ToList();

            if (invoiceToModify != null)
            {
                invoiceToModify.PaymentTypeId = invoice.PaymentTypeId;
                invoiceToModify.PaymentDate = invoice.PaymentDate;
                invoiceToModify.CustomerId = invoice.CustomerId;
                invoiceToModify.CustomerName = invoice.CustomerName;
                invoiceToModify.CustomerNipNumber = invoice.CustomerNipNumber;
                invoiceToModify.CustomerStreetName = invoice.CustomerStreetName;
                invoiceToModify.CustomerBildingNumber = invoice.CustomerBildingNumber;
                invoiceToModify.CustomerApartmentNumber = invoice.CustomerApartmentNumber;
                invoiceToModify.CustomerZipCode = invoice.CustomerZipCode;
                invoiceToModify.CustomerCity = invoice.CustomerCity;
                invoiceToModify.NetAmount = invoice.NetAmount;
                invoiceToModify.GrossAmount = invoice.GrossAmount;
                invoiceToModify.VatAmount = invoice.VatAmount;
                invoiceToModify.Paid = invoice.Paid;
                invoiceToModify.PaidDate = invoice.PaidDate;

                if (itemsToDelete != null)
                    _dbContext.InvoiceItems.RemoveRange(itemsToDelete);
                invoiceToModify.Items.RemoveAll(x => x.InvoiceId == invoice.Id);

                foreach (InvoiceItemDto item in invoice.Items)
                {
                    var newItem = _mapper.Map<InvoiceItems>(item);
                    invoiceToModify.Items.Add(newItem);
                };

                _dbContext.Invoices.Update(invoiceToModify);
                _dbContext.SaveChanges();

                return invoiceToModify.Id;
            }
            return 0;
        }


        private int GetLastNumberOfInvoice(Invoice newInvoice)
        {

            var invoices = _dbContext.Invoices.Where(i => i.Type == newInvoice.Type).ToList();

            var number = (from invoice in invoices
                          where invoice.Year == newInvoice.Year && invoice.Month == newInvoice.Month
                          orderby invoice.Number descending
                          select invoice.Number).FirstOrDefault() + 1;

            return number;
        }
    }
}


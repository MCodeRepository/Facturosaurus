using Facturosaurus.Forms.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;

namespace Facturosaurus.Forms.Api.Services
{
    internal class InvoiceService
    {
        private readonly HttpClient _httpClient;

        public InvoiceService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public Result<List<InvoiceDto>> GetInvoicesList()
        {
            if (_httpClient.BaseAddress != null)
            {
                List<InvoiceDto> invoicesList;
                try
                {
                    HttpResponseMessage response = _httpClient.GetAsync("/api/invoice").Result;
                    invoicesList = response.Content.ReadAsAsync<List<InvoiceDto>>().Result;

                    return new Result<List<InvoiceDto>> { Value = invoicesList, Status = (int)response.StatusCode };
                }
                catch (Exception)
                {
                    return new Result<List<InvoiceDto>> { Status = 1300 };
                }
            }
            else
            {
                return new Result<List<InvoiceDto>> { Status = 1001 };
            }
        }

        public Result<bool> CreateNewInvoice(InvoiceCreateDto invoiceDto)
        {
            if (_httpClient.BaseAddress != null)
            {
                if (invoiceDto != null)
                {
                    try
                    {
                        var response = _httpClient.PostAsJsonAsync<InvoiceCreateDto>("api/invoice", invoiceDto).Result;

                        return new Result<bool> { Value = true, Status = (int)response.StatusCode };
                    }
                    catch (Exception)
                    {
                        return new Result<bool> { Status = 1301 };
                    }
                }
                else
                    return new Result<bool> { Status = 1302 };

            }
            else
                return new Result<bool> { Status = 1001 };
        }


        internal Result<bool> ModifyInvoice(InvoiceDto invoiceDto)
        {
            if (_httpClient.BaseAddress != null)
            {
                if (invoiceDto != null)
                {
                    try
                    {
                        var response = _httpClient.PutAsJsonAsync<InvoiceDto>("api/invoice", invoiceDto).Result;

                        if (response.StatusCode != System.Net.HttpStatusCode.OK)
                            return new Result<bool> { Value = false, Status = (int)response.StatusCode };
                        return new Result<bool> { Value = true, Status = (int)response.StatusCode };

                    }
                    catch (Exception)
                    {
                        return new Result<bool>() { Status = 1303 };
                    }
                }
                else
                    return new Result<bool>() { Status = 1304 };
            }
            else
                return new Result<bool>() { Status = 1101 };
        }
    }
}

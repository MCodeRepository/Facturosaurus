using Facturosaurus.Forms.Models;
using Facturosaurus.Forms.SubbClases;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;

namespace Facturosaurus.Forms.Api.Services
{
    internal class CustomerService
    {
        private readonly HttpClient _httpClient;

        public CustomerService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public Result<List<CustomerDto>> GetCustomersList()
        {
            if (_httpClient.BaseAddress != null)
            {
                List<CustomerDto> customersList;
                try
                {
                    HttpResponseMessage response = _httpClient.GetAsync("/api/customers").Result;
                    customersList = response.Content.ReadAsAsync<List<CustomerDto>>().Result;

                    return new Result<List<CustomerDto>> { Value = customersList, Status = (int)response.StatusCode };
                }
                catch (Exception)
                {
                    return new Result<List<CustomerDto>> { Status = 1400 };
                }
            }
            else
                return new Result<List<CustomerDto>> { Status = 1001 };
        }

        public Result<bool> CreateNewCustomer(CustomerCreateDto customer)
        {
            if (_httpClient.BaseAddress != null)
            {
                if (customer != null)
                {
                    try
                    {
                        var response = _httpClient.PostAsJsonAsync<CustomerCreateDto>("/api/customers", customer).Result;


                        if (response.StatusCode == HttpStatusCode.Created)
                            return new Result<bool> { Value = true, Status = (int)response.StatusCode };

                        var responseBody = response.Content.ReadFromJsonAsync<ErrorResponse>().Result;
                        var errors = Errors(responseBody);

                        return new Result<bool> { Status = (int)response.StatusCode, Info = errors };
                    }
                    catch (Exception)
                    {
                        return new Result<bool> { Status = 1402 };
                    }
                }
                else
                    return new Result<bool> { Status = 1403 };

            }
            else
                return new Result<bool> { Status = 1001 };
        }

        private string Errors(ErrorResponse errors)
        {
            string errorsList = "";

            foreach (var error in errors.Errors)
            {
                errorsList = errorsList + error.Value[0] + Environment.NewLine;
            }
            return errorsList;
        }

        public Result<bool> ModifyCustomer(CustomerModifyDto customer)
        {
            if (_httpClient.BaseAddress != null)
            {
                if (customer != null)
                {
                    try
                    {
                        var request = _httpClient.PutAsJsonAsync<CustomerModifyDto>($"/api/customers", customer).Result;

                        if (request.StatusCode == HttpStatusCode.OK)
                            return new Result<bool> { Value = true, Status = (int)request.StatusCode };
                        return new Result<bool> { Value = false, Status = (int)request.StatusCode };
                    }
                    catch (Exception)
                    {
                        return new Result<bool> { Value = true, Status = 1404 };
                    }
                }
                else
                    return new Result<bool> { Status = 1405 };
            }
            else
                return new Result<bool> { Status = 1001 };
        }

        public Result<bool> DeleteCustomer(int customerId)
        {
            if (_httpClient.BaseAddress != null)
            {
                if (customerId > 0)
                {
                    try
                    {
                        var request = _httpClient.DeleteAsync($"/api/customers/{customerId}").Result;

                        if (request.StatusCode == HttpStatusCode.OK)
                            return new Result<bool> { Value = true, Status = (int)request.StatusCode };
                        return new Result<bool> { Value = false, Status = 1406 };
                    }
                    catch (Exception)
                    {
                        return new Result<bool> { Value = false, Status = 1406 };
                    }
                }
                else
                    return new Result<bool> { Value = false, Status = 1407 };
            }
            else
                return new Result<bool> { Status = 1001 };
        }
    }
}

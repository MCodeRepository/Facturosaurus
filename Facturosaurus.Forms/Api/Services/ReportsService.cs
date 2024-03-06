using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facturosaurus.Forms.Api.Services
{
    internal class ReportsService
    {
        private readonly HttpClient _httpClient;


        public ReportsService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task GetNotPaidInvoicesReport()
        {
            if (_httpClient.BaseAddress != null)
            {
                try
                {
                    using (var response = _httpClient.GetAsync("api/reports/notpaidinvoices").Result)
                    {
                        if (response.IsSuccessStatusCode)
                        {
                            var content = await response.Content.ReadAsByteArrayAsync();
                            File.WriteAllBytes("Faktury_przeterminowane.html", content);
                        }
                        else
                        {
                            MessageBox.Show($"Błąd: {response.StatusCode} - {response.ReasonPhrase}");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex.Message}");
                }
            }
        }

        public async Task GetCustomerReport()
        {
            if (_httpClient.BaseAddress != null)
            {
                try
                {
                    using (var response = _httpClient.GetAsync("api/reports/customers").Result)
                    {
                        if (response.IsSuccessStatusCode)
                        {
                            var content = await response.Content.ReadAsByteArrayAsync();
                            File.WriteAllBytes("Raport_kontrahentow.html", content);
                        }
                        else
                        {
                            MessageBox.Show($"Błąd: {response.StatusCode} - {response.ReasonPhrase}");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex.Message}");
                }
            }
        }

        public async Task GetCustomerInvoicesReport(int CustomerId)
        {
            if (_httpClient.BaseAddress != null)
            {
                try
                {
                    using (var response = _httpClient.GetAsync($"api/reports/customerinvoices/{CustomerId}").Result)
                    {
                        if (response.IsSuccessStatusCode)
                        {
                            var content = await response.Content.ReadAsByteArrayAsync();
                            File.WriteAllBytes("Raport_faktur_kontrahenta.html", content);
                        }
                        else
                        {
                            MessageBox.Show($"Błąd: {response.StatusCode} - {response.ReasonPhrase}");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex.Message}");
                }
            }
        }
    }
}

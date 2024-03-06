using Facturosaurus.Forms.api;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace Facturosaurus.Forms.Forms.Reports
{
    public partial class Reports : Form
    {
        public List<Report> ReportsList { get; set; }
        FacturosaurusApi api;

        public Reports()
        {
            InitializeComponent();

            ReportsList = new List<Report>()
            {
                new Report() {Code=1, Name="Raport przeterminowanych faktur", FileName="Faktury_przeterminowane.html"},
                new Report() {Code=2, Name="Raport kontrahentów", FileName="Raport_kontrahentow.html"},
                new Report() {Code=3, Name="Raport faktur danego kontrahenta", FileName="Raport_faktur_kontrahenta.html"}
            };

            checkReports();

            api = new FacturosaurusApi();
        }

        private void Reports_Load(object sender, EventArgs e)
        {
            reportBindingSource.DataSource = ReportsList;
        }

        private void checkReports()
        {
            try
            {
                var listOfFiles = Directory.GetFiles(System.IO.Directory.GetCurrentDirectory());

                foreach (var file in listOfFiles)
                {
                    FileInfo fileInfo = new FileInfo(file);
                    var creationDate = fileInfo.LastWriteTime;

                    switch (fileInfo.Name)
                    {
                        case "Faktury_przeterminowane.html":
                            ReportsList[0].CreatedDate = creationDate;
                            break;
                        case "Raport_kontrahentow.html":
                            ReportsList[1].CreatedDate = creationDate;
                            break;
                        case "Raport_faktur_kontrahenta.html":
                            ReportsList[2].CreatedDate = creationDate;
                            break;
                        default:
                            break;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Błąd sprawdzania raportów.");
            }
        }

        private async void dgvInvoicesList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvReportsList.Columns[e.ColumnIndex].Name == "btnExecute")
            {


                var selectedReport = dgvReportsList.SelectedRows[0].DataBoundItem as Report;
                if (selectedReport != null)
                {
                    switch (selectedReport.Code)
                    {
                        case 1:
                            await api.GetReportNotPaidInvoices();
                            break;
                        case 2:
                            await api.GetCustomerReport();
                            break;
                        case 3:
                            MessageBox.Show("Proszę wybrać kontrakenta do raportu");
                            using (var form = new Customers())
                            {
                                var result = form.ShowDialog();
                                if (result == DialogResult.OK)
                                {
                                    if (form.SelectedCustomer != null)
                                        await api.GetCustomerInvoicesReport(form.SelectedCustomer.Id);
                                }
                            }
                            break;
                        default:
                            break;
                    }
                }
                checkReports();
            }

            if (dgvReportsList.Columns[e.ColumnIndex].Name == "btnOpen")
            {
                var selectedReport = dgvReportsList.SelectedRows[0].DataBoundItem as Report;
                if (selectedReport != null)
                {

                    switch (selectedReport.Code)
                    {
                        case 1:
                            OpenFileWithDefaultProgram("Faktury_przeterminowane.html");
                            break;
                        case 2:
                            OpenFileWithDefaultProgram("Raport_kontrahentow.html");
                            break;
                        case 3:
                            OpenFileWithDefaultProgram("Raport_faktur_kontrahenta.html");
                            break;
                        default:
                            break;
                    }
                }
            }
        }

        static void OpenFileWithDefaultProgram(string filePath)
        {
            try
            {
                if (File.Exists(filePath))
                {
                    ProcessStartInfo startInfo = new ProcessStartInfo(filePath);
                    Process.Start(startInfo);
                }
                else
                {
                    MessageBox.Show("Plik raportu nie istnieje.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd: {ex.Message}");
            }
        }
    }
}

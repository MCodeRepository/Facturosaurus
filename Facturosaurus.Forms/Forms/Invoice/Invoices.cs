using Facturosaurus.Forms.api;
using Facturosaurus.Forms.Lists;
using Facturosaurus.Forms.Printing;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;


namespace Facturosaurus.Forms
{
    public partial class Invoices : Form
    {
        FacturosaurusApi api;
        BindingSource bindingSource1;
        List<InvoiceDto> invoices;

        public Invoices()
        {
            InitializeComponent();
            api = new FacturosaurusApi();
            bindingSource1 = new BindingSource();

            txtYearFilter.Text=DateTime.Now.Year.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Invoices_Load(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void RefreshList()
        {
            //W przyszłości filtrowanie na fazie zapytania
            var returnAllType = string.IsNullOrEmpty(cbxInvoiceTypeFilter.SelectedText.Trim());
            var returnAllNo = string.IsNullOrEmpty(txtNumberFilter.Text.Trim());
            var returnAllMonth = string.IsNullOrEmpty(txtMonthFilter.Text.Trim());
            var returnAllYear = string.IsNullOrEmpty(txtYearFilter.Text.Trim());
            var returnAllCustomerId = string.IsNullOrEmpty(txtCustomerIdFilter.Text.Trim());
            var returnAllNotPaid = !chbOnlyActive.Checked;

            var typeOfInvoiceFilder = 0;

            switch (cbxInvoiceTypeFilter.SelectedIndex)
            {
                case 1:
                    typeOfInvoiceFilder = 1;
                    break;
                case 2:
                    typeOfInvoiceFilder = 4;
                    break;
                default:
                    typeOfInvoiceFilder = 0;
                    break;
            }


            invoices = api.GetInvoicesList();

            if (invoices != null)
            {
                var invoicesrAfterFilters = from i in invoices
                                            where (returnAllType || (i.Type == typeOfInvoiceFilder)) &&
                                             (returnAllNo || i.Number == Int32.Parse(txtNumberFilter.Text.ToString())) &&
                                             (returnAllMonth || i.Month == Int32.Parse(txtMonthFilter.Text.ToString())) &&
                                             (returnAllYear || i.Year == Int32.Parse(txtYearFilter.Text.ToString())) &&
                                             (returnAllCustomerId || i.CustomerId == Int32.Parse(txtCustomerIdFilter.Text.ToString())) &&
                                             (returnAllNotPaid || (i.Paid == false))

                                            select new InvoicesList()
                                            {
                                                Id = i.Id,
                                                InvoiceTypes = i.Type == 1 ? "FV" : "FK",
                                                WholeNumber = $"{i.Number}/{i.Month}/{i.Year}",
                                                CreateDate = i.CreateDate,
                                                ShortCompanyName = i.CustomerName,
                                                NetAmount = i.NetAmount,
                                                GrossAmount = i.GrossAmount,
                                                PaymentDate = i.PaymentDate,
                                                PaidDate = i.PaidDate,
                                                Paid = i.Paid

                                            };

                //bindingSource1.DataSource = null;
                bindingSource1.DataSource = invoicesrAfterFilters;
                dgvInvoicesList.DataSource = bindingSource1;
            }
        }


        private void btnEdit_Click(object sender, EventArgs e)
        {


            if (dgvInvoicesList.Rows.Count > 0)
            {
                var selectedInvoice = dgvInvoicesList.SelectedRows[0].DataBoundItem as InvoicesList;
                var invoiceDto = invoices.Where(i => i.Id == selectedInvoice.Id).FirstOrDefault();

                if (invoiceDto != null)
                {
                    using (var form = new InvoiceDetails(invoiceDto))
                    {
                        var result = form.ShowDialog();
                        if (result == DialogResult.OK)
                        {
                            RefreshList();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Proszę wybrać fakturę.");
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            cbxInvoiceTypeFilter.SelectedIndex = -1;
            txtNumberFilter.Text = "";
            txtMonthFilter.Text = "";
            txtYearFilter.Text = "";
            txtCustomerIdFilter.Text = "";
            chbOnlyActive.Checked = false;

            RefreshList();
        }

        private void txtCustomerIdFilter_DoubleClick(object sender, EventArgs e)
        {
            using (var form = new Customers())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    txtCustomerIdFilter.Text = form.SelectedCustomerId.ToString();
                    txtCustomerNameFilter.Text = form.SelectedCustomerName.ToString();
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CompanyDetailsDto companyDetails = api.GetCurrentCompanyDetails();
            if (companyDetails != null)
            {
                using (var form = new InvoiceDetails())
                {
                    var result = form.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        RefreshList();
                    }
                }
            }
            else
            {
                MessageBox.Show("Brak wypełnionych danych firmy. Tworzenie faktur niemożliwe.");
            }


        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (dgvInvoicesList.Rows.Count > 0)
            {
                var selectedInvoice = dgvInvoicesList.SelectedRows[0].DataBoundItem as InvoicesList;
                var invoiceDto = invoices.Where(i => i.Id == selectedInvoice.Id).FirstOrDefault();

                if (invoiceDto != null)
                {
                    InvoicePrinting invoicePrinting = new InvoicePrinting(invoiceDto);
                    invoicePrinting.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Proszę wybrać fakturę.");
                }
            }
        }
    }
}

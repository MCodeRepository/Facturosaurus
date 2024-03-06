using Facturosaurus.Forms.api;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Facturosaurus.Forms
{
    public partial class Customers : Form
    {
        FacturosaurusApi api;
        List<CustomerDto> customers;

        public int SelectedCustomerId { get; set; }
        public string SelectedCustomerName { get; set; }

        public CustomerDto SelectedCustomer { get; set; }


        public Customers()
        {
            InitializeComponent();
            api = new FacturosaurusApi();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Customers_Load(object sender, EventArgs e)
        {
            try
            {
                customers = api.GetCustomersList();
                LoadCustomerList(txtContrahentFilter.Text, txtNipFilter.Text, chbOnlyActiveFilter.Checked);
                RefreshCustomerDetails();
            }
            catch { }
        }

        private void dgvCustomersList_SelectionChanged(object sender, EventArgs e)
        {
            RefreshCustomerDetails();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadCustomerList(txtContrahentFilter.Text, txtNipFilter.Text, chbOnlyActiveFilter.Checked);

            RefreshCustomerDetails();
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            txtContrahentFilter.Text = "";
            txtNipFilter.Text = "";
            chbOnlyActiveFilter.Checked = false;

            LoadCustomerList(txtContrahentFilter.Text, txtNipFilter.Text, chbOnlyActiveFilter.Checked);

            RefreshCustomerDetails();
        }


        private void LoadCustomerList(string customerName, string customerNip, bool customerActive)
        {


            var returnAllName = string.IsNullOrEmpty(customerName.Trim());
            var returnAllNip = string.IsNullOrEmpty(customerNip.Trim());
            var returnAllOnlyActive = !chbOnlyActiveFilter.Checked;

            //var customerAfterFilters = customers.Where(c => c.CustomerName.ToUpper().Contains(customerName.ToUpper()));
            var customerAfterFilters = from c in customers
                                       where (returnAllName || c.CustomerName.ToUpper().Contains(customerName.ToUpper().Trim()))
                                       && (returnAllNip || c.NipNumber.ToUpper().Contains(customerNip.ToUpper().Trim()))
                                       && (returnAllOnlyActive || c.Active == true)
                                       select c;

            dgvCustomersList.Rows.Clear();

            if (customerAfterFilters != null)
            {
                foreach (CustomerDto customer in customerAfterFilters)
                {
                    dgvCustomersList.Rows.Add(customer.Id, customer.ShortCustomerName, customer.NipNumber, customer.Active);
                }
            }
        }


        private void RefreshCustomerDetails()
        {
            if (dgvCustomersList.Rows.Count > 0)
            {
                int rowindex = dgvCustomersList.CurrentCell.RowIndex;

                var customerId = dgvCustomersList.Rows[rowindex].Cells["ID"].Value.ToString();

                if (customerId != "")
                {
                    CustomerDto customer = customers.Where(c => c.Id.Equals(Int16.Parse(customerId))).FirstOrDefault();

                    if (customer != null)
                    {
                        labAddress.Text = $"ul. {customer.StreetName} {customer.BildingNumber}/{customer.ApartmentNumber} {customer.ZipCode} {customer.City.ToUpper()}";
                        labBankName.Text = $"{customer.BankName}";

                        string currency = customer.AccountCurrency == 0 && customer.AccountNumber != "" ? "PLN" : "";

                        labBankAccount.Text = $"{currency} {customer.AccountNumber}";
                        labMail.Text = $"{customer.AddressEmail}";
                        labPhone.Text = $"{customer.PhoneNumber}";
                    }
                }
            }
            else
            {
                labAddress.Text = "";
                labBankName.Text = "";
                labBankAccount.Text = "";
                labMail.Text = "";
                labPhone.Text = "";
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvCustomersList.Rows.Count > 0)
            {
                int rowindex = dgvCustomersList.CurrentCell.RowIndex;
                var customerId = dgvCustomersList.Rows[rowindex].Cells["ID"].Value.ToString();

                CustomerDto customer = customers.Where(c => c.Id.Equals(Int16.Parse(customerId))).FirstOrDefault();
                if (customer != null)
                {
                    frmCustomerDetails customerDetails = new frmCustomerDetails(customer, this);
                    customerDetails.Show();
                }
                else
                {
                    MessageBox.Show("Proszę wybrać kontrahenta.");
                }

                LoadCustomerList(txtContrahentFilter.Text, txtNipFilter.Text, chbOnlyActiveFilter.Checked);
                RefreshCustomerDetails();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            frmCustomerDetails frmCustomerDetails = new frmCustomerDetails(this);
            frmCustomerDetails.Show();
        }

        public void ReLoadList()
        {
            customers = api.GetCustomersList();
            LoadCustomerList(txtContrahentFilter.Text, txtNipFilter.Text, chbOnlyActiveFilter.Checked);
            RefreshCustomerDetails();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int rowindex = dgvCustomersList.CurrentCell.RowIndex;
            var customerId = dgvCustomersList.Rows[rowindex].Cells["ID"].Value.ToString();
            var customerName = dgvCustomersList.Rows[rowindex].Cells["CustomerName"].Value.ToString();

            DialogResult dialogResult = MessageBox.Show($"Usunąć kontrahenta {customerName}?", "Potwierdź operację", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                api.DeleteCustomer(Int32.Parse(customerId));
                //LoadCustomerList(txtContrahentFilter.Text, txtNipFilter.Text, chbOnlyActiveFilter.Checked);
                //RefreshCustomerDetails();
                ReLoadList();
            }

        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            int rowindex = dgvCustomersList.CurrentCell.RowIndex;
            SelectedCustomerId = Int16.Parse(dgvCustomersList.Rows[rowindex].Cells["ID"].Value.ToString());
            SelectedCustomerName = dgvCustomersList.Rows[rowindex].Cells["CustomerName"].Value.ToString();

            SelectedCustomer = customers.Where(c => c.Id == SelectedCustomerId).FirstOrDefault();

            this.DialogResult = DialogResult.OK;
            Close();
        }
    }
}

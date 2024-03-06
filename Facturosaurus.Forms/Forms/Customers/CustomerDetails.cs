using Facturosaurus.Forms.api;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Facturosaurus.Forms
{
    public partial class frmCustomerDetails : Form
    {

        FacturosaurusApi api;
        Customers frmCustomers;
        List<String> errors = new List<String>();
        CustomerDto customer;

        public frmCustomerDetails(CustomerDto customerDto, Customers frmCustomers)
        {
            InitializeComponent();
            customer = customerDto;
            api = new FacturosaurusApi();
            this.frmCustomers = frmCustomers;
        }
        public frmCustomerDetails(Customers frmCustomers)
        {
            InitializeComponent();
            api = new FacturosaurusApi();
            this.frmCustomers = frmCustomers;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmCustomerDetails_Load(object sender, EventArgs e)
        {
            if (customer != null)
            {
                this.Text = "Edycja kontrahenta";
                txtNipNumber.Enabled = false;

                txtCustomerId.Text = customer.Id.ToString();
                txtCreateDate.Text = customer.CreateDate.ToString("MMMM dd, yyyy");
                chbActive.Checked = customer.Active;
                txtCustomerName.Text = customer.CustomerName;
                txtShortCustomerName.Text = customer.ShortCustomerName;
                txtNipNumber.Text = customer.NipNumber;
                txtStreetName.Text = customer.StreetName;
                txtBildingNumber.Text = customer.BildingNumber;
                txtApartmentNumber.Text = customer.ApartmentNumber;
                txtZipCode.Text = customer.ZipCode;
                txtCity.Text = customer.City;
                txtBankName.Text = customer.BankName;
                cbxAccountCurrency.SelectedIndex = customer.AccountCurrency;
                txtAccountNumber.Text = customer.AccountNumber;
                txtAddressEmail.Text = customer.AddressEmail;
                txtPhoneNumber.Text = customer.PhoneNumber;
            }
            else
            {
                this.Text = "Tworzenie nowego kontrahenta";
                txtNipNumber.Enabled = true;
            }

            inicializeControlsValidate();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var currency = cbxAccountCurrency.SelectedIndex >= 0 ? cbxAccountCurrency.SelectedIndex : 0;

            if (customer == null)
            {
                bool savedOK = api.CreateNewCustomer(txtShortCustomerName.Text, txtCustomerName.Text, txtNipNumber.Text,
                txtStreetName.Text, txtBildingNumber.Text, txtApartmentNumber.Text, txtZipCode.Text, txtCity.Text, txtBankName.Text,
                currency, txtAccountNumber.Text, txtPhoneNumber.Text, txtAddressEmail.Text, chbActive.Checked);

                if (savedOK)
                {
                    frmCustomers.ReLoadList();
                    Close();
                }
            }
            else
            {
                bool savedOK = api.ModifyCustomer(Int32.Parse(txtCustomerId.Text), txtShortCustomerName.Text, txtCustomerName.Text, txtNipNumber.Text,
                txtStreetName.Text, txtBildingNumber.Text, txtApartmentNumber.Text, txtZipCode.Text, txtCity.Text, txtBankName.Text,
                currency, txtAccountNumber.Text, txtPhoneNumber.Text, txtAddressEmail.Text, chbActive.Checked);

                if (savedOK)
                {
                    frmCustomers.ReLoadList();
                    Close();
                }
            }
        }

        private void txtControlsValidate_TextChanged(object sender, EventArgs e)
        {
            checkValueFromTextBox<TextBoxBase>((TextBoxBase)sender);
        }

        private void inicializeControlsValidate()
        {
            foreach (Control control in this.Controls)
            {
                if (control.GetType() == typeof(TextBoxBase))
                {
                    checkValueFromTextBox((TextBoxBase)control);
                }
            }
        }

        private void checkValueFromTextBox<T>(T control) where T : TextBoxBase
        {
            bool notValid = false;

            switch (control.Name)
            {
                case "txtCustomerName":
                case "txtShortCustomerName":
                case "txtStreetName":
                case "txtBildingNumber":
                case "txtCity":
                case "txtBankName":
                case "txtCurrency":
                    notValid = control.Text == "";
                    break;
                case "txtNipNumber":
                    notValid = control.Text == "" || !Regex.IsMatch(control.Text, @"^[0-9]{10}$");
                    break;
                case "txtZipCode":
                    notValid = !Regex.IsMatch(control.Text, @"^[0-9]{2}-[0-9]{3}$");
                    break;
                case "txtAccountNumber":
                    notValid = control.Text == "" && !Regex.IsMatch(control.Text, @"^\d{26}$");
                    break;
                case "txtPhoneNumber":
                    notValid = control.Text != "" && !Regex.IsMatch(control.Text, @"^\+(?:[0-9]•?){6,14}[0-9]$");
                    break;
                case "txtAddressEmail":
                    notValid = control.Text != "" && !Regex.IsMatch(control.Text, @"^[a-z\d]+[\w\d.-]*@(?:[a-z\d]+[a-z\d-]+\.){1,5}[a-z]{2,6}$");
                    break;
                default:
                    notValid = false;
                    break;

                    //cbxAccountCurrency.SelectedIndex = customer.AccountCurrency; obsługa comboboxa
            }

            if (notValid)
            {
                control.BackColor = Color.Gainsboro;
                errors.Add(control.Name);
            }
            else
            {
                control.BackColor = SystemColors.Window;
                errors.Remove(control.Name);

            }
        }
    }
}

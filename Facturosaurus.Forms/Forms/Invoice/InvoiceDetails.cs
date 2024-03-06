using Facturosaurus.Forms.api;
using Facturosaurus.Forms.Forms.Invoice;
using System;
using System.Windows.Forms;

namespace Facturosaurus.Forms
{
    public partial class InvoiceDetails : Form
    {
        Invoice invoice;
        InvoiceItem invoiceItem;
        FacturosaurusApi api;
        BindingSource invoiceItemsBS;
        CompanyDetailsDto companyDetailsDto;


        public InvoiceDetails()
        {
            InitializeComponent();
            inicializeComboBoxes();
            api = new FacturosaurusApi();
            companyDetailsDto = api.GetCurrentCompanyDetails();
            invoice = new Invoice(companyDetailsDto);
            invoiceItem = new InvoiceItem();
            invoiceItemsBS = new BindingSource();
        }

        public InvoiceDetails(InvoiceDto invoiceDto)
        {
            InitializeComponent();
            inicializeComboBoxes();
            api = new FacturosaurusApi();
            invoice = new Invoice(invoiceDto);
            invoiceItem = new InvoiceItem();
            invoiceItemsBS = new BindingSource();
        }

        //######################################## OTHER EVENTS #########################################################
        #region OtherEvents


        private void InvoiceDetails_Load(object sender, EventArgs e)
        {
            loadInvoice(invoice);
        }

        private void cbxPaymentType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (invoiceItem != null)
            {
                invoice.setPaymentType((PaymentType)cbxPaymentType.SelectedItem);
                loadInvoice(invoice);
            }
        }




        ////////////////////////////////////////////////////////////////////////////// Function for editing item
        private void txtEditItemUnitPrice_Leave(object sender, EventArgs e)
        {
            Decimal unitPrice;

            if (Decimal.TryParse(txtEditItemUnitPrice.Text, out unitPrice))
            {
                invoiceItem.setUnitPrice(unitPrice);
                loadItemToEdit(invoiceItem);
            }
            else
            {
                MessageBox.Show("Niepoprawna wartość!");
                invoiceItem.setQuantity(0);
            }
        }

        private void txtEditItemQuantity_Leave(object sender, EventArgs e)
        {
            int quantity;
            if (Int32.TryParse(txtEditItemQuantity.Text, out quantity))
            {
                invoiceItem.setQuantity(quantity);
                loadItemToEdit(invoiceItem);
            }
            else
            {
                MessageBox.Show("Niepoprawna wartość!");
                invoiceItem.setQuantity(0);
            }
        }

        private void cbxEditItemVatRate_SelectedValueChanged(object sender, EventArgs e)
        {
            if (invoiceItem != null)
            {
                invoiceItem.setVatRate((Vat)cbxEditItemVatRate.SelectedItem);
                loadItemToEdit(invoiceItem);
            }
        }

        private void loadItemDetailsToEditTextBoxes()
        {
            if (dgvItemsList.Rows.Count > 0)
            {
                //int rowindex = dgvItemsList.CurrentCell.RowIndex;
                //var itemOrderNumber = dgvItemsList.Rows[rowindex].Cells["orderNumberDataGridViewTextBoxColumn"].Value.ToString();

                //invoiceItem = invoice.Items.Where(c => c.OrderNumber.Equals(Int16.Parse(itemOrderNumber))).FirstOrDefault();

                invoiceItem = dgvItemsList.SelectedRows[0].DataBoundItem as InvoiceItem;
                loadItemToEdit(invoiceItem);
            }
        }

        #endregion
        //######################################## EVENTS IN BUTTONS ####################################################
        #region EventsInButtons
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (invoice.Id == 0)
            {
                var invoiceDto = invoice.GetInvoiceCreateDto();
                api.CreateNewInvoice(invoiceDto);
            }
            else
            {
                var invoiceDto = invoice.GetInvoiceDto();
                api.ModifyInvoice(invoiceDto);
            }

            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void btnDeletePosition_Click(object sender, EventArgs e)
        {
            var selectedInvoiceItem = dgvItemsList.SelectedRows[0].DataBoundItem as InvoiceItem;

            if (selectedInvoiceItem != null)
            {
                invoice.deleteItem(selectedInvoiceItem);
                invoiceItemsBS.DataSource = null;
                invoiceItemsBS.DataSource = invoice.Items;
                dgvItemsList.DataSource = invoiceItemsBS;
                loadInvoice(invoice);
            }
            else
            {
                MessageBox.Show("Proszę wybrać pozycję.");
            }

        }

        private void btnEditItem_Click(object sender, EventArgs e)
        {
            loadItemDetailsToEditTextBoxes();
            gbModifyItem.Visible = true;
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            clearEditItemTextBoxes();
            gbModifyItem.Visible = true;
        }

        private void btnEditClose_Click(object sender, EventArgs e)
        {
            clearEditItemTextBoxes();
            gbModifyItem.Visible = false;
        }

        private void btnEditSave_Click(object sender, EventArgs e)
        {
            // kontrola 

            invoice.addInvoiceItem(invoiceItem);
            loadInvoice(invoice);

            dgvItemsList.DataSource = null;
            dgvItemsList.DataSource = invoice.Items;

            clearEditItemTextBoxes();

        }

        private void btnChooseCustomer_Click(object sender, EventArgs e)
        {
            using (var form = new Customers())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    invoice.setCustomer(form.SelectedCustomer);
                    loadInvoice(invoice);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion


        //######################################## ADDITIONAL FUNCTIONS #################################################
        #region AdditionalFunctions
        private void clearEditItemTextBoxes()
        {
            invoiceItem = new InvoiceItem();
            loadItemToEdit(invoiceItem);
        }

        private void inicializeComboBoxes()
        {
            cbxEditItemVatRate.DataSource = VatRates.getVatRatesList();
            cbxEditItemVatRate.DisplayMember = "Description";
            cbxEditItemVatRate.ValueMember = "Rate";

            cbxPaymentType.DataSource = PaymentTypes.getPaymentTypesList();
            cbxPaymentType.DisplayMember = "Description";
            cbxPaymentType.ValueMember = "Id";

            cbxEditItemUnit.DataSource = UnitTypes.getUnitTypesList();
            cbxEditItemUnit.DisplayMember = "ShortName";
            cbxEditItemUnit.ValueMember = "Id";
        }

        private void loadInvoice(Invoice invoice)
        {
            if (invoice != null)
            {
                txtType.Text = invoice.Type.ShortName;
                dtpExecutionDate.Value = invoice.ExecutionDate;
                cbxPaymentType.SelectedItem = invoice.PaymentType;
                txtCustomerName.Text = invoice.CustomerName;
                txtStreetName.Text = invoice.StreetName;
                txtBildingNumber.Text = invoice.BildingNumber;
                txtApartmentNumber.Text = invoice.ApartmentNumber;
                txtZipCode.Text = invoice.ZipCode;
                txtCity.Text = invoice.City;
                txtNipNumber.Text = invoice.NipNumber;
                txtNumber.Text = invoice.Number.ToString();
                txtMonth.Text = invoice.Month.ToString();
                txtYear.Text = invoice.Year.ToString();
                chbPaid.Checked = invoice.Paid;
                txtPaymentDate.Text = invoice.PaymentDate.ToString("dd/MM/yyyy");
                //dtpExecutionDate.Value = invoice.ExecutionDate;
                txtCreateDate.Text = invoice.CreateDate.ToString("dd/MM/yyyy");
                txtAuthor.Text = invoice.Author;

                if (invoice.PaidDate != default(DateTime))
                {
                    dtpPaidDate.Value = invoice.PaidDate;
                }

                txtId.Text = invoice.Id.ToString();
                chbPaid.Checked = invoice.Paid;


                txtCustomerName.Text = invoice.CustomerName;
                txtStreetName.Text = invoice.CustomerStreetName;
                txtBildingNumber.Text = invoice.CustomerBildingNumber;
                txtApartmentNumber.Text = invoice.CustomerApartmentNumber;
                txtZipCode.Text = invoice.CustomerZipCode;
                txtCity.Text = invoice.CustomerCity;
                txtNipNumber.Text = invoice.CustomerNipNumber;

                txtNetAmound.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:C2}", invoice.NetAmount);
                txtVatAmound.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:C2}", invoice.VatAmount);
                txtGrossAmount.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:C2}", invoice.GrossAmount);
            }

            setVivibility();

            invoiceItemsBS.DataSource = invoice.Items;
            dgvItemsList.DataSource = invoiceItemsBS;
        }

        private void loadItemToEdit(InvoiceItem invoiceItem)
        {
            if (invoiceItem != null)
            {
                txtEditItemName.Text = invoiceItem.ItemName;
                cbxEditItemUnit.SelectedItem = invoiceItem.Unit;
                txtEditItemQuantity.Text = invoiceItem.Quantity.ToString();
                txtEditItemUnitPrice.Text = invoiceItem.UnitPrice.ToString();
                cbxEditItemVatRate.SelectedItem = invoiceItem.Vat;
                txtEditGrossValue.Text = invoiceItem.GrossValue.ToString();
            }
        }
        #endregion

        private void chbPaid_CheckedChanged(object sender, EventArgs e)
        {
            setVivibility();
            loadInvoice(invoice);
        }

        private void setVivibility()
        {
            if (chbPaid.Checked)
            {
                labPaidDate.Visible = true;
                dtpPaidDate.Visible = true;
                invoice.setPaidDate(true);
            }
            else
            {
                labPaidDate.Visible = false;
                dtpPaidDate.Visible = false;
                invoice.setPaidDate(false);
            }
            if (invoice.Id == 0)
            {
                labId.Visible = false;
                txtId.Visible = false;
                labCreateDate.Visible = false;
                txtCreateDate.Visible = false;
            }
            else
            {
                labId.Visible = true;
                txtId.Visible = true;
                labCreateDate.Visible = true;
                txtCreateDate.Visible = true;
            }
        }

        private void txtEditItemName_Leave(object sender, EventArgs e)
        {
            invoiceItem.ItemName = txtEditItemName.Text;
        }

        private void cbxEditItemUnit_SelectedValueChanged(object sender, EventArgs e)
        {
            if (invoiceItem != null)
            {
                invoiceItem.setUnit((UnitType)cbxEditItemUnit.SelectedItem);
            }
        }

        private void dtpPaidDate_ValueChanged(object sender, EventArgs e)
        {
            invoice.PaidDate = (DateTime)dtpPaidDate.Value.Date;

        }

        private void dtpExecutionDate_ValueChanged(object sender, EventArgs e)
        {
            var data = (DateTime)dtpExecutionDate.Value.Date;
            invoice.setExecutionDate(data);
            companyDetailsDto = api.GetCompanyDetailsForDate(invoice);
            loadInvoice(invoice);
        }
        private void ItemUp_Click(object sender, EventArgs e)
        {

        }
    }
}

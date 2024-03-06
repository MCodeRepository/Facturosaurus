using System;

namespace Facturosaurus.Forms
{
    partial class InvoiceDetails
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvoiceDetails));
            this.dgvItemsList = new System.Windows.Forms.DataGridView();
            this.VatRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Up = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Down = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Modify = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.labAmound = new System.Windows.Forms.Label();
            this.txtNetAmound = new System.Windows.Forms.TextBox();
            this.txtVatAmound = new System.Windows.Forms.TextBox();
            this.txtGrossAmount = new System.Windows.Forms.TextBox();
            this.labType = new System.Windows.Forms.Label();
            this.labExecutionDate = new System.Windows.Forms.Label();
            this.labPaymentType = new System.Windows.Forms.Label();
            this.labCustomerName = new System.Windows.Forms.Label();
            this.labInvoiceNumber = new System.Windows.Forms.Label();
            this.labPaymentDate = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtType = new System.Windows.Forms.TextBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.chbPaid = new System.Windows.Forms.CheckBox();
            this.labAddrss = new System.Windows.Forms.Label();
            this.txtStreetName = new System.Windows.Forms.TextBox();
            this.labId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.labCreateDate = new System.Windows.Forms.Label();
            this.txtCreateDate = new System.Windows.Forms.TextBox();
            this.txtPaymentDate = new System.Windows.Forms.TextBox();
            this.labNipNumber = new System.Windows.Forms.Label();
            this.txtNipNumber = new System.Windows.Forms.TextBox();
            this.txtBildingNumber = new System.Windows.Forms.TextBox();
            this.txtApartmentNumber = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtMonth = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.labPaidDate = new System.Windows.Forms.Label();
            this.labPaid = new System.Windows.Forms.Label();
            this.cbxPaymentType = new System.Windows.Forms.ComboBox();
            this.btnChooseCustomer = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtpPaidDate = new System.Windows.Forms.DateTimePicker();
            this.txtZipCode = new System.Windows.Forms.MaskedTextBox();
            this.dtpExecutionDate = new System.Windows.Forms.DateTimePicker();
            this.gbModifyItem = new System.Windows.Forms.GroupBox();
            this.btnEditClose = new System.Windows.Forms.Button();
            this.btnEditSave = new System.Windows.Forms.Button();
            this.txtEditGrossValue = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labEditName = new System.Windows.Forms.Label();
            this.cbxEditItemVatRate = new System.Windows.Forms.ComboBox();
            this.cbxEditItemUnit = new System.Windows.Forms.ComboBox();
            this.txtEditItemName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEditItemUnitPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEditItemQuantity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnEditItem = new System.Windows.Forms.Button();
            this.btnDeletePosition = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.orderNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.netValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vatValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grossValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceItemDtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemsList)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.gbModifyItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceItemDtoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvItemsList
            // 
            this.dgvItemsList.AllowUserToAddRows = false;
            this.dgvItemsList.AllowUserToDeleteRows = false;
            this.dgvItemsList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvItemsList.AutoGenerateColumns = false;
            this.dgvItemsList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvItemsList.BackgroundColor = System.Drawing.Color.White;
            this.dgvItemsList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Athiti Medium", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvItemsList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvItemsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItemsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderNumberDataGridViewTextBoxColumn,
            this.itemNameDataGridViewTextBoxColumn,
            this.unitDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.unitPriceDataGridViewTextBoxColumn,
            this.netValueDataGridViewTextBoxColumn,
            this.VatRate,
            this.vatValueDataGridViewTextBoxColumn,
            this.grossValueDataGridViewTextBoxColumn,
            this.Up,
            this.Down,
            this.Delete,
            this.Modify});
            this.dgvItemsList.DataSource = this.invoiceItemDtoBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Athiti Medium", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvItemsList.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvItemsList.Location = new System.Drawing.Point(12, 254);
            this.dgvItemsList.MultiSelect = false;
            this.dgvItemsList.Name = "dgvItemsList";
            this.dgvItemsList.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Athiti Medium", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvItemsList.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvItemsList.RowHeadersVisible = false;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Black;
            this.dgvItemsList.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvItemsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItemsList.Size = new System.Drawing.Size(1146, 308);
            this.dgvItemsList.TabIndex = 11;
            // 
            // VatRate
            // 
            this.VatRate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.VatRate.DataPropertyName = "VatRate";
            this.VatRate.HeaderText = "Stawka VAT";
            this.VatRate.Name = "VatRate";
            this.VatRate.ReadOnly = true;
            this.VatRate.Width = 70;
            // 
            // Up
            // 
            this.Up.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Wingdings 3", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.Up.DefaultCellStyle = dataGridViewCellStyle2;
            this.Up.HeaderText = "";
            this.Up.Name = "Up";
            this.Up.ReadOnly = true;
            this.Up.Text = "p";
            this.Up.ToolTipText = "Przesuń w górę";
            this.Up.UseColumnTextForButtonValue = true;
            this.Up.Width = 20;
            // 
            // Down
            // 
            this.Down.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Wingdings 3", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.Down.DefaultCellStyle = dataGridViewCellStyle3;
            this.Down.HeaderText = "";
            this.Down.Name = "Down";
            this.Down.ReadOnly = true;
            this.Down.Text = "q";
            this.Down.ToolTipText = "Przesuń w dół";
            this.Down.UseColumnTextForButtonValue = true;
            this.Down.Width = 20;
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Wingdings 2", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.Delete.DefaultCellStyle = dataGridViewCellStyle4;
            this.Delete.HeaderText = "";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "Ó";
            this.Delete.ToolTipText = "Usuń";
            this.Delete.UseColumnTextForButtonValue = true;
            this.Delete.Width = 20;
            // 
            // Modify
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Wingdings", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.Modify.DefaultCellStyle = dataGridViewCellStyle5;
            this.Modify.HeaderText = "";
            this.Modify.Name = "Modify";
            this.Modify.ReadOnly = true;
            this.Modify.Text = "!";
            this.Modify.ToolTipText = "Edytuj";
            this.Modify.UseColumnTextForButtonValue = true;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Font = new System.Drawing.Font("Athiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSave.Location = new System.Drawing.Point(961, 607);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(96, 30);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Zapisz";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Font = new System.Drawing.Font("Athiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnClose.Location = new System.Drawing.Point(1062, 607);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(96, 30);
            this.btnClose.TabIndex = 20;
            this.btnClose.Text = "Wyjdź";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // labAmound
            // 
            this.labAmound.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labAmound.AutoSize = true;
            this.labAmound.Font = new System.Drawing.Font("Athiti Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labAmound.Location = new System.Drawing.Point(552, 570);
            this.labAmound.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labAmound.Name = "labAmound";
            this.labAmound.Size = new System.Drawing.Size(65, 25);
            this.labAmound.TabIndex = 40;
            this.labAmound.Text = "RAZEM";
            // 
            // txtNetAmound
            // 
            this.txtNetAmound.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNetAmound.Font = new System.Drawing.Font("Athiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtNetAmound.Location = new System.Drawing.Point(664, 568);
            this.txtNetAmound.Name = "txtNetAmound";
            this.txtNetAmound.ReadOnly = true;
            this.txtNetAmound.Size = new System.Drawing.Size(118, 28);
            this.txtNetAmound.TabIndex = 41;
            // 
            // txtVatAmound
            // 
            this.txtVatAmound.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVatAmound.Font = new System.Drawing.Font("Athiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtVatAmound.Location = new System.Drawing.Point(840, 568);
            this.txtVatAmound.Name = "txtVatAmound";
            this.txtVatAmound.ReadOnly = true;
            this.txtVatAmound.Size = new System.Drawing.Size(106, 28);
            this.txtVatAmound.TabIndex = 42;
            // 
            // txtGrossAmount
            // 
            this.txtGrossAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGrossAmount.Font = new System.Drawing.Font("Athiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtGrossAmount.Location = new System.Drawing.Point(947, 568);
            this.txtGrossAmount.Name = "txtGrossAmount";
            this.txtGrossAmount.ReadOnly = true;
            this.txtGrossAmount.Size = new System.Drawing.Size(128, 28);
            this.txtGrossAmount.TabIndex = 43;
            // 
            // labType
            // 
            this.labType.AutoSize = true;
            this.labType.Font = new System.Drawing.Font("Athiti Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labType.Location = new System.Drawing.Point(7, 23);
            this.labType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labType.Name = "labType";
            this.labType.Size = new System.Drawing.Size(40, 25);
            this.labType.TabIndex = 3;
            this.labType.Text = "Typ";
            // 
            // labExecutionDate
            // 
            this.labExecutionDate.AutoSize = true;
            this.labExecutionDate.Font = new System.Drawing.Font("Athiti Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labExecutionDate.Location = new System.Drawing.Point(7, 57);
            this.labExecutionDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labExecutionDate.Name = "labExecutionDate";
            this.labExecutionDate.Size = new System.Drawing.Size(133, 25);
            this.labExecutionDate.TabIndex = 4;
            this.labExecutionDate.Text = "Data wykonania";
            // 
            // labPaymentType
            // 
            this.labPaymentType.AutoSize = true;
            this.labPaymentType.Font = new System.Drawing.Font("Athiti Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labPaymentType.Location = new System.Drawing.Point(7, 91);
            this.labPaymentType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labPaymentType.Name = "labPaymentType";
            this.labPaymentType.Size = new System.Drawing.Size(116, 25);
            this.labPaymentType.TabIndex = 10;
            this.labPaymentType.Text = "Typ płatności";
            // 
            // labCustomerName
            // 
            this.labCustomerName.AutoSize = true;
            this.labCustomerName.Font = new System.Drawing.Font("Athiti Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labCustomerName.Location = new System.Drawing.Point(7, 125);
            this.labCustomerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labCustomerName.Name = "labCustomerName";
            this.labCustomerName.Size = new System.Drawing.Size(160, 25);
            this.labCustomerName.TabIndex = 10;
            this.labCustomerName.Text = "Nazwa kontrahenta";
            // 
            // labInvoiceNumber
            // 
            this.labInvoiceNumber.AutoSize = true;
            this.labInvoiceNumber.Font = new System.Drawing.Font("Athiti Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labInvoiceNumber.Location = new System.Drawing.Point(377, 26);
            this.labInvoiceNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labInvoiceNumber.Name = "labInvoiceNumber";
            this.labInvoiceNumber.Size = new System.Drawing.Size(62, 25);
            this.labInvoiceNumber.TabIndex = 10;
            this.labInvoiceNumber.Text = "Numer";
            // 
            // labPaymentDate
            // 
            this.labPaymentDate.AutoSize = true;
            this.labPaymentDate.Font = new System.Drawing.Font("Athiti Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labPaymentDate.Location = new System.Drawing.Point(377, 91);
            this.labPaymentDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labPaymentDate.Name = "labPaymentDate";
            this.labPaymentDate.Size = new System.Drawing.Size(141, 25);
            this.labPaymentDate.TabIndex = 11;
            this.labPaymentDate.Text = "Termin płatności";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Font = new System.Drawing.Font("Athiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtCustomerName.Location = new System.Drawing.Point(203, 125);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.ReadOnly = true;
            this.txtCustomerName.Size = new System.Drawing.Size(579, 28);
            this.txtCustomerName.TabIndex = 18;
            // 
            // txtType
            // 
            this.txtType.Font = new System.Drawing.Font("Athiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtType.Location = new System.Drawing.Point(203, 23);
            this.txtType.Name = "txtType";
            this.txtType.ReadOnly = true;
            this.txtType.Size = new System.Drawing.Size(56, 28);
            this.txtType.TabIndex = 19;
            // 
            // txtNumber
            // 
            this.txtNumber.Font = new System.Drawing.Font("Athiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtNumber.Location = new System.Drawing.Point(446, 23);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.ReadOnly = true;
            this.txtNumber.Size = new System.Drawing.Size(49, 28);
            this.txtNumber.TabIndex = 20;
            // 
            // chbPaid
            // 
            this.chbPaid.AutoSize = true;
            this.chbPaid.Location = new System.Drawing.Point(980, 132);
            this.chbPaid.Margin = new System.Windows.Forms.Padding(4);
            this.chbPaid.Name = "chbPaid";
            this.chbPaid.Size = new System.Drawing.Size(15, 14);
            this.chbPaid.TabIndex = 21;
            this.chbPaid.UseVisualStyleBackColor = true;
            this.chbPaid.CheckedChanged += new System.EventHandler(this.chbPaid_CheckedChanged);
            // 
            // labAddrss
            // 
            this.labAddrss.AutoSize = true;
            this.labAddrss.Font = new System.Drawing.Font("Athiti Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labAddrss.Location = new System.Drawing.Point(7, 159);
            this.labAddrss.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labAddrss.Name = "labAddrss";
            this.labAddrss.Size = new System.Drawing.Size(56, 25);
            this.labAddrss.TabIndex = 22;
            this.labAddrss.Text = "Adres";
            // 
            // txtStreetName
            // 
            this.txtStreetName.Font = new System.Drawing.Font("Athiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtStreetName.Location = new System.Drawing.Point(203, 159);
            this.txtStreetName.Name = "txtStreetName";
            this.txtStreetName.ReadOnly = true;
            this.txtStreetName.Size = new System.Drawing.Size(153, 28);
            this.txtStreetName.TabIndex = 23;
            // 
            // labId
            // 
            this.labId.AutoSize = true;
            this.labId.Font = new System.Drawing.Font("Athiti Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labId.Location = new System.Drawing.Point(946, 60);
            this.labId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labId.Name = "labId";
            this.labId.Size = new System.Drawing.Size(26, 25);
            this.labId.TabIndex = 24;
            this.labId.Text = "Id";
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Athiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtId.Location = new System.Drawing.Point(979, 57);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(153, 28);
            this.txtId.TabIndex = 25;
            // 
            // labCreateDate
            // 
            this.labCreateDate.AutoSize = true;
            this.labCreateDate.Font = new System.Drawing.Font("Athiti Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labCreateDate.Location = new System.Drawing.Point(836, 88);
            this.labCreateDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labCreateDate.Name = "labCreateDate";
            this.labCreateDate.Size = new System.Drawing.Size(136, 25);
            this.labCreateDate.TabIndex = 26;
            this.labCreateDate.Text = "Data stworzenia";
            // 
            // txtCreateDate
            // 
            this.txtCreateDate.Font = new System.Drawing.Font("Athiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtCreateDate.Location = new System.Drawing.Point(979, 88);
            this.txtCreateDate.Name = "txtCreateDate";
            this.txtCreateDate.ReadOnly = true;
            this.txtCreateDate.Size = new System.Drawing.Size(153, 28);
            this.txtCreateDate.TabIndex = 27;
            // 
            // txtPaymentDate
            // 
            this.txtPaymentDate.Font = new System.Drawing.Font("Athiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtPaymentDate.Location = new System.Drawing.Point(525, 91);
            this.txtPaymentDate.Name = "txtPaymentDate";
            this.txtPaymentDate.ReadOnly = true;
            this.txtPaymentDate.Size = new System.Drawing.Size(153, 28);
            this.txtPaymentDate.TabIndex = 28;
            // 
            // labNipNumber
            // 
            this.labNipNumber.AutoSize = true;
            this.labNipNumber.Font = new System.Drawing.Font("Athiti Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labNipNumber.Location = new System.Drawing.Point(7, 193);
            this.labNipNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labNipNumber.Name = "labNipNumber";
            this.labNipNumber.Size = new System.Drawing.Size(37, 25);
            this.labNipNumber.TabIndex = 29;
            this.labNipNumber.Text = "NIP";
            // 
            // txtNipNumber
            // 
            this.txtNipNumber.Font = new System.Drawing.Font("Athiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtNipNumber.Location = new System.Drawing.Point(203, 193);
            this.txtNipNumber.Name = "txtNipNumber";
            this.txtNipNumber.ReadOnly = true;
            this.txtNipNumber.Size = new System.Drawing.Size(153, 28);
            this.txtNipNumber.TabIndex = 30;
            // 
            // txtBildingNumber
            // 
            this.txtBildingNumber.Font = new System.Drawing.Font("Athiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBildingNumber.Location = new System.Drawing.Point(365, 159);
            this.txtBildingNumber.Name = "txtBildingNumber";
            this.txtBildingNumber.ReadOnly = true;
            this.txtBildingNumber.Size = new System.Drawing.Size(69, 28);
            this.txtBildingNumber.TabIndex = 31;
            // 
            // txtApartmentNumber
            // 
            this.txtApartmentNumber.Font = new System.Drawing.Font("Athiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtApartmentNumber.Location = new System.Drawing.Point(440, 159);
            this.txtApartmentNumber.Name = "txtApartmentNumber";
            this.txtApartmentNumber.ReadOnly = true;
            this.txtApartmentNumber.Size = new System.Drawing.Size(63, 28);
            this.txtApartmentNumber.TabIndex = 32;
            // 
            // txtCity
            // 
            this.txtCity.Font = new System.Drawing.Font("Athiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtCity.Location = new System.Drawing.Point(638, 159);
            this.txtCity.Name = "txtCity";
            this.txtCity.ReadOnly = true;
            this.txtCity.Size = new System.Drawing.Size(184, 28);
            this.txtCity.TabIndex = 34;
            // 
            // txtMonth
            // 
            this.txtMonth.Font = new System.Drawing.Font("Athiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtMonth.Location = new System.Drawing.Point(501, 23);
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.ReadOnly = true;
            this.txtMonth.Size = new System.Drawing.Size(54, 28);
            this.txtMonth.TabIndex = 35;
            // 
            // txtYear
            // 
            this.txtYear.Font = new System.Drawing.Font("Athiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtYear.Location = new System.Drawing.Point(561, 23);
            this.txtYear.Name = "txtYear";
            this.txtYear.ReadOnly = true;
            this.txtYear.Size = new System.Drawing.Size(54, 28);
            this.txtYear.TabIndex = 36;
            // 
            // labPaidDate
            // 
            this.labPaidDate.AutoSize = true;
            this.labPaidDate.Font = new System.Drawing.Font("Athiti Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labPaidDate.Location = new System.Drawing.Point(846, 158);
            this.labPaidDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labPaidDate.Name = "labPaidDate";
            this.labPaidDate.Size = new System.Drawing.Size(126, 25);
            this.labPaidDate.TabIndex = 37;
            this.labPaidDate.Text = "Data opłacenia";
            // 
            // labPaid
            // 
            this.labPaid.AutoSize = true;
            this.labPaid.Font = new System.Drawing.Font("Athiti Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labPaid.Location = new System.Drawing.Point(890, 125);
            this.labPaid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labPaid.Name = "labPaid";
            this.labPaid.Size = new System.Drawing.Size(82, 25);
            this.labPaid.TabIndex = 39;
            this.labPaid.Text = "Opłacona";
            // 
            // cbxPaymentType
            // 
            this.cbxPaymentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPaymentType.Font = new System.Drawing.Font("Athiti", 9.75F);
            this.cbxPaymentType.FormattingEnabled = true;
            this.cbxPaymentType.Items.AddRange(new object[] {
            "gotówka",
            "przelew"});
            this.cbxPaymentType.Location = new System.Drawing.Point(203, 92);
            this.cbxPaymentType.Name = "cbxPaymentType";
            this.cbxPaymentType.Size = new System.Drawing.Size(153, 29);
            this.cbxPaymentType.TabIndex = 40;
            this.cbxPaymentType.SelectedIndexChanged += new System.EventHandler(this.cbxPaymentType_SelectedIndexChanged);
            // 
            // btnChooseCustomer
            // 
            this.btnChooseCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChooseCustomer.Font = new System.Drawing.Font("Athiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnChooseCustomer.Location = new System.Drawing.Point(784, 125);
            this.btnChooseCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.btnChooseCustomer.Name = "btnChooseCustomer";
            this.btnChooseCustomer.Size = new System.Drawing.Size(38, 30);
            this.btnChooseCustomer.TabIndex = 41;
            this.btnChooseCustomer.Text = "...";
            this.btnChooseCustomer.UseVisualStyleBackColor = true;
            this.btnChooseCustomer.Click += new System.EventHandler(this.btnChooseCustomer_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtAuthor);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.dtpPaidDate);
            this.groupBox3.Controls.Add(this.txtZipCode);
            this.groupBox3.Controls.Add(this.dtpExecutionDate);
            this.groupBox3.Controls.Add(this.btnChooseCustomer);
            this.groupBox3.Controls.Add(this.cbxPaymentType);
            this.groupBox3.Controls.Add(this.labPaid);
            this.groupBox3.Controls.Add(this.labPaidDate);
            this.groupBox3.Controls.Add(this.txtYear);
            this.groupBox3.Controls.Add(this.txtMonth);
            this.groupBox3.Controls.Add(this.txtCity);
            this.groupBox3.Controls.Add(this.txtApartmentNumber);
            this.groupBox3.Controls.Add(this.txtBildingNumber);
            this.groupBox3.Controls.Add(this.txtNipNumber);
            this.groupBox3.Controls.Add(this.labNipNumber);
            this.groupBox3.Controls.Add(this.txtPaymentDate);
            this.groupBox3.Controls.Add(this.txtCreateDate);
            this.groupBox3.Controls.Add(this.labCreateDate);
            this.groupBox3.Controls.Add(this.txtId);
            this.groupBox3.Controls.Add(this.labId);
            this.groupBox3.Controls.Add(this.txtStreetName);
            this.groupBox3.Controls.Add(this.labAddrss);
            this.groupBox3.Controls.Add(this.chbPaid);
            this.groupBox3.Controls.Add(this.txtNumber);
            this.groupBox3.Controls.Add(this.txtType);
            this.groupBox3.Controls.Add(this.txtCustomerName);
            this.groupBox3.Controls.Add(this.labPaymentDate);
            this.groupBox3.Controls.Add(this.labInvoiceNumber);
            this.groupBox3.Controls.Add(this.labCustomerName);
            this.groupBox3.Controls.Add(this.labPaymentType);
            this.groupBox3.Controls.Add(this.labExecutionDate);
            this.groupBox3.Controls.Add(this.labType);
            this.groupBox3.Font = new System.Drawing.Font("Athiti Medium", 8.999999F, System.Drawing.FontStyle.Bold);
            this.groupBox3.ImeMode = System.Windows.Forms.ImeMode.On;
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1146, 236);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            // 
            // dtpPaidDate
            // 
            this.dtpPaidDate.CalendarFont = new System.Drawing.Font("Athiti ExtraLight", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtpPaidDate.CustomFormat = " dd / MM / yyyy";
            this.dtpPaidDate.Font = new System.Drawing.Font("Athiti ExtraLight", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtpPaidDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPaidDate.Location = new System.Drawing.Point(979, 156);
            this.dtpPaidDate.Name = "dtpPaidDate";
            this.dtpPaidDate.Size = new System.Drawing.Size(153, 27);
            this.dtpPaidDate.TabIndex = 45;
            this.dtpPaidDate.ValueChanged += new System.EventHandler(this.dtpPaidDate_ValueChanged);
            // 
            // txtZipCode
            // 
            this.txtZipCode.Location = new System.Drawing.Point(525, 160);
            this.txtZipCode.Mask = "00-999";
            this.txtZipCode.Name = "txtZipCode";
            this.txtZipCode.ReadOnly = true;
            this.txtZipCode.Size = new System.Drawing.Size(107, 27);
            this.txtZipCode.TabIndex = 44;
            // 
            // dtpExecutionDate
            // 
            this.dtpExecutionDate.CalendarFont = new System.Drawing.Font("Athiti ExtraLight", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtpExecutionDate.CustomFormat = " dd / MM / yyyy";
            this.dtpExecutionDate.Font = new System.Drawing.Font("Athiti ExtraLight", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtpExecutionDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpExecutionDate.Location = new System.Drawing.Point(203, 58);
            this.dtpExecutionDate.Name = "dtpExecutionDate";
            this.dtpExecutionDate.Size = new System.Drawing.Size(153, 27);
            this.dtpExecutionDate.TabIndex = 43;
            this.dtpExecutionDate.ValueChanged += new System.EventHandler(this.dtpExecutionDate_ValueChanged);
            // 
            // gbModifyItem
            // 
            this.gbModifyItem.Controls.Add(this.btnEditClose);
            this.gbModifyItem.Controls.Add(this.btnEditSave);
            this.gbModifyItem.Controls.Add(this.txtEditGrossValue);
            this.gbModifyItem.Controls.Add(this.label6);
            this.gbModifyItem.Controls.Add(this.label4);
            this.gbModifyItem.Controls.Add(this.labEditName);
            this.gbModifyItem.Controls.Add(this.cbxEditItemVatRate);
            this.gbModifyItem.Controls.Add(this.cbxEditItemUnit);
            this.gbModifyItem.Controls.Add(this.txtEditItemName);
            this.gbModifyItem.Controls.Add(this.label3);
            this.gbModifyItem.Controls.Add(this.txtEditItemUnitPrice);
            this.gbModifyItem.Controls.Add(this.label2);
            this.gbModifyItem.Controls.Add(this.txtEditItemQuantity);
            this.gbModifyItem.Controls.Add(this.label5);
            this.gbModifyItem.Font = new System.Drawing.Font("Athiti Medium", 8.999999F, System.Drawing.FontStyle.Bold);
            this.gbModifyItem.ImeMode = System.Windows.Forms.ImeMode.On;
            this.gbModifyItem.Location = new System.Drawing.Point(21, 483);
            this.gbModifyItem.Name = "gbModifyItem";
            this.gbModifyItem.Size = new System.Drawing.Size(1129, 67);
            this.gbModifyItem.TabIndex = 44;
            this.gbModifyItem.TabStop = false;
            this.gbModifyItem.Visible = false;
            // 
            // btnEditClose
            // 
            this.btnEditClose.Font = new System.Drawing.Font("Wingdings 2", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnEditClose.Location = new System.Drawing.Point(1102, 38);
            this.btnEditClose.Name = "btnEditClose";
            this.btnEditClose.Size = new System.Drawing.Size(21, 23);
            this.btnEditClose.TabIndex = 47;
            this.btnEditClose.Text = "O";
            this.btnEditClose.UseVisualStyleBackColor = true;
            this.btnEditClose.Click += new System.EventHandler(this.btnEditClose_Click);
            // 
            // btnEditSave
            // 
            this.btnEditSave.Font = new System.Drawing.Font("Wingdings 2", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnEditSave.Location = new System.Drawing.Point(1102, 14);
            this.btnEditSave.Name = "btnEditSave";
            this.btnEditSave.Size = new System.Drawing.Size(21, 23);
            this.btnEditSave.TabIndex = 46;
            this.btnEditSave.Text = "P";
            this.btnEditSave.UseVisualStyleBackColor = true;
            this.btnEditSave.Click += new System.EventHandler(this.btnEditSave_Click);
            // 
            // txtEditGrossValue
            // 
            this.txtEditGrossValue.Font = new System.Drawing.Font("Athiti SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtEditGrossValue.Location = new System.Drawing.Point(1011, 31);
            this.txtEditGrossValue.Name = "txtEditGrossValue";
            this.txtEditGrossValue.ReadOnly = true;
            this.txtEditGrossValue.Size = new System.Drawing.Size(85, 28);
            this.txtEditGrossValue.TabIndex = 48;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Athiti SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(1011, 11);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 19);
            this.label6.TabIndex = 47;
            this.label6.Text = "Wartość brutto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Athiti SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(952, 11);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 19);
            this.label4.TabIndex = 45;
            this.label4.Text = "VAT";
            // 
            // labEditName
            // 
            this.labEditName.AutoSize = true;
            this.labEditName.Font = new System.Drawing.Font("Athiti SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labEditName.Location = new System.Drawing.Point(7, 11);
            this.labEditName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labEditName.Name = "labEditName";
            this.labEditName.Size = new System.Drawing.Size(78, 19);
            this.labEditName.TabIndex = 3;
            this.labEditName.Text = "Nazwa usługi";
            // 
            // cbxEditItemVatRate
            // 
            this.cbxEditItemVatRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEditItemVatRate.Font = new System.Drawing.Font("Athiti SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbxEditItemVatRate.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.cbxEditItemVatRate.Location = new System.Drawing.Point(952, 31);
            this.cbxEditItemVatRate.Name = "cbxEditItemVatRate";
            this.cbxEditItemVatRate.Size = new System.Drawing.Size(53, 29);
            this.cbxEditItemVatRate.TabIndex = 46;
            this.cbxEditItemVatRate.Tag = "";
            this.cbxEditItemVatRate.SelectedValueChanged += new System.EventHandler(this.cbxEditItemVatRate_SelectedValueChanged);
            // 
            // cbxEditItemUnit
            // 
            this.cbxEditItemUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEditItemUnit.Font = new System.Drawing.Font("Athiti SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbxEditItemUnit.FormattingEnabled = true;
            this.cbxEditItemUnit.Items.AddRange(new object[] {
            "szt.",
            "godz."});
            this.cbxEditItemUnit.Location = new System.Drawing.Point(702, 31);
            this.cbxEditItemUnit.Name = "cbxEditItemUnit";
            this.cbxEditItemUnit.Size = new System.Drawing.Size(53, 29);
            this.cbxEditItemUnit.TabIndex = 40;
            this.cbxEditItemUnit.SelectedValueChanged += new System.EventHandler(this.cbxEditItemUnit_SelectedValueChanged);
            // 
            // txtEditItemName
            // 
            this.txtEditItemName.Font = new System.Drawing.Font("Athiti SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtEditItemName.Location = new System.Drawing.Point(11, 31);
            this.txtEditItemName.Name = "txtEditItemName";
            this.txtEditItemName.Size = new System.Drawing.Size(685, 28);
            this.txtEditItemName.TabIndex = 29;
            this.txtEditItemName.Leave += new System.EventHandler(this.txtEditItemName_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Athiti SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(839, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 19);
            this.label3.TabIndex = 43;
            this.label3.Text = "Cena netto";
            // 
            // txtEditItemUnitPrice
            // 
            this.txtEditItemUnitPrice.Font = new System.Drawing.Font("Athiti SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtEditItemUnitPrice.Location = new System.Drawing.Point(837, 31);
            this.txtEditItemUnitPrice.Name = "txtEditItemUnitPrice";
            this.txtEditItemUnitPrice.Size = new System.Drawing.Size(109, 28);
            this.txtEditItemUnitPrice.TabIndex = 44;
            this.txtEditItemUnitPrice.Leave += new System.EventHandler(this.txtEditItemUnitPrice_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Athiti SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(702, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 19);
            this.label2.TabIndex = 30;
            this.label2.Text = "J.m.";
            // 
            // txtEditItemQuantity
            // 
            this.txtEditItemQuantity.Font = new System.Drawing.Font("Athiti SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtEditItemQuantity.Location = new System.Drawing.Point(761, 31);
            this.txtEditItemQuantity.Name = "txtEditItemQuantity";
            this.txtEditItemQuantity.Size = new System.Drawing.Size(70, 28);
            this.txtEditItemQuantity.TabIndex = 42;
            this.txtEditItemQuantity.Leave += new System.EventHandler(this.txtEditItemQuantity_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Athiti SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(761, 11);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 19);
            this.label5.TabIndex = 41;
            this.label5.Text = "Ilość w j.m.";
            // 
            // btnAddItem
            // 
            this.btnAddItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddItem.Font = new System.Drawing.Font("Athiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAddItem.Location = new System.Drawing.Point(13, 569);
            this.btnAddItem.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(123, 30);
            this.btnAddItem.TabIndex = 45;
            this.btnAddItem.Text = "Dodaj pozycję";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // btnEditItem
            // 
            this.btnEditItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditItem.Font = new System.Drawing.Font("Athiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnEditItem.Location = new System.Drawing.Point(144, 569);
            this.btnEditItem.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditItem.Name = "btnEditItem";
            this.btnEditItem.Size = new System.Drawing.Size(142, 30);
            this.btnEditItem.TabIndex = 46;
            this.btnEditItem.Text = "Modyfikuj pozycję";
            this.btnEditItem.UseVisualStyleBackColor = true;
            this.btnEditItem.Click += new System.EventHandler(this.btnEditItem_Click);
            // 
            // btnDeletePosition
            // 
            this.btnDeletePosition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeletePosition.Font = new System.Drawing.Font("Athiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDeletePosition.Location = new System.Drawing.Point(294, 569);
            this.btnDeletePosition.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeletePosition.Name = "btnDeletePosition";
            this.btnDeletePosition.Size = new System.Drawing.Size(123, 30);
            this.btnDeletePosition.TabIndex = 47;
            this.btnDeletePosition.Text = "Usuń pozycję";
            this.btnDeletePosition.UseVisualStyleBackColor = true;
            this.btnDeletePosition.Click += new System.EventHandler(this.btnDeletePosition_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Vat";
            this.dataGridViewTextBoxColumn1.HeaderText = "Vat";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 542;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Font = new System.Drawing.Font("Athiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtAuthor.Location = new System.Drawing.Point(979, 26);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.ReadOnly = true;
            this.txtAuthor.Size = new System.Drawing.Size(153, 28);
            this.txtAuthor.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Athiti Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(917, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 25);
            this.label1.TabIndex = 46;
            this.label1.Text = "Autor";
            // 
            // orderNumberDataGridViewTextBoxColumn
            // 
            this.orderNumberDataGridViewTextBoxColumn.DataPropertyName = "OrderNumber";
            this.orderNumberDataGridViewTextBoxColumn.HeaderText = "Lp";
            this.orderNumberDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.orderNumberDataGridViewTextBoxColumn.Name = "orderNumberDataGridViewTextBoxColumn";
            this.orderNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // itemNameDataGridViewTextBoxColumn
            // 
            this.itemNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.itemNameDataGridViewTextBoxColumn.DataPropertyName = "ItemName";
            this.itemNameDataGridViewTextBoxColumn.FillWeight = 609.5238F;
            this.itemNameDataGridViewTextBoxColumn.HeaderText = "Nazwa usługi";
            this.itemNameDataGridViewTextBoxColumn.Name = "itemNameDataGridViewTextBoxColumn";
            this.itemNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemNameDataGridViewTextBoxColumn.Width = 440;
            // 
            // unitDataGridViewTextBoxColumn
            // 
            this.unitDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.unitDataGridViewTextBoxColumn.DataPropertyName = "UnitDescription";
            this.unitDataGridViewTextBoxColumn.FillWeight = 27.21088F;
            this.unitDataGridViewTextBoxColumn.HeaderText = "J.m.";
            this.unitDataGridViewTextBoxColumn.Name = "unitDataGridViewTextBoxColumn";
            this.unitDataGridViewTextBoxColumn.ReadOnly = true;
            this.unitDataGridViewTextBoxColumn.Width = 40;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.FillWeight = 27.21088F;
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Ilość";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            this.quantityDataGridViewTextBoxColumn.Width = 50;
            // 
            // unitPriceDataGridViewTextBoxColumn
            // 
            this.unitPriceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.unitPriceDataGridViewTextBoxColumn.DataPropertyName = "UnitPrice";
            this.unitPriceDataGridViewTextBoxColumn.FillWeight = 27.21088F;
            this.unitPriceDataGridViewTextBoxColumn.HeaderText = "Cena j.m.";
            this.unitPriceDataGridViewTextBoxColumn.Name = "unitPriceDataGridViewTextBoxColumn";
            this.unitPriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.unitPriceDataGridViewTextBoxColumn.Width = 90;
            // 
            // netValueDataGridViewTextBoxColumn
            // 
            this.netValueDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.netValueDataGridViewTextBoxColumn.DataPropertyName = "NetValue";
            this.netValueDataGridViewTextBoxColumn.FillWeight = 27.21088F;
            this.netValueDataGridViewTextBoxColumn.HeaderText = "Wartość netto";
            this.netValueDataGridViewTextBoxColumn.Name = "netValueDataGridViewTextBoxColumn";
            this.netValueDataGridViewTextBoxColumn.ReadOnly = true;
            this.netValueDataGridViewTextBoxColumn.Width = 120;
            // 
            // vatValueDataGridViewTextBoxColumn
            // 
            this.vatValueDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.vatValueDataGridViewTextBoxColumn.DataPropertyName = "VatValue";
            this.vatValueDataGridViewTextBoxColumn.FillWeight = 27.21088F;
            this.vatValueDataGridViewTextBoxColumn.HeaderText = "Wartość VAT";
            this.vatValueDataGridViewTextBoxColumn.Name = "vatValueDataGridViewTextBoxColumn";
            this.vatValueDataGridViewTextBoxColumn.ReadOnly = true;
            this.vatValueDataGridViewTextBoxColumn.Width = 109;
            // 
            // grossValueDataGridViewTextBoxColumn
            // 
            this.grossValueDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.grossValueDataGridViewTextBoxColumn.DataPropertyName = "GrossValue";
            this.grossValueDataGridViewTextBoxColumn.FillWeight = 27.21088F;
            this.grossValueDataGridViewTextBoxColumn.HeaderText = "Wartosc brutto";
            this.grossValueDataGridViewTextBoxColumn.Name = "grossValueDataGridViewTextBoxColumn";
            this.grossValueDataGridViewTextBoxColumn.ReadOnly = true;
            this.grossValueDataGridViewTextBoxColumn.Width = 115;
            // 
            // invoiceItemDtoBindingSource
            // 
            this.invoiceItemDtoBindingSource.DataSource = typeof(Facturosaurus.Forms.Forms.Invoice.InvoiceItem);
            // 
            // InvoiceDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1165, 643);
            this.Controls.Add(this.btnDeletePosition);
            this.Controls.Add(this.btnEditItem);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.gbModifyItem);
            this.Controls.Add(this.txtGrossAmount);
            this.Controls.Add(this.txtVatAmound);
            this.Controls.Add(this.txtNetAmound);
            this.Controls.Add(this.labAmound);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvItemsList);
            this.Controls.Add(this.groupBox3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InvoiceDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ekycja faktury";
            this.Load += new System.EventHandler(this.InvoiceDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemsList)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.gbModifyItem.ResumeLayout(false);
            this.gbModifyItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceItemDtoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private EventHandler ItemUp_Click()
        {
            return null;
        }

        private void InvoiceDetails_Click(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.DataGridView dgvItemsList;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.BindingSource invoiceItemDtoBindingSource;
        private System.Windows.Forms.Label labType;
        private System.Windows.Forms.Label labExecutionDate;
        private System.Windows.Forms.Label labPaymentType;
        private System.Windows.Forms.Label labCustomerName;
        private System.Windows.Forms.Label labInvoiceNumber;
        private System.Windows.Forms.Label labPaymentDate;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.CheckBox chbPaid;
        private System.Windows.Forms.Label labAddrss;
        private System.Windows.Forms.TextBox txtStreetName;
        private System.Windows.Forms.Label labId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label labCreateDate;
        private System.Windows.Forms.TextBox txtCreateDate;
        private System.Windows.Forms.TextBox txtPaymentDate;
        private System.Windows.Forms.Label labNipNumber;
        private System.Windows.Forms.TextBox txtNipNumber;
        private System.Windows.Forms.TextBox txtBildingNumber;
        private System.Windows.Forms.TextBox txtApartmentNumber;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtMonth;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label labPaidDate;
        private System.Windows.Forms.Label labPaid;
        private System.Windows.Forms.ComboBox cbxPaymentType;
        private System.Windows.Forms.Button btnChooseCustomer;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dtpExecutionDate;
        private System.Windows.Forms.GroupBox gbModifyItem;
        private System.Windows.Forms.TextBox txtEditGrossValue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labEditName;
        private System.Windows.Forms.ComboBox cbxEditItemVatRate;
        private System.Windows.Forms.ComboBox cbxEditItemUnit;
        private System.Windows.Forms.TextBox txtEditItemUnitPrice;
        private System.Windows.Forms.TextBox txtEditItemName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEditItemQuantity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labAmound;
        private System.Windows.Forms.TextBox txtNetAmound;
        private System.Windows.Forms.TextBox txtVatAmound;
        private System.Windows.Forms.TextBox txtGrossAmount;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnEditSave;
        private System.Windows.Forms.Button btnEditClose;
        private System.Windows.Forms.MaskedTextBox txtZipCode;
        private System.Windows.Forms.DateTimePicker dtpPaidDate;
        private System.Windows.Forms.Button btnEditItem;
        private System.Windows.Forms.Button btnDeletePosition;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn netValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn VatRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn vatValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn grossValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Up;
        private System.Windows.Forms.DataGridViewButtonColumn Down;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.DataGridViewButtonColumn Modify;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label label1;
    }
}
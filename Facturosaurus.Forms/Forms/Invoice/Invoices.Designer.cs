namespace Facturosaurus.Forms
{
    partial class Invoices
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Invoices));
            this.dgvInvoicesList = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceTypesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wholeNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shortCompanyNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.netAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grossAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paidDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paidDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.invoicesListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCustomerIdFilter = new Facturosaurus.Forms.IntegerNumberTextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.txtCustomerNameFilter = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.txtYearFilter = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumberFilter = new System.Windows.Forms.TextBox();
            this.txtMonthFilter = new System.Windows.Forms.TextBox();
            this.chbOnlyActive = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxInvoiceTypeFilter = new System.Windows.Forms.ComboBox();
            this.btnCreateCorrection = new System.Windows.Forms.Button();
            this.btnPrintDuplicate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoicesList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoicesListBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvInvoicesList
            // 
            this.dgvInvoicesList.AllowUserToAddRows = false;
            this.dgvInvoicesList.AllowUserToDeleteRows = false;
            this.dgvInvoicesList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvInvoicesList.AutoGenerateColumns = false;
            this.dgvInvoicesList.BackgroundColor = System.Drawing.Color.White;
            this.dgvInvoicesList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Athiti Medium", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInvoicesList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInvoicesList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoicesList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.invoiceTypesDataGridViewTextBoxColumn,
            this.wholeNumberDataGridViewTextBoxColumn,
            this.createDateDataGridViewTextBoxColumn,
            this.shortCompanyNameDataGridViewTextBoxColumn,
            this.netAmountDataGridViewTextBoxColumn,
            this.grossAmountDataGridViewTextBoxColumn,
            this.paymentDateDataGridViewTextBoxColumn,
            this.paidDateDataGridViewTextBoxColumn,
            this.paidDataGridViewCheckBoxColumn});
            this.dgvInvoicesList.DataSource = this.invoicesListBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Athiti Medium", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInvoicesList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvInvoicesList.Location = new System.Drawing.Point(13, 82);
            this.dgvInvoicesList.MultiSelect = false;
            this.dgvInvoicesList.Name = "dgvInvoicesList";
            this.dgvInvoicesList.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Athiti Medium", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInvoicesList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvInvoicesList.RowHeadersVisible = false;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Black;
            this.dgvInvoicesList.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvInvoicesList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInvoicesList.Size = new System.Drawing.Size(1325, 659);
            this.dgvInvoicesList.TabIndex = 10;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            this.idDataGridViewTextBoxColumn.Width = 132;
            // 
            // invoiceTypesDataGridViewTextBoxColumn
            // 
            this.invoiceTypesDataGridViewTextBoxColumn.DataPropertyName = "InvoiceTypes";
            this.invoiceTypesDataGridViewTextBoxColumn.HeaderText = "Typ";
            this.invoiceTypesDataGridViewTextBoxColumn.Name = "invoiceTypesDataGridViewTextBoxColumn";
            this.invoiceTypesDataGridViewTextBoxColumn.ReadOnly = true;
            this.invoiceTypesDataGridViewTextBoxColumn.Width = 132;
            // 
            // wholeNumberDataGridViewTextBoxColumn
            // 
            this.wholeNumberDataGridViewTextBoxColumn.DataPropertyName = "WholeNumber";
            this.wholeNumberDataGridViewTextBoxColumn.HeaderText = "Numer";
            this.wholeNumberDataGridViewTextBoxColumn.Name = "wholeNumberDataGridViewTextBoxColumn";
            this.wholeNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.wholeNumberDataGridViewTextBoxColumn.Width = 133;
            // 
            // createDateDataGridViewTextBoxColumn
            // 
            this.createDateDataGridViewTextBoxColumn.DataPropertyName = "CreateDate";
            this.createDateDataGridViewTextBoxColumn.HeaderText = "Data utworzenia";
            this.createDateDataGridViewTextBoxColumn.Name = "createDateDataGridViewTextBoxColumn";
            this.createDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.createDateDataGridViewTextBoxColumn.Width = 132;
            // 
            // shortCompanyNameDataGridViewTextBoxColumn
            // 
            this.shortCompanyNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.shortCompanyNameDataGridViewTextBoxColumn.DataPropertyName = "ShortCompanyName";
            this.shortCompanyNameDataGridViewTextBoxColumn.HeaderText = "Kontrahent";
            this.shortCompanyNameDataGridViewTextBoxColumn.Name = "shortCompanyNameDataGridViewTextBoxColumn";
            this.shortCompanyNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // netAmountDataGridViewTextBoxColumn
            // 
            this.netAmountDataGridViewTextBoxColumn.DataPropertyName = "NetAmount";
            this.netAmountDataGridViewTextBoxColumn.HeaderText = "Wartość netto";
            this.netAmountDataGridViewTextBoxColumn.Name = "netAmountDataGridViewTextBoxColumn";
            this.netAmountDataGridViewTextBoxColumn.ReadOnly = true;
            this.netAmountDataGridViewTextBoxColumn.Width = 132;
            // 
            // grossAmountDataGridViewTextBoxColumn
            // 
            this.grossAmountDataGridViewTextBoxColumn.DataPropertyName = "GrossAmount";
            this.grossAmountDataGridViewTextBoxColumn.HeaderText = "Wartość brutto";
            this.grossAmountDataGridViewTextBoxColumn.Name = "grossAmountDataGridViewTextBoxColumn";
            this.grossAmountDataGridViewTextBoxColumn.ReadOnly = true;
            this.grossAmountDataGridViewTextBoxColumn.Width = 132;
            // 
            // paymentDateDataGridViewTextBoxColumn
            // 
            this.paymentDateDataGridViewTextBoxColumn.DataPropertyName = "PaymentDate";
            this.paymentDateDataGridViewTextBoxColumn.HeaderText = "Data płatności";
            this.paymentDateDataGridViewTextBoxColumn.Name = "paymentDateDataGridViewTextBoxColumn";
            this.paymentDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.paymentDateDataGridViewTextBoxColumn.Width = 133;
            // 
            // paidDateDataGridViewTextBoxColumn
            // 
            this.paidDateDataGridViewTextBoxColumn.DataPropertyName = "PaidDate";
            this.paidDateDataGridViewTextBoxColumn.HeaderText = "Data opłacenia";
            this.paidDateDataGridViewTextBoxColumn.Name = "paidDateDataGridViewTextBoxColumn";
            this.paidDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.paidDateDataGridViewTextBoxColumn.Width = 132;
            // 
            // paidDataGridViewCheckBoxColumn
            // 
            this.paidDataGridViewCheckBoxColumn.DataPropertyName = "Paid";
            this.paidDataGridViewCheckBoxColumn.HeaderText = "Zapłacona";
            this.paidDataGridViewCheckBoxColumn.Name = "paidDataGridViewCheckBoxColumn";
            this.paidDataGridViewCheckBoxColumn.ReadOnly = true;
            this.paidDataGridViewCheckBoxColumn.Width = 132;
            // 
            // invoicesListBindingSource
            // 
            this.invoicesListBindingSource.DataSource = typeof(Facturosaurus.Forms.Lists.InvoicesList);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.Font = new System.Drawing.Font("Athiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnEdit.Location = new System.Drawing.Point(1035, 748);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(96, 30);
            this.btnEdit.TabIndex = 14;
            this.btnEdit.Text = "Edytuj";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Font = new System.Drawing.Font("Athiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAdd.Location = new System.Drawing.Point(928, 748);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(96, 30);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Dodaj";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.Font = new System.Drawing.Font("Athiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPrint.Location = new System.Drawing.Point(1139, 748);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(96, 30);
            this.btnPrint.TabIndex = 15;
            this.btnPrint.Text = "Drukuj";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Font = new System.Drawing.Font("Athiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnClose.Location = new System.Drawing.Point(1243, 748);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(96, 30);
            this.btnClose.TabIndex = 16;
            this.btnClose.Text = "Wyjdź";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.txtCustomerIdFilter);
            this.groupBox1.Controls.Add(this.btnRefresh);
            this.groupBox1.Controls.Add(this.txtCustomerNameFilter);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnShowAll);
            this.groupBox1.Controls.Add(this.txtYearFilter);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNumberFilter);
            this.groupBox1.Controls.Add(this.txtMonthFilter);
            this.groupBox1.Controls.Add(this.chbOnlyActive);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbxInvoiceTypeFilter);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1325, 62);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtry";
            // 
            // txtCustomerIdFilter
            // 
            this.txtCustomerIdFilter.Font = new System.Drawing.Font("Athiti", 11.25F);
            this.txtCustomerIdFilter.Location = new System.Drawing.Point(482, 19);
            this.txtCustomerIdFilter.Name = "txtCustomerIdFilter";
            this.txtCustomerIdFilter.Size = new System.Drawing.Size(100, 31);
            this.txtCustomerIdFilter.TabIndex = 17;
            this.txtCustomerIdFilter.DoubleClick += new System.EventHandler(this.txtCustomerIdFilter_DoubleClick);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Font = new System.Drawing.Font("Athiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRefresh.Location = new System.Drawing.Point(1230, 21);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(83, 30);
            this.btnRefresh.TabIndex = 9;
            this.btnRefresh.Text = "Odśwież";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // txtCustomerNameFilter
            // 
            this.txtCustomerNameFilter.Enabled = false;
            this.txtCustomerNameFilter.Font = new System.Drawing.Font("Athiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtCustomerNameFilter.Location = new System.Drawing.Point(589, 19);
            this.txtCustomerNameFilter.Margin = new System.Windows.Forms.Padding(4);
            this.txtCustomerNameFilter.Name = "txtCustomerNameFilter";
            this.txtCustomerNameFilter.Size = new System.Drawing.Size(217, 31);
            this.txtCustomerNameFilter.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Athiti Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(814, 23);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tylko nieopłacone";
            // 
            // btnShowAll
            // 
            this.btnShowAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowAll.Font = new System.Drawing.Font("Athiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnShowAll.Location = new System.Drawing.Point(1059, 21);
            this.btnShowAll.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(163, 30);
            this.btnShowAll.TabIndex = 8;
            this.btnShowAll.Text = "Pokaż wszystkie";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // txtYearFilter
            // 
            this.txtYearFilter.Font = new System.Drawing.Font("Athiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtYearFilter.Location = new System.Drawing.Point(324, 20);
            this.txtYearFilter.Margin = new System.Windows.Forms.Padding(4);
            this.txtYearFilter.Name = "txtYearFilter";
            this.txtYearFilter.Size = new System.Drawing.Size(45, 31);
            this.txtYearFilter.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Athiti Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(377, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kontrahent";
            // 
            // txtNumberFilter
            // 
            this.txtNumberFilter.Font = new System.Drawing.Font("Athiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtNumberFilter.Location = new System.Drawing.Point(224, 20);
            this.txtNumberFilter.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumberFilter.Name = "txtNumberFilter";
            this.txtNumberFilter.Size = new System.Drawing.Size(45, 31);
            this.txtNumberFilter.TabIndex = 2;
            // 
            // txtMonthFilter
            // 
            this.txtMonthFilter.Font = new System.Drawing.Font("Athiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtMonthFilter.Location = new System.Drawing.Point(274, 20);
            this.txtMonthFilter.Margin = new System.Windows.Forms.Padding(4);
            this.txtMonthFilter.Name = "txtMonthFilter";
            this.txtMonthFilter.Size = new System.Drawing.Size(45, 31);
            this.txtMonthFilter.TabIndex = 3;
            // 
            // chbOnlyActive
            // 
            this.chbOnlyActive.AutoSize = true;
            this.chbOnlyActive.Location = new System.Drawing.Point(974, 28);
            this.chbOnlyActive.Margin = new System.Windows.Forms.Padding(4);
            this.chbOnlyActive.Name = "chbOnlyActive";
            this.chbOnlyActive.Size = new System.Drawing.Size(15, 14);
            this.chbOnlyActive.TabIndex = 7;
            this.chbOnlyActive.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Athiti Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(14, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Typ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Athiti Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(154, 23);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 25);
            this.label4.TabIndex = 16;
            this.label4.Text = "Numer";
            // 
            // cbxInvoiceTypeFilter
            // 
            this.cbxInvoiceTypeFilter.BackColor = System.Drawing.Color.White;
            this.cbxInvoiceTypeFilter.Font = new System.Drawing.Font("Athiti", 9.75F);
            this.cbxInvoiceTypeFilter.FormattingEnabled = true;
            this.cbxInvoiceTypeFilter.Items.AddRange(new object[] {
            "FV",
            "FK"});
            this.cbxInvoiceTypeFilter.Location = new System.Drawing.Point(61, 21);
            this.cbxInvoiceTypeFilter.Name = "cbxInvoiceTypeFilter";
            this.cbxInvoiceTypeFilter.Size = new System.Drawing.Size(86, 29);
            this.cbxInvoiceTypeFilter.TabIndex = 1;
            // 
            // btnCreateCorrection
            // 
            this.btnCreateCorrection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCreateCorrection.Font = new System.Drawing.Font("Athiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCreateCorrection.Location = new System.Drawing.Point(13, 748);
            this.btnCreateCorrection.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreateCorrection.Name = "btnCreateCorrection";
            this.btnCreateCorrection.Size = new System.Drawing.Size(119, 30);
            this.btnCreateCorrection.TabIndex = 11;
            this.btnCreateCorrection.Text = "Twórz korektę";
            this.btnCreateCorrection.UseVisualStyleBackColor = true;
            // 
            // btnPrintDuplicate
            // 
            this.btnPrintDuplicate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPrintDuplicate.Font = new System.Drawing.Font("Athiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPrintDuplicate.Location = new System.Drawing.Point(140, 748);
            this.btnPrintDuplicate.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrintDuplicate.Name = "btnPrintDuplicate";
            this.btnPrintDuplicate.Size = new System.Drawing.Size(132, 30);
            this.btnPrintDuplicate.TabIndex = 12;
            this.btnPrintDuplicate.Text = "Drukuj duplikat";
            this.btnPrintDuplicate.UseVisualStyleBackColor = true;
            // 
            // Invoices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1351, 786);
            this.Controls.Add(this.btnPrintDuplicate);
            this.Controls.Add(this.btnCreateCorrection);
            this.Controls.Add(this.dgvInvoicesList);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Invoices";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Faktury";
            this.Load += new System.EventHandler(this.Invoices_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoicesList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoicesListBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvInvoicesList;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chbOnlyActive;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.TextBox txtNumberFilter;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxInvoiceTypeFilter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMonthFilter;
        private System.Windows.Forms.TextBox txtYearFilter;
        private System.Windows.Forms.TextBox txtCustomerNameFilter;
        private System.Windows.Forms.Button btnCreateCorrection;
        private System.Windows.Forms.Button btnPrintDuplicate;
        private System.Windows.Forms.BindingSource invoicesListBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceTypesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wholeNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shortCompanyNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn netAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn grossAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paidDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn paidDataGridViewCheckBoxColumn;
        private IntegerNumberTextBox txtCustomerIdFilter;
    }
}
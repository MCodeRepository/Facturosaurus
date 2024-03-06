namespace Facturosaurus.Forms
{
    partial class frmCustomerDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomerDetails));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtZipCode = new System.Windows.Forms.MaskedTextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtApartmentNumber = new System.Windows.Forms.TextBox();
            this.txtBildingNumber = new System.Windows.Forms.TextBox();
            this.txtStreetName = new System.Windows.Forms.TextBox();
            this.labCity = new System.Windows.Forms.Label();
            this.labZipCode = new System.Windows.Forms.Label();
            this.labApartmentNumber = new System.Windows.Forms.Label();
            this.labStreetName = new System.Windows.Forms.Label();
            this.labBildingNumber = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chbActive = new System.Windows.Forms.CheckBox();
            this.txtCreateDate = new System.Windows.Forms.TextBox();
            this.txtCustomerId = new System.Windows.Forms.TextBox();
            this.txtNipNumber = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtShortCustomerName = new System.Windows.Forms.TextBox();
            this.labActive = new System.Windows.Forms.Label();
            this.labCreateDate = new System.Windows.Forms.Label();
            this.labNipNumber = new System.Windows.Forms.Label();
            this.labCustomerName = new System.Windows.Forms.Label();
            this.labShortCustomerName = new System.Windows.Forms.Label();
            this.labCustomerId = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbxAccountCurrency = new System.Windows.Forms.ComboBox();
            this.txtAccountNumber = new System.Windows.Forms.TextBox();
            this.txtBankName = new System.Windows.Forms.TextBox();
            this.labAccountNumber = new System.Windows.Forms.Label();
            this.labAccountCurrency = new System.Windows.Forms.Label();
            this.labBankName = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtAddressEmail = new System.Windows.Forms.TextBox();
            this.labPhoneNumber = new System.Windows.Forms.Label();
            this.labAddressEmail = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtZipCode);
            this.groupBox4.Controls.Add(this.txtCity);
            this.groupBox4.Controls.Add(this.txtApartmentNumber);
            this.groupBox4.Controls.Add(this.txtBildingNumber);
            this.groupBox4.Controls.Add(this.txtStreetName);
            this.groupBox4.Controls.Add(this.labCity);
            this.groupBox4.Controls.Add(this.labZipCode);
            this.groupBox4.Controls.Add(this.labApartmentNumber);
            this.groupBox4.Controls.Add(this.labStreetName);
            this.groupBox4.Controls.Add(this.labBildingNumber);
            this.groupBox4.Font = new System.Drawing.Font("Athiti Medium", 8.999999F, System.Drawing.FontStyle.Bold);
            this.groupBox4.Location = new System.Drawing.Point(12, 199);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(728, 116);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Dane adresowe";
            // 
            // txtZipCode
            // 
            this.txtZipCode.Font = new System.Drawing.Font("Athiti", 9.75F);
            this.txtZipCode.Location = new System.Drawing.Point(131, 67);
            this.txtZipCode.Mask = "00-999";
            this.txtZipCode.Name = "txtZipCode";
            this.txtZipCode.Size = new System.Drawing.Size(183, 28);
            this.txtZipCode.TabIndex = 10;
            this.txtZipCode.TextChanged += new System.EventHandler(this.txtControlsValidate_TextChanged);
            // 
            // txtCity
            // 
            this.txtCity.Font = new System.Drawing.Font("Athiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtCity.Location = new System.Drawing.Point(433, 64);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(278, 28);
            this.txtCity.TabIndex = 11;
            this.txtCity.TextChanged += new System.EventHandler(this.txtControlsValidate_TextChanged);
            // 
            // txtApartmentNumber
            // 
            this.txtApartmentNumber.Font = new System.Drawing.Font("Athiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtApartmentNumber.Location = new System.Drawing.Point(615, 26);
            this.txtApartmentNumber.Name = "txtApartmentNumber";
            this.txtApartmentNumber.Size = new System.Drawing.Size(96, 28);
            this.txtApartmentNumber.TabIndex = 9;
            // 
            // txtBildingNumber
            // 
            this.txtBildingNumber.Font = new System.Drawing.Font("Athiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBildingNumber.Location = new System.Drawing.Point(433, 25);
            this.txtBildingNumber.Name = "txtBildingNumber";
            this.txtBildingNumber.Size = new System.Drawing.Size(86, 28);
            this.txtBildingNumber.TabIndex = 8;
            this.txtBildingNumber.TextChanged += new System.EventHandler(this.txtControlsValidate_TextChanged);
            // 
            // txtStreetName
            // 
            this.txtStreetName.Font = new System.Drawing.Font("Athiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtStreetName.Location = new System.Drawing.Point(65, 26);
            this.txtStreetName.Name = "txtStreetName";
            this.txtStreetName.Size = new System.Drawing.Size(249, 28);
            this.txtStreetName.TabIndex = 7;
            this.txtStreetName.TextChanged += new System.EventHandler(this.txtControlsValidate_TextChanged);
            // 
            // labCity
            // 
            this.labCity.AutoSize = true;
            this.labCity.Font = new System.Drawing.Font("Athiti Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labCity.Location = new System.Drawing.Point(321, 67);
            this.labCity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labCity.Name = "labCity";
            this.labCity.Size = new System.Drawing.Size(105, 25);
            this.labCity.TabIndex = 8;
            this.labCity.Text = "Miejscowość";
            // 
            // labZipCode
            // 
            this.labZipCode.AutoSize = true;
            this.labZipCode.Font = new System.Drawing.Font("Athiti Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labZipCode.Location = new System.Drawing.Point(7, 67);
            this.labZipCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labZipCode.Name = "labZipCode";
            this.labZipCode.Size = new System.Drawing.Size(117, 25);
            this.labZipCode.TabIndex = 7;
            this.labZipCode.Text = "Kod pocztowy";
            // 
            // labApartmentNumber
            // 
            this.labApartmentNumber.AutoSize = true;
            this.labApartmentNumber.Font = new System.Drawing.Font("Athiti Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labApartmentNumber.Location = new System.Drawing.Point(526, 25);
            this.labApartmentNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labApartmentNumber.Name = "labApartmentNumber";
            this.labApartmentNumber.Size = new System.Drawing.Size(84, 25);
            this.labApartmentNumber.TabIndex = 6;
            this.labApartmentNumber.Text = "Nr lokalu";
            // 
            // labStreetName
            // 
            this.labStreetName.AutoSize = true;
            this.labStreetName.Font = new System.Drawing.Font("Athiti Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labStreetName.Location = new System.Drawing.Point(7, 27);
            this.labStreetName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labStreetName.Name = "labStreetName";
            this.labStreetName.Size = new System.Drawing.Size(51, 25);
            this.labStreetName.TabIndex = 4;
            this.labStreetName.Text = "Ulica";
            // 
            // labBildingNumber
            // 
            this.labBildingNumber.AutoSize = true;
            this.labBildingNumber.Font = new System.Drawing.Font("Athiti Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labBildingNumber.Location = new System.Drawing.Point(321, 26);
            this.labBildingNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labBildingNumber.Name = "labBildingNumber";
            this.labBildingNumber.Size = new System.Drawing.Size(99, 25);
            this.labBildingNumber.TabIndex = 5;
            this.labBildingNumber.Text = "Nr budynku";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chbActive);
            this.groupBox3.Controls.Add(this.txtCreateDate);
            this.groupBox3.Controls.Add(this.txtCustomerId);
            this.groupBox3.Controls.Add(this.txtNipNumber);
            this.groupBox3.Controls.Add(this.txtCustomerName);
            this.groupBox3.Controls.Add(this.txtShortCustomerName);
            this.groupBox3.Controls.Add(this.labActive);
            this.groupBox3.Controls.Add(this.labCreateDate);
            this.groupBox3.Controls.Add(this.labNipNumber);
            this.groupBox3.Controls.Add(this.labCustomerName);
            this.groupBox3.Controls.Add(this.labShortCustomerName);
            this.groupBox3.Controls.Add(this.labCustomerId);
            this.groupBox3.Font = new System.Drawing.Font("Athiti Medium", 8.999999F, System.Drawing.FontStyle.Bold);
            this.groupBox3.ImeMode = System.Windows.Forms.ImeMode.On;
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(728, 168);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Podstawowe informacje";
            // 
            // chbActive
            // 
            this.chbActive.AutoSize = true;
            this.chbActive.Location = new System.Drawing.Point(696, 30);
            this.chbActive.Margin = new System.Windows.Forms.Padding(4);
            this.chbActive.Name = "chbActive";
            this.chbActive.Size = new System.Drawing.Size(15, 14);
            this.chbActive.TabIndex = 3;
            this.chbActive.UseVisualStyleBackColor = true;
            // 
            // txtCreateDate
            // 
            this.txtCreateDate.Enabled = false;
            this.txtCreateDate.Font = new System.Drawing.Font("Athiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtCreateDate.Location = new System.Drawing.Point(469, 23);
            this.txtCreateDate.Name = "txtCreateDate";
            this.txtCreateDate.Size = new System.Drawing.Size(124, 28);
            this.txtCreateDate.TabIndex = 2;
            // 
            // txtCustomerId
            // 
            this.txtCustomerId.Enabled = false;
            this.txtCustomerId.Font = new System.Drawing.Font("Athiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtCustomerId.Location = new System.Drawing.Point(203, 23);
            this.txtCustomerId.Name = "txtCustomerId";
            this.txtCustomerId.Size = new System.Drawing.Size(104, 28);
            this.txtCustomerId.TabIndex = 1;
            // 
            // txtNipNumber
            // 
            this.txtNipNumber.Font = new System.Drawing.Font("Athiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtNipNumber.Location = new System.Drawing.Point(203, 125);
            this.txtNipNumber.Name = "txtNipNumber";
            this.txtNipNumber.Size = new System.Drawing.Size(153, 28);
            this.txtNipNumber.TabIndex = 6;
            this.txtNipNumber.TextChanged += new System.EventHandler(this.txtControlsValidate_TextChanged);
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Font = new System.Drawing.Font("Athiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtCustomerName.Location = new System.Drawing.Point(203, 91);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(508, 28);
            this.txtCustomerName.TabIndex = 5;
            this.txtCustomerName.TextChanged += new System.EventHandler(this.txtControlsValidate_TextChanged);
            // 
            // txtShortCustomerName
            // 
            this.txtShortCustomerName.Font = new System.Drawing.Font("Athiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtShortCustomerName.Location = new System.Drawing.Point(203, 57);
            this.txtShortCustomerName.Name = "txtShortCustomerName";
            this.txtShortCustomerName.Size = new System.Drawing.Size(508, 28);
            this.txtShortCustomerName.TabIndex = 4;
            this.txtShortCustomerName.TextChanged += new System.EventHandler(this.txtControlsValidate_TextChanged);
            // 
            // labActive
            // 
            this.labActive.AutoSize = true;
            this.labActive.Font = new System.Drawing.Font("Athiti Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labActive.Location = new System.Drawing.Point(610, 23);
            this.labActive.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labActive.Name = "labActive";
            this.labActive.Size = new System.Drawing.Size(78, 25);
            this.labActive.TabIndex = 11;
            this.labActive.Text = "Aktywny";
            // 
            // labCreateDate
            // 
            this.labCreateDate.AutoSize = true;
            this.labCreateDate.Font = new System.Drawing.Font("Athiti Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labCreateDate.Location = new System.Drawing.Point(325, 23);
            this.labCreateDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labCreateDate.Name = "labCreateDate";
            this.labCreateDate.Size = new System.Drawing.Size(137, 25);
            this.labCreateDate.TabIndex = 10;
            this.labCreateDate.Text = "Data utworzenia";
            // 
            // labNipNumber
            // 
            this.labNipNumber.AutoSize = true;
            this.labNipNumber.Font = new System.Drawing.Font("Athiti Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labNipNumber.Location = new System.Drawing.Point(7, 125);
            this.labNipNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labNipNumber.Name = "labNipNumber";
            this.labNipNumber.Size = new System.Drawing.Size(37, 25);
            this.labNipNumber.TabIndex = 10;
            this.labNipNumber.Text = "NIP";
            // 
            // labCustomerName
            // 
            this.labCustomerName.AutoSize = true;
            this.labCustomerName.Font = new System.Drawing.Font("Athiti Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labCustomerName.Location = new System.Drawing.Point(7, 91);
            this.labCustomerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labCustomerName.Name = "labCustomerName";
            this.labCustomerName.Size = new System.Drawing.Size(153, 25);
            this.labCustomerName.TabIndex = 10;
            this.labCustomerName.Text = "Pełna nazwa firmy";
            // 
            // labShortCustomerName
            // 
            this.labShortCustomerName.AutoSize = true;
            this.labShortCustomerName.Font = new System.Drawing.Font("Athiti Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labShortCustomerName.Location = new System.Drawing.Point(7, 57);
            this.labShortCustomerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labShortCustomerName.Name = "labShortCustomerName";
            this.labShortCustomerName.Size = new System.Drawing.Size(180, 25);
            this.labShortCustomerName.TabIndex = 4;
            this.labShortCustomerName.Text = "Skrócona nazwa firmy";
            // 
            // labCustomerId
            // 
            this.labCustomerId.AutoSize = true;
            this.labCustomerId.Font = new System.Drawing.Font("Athiti Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labCustomerId.Location = new System.Drawing.Point(7, 23);
            this.labCustomerId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labCustomerId.Name = "labCustomerId";
            this.labCustomerId.Size = new System.Drawing.Size(125, 25);
            this.labCustomerId.TabIndex = 3;
            this.labCustomerId.Text = "Id kontrahenta";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbxAccountCurrency);
            this.groupBox2.Controls.Add(this.txtAccountNumber);
            this.groupBox2.Controls.Add(this.txtBankName);
            this.groupBox2.Controls.Add(this.labAccountNumber);
            this.groupBox2.Controls.Add(this.labAccountCurrency);
            this.groupBox2.Controls.Add(this.labBankName);
            this.groupBox2.Font = new System.Drawing.Font("Athiti Medium", 8.999999F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(12, 335);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(728, 106);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Konto bankowe";
            // 
            // cbxAccountCurrency
            // 
            this.cbxAccountCurrency.BackColor = System.Drawing.Color.White;
            this.cbxAccountCurrency.Font = new System.Drawing.Font("Athiti", 9.75F);
            this.cbxAccountCurrency.FormattingEnabled = true;
            this.cbxAccountCurrency.ItemHeight = 21;
            this.cbxAccountCurrency.Items.AddRange(new object[] {
            "PLN",
            "EUR"});
            this.cbxAccountCurrency.Location = new System.Drawing.Point(131, 61);
            this.cbxAccountCurrency.Name = "cbxAccountCurrency";
            this.cbxAccountCurrency.Size = new System.Drawing.Size(107, 29);
            this.cbxAccountCurrency.TabIndex = 14;
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.Font = new System.Drawing.Font("Athiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtAccountNumber.Location = new System.Drawing.Point(363, 61);
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.Size = new System.Drawing.Size(348, 28);
            this.txtAccountNumber.TabIndex = 14;
            this.txtAccountNumber.TextChanged += new System.EventHandler(this.txtControlsValidate_TextChanged);
            // 
            // txtBankName
            // 
            this.txtBankName.Font = new System.Drawing.Font("Athiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBankName.Location = new System.Drawing.Point(131, 27);
            this.txtBankName.Name = "txtBankName";
            this.txtBankName.Size = new System.Drawing.Size(580, 28);
            this.txtBankName.TabIndex = 12;
            this.txtBankName.TextChanged += new System.EventHandler(this.txtControlsValidate_TextChanged);
            // 
            // labAccountNumber
            // 
            this.labAccountNumber.AutoSize = true;
            this.labAccountNumber.Font = new System.Drawing.Font("Athiti Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labAccountNumber.Location = new System.Drawing.Point(245, 64);
            this.labAccountNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labAccountNumber.Name = "labAccountNumber";
            this.labAccountNumber.Size = new System.Drawing.Size(111, 25);
            this.labAccountNumber.TabIndex = 8;
            this.labAccountNumber.Text = "Numer konta";
            // 
            // labAccountCurrency
            // 
            this.labAccountCurrency.AutoSize = true;
            this.labAccountCurrency.Font = new System.Drawing.Font("Athiti Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labAccountCurrency.Location = new System.Drawing.Point(7, 61);
            this.labAccountCurrency.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labAccountCurrency.Name = "labAccountCurrency";
            this.labAccountCurrency.Size = new System.Drawing.Size(65, 25);
            this.labAccountCurrency.TabIndex = 7;
            this.labAccountCurrency.Text = "Waluta";
            // 
            // labBankName
            // 
            this.labBankName.AutoSize = true;
            this.labBankName.Font = new System.Drawing.Font("Athiti Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labBankName.Location = new System.Drawing.Point(7, 27);
            this.labBankName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labBankName.Name = "labBankName";
            this.labBankName.Size = new System.Drawing.Size(112, 25);
            this.labBankName.TabIndex = 4;
            this.labBankName.Text = "Nazwa banku";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txtPhoneNumber);
            this.groupBox6.Controls.Add(this.txtAddressEmail);
            this.groupBox6.Controls.Add(this.labPhoneNumber);
            this.groupBox6.Controls.Add(this.labAddressEmail);
            this.groupBox6.Font = new System.Drawing.Font("Athiti Medium", 8.999999F, System.Drawing.FontStyle.Bold);
            this.groupBox6.Location = new System.Drawing.Point(12, 466);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(728, 104);
            this.groupBox6.TabIndex = 11;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Dane kontaktowe";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Font = new System.Drawing.Font("Athiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtPhoneNumber.Location = new System.Drawing.Point(131, 61);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(580, 28);
            this.txtPhoneNumber.TabIndex = 16;
            this.txtPhoneNumber.TextChanged += new System.EventHandler(this.txtControlsValidate_TextChanged);
            // 
            // txtAddressEmail
            // 
            this.txtAddressEmail.Font = new System.Drawing.Font("Athiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtAddressEmail.Location = new System.Drawing.Point(131, 27);
            this.txtAddressEmail.Name = "txtAddressEmail";
            this.txtAddressEmail.Size = new System.Drawing.Size(580, 28);
            this.txtAddressEmail.TabIndex = 15;
            this.txtAddressEmail.TextChanged += new System.EventHandler(this.txtControlsValidate_TextChanged);
            // 
            // labPhoneNumber
            // 
            this.labPhoneNumber.AutoSize = true;
            this.labPhoneNumber.Font = new System.Drawing.Font("Athiti Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labPhoneNumber.Location = new System.Drawing.Point(7, 61);
            this.labPhoneNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labPhoneNumber.Name = "labPhoneNumber";
            this.labPhoneNumber.Size = new System.Drawing.Size(100, 25);
            this.labPhoneNumber.TabIndex = 7;
            this.labPhoneNumber.Text = "Nr telefonu";
            // 
            // labAddressEmail
            // 
            this.labAddressEmail.AutoSize = true;
            this.labAddressEmail.Font = new System.Drawing.Font("Athiti Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labAddressEmail.Location = new System.Drawing.Point(7, 27);
            this.labAddressEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labAddressEmail.Name = "labAddressEmail";
            this.labAddressEmail.Size = new System.Drawing.Size(113, 25);
            this.labAddressEmail.TabIndex = 4;
            this.labAddressEmail.Text = "Adres e-mail";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Athiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSave.Location = new System.Drawing.Point(537, 577);
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
            this.btnClose.Font = new System.Drawing.Font("Athiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnClose.Location = new System.Drawing.Point(644, 577);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(96, 30);
            this.btnClose.TabIndex = 18;
            this.btnClose.Text = "Wyjdź";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmCustomerDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(752, 615);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCustomerDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edycja kontrahenta";
            this.Load += new System.EventHandler(this.frmCustomerDetails_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label labStreetName;
        private System.Windows.Forms.Label labBildingNumber;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label labCustomerId;
        private System.Windows.Forms.Label labActive;
        private System.Windows.Forms.Label labCreateDate;
        private System.Windows.Forms.Label labNipNumber;
        private System.Windows.Forms.Label labCustomerName;
        private System.Windows.Forms.Label labShortCustomerName;
        private System.Windows.Forms.Label labCity;
        private System.Windows.Forms.Label labZipCode;
        private System.Windows.Forms.Label labApartmentNumber;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labAccountNumber;
        private System.Windows.Forms.Label labAccountCurrency;
        private System.Windows.Forms.Label labBankName;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label labPhoneNumber;
        private System.Windows.Forms.Label labAddressEmail;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtShortCustomerName;
        private System.Windows.Forms.TextBox txtCreateDate;
        private System.Windows.Forms.TextBox txtCustomerId;
        private System.Windows.Forms.TextBox txtNipNumber;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtApartmentNumber;
        private System.Windows.Forms.TextBox txtBildingNumber;
        private System.Windows.Forms.TextBox txtStreetName;
        private System.Windows.Forms.CheckBox chbActive;
        private System.Windows.Forms.TextBox txtAccountNumber;
        private System.Windows.Forms.TextBox txtBankName;
        private System.Windows.Forms.ComboBox cbxAccountCurrency;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtAddressEmail;
        private System.Windows.Forms.MaskedTextBox txtZipCode;
    }
}
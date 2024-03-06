using Facturosaurus.Forms.api;
using Facturosaurus.Forms.dtos;
using Facturosaurus.Forms.SubbClases;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Facturosaurus.Forms
{
    public partial class Settings : Form
    {
        AppSettings appSettings;
        FacturosaurusApi api;
        List<string> errors = new List<string>();
        List<UserDto> userListDto;
        UserRolesComboBox userRolesComboBox;

        UserRegisterDto userRegisterDto;
        UserModifyDto userModifyDto;
        UserNewPasswordDto userNewPasswordDto;

        bool addUser;
        bool modifyUser;
        bool changePassword;


        public Settings()
        {
            InitializeComponent();
            appSettings = AppSettings.GetInstance();

            if (appSettings.GetApiBaseUrl() != "")
            {
                api = new FacturosaurusApi();
                InicializeComboBoxes();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void InicializeComboBoxes()
        {
            if (api.HasConnection)
            {
                cbxEditUserActive.DataSource = YesNoComboBox.getDecisionsList();
                cbxEditUserActive.DisplayMember = "FullName";
                cbxEditUserActive.ValueMember = "Value";

                userRolesComboBox = new UserRolesComboBox();
                cbxEditUserRole.DataSource = userRolesComboBox.getRolesList();
                cbxEditUserRole.DisplayMember = "Name";
                cbxEditUserRole.ValueMember = "Id";
            }
        }

        private void txtControlsValidate_TextChanged(object sender, EventArgs e)
        {
            checkValueFromTextBox<TextBoxBase>((TextBoxBase)sender);
        }

        private List<Control> getListOfTextBoxes(Control control)
        {
            List<Control> controls = new List<Control>();

            foreach (Control c in this.Controls)
            {
                if (control.GetType() == typeof(TextBoxBase))
                {
                    controls.Add(c);
                }
                getListOfTextBoxes(control);
            }
            return controls;
        }

        private void checkValueFromTextBox<T>(T control) where T : TextBoxBase
        {
            bool notValid = false;

            switch (control.Name)
            {
                case "txtCompanyName":
                case "txtShortCompanyName":
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
                case "txtBankAccountNumber":
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
            }

            if (notValid)
            {
                control.BackColor = Color.Gainsboro;
                if (!errors.Contains(control.Name))
                    errors.Add(control.Name);
            }
            else
            {
                control.BackColor = SystemColors.Window;
                errors.Remove(control.Name);
            }
        }

        private void txtUrlApiFacturosaurus_Leave(object sender, EventArgs e)
        {
            appSettings.Param.API_BASE_URL = txtUrlApiFacturosaurus.Text;
            
            if (appSettings.Param.API_BASE_URL.Trim() != "")
            {
                if (api == null)
                    api = new FacturosaurusApi();        

                api.SetBaseAddres();
                
                if (api!=null && api.HasConnection)
                {
                    ((Control)this.tabPageCompanyDetails).Enabled = true;
                    ((Control)this.tabPageUsers).Enabled = true;

                    CompanyDetails_Load();
                    Users_Load();
                    InicializeComboBoxes();
                }
                else
                {
                    MessageBox.Show("Problem z połaczeniem do serwisu API, sprawdz podstawowy adres!");

                    ((Control)this.tabPageCompanyDetails).Enabled = false;
                    ((Control)this.tabPageUsers).Enabled = false;

                    Users_Load();
                    CompanyDetails_Load();
                }
            }
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            AppSetings_Load();
            if (api!=null && api.HasConnection)
            {
                CompanyDetails_Load();
                Users_Load();
            }
        }

        private void AppSetings_Load()
        {
            txtUrlApiFacturosaurus.Text = appSettings.GetApiBaseUrl();
            txtLogoPath.Text = appSettings.getMenuLogoPath();
            txtLogoInvoicePath.Text = appSettings.getInvoiceLogoPath();
            txtLicense.Text = appSettings.getLicence();
        }

        private void CompanyDetails_Load()
        {
            if (api.HasConnection)
            {
                var companyDetails = api.GetCurrentCompanyDetails();

                if (companyDetails != null)
                {
                    txtCompanyName.Text = companyDetails.CompanyName;
                    txtShortCompanyName.Text = companyDetails.ShortCompanyName;
                    txtNipNumber.Text = companyDetails.NipNumber;
                    txtStreetName.Text = companyDetails.StreetName;
                    txtBildingNumber.Text = companyDetails.BildingNumber;
                    txtApartmentNumber.Text = companyDetails.ApartmentNumber;
                    txtZipCode.Text = companyDetails.ZipCode;
                    txtCity.Text = companyDetails.City;
                    txtBankName.Text = companyDetails.BankName;
                    txtCurrency.Text = companyDetails.Currency;
                    txtBankAccountNumber.Text = companyDetails.BankAccountNumber;
                    txtPhoneNumber.Text = companyDetails.PhoneNumber;
                    txtAddressEmail.Text = companyDetails.AddressEmail;
                }
            }
            else
            {
                txtCompanyName.Text = "";
                txtShortCompanyName.Text = "";
                txtNipNumber.Text = "";
                txtStreetName.Text = "";
                txtBildingNumber.Text = "";
                txtApartmentNumber.Text = "";
                txtZipCode.Text = "";
                txtCity.Text = "";
                txtBankName.Text = "";
                txtCurrency.Text = "";
                txtBankAccountNumber.Text = "";
                txtPhoneNumber.Text = "";
                txtAddressEmail.Text = "";
            }
        }

        private void Users_Load()
        {
            gbModifyUser.Visible = false;

            if (api.HasConnection)
            {
                userListDto = api.GetUsersList();

                if (userListDto != null)
                {
                    userBindingSource.DataSource = userListDto;
                }
            }
            else
            {
                userBindingSource.DataSource = null;
            }
        }


        private void btnEditClose_Click(object sender, EventArgs e)
        {
            resetUserModifyBox();
        }

        private void btnEditSave_Click(object sender, EventArgs e)
        {
            if (addUser || modifyUser)
            {
                if (txtEditUserName.Text.Trim() == "")
                    MessageBox.Show("Proszę podać imię.");
                else if (txtEditUserLastName.Text.Trim() == "")
                    MessageBox.Show("Proszę podać nazwisko.");
                else if (txtEditUserEmail.Text.Trim() == "")
                    MessageBox.Show("Proszę podać adres email.");
                else if (txtEditUserPassword.Text.Trim() == "" && addUser)
                    MessageBox.Show("Proszę podać hasło.");
                else if ((txtEditUserConfirmPassword.Text.Trim() != txtEditUserPassword.Text.Trim()) && addUser)
                    MessageBox.Show("Podane hasła nie są zgodne.");
                else
                {
                    if (addUser)
                    {
                        userRegisterDto = new UserRegisterDto();

                        userRegisterDto.FirstName = txtEditUserName.Text;
                        userRegisterDto.LastName = txtEditUserLastName.Text;
                        userRegisterDto.Email = txtEditUserEmail.Text;
                        userRegisterDto.PhoneNumber = txtEditUserPhone.Text;
                        userRegisterDto.Password = txtEditUserPassword.Text;
                        userRegisterDto.ConfirmPassword = txtEditUserConfirmPassword.Text;
                        userRegisterDto.RoleId = ((Role)cbxEditUserRole.SelectedItem).Id;
                        userRegisterDto.Active = ((Decision)cbxEditUserActive.SelectedItem).Value;

                        api.RegisterUser(userRegisterDto);
                        resetUserModifyBox();
                        Users_Load();
                    }

                    if (modifyUser)
                    {
                        userModifyDto.FirstName = txtEditUserName.Text;
                        userModifyDto.LastName = txtEditUserLastName.Text;
                        userModifyDto.Email = txtEditUserEmail.Text;
                        userModifyDto.PhoneNumber = txtEditUserPhone.Text;
                        userModifyDto.RoleId = ((Role)cbxEditUserRole.SelectedItem).Id;
                        userModifyDto.Active = ((Decision)cbxEditUserActive.SelectedItem).Value;

                        api.ModifyUser(userModifyDto);
                        resetUserModifyBox();
                        Users_Load();
                    }
                };
            }
            else if (changePassword)
            {
                userNewPasswordDto = new UserNewPasswordDto()
                {
                    Id = userModifyDto.Id,
                    Password = txtEditUserPassword.Text,
                    ConfirmPassword = txtEditUserConfirmPassword.Text
                };

                api.ChangePassword(userNewPasswordDto);
                resetUserModifyBox();
                Users_Load();
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            clearModifyBox();
            addUser = true;
            setControlsInMidifyVisibility();

        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            clearModifyBox();

            modifyUser = true;
            setControlsInMidifyVisibility();

            loadUserToModify();
        }

        private void btnNewPassword_Click(object sender, EventArgs e)
        {
            clearModifyBox();

            changePassword = true;
            setControlsInMidifyVisibility();

            loadUserToModify();
        }
        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            var selectedUserDto = dgvUserList.SelectedRows[0].DataBoundItem as UserDto;

            if (selectedUserDto != null && selectedUserDto.Id != Guid.Empty) { }
            api.DeleteUser(selectedUserDto.Id);

            Users_Load();
        }

        private void loadUserToModify()
        {

            var selectedUserDto = dgvUserList.SelectedRows[0].DataBoundItem as UserDto;

            txtEditUserName.Text = selectedUserDto.FirstName;
            txtEditUserLastName.Text = selectedUserDto.LastName;
            txtEditUserEmail.Text = selectedUserDto.Email;
            txtEditUserPhone.Text = selectedUserDto.PhoneNumber;
            cbxEditUserRole.SelectedValue = userRolesComboBox.getRole(selectedUserDto.RoleName).Id;
            cbxEditUserActive.SelectedValue = selectedUserDto.Active;

            userModifyDto = new UserModifyDto()
            {
                Id = selectedUserDto.Id
            };
        }

        private void clearModifyBox()
        {
            txtEditUserName.Text = "";
            txtEditUserLastName.Text = "";
            txtEditUserEmail.Text = "";
            txtEditUserPhone.Text = "";
            cbxEditUserRole.SelectedValue = userRolesComboBox.getDefaultRole().Id;
            cbxEditUserActive.SelectedValue = ((Decision)YesNoComboBox.getDefaultDecision()).Value;
        }

        private void setControlsInMidifyVisibility()
        {
            if (addUser)
            {
                gbModifyUser.Visible = true;
                gbModifyUserDetails.Enabled = true;
                gbModifyUserPassword.Visible = true;
            }
            if (modifyUser)
            {
                gbModifyUser.Visible = true;
                gbModifyUserDetails.Enabled = true;
                gbModifyUserPassword.Visible = false;
            }
            if (changePassword)
            {
                gbModifyUser.Visible = true;
                gbModifyUserDetails.Enabled = false;
                gbModifyUserPassword.Visible = true;
            }
        }

        private void resetUserModifyBox()
        {
            gbModifyUser.Visible = false;


            userRegisterDto = null;
            userNewPasswordDto = null;
            userModifyDto = null;

            addUser = false;
            modifyUser = false;
            changePassword = false;

            txtEditUserName.Text = "";
            txtEditUserLastName.Text = "";
            txtEditUserEmail.Text = "";
            txtEditUserPhone.Text = "";
            txtEditUserPassword.Text = "";
            txtEditUserConfirmPassword.Text = "";
            cbxEditUserRole.SelectedValue = userRolesComboBox.getDefaultRole().Id;
            cbxEditUserActive.SelectedValue = YesNoComboBox.getDefaultDecision().Value;
        }

        private void btnSaveCompanyDetails_Click(object sender, EventArgs e)
        {
            if (api != null)
            {
                if (errors.Count == 0)
                {
                    var updateSuccess = api.CreateNewCompanyDetails(txtShortCompanyName.Text, txtCompanyName.Text, txtNipNumber.Text,
                        txtStreetName.Text, txtBildingNumber.Text, txtApartmentNumber.Text, txtZipCode.Text, txtCity.Text, txtBankName.Text,
                        txtCurrency.Text, txtBankAccountNumber.Text, txtPhoneNumber.Text, txtAddressEmail.Text);

                    if (updateSuccess)
                    {
                        MessageBox.Show("Dane zostały zaktualizowane.");
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Błąd aktualizacji danych.");
                    }
                }
                else
                {
                    MessageBox.Show("Proszę sprawdzić poprawność wprowadzonych danych.");
                }
            }
        }

        private void btnSaveApi_Click(object sender, EventArgs e)
        {
            appSettings.SetParams(txtLogoPath.Text,txtLogoInvoicePath.Text,txtLicense.Text);

            appSettings.ParametersSave();
            Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvUserList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            resetUserModifyBox();
        }

        private void Settings_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnChooseLogoMenu_Click(object sender, EventArgs e)
        {
            openImageFileDialog.ShowDialog(this);
            txtLogoPath.Text = openImageFileDialog.FileName;
        }

        private void btnChooseLogoInvoice_Click(object sender, EventArgs e)
        {
            openImageFileDialog.ShowDialog(this);
            txtLogoInvoicePath.Text = openImageFileDialog.FileName;
        }
    }
}




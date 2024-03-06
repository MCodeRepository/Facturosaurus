using Facturosaurus.Forms.api;
using Facturosaurus.Forms.dtos;
using Facturosaurus.Forms.Models;
using System;
using System.Windows.Forms;

namespace Facturosaurus.Forms.Forms.Menu
{
    public partial class Logging : Form
    {
        private FacturosaurusApi api;
        private AppSettings settings;
        public LoggedUser LoggedUser { get; set; }

        public Logging()
        {
            settings = AppSettings.GetInstance();
            api = new FacturosaurusApi();

            InitializeComponent();
        }

        private void Logging_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (txtAddressEmail.Text.Trim() != "")
            {
                settings.Param.DEFAULT_LOGIN = txtAddressEmail.Text.Trim();
                settings.ParametersSave();
            }
            
            if (!(this.DialogResult == DialogResult.OK))
                this.DialogResult = DialogResult.Cancel;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var token = api.Login(new LoginDto() { Email = txtAddressEmail.Text, Password = txtPassword.Text });

            if (token != "")
            {
                LoggedUser = new LoggedUser() { Token = token };
                settings.setLoggedUser(LoggedUser);

                api.setAccesToken();

                UserDto user = api.GetUser(txtAddressEmail.Text);
                if (user != null)
                {
                    LoggedUser = new LoggedUser()
                    {
                        Id = user.Id,
                        FirstName = user.FirstName,
                        LastName = user.LastName,
                        Email = user.Email,
                        PhoneNumber = user.PhoneNumber,
                        CreatedDate = user.CreatedDate,
                        Active = user.Active,
                        RoleName = user.RoleName,
                        Token = token
                    };
                    settings.setLoggedUser(LoggedUser);
                    this.DialogResult = DialogResult.OK;
                }

            }
        }

        private void Logging_Load(object sender, EventArgs e)
        {
            txtAddressEmail.Text = settings.GetDefaultLogin();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

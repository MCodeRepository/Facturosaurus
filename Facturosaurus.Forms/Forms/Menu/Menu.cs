using Facturosaurus.Forms.api;
using Facturosaurus.Forms.Forms.Menu;
using Facturosaurus.Forms.Forms.Reports;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Facturosaurus.Forms
{
    public partial class Menu : Form
    {
        FacturosaurusApi api;
        AppSettings appSettings;

        public Menu()
        {
            api = new FacturosaurusApi();
            appSettings = AppSettings.GetInstance();
            InitializeComponent();
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lblCustomers_Click(object sender, EventArgs e)
        {
            Customers frmCustomers = new Customers();
            frmCustomers.ShowDialog();
        }

        private void lblElementOfMenu_MouseHover(object sender, EventArgs e)
        {
            Label lblElementOfMenu = (Label)sender;
            lblElementOfMenu.ForeColor = Color.Black;
        }
        private void lblElementOfMenu_MouseLeave(object sender, EventArgs e)
        {
            Label lblElementOfMenu = (Label)sender;
            lblElementOfMenu.ForeColor = Color.DarkSlateGray;
        }

        private void lblInvoices_Click(object sender, EventArgs e)
        {
            Invoices invoices = new Invoices();
            invoices.Show();
        }

        private void lblSettings_Click(object sender, EventArgs e)
        {
            using (var settings = new Settings())
            {
                var result = settings.ShowDialog();
                if (result == DialogResult.OK)
                {
                    CheckApi();
                }
            }
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            CheckApi();
            lblInfo.Text = $"{appSettings.Param.LICENSE_FOR} | {appSettings.GetVersion()}";
            pbLogo.ImageLocation = appSettings.getMenuLogoPath();
        }

        private void CheckApi()
        {
            api.SetBaseAddres();
            var roleFromLoggedUser = appSettings.getRoleFromLoggedUser();

            if (api.HasConnection && roleFromLoggedUser != "")
            {

                lblCustomers.Enabled = roleFromLoggedUser.Contains("Użytkownik");
                lblInvoices.Enabled = roleFromLoggedUser.Contains("Użytkownik");
                lblJobs.Enabled = roleFromLoggedUser.Contains("Użytkownik");
                lblReports.Enabled = roleFromLoggedUser.Contains("Użytkownik");
            }
            else
            {
                lblCustomers.Enabled = false;
                lblInvoices.Enabled = false;
                lblJobs.Enabled = false;
                lblReports.Enabled = false;
            }
        }

        private void lblLogin_Click(object sender, EventArgs e)
        {

            if (!appSettings.userLogged())
            {
                using (var logging = new Logging())
                {
                    var result = logging.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        lblStatus.Text = $"Zalogowano jako: {appSettings.getLoggedUserName()}";
                        lblStatus.ForeColor = Color.Black;
                        lblLogin.Text = "Wyloguj";
                        api.setAccesToken();
                        CheckApi();
                    }
                }
            }
            else
            {
                appSettings.setLoggedUser(null);
                lblStatus.Text = "Brak zalogowanego użytkownika";
                lblStatus.ForeColor = Color.Crimson;
                lblLogin.Text = "Zaloguj";
                CheckApi();
            }
        }

        private void lblReports_Click(object sender, EventArgs e)
        {
            using (var reports = new Reports())
            {
                var result = reports.ShowDialog();
                if (result == DialogResult.OK)
                {

                }
            }
        }
    }
}

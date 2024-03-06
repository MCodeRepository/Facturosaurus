using Facturosaurus.Forms.Forms.Menu;
using Newtonsoft.Json;
using System;
using System.IO;

namespace Facturosaurus.Forms
{
    public sealed class AppSettings
    {
        private static string _version="1.0";
        private static AppSettings instance;
        private static string filePath = "AppSettings.json";
        private LoggedUser loggedUser;

        public Parameters Param { get; set; } = new Parameters() 
        { 
            API_BASE_URL = "", 
            DEFAULT_LOGIN = "",
            INVOICE_IMAGE="",
            MENU_IMAGE="",
            LICENSE_FOR = ""
        };

        private AppSettings()
        {
            CheckFile();
            ReadParametersFromFile();
        }

        public static AppSettings GetInstance()
        {
            if (instance == null)
            {
                instance = new AppSettings();
            }
            return instance;
        }

        private void CheckFile()
        {
            var fileExists = File.Exists(filePath);
            if (!fileExists)
            {
                using (File.Create(Path.Combine(filePath))) { 
                
                } ;

            }
        }

        public string GetVersion() { return _version; }

        public void ParametersSave()
        {
            var paramSerializated = JsonConvert.SerializeObject(Param);
            File.WriteAllText(filePath, paramSerializated);
        }

        private void ReadParametersFromFile()
        {
            string paramSerializated = File.ReadAllText(filePath);
            var paramFromFile = JsonConvert.DeserializeObject<Parameters>(paramSerializated);

            if (paramFromFile != null)
                Param = paramFromFile;
        }

        public string GetApiBaseUrl()
        {
            return Param.API_BASE_URL;
        }
        public string GetDefaultLogin()
        {
            return Param.DEFAULT_LOGIN;
        }

        public void setLoggedUser(LoggedUser user)
        {
            loggedUser = user;
        }

        public string getLoggedUserName()
        {
            if (loggedUser != null)
                return $"{loggedUser.FirstName} {loggedUser.LastName}";
            return "";
        }

        public Guid getLoggedUserId()
        {
            if (loggedUser != null)
                return loggedUser.Id;
            return Guid.Empty;
        }

        public string getTokenFromLoggedUser()
        {
            if (loggedUser != null)
                return loggedUser.Token;
            return "";
        }

        public string getRoleFromLoggedUser()
        {
            if (loggedUser != null)
                return loggedUser.RoleName;
            return "";
        }

        public bool userLogged()
        {
            if (loggedUser != null)
                return true;
            return false;
        }

        public void SetParams(string menuImage, string invoiceImage, string licence)
        {
            Param.MENU_IMAGE = menuImage;
            Param.INVOICE_IMAGE = invoiceImage;
            Param.LICENSE_FOR = licence;
        }

        public string getMenuLogoPath() { return Param.MENU_IMAGE; }
        public string getInvoiceLogoPath() { return Param.INVOICE_IMAGE; }
        public string getLicence() { return Param.LICENSE_FOR; }

    }

    public class Parameters
    {
        public string API_BASE_URL { get; set; }
        public string DEFAULT_LOGIN { get; set; }
        public string INVOICE_IMAGE { get; set; }
        public string MENU_IMAGE { get; set; }
        public string LICENSE_FOR { get; set; }
    }
}

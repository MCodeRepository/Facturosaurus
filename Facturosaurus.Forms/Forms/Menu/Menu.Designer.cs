using System.Drawing;

namespace Facturosaurus.Forms
{
    partial class Menu
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.label1 = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.lblReports = new System.Windows.Forms.Label();
            this.lblInvoices = new System.Windows.Forms.Label();
            this.lblJobs = new System.Windows.Forms.Label();
            this.lblCustomers = new System.Windows.Forms.Label();
            this.lblClose = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.lblSettings = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.pnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Athiti", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(22, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "FACTUROSAURUS";
            this.label1.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbLogo.Location = new System.Drawing.Point(916, 12);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(662, 693);
            this.pbLogo.TabIndex = 1;
            this.pbLogo.TabStop = false;
            // 
            // lblReports
            // 
            this.lblReports.AutoSize = true;
            this.lblReports.Font = new System.Drawing.Font("Athiti Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblReports.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblReports.Location = new System.Drawing.Point(26, 212);
            this.lblReports.Name = "lblReports";
            this.lblReports.Size = new System.Drawing.Size(92, 33);
            this.lblReports.TabIndex = 2;
            this.lblReports.Text = "Raporty";
            this.lblReports.Click += new System.EventHandler(this.lblReports_Click);
            this.lblReports.MouseLeave += new System.EventHandler(this.lblElementOfMenu_MouseLeave);
            this.lblReports.MouseHover += new System.EventHandler(this.lblElementOfMenu_MouseHover);
            // 
            // lblInvoices
            // 
            this.lblInvoices.AutoSize = true;
            this.lblInvoices.Font = new System.Drawing.Font("Athiti Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblInvoices.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblInvoices.Location = new System.Drawing.Point(26, 174);
            this.lblInvoices.Name = "lblInvoices";
            this.lblInvoices.Size = new System.Drawing.Size(90, 33);
            this.lblInvoices.TabIndex = 4;
            this.lblInvoices.Text = "Faktury";
            this.lblInvoices.Click += new System.EventHandler(this.lblInvoices_Click);
            this.lblInvoices.MouseLeave += new System.EventHandler(this.lblElementOfMenu_MouseLeave);
            this.lblInvoices.MouseHover += new System.EventHandler(this.lblElementOfMenu_MouseHover);
            // 
            // lblJobs
            // 
            this.lblJobs.AutoSize = true;
            this.lblJobs.Font = new System.Drawing.Font("Athiti Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblJobs.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblJobs.Location = new System.Drawing.Point(26, 135);
            this.lblJobs.Name = "lblJobs";
            this.lblJobs.Size = new System.Drawing.Size(96, 33);
            this.lblJobs.TabIndex = 5;
            this.lblJobs.Text = "Zlecenia";
            this.lblJobs.MouseLeave += new System.EventHandler(this.lblElementOfMenu_MouseLeave);
            this.lblJobs.MouseHover += new System.EventHandler(this.lblElementOfMenu_MouseHover);
            // 
            // lblCustomers
            // 
            this.lblCustomers.AutoSize = true;
            this.lblCustomers.Font = new System.Drawing.Font("Athiti Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCustomers.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblCustomers.Location = new System.Drawing.Point(26, 96);
            this.lblCustomers.Name = "lblCustomers";
            this.lblCustomers.Size = new System.Drawing.Size(132, 33);
            this.lblCustomers.TabIndex = 6;
            this.lblCustomers.Text = "Kontrahenci";
            this.lblCustomers.Click += new System.EventHandler(this.lblCustomers_Click);
            this.lblCustomers.MouseLeave += new System.EventHandler(this.lblElementOfMenu_MouseLeave);
            this.lblCustomers.MouseHover += new System.EventHandler(this.lblElementOfMenu_MouseHover);
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.Font = new System.Drawing.Font("Athiti Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblClose.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblClose.Location = new System.Drawing.Point(26, 366);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(87, 33);
            this.lblClose.TabIndex = 7;
            this.lblClose.Text = "Wyjście";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            this.lblClose.MouseLeave += new System.EventHandler(this.lblElementOfMenu_MouseLeave);
            this.lblClose.MouseHover += new System.EventHandler(this.lblElementOfMenu_MouseHover);
            // 
            // lblInfo
            // 
            this.lblInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Athiti Light", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblInfo.Location = new System.Drawing.Point(1397, 1033);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(0, 19);
            this.lblInfo.TabIndex = 8;
            // 
            // pnlMenu
            // 
            this.pnlMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlMenu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlMenu.Controls.Add(this.lblSettings);
            this.pnlMenu.Controls.Add(this.label1);
            this.pnlMenu.Controls.Add(this.lblReports);
            this.pnlMenu.Controls.Add(this.lblClose);
            this.pnlMenu.Controls.Add(this.lblCustomers);
            this.pnlMenu.Controls.Add(this.lblInvoices);
            this.pnlMenu.Controls.Add(this.lblJobs);
            this.pnlMenu.Location = new System.Drawing.Point(12, 627);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(370, 425);
            this.pnlMenu.TabIndex = 9;
            // 
            // lblSettings
            // 
            this.lblSettings.AutoSize = true;
            this.lblSettings.Font = new System.Drawing.Font("Athiti Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSettings.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblSettings.Location = new System.Drawing.Point(26, 251);
            this.lblSettings.Name = "lblSettings";
            this.lblSettings.Size = new System.Drawing.Size(121, 33);
            this.lblSettings.TabIndex = 8;
            this.lblSettings.Text = "Ustawienia";
            this.lblSettings.Click += new System.EventHandler(this.lblSettings_Click);
            this.lblSettings.MouseLeave += new System.EventHandler(this.lblElementOfMenu_MouseLeave);
            this.lblSettings.MouseHover += new System.EventHandler(this.lblElementOfMenu_MouseHover);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Athiti Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblStatus.ForeColor = System.Drawing.Color.Crimson;
            this.lblStatus.Location = new System.Drawing.Point(24, 34);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(248, 24);
            this.lblStatus.TabIndex = 10;
            this.lblStatus.Text = "Brak zalogowanego użytkownika";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Athiti Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblLogin.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblLogin.Location = new System.Drawing.Point(22, 1);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(88, 33);
            this.lblLogin.TabIndex = 11;
            this.lblLogin.Text = "Zaloguj";
            this.lblLogin.Click += new System.EventHandler(this.lblLogin_Click);
            this.lblLogin.MouseLeave += new System.EventHandler(this.lblElementOfMenu_MouseLeave);
            this.lblLogin.MouseHover += new System.EventHandler(this.lblElementOfMenu_MouseHover);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1590, 1061);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.pbLogo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facturosaurus";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lblReports;
        private System.Windows.Forms.Label lblInvoices;
        private System.Windows.Forms.Label lblJobs;
        private System.Windows.Forms.Label lblCustomers;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Label lblSettings;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblLogin;
    }
}


using Facturosaurus.Forms.Forms.Invoice;
using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Text;
using System.Windows.Forms;

namespace Facturosaurus.Forms.Printing
{
    public partial class InvoicePrinting : Form
    {
        Invoice invoice;
        AppSettings appSettings;
        int YLastPosition;

        public InvoicePrinting(InvoiceDto invoice)
        {
            InitializeComponent();
            this.invoice = new Invoice(invoice);

            appSettings = AppSettings.GetInstance();
            LoadInvoice();
        }

        private void LoadInvoice()
        {
            if (invoice != null)
            {
                pbLogoInvoice.ImageLocation = appSettings.Param.INVOICE_IMAGE;

                lblNumber.Text = invoice.getFullInvoiceNumber();
                lblCreateDate.Text = invoice.CreateDate.ToString("dd/MM/yyyy");
                lblExecutionDate.Text = invoice.ExecutionDate.ToString("dd/MM/yyyy");
                lblCompanyCity.Text = invoice.City;
                lblCompanyName.Text = invoice.CompanyName;
                lblCompanyNip.Text = invoice.getCompanyNipNumber();
                lblCompanyStreet.Text = invoice.getCompanyFullStreet();
                lblCompanyZipAndCity.Text = invoice.getCompanyZipAndCity();

                lblCompanyBankName.Text = invoice.BankName.ToString();

                
                StringBuilder bankAccountNumber = new StringBuilder(invoice.BankAccountNumber.ToString());

                for (int i = 2; i < bankAccountNumber.Length; i += 5)
                {
                    bankAccountNumber.Insert(i, ' ');
                }

                lblCompanyBankAccount.Text = bankAccountNumber.ToString();

                lblCustomerName.Text = invoice.CustomerName;
                lblCustomerNip.Text = invoice.getCustomerNipNumber();
                lblCustomerStreet.Text = invoice.getCustomerFullStreet();
                lblCustomerZipAndCity.Text = invoice.getCustomerZipAndCity();

                lblItemLp.Text = invoice.Items[0].OrderNumber.ToString();
                lblItemName.Text = invoice.Items[0].ItemName.ToString(); ;
                lblItemUnit.Text = invoice.Items[0].UnitDescription;
                lblItemQuantity.Text = invoice.Items[0].Quantity.ToString();
                lblItemUnitPraceRight.Text = invoice.Items[0].UnitPrice.ToString();
                lblItemNetValueRight.Text = invoice.Items[0].NetValue.ToString();
                lblItemVatRate.Text = invoice.Items[0].VatRate;
                lblItemVatValueRight.Text = invoice.Items[0].VatValue.ToString();
                lblItemGrossValueRight.Text = invoice.Items[0].GrossValue.ToString();

                lblItemAmountNetValueRight.Text = invoice.NetAmount.ToString();
                lblItemAmountVatValueRight.Text = invoice.VatAmount.ToString();
                lblItemAmountGrossValueRight.Text = invoice.GrossAmount.ToString();

                lblItemAmountGrossValue23Right.Text = invoice.GrossAmount.ToString();
                lblItemAmountNetValue23Right.Text = invoice.NetAmount.ToString();
                lblItemAmountVatValue23Right.Text = invoice.VatAmount.ToString();

                lblGrossAmount.Text = invoice.GrossAmount.ToString() + " zł";
                lblValueInWords.Text = invoice.getValueInWords();
                lblPaymentType.Text = invoice.PaymentType.Description;
                lblPaymentDate.Text = invoice.PaymentDate.ToString("dd/MM/yyyy");

                lblAuthor.Text = invoice.Author;

            }
        }

        private void btnPrint_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btnPrint, "Drukuj fakturę.");
        }

        private void Print(Panel pnl)
        {
            panel1 = pnl;
            GetPrintArea(pnl);

            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        Bitmap MemoryImage;
        Panel panel1;

        protected override void OnPaint(PaintEventArgs e)
        {
            if (MemoryImage != null)
            {
                e.Graphics.DrawImage(MemoryImage, 0, 0);
                base.OnPaint(e);
            }
        }

        public void GetPrintArea(Panel pnl)
        {
            MemoryImage = new Bitmap(pnl.Width, pnl.Height);
            Rectangle rect = new Rectangle(0, 0, pnl.Width, pnl.Height);
            pnl.DrawToBitmap(MemoryImage, new Rectangle(0, 0, pnl.Width, pnl.Height));
        }


        private void btnPrint_Click(object sender, EventArgs e)
        {
            Print(this.pnlPrint);
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            YLastPosition = 0;

            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            e.Graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            e.Graphics.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            
            GetPrintArea(panel1, e.Graphics, YLastPosition, "pnlHeader");

            foreach (var i in invoice.Items)
            {
                lblItemLp.Text = i.OrderNumber.ToString();
                lblItemName.Text = i.ItemName;
                lblItemUnit.Text = i.UnitDescription;
                lblItemQuantity.Text = i.Quantity.ToString();
                lblItemUnitPraceRight.Text = i.UnitPrice.ToString();
                lblItemNetValueRight.Text = i.NetValue.ToString();
                lblItemVatRate.Text = i.VatRate.ToString();
                lblItemVatValueRight.Text = i.VatValue.ToString();
                lblItemGrossValueRight.Text = i.GrossValue.ToString();

                GetPrintArea(panel1, e.Graphics, YLastPosition, "pnlItem");
            }

            GetPrintArea(panel1, e.Graphics, YLastPosition, "pnlFooter");
        }

        public void GetPrintArea(Panel pnl, Graphics gr, int OffsetY, string PanelName)
        {

            if (pnl.Width > 0)
            {
                //gr.PageScale = gr.VisibleClipBounds.Width / pnl.Width;
                gr.PageScale = 1;
            }

            foreach (var ctl in pnl.Controls)
            {
                if (ctl is Label)
                {
                    var lbl = (Label)ctl;

                    StringFormat stringFormat = new StringFormat();

                    int x = 0;

                    if (lbl.Name.IndexOf("Right") == -1) 
                    {
                        stringFormat.Alignment = StringAlignment.Near;
                        x = 0;
                    }
                    else
                    {
                        stringFormat.Alignment = StringAlignment.Far;
                        x = 50;
                    }

                    gr.DrawString(
                        lbl.Text,
                        lbl.Font,
                        new SolidBrush(lbl.ForeColor),
                        lbl.Location.X+x,
                        lbl.Location.Y + OffsetY,
                        stringFormat);
                }
                if (ctl is PictureBox)
                {
                    var pic = (PictureBox)ctl;

                    gr.DrawImage(pic.Image, new Rectangle(
                            pic.Location.X,
                            pic.Location.Y + OffsetY,
                            pic.Width,
                            pic.Height));

                }
                if (ctl is LineSeparator)
                {
                    var line = (LineSeparator)ctl;

                    Point startPoint = new Point(line.Location.X, line.Location.Y + 5 + OffsetY);
                    Point endPoint = new Point(startPoint.X + line.Size.Width, startPoint.Y);

                    gr.DrawLine(new Pen(new SolidBrush(line.ForeColor)), startPoint, endPoint);
                }
                
                if(ctl is Panel)
                {
                    Panel panel = (Panel)ctl;

                    if (panel.Name == PanelName)
                    {
                        YLastPosition = YLastPosition + panel.Size.Height ;

                        GetPrintArea(ctl as Panel, gr, OffsetY, PanelName);
                    }
                }
            }
        }
    }
}

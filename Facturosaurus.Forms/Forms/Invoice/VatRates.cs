using System.Collections.Generic;
using System.Linq;

namespace Facturosaurus.Forms.Forms.Invoice
{
    public static class VatRates
    {
        private static List<Vat> vatList = new List<Vat>()
        {
             new Vat() { Id = 1, Rate = 0.23m, Description = "23%" },
             new Vat() { Id = 2, Rate = 0, Description = "0%" },
             new Vat() { Id = 3, Rate = 0.08m, Description = "8%" },
        };

        public static List<Vat> getVatRatesList()
        {
            return vatList;
        }

        public static Vat getDefaultVat()
        {
            return getVat(1);
        }

        public static Vat getVat(int id)
        {
            return vatList.Where(x => x.Id == id).FirstOrDefault();
        }
    }

    public class Vat
    {
        public int Id { get; set; }
        public decimal Rate { get; set; }
        public string Description { get; set; }
    }
}

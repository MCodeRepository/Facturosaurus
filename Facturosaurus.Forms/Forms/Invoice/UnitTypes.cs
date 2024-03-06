using System.Collections.Generic;
using System.Linq;

namespace Facturosaurus.Forms.Forms.Invoice
{
    internal class UnitTypes
    {
        private static List<UnitType> unitTypesList = new List<UnitType>()
        {
             new UnitType() { Id = 1, ShortName = "szt.", FullName = "sztuki" },
             new UnitType() { Id = 2, ShortName = "godz.", FullName = "godzina" },
        };

        public static List<UnitType> getUnitTypesList()
        {
            return unitTypesList;
        }

        public static UnitType getDefaultUnitType()
        {
            return getUnitType(1);
        }

        public static UnitType getUnitType(int id)
        {
            return unitTypesList.Where(x => x.Id == id).FirstOrDefault();
        }
    }

    public class UnitType
    {
        public int Id { get; set; }
        public string ShortName { get; set; }
        public string FullName { get; set; }
    }
}

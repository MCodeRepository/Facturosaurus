using System.Collections.Generic;
using System.Linq;

namespace Facturosaurus.Forms.SubbClases
{
    internal class YesNoComboBox
    {
        private static List<Decision> decisionsList = new List<Decision>()
        {
             new Decision() { Id = 1, ShortName = "T", FullName = "Tak" , Value= true },
             new Decision() { Id = 0, ShortName = "N", FullName = "Nie" , Value = false },
        };

        public static List<Decision> getDecisionsList()
        {
            return decisionsList;
        }

        public static Decision getDefaultDecision()
        {
            return getDecision(0);
        }

        public static Decision getDecision(int id)
        {
            return decisionsList.Where(x => x.Id == id).FirstOrDefault();
        }
    }

    public class Decision
    {
        public int Id { get; set; }
        public string ShortName { get; set; }
        public string FullName { get; set; }
        public bool Value { get; set; }
    }
}

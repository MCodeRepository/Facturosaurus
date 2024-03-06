using System;
using System.Collections.Generic;
using System.Linq;

namespace Facturosaurus.Forms.Forms.Invoice
{
    public static class PaymentTypes
    {
        private static List<PaymentType> paymentTypesList = new List<PaymentType>()
            {
             new PaymentType() { Id = 1, Description = "gotówka", DaysToAddToDatePayment=0 },
             new PaymentType() { Id = 2, Description = "przelew 7 dni", DaysToAddToDatePayment=7 },
             new PaymentType() { Id = 3, Description = "przelew 14 dni", DaysToAddToDatePayment=14 },
            };

        public static List<PaymentType> getPaymentTypesList()
        {
            return paymentTypesList;
        }

        public static DateTime getPaymentDate(PaymentType paymentType, DateTime date)
        {
            return date.AddDays(paymentTypesList.Where(p => p.Id == paymentType.Id).First().DaysToAddToDatePayment).Date;
        }
    }

    public class PaymentType
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int DaysToAddToDatePayment { get; set; }
    }
}

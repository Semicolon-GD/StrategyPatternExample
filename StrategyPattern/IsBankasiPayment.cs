using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    internal class IsBankasiPayment : IPaymentService 
    {
        public bool Pay(PaymentInfo paymentOptions)
        {
            Console.WriteLine("İş Bankası ile ödeme yapıldı.");
            return true;
        }

    }
}

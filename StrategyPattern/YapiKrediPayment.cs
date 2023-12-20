using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    internal class YapiKrediPayment : IPaymentService
    {
        public bool Pay(PaymentInfo paymentOptions)
        {
            Console.WriteLine("Yapı Kredi Bankası ile ödeme yapıldı.");
            return true;
        }
    }
}

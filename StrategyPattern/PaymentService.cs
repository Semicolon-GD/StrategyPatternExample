using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    internal class PaymentService
    {
        private IPaymentService paymentService;

        public PaymentService()
        {

        }

        public PaymentService(IPaymentService paymentService)
        {
            this.paymentService = paymentService;
        }

        public void SetPaymentInfo(IPaymentService paymentInfo)
        {
            this.paymentService = paymentInfo;
        }

        public bool PayWithStrategy(PaymentInfo paymentInfo)
        {
            return paymentService.Pay(paymentInfo);
        }

    }
}

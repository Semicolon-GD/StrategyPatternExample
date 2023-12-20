using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    internal class PaymentInfo
    {
        public string CardNumber { get; set; }  
        public string CardHolderName { get; set; }
        public string ExpirationDate { get; set; }
        public string Cvv { get; set; }
        public decimal Amount { get; set; }


    }
}

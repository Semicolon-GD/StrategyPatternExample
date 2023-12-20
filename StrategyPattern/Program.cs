using System.Numerics;

namespace StrategyPattern

{
    class Program
    {

        static void Main(string[] args)
        {
            var paymentInfo =new PaymentInfo();

            paymentInfo.Cvv = "123";
            paymentInfo.CardNumber = "1241414";
            paymentInfo.ExpirationDate = "12/11";
            paymentInfo.Amount = 100;
            paymentInfo.CardHolderName = "Ali";
            

            var paymentService=new PaymentService();

            do
            {
                Console.WriteLine("Ödeme yapılacak bankayı seçiniz (1: Garanti, 2: Yapı Kredi, 3: İş Bankası)");
                var bank = Console.ReadLine();

                IPaymentService bankPaymentService = null;

                switch (bank)
                {
                    case "1":
                        bankPaymentService = new YapiKrediPayment();
                        break;
                    case "2":
                        bankPaymentService = new GarantiPayment();
                        break;
                    case "3":
                        bankPaymentService = new IsBankasiPayment();
                        break;
                    default:
                        Console.WriteLine("Geçersiz Banka Seçimi.");
                        break;
                }

                paymentService.SetPaymentInfo(bankPaymentService);
                paymentService.PayWithStrategy(paymentInfo);


            } while (Console.ReadKey().Key != ConsoleKey.Escape);


        }



    }
}
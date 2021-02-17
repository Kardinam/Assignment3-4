using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3_4.Payment
{
    public class Pay : IPay
    {
        public WayOfPayment WayOfPayment { get; set; }

        public Pay(WayOfPayment wayOfPayment)
        {
            WayOfPayment = wayOfPayment;
        }

        public void Payment()
        {
            string Way = "";

            switch (WayOfPayment)
            {
                case (WayOfPayment.Bank):
                  Way = "Bank";
                      break;
                case (WayOfPayment.Debit):
                    Way = "Credit Card";
                        break;
                case (WayOfPayment.Cash):
                    Way = "Cash";
                    break;
                default:
                    Way = "you chose not to pay";
                    break;
            }
            Console.WriteLine("you chose to pay with {0}.", Way);

        }

       
    }
}

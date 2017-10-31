using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture9Walkthrough
{
    class Program
    {
        static void Main(string[] args)
        {
            CreditCardPayment credit = new CreditCardPayment("K. Lewis", 238498234, 50);
            credit.PaymentDetails();

            CashPayment cash = new CashPayment(155.15);
            cash.PaymentDetails();

            Console.ReadKey();

        }
    }
}

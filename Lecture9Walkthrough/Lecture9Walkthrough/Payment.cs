using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture9Walkthrough
{
    class Payment
    {
        public double Amount { get; set; }

        public Payment()
        {
            Amount = 0;
        }

        public Payment(double amount)
        {
            Amount = amount;
        }

        public virtual void PaymentDetails()
        {
            Console.WriteLine("The amount of the payment is {0:C}", Amount);
        }
    }
}

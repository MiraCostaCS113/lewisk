using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture9Walkthrough
{
    class CashPayment : Payment
    {
        public CashPayment() : base()
        {
        }

        public CashPayment(double amount) : base(amount)
        {
        }

        public override void PaymentDetails()
        {
            Console.WriteLine("Cash Payment.");
            base.PaymentDetails();
        }
    }
}

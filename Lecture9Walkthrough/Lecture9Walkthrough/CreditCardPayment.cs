using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture9Walkthrough
{
    class CreditCardPayment : Payment
    {
        public string Name { get; set; }
        public long Number { get; set; }

        public CreditCardPayment() : base()
        {
            Name = "John Doe";
            Number = 1234567890;
        }

        public CreditCardPayment(string name, long number) : base()
        {
            Name = name;
            Number = number;
        }

        public CreditCardPayment(string name, long number, double amount) : this(name, number)
        {
            Amount = amount;
        }

        public override void PaymentDetails()
        {
            Console.WriteLine("Credit Card Payment");
            Console.WriteLine("Name: {0}, Number: {1}", Name, Number);
            base.PaymentDetails();
        }
    }
}

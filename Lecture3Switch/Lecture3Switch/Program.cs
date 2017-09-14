using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture3Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your vehicle type:");
            Console.WriteLine("1 - passenger");
            Console.WriteLine("2 - bus");
            Console.WriteLine("3 - truck");
            Console.WriteLine("4+ - other");

            int input = Convert.ToInt32(Console.ReadLine());
            double charge;

            switch (input)
            {
                case 1:
                    charge = 1.5;
                    break;
                case 2:
                    charge = 2.5;
                    break;
                case 3:
                    charge = 4.5;
                    break;
                default:
                    charge = 5;
                    break;
            }
            Console.WriteLine("Please pay {0:C}", charge);
            Console.ReadLine();
        }
    }
}

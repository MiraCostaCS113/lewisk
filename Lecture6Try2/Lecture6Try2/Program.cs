using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture6Try2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isGood = false;

            Console.WriteLine("Enter number between 1 and 100:");
            while (!isGood)
            {
                string strNumber = Console.ReadLine();
                int number = 0;
                try
                {
                    number = Convert.ToInt32(strNumber);
                    if (number < 0 || number >100)
                    {
                        throw new FormatException();
                    }
                    isGood = true;

                }
                catch (Exception)
                {
                    Console.WriteLine("Bad Input.\nEnter number between 1 and 100:");
                }
            }
            Console.WriteLine("All's good.");
            Console.ReadLine();
        }
    }
}

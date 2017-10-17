using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture6Fraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Fraction copyFromfraction = new Fraction(20, 60);
            Fraction fraction = new Fraction(copyFromfraction);

            Console.WriteLine(" {1}/{2} can be reduced to {0} and the value is {3}.", 
                fraction.ReducedFraction(),
                fraction.GetNumerator(),
                fraction.GetDenominator(),
                fraction.GetFractionValue());

            Console.ReadLine();
        }
    }
}

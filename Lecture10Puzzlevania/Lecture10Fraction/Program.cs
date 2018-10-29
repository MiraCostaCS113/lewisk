using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture10Fraction
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Fraction> fractionList = new List<Fraction>();
            fractionList.Add(new Fraction(10, 20)); //.5
            fractionList.Add(new Fraction(20, 10)); //2
            fractionList.Add(new Fraction(1, 8)); //.125
            fractionList.Add(new Fraction(4, 1)); //4

            Console.WriteLine("Original List ");
            foreach (Fraction f in fractionList)
            {
                Console.WriteLine(f);
            }

            fractionList.Sort();
            Console.WriteLine("Sorted List ");
            foreach (Fraction f in fractionList)
            {
                Console.WriteLine(f);
            }
            Console.ReadLine();
        }
    }
}

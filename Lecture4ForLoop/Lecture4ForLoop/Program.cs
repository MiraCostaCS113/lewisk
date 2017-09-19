using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture4ForLoop
{
    class Program
    {
        const int TOTAL_TOSS = 8;
        static void Main(string[] args)
        {
            for(int tossCount = 0; tossCount < TOTAL_TOSS; tossCount++)
            {
                Console.WriteLine("Enter heads of tails:");
                string userInput = Console.ReadLine();
            }
        }
    }
}

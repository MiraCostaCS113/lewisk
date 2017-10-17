using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture6Lab1
{
    class Program
    {
        enum CoinSide { Heads, Tails};

        const int TOTAL_FLIPS = 100000;

        static void Main(string[] args)
        {
            Random random = new Random();

            CoinSide[] flipHistory = new CoinSide[TOTAL_FLIPS];
            int numberOfHeads = 0; 

            for(int i = 0; i < TOTAL_FLIPS; i++)
            {
                flipHistory[i] = (CoinSide)random.Next(2);
                if(flipHistory[i] == CoinSide.Heads)
                {
                    numberOfHeads++;
                }
            }

            PrintFlipHistory(flipHistory, numberOfHeads);

            Console.ReadLine();
        }

        static void PrintFlipHistory(CoinSide [] flips, int heads)
        {
            for(int i = 0; i < flips.Length; i++)
            {
                //Console.WriteLine("For flip {0} we flipped a {1}.", i + 1, flips[i].ToString());
            }

            Console.WriteLine("We flipped {0} of {1} heads which is {2:P3}.", 
                heads, 
                flips.Length, 
                heads / (double)flips.Length);

            Console.WriteLine("We flipped {0} of {1} tails which is {2:P3}.",
                flips.Length - heads,
                flips.Length,
                (flips.Length - heads) / (double)flips.Length);
        }
    }
}

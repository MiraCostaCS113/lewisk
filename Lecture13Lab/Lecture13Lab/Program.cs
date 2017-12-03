using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture13Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            Handicapper handicap = new Handicapper();
            handicap.AddScore(1);
            handicap.AddScore(2);
            handicap.AddScore(3);
            handicap.AddScore(4);
            handicap.AddScore(5);
            handicap.AddScore(6);
            handicap.AddScore(7);
            handicap.AddScore(8);
            handicap.AddScore(9);
            handicap.AddScore(10);

            handicap.AddScore(11);
            handicap.AddScore(12);
            handicap.AddScore(13);
            handicap.AddScore(14);

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(handicap[i]);
            }

            Console.ReadLine();

        }
    }
}

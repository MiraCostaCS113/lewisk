using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture7Counter2
{
    class Program
    {
        static void Main(string[] args)
        {
            Counter cnt = new Counter();

            cnt.Decrement();
            cnt.Increment();

            Console.WriteLine(cnt);

            Console.ReadLine();

        }
    }
}

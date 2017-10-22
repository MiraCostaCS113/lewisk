using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture8Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            UnixTime time = new UnixTime();
            time.Seconds = -84897498;
            Console.WriteLine("Seconds: {0}", time.Seconds);

            time.Seconds = 11334243;
            Console.WriteLine("Seconds: {0}", time.Seconds);
            Console.WriteLine("Minutes: {0}", time.Minutes);
            time.Event = "Mira Costa Built.";
            Console.WriteLine("Event: {0}", time.Event);

            Console.ReadKey();
        }
    }
}

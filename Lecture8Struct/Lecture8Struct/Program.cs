using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture8Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeStruct time = new TimeStruct();
            time.Sec = 10;

            UpdateTime(time);

            Console.WriteLine("Seconds {0}", time.Sec);
            Console.ReadLine();
            
        }

        public static void UpdateTime(TimeStruct time)
        {
            time.Sec++;
        }

    }
}

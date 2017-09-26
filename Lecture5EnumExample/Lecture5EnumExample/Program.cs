using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture5EnumExample
{
    class Program
    {
        public enum DaysOfWeek { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday };

        public enum Planets
        {
            Mercury,
            Venus,
            Earth,
            Mars,
            Jupiter,
            Saturn,
            Uranus,
            Neptune,
            //Pluto, no longer a planet due to changed definition in 2006.  
        };

        static void Main(string[] args)
        {
            DaysOfWeek today = DaysOfWeek.Monday;
            

            if (today == DaysOfWeek.Monday)
            {
                Console.WriteLine("CS 155: C# ({0})", today.ToString());
            }

            today = (DaysOfWeek)5; // what day is this?

            if (today != DaysOfWeek.Monday)
            {
                Console.WriteLine("CS 155: C# ({0})", today.ToString());
            }

            Console.ReadKey();

        }

    }
}

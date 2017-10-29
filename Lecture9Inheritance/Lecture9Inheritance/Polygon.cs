using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture9Inheritance
{
    class Polygon
    {
        public int NumberOfSides { get; set; }

        public Polygon()
        {
            Console.WriteLine("Polygon constructor.");
            NumberOfSides = 0;
        }

        public Polygon(int numberOfSides)
        {
            Console.WriteLine("Polygon constructor.");
            NumberOfSides = numberOfSides;
        }
    }
}

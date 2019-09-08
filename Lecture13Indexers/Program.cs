using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture13Indexers
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector vector = new Vector(6, 9);
            Vector vector2 = new Vector(5, 6);

            Console.WriteLine("Vector add {0}", vector + vector2);

            Console.WriteLine("Index 0 is the same as X. vector[0]={0}, vector.X={1}",
                vector[0], vector.X);
            Console.WriteLine("Index 1 is the same as Y. vector[1]={0}, vector.Y={1}",
                vector[1], vector.Y);

            Console.ReadLine();
        }
    }
}

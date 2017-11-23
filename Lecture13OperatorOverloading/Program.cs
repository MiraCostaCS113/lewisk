using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture13OperatorOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector a = new Vector(5, 2);
            Vector b = new Vector(-3, 4);

            Vector result = a + b;

            Console.WriteLine("Vector A = {0}", a);
            Console.WriteLine("Vector B = {0}", b);
            Console.WriteLine("Vector result = {0}", result);

            Console.WriteLine("Scalar: {0}", a * 5);

            Console.ReadKey();
        }
    }
}

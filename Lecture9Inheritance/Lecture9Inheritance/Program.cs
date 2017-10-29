using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture9Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(5, 6);
            Console.WriteLine("Area is {0}", rectangle.Area());

            Square square = new Square(8);
            Console.WriteLine("Area is {0}", square.Area());

            Console.ReadKey();
        }
    }
}

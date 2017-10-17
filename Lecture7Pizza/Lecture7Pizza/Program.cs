using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture7Pizza
{
    class Program
    {
        static void Main(string[] args)
        {
            Pizza pizza = new Pizza();
            Pizza pizza2 = new Pizza(Size.LARGE, 2, 2, 8);

            Pizza pizza3 = new Pizza(Size.MEDIUM, -3, -5, -8);

            Console.WriteLine(pizza);
            Console.WriteLine(pizza2);
            Console.WriteLine(pizza3);

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture1Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            //   print a  message to   the screen
            Console.WriteLine("Hello out there.");
            Console.WriteLine("I will add two numbers for you.");
            Console.WriteLine("Enter one number and press enter, thenenter second number and press enter:");

            //   declare two integer variables
            int n1, n2, sum;
            int product;
            double division;
            string userInput;
            userInput =  Console.ReadLine();
            n1   =  Int32.Parse(userInput);
            n2   =  Int32.Parse(Console.ReadLine());

            //   calculate the sum of   these two numbers
            sum = n1   +  n2;
            product = n1 * n2;
            division = sum / product;
            //   print a  message along with the sum of the two numbers
            Console.WriteLine("The sum of those two numbers is");
            Console.WriteLine(sum);
            Console.WriteLine("The value ({0,-10})of the product is ", product);
            Console.WriteLine("The value of the divison is ");
            Console.WriteLine(division);
            //Just to   pause the screen.
            Console.ReadLine();
        }
    }
}

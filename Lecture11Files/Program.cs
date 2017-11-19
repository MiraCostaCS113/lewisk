using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture11Files
{
    class Program
    {
        static void Main(string[] args)
        {

            using (StreamWriter file = new StreamWriter("a.txt", false))
            {
                file.WriteLine("Hello CS 155");
                file.WriteLine("Hello World");
            }
            Console.ReadKey();



        }
    }
}

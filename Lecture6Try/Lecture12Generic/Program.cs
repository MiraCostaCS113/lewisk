using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture12Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            //PracticeList<String> myList = new PracticeList<string>();
            //PracticeList<int> myInts = new PracticeList<int>();

            //myList.Add("Hi");
            //myInts.Add(56);

            //Console.WriteLine(myList.GetItem(0));
            //Console.WriteLine(myInts.GetItem(0));

            Console.WriteLine(Average(1, 2, 3, 4));
            int[] array = { 1, 2, 3, 4 };

            Console.WriteLine(Average(array));

            Console.ReadKey();
        }

        public static double Average(params int [] numbers)
        {
            double total = 0;
            foreach (int number in numbers)
                total += number;
            return total / (double)numbers.Length;

        }
    }
}

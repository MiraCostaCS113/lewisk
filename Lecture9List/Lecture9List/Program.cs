using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture9List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> myList = new List<string>();

            myList.Add("Bashful");
            myList.Add("Awful");
            myList.Add("Jumpy");
            myList.Add("Happy");
            PrintList<string>(myList);

            myList.Insert(2, "Doc");
            PrintList<string>(myList);

            myList.Add("Dopey");
            PrintList<string>(myList);

            myList.RemoveAt(1);
            PrintList<string>(myList);

            myList[2] = "Sneezy";
            PrintList<string>(myList);

            string dwarf = myList[2];
            string dwarf2 = myList.ElementAt(2);
            Console.WriteLine("Dware = {0}, Dwarf2 = {1}", dwarf, dwarf2);

            int index = myList.IndexOf("Sneezy");
            Console.WriteLine("Index of Sneezy is {0}", index);

            index = myList.IndexOf("Jumpy");
            Console.WriteLine("Index of Jumpy is {0}", index);

            myList.Sort();
            PrintList<string>(myList);

            Console.ReadKey();
        }

        static void PrintList<T>(List<T> list)
        {
            Console.WriteLine("List Contents:");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("End of List.\n");
        }
    }
    
}

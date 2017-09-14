using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture3StringDemo1
{
    class Program
    {
        const string ENDING = "ay";
        static void Main(string[] args)
        {

            //Console.WriteLine("{0}{1}{2}{0}{1}", "A", "B", "C");


 

            Console.WriteLine("K in pig latin is {0}", PigLatin("K"));



            Console.WriteLine("LE in pig latin is {0}", PigLatin("LE"));

            Console.ReadLine();

        }

        static string PigLatin(string name)
        {
            if (name.Length == 1)
            {
                return name.ToUpper() + ENDING;
            }
            else if (name.Length == 2)
            {
                return name + ENDING;

            }
            else
            {
                name = name.ToLower();
                string firstLetter = name.Substring(0, 1);
                string secondLetter = name.Substring(1, 1).ToUpper();
                string remainderName = name.Substring(2);

                return secondLetter + remainderName + firstLetter + ENDING;
            }



        }
    }

    
}

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
            Console.WriteLine("Welcome to the Pig Latin Converter.");
            Console.WriteLine("Please enter your first name:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Please enter your last name:");
            string lastName = Console.ReadLine();

            firstName = firstName.ToLower();
            string firstLetter = firstName.Substring(0, 1);
            string secondLetter = firstName.Substring(1, 1).ToUpper();
            string remainderName = firstName.Substring(2);
            firstName = secondLetter + remainderName + firstLetter + ENDING;

            lastName = lastName.ToLower();
            string firstLastLetter = lastName.Substring(0, 1);
            string secondLastLetter = lastName.Substring(1, 1).ToUpper();
            string remainderLastName = lastName.Substring(2);
            lastName = secondLastLetter + remainderLastName + firstLastLetter + ENDING;

            Console.WriteLine("Your pig latin name is {0} {1}.", firstName, lastName);

            Console.ReadKey();

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

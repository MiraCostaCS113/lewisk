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
            string firstName = "Kevin";
            firstName = firstName.ToLower(); //make it all lowercase
            string firstLetter = firstName.Substring(0, 1); //separate out the first letter
            string secondLetter = firstName.Substring(1, 1); //separate out the second letter
            string remainderFirstName = firstName.Substring(2); //seperate out the rest of the first name

            string pigLatinFirstName = secondLetter.ToUpper() + remainderFirstName + firstLetter + ENDING;

            Console.WriteLine("Kevin in pig latin is {0}", pigLatinFirstName);

            string lastName = "Lewis";
            lastName = lastName.ToLower(); //make it all lowercase
            string firstLNLetter = lastName.Substring(0, 1); //separate out the first letter
            string secondLNLetter = lastName.Substring(1, 1); //separate out the second letter
            string remainderLasName = lastName.Substring(2); //seperate out the rest of the first name

            string pigLatinLastName = secondLNLetter.ToUpper() + remainderLasName + firstLNLetter + ENDING;

            Console.WriteLine("Lewis in pig latin is {0}", pigLatinLastName);

            Console.ReadLine();

        }
    }
}

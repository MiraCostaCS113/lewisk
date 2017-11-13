using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture11Names
{
    class Program
    {
        private const string BOYS_FILE = "boynames.txt";
        private const string GIRL_FILE = "girlnames.txt";

        static void Main(string[] args)
        {
            Dictionary<string, NameInfo> boys = readFile(BOYS_FILE);
            Dictionary<string, NameInfo> girls = readFile(GIRL_FILE);

            while (Process(boys, girls))
            {
                //run program
            }
        }

        private static Dictionary<string, NameInfo> readFile(string filename)
        {
            Dictionary<string, NameInfo> info = new Dictionary<string, NameInfo>();
            char[] delimiterChars = { ' ' };

            using (StreamReader sr = new StreamReader(filename))
            {
                string line;
                int count = 1;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] lineData = line.Split(delimiterChars);
                    NameInfo ni = new NameInfo();
                    ni.Rank = count;
                    ni.Count = Int32.Parse(lineData[1]);
                    info.Add(lineData[0].ToLower(), ni);
                    count++;
                }
            }
            return info;
        }

        private static bool Process(Dictionary<string, NameInfo> boys, Dictionary<string, NameInfo> girls)
        {
            Console.WriteLine("Enter names of child or quit to exit:");
            string input = Console.ReadLine();
            input = input.ToLower();

            if (input.Equals("quit"))
            {
                return false;
            }

            Output(input, boys, "boys");
            Output(input, girls, "girls");

            return true;
        }

        private static void Output(string name, Dictionary<string, NameInfo> dict, string gender)
        {
            NameInfo ni = null;
            if (dict.ContainsKey(name))
            {
                ni = dict[name];
            }

            if (ni == null)
            {
                Console.WriteLine("{0} is not ranked among the top 1000 {1} names.", name, gender);
            } 
            else
            {
                Console.WriteLine("{0} is ranked {1} in popularity among {2} with {3} namings.",
                    name, ni.Rank, gender, ni.Count);
            }
        }
    }
}

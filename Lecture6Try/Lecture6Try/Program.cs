using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture6Try
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] scoreList = new int[10];
            try
            {
                Console.WriteLine("We are initializing the array.");
                //let's initialize my array
                for (int i = 0; i <= 10; i++)
                {
                    scoreList[i] = 1;
                }

            }
            //this one must come after the specific ones. 
            catch (IndexOutOfRangeException e) //a specific exception
            {
                Console.WriteLine("Something bad with the array probably happened." + e);
            }
            catch (Exception e) // this is the general exception
            {
                Console.WriteLine("Something bad happened." + e);
            }
            finally
            {
                Console.WriteLine("We are done");
            }

            Console.ReadKey();
        }
    }
}

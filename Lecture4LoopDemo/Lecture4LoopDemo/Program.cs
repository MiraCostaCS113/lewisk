using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture4LoopDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int numA = 0;
            int numB = 0;
            int numC = 0;
            int numD = 0;
            int numF = 0;
            int total = 0;
            int totalGrades = 0;
            int[] grades = new int[100];

            Console.WriteLine("Enter a test score, negative to exit:");
            string strTestScore = Console.ReadLine();
            int testScore = Convert.ToInt32(strTestScore);

            while (testScore >= 0)
            {
                grades[totalGrades] = testScore;
                totalGrades++;
                total += testScore;

                if(testScore >= 90)
                {
                    numA++;
                }
                else if(testScore >= 80)
                {
                    numB++;
                }
                else if(testScore >= 70)
                {
                    numC++;
                }
                else if (testScore >= 60)
                {
                    numD++;
                }
                else
                {
                    numF++;
                }

                Console.WriteLine("Enter a test score, negative to exit:");
                strTestScore = Console.ReadLine();
                testScore = Convert.ToInt32(strTestScore);
            }

            Console.WriteLine("Total input grades: {0}", totalGrades);
            Console.WriteLine("Number of A's = {0} which is {1:P2}", numA, numA / (double)totalGrades);
            Console.WriteLine("Number of B's = {0} which is {1:P2}", numB, numB / (double)totalGrades);
            Console.WriteLine("Number of C's = {0} which is {1:P2}", numC, numC / (double)totalGrades);
            Console.WriteLine("Number of D's = {0} which is {1:P2}", numD, numD / (double)totalGrades);
            Console.WriteLine("Number of F's = {0} which is {1:P2}", numF, numF / (double)totalGrades);
            double average = total / (double)totalGrades;
            Console.WriteLine("The test average was {0}", average);

            double summation = 0;
            //standard deviation
            for(int i = 0; i < totalGrades; i++)
            {
                summation += Math.Pow(grades[i] - average, 2);
            }

            Console.WriteLine("Standard Deviation = {0}", Math.Sqrt(summation/totalGrades));


            Console.ReadLine();
        }
    }
}

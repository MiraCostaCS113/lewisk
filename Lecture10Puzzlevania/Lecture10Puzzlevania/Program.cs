using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture10Puzzlevania
{
    class Program
    {
        const int MAX_SIMULATIONS = 10000;
        static void Main(string[] args)
        {
            List<Duelist> list = new List<Duelist>();

            list.Add(new SmartDuelist("Aaron", 1 / 3.0));
            list.Add(new Duelist("Charlie", 995/1000.0));
            list.Add(new Duelist("Bob", 1 / 2.0));

            //PrintList<Duelist>(list);

            list.Sort();

            PrintList<Duelist>(list);

            //Console.WriteLine(FindDuelistToShotAt(list, list[0])); // aaron is shooter
            //Console.WriteLine(FindDuelistToShotAt(list, list[1])); // bob is shooter

            //Kill charlie and test aaron
            //list[2].Alive = false;
            //Console.WriteLine(FindDuelistToShotAt(list, list[0])); // aaron is shooter

            for (int i = 0; i < MAX_SIMULATIONS; i++)
            {
                Duelist winner = RunSimulation(list);
                winner.AddWin();
                ResetDuelers(list);
            }

            PrintList<Duelist>(list);

            Console.ReadLine();
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

        static Duelist FindDuelistToShotAt(List<Duelist> list, Duelist shooter)
        {
            Duelist target = null;
            foreach(var dueler in list)
            {
                if(dueler.Alive && !(dueler.Equals(shooter)))
                {
                    if(target != null && target.GetProbablity() < dueler.GetProbablity())
                    {
                        target = dueler;
                    }
                    else if (target == null)
                    {
                        target = dueler;
                    }
                }
            }
            return target;
        }

        static void ResetDuelers(List<Duelist> list)
        {
            foreach(var dueler in list)
            {
                dueler.Reset();
            }
        }

        static bool KeepPlaying(List<Duelist> list)
        {
            int stillAlive = 0;
            foreach(var dueler in list)
            {
                if(dueler.Alive)
                {
                    stillAlive++;
                }
            }
            return stillAlive >= 2;
        }

        static Duelist FindWinner(List<Duelist> list)
        {
            foreach(var dueler in list)
            {
                if (dueler.Alive)
                {
                    return dueler;
                }
            }
            return null;//error
        }

        static Duelist RunSimulation(List<Duelist> list)
        {
            while(KeepPlaying(list))
            {
                foreach(var dueler in list)
                {
                    if(dueler.Alive)
                    {
                        Duelist target = FindDuelistToShotAt(list, dueler);
                        if(target != null)
                        {
                            dueler.ShootAt(target);
                        }
                    }
                }
            }
            return FindWinner(list);
        }
    }
}

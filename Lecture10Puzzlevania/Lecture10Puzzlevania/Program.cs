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

            list.Add(new Duelist("Aaron", 1 / 3.0));
            list.Add(new Duelist("Charlie", 995/1000.0));
            list.Add(new Duelist("Bob", 1 / 2.0));

            //PrintList<Duelist>(list);
            #region Sort
            ///Find firing order
            list.Sort();
            PrintList<Duelist>(list);
            #endregion

            #region Simulation
            for (int i = 0; i < MAX_SIMULATIONS; i++)
            {
                Duelist winner = RunSimulation(list);
                winner.AddWin();
                ResetDuelers(list);
            }

            PrintList<Duelist>(list);
            #endregion
            Console.ReadLine();
        }

        /// <summary>
        /// Simple method for printing out lists
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        static void PrintList<T>(List<T> list)
        {
            Console.WriteLine("List Contents:");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("End of List.\n");
        }

        /// <summary>
        /// Find a duelist to shoot at
        /// </summary>
        /// <param name="list">All the duelists</param>
        /// <param name="shooter"> who is shooting</param>
        /// <returns></returns>
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

        /// <summary>
        /// Resets the duelist
        /// </summary>
        /// <param name="list"></param>
        static void ResetDuelers(List<Duelist> list)
        {
            foreach(var dueler in list)
            {
                dueler.Reset();
            }
        }

        /// <summary>
        /// Method for determining if we should keep playing
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Find the winner
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Run a simulation
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
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

        #region Test
        /* Test code
         *             //Console.WriteLine(FindDuelistToShotAt(list, list[0])); // aaron is shooter
            //Console.WriteLine(FindDuelistToShotAt(list, list[1])); // bob is shooter

            //Kill charlie and test aaron
            //list[2].Alive = false;
            //Console.WriteLine(FindDuelistToShotAt(list, list[0])); // aaron is shooter
            */
        #endregion
    }
}

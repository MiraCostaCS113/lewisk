using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture10Alien
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create some Aliens
            Predator p = new Predator(100, 16);
            Alien a = new Alien(100, 5);
            Orc o = new Orc(100, 9);

            //Create AlienPack and add aliens
            AlienPack ap = new AlienPack();
            ap.AddAlien(p);
            ap.AddAlien(a);
            ap.AddAlien(o);


            ap.SortAliens();
            ap.Print();

            p.ShealthMode = true;
            ap.SortAliens();
            ap.Print();

            Console.WriteLine("Orc GetDamage = {0}", o.GetDamage());


            Console.ReadKey();
        }



    }
}

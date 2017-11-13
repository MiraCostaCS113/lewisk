using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture10Alien
{
    class AlienPack
    {
        private List<Alien> aliens;

        public AlienPack()
        {
            aliens = new List<Alien>();
        }

        public void AddAlien(Alien newAlien)
        {
            aliens.Add(newAlien);
        }
        public List<Alien> GetAliens()
        {
            return aliens;
        }
        public int CalculateDamage()
        {
            int damage = 0;

            foreach (Alien a in aliens)
            {
                damage += a.GetDamage();
            }
            return damage;
        }

        public void Print()
        {
            Console.WriteLine("Alien List");
            foreach (Alien a in aliens)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine();
        }

        public void SortAliens()
        {
            aliens.Sort();
            aliens.Reverse();
        }

    }
}

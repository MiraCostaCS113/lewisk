using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture10Alien
{
    class Alien : IComparable
    {
        public const int MAX_HEALTH = 100;
        public int damage;
        public int health; //0 = dead, 100 = full

        public Alien(int health, int damage)
        {
            this.health = health;
            this.damage = damage;
        }

        public int CompareTo(object obj)
        {
            if (obj == null)
            {
                return 1;
            }

            Alien otherAlien = obj as Alien;
            if (otherAlien != null)
            {
                return this.GetDamage().CompareTo(otherAlien.GetDamage());
            }
            else
            {
                throw new ArgumentException("Object is not a Alien.");
            }
        }

        public virtual int GetDamage()
        {
            return damage;
        }

        public void TakeDamage(int damage)
        {
            health -= damage;
        }

        public override string ToString()
        {
            return String.Format("Alien object with damage {0}", damage);
        }
    }
}

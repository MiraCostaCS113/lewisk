using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture10Alien
{
    class Orc : Alien
    {
        public Orc(int health, int damage) : base(health, damage)
        {
        }

        public override int GetDamage()
        {
            //Orc's get a 50% damage boost if they have full health
            if(health >= Alien.MAX_HEALTH)
            {
                return (int)(base.GetDamage() * 1.5);
            }
            return base.GetDamage();
        }

        public override string ToString()
        {
            return String.Format("Orc(Alien) object with damage {0}", GetDamage());
        }
    }
}

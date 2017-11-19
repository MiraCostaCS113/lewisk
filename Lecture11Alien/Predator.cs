using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture10Alien
{
    class Predator : Alien
    {
        private bool shealthMode; 
        public bool ShealthMode
        {
            get { return shealthMode; }
            set { shealthMode = value; }       
        }

        public Predator(int health, int damage) : base(health, damage)
        {
            shealthMode = false;
        }

        public override int GetDamage()
        {
            //if invisible damage is only half
            if(shealthMode) 
            {
                return base.GetDamage() / 2;
            }
            return base.GetDamage();
        }

        public override string ToString()
        {
            return String.Format("Predator(Alien) object with damage {0}", GetDamage());
        }

    }
}

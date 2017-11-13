using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture10Puzzlevania
{
    class SmartDuelist : Duelist
    {
        private bool shotAlready;
        public SmartDuelist(string name, double probability) : base(name, probability)
        {
            shotAlready = false;
        }

        public override void ShootAt(Duelist duelist)
        {
            if (shotAlready)
            {
                base.ShootAt(duelist);
            }
            else
            {
                shotAlready = true;
            }
        }

        public override void Reset()
        {
            base.Reset();
            shotAlready = false;
        }
    }
}

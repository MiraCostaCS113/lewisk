using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture10Puzzlevania
{
    class Duelist : IComparable
    {
        public String Name { get; set; }
        public bool Alive { get; set; }

        private double probability;
        private Random random;

        private int wins;

        public Duelist(String name, double probability)
        {
            Name = name;
            SetProbablity(probability);
            Alive = true;
            random = new Random((int)(probability * DateTime.Now.Millisecond));
            wins = 0;
        }
        
        public void AddWin()
        {
            wins++;
        }

        public void SetProbablity(double probability)
        {
            if (probability <= 0)
            {
                this.probability = 0;
            }
            else if (probability >= 1.0)
            {
                this.probability = 1.0;
            }
            else
            {
                this.probability = probability;
            }
        }

        public double GetProbablity()
        {
            return this.probability;
        }

        public int CompareTo(object obj)
        {
            if (obj == null)
            {
                return 1;
            }

            Duelist otherDuelist = obj as Duelist;
            if (otherDuelist != null)
            {
                return this.probability.CompareTo(otherDuelist.probability);
            }
            else
            {
                throw new ArgumentException("Object is not a Duelist");
            }
        }

        public virtual void ShootAt(Duelist duelist)
        {
            if (random.NextDouble() < this.probability)
            {
                duelist.Alive = false;
            }
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (obj is Duelist otherDuelist)
            {
                return otherDuelist.Name == Name;
            }
            else
            {
                throw new ArgumentException("Object is not a Duelist");
            }
        }

        public virtual void Reset()
        {
            Alive = true;
        }

        public override string ToString()
        {
            return string.Format("{0} - {1:P}: Wins = {2}", Name, probability, wins);
        }
    }
}

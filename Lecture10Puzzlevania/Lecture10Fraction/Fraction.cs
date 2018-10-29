using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture10Fraction
{
    class Fraction : IComparable 
    {
        private int numerator;
        private int denominator;

        #region constructors
        //no-arg constructor
        public Fraction()
        {
            this.numerator = 0;
            this.denominator = 1;
        }

        public Fraction(int one) : this()
        {
            this.numerator = one;
        }

        public Fraction(int numerator, int denominator) : this(numerator)
        {
            setDenominator(denominator);
        }

        public Fraction(Fraction fraction)
        {
            this.numerator = fraction.numerator;
            this.denominator = fraction.denominator;
        }
        #endregion

        public void setNumerator(int numerator)
        {
            this.numerator = numerator;
        }

        public void setDenominator(int denominator)
        {
            if (denominator != 0)
            {
                this.denominator = denominator;
            }

        }

        public int getNumerator()
        {
            return this.numerator;
        }

        public int getDenominator()
        {
            return this.denominator;
        }

        public double value()
        {
            return this.numerator / (double)this.denominator;
        }

        public override string ToString()
        {
            return String.Format("{0}/{1}", this.numerator, this.denominator);
        }

        public string reduced()
        {
            return String.Format("{0}/{1}", getRNum(), getRDem());
        }

        public int gcd()
        {
            int max = numerator;
            if (denominator < max)
            {
                max = denominator;
            }

            int factor = 1;

            for (int i = 2; i <= max; i++)
            {
                if (numerator % i == 0 && denominator % i == 0)
                {
                    factor = i;
                }
            }
            return factor;
        }

        public override bool Equals(object obj)
        {
            if (obj == null && GetType() != obj.GetType())
                return false;

            Fraction f = (Fraction)obj;
            return value() == f.value();
        }

        private int getRNum()
        {
            return numerator / gcd();
        }

        private int getRDem()
        {
            return denominator / gcd();
        }

        public int CompareTo(object obj)
        {
            if (obj == null)
            {
                return 1;
            }
            Fraction otherFraction = obj as Fraction;
            if (otherFraction != null)
            {
                return this.value().CompareTo(otherFraction.value());
            }
            else
            {
                throw new ArgumentException("Object is not a Duelist");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture6Fraction
{
    class Fraction
    {
        private int _numerator;
        private int denominator;


        public Fraction()
        {
            _numerator = 1;
            denominator = 1;
        }

        public Fraction(int numerator, int denominator)
        {
            this._numerator = numerator;
            SetDenominator(denominator);
        }

        public Fraction(Fraction fraction)
            : this(fraction._numerator, fraction.denominator)
        {
            
        }

        public int GetNumerator()
        {
            return _numerator;
        }

        public int GetDenominator()
        {
            return denominator;
        }

        public void SetNumerator(int numerator)
        {
            _numerator = numerator;
        }

        public void SetDenominator(int denominator)
        {
            if (denominator == 0)
            {
                this.denominator = 1;
            }
            else
            {
                this.denominator = denominator;
            }
        }

        public double GetFractionValue()
        {
            return _numerator / (double)denominator;
        }

        public int GreatestCommonFactor()
        {
            int min = Math.Min(_numerator, denominator);
            int gcf = 1;
            for(int i = min; i > 1; i--)
            {
                if(_numerator%i == 0 && denominator%i==0)
                {
                    gcf = i;
                    break;
                }
            }
            return gcf;
        }

        public string ReducedFraction()
        {
            return String.Format("{0}/{1}", _numerator / GreatestCommonFactor(), denominator / GreatestCommonFactor());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture7Counter2
{
    class Counter
    {
        int counter;

        public int Increment()
        {
            counter++;
            return counter;
        }

        public int Decrement()
        {
            if (counter > 0)
            {
                counter--;
            }
            return counter;
        }

        public void Reset()
        {
            counter = 0;
        }

        public int GetValue()
        {
            return counter;
        }

        public override string ToString()
        {
            return string.Format("{0}", counter);
        }

        public override bool Equals(object obj)
        {
            return counter == ((Counter)obj).counter;
        }
    }
}

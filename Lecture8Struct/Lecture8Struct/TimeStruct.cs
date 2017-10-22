using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture8Struct
{
    //class TimeStruct
    struct TimeStruct
    {
        private int sec;

        public int Sec
        {
            get { return sec; }
            set { sec = value; }
        }
        public int CalcMin()
        {
            return sec / 60;
        }

    }
}

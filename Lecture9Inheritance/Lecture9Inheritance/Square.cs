using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture9Inheritance
{
    class Square : Rectangle
    {
        public Square(double size) : base(size, size)
        { //no code as Square is just the name of a special rectangle
            Console.WriteLine("Square constructor.");
        }

       
    }
}

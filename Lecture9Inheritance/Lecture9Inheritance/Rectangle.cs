using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture9Inheritance
{
    class Rectangle : Polygon
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public Rectangle(double length, double width) : base(4)
        {
            //what does base 4 do?
            Console.WriteLine("Rectangle constructor.");
            Length = length;
            Width = width;
        }

        public double Area()
        {
            return Length * Width;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture13Event
{
    class Program
    {
        static void Main(string[] args)
        {
            Point point = new Point();

            point.PointChanged += HandlePointChanged;

            Console.WriteLine("Before changing the point.");
            point.X = 3;
            Console.WriteLine("After changing the point.");

            Console.ReadKey();
        }

        public static void HandlePointChanged(object sender, EventArgs eventArgs)
        {
            //Do something intelligent when the point changes.  Perhaps redraw the GUI, or 
            //update another data structure, or anthing else you can think of. 
            Console.WriteLine("Event called.");

        }
    }
}

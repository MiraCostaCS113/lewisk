using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture6Date
{
    class Program
    {
        static void Main(string[] args)
        {
            Date birthday = new Date();

            birthday.setMonth(1);
            birthday.setDay(12);
            birthday.setYear(1995);

            Console.WriteLine(birthday.MonthString());
            
            Console.WriteLine(birthday.dateString());

            Date midterm = new Date();
            midterm.setMonth(10);
            midterm.setDay(9);
            midterm.setYear(2017);

            Console.WriteLine(midterm.dateString());

            Date final = new Date();
            final.setDate(12, 11, 2017);
            Console.WriteLine(final);

            Console.ReadLine();
        }
    }
}

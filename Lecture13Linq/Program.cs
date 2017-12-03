using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture13Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> allPeople = new List<Person>();

            allPeople.Add(new Person("Avon", "Smith", 5, 40, 60));
            allPeople.Add(new Person("Brenda", "Smith", 10, 70, 190));
            allPeople.Add(new Person("Cindy", "Smith", 15, 70, 190));
            allPeople.Add(new Person("Dany", "Smith", 20, 70, 190));
            allPeople.Add(new Person("Emily", "Smith", 25, 70, 190));
            allPeople.Add(new Person("Frank", "Smith", 28, 70, 190));
            allPeople.Add(new Person("Gale", "Smith", 30, 70, 190));
            allPeople.Add(new Person("Helga", "Smith", 56, 30, 190));
            allPeople.Add(new Person("Irma", "Smith", 67, 83, 190));
            allPeople.Add(new Person("Jasmine", "Smith", 78, 57, 190));
            allPeople.Add(new Person("Kara", "Smith", 88, 58, 190));
            allPeople.Add(new Person("Laura", "Smith", 100, 70, 190));

            IEnumerable<Person> adults = from person in allPeople
                                         where person.Age >= 18
                                         select person;
            Console.WriteLine("Printing all adults.");
            foreach (Person adult in adults)
            {
                Console.WriteLine(adult);
            }
            

            IEnumerable<Person> seniors = from person in allPeople
                                          where person.Age >= 55
                                          select person;
            Console.WriteLine("\nPrinting all seniors.");
            foreach (Person senior in seniors)
            {
                Console.WriteLine(senior);
            }

            seniors = from person in allPeople
                      orderby person.Height descending
                      where person.Age >= 55
                      select person;
            Console.WriteLine("\nPrinting all seniors from tallest to shortest");
            foreach (Person senior in seniors)
            {
                Console.WriteLine(senior);
            }

            Console.ReadKey();

        }
    }
}

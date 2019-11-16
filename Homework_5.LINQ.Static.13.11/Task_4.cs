using LINQ.HelpMaterial;
using System.Linq;
using System;

namespace Homework_5.LINQ.Static._13._11
{
    class MyLINQTask
    {
        public static void MyLINQMethod()
        {
            var myPersons = PersonsService.GetPersons();

            var sortedPersons = myPersons.Where(person => person.Age > 30).OrderByDescending(person => person.Age)/*.ThenByDescending(person => person.FirstName)*/;
            var sortedPersonsTwo = myPersons.Where(person => person.Age > 30).OrderBy(person => person.FirstName);

            Console.WriteLine("Order by ascending FirstName, age by descending and age > 30\n");
            foreach (var per in sortedPersons)
            {
                Console.WriteLine(per);
            }
            Console.WriteLine("\nOrder by ascending FirstName, wher Age > 30\n");
            foreach (var per in sortedPersonsTwo)
            {
                Console.WriteLine(per);
            }

        }
    }
}

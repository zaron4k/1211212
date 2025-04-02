using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static List<Person> persons = new List<Person>();

        static void Main()
        {
            persons.Add(new Applicant("Иван", "Петров", new DateTime(2005, 5, 20), "Физика"));
            persons.Add(new Student("Анна", "Иванова", new DateTime(2002, 3, 15), "Математика", 3));
            persons.Add(new Teacher("Олег", "Сергеев", new DateTime(1975, 7, 10), "Информатика", "Доцент", 20));

            PrintAllPersons();
            FindPersonsByAge(18, 25);
        }

        static void PrintAllPersons()
        {
            foreach (var person in persons)
            {
                person.Print();
            }
        }

        static void FindPersonsByAge(int minAge, int maxAge)
        {
            Console.WriteLine($"Люди в возрасте от {minAge} до {maxAge}:");
            foreach (var person in persons)
            {
                if (person.Age >= minAge && person.Age <= maxAge)
                {
                    person.Print();
                }
            }
        }
    }
}

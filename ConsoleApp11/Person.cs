using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    abstract class Person
    {
        protected string firstName, lastName;
        protected DateTime birthDate;

        protected Person(string firstName, string lastName, DateTime birthDate)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.birthDate = birthDate;
        }

        public string FullName => $"{firstName} {lastName}";
        public int Age => DateTime.Now.Year - birthDate.Year - (DateTime.Now < birthDate.AddYears(DateTime.Now.Year - birthDate.Year) ? 1 : 0);

        public abstract void Print();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Applicant : Person
    {
        private string faculty;

        public Applicant(string firstName, string lastName, DateTime birthDate, string faculty)
            : base(firstName, lastName, birthDate)
        {
            this.faculty = faculty;
        }

        public override void Print()
        {
            Console.WriteLine($"Абитуриент: {FullName}, Возраст: {Age}, Факультет: {faculty}");
        }
    }
}

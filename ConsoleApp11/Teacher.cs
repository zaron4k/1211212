using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Teacher : Person
    {
        private string faculty, position;
        private int experience;

        public Teacher(string firstName, string lastName, DateTime birthDate, string faculty, string position, int experience)
            : base(firstName, lastName, birthDate)
        {
            this.faculty = faculty;
            this.position = position;
            this.experience = experience;
        }

        public override void Print()
        {
            Console.WriteLine($"Преподаватель: {FullName}, Возраст: {Age}, Факультет: {faculty}, Должность: {position}, Стаж: {experience} лет");
        }
    }
}

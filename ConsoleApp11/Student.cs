using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Student : Person
    {
        private string faculty;
        private int course;

        public Student(string firstName, string lastName, DateTime birthDate, string faculty, int course)
            : base(firstName, lastName, birthDate)
        {
            this.faculty = faculty;
            this.course = course;
        }

        public override void Print()
        {
            Console.WriteLine($"Студент: {FullName}, Возраст: {Age}, Факультет: {faculty}, Курс: {course}");
        }
    }
}

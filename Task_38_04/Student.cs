using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_38_04
{
    public class Student : IComparable
    {
        public string Surname { get; private set; }
        public string Name { get; private set; }
        public string Patronymic { get; private set; }
        public string Group { get; private set; }
        public GenderOfStudents GenderOfStudents { get; private set; }
        public DateTime BirthDate { get; private set; }

        public Student(string surname, string name, string patronymic, string group, GenderOfStudents genderOfStudents, DateTime birthDate)
        {
            Surname = surname;
            Name = name;
            Patronymic = patronymic;
            Group = group;
            GenderOfStudents = genderOfStudents;
            BirthDate = birthDate;
        }

        public override string ToString()
        {
            return $"{Surname} {Name} {Patronymic} - {Group}, {GenderOfStudents}, {BirthDate}";
        }

        public string StringGenderOfStudents()
        {
            switch(GenderOfStudents)
            {
                case GenderOfStudents.Male: return"мужчина"; break;
                case GenderOfStudents.Female: return "женщина";break;
            }
            return null;
        }

        public int CompareTo(object? obj)
        {
            if (obj != null && obj is Student student)
            {
                return (Surname).CompareTo(student.Surname);
            }
            else
                throw new ArgumentException();
        }
    }
}

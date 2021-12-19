using System;
using System.Collections.Generic;
using System.Text;

namespace Person.Models
{
    public class Person1:IComparable
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }

        public Person1(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }

        public int CompareTo(object obj)
        {
            return ((Person1)obj).Age.CompareTo(this.Age);
        }
    }
}

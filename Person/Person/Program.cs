using Person.Models;
using System;

namespace Person
{
    class Program
    {
        static void Main(string[] args)
        {
            DataList<Person1> dataList = new DataList<Person1>();

            Person1 person1 = new Person1("Sadiq", "Abdullayev", 13);
            Person1 person2 = new Person1("Reshad","Qasimzade",23);
            Person1 person3 = new Person1("Elnur","Ceferov",21);
            Person1 person4 = new Person1("Esger","Esgerov",26);

            dataList.Add(person1);
            dataList.Add(person2);
            dataList.Add(person3);
            dataList.Add(person4);


        }
    }
}

using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] people = new Person[3]
            {
                new Customer
                {
                    FirstName = "Furkan"
                },
                new Student
                {
                    FirstName = "Hakan"
                },
                new Person
                {
                    FirstName = "Barış"
                }
            };

            foreach(var person in people)
            {
                Console.WriteLine(person.FirstName);
            }

            Console.ReadLine();
        }
    }

    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class Customer : Person
    {
        public string City { get; set; }
    }

    class Student : Person
    {
        public string Depertmant { get; set; }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayListOp();
            //List();

            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("book", "kitap");
            dictionary.Add("table", "tablo");
            dictionary.Add("pencil", "kalem");

            //Console.WriteLine(dictionary["table"]);

            foreach(var item in dictionary)
            {
                Console.WriteLine(item.Value);
            }

            Console.WriteLine(dictionary.ContainsKey("glass"));
            Console.WriteLine(dictionary.ContainsKey("table"));

            Console.ReadLine();
        }

        private static void List()
        {
            List<string> cities = new List<string>();
            cities.Add("Ankara");
            cities.Add("Hatay");

            List<Customer> customers = new List<Customer>();
            customers.Add(new Customer { Id = 1, FirstName = "Furkan" });
            customers.Add(new Customer { Id = 2, FirstName = "Barış" });


            var customer1 = new Customer
            {
                Id = 3,
                FirstName = "Oğuz"
            };
            customers.Add(customer1);
            customers.AddRange(new Customer[2]
            {
                new Customer{Id = 4,FirstName="Mine"},
                new Customer{Id = 5,FirstName="Eren"}
            });
            //customers.Clear();

            Console.WriteLine(customers.Contains(customer1));

            var index = customers.IndexOf(customer1);
            Console.WriteLine("Index : {0}", index);

            var index2 = customers.LastIndexOf(customer1);
            Console.WriteLine("Index : {0}", index2);

            customers.Insert(0, customer1);
            customers.Remove(customer1);

            foreach (var customer in customers)
            {
                Console.WriteLine(customer.FirstName);
            }

            var count = customers.Count;
            Console.WriteLine("Count : {0}", count);
        }

        private static void ArrayListOp()
        {
            ArrayList cities = new ArrayList();
            cities.Add("Ankara");
            cities.Add("İstanbul");

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }
        }
    }

    class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
    }
}

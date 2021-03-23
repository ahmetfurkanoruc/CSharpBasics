using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            Customer customer = new Customer();
            customer.City = "Ankara";
            customer.Id = 1;
            customer.FirstName = "Furkan";
            customer.LastName = "Oruç";

            Customer customer2 = new Customer
            {
                Id = 2,
                City = "İstanbul",
                FirstName = "Barış",
                LastName = "Uğur"
            };

            Console.WriteLine(customer2.FirstName);

            Console.ReadLine();
        }
    }


}

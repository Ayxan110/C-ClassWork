using System;
using System.Collections.Generic;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer
            {
                Name = "Aykhan",
                Surname = "Dadashov",
                Credits = new List<Credit> { new Credit { Date = "6 months", Amount = 15000 } }
            };

            Customer customer1 = (Customer)customer.Clone();

            foreach (Credit item in customer.Credits)
            {
                Console.WriteLine($"{customer.Name} {customer.Surname} {item.Amount} {item.Date}");
            }
            foreach (Credit item in customer1.Credits)
            {
                Console.WriteLine($"{customer1.Name} {customer1.Surname} {item.Amount} {item.Date}");
            }

            Console.ReadLine();
        }
    }
}

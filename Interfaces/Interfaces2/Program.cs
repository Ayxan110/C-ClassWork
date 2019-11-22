using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces2
{
    class Program
    {
        static void Main(string[] args)
        {
            Customers customers1 = new Customers();

            List<Customer> customers = customers1.GetAllCustomers();
            customers.Sort(new OrderByAmount());
            foreach(Customer custom in customers)
            {
                Console.WriteLine(custom);
            }
            Console.ReadLine();
        }
    }
}

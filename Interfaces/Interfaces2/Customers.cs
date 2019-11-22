using Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Interfaces2
{
    class Customers : IEnumerable
    {
        public List<Customer> AllCustomers;
        public Customers()
        {
            AllCustomers = new List<Customer>
            {
                new Customer
                {
                    Name = "Fuad",
                    Surname = "Melikov",
                    Credits = new List<Credit>
                    {
                        new Credit
                        {
                            Amount = 14000,
                            Date = "2 year"
                        },
                    }
                },
                new Customer
                {
                    Name = "Ayxan",
                    Surname = "Dadashov",
                    Credits = new List<Credit>
                    {
                        new Credit
                        {
                            Amount = 11000,
                            Date = "1 year"
                        }
                    }
                },
            };
        }

        public List<Customer> GetAllCustomers()
        {
            return AllCustomers;
        }

        public IEnumerator GetEnumerator()
        {
            return AllCustomers.GetEnumerator();
        }
    }
}

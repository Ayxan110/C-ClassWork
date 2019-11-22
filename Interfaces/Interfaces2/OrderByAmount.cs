using System.Collections.Generic;
using Interfaces;

namespace Interfaces2
{
    internal class OrderByAmount : IComparer<Customer>
    {
        public int Compare(Customer x, Customer y)
        {
            if (x.GetAmounts() > y.GetAmounts())
                return 1;
            else if (x.GetAmounts() > y.GetAmounts())
                return -1;
            else
                return 0;
        }
    }
}
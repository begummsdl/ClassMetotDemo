using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void CustomerList(Customer[] customers)
        {
            Console.WriteLine("Customer List:");
            foreach (var customer in customers)
            {
                Console.WriteLine("Id: {0}  Firstname: {1}  LAstname: {2}", customer.Id, customer.Firstname, customer.Lastname);
            }
        }
        public void CustomerAdd(Customer customer)
        {
            Console.WriteLine("{0} {1} added!", customer.Firstname, customer.Lastname);
        }
        public void CustomerDelete(Customer customer)
        {
            Console.WriteLine("{0} {1} deleted!", customer.Firstname, customer.Lastname);
        }
    }
}

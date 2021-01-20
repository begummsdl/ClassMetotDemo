using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer
            {
                Id = 1,
                Firstname = "Begüm",
                Lastname = "Muşdal"
            };
            Customer customer2 = new Customer
            {
                Id = 2,
                Firstname = "Begüm",
                Lastname = "Ünal"
            };
            Customer[] customers = new Customer[] { customer1, customer2 };

            CustomerManager customerManager = new CustomerManager();
            customerManager.CustomerList(customers);
            customerManager.CustomerAdd(customer1);
            customerManager.CustomerDelete(customer2);

            Console.ReadLine();
        } 
    }
}

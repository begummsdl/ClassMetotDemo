using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer()
            {
                Id = 1,
                Firstname = "Begüm",
                Lastname = "Muşdal"
            };
            Customer customer2 = new Customer()
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
        class Customer
        {
            public int Id { get; set; }
            public string Firstname { get; set; }
            public string Lastname { get; set; }
        }
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
}

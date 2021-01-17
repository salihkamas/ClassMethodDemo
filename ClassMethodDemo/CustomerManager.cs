using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine($"Customer Added! : {customer.Name} {customer.LastName}");
        }
        public void Listing(Customer[] customers)
        {
            foreach (Customer customer in customers)
            {
                Console.WriteLine($"{customer.Name} {customer.LastName} \nAge: {customer.Age} \nId : {customer.IdNo}");
                Console.WriteLine("-------------------------------------------------------------------------");
            }
        }
        public void Delete(Customer customer)
        {
            Console.WriteLine($"Customer Deleted! : {customer.Name} {customer.LastName}");
        }

    }
}

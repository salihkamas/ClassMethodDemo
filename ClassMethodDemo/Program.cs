using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Name = "Salih";
            customer1.LastName = "Kamaş";
            customer1.IdNo = "11111111111";
            customer1.Age = 22;

            Customer customer2 = new Customer();
            customer2.Name = "Mehmet";
            customer2.LastName = "İkincil";
            customer2.IdNo = "22222222222";
            customer2.Age = 33;


            Customer customer3 = new Customer();
            customer3.Name = "Ahmet";
            customer3.LastName = "Üçüncül";
            customer3.IdNo = "33333333333";
            customer3.Age = 44;

            Customer[] customers = new Customer[] { customer1, customer2, customer3 };

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Listing(customers);
            customerManager.Delete(customer3);
        }
    }
}

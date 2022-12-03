using System;

namespace ClassesMethodDemo
{
    class Program
    {
        public static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Name = "Ali";
            customer1.Surname = "Kaya";
            CustomerManager customerManager1 = new CustomerManager();
            customerManager1.Delete(customer1);
            customerManager1.CustomerList(customer1);
         
            Console.ReadLine();

        }
    }
}

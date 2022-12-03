using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesMethodDemo
{
    internal class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine($"Müşteri eklendi :{customer.Name}");
        }
       public void Delete(Customer customer)
        {
            Console.WriteLine($"Müşteri silindi : { customer.Name}");
        }
       public void CustomerList(Customer customer)
        {
            Customer[] customers = new Customer[] { customer };
            foreach (Customer client in customers)
            {
               Console.WriteLine($"Müşterinin adı:{client.Name}");

               Console.WriteLine($"Müşterinin soyadı: { client.Surname}");
            }
        }

    }
}

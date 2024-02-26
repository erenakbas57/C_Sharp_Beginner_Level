using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLar
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.Id = 1;
            customer.FirstName = "Eren";
            customer.LastName = "Akbas";

            Customer customer2 = new Customer
            {
                Id = 2,
                FirstName = "Eren",
                LastName = "Akbas"
            };
            

            Console.WriteLine(customer.FirstName);

            customer.Add();

            Console.ReadLine();
        }
    }

    class Customer
    {
        public int Id { 
            get{
                return Id;
            } 
            set{
                Id = value;
            } }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    
        public string Add()
        {
            return "Customer Added!";
        }

        public string Update()
        {
            return "Customer Updated!";
        }

        public string Delete()
        {
            return "Customer Deleted!";
        }

    }

}


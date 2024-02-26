using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterFaces
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonManager personManager = new PersonManager();

            Student student = new Student
            {
                Id = 1,
                FirstName = "eren",
                LastName = "akbaş",
                Department = "Software"
            };

            Customer customer = new Customer
            {
                Id = 2,
                FirstName = "süleyman",
                LastName = "demirbaş",
                Address = "istanbul"
            };
            
            personManager.Add(student);
            personManager.Add(customer);

            Console.ReadLine();
        }

        public interface IPerson //interface soyuttur.
        {
            int Id { get; set; }
            string FirstName { get; set; }
            string LastName { get; set; }
        }

        class Student : IPerson
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Department { get; set; }
        }

        class Customer : IPerson
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Address { get; set; }
        }

        class PersonManager 
        {
            public void Add(IPerson person) // interface'den implemente edilmiş bir nesne gönderilebilir.
            {
                Console.WriteLine(person.FirstName);
            }
        }
 
    }
}

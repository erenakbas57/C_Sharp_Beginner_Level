using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // customer nesnesini tanımladık
            Customer customer = new Customer();
            customer.City = "istanbul";

            //person sınıfını tanımladık dizi olarak.
            Person[] people = new Person[]
            {
                new Student(),new Customer(),new Person()
            };


            //      İNTERFACE VE İNHERİTANCE FARKLARI
            /*
            interface tek başına bir anlam ifade etmez.  ama class lar ifade eder.
            sadece bir class miras alınabilir. ama birden fazla interface kullanılabilir.

            VIRTUAL örneği de var.
            */
        }
    }
    
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string  LastName { get; set; }

        public virtual void Save() // virtual metotlar override edilebilir.
        {
            Console.WriteLine("Person saved");
        }
    }

    class Customer : Person
    {
        public string City { get; set; }

        public override void Save() // virtual olduğu için override ettik ve ekrana customer saved yazdırdık.
        {
            Console.WriteLine("Customer saved");
        }
    }

    class Student : Person
    {
        public string Department { get; set; }

        public override void Save()
        {
            Console.WriteLine("Student saved");
        }
    }
}

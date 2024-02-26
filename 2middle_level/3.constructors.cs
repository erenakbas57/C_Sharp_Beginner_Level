using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            /*1.ÖRNEK*/
            CustomerManager customer = new CustomerManager(10); // 10 verilmezse default 5 alır
            customer.List();

            /*2.ÖRNEK : nesne örnekleri için*/
            Product product = new Product(2,"laptop"); // 2 ve laptop verilmezse default 0 ve null alır
            Console.WriteLine(product);

            /*CONSTRUCTOR İNJECTİON*/
            /*normal property ile*/
            EmployeeManager employeeManager = new EmployeeManager(); // constructor parametre almadığı için boş bırakılır.
            employeeManager.logger = new DatabaseLogger();
            employeeManager.Add();

            /*constructor ile*/
            Employee1Manager employee1Manager = new Employee1Manager(new DatabaseLogger()); // constructor parametre alır.
            employee1Manager.Delete();


            /*BASE CLASS İLE PARAMETRE YOLLAMAK*/
            PersonManager personManager = new PersonManager("Prophet");
            // constructor fonksiyonu Base contsructor fonksiyonunu çağırır. Base çalışı rsonra PersonManager çalışır.
            personManager.Add();

            Console.ReadLine();
        }
    }

    /*1.ÖRNEK*/
    class CustomerManager
    {
        private int _count=5;

        public CustomerManager(int count)
        {
            _count = count;

        }
        public void List()
        {
            Console.WriteLine("Listed {0}",_count);
        }
    }

    /*2.ÖRNEK : nesne örnekleri için*/
    class Product
    {
        int _id;
        string _name;
        public Product(int id,string name)
        {
            _id = id;
            _name = name;
        }
        public int Id { get; set; }
        public string Name { get; set; }

    }

    /*CONSTRUCTOR İNJECTİON*/
    interface ILogger
    {
        void Log();
    }

    class DatabaseLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to Database");
        }
    }

    class FileLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to File");
        }
    }

    /*normal property ile*/
    class EmployeeManager
    {
        public  ILogger logger { get; set; }
        public void Add()
        {
            logger.Log();
            Console.WriteLine("Add!");
        }
    }

    /*constructor ile*/
    class Employee1Manager
    {
        private ILogger _logger;
        public Employee1Manager(ILogger logger)
        {
            _logger = logger;
        }
        public void Delete()
        {
            _logger.Log();
            Console.WriteLine("Deleted!");
        }
    }



    /*base class ile*/
    class Base
    {
        private string _entity;
        public Base(string entity)
        {
            _entity = entity;
        }
        public void Message()
        {
            Console.WriteLine("{0} message",_entity);
        }
    }

    class PersonManager:Base
    {
        public PersonManager(string entity):base(entity)
        {

        }
        public void Add()
        {
            Console.WriteLine("PersonManager completed!");
            Message();
        }
    }
}

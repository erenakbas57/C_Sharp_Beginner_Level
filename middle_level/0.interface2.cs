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
            // interface tek başına bir anlam ifade etmez.
            // interface'ler new'lenemez.
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new SqlServerDal());

            
            ICustomer[] customers = new ICustomer[2]
            {
               new SqlServerDal(),
               new OracleServerDal()
            };

            Console.ReadLine();
        }

        interface ICustomer
        {
            void Add();
            void Update();
            void Delete();

        }

        class SqlServerDal : ICustomer
        {
            public void Add()
            {
                Console.WriteLine("SQL added");
            }

            public void Delete()
            {
                Console.WriteLine("SQL deleted");
            }

            public void Update()
            {
                Console.WriteLine("SQL updated");
            }
        }

        class OracleServerDal : ICustomer
        {
            public void Add()
            {
                Console.WriteLine("ORACLE added");
            }

            public void Delete()
            {
                Console.WriteLine("ORACLE deleted");
            }

            public void Update()
            {
                Console.WriteLine("ORACLE updated");
            }
        }
        
        class CustomerManager
        {
            public void Add(ICustomer customer)
            {
                customer.Add();
            }
        }
    }
    
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            // abstract class içinde abstract metodu yaparsak, başka sınıfa miras verildiğinde override olmak zorunda.
            // abstract class nesne örneği oluşturulamaz.

            Database sql = new Sql();
            sql.Delete();

            Oracle oracle = new Oracle();
            oracle.Delete();

                
            Console.ReadLine();
        }
    }
    
    abstract class Database
    {
        public void Add()
        {
            Console.WriteLine("added by default");
        }

        public abstract void Delete(); // override edebilmek için sınıfında abstract olması gerekiyor.
    }

    class Sql : Database
    {
        public override void Delete()
        {
            Console.WriteLine("deleted by Sql");
        }
    }

    class Oracle : Database
    {
        public override void Delete()
        {
            Console.WriteLine("deleted by Oracle");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reference_AndValueType
{
    class Program
    {
        static void Main(string[] args)
        {
            /DEĞER TİP/
            int number1 = 10;
            int number2 = 20;
            number2 = number1; // number2 "10" değerini aldı
            number1 = 30; // burada sadece number1 değişti. 

            Console.WriteLine(number2);

            /* değişken değeri                referans değeri             */
            string[] cities1 = new string[] { "ankara", "adana", "afyon" };// örnek değer 101
            string[] cities2 = new string[] { "bursa","burdur","balıkesir"};// örnek değer 102 ve 101 oluyor referans değer
            cities2 = cities1;
            cities1[0] = "istanbul";
            // ankara , istanbul'a dönüştü  ve iki değişkeninde referans değeri 101 olduğu için ankara istanbul a dönüştü.
            //cities2 değişkeninin referans değeri olan b harfli şehirler iptal oluyor.

            foreach (var cities in cities2)
            {
                Console.WriteLine(cities);
            }
            Console.ReadLine();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriTipleri
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 1;
            // int tam sayı değerleri alır. 4 byte

            long number1 = 1111111111111111111;
            // long 19 karakterli sayılara kadar yazabilir. 8 byte

            short number2 = 32767;
            // short kıa değerler alır. 32 bine kadar. 2 byte

            byte number3 = 255;
            // byte 0-255 arası değer alır. 1 byte

            bool deger = default;
            // true ya da false değer alır.

            char character = 'A';
            // sadece unicode karakterler yazılır.

            double number4 = 4.2;
            // ondalıklı sayılarda atanır.

            decimal number5 = 85.4m;
            // sonuna m koymak lazım. ondalıklı sayılar geniş sayı aralığı.

            string yazı = "eren";

            var sayi1 = 3;
            var yazii = "eren";
            var onda = 3.4;

            Console.WriteLine(gunler.perşembe);

            Console.ReadLine();
        }

        enum gunler
        {
            pazartesi,salı,çarsamba,perşembe,cuma,cumartesi,pazar
        }
    }
}

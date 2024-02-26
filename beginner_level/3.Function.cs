using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodlar
{
    class Program
    {
        static void Main(string[] args)
        {
            write("eren");

            write(topla(5, 8).ToString());

            plus();

            write((5,5).ToString());
            read();
        }

        static void write(string metin)
        {
            Console.WriteLine(metin);
        }

        static void read()
        {
            Console.ReadLine();
        }

        static int topla(int x, int y)
        {
            int toplam = x + y;
            return toplam;
        }

        static void plus(int toplam=1, int a = 1, int b = 0)
        {
            // b default parametredir. değer verilmezse 0 olur.

            Console.Write("1. SAYI GİRİNİZ : ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. SAYI GİRİNİZ : ");
            b = Convert.ToInt32(Console.ReadLine());
            toplam = a + b;
            Console.WriteLine("toplamı : " + toplam);
        }

        static int multiply(int a, int b)
        {
            return a * b;
        }
        //  metodu aşırı yüklenmedir.
        static int multiply(int a, int b, int c)
        {
            return a * b * c;
        }
    }
}


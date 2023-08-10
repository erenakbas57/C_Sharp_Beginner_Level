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
            yaz("eren");

            yaz(topla(5, 8).ToString());

            toplama();

            yaz(çarp(5,5).ToString());
            oku();
        }

        static void yaz(string metin)
        {
            Console.WriteLine(metin);
        }

        static void oku()
        {
            Console.ReadLine();
        }

        static int topla(int x, int y)
        {
            int toplam = x + y;
            return toplam;
        }

        static void toplama(int toplam=1, int a = 1, int b = 0)
        {
            // b default parametredir. değer verilmezse 0 olur.

            Console.Write("1. SAYI GİRİNİZ : ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. SAYI GİRİNİZ : ");
            b = Convert.ToInt32(Console.ReadLine());
            toplam = a + b;
            Console.WriteLine("toplamı : " + toplam);
        }

        static int çarp(int a, int b)
        {
            return a * b;
        }
        // çarp metodu aşırı yüklenmedir.
        static int çarp(int a, int b, int c)
        {
            return a * b * c;
        }
    }
}


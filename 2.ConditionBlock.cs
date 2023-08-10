using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SartBloklari
{
    class Program
    {
        static void Main(string[] args)
        {
            #region İF-ELSE
            int sayi;
            Console.Write("sayı giriniz = ");
            sayi = Convert.ToInt32(Console.ReadLine());

            if (sayi > 10)
            {
                Console.WriteLine("sayı 10'dan büyüktür");
            }
            else if (sayi == 10)
            {
                Console.WriteLine("sayı 10'a eşittir");
            }
            else
            {
                Console.WriteLine("sayı 10'dan küçüktür");
            }
            #endregion

            #region IÇ IÇE IF
            int sayi2;
            Console.Write("sayı giriniz : ");
            sayi2 = Convert.ToInt32(Console.ReadLine());

            if (sayi2<100&&sayi2>0)
            {
                if (sayi2<100&&sayi2>=90)
                {
                    Console.WriteLine("sayı 90-100 arasındadır.");
                }
                else if (sayi2 < 90 && sayi2 >= 80)
                {
                    Console.WriteLine("sayı 80-90 arasındadır");
                }
                else
                    Console.WriteLine("sayı 0-80 arasındadır");
            }
            #endregion

            #region SWITCH
            double sayi1;
            Console.WriteLine("sayı giriniz : ");
            sayi1 = Convert.ToDouble(Console.ReadLine());

            switch (sayi1)
            {
                case 10:
                    Console.WriteLine("10");
                    break;
                case 0:
                    Console.WriteLine("0");
                    break;
                default:
                    Console.WriteLine("sayı 10 ya da o değildir");
                    break;
            }
            #endregion


            Console.ReadLine();
        }
    }
}

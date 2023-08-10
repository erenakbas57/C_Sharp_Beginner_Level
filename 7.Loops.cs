using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            #region FOR DÖNGÜSÜ

            // 1'den 100'e kadar döner
            /*
            for (int i = 1; i <=100; i++)
            {
                Console.WriteLine(i);
            }
            */


            //1-N arasında kullanıcıdan değer alarak bölünebilen ve bölünemeyen bulma 
            /*
            Console.Write("1'den başlayıp kaça kadar gitsin ? = ");
            int son = Convert.ToInt32(Console.ReadLine());

            Console.Write("kaça bölünsün ? = ");
            int bolum = Convert.ToInt32(Console.ReadLine());

            int bolunebilen = 0, bolunemeyen = 0;
            for (int i = 1; i <= son; i++)
            {
                if (i % bolum == 0)
                {
                    Console.WriteLine("-->{0} sayısı {1} tam bölünür. ", i, bolum);
                    bolunebilen++;
                }
                else
                {
                    Console.WriteLine("{0} sayısı {1} tam bölünmez. ", i, bolum);
                    bolunemeyen++;
                }
            }
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("*************************************");
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("{0} tam bölünebilen {1} sayı bulundu", bolum, bolunebilen);
            Console.WriteLine("{0} tam bölünemeyen {1} sayı bulundu", bolum, bolunemeyen);
            */


            //1-100 arası 5'e bölünebilen ve bölünemeyen sayıları bulma
            /*
            for (int i = 1; i <= 100; i++)
            {
                if (i % 5 == 0)
                {
                    Console.WriteLine("{0}, 5'e tam bölünür.", i);
                }
                else
                {
                    Console.WriteLine("{0}, 5'e tam bölünmez.", i);
                }
            }
            */


            //20'den 1'e doğru giden döngü
            /*
            for (int i = 20; i > 0; i--)
            {
                Console.WriteLine(i);
            }
            */


            //3 yerine hediye kazandınız yazan program
            /*
            for (int i = 1; i <= 100; i++)
            {
                if (i != 3)
                {
                    Console.WriteLine("değer : {0}", i);
                }
                else
                {
                    Console.WriteLine("hediye kazandınız");
                }
            }
            */

            //1-10 arası
            /*
            int deger;
            Random rastgele = new Random();
            int sayi = rastgele.Next(1, 10);
            Console.Write("1-10 arası sayı giriniz : ");
            deger = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < 10; i++)
            {
                if (deger==sayi)
                {
                    Console.WriteLine("kazandınız");
                    break;
                }
                else
                {
                    Console.WriteLine("yanlış sayı. maalesef kaybettiniz.");
                    break;
                }
            }
            */



            #endregion

            #region WHİLE DÖNGÜSÜ

            /*
            int deger = 1;
            while (deger<=100)
            {
                Console.WriteLine(deger);
                deger++;
            }
            */


            //1-N arasında kullanıcıdan değer alarak bölünebilen ve bölünemeyen bulma
            /*
            Console.Write("1'den başlayıp kaça kadar gitsin ? = ");
            int son = Convert.ToInt32(Console.ReadLine());

            Console.Write("kaça bölünsün ? = ");
            int bolum = Convert.ToInt32(Console.ReadLine());

            int i = 1;
            int bolunebilen = 0, bolunemeyen = 0;
            while (i <= son)
            {
                if (i % bolum == 0)
                {
                    Console.WriteLine("-->{0} sayısı {1} tam bölünür. ", i, bolum);
                    bolunebilen++;
                }
                else
                {
                    Console.WriteLine("{0} sayısı {1} tam bölünmez. ", i, bolum);
                    bolunemeyen++;
                }
                i++;
            }
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("*************************************");
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("{0} tam bölünebilen {1} sayı bulundu", bolum, bolunebilen);
            Console.WriteLine("{0} tam bölünemeyen {1} sayı bulundu", bolum, bolunemeyen);
            */




            #endregion

            #region DO-WHİLE DÖNGÜSÜ
            // döngü çalışmasa bile "do" ilk yazıldığı için bir defa çalışır.
            /*
            int deger = 1;
            do
            {
                Console.WriteLine(deger);
                deger++;
            } while (deger<=10);
            */

            #endregion

            #region FOREACH
            //diziler ve listelerde kullanılır.
            /*
            int[] dizi = new int[10] { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19 };
            foreach (var d in dizi)
            {
                Console.WriteLine(d);
            }
            */

            #endregion


            #region continue ve break komutları
            //döngülerin içinde kullanılır.

            //continue komutu
            /*
            for (int i = 0; i <= 10; i++)
            {
                if (i < 9)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
            Console.WriteLine("döngü bitti ");
            */

            //break komutu
            /*
            int x = 0;
            for (; ; )
            {
                Console.Write("sayı giriniz : ");
                x = Convert.ToInt32(Console.ReadLine());
                if (x == 0)
                {
                    break;
                }
                if (x == 5)
                {
                    Console.WriteLine("5'e tam bölünebilen bir sayıdır.");
                }
            }
            Console.WriteLine("döngü bitti");
            */

            #endregion

            

            Console.ReadLine();
        }
    }
}

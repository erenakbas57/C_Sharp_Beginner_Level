using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Params
{
    class Program
    {
        static void Main(string[] args)
        {
            //PARAMS
            // params değeri metodlarda gireceğimiz değişken değerini bilmediğimiz zaman kullanılır. (va_lsit mantığı gibi düşünebiliriz.)
             

            yaz(topla(1,5,8,8).ToString());

            Console.Read();
        }

        static int topla(params int[] sayilar)
        {
            int toplam = 0;

            foreach (int sayi in sayilar)
            {
                toplam = toplam + sayi;
            }

            return toplam;
        }
    }
}

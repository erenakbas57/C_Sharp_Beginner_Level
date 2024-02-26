using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. dizi örneği
            string[] dizi = new string[3];
            dizi[0] = "eren";
            dizi[1] = "ömer";
            dizi[2] = "ali";

            //2. dizi örneği
            string[] ogrenci = new []{ "eren", "ömer", "ali" };

            //3.dizi örneği
            int[] sayilar = { 1, 3, 5, 7, 9 };

            //4.dizi örneği
            string[] diziler = new string[3] { "eren", "ömer", "ali" };


            #region 2 BOYUTLU DİZİLER
            string[,] sehirler = new string[2, 3];
            sehirler[0, 0] = "istanbul";
            sehirler[0, 1] = "gaziosmanpaşa";
            sehirler[0, 2] = "fatih";
            sehirler[1, 0] = "bursa";
            sehirler[1, 1] = "kestel";
            sehirler[1, 2] = "nilüfer";


            string[,] sehir = new string[2, 3]
            {
                {"aziz", "ali" , "ahmet"},
                {"eren", "erdem", "eslem"}
            };

            #endregion

            #region 3 BOYUTLU DİZİLER
            int[,,] ucboyut;

            int[,,] ucde = new int[4, 2, 2];

            int[,,] ucd = {
                            { {1,2}   , {3,4}   },
                            { {5,6}   , {7,8}   },
                            { {9,10}  , {11,12} },
                            { {13,14} , {15,16} }
                          };

            ucd[0, 0, 0] = 10;
            ucd[0, 0, 1] = 20;
            ucd[0, 1, 0] = 30;
            ucd[0, 1, 1] = 40;
            ucd[1, 0, 0] = 50;
            ucd[1, 0, 1] = 60;
            ucd[1, 1, 0] = 70;
            ucd[1, 1, 1] = 80;
            //9 değerinden sonra normal devam edecek çünkü değer atamadık.


            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    for (int k = 0; k < 2; k++)
                    {
                        Console.WriteLine(ucd[i, j, k]);
                    }
                }
            }
            #endregion

            #region DÜZENSİZ DİZİLER
            int[][] duzensiz = {
                                new int[] {1,2,3,4,5,6,7,8,9},
                                new int[] {10,20,30,40,50},
                                new int[] {11,22,33},
                                new int[] {99}
                               };

            foreach (var jagged in duzensiz)
            {
                foreach (var i in jagged)
                {
                    Console.Write(i);
                    Console.Write(" ");
                }
                Console.WriteLine();

            }
            #endregion

            Console.ReadLine();
        }
    }
}

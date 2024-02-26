using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefVeOut
{
    class Program
    {
        static void Main(string[] args)
        {
            //Normally
            int bir = 10;
            Console.WriteLine("girmeden önce : " + bir);
            Normally(bir);
            Console.WriteLine("girdikten sonra : " + bir);
            //işlemde değeri kopyaladığı için çıkınca da 10 değeri kaldı.
            Console.WriteLine("*******************************");


            //REF değerli
            int iki = 10;
            Console.WriteLine("girmeden önce : " + iki);
            Reference(ref iki);
            Console.WriteLine("girdikten sonra : " + iki);
            // işlemde ref değerini kullanarak y'nin referansını aldık. 20 değeri çıktı.
            // değer REF'e gitmeden önce değer atanması zorunludur.
            Console.WriteLine("*******************************");


            //OUT değerli
            int uc = 10;
            Console.WriteLine("girmeden önce : " + uc);
            Out(out uc);
            Console.WriteLine("girdikten sonra : " + uc);
            // işlemde out değerini kullanarak z'nin referansını aldık. 2 değeri çıktı.
            
            Console.Read();
        }
        
        static void Normally(int x)
        {
            x = x * 2;
        }

        static void Reference(ref int y)
        {
            y = y * 2;
        }

        static void Out(out int z)
        {
            z = 2;
        }
    }
}

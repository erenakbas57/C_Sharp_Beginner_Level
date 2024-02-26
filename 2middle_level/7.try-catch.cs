using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            // TEMEL HATA AYIKLAMA 

            #region BASIC EXCEPTION HANDLING
            try
            {
                string[] students = new string[2] { "eren", "mahmut" };
                students[2] = "mehmet"; // index sınırını aştık
            }
            catch(IndexOutOfRangeException exception) // sınırı aşarsa buraya girecek
            {
                Console.WriteLine(exception.Message);
            }
            catch (Exception exception)  // exception genel sınıfını verdiğimiz için diğer tüm hatalar buraya düşer
            {
                Console.WriteLine(exception.Message);
            }

            #endregion


            // KENDİ HATA SINIFIMIZI OLUŞTURMAK

            #region CUSTOM EXCEPTION

            try
            {
                Find();
            }
            catch (RecordNotFoundException exception)
            {
                Console.WriteLine(exception.Message);
            }

            #endregion


            //  ACTİON DELEGASYONU
            /*
                1- Action delegasyonu geriye değer döndürmeyen metotları temsil eder.
                2- Action delegasyonu parametre alabilir.
                3- Action delegasyonu geriye değer döndürmez.

                *** 4- Fonksiyon içine fonksiyon göndermek için kullanılır.
            */
            HandleException(() =>
            {
                Find(); // handleexception içine find metotunu gönderdik
                // Find fonksiyonu çalışacak. 
                // devamında HandleException içindeki kodlar çalışacak. (yani try-catch bloğu) 
            });


            Console.ReadLine();

        }



        private static void HandleException(Action action)
        {
            try
            {
                action.Invoke();
            }
            catch (Exception exception )
            {
                Console.WriteLine(exception.Message);
            }
        }



        private static void Find()
        {
            List<string> student = new List<string> { "eren", "ömer", "ali", "cengiz" };

            if (!student.Contains("ahmet"))
            {
                throw new RecordNotFoundException("kayıt bulunamadı");
            }
            else
            {
                Console.WriteLine("kayıt bulundu");
            }
        }



        class RecordNotFoundException : Exception
        {
            public RecordNotFoundException(string message) : base(message)
            {

            }
        }
    }
}
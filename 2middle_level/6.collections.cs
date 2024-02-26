using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {

            /* NON-GENERIC COLLECTIONS
                1- farklı türlerdeki verilerin bir arada saklanabildiği koleksiyon türü.
                2- tür güvenliği sağlamazlar ve içerdikleri öğeleri object türünde tutarlar.
                3- içerisindeki verinin elde edilip kullanılabilmesi için boxing/unboxing işlemine tabii tutulur.
                4- System.collection namespace'sinde yer alırlar. eklemek gerekir.

                5- boxing/unboxing işlemi yaparlar. (yabi değer tipi referans(obje) tipine dönüştürme işlemi)
            */
            #region NONE GENERIC COLLECTIONS
            

                    /* ARRAYLIST
                        1- System.Collection namespace'inde yer alır.
                        2- ArrayList sınıfı, object türünde veri saklar.
                        3- Add, Remove, RemoveAt, Insert, IndexOf, Contains, Clear, Sort, Reverse gibi metotları bulunur.
                        4- Kapasitesi otomatik olarak artar.

                        *** 5- Her tür veriyi alabilir. (int, double, string vs)
                    */
                    #region ARRAYLIST
                    
                    ArrayList cities = new ArrayList();
                    cities.Add("istanbul");
                    cities.Add(1);
                    cities.Add(5.2);

                    foreach (var city in cities)
                    {
                        //Console.WriteLine(city);
                    }
                    cities.Add("ankara");

                    ArrayList kullanici = new ArrayList()
                    {
                        {"eren" },
                        {"ali" },
                        {"ahmet" }
                    };

                    #endregion


                    /* HASHTABLE
                        1- Key-Value anahtar çifti şeklinde saklar.
                        2- FILO (First In Last Out) mantığı ile çalışır.
                        3- DictionaryEntry sınıfı ile içerisindeki verilere erişim sağlanır.
                    */
                    #region HASHTABLE

                    Hashtable hash = new Hashtable();
                    hash.Add("key", "value");
                    hash.Add(42, "forty two");


                    foreach (DictionaryEntry hashs in hash)
                    {
                        Console.WriteLine(hashs.Key);
                    }
                    
                    #endregion


                    /* SORTEDLIST
                        1- Anahtarlar otomatik olarak sıralanır.
                        2- Key-Value anahtar çifti şeklinde saklar.
                        
                    */
                    #region SORTEDLIST

                    SortedList sortedList = new SortedList();
                    sortedList.Add("b", "second");
                    sortedList.Add("a", "first");
                    
                    #endregion


                    /* STACK
                        1-  FILO (First In Last Out) mantığı ile çalışır.
                        2- Push, Pop, Peek gibi metotları bulunur.
                    */
                    #region STACK

                    Stack stack = new Stack();
                    stack.Push("first");
                    stack.Push("second");
                    object topItem = stack.Pop(); // "second"
                    
                    #endregion


            #endregion


            /* GENERIC COLLECTIONS
                1- System.Collections.Generic içinde yer alır.
                2- veriler obje olarak değil, DEĞİŞKEN TÜRÜ şeklinde alınırlar.
            
                3- Generic koleksiyonlar, kodun daha okunabilir, esnek ve güvenli 
                   olmasını sağlar çünkü koleksiyonun türü derleme zamanında 
                   belirlenir ve böylece tür uyumluluğu ve güvenliği sağlanır.
            */
            #region GENERIC COLLECTIONS

                    /* LIST
                        1- List<T> sınıfı, belirli bir türdeki verileri saklamak için kullanılır.
                        2- Add, Remove, RemoveAt, Insert, IndexOf, Contains, Clear, Sort, Reverse gibi metotları bulunur.
                        3- Kapasitesi otomatik olarak artar.
                    */
                    #region LIST<TYPE>

                    List<string> cities1 = new List<string>();
                    cities1.Add("istanbul");
                    cities1.Add("adana");
                    cities1.Add("ankara");

                    for (int i = 0; i < cities1.Count; i++)
                    {
                        //Console.WriteLine(cities1[i]);
                    }

                    //KENDİ SINIFIMIZ OLAN NESNE LİSTESİ
                    List<Customer> customers = new List<Customer>();
                    customers.Add(new Customer { Id = 3, Name = "eren" });

                    foreach (var item in customers)
                    {
                        //Console.WriteLine(item.Id + " " + item.Name);
                    }

                    #endregion


                    /* DICIONARY
                        1- Key-Value anahtar çifti şeklinde saklar.
                        2- Anahtarlar benzersiz olmalıdır ve her anahtara karşılık gelen bir değeri tutar.
                    */
                    #region DICTIONARY<TKEY, TVALUE>

                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    dictionary.Add("table","tablo");
                    dictionary.Add("computer","bilgisayar");

                    Console.WriteLine(dictionary["table"]); // tablo değerini yazdı.

                    Dictionary<int, string> kullanici1 = new Dictionary<int, string>
                    {
                        {1,"eren" },
                        {2, "ali" }
                    };

                    #endregion


                    /* HASHSET<TYPE>
                        1- Benzersiz öğeleri depolar, yani aynı öğeyi birden fazla kez içeremez.
                        2- Elemanlar ekleme, çıkarma ve içerik sorgulama gibi hızlı işlemler sunar.
                        3- Elemanlar sırasız olarak depolanır.
                    */
                    #region HASHSET<TYPE>

                    HashSet<int> uniqueNumbers = new HashSet<int>();
                    uniqueNumbers.Add(10);
                    uniqueNumbers.Add(20);
                    uniqueNumbers.Add(10); // Tekrar eden öğe, eklenmez

                    foreach (int number in uniqueNumbers)
                    {
                        // Console.WriteLine(number); // Çıktı: 10, 20
                    }

                    #endregion

                    
                    /* QUEUE<TYPE>
                        1- FIFO (First In First Out) mantığı ile çalışır.
                        2- Enqueue, Dequeue, Peek gibi metotları bulunur.
                        3- Kuyruğun başı ve sonu ile işlem yapılabilir.
                    */
                    #region QUEUE<TYPE>

                    Queue<string> queue = new Queue<string>();
                    queue.Enqueue("first");
                    queue.Enqueue("second");
                    string frontItem = queue.Dequeue(); // "first"

                    #endregion

                    /* STACK<TYPE>
                        1- LIFO (Last In First Out) mantığı ile çalışır.
                        2- Push, Pop, Peek gibi metotları bulunur.
                        3- Yığının en üstündeki öğe ile işlem yapılabilir.
                    */
                    #region STACK<TYPE>

                    Stack<int> stack = new Stack<int>();
                    stack.Push(10);
                    stack.Push(20);
                    int topItem = stack.Pop(); // 20

                    #endregion

            #endregion



            #region METHODS
            List<int> sayilar = new List<int>();
            sayilar.Add(3); // eleman ekleme

            customers.AddRange(new Customer[2] {
                new Customer{Id=1, Name="ahmet"},
                new Customer{Id=2, Name="ali"}
            });// toplu eleman ekleme

            int eleman = sayilar.Count;// eleman sayısı bulma

            sayilar.Clear(); // tüm elemanları temizler.

            Console.WriteLine(cities1.Contains("ankara")); // arama yapar. true ya da false döner.

            var index = sayilar.IndexOf(3);
            Console.WriteLine(index);

            #endregion
            Console.ReadLine();
        }

    }

    class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
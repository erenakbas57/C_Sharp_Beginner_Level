namespace StaticClass
{
    class Program
    {
        static void Main(string[] args)
        {
            // Statik sınıfın üyesine doğrudan erişim.
            Teacher.Number = 3;

            // Statik yöntem doğrudan çağrılır.
            Ornek.Static();

            // Statik olmayan yöntem, sınıfın örneği üzerinden çağrılır.
            Ornek ornek = new Ornek();
            ornek.NoStatic();

            Console.Read();
        }
    }

    /*
    1- Statik sınıflar genellikle yardımcı işlevler veya yardımcı yöntemler içerir.
    2- Statik sınıfların bir örneği oluşturulamaz ve her zaman statik üyeler içerir.
    3- Statik sınıflar genellikle hizmetleri sağlamak için kullanılır.
    */
    static class Teacher
    {
        public static int Number { get; set; }
    }
    /*  Statik Üyeler (Static Members):
        1- Bir sınıfın veya yapının üyesi "static" olarak işaretlenebilir.
        2- Statik üyeler, sınıfın örneği oluşturulmadan erişilebilir.
        3- sınıf örneği oluşturulmadan önce bellekte oluşturulur.
        4- Bir sınıfın statik üyeleri, sınıfın kendisine aittir. Yani, bir sınıfın tüm örnekleri tarafından paylaşılır
    */
    class Ornek
    {
        public void NoStatic()
        {
            Console.WriteLine("nesne örneği üretilen NoStatic.");
        }

        /*
        1- Static fonksiyonlar sınıfın örneği oluşturulmadan çağrılabilir.
        */
        public static void Static()
        {
            Console.WriteLine("direk sınıf çağırarak yazıldı Static.");
        }
    }
}

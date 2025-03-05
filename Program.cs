using System;

namespace ConsoleApp {

    class Program {

        static void Main(string[] args) {

            // Burada int , float , long , double ve bunlar gibi araçların olma sebepleri sadece ondalık ya da tam sayı yazabilelim diye değildir bunlar
            // aynı zaman da yer kaplarlar ve kullanılabilecekleri sayı aralığı da değişkenlik gösterir en fazla sayı aralığına decimal sahiptir fakat boyutu
            // da öbürlerinden daha büyüktür bu gözetilerek yazılmalıdır.

            // Tam Sayı (byte,short,int,long)
            int sayi = 10;
            int sayi2 = 20;

            long sayi3 = 50; 
            short sayi4 = 5;
            byte sayi5 = 10;

            // Ondalıklı Sayı
            float a = 10.5f; // C# da float bir değer yazarken sonuna "f" konur.
            double b = 20.6;
            decimal c = 100.56m; // C# da decimal bir değer yazarken sonuna "m" konur.

            // Karakter
            // ( String değerde söz dizileri vardır, Char'da ise tek harf girilir ve tek tırnak ile girilir. )
            string name = "Çınar Özgürgil";
            char ch = 'b'; // Burada bu şekilde tek tırnak kullanılır

            // Boolean
            bool isRetired = true;
            bool isActive = false;


            Console.WriteLine(sayi);
            System.Console.WriteLine(sayi2);

            // UYGULAMA

            byte kilo = 78;
            string plaka = "35 AC 5553";
            long km = 128500;
            int id = 123123;
            bool isActiva = false;
            int Maaş = 100500;
            string ad = "Çınar";
            string soyad = "Özgürgil";
            char şubekodu = 'A';



        }
    }
}

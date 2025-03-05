using System;

namespace ConsoleApp {

    class Program {

        static void Main(string[] args) {

            // Burada int , float , long , double ve bunlar gibi araçların olma sebepleri sadece ondalık ya da tam sayı yazabilelim diye değildir bunlar
            // aynı zaman da yer kaplarlar ve kullanılabilecekleri sayı aralığı da değişkenlik gösterir en fazla sayı aralığına decimal sahiptir fakat boyutu
            // da öbürlerinden daha büyüktür bu gözetilerek yazılmalıdır.

            // Tam Sayı
            int sayi = 10;
            int sayi2 = 20;

            long sayi3 = 50;
            short sayi4 = 5;
            byte sayi5 = 10;

            // Ondalıklı Sayı
            float a = 10.5f; // C# da float bir değer yazarken sonuna "f" konur.
            double b = 20.6;
            decimal c = 100.56m; // C# da decimal bir değer yazarken sonuna "m" konur.

            Console.WriteLine(sayi);
            System.Console.WriteLine(sayi2);
        }

    }

}

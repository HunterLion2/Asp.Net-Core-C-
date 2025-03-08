using System;
using System.Globalization;

namespace ConsoleApp
{

    class Program
    {

        static void Main(string[] args)
        {

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

            //                                  --------------------------- Veri Tipi Dönüşümü ------------------------------------


            // Burada yazılan write değerinin writeLine'dan farkı write değeri geldikten sonra aşşağıya satır kaymamasıdır.


            // implicit casting (automatically): smaller type to larger [Yani aslında bu 32-bit'i 64-bit'e çevirmedir].

            int ö = 10;
            long ü = ö;

            float e = 10.5f;
            double f = e;

            // explicit casting (manually): larger type to smaller [ Bu da 64-bit'i 32-bit'e dönüştürmedir fakat bu atama yapılırken aşşağıda olduğu (int)c ile c int'e çevrilir.]
            // Fakat bu şekilde işlem yaparken veri kaybı olduğu için burada çıkacak sonuç 32-bit'in karşılıyabildiği max değerdir.

            // long c = 10;
            // int d = (int)c;

            double g = 10;
            float h = (float)g;

            double k = 10.5;
            int l = (int)k;

            // int to string

            int x = 10;
            string z = x.ToString(); // Stringe dönüştürme bu şekilde olur.

            Console.WriteLine(l);


            Console.Write("1.sayı: ");
            int sayi1 = int.Parse(Console.ReadLine()); // Buradaki int.Parse() olayı ise Console.ReadLine()'dan gelen string ifadeyi int değerine döndürür.

            Console.Write("2.sayı: ");
            // int sayi2 = int.Parse(Console.ReadLine());

            int toplam = sayi2 + sayi1;
            Console.WriteLine($"Girilen Toplam Değer: {toplam}"); // $ işaretini kullanmazsal o zaman içerisine int değerini yazamazdık.



            //                                             ---------------------- UYGULAMA --------------------------

            Console.Write("Dikdörtgen Kısa: ");
            int dikdörtgen_kısa = int.Parse(Console.ReadLine());

            Console.Write("Dikdörtgen Uzun: ");
            int dikdörtgen_uzun = int.Parse(Console.ReadLine());


            // Bu şekilde var değeri de yazılabilir yani bir sayı değeri belirtmeye gerek yoktır.
            var alan = dikdörtgen_kısa * dikdörtgen_uzun;
            var cevre = (dikdörtgen_kısa + dikdörtgen_uzun) * 2;

            // Console.WriteLine("alan: " + alan + " " + "çevre: " + cevre);
            Console.WriteLine($"alan: {alan} çevre: {cevre}");

            //                                          ----------------------- DATE-TİME -------------------------

            // Date-Time Bilgisi ile zaman bilgileri alınır Now ile şuan ki zaman bilgisi alınır.

            string[] aylar = { "Ocak", "Şubat", "Mart", "Nisan", "Mayıs", "Haziran", "Temmuz", "Ağustos", "Eylül", "Ekim", "Kasım", "Aralık" };
            DateTime simdi = DateTime.Now;

            Console.WriteLine(simdi);
            Console.WriteLine(simdi.Year); // Şimdiki zamanın yıl bilgisini getirir.
            Console.WriteLine(simdi.Month);
            Console.WriteLine(aylar[simdi.Month - 1]);
            Console.WriteLine(simdi.Day);
            Console.WriteLine(simdi.DayOfWeek); // Getirdiği günden hangi gün olduğunu belirtir
            Console.WriteLine(simdi.Hour);
            Console.WriteLine(simdi.Minute);
            Console.WriteLine(simdi.Second);

            DateTime dt = new DateTime(2025, 3, 8, 12, 46, 21);

            // Add Metodu ile ekleme ve çıkarma yapabiliriz zamana
            DateTime dt1 = dt.AddDays(2);
            DateTime dt2 = dt.AddYears(1);
            DateTime dt3 = dt.AddHours(-5);

            var fark = simdi - dt;

            // Total değerleri ile toplam günü saati yada başka bir değeri getirtebiliriz.
            Console.WriteLine(fark.TotalDays);
            Console.WriteLine(fark.TotalHours);


            // Burada ToString'in içerisine yazdığımız değerler sayesinde istediğimiz tarih bilgisini getirtebiliriz.
            Console.WriteLine(simdi);
            Console.WriteLine(simdi.ToString("d"));
            Console.WriteLine(simdi.ToString("D"));
            Console.WriteLine(simdi.ToString("F"));
            Console.WriteLine(simdi.ToString("M"));
            Console.WriteLine(simdi.ToString("t"));
            Console.WriteLine(simdi.ToString("T"));
            Console.WriteLine(simdi.ToString("Y"));

            Console.WriteLine(simdi.ToString("hh:mm:ss"));

            // Burada yazdığım değerler zamanın nasıl getiriliceğini burada belirtmiş oluruz.
            Console.WriteLine(simdi.ToString("ddd MMM %d, yyyy"));

            CultureInfo culture = new CultureInfo("en"); // Burada hangi dildi olucağını belirttik en yani ingilizce
            Console.WriteLine(simdi.ToString("F", culture)); // ToString de ilk önce formatı belirtilir sonrasında o formatın uygulanacağı değer yazılır.


            //                                  -------------------- Aritmatik Operatörler -----------------------

            // 1- Aritmetik Operatörler (+,-,*,/,%,++,--) 
            // Burada % işareti işlemin kalanını bize getirir teklik çiftlik olaylarında kullanılır..


            // 2- Atama Operatörleri (=,+=,-=,*=,/=,%=)

            int xa = 5, ys = 10, zs = 20;
            double val;

            // Buradaki += yada -= gibi değerler x değerinin üstüne 5 ekle demek yada 5 çıkar demektir geriye kalanlarda aynı mantıkdadır.

            xa += 5;
            xa -= 5;
            xa *= 5;
            xa /= 5;
            xa %= 5;
            val = Math.Pow(2, 5); // Buradaki Pow bilgisi üslü sayı yazmak için kullanılır yani aslında buradaki değer 2 üzeri 5 tir.
            val = Math.Sqrt(25); // Sqrt içine girilen değerin karekökünü alır.
            val = Math.Abs(-10); // Abs değeri negatif değeri pozitif değere döndürür.
            val = Math.Round(4.5); // Sayıyı kendine en yakın sayıya yuvarlar
            val = Math.Ceiling(5.5); // Her zaman yukarıya yuvarlama yapar 
            val = Math.Floor(5.7); // Her zaman aşşağıya yuvarlama yapar.

            Console.WriteLine($"x: {x} y: {ys} z: {z}");
            Console.WriteLine(val);

            //                                             --------------- UYGULAMA ------------------

            int j = 2, v = 5, t = 10;
            int say1 = 0;

            // a)

            Console.WriteLine($"Rastgele Sayı: {say1}");


            // 3- Karşılaştırma Operatörleri (==,!=,<,>,<=,>=,?:)

            // 4- Mantıksal Operatörler (&&,||,!)


        }
    }
}

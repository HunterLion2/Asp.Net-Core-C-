

// namespace ConsoleApp
// {

//     class Program
//     {

//         static void Main(string[] args)
//         {

            // Burada int , float , long , double ve bunlar gibi araçların olma sebepleri sadece ondalık ya da tam sayı yazabilelim diye değildir bunlar
            // aynı zaman da yer kaplarlar ve kullanılabilecekleri sayı aralığı da değişkenlik gösterir en fazla sayı aralığına decimal sahiptir fakat boyutu
            // da öbürlerinden daha büyüktür bu gözetilerek yazılmalıdır.

            // Tam Sayı (byte,short,int,long)
            // int sayi = 10;
            // int sayi2 = 20;

            // long sayi3 = 50;
            // short sayi4 = 5;
            // byte sayi5 = 10;

            // Ondalıklı Sayı
            // float a = 10.5f; // C# da float bir değer yazarken sonuna "f" konur.
            // double b = 20.6;
            // decimal c = 100.56m; // C# da decimal bir değer yazarken sonuna "m" konur.

            // Karakter
            // ( String değerde söz dizileri vardır, Char'da ise tek harf girilir ve tek tırnak ile girilir. )
            // string name = "Çınar Özgürgil";
            // char ch = 'b'; // Burada bu şekilde tek tırnak kullanılır

            // Boolean
            // bool isRetired = true;
            // bool isActive = false;


            // Console.WriteLine(sayi);
            // System.Console.WriteLine(sayi2);

            // UYGULAMA

            // byte kilo = 78;
            // string plaka = "35 AC 5553";
            // long km = 128500;
            // int id = 123123;
            // bool isActiva = false;
            // int Maaş = 100500;
            // string ad = "Çınar";
            // string soyad = "Özgürgil";
            // char şubekodu = 'A';

            //                                  --------------------------- Veri Tipi Dönüşümü ------------------------------------


            // Burada yazılan write değerinin writeLine'dan farkı write değeri geldikten sonra aşşağıya satır kaymamasıdır.


            // implicit casting (automatically): smaller type to larger [Yani aslında bu 32-bit'i 64-bit'e çevirmedir].

            // int ö = 10;
            // long ü = ö;

            // float e = 10.5f;
            // double f = e;

            // explicit casting (manually): larger type to smaller [ Bu da 64-bit'i 32-bit'e dönüştürmedir fakat bu atama yapılırken aşşağıda olduğu (int)c ile c int'e çevrilir.]
            // Fakat bu şekilde işlem yaparken veri kaybı olduğu için burada çıkacak sonuç 32-bit'in karşılıyabildiği max değerdir.

            // long c = 10;
            // int d = (int)c;

            // double g = 10;
            // float h = (float)g;

            // double k = 10.5;
            // int l = (int)k;

            // int to string

            // int x = 10;
            // string z = x.ToString(); // Stringe dönüştürme bu şekilde olur.

            // Console.WriteLine(l);


            // Console.Write("1.sayı: ");
            // int sayi1 = int.Parse(Console.ReadLine()); // Buradaki int.Parse() olayı ise Console.ReadLine()'dan gelen string ifadeyi int değerine döndürür.

            // Console.Write("2.sayı: ");
            // // int sayi2 = int.Parse(Console.ReadLine());

            // int toplam = sayi2 + sayi1;
            // Console.WriteLine($"Girilen Toplam Değer: {toplam}"); // $ işaretini kullanmazsal o zaman içerisine int değerini yazamazdık.



            //                                             ---------------------- UYGULAMA --------------------------

            // Console.Write("Dikdörtgen Kısa: ");
            // int dikdörtgen_kısa = int.Parse(Console.ReadLine());

            // Console.Write("Dikdörtgen Uzun: ");
            // int dikdörtgen_uzun = int.Parse(Console.ReadLine());


            // // Bu şekilde var değeri de yazılabilir yani bir sayı değeri belirtmeye gerek yoktır.
            // var alan = dikdörtgen_kısa * dikdörtgen_uzun;
            // var cevre = (dikdörtgen_kısa + dikdörtgen_uzun) * 2;

            // // Console.WriteLine("alan: " + alan + " " + "çevre: " + cevre);
            // Console.WriteLine($"alan: {alan} çevre: {cevre}");

            //                                          ----------------------- DATE-TİME -------------------------

            // Date-Time Bilgisi ile zaman bilgileri alınır Now ile şuan ki zaman bilgisi alınır.

            // string[] aylar = { "Ocak", "Şubat", "Mart", "Nisan", "Mayıs", "Haziran", "Temmuz", "Ağustos", "Eylül", "Ekim", "Kasım", "Aralık" };
            // DateTime simdi = DateTime.Now;

            // Console.WriteLine(simdi);
            // Console.WriteLine(simdi.Year); // Şimdiki zamanın yıl bilgisini getirir.
            // Console.WriteLine(simdi.Month);
            // Console.WriteLine(aylar[simdi.Month - 1]);
            // Console.WriteLine(simdi.Day);
            // Console.WriteLine(simdi.DayOfWeek); // Getirdiği günden hangi gün olduğunu belirtir
            // Console.WriteLine(simdi.Hour);
            // Console.WriteLine(simdi.Minute);
            // Console.WriteLine(simdi.Second);

            // DateTime dt = new DateTime(2025, 3, 8, 12, 46, 21);

            // // Add Metodu ile ekleme ve çıkarma yapabiliriz zamana
            // DateTime dt1 = dt.AddDays(2);
            // DateTime dt2 = dt.AddYears(1);
            // DateTime dt3 = dt.AddHours(-5);

            // var fark = simdi - dt;

            // // Total değerleri ile toplam günü saati yada başka bir değeri getirtebiliriz.
            // Console.WriteLine(fark.TotalDays);
            // Console.WriteLine(fark.TotalHours);


            // // Burada ToString'in içerisine yazdığımız değerler sayesinde istediğimiz tarih bilgisini getirtebiliriz.
            // Console.WriteLine(simdi);
            // Console.WriteLine(simdi.ToString("d"));
            // Console.WriteLine(simdi.ToString("D"));
            // Console.WriteLine(simdi.ToString("F"));
            // Console.WriteLine(simdi.ToString("M"));
            // Console.WriteLine(simdi.ToString("t"));
            // Console.WriteLine(simdi.ToString("T"));
            // Console.WriteLine(simdi.ToString("Y"));

            // Console.WriteLine(simdi.ToString("hh:mm:ss"));

            // // Burada yazdığım değerler zamanın nasıl getiriliceğini burada belirtmiş oluruz.
            // Console.WriteLine(simdi.ToString("ddd MMM %d, yyyy"));

            // CultureInfo culture = new CultureInfo("en"); // Burada hangi dildi olucağını belirttik en yani ingilizce
            // Console.WriteLine(simdi.ToString("F", culture)); // ToString de ilk önce formatı belirtilir sonrasında o formatın uygulanacağı değer yazılır.


            //                                  -------------------- Aritmatik Operatörler -----------------------

            // 1- Aritmetik Operatörler (+,-,*,/,%,++,--) 
            // Burada % işareti işlemin kalanını bize getirir teklik çiftlik olaylarında kullanılır..


            // 2- Atama Operatörleri (=,+=,-=,*=,/=,%=)

            // int xa = 5, ys = 10, zs = 20;
            // double val;

            // // Buradaki += yada -= gibi değerler x değerinin üstüne 5 ekle demek yada 5 çıkar demektir geriye kalanlarda aynı mantıkdadır.

            // xa += 5;
            // xa -= 5;
            // xa *= 5;
            // xa /= 5;
            // xa %= 5;
            // val = Math.Pow(2, 5); // Buradaki Pow bilgisi üslü sayı yazmak için kullanılır yani aslında buradaki değer 2 üzeri 5 tir.
            // val = Math.Sqrt(25); // Sqrt içine girilen değerin karekökünü alır.
            // val = Math.Abs(-10); // Abs değeri negatif değeri pozitif değere döndürür.
            // val = Math.Round(4.5); // Sayıyı kendine en yakın sayıya yuvarlar
            // val = Math.Ceiling(5.5); // Her zaman yukarıya yuvarlama yapar 
            // val = Math.Floor(5.7); // Her zaman aşşağıya yuvarlama yapar.

            // Console.WriteLine($"x: {x} y: {ys} z: {z}");
            // Console.WriteLine(val);

            //                                             --------------- UYGULAMA ------------------

            // int x = 2, y = 5, z = 10;

            // int degerler_toplamı = x + y + z;

            // Console.Write("Sayi1: ");
            // int say1 = int.Parse(Console.ReadLine());

            // Console.Write("Sayi2: ");
            // int say2 = int.Parse(Console.ReadLine());

            // int kullanıcı_carpım = say1 * say2;

            // int ıslem = kullanıcı_carpım - degerler_toplamı;

            // Console.WriteLine($"Cikarmasi:{ıslem}");

            // Console.Write("Tek-Cift: ");
            // int tekcıft = int.Parse(Console.ReadLine());

            // Burada if else kullanmadan "? :" yapısını kullanmış olduk. 
            // string sonuc = (tekcıft % 2 == 0 ? "Evet" : "Hayır");

            // Console.WriteLine($"Girilen Deger Cift Mi => {sonuc}");

            // var uzeri = Math.Pow(y, x);
            // Console.WriteLine($"Y Uzeri X Degeri => {uzeri}");




            // 3) Karşılaştırma Operatörleri (==,!=,=>,=<,?:)

            // int aa = 5, bb = 5, cc = 10, dd = 4;
            // string username = "ÇınarÖzgürgil";
            // string password = "123456";

            // var result = (a == b); // true
            //result = (a == c); // false değeri döner
            //result = (username == "Çnaz");

            // 4) Mantıksal Operatörler (&&, || , !)

            // int xx = 6;
            // int hak = 5;
            // char devami = 'e';

            // and (&&) [Girilen iki değerinde doğru ise doğru yanlış ise yanlış olması gerekir başka türlü olmaz]
            // true && true => true
            // false && true => false

            // or(||)
            // true || true
            // false || true
            // false || false

            //                                   --------------------------- Switch-Case -----------------------------

            // switch(say1) {
            //     case(10): // Aslında switch case if else'e çok benzer switch alınan değerdir case de bu değerin alacağı değerleri yazdığımız yerdir default da else'e benzer yukarıdakiler olmaz sa şunu yap der. 
            //         Console.WriteLine("Kış Mevsimi");
            //     default: 
            //         Console.WriteLine("Kış Mevsimi Değil");
            // }

            // switch (say1)
            // {
            //     // 10 11 12 değerleri için aşşağıdaki olayı yap anlamına gelir
            //     case (12):
            //     case (11):
            //     case (10): // Aslında switch case if else'e çok benzer switch alınan değerdir case de bu değerin alacağı değerleri yazdığımız yerdir default da else'e benzer yukarıdakiler olmaz sa şunu yap der. 
            //         Console.WriteLine("Kış Mevsimi");
            //     default:
            //         Console.WriteLine("Kış Mevsimi Değil");
            // }

            //                                   --------------------------------- For -----------------------------------

            // 1) ----

            // Console.Write("Başlangıç: ");
            // int baslangıc = int.Parse(Console.ReadLine());

            // Console.Write("Artış-Mıktarı: ");
            // int artıs = int.Parse(Console.ReadLine());

            // Console.Write("Bitis: ");
            // int bıtıs = int.Parse(Console.ReadLine());


            // for(int basla = baslangıc; basla <= bıtıs; basla=basla + artıs) {
            //     Console.WriteLine(basla);
            // }


            // 2) ----------

            // int[] sayilar = {1,3,5,6,7,23,67,90};

            // for(int i = 0; i < sayilar.Length; i++) {
            //     if(sayilar[i] % 3 == 0) {
            //         Console.WriteLine(sayilar[i]);
            //     }
            // }

            // 3) ---------------------

            // int[] sayilar = { 1, 3, 5, 6, 7, 23, 67, 90 };
            // int toplam = 0;

            // Burada aslında i değerini sayilar'ın içindeki en büyük değere kadar yazdırıp sonrada i'nin içinden sayilar'da olan rakamı almış olduk.
            // for (int i = 0; i < sayilar.Length; i++)
            // {
            //     toplam += sayilar[i];
            // }
            // Console.WriteLine("Toplam: " + toplam);


            //                          ------------------ FOREACH() ----------------


            // string[] arabalar = { "Opel", "Mazda", "Toyota", "Bmw", "Mercedes" };

            // foreach (string araba in arabalar)
            // {
            //     if (araba.Length >= 5)
            //     {
            //         Console.WriteLine(araba);
            //     }
            // }

            //              ------------------------------ WHİLE() -------------------------------

            // For'un aynısıdır fakat bunda ilk değer dışarıda son değeride içeriye yazılır

            // int i = 0;
            // while (i < 10)
            // {
            //     Console.WriteLine(i);
            //     i++;
            // }

            //          ------------------------------- Break And Continue ----------------------------------

            // Break - Continue Kullanımı: 

            // For döngülerinde sürecin devam edip etmeme olayını kontrol etmemizi sağlar.

            // string name = "Çınar Özgürgil";

            // for (int i = 0; i < name.Length; i++)
            // {
            //     if (name[i] == 'd')
            //     {
            //         continue;
            //         Console.WriteLine(name[i]);
            //     }
            // }

            // Console.WriteLine("döngü dışı");


            //      ------------------------------------ Asal Sayı (Uygulama) ------------------------------------------


            // Console.Write("Sayı: ");
            // int say = int.Parse(Console.ReadLine());

            // int[] sayılar = { 2, 3, 5, 7 };

            // bool asalmi = true;

            // foreach (int sayı in sayılar)
            // {
            //     if (say == sayı)
            //     {
            //         asalmi = true;
            //         break;
            //     }
            //     else if (say % sayı == 0)
            //     {
            //         asalmi = false;
            //         break;
            //     }
            // }

            // if (asalmi)
            // {
            //     Console.WriteLine("Asaldır");
            // }
            // else
            // {
            //     Console.WriteLine("Asal değildir");
            // }

            //                                  ---------------------- SAYI TAHMİN UYGULAMASI ------------------------------


            // Random random = new Random();

            // int rastgele = random.Next(1, 10);

            // for (int hakkı = 5; hakkı > 0; hakkı--)
            // {
            //     Console.Write("Sayı: ");
            //     int sayı = int.Parse(Console.ReadLine());

            //     if (sayı == rastgele)
            //     {
            //         Console.WriteLine("Tebrikler Bildiniz.");
            //         break;
            //     }

            //     else if (sayı > rastgele)
            //     {
            //         Console.WriteLine("Daha küçük bir değer giriniz.");
            //     }

            //     else if (rastgele < sayı)
            //     {
            //         Console.WriteLine("Daha Büyük bir değer giriniz.");
            //     }

            //     else
            //     {
            //         Console.WriteLine("Maalesef Bilemediniz");
            //     }

            // }

    //                   -------------------------------------- CLASS --------------------------------------------------

    // class Ogrenci
    // {
    //     public int OgrNo { get; set; }
    //     public string Ad { get; set; }
    //     public string Sube { get; set; }
    // }

    // class Program
    // {
    //     static void Main(string[] args)
    //     {
    //         Ogrenci ogr1 = new Ogrenci();
    //         ogr1.OgrNo = 100;
    //         ogr1.Ad = "Çınar";
    //         ogr1.Sube ="10A";

    //         Console.WriteLine($"no: {ogr1.OgrNo} ad: {ogr1.Ad} sube: {ogr1.Sube}");

    //         Ogrenci ogr2 = new Ogrenci()
    //         {
    //             OgrNo = 200,
    //             Ad="Ada",
    //             Sube="10B" 
    //         };

    //         Console.WriteLine($"no: {ogr2.OgrNo} ad: {ogr2.Ad} sube: {ogr2.Sube}");
            
    //         Ogrenci ogr3 = new Ogrenci()
    //         {
    //             OgrNo = 300,
    //             Ad="Yiğit",
    //             Sube="11A" 
    //         };

    //         Console.WriteLine($"no: {ogr3.OgrNo} ad: {ogr3.Ad} sube: {ogr3.Sube}");

    //         Console.WriteLine("**************************");

    //         Ogrenci[] ogrenciler = new Ogrenci[3];

    //         ogrenciler[0] = ogr1;
    //         ogrenciler[1] = ogr2;
    //         ogrenciler[2] = ogr3;

    //         for (int i = 0; i < ogrenciler.Length; i++)
    //         {
    //              Console.WriteLine($"no: {ogrenciler[i].OgrNo} ad: {ogrenciler[i].Ad} sube: {ogrenciler[i].Sube}");
    //         }


    //     }
    // }

// ------------------------------------------------------------------------ Function ----------------------------------------------------------------------------


    // class Product
    // {
    //     public string Name { get; set; }
    //     public double Price { get; set; }
    //     public string Description { get; set; }
    // }

    // class Program
    // {

    //     class Person
    //     {
    //         public string Name { get; set; }
    //         public int Year { get; set; }

    //         // Function bu şekilde oluşturulur ve buradaki fark oluşturulan fonksiyondan çıkıcak değerin ne olduğunu fonksiyonu oluşturmadan söylememizi istiyor
    //         // string , int gibi.

    //         public string Intro()
    //         {
    //             return $"isim: {this.Name} yaş: {this.CalculateAge()}";
    //         }

    //         // Burada yazılan fonksiyonlar da her türlü return olması lazım 

    //         public int CalculateAge()
    //         {
    //             return DateTime.Now.Year - this.Year;
    //         }
    //     }




    //     static void Main(string[] args)
    //     {
    //         // Class => object (nesne)
    //         // Ogrenci => ogr1,ogr2

    //         var p1 = new Person { Name = "Ada", Year = 2012 };
    //         var p2 = new Person { Name = "Yiğit", Year = 2010 };
    //         var p3 = new Person { Name = "Sena", Year = 1999 };

    //         // var str1 = p1.Intro();
    //         // var str2 = p2.Intro();
    //         // var str3 = p3.Intro();

    //         Console.WriteLine(p1.Intro());
    //         Console.WriteLine(p2.Intro());
    //         Console.WriteLine(p3.Intro());

    //         // Console.WriteLine($"name: {p1.Name} age: {2020 - p1.Year}");
    //         // Console.WriteLine($"name: {p2.Name} age: {2020 - p2.Year}");
    //         // Console.WriteLine($"name: {p3.Name} age: {2020 - p3.Year}");

    //     }
    // }


    


//         }
//     }
// }



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


// ------------------------------------- Yapıcı Metodlar(Constructor) -----------------------------------------

//    class Araba
//     {        
//         // Bu şekilde class'ın adını vererek bir constructor oluştururuz.
//         public Araba()
//         {
//             this.MaxHiz = 180;
//             Console.WriteLine("yapıcı metot çalıştırıldı.");
//         }
//         public Araba(int maxhiz)
//         {
//             this.MaxHiz = maxhiz;
//         }

//         public Araba(string marka,string model,string renk,bool otomatik,int maxhiz)
//         {
//             this.Marka = marka;
//             this.Model = model;
//             this.Renk = renk;
//             this.Otomatik = otomatik;
//             this.MaxHiz = maxhiz;
//         }

// Burada ki get ve set in anlamı şudur get değerin okunabilir olucağı anlamına gelir set ise değerin değiştirilebilir olucağı anlamına gelir.
//         public string Marka { get; set; }
//         public string Model { get; set; }
//         public string Renk { get; set; }
//         public bool Otomatik { get; set; }
//         public int MaxHiz { get; set; }
//     }


// -------------------------------------------------- Proporties --------------------------------------------------------------

// namespace ConsoleApp {

//     class Product {
//         // Eğer Buradaki değerlere public yazmazsam bu class'ın dışında buradaki değerlere erişemem.
//         private string _name;

//         public string Name {
//             get {
//                 return _name; 
//             } set { // Burası _name değerine bir atama yapmak istediği zaman çıkıcak koşullardır.
//                 if(!string.IsNullOrEmpty(value)) {
//                     _name = value;
//                 } else {
//                     // Console.WriteLine("Name alanı boş geçilemez");

//                     // Burada throw bir fırlatma dır Exception ise hata fırlatmat için kullanılır
//                     throw new Exception("Name alanı zorunlu");
//                 }
//             }
//         }

//         // Buraya private vererek buradaki değeri dışarıdan değiştirilemez kılarız ve bu değeri de kendi class'ının içerisinde bir function ile erişerek bu fonksiyonu başka bir class içerisinde çağırdığımız zaman bunu erişilebilir kılarız.
//         // Burada fonksüyon çağırma ile bunu yapmak yerine proporties ile de bu yapılabilir.

//         private double _price;

//         public double Price {
//             get { // Burada private olan öge return edilir.
//                 return _price;
//             }
//             set { // Burada da private olan değerin içerisine değerler atıyabiliyoruz. value değeri set edilen değer anlamına gelir.
//                 if(value < 0) {
//                     _price = 0;
//                 } else {
//                     _price = value;
//                 }
//             }
//         }



//         // public void SetPrice(double price) {
//         //     if(price < 0) {
//         //         this.Price = 0;
//         //     } else {
//         //         this.Price = price;
//         //     }
//         // }

//     }

//     class Program {

//         static void Main(string[] args) {
//             var p = new Product();
//             p.Name = "Samsung S8";
//             // p.SetPrice(2000);
//             p.Price = -2000;

//             Console.WriteLine(p.Price);
//         }
//     }
// }


// ---------------------------------------------------------------------- Static ---------------------------------------------------------------------------------

// Static değerlerin diğer normal değerlerden farkı bu değerler class değeri her çağrıldığında (tekrardan oluşturulup o değere atanmaz)
// kopyalanmadan bütün değerler için geçerli olur.

// class Student
// {
//     public string Name { get; set; }
//     public int StudentNumber { get; set; }

//     public static string School = "my school";
//     public static string Address = "my school address";

//     public Student(string name, int studentnumber)
//     {
//         this.Name = name;
//         this.StudentNumber=studentnumber;
//     }

//     public void DisplayStudentDetails()
//     {
//         Console.WriteLine($"name: {this.Name} number: {this.StudentNumber}");
//     }

//     public static void DisplaySchoolDetails(){
//         Console.WriteLine($"school name: {School} address: {Address}");
//     }
// }

// static class HelperMethods
// {
//     public static string KarakterDuzelt(string str)
//     {
//         return str
//                 .Replace("ö","o")
//                 .Replace("ü","u")
//                 .Replace("ç","c")
//                 .Replace(" ","-")
//                 .Replace("ğ","g");
//     }
// }

// class Program
// {
//     static void Main(string[] args)
//     {
//         // var s1 = new Student("Çınar",100);
//         // var s2 = new Student("Sena",101);
//         // var s3 = new Student("Yiğit",102);

//         // Student.DisplaySchoolDetails();

//         // s1.DisplayStudentDetails();
//         // s2.DisplayStudentDetails();
//         // s3.DisplayStudentDetails();


//         string str = "ölçme ve değerlendirme";
//         var result = HelperMethods.KarakterDuzelt(str);
//         Console.WriteLine(result);

//     }
// }


// -------------------------------------------------------------- Miras Alma / Abstrack Sınıflar -------------------------------------------------------------------------------

// Abstrack bir değer oluşturduğumuz zaman bu değerden yeni bir nesne üretemeyiz.

// abstract class Person
// {
//     public string Name { get; set; }
//     public string SurName { get; set; }

//     public Person(string name, string surname)
//     {
//         this.Name = name;
//         this.SurName = surname;
//         Console.WriteLine("Person nesnesi oluşturuldu.");
//     }

//Burada ki virtual'ın anlamı biz her zaman buradaki Intro() içerisinde ki değerleri diğer mirasçı class larda da aynısını kullanmak zorunda değiliz 
//buraya yazdığımız "virtual" değeri sayesinde buradaki değeri ezeriz. Ve mirasçı class'a da "override" yazarız. Bu sayede Intro()'nun içerisine yazılacak değerlerde değişiklik yapma hakkımız olur.

//     public void Greeting()
//     {
//         Console.WriteLine("I am a person");
//     }
//     public abstract void Intro();
// }

// class Student : Person
// {
//     public string StudentNumber { get; set; }
//     public Student(string name, string surname, string studentnumber) : base(name, surname)
//     {
//         this.StudentNumber = studentnumber;
//         Console.WriteLine("Student nesnesi oluşturuldu.");
//     }

//     public override void Intro()
//     {
//         Console.WriteLine($"name: {this.Name} Surname: {this.SurName} Number: {this.StudentNumber}");
//     }
// }


// class Teacher : Person
// {
//     public string Branch { get; set; }

// Burada ki base() kelimesi temel anlamına gelir yani Teacher da alınan name ve surname bilgilerini ana olana gönder yani miras aldığımıza burada o kişi Person oluyor.

//     public Teacher(string name, string surname, string branch) : base(name, surname)
//     {
//         this.Branch = branch;
//     }

//     public void Teach()
//     {
//         Console.WriteLine("I am teaching...");
//     }

//     public override void Intro()
//     {
//         Console.WriteLine($"name: {this.Name} Surname: {this.SurName} Branch: {this.Branch}");
//     }
// }

// abstract class Shape
// {
//     public int Width { get; set; }
//     public int Height { get; set; }

//     public Shape(int w, int h)
//     {
//         this.Width = w;
//         this.Height = h;
//     }

//     public int CalculateArea()
//     {
//         return this.Width * this.Height;
//     }

// Bu soyut bir methodtur yani Shape class'ı her çağrıldığında çağrılan yerde bu method ile ilgili 
//     public abstract void Draw();
// }

// class Square: Shape
// {

//     public Square(int w, int h):base(w,h)
//     {        
//     }
//     public override void Draw()
//     {
//         Console.WriteLine("Draw a square");
//     }
// }

// class Rectangle: Shape
// {
//     public Rectangle(int w, int h):base(w,h) {

//     }
//     public override void Draw()
//     {
//         Console.WriteLine("Draw a rectangle");
//     }
// }

// class Program
// {
//     static void Main(string[] args)
//     {           
//         // Abstract Class: Soyut Sınıf      

//         var shapes = new Shape[3];

//         shapes[0] = new Rectangle(10,15);
//         shapes[1] = new Square(15,15);
//         shapes[2] = new Rectangle(15,20);

//         foreach (var shape in shapes)
//         {
//             shape.Draw();
//             Console.WriteLine($"alan: {shape.CalculateArea()}");
//         }

//     }
// }


// ----------------------------------------------------------------------- Interface --------------------------------------------------------------------------------

// İnterface'ler (arayüz) genellikle "I" harfi ile başlar.
// İnterface'e bir constructor eklenemez.

// interface IKisi
// {
//     string adSoyad {get;set;}
//     string adres {get;set;}  
//     string departman { get; set; }
//     double maas { get; set; }

// }
// interface IPersonel
// {       
//     string departman { get; set; }
//     void bilgi();

// }

// class Yonetici : IPersonel,IKisi
// {
//     public Yonetici(string _adsoyad,string _adres,string _departman)
//     {
//         this.adSoyad = _adsoyad;
//         this.adres = _adres;
//         this.departman =_departman;
//     }
//     public string adSoyad { get; set; }
//     public string adres { get; set; }
//     public string departman { get; set; }
//     public double maas{ get; set; }

//     public void bilgi()
//     {
//         Console.WriteLine($"{this.adSoyad} isimli personel {this.departman} bölümünde yöneticidir.");
//     }
// }

// class Isci: IPersonel,IKisi
// {
//     public Isci(string _adsoyad,string _adres,string _departman)
//     {
//         this.adSoyad = _adsoyad;
//         this.adres = _adres;
//         this.departman =_departman;
//     }
//     public string adSoyad { get; set; }
//     public string adres { get; set; }
//     public string departman { get; set; }
//     public double maas { get; set; }

//     public void bilgi()
//     {
//         Console.WriteLine($"{this.adSoyad} isimli personel {this.departman} bölümünde işçidir.");
//     }
// }

//     class Robot : IPersonel
// {
//     public Robot(string _departman)
//     {
//         this.departman = _departman;
//     }
//     public string departman { get; set; }

//     public void bilgi()
//     {
//         Console.WriteLine($"{this.departman} bölümünde bir robot.");            
//     }
// }

// class Program
// {
//     static void Main(string[] args)
//     {           
//        // Interface

//         // IPersonel y = new Yonetici();
//         // IPersonel i = new Isci();

//         var personeller = new IPersonel[3];

//         personeller[0] = new Yonetici("ali yılmaz","istanbul","finans");
//         personeller[1] = new Isci("ahmet cengiz","kocaeli","üretim");
//         personeller[2] = new Robot("üretim");

//         foreach (var personel in personeller)
//         {
//             personel.bilgi();
//         }
//     }
// }

// -------------------------------------------------------------------------- Array List -------------------------------------------------------------------------------
// using System.Collections;

// class Program
//     {
//         static void Main(string[] args)
//         {           
//             // ArrayList

//             ArrayList myList = new ArrayList();

//             myList.Add(10);
//             myList.Add("10");
//             myList.Add("abc");
//             myList.Add(10.5);

//             // Add metodu ile listeye eleman en sondan eklenir.

//             IList myList2 = new ArrayList(){"******","10","abc",10.5};

//             // IList , ArrayList den daha kısıtlayıcı bir listeleme yapısıdır.

//             // Accessing Items
//             // Console.WriteLine(myList[0]);
//             int sayi = (int)myList[0];

//             // myList.Insert(1,20);

//             // Insert metodu ile istediğimiz indexe istediğimiz değeri atıyabiliriz.
//             // (1,20) burada ilk girilen değer index değerini 2. girilen değer indexe verilicek değerdir.

//             // myList.InsertRange(3,myList2);

//             // ** liste içine liste ekleneceği zaman InsertRange kullanılır burada olduğu gibi.


//             // Remove Items

//             // myList.Remove(10);  // 10 değerine sahip olan elemanı siler.
//             // myList.RemoveAt(2); // Silmek istediğimiz index değerini girip onu silebiliriz.
//             // myList.RemoveRange(0,2); // Burada da 0. indexten başla 2.ye kadar sil demektir.

//             foreach (var item in myList)
//             {
//                 Console.WriteLine(item);
//             }

//             Console.WriteLine(myList.Contains(10));

//             // Listenin içerisinde bir değer aramak istediğimiz zaman Contains değerini kullanırız.Sonucunda bize True False değer döndürür.

//             ArrayList sayilar = new ArrayList(){10,5,4,60};

//             foreach (var item in sayilar)
//             {
//                 Console.WriteLine(item);
//             }

//             sayilar.Sort();

//             foreach (var item in sayilar)
//             {
//                 Console.WriteLine(item);
//             }
//         }
//     }

// using ConsoleApp.Entity;

//     class Product
//     {
//         public string Name { get; set; }
//     }
//     class Program
//     {

        //ArrayList de istediğimiz türde değeri saklıyabiliyorken burada değerleri atmadan 
        //önce hangi türde değer atanacağını belirtiriz sonrasında sadece o türe ait bilgileri atarız.

        // static void Main(string[] args)
        // {           
        //     // Generic List
        //     List<int> sayilar = new List<int>();
        //     sayilar.Add(10);
        //     sayilar.Add(20);
        //     sayilar.Add(30);

        //     List<string> isimler = new List<string>();
        //     isimler.Add("ali");
        //     isimler.Add("ahmet");
        //     isimler.Add("yağmur");
        //     isimler.Add(null);

        //     List<Product> urunler1 = new List<Product>()
        //     {
        //         new Product(){Name="Samsung S6"},
        //         new Product(){Name="Samsung S7"},
        //         new Product(){Name="Samsung S8"},
        //         new Product(){Name="Samsung S9"}
        //     };

        //     IList<Product> urunler2 = new List<Product>()
        //     {
        //         new Product(){Name="IPhone 6"},
        //         new Product(){Name="IPhone 7"},
        //         new Product(){Name="IPhone 8"},
        //         new Product(){Name="IPhone 10"}
        //     };

            //AddRange metodu liste içine liste ekler. 

            // urunler1.AddRange(urunler2);

            // foreach (var sayi in sayilar)
            // {
            //     Console.WriteLine(sayi);
            // }

            // foreach (var product in urunler1)
            // {
            //     Console.WriteLine(product.Name);
            // }

            // urunler1.ForEach(p=> {
            //         Console.WriteLine(p.Name);
            // });


            // Count ile listenin içindeki eleman sayısı gelir.
            // int count = urunler1.Count;
            // Console.WriteLine(count);

            // Console.WriteLine(urunler2[0].Name);

            // for (int i = 0; i < urunler2.Count; i++)
            // {
            //     Console.WriteLine(urunler2[i].Name);
            // }

            // insert items

            // Insert metodunda ilk değerin girileceği yere hangi indexe değerin verileceği yazılır ikinci bölümede o seçilen indexe verilecek değer yazılır.
            // sayilar.Insert(1,100);

            // foreach (var sayi in sayilar)
            // {
            //     Console.WriteLine(sayi);
            // }

            // InsertRange metodu ise ilk değerinde girilecek değerin hangi indexe verileceğini yazarız ikinci indexe ise hangi listenin bu listeye ekleneceğini yazarız.
            // urunler1.InsertRange(1,urunler2);

            // for (int i = 0; i < urunler1.Count; i++)
            // {
            //     Console.WriteLine(urunler1[i].Name);   
            // }

    //         sayilar.RemoveAt(sayilar.Count-1);

    //          foreach (var sayi in sayilar)
    //         {
    //             Console.WriteLine(sayi);
    //         }

    //     }
    // }

// ------------------------------------------------------------------------- Dictionary --------------------------------------------------------------------------------

    // static void Main(string[] args) {

    //     // Eğer bilgiyi key ve value değerleri şeklinde tanımlamak istersek buna başvurmamız gerekir.

    //     Dictionary<int,string> plakalar = new Dictionary<int,string>();

    //     plakalar.Add(34,"İstanbul");
    //     plakalar.Add(35,"İzmir");
    //     plakalar.Add(53,"Rize");

    //     Dictionary<int,string> sayilar = new Dictionary<int, string> {
    //         {1,"Bir"},
    //         {2,"İki"},
    //         {3,"Üç"}
    //     };

    //     Console.WriteLine(sayilar[1]); 

    //     foreach (var plaka in plakalar)
    //     {
    //         Console.WriteLine($"{plaka.Key} {plaka.Value}");
    //     }

    //     for(int i = 0; i < plakalar.Count; i++) {
    //         // ElementAt(i) bu method listenin içerisinden istediğimiz değeri çekebilmemizi sağlar.
    //         // Burada Keys Ve Value yazma sebebimimiz Dictionary yapısını kullanmamızdandır.
    //         Console.WriteLine($"{plakalar.Keys.ElementAt(i)} {plakalar[plakalar.Keys.ElementAt(i)]}");

    //         // ContainsKey() bilgisi içine girilen değerin var olup olmadığını sonucunda true ya da false değer döndürerek bize söyler.
    //         Console.WriteLine(plakalar.ContainsKey(34));

    //         // Burada Remove() methodu içerisine girilen value değerini arar bulur varsa siler.
    //         plakalar.Remove(34);
    //         plakalar.Remove(35);
    //     }
    // }

// ----------------------------------------------------------------------- Hata Ve Hata Yönetimi ------------------------------------------------------------------------

    // class Product{
    //     public string Name { get; set; }
    // }

    // class Program
    // {
    //     static void Main(string[] args)
    //     {           
    //        // Bu şekilde sistemdeki hataları bir yere yazmış olduk.

    //        // Exception 
    //        // Unhandled exception. System.FormatException
    //        // Unhandled exception. System.DivideByZeroException
    //        // Unhandled exception. System.IndexOutOfRangeException
    //        // Unhandled exception. System.NullReferenceException

    //        Console.Write("1. sayı: ");
    //        int sayi1 =int.Parse(Console.ReadLine());

    //        Console.Write("2. sayı: ");
    //        int sayi2 =int.Parse(Console.ReadLine());

    //        var sonuc = sayi1 / sayi2;

    //        int[] sayilar = new int[2];
    //        // sayilar[2] = 10;

    //        Product p = null;
    //        Console.WriteLine(p.Name);

    //        // Exception Handling
           
    //     }
    // }

// ---------------------------------------------------------------------- Hata Yakalama -----------------------------------------------------------------------------

        // try // Buranın İçerisine hatanın yakalanacağı kod satırı yazılır
        // {
        //     Console.Write("a: ");
        //     int a = int.Parse(Console.ReadLine());

        //     Console.Write("b: ");
        //     int b = int.Parse(Console.ReadLine());

        //     var sonuc = a / b;

        //     Console.WriteLine($"{0} / {1} = {2}",a,b,sonuc);
        // }
        // catch (DivideByZeroException ex)  // Buraya çıkabilecek hata kodu yazılır. 
        // { // Buranın içerisine decatch de ki hata yakalandığı zaman yapılacak işlem yazılır.
        //     Console.WriteLine("B sıgfır olamaz");
        //     Console.WriteLine(ex.Message);
        // } 
        // catch(FormatException ex) {
        //     Console.WriteLine("Sayısal bilgi girmelisiniz");
        //     Console.WriteLine(ex.Message); // Bu da sistemin verdiği hata mesajını da yazdırır.
        // }
        // catch(Exception){ // Exception genel bütün hataları kapsar ve herhangi bir hata aldığı zaman aşşağıdaki kodu çalıştırır.
        //     Console.WriteLine("Bir Hata Oluştu");
        // }

        // Algoritmada çıkabilecek hataları öngererek hareket edip ona göre hata kodlarını yazmalıyız.

// ------------------------------------------------------------------ Hata Fırlatma ------------------------------------------------------------------------------------

    // class Person
    // {
    //     string _name;
    //     public string Name
    //     {
    //         get {
    //             return _name;
    //         }
    //         set { // Burada set methodu ile kullanıcının girdiği değeri kontrol ederiz.
    //             if(value.Length>15) // Bu şekilde de hata fırlatabiliriz.
    //                 throw new Exception("Name için en fazla 15 karakter girmelisiniz.");
    //             _name = value;
    //         }
    //     }
    // }
    // class Program
    // {
    //     static void check_password(string password)
    //     {
    //         if (password.Length<8 || password.Length>15)
    //             throw new Exception("Parola 7-15 karakter arasında olmalıdır.");
    //         if (!password.Any(char.IsDigit)) // Any methodu ile password içerisindeki her bir kelimeyi kontrol edebiliriz.
    //         // IsDigit değeri password içerisindeki her bir kelimenin rakam olup olmadığına bakar.
    //             throw new Exception("Parola en az bir rakam içermelidir.");
    //         if (!password.Any(char.IsLetter)) // IsLetter değeri ise girilen değerin harf olup olmadığına bakar.
    //             throw new Exception("Parola en az bir harf içermelidir");
    //     }

        // static void Main(string[] args)
        // {
            // Exception Handling

            // string parola = "12345222s";

            // try
            // {
            //     check_password(parola);
            //     Console.WriteLine("parola geçerli.");
            // }
            // catch (Exception ex) Biz burada aslında yukarıda oluşturduğumuz Exception değerlerini yakalarız
            // {
            //     Console.WriteLine(ex.Message);
            // }

    //         try
    //         {
    //             var p = new Person();
    //             p.Name = "Sadık    ";
    //         }
    //         catch (System.Exception ex)
    //         {
    //             Console.WriteLine(ex.Message);
    //         }
    //     }
    // }

// --------------------------------------------------------------- Exception(Kendi Hata Sınıfımızı Yazma) ------------------------------------------------------------------------------------



    // Kendi hata sınıfımızı yazarken bu şekilde ana Exception'a bağlarız ve aldığımız mesajları oraya da göndeririz.
    class LoginException: Exception
    {
        public LoginException(string message):base(message)
        {
            
        }
    }


    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Login("sadikturan","123456777");
                Console.WriteLine("login başarılı.");
            }
            catch (LoginException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        static void Login(string username, string password)
        {
            if (username.Contains(" "))
                throw new LoginException("username boşluk içeremez.");

            if (password.Length<8)
                throw new LoginException("Parola min. 8 karakter olmalıdır.");
        }
    }


//         }
//     }
// }
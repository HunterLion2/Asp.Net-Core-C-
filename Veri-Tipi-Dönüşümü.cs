
// Burada yazılan write değerinin writeLine'dan farkı write değeri geldikten sonra aşşağıya satır kaymamasıdır.


// implicit casting (automatically): smaller type to larger [Yani aslında bu 32-bit'i 64-bit'e çevirmedir].

int a = 10;
long b = a;

float e = 10.5f;
double f = e;

// explicit casting (manually): larger type to smaller [ Bu da 64-bit'i 32-bit'e dönüştürmedir fakat bu atama yapılırken aşşağıda olduğu (int)c ile c int'e çevrilir.]
// Fakat bu şekilde işlem yaparken veri kaybı olduğu için burada çıkacak sonuç 32-bit'in karşılıyabildiği max değerdir.

long c = 10;
int d = (int)c;

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
int sayi2 = int.Parse(Console.ReadLine());

int toplam = sayi2;
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


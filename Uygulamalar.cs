// class Uygulamalar
// {
//     static void Main(string[] args)
//     {
//         ----------------------------------Bankamatik Uygulaması------------------------------------

//     string secim = "";
//         double bakiye = 0;

//         do
//         {
//             Console.Write("1-Bakiye Görüntüle\n2-Para Yatırma\n3-Para Çek\n4-Çıkış\nSeçiminiz: ");
//             secim = Console.ReadLine();

//             switch (secim)
//             {

//                 case ("1"):
//                     Console.WriteLine($"{bakiye}");
//                     break;
//                 case ("2"):
//                     Console.Write("Yatırılıcak Değer: ");
//                     int yatirilan = int.Parse(Console.ReadLine());
//                     bakiye += yatirilan;
//                     break;
//                 case ("3"):
//                     Console.Write("Çekilecek Değer: ");
//                     int çekilen = int.Parse(Console.ReadLine());

//                     if (çekilen > bakiye)
//                     {
//                         Console.WriteLine("Çekilmek İstenen Değer Bakiyenizde Bulunandan Fazladır");
//                     }
//                     else
//                     {
//                         bakiye -= çekilen;
//                         Console.WriteLine("Çekim İşlemi Başaralı");
//                     }
//                     break;
//                 case ("4"):
//                     secim = "4";
//                     break;
//                 default:
//                     Console.WriteLine("Hatalı Seçim");
//                     break;
//             }
//         } while (secim != "4");

//         Console.WriteLine("Uygulamdan Çıkıldı");
//     }
// }


// class ÜrünBilgisi{

//     public string name { get; set; }
//     public int price { get; set; }
//     public string description { get; set; }
// }

// class Ürünler
// {
//     static void Main(string[] args)
//     {

//         ÜrünBilgisi ürün = new ÜrünBilgisi();
//         string secim = "";

//         do
//         {
//             Console.WriteLine(" Ürün Girmek İçin - 1 \n Ürünlere Bakmak İçin - 2 \n Çıkış İçin - 3 \n Seçiniz: ");
//             secim = Console.ReadLine();
//             Console.WriteLine(secim);

//             switch (secim) {
//                 case "1":
//                     Console.Write("Ürün İsmi: ");
//                     ürün.name = Console.ReadLine();
//                     Console.Write("Ürün Fiyatı: ");
//                     ürün.price = int.Parse(Console.ReadLine());
//                     Console.Write("Ürün Açıklaması: ");
//                     ürün.description = Console.ReadLine();
//                     Console.WriteLine("Ürününüz Başarı İle Kaydedildi");
//                     break;
//                 case "2":
//                     Console.WriteLine($" Ürün İsmi: {ürün.name} \n Ürün Fiyatı: {ürün.price} \n Ürün Açıklaması {ürün.description}");
//                     break;
//                 case "3":
//                     secim = "3";
//                     break;
//                 default:
//                     Console.WriteLine("Lütfen Belirten Rakamlardan Birini Giriniz");
//                     break;
//             }
//         } while (secim != "3");
//        Console.WriteLine("Uygulamadan Çıkıldı");
//     }
// }

//  ------------------------------------- Function Uygulaması ------------------------------------ 

// class Araba
//     {
//         public string Marka { get; set; }
//         public string Model { get; set; }
//         public string Renk { get; set; }
//         public bool Otomatik { get; set; }

//         public void Start()
//         {
//             Console.WriteLine($"{this.Marka} {this.Model} çalıştırıldı.");
//         }

//         public void Stop()
//         {
//             Console.WriteLine($"{this.Marka} {this.Model} stop edildi.");
//         }

//         public void Yavasla()
//         {
//             Console.WriteLine($"{this.Marka} {this.Model}a yavaşlıyor");
//         }

//         public void Hizlan()
//         {
//             Console.WriteLine($"{this.Marka} {this.Model} hızlanıyor");
//         }

//         public void Menu()
//         {
//             string komut = "";

//             do
//             {
//                 Console.WriteLine("1-Start 2-Hızlan 3-Yavaşla 4-Stop Çıkış: Ç");
//                 Console.Write("Seçiminiz: ");
//                 komut = Console.ReadLine();

//                 switch (komut)
//                 {
//                     case "1":
//                         this.Start();
//                         break;
//                     case "2":
//                         this.Hizlan();
//                         break;
//                     case "3":
//                         this.Yavasla();
//                         break;
//                     case "4":
//                         this.Stop();
//                         break;
//                     default:
//                         Console.WriteLine("uygulamadan çıkıldı.");
//                         break;
//                 }

//             } while (komut != "Ç");

//         }
//     }

//     class Program
//     {
//         static void Main(string[] args)
//         {
//             var opel = new Araba();
//             opel.Marka = "Opel";
//             opel.Model = "Astra";
//             opel.Renk = "Beyaz";
//             opel.Otomatik = true;

//             // opel.Start();
//             // opel.Hizlan();
//             // opel.Yavasla();
//             // opel.Stop();

//             var mazda = new Araba();
//             mazda.Marka="Mazda";
//             mazda.Model="CX3";
//             mazda.Renk="Kırmızı";
//             mazda.Otomatik=true;

//             opel.Menu();
//             // mazda.Menu();
//         }
//     }


//                               ---------------------------------------------- Function(asd) -------------------------------------------------------

    // class Islem
    // {
    //     // public int Toplama(int x, int y=0, int z=0)
    //     // {
    //     //     Console.WriteLine("x " + x);
    //     //     Console.WriteLine("y " + y);
    //     //     Console.WriteLine("z " + z);

    //     //     return x + y + z;
    //     // }

    //     public int Toplama(params int[] sayilar)
    //     {
    //         int toplam=0;
    //         foreach (var sayi in sayilar)
    //         {
    //             toplam += sayi;
    //         }
    //         return toplam;
    //     }
    // }

    // class Program
    // {
    //     static void Main(string[] args)
    //     {
    //         var islem = new Islem();

    //         // Console.WriteLine(islem.Toplama(10, 20, 30));
    //         // Console.WriteLine(islem.Toplama(y: 20, z: 30, x: 10)); // Named 
    //         // Console.WriteLine(islem.Toplama(10,20)); // default 
    //         Console.WriteLine(islem.Toplama(10)); 
    //         Console.WriteLine(islem.Toplama(10,20)); 
    //         Console.WriteLine(islem.Toplama(10,20,30)); 
    //         Console.WriteLine(islem.Toplama(10,20,30,40)); 

// ------------------------------------------------ Function() Aşırı Yükleme Mantığı -----------------------------------------------------------

        // Bu şekilde bir function'un birden fazla halde metodu olanları yazılırsa biz bu function'lardan istediğimizi seçip çalışabiliriz.

        // public int Toplama(int a, int b)
        // {
        //     return a + b;
        // }
        // public int Toplama(int a, int b, int c)
        // {
        //     return a + b + c;
        // }

        // public int Toplama(int a, int b, int c, int d)
        // {
        //     return a + b + c + d;
        // }

// ----------------------------------------------------------- Constructor ------------------------------------------------------------------


// class Comment
//     {
//         public int CommentId { get; set; }
//         public string Text { get; set; }
//     }

//     class Product
//     {
//         public Product()
//         {
//             this.ProductId = (new Random()).Next(11111,99999);
//             this.Comments = new Comment[3];
//         }

//         public Product(int productId):this()
//         {
//             this.ProductId = productId;
//         }

//         public Product(int productId,string name,double price,bool isApproved):this(productId)
//         {
//             this.Name = name;
//             this.Price=price;
//             this.IsApproved=isApproved;
//         }


//         public int ProductId { get; set; }
//         public string Name { get; set; }
//         public double Price { get; set; }
//         public bool IsApproved { get; set; }
//         public Comment[] Comments { get; set; }
//     }
//     class Program
//     {
//         static void Main(string[] args)
//         {

//             var c1 = new Comment { CommentId=1,Text="Güzel telefon"};

//             var p1 = new Product();

//             p1.Comments[0] = c1;

//             Console.WriteLine(p1.ProductId);            
//             Console.WriteLine(p1.Name);            
//             Console.WriteLine(p1.Price);            
//             Console.WriteLine(p1.IsApproved);         
//             Console.WriteLine(p1.Comments[0].Text);         

//             Console.WriteLine("*********************");

//             var p2 = new Product(1213);

//             p2.Comments[0] = c1;

//             Console.WriteLine(p2.ProductId);            
//             Console.WriteLine(p2.Name);            
//             Console.WriteLine(p2.Price);            
//             Console.WriteLine(p2.IsApproved); 
//             Console.WriteLine(p2.Comments[0].Text);       

//             Console.WriteLine("*********************");
            
//             var p3 = new Product(1231,"samsung s7",3000,true);

//             Console.WriteLine(p3.ProductId);            
//             Console.WriteLine(p3.Name);            
//             Console.WriteLine(p3.Price);            
//             Console.WriteLine(p3.IsApproved);   

//             p3.Comments[0] = c1;
//             Console.WriteLine(p3.Comments[0].Text);  

//         }
//     }

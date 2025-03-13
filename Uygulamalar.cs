// class Uygulamalar
// {
    // static void Main(string[] args)
    // {

    //  ---------------------------------- Bankamatik Uygulaması ------------------------------------

    // string secim = "";
    // double bakiye = 0;

    // do
    // {
    //     Console.Write("1-Bakiye Görüntüle\n2-Para Yatırma\n3-Para Çek\n4-Çıkış\nSeçiminiz: ");
    //     secim = Console.ReadLine();

    //     switch (secim)
    //     {

    //         case("1"):
    //             Console.WriteLine($"{bakiye}");
    //             break;
    //         case("2"):
    //             Console.Write("Yatırılıcak Değer: ");
    //             int yatirilan = int.Parse(Console.ReadLine());
    //             bakiye += yatirilan;
    //             break;
    //         case("3"):
    //             Console.Write("Çekilecek Değer: ");
    //             int çekilen = int.Parse(Console.ReadLine());

    //             if(çekilen > bakiye) {
    //                 Console.WriteLine("Çekilmek İstenen Değer Bakiyenizde Bulunandan Fazladır");
    //             } else {
    //                 bakiye -= çekilen;
    //                 Console.WriteLine("Çekim İşlemi Başaralı");
    //             }
    //             break;
    //         case("4"):
    //             secim = "4";
    //             break;

    //         default:
    //             Console.WriteLine("Hatalı Seçim");
    //             break;
    //     }

    // } while (secim!="4");

    // Console.WriteLine("Uygulamdan Çıkıldı");
// }

// }

class ÜrünBilgisi
{
    public string name { get; set; }
    public int price { get; set; }
    public string description { get; set; }
}

class Ürünler
{

    static void Main(string[] args)
    {

        ÜrünBilgisi ürün = new ÜrünBilgisi();
        string secim = "";

        do
        {

            Console.WriteLine(" Ürün Girmek İçin - 1 \n Ürünlere Bakmak İçin - 2 \n Çıkış İçin - 3 \n Seçiniz: ");
            secim = Console.ReadLine();
            Console.WriteLine(secim);

            switch (secim) {
            
                case "1":
                    Console.Write("Ürün İsmi: ");
                    ürün.name = Console.ReadLine();

                    Console.Write("Ürün Fiyatı: ");
                    ürün.price = int.Parse(Console.ReadLine());

                    Console.Write("Ürün Açıklaması: ");
                    ürün.description = Console.ReadLine();

                    Console.WriteLine("Ürününüz Başarı İle Kaydedildi");

                    break;
                case "2":
                    Console.WriteLine($" Ürün İsmi: {ürün.name} \n Ürün Fiyatı: {ürün.price} \n Ürün Açıklaması {ürün.description}");
                    break;

                case "3":
                    secim = "3";
                    break;
                default:
                    Console.WriteLine("Lütfen Belirten Rakamlardan Birini Giriniz");
                    break;
            }
        } while (secim != "3");

       Console.WriteLine("Uygulamadan Çıkıldı");

    }
}


// string[] isimler = {"Ali","Ahmet", "Çınar", "Taner"};

// isimler[0] = "Ali";

// Burdaki SetValue değeri 0. indexte ki değeri Ali yap anlamına gelir.
// isimler.SetValue("Ali",0);

// GetValue değeri 0. index değerini getir anlamına gelir.
// Console.WriteLine(isimler.GetValue(0));

// Array demek dizi demektir IndexOf ise Array üzerinden isimler'in içindeki Çınar değerinin index değerini öğrenir.
// Console.WriteLine(Array.IndexOf(isimler,"Çınar"));
// Console.WriteLine(isimler.Length);


// Sort değeri isimler değerini alfabetik sıraya göre sıralar eğer sayı ise küçükten büyüğe sıralar.
// Array.Sort(isimler);
// Console.WriteLine(isimler.GetValue(0));

// Reverse değeri içerisine girilen değeri döndürür.
// Array.Reverse(isimler);

// Burada Clear istediğimiz aralıkta ki değerin silinmesini sağlar burada dediğimiz şey isimler dizisindeki 0. indexten 2. index'e kadar ki değeri sil anlamına gelir.
// Array.Clear(isimler,0,2);


// Buradaki ^ değeri sayesinde dizi içerisinde sondan başlayarak index değeri istiyebiliriz ve sondan başladığımız için index değeri 0 dan değil 1 den başlar.
// Console.WriteLine(isimler[^2]);


// Buradaki 1..3 değeri 1. değerden 3. değere kadar getir anlamına gelir.
// var result = isimler[1..3];

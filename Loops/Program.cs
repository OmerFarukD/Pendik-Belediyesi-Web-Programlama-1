
// 0 den 20 ye kadar tüm tek ve çift sayıları ekrana bastıran kodu yazınız.

//  1. Yöntem
//for(int i=0; i<=20; i += 2)
//{
//    Console.WriteLine($"Çift sayı : {i}");
//}

//for (int i = 1; i<=20; i+=2)
//{
//    Console.WriteLine($"Tek sayılar : {i}");
//}

//for(int i = 0; i<=20; i++)
//{
//    if (i % 2 ==0)
//    {
//        Console.WriteLine($"Çift Sayı : {i}");
//    }
//    else
//    {
//        Console.WriteLine($"Tek Sayı : {i}");
//    }
//}

// Kullanıcıdan aç adet bilgi gireceğini tutan bir değer alınız
// kullanıcının adı : soyadı: yaş 
// Ekran Çıktısı olarak şunu ver 
// 1. Kişi adı : , soyadı: , yaşı: 

Console.WriteLine("Kaç adet bilgi girmek istersiniz: ");
int adet = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i<adet; i++)
{
    Console.WriteLine("Lütfen isim giriniz: ");
    string name = Console.ReadLine();

    Console.WriteLine("Lütfen soyisim giriniz: ");
    string surname = Console.ReadLine();

    Console.WriteLine("Lütfen yaşınızıgiriniz: ");
    int age = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"{i+1}. kişinin adı : {name}, soyadı: {surname}, yaşı:{age}");
}










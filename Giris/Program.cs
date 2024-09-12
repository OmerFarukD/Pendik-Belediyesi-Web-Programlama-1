// See https://aka.ms/new-console-template for more informatio


Console.WriteLine("bugun c# eğitiminin ilk günü !");  // concole.writeLine : konsolda yazı yazmak için bir metod.
Console.WriteLine(123 * 965);
Console.WriteLine("123*965");


// STRİNG:: metinsel ifadeleri tuttuğımız veri yapılarıdır.
//değişken nasıl oluşturulu ???  veri  tipi değişkenin adı = değer ; 
//string ad = "Figen ";
//string soyad = "aycil";



//Console.WriteLine("Lüften isim giriniz. ");

//String name  = Console.ReadLine();

//Console.WriteLine("lütfen soyisim giriniz.");

//String lastName = Console.ReadLine();

//Console.WriteLine("lütfen yaşınızı giriniz.");

//int age; 
    
//age = Convert.ToInt32(Console.ReadLine());


//Console.WriteLine($" ismim: {name} soyisim:  {lastName} yaşım: {age}");


// double : ondalıklı sayıları tutan veri tipidir 

double number1 = 22;
double number2 = 7;

// float : ondalıklı sayılar için kullanılır 

float number3 = 10.4f;
Console.WriteLine(number3);
Console.WriteLine(number1/number2);

// bool (Doğruluk) : True veya false değerler alır. 

bool dogru = true;
Console.WriteLine(dogru);

bool yanlis = false;
Console.WriteLine(yanlis);
// karşılaştırma operatörleri. 
// < küçüktür
// > büyüktür
// <= küçük eşittir
// >= büyük eşittir
// == eşit midir ?
// != eşit değil midir ?

Console.WriteLine(3<5);

Console.WriteLine(4>=6); // false
Console.WriteLine(3!=3); // false
Console.WriteLine(3==4); // false
Console.WriteLine(4<=4); // true
Console.WriteLine(5>=5); // true
Console.WriteLine(5<9); // true
Console.WriteLine(6>6); // false
Console.WriteLine(3<3); // false

// mantıksal operatörler : (&& ve , || veya)

Console.WriteLine();
//                  true  and true = true

var sonuc = (3 < 5 || 5 != 6) && 3 != 0;
Console.WriteLine(sonuc.GetType());

// Ternary operatör : 
// Kullanıcıdan yaş değişkenini alıp yaşı 18 den büyük eşit ise Ehliyet alabilir
// aksi takdirde ehliyet alamaz.

//Console.WriteLine("Lütfen yaşınızı giriniz : ");
//int age = Convert.ToInt32(Console.ReadLine());

//string ehliyetDurumu = age >= 18 ? "Ehliyet alabilir" : "Ehliyet alamaz.";
//Console.WriteLine(ehliyetDurumu);

// kullanıcıdan bir sayı değeri alıp eğer sayı 10 dan büyük eşit ise 
// ekran çıktısı olarak sayı 10 dan büyük eşittir.
// aksi durumda sayı 10 dan küçüktür. 

// Karar mekanizmaları : (if- else)

// if else: 
// Kullanıcıdan yaş değişkenini alıp yaşı 18 den büyük eşit ise Ehliyet alabilir
// aksi takdirde ehliyet alamaz.

//Console.WriteLine("Lütfen yaşınızı giriniz : ");
//int age = Convert.ToInt32(Console.ReadLine());


//if (age>=18)
//{
//    Console.WriteLine("Ehliyet alabilir");
//}
//else
//{
//    Console.WriteLine("Ehliyet alamaz.");
//}

// kullanıcı adı : admin
// parola : 12345

// kullanıcıdan bir tane kullanıcı adı bir tane de parola alalım.
// parola hatalıysa parola hatalıdır
// kullanıcı adı hatalıysa kullanıcı adı hatalıdır.
// aksi durumda giriş başarılı.

//string username = "admin";
//string password = "12345";

//Console.WriteLine("Lütfen kullanıcı adınızı giriniz : ");
//string inputUsername = Console.ReadLine();

//Console.WriteLine("Lütfen parolanızı girini: ");
//string inputPassword = Console.ReadLine();


//if (inputUsername != username || inputPassword != password)
//{
//    Console.WriteLine("Kullanıcı adı veya parola hatalıdır.");
//}
//else
//{
//    Console.WriteLine("Giriş başarılıdır.");
//}

// Kullanıcıdan bir puan alarak  50 üstü ise d
// 60 üstü ise c
// 70 üstü ise b
// 80 üstü ise A
// 90 üstü ise A+
// 100 ise S 

//Console.WriteLine("Lütfen puanınızı giriniz.");
//int puan = Convert.ToInt32(Console.ReadLine());

//if (puan<50)
//{
//    Console.WriteLine("Kaldınız.");
//    return;
//}

//else if(puan>=50 && puan <60)
//{
//    Console.WriteLine("C");
//}
//else if (puan >=60 && puan < 70)
//{
//    Console.WriteLine( "C ile b arasında kalıyor");
//}
//else if (puan >=70 && puan <80)
//{
//    Console.WriteLine("b");
//}
//else if (puan >= 80 && puan <90)
//{
//    Console.WriteLine("a");
//}
//else if (puan >= 90 && puan<100)
//{
//    Console.WriteLine("a+");
//}
//else if (puan == 100)
//{
//    Console.WriteLine("s");
//}
//else
//{
//    Console.WriteLine("Lütfen 1 ile 100 arasında bir puan giriniz.");
//}

// 1 den 4 e kadar kullanıcıdan bir sayı alınız rakamların karşılığı şu şekil olacak:
// 1 -> İlkBahar
// 2 -> Yaz
// 3 -> SonBahar
// 4 -> Kış 
//Console.WriteLine("Lütfen bir değer arılığı giriniz :");
//int deger = Convert.ToInt32(Console.ReadLine());
//string mevsim=string.Empty;
// 1. Yöntem
//switch (deger)
//{
//    case 1:
//        mevsim = "İlkbahar";
//        break;
//    case 2:
//        mevsim = "Yaz";
//        break;
//    case 3:
//        mevsim = "Sonbahar";
//        break;
//    case 4:
//        mevsim = "Kış";
//        break;

//    default:
//        Console.WriteLine("Yanlış değer aralığı girdiniz.");
//        break;
//}

//mevsim = deger switch
//{
//    1 => "İlkbahar",
//    2 => "Yaz",
//    3 => "Sonbahar",
//    4 => "Kış",
//    _ => "Geçersiz sayı girdiniz. Lütfen 1 ile 4 arasında bir rakam giriniz"
//};
//Console.WriteLine(mevsim);

// Basit bir hesap makinesi uygulaması yapınız(+,/,*,-,%,u(üs alma))

Console.WriteLine("Lütfen 1. sayıyı giriniz: ");
int sayi1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Lütfen 2. sayıyı giriniz: ");
int sayi2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("İşlemi seçiniz : (+,/,*,-,%,u(üs alma)");
string _operator = Console.ReadLine();

if (_operator == "+")
{
    Console.WriteLine($"{sayi1} + {sayi2} = {sayi1 + sayi2}");
}

else if (_operator == "-")
{
    Console.WriteLine($"{sayi1} - {sayi2} = {sayi1 - sayi2}");
}

else if (_operator == "/")
{
    Console.WriteLine($"{sayi1} / {sayi2} = {sayi1 / sayi2}");
}
else if (_operator == "*")
{
    Console.WriteLine($"{sayi1} * {sayi2} = {sayi1 * sayi2}");
}
else if (_operator == "u")
{
    Console.WriteLine($"{sayi1} in {sayi2} üssü  {Math.Pow(sayi1, sayi2)}");
}
else
{
    Console.WriteLine("Geçersiz karakter girdiniz.");
}


switch (_operator)
{
    case "+":
        Console.WriteLine($"{sayi1} + {sayi2} = {sayi1 + sayi2}");
        break;
    case "-":
        Console.WriteLine($"{sayi1} - {sayi2} = {sayi1 - sayi2}");
        break;
    case "/":
        Console.WriteLine($"{sayi1} / {sayi2} = {sayi1 / sayi2}");
        break;
    case "*":
        Console.WriteLine($"{sayi1} * {sayi2} = {sayi1 * sayi2}");
        break;
    case "u":
        Console.WriteLine($"{sayi1} in {sayi2} üssü  {Math.Pow(sayi1, sayi2)}");
        break;
    default:
        Console.WriteLine("Geçersiz karakter girdiniz.");
        break;
}

string result = _operator switch
{
    "+" => $"{sayi1} + {sayi2} = {sayi1 + sayi2}",
    "-" => $"{sayi1} - {sayi2} = {sayi1 - sayi2}",
    "*" => $"{sayi1} * {sayi2} = {sayi1 * sayi2}",
    "/" => $"{sayi1} / {sayi2} = {sayi1 / sayi2}",
    "u" => $"{sayi1} in {sayi2} üssü  {Math.Pow(sayi1, sayi2)}"
};
Console.WriteLine(result);






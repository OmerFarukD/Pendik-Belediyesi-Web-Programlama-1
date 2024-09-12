//string[] sehirler = {"İstanbul","Ankara","İzmir","Kocaeli","Sakarya","Malatya","Adıyaman","Eskişehir"};

////                       0         1        2        3         4         5        6           7

//for (int i = 0; i < sehirler.Length; i++)
//{
//    Console.WriteLine(sehirler[i]);
//}


//Console.WriteLine("Foreach yöntemi ile gösterimi : ");
//foreach (string sehir in sehirler)
//{
//    Console.WriteLine(sehir);
//}

//// ülekeler adında bir dizi oluşturun 5 tane eleman ekleyin
//// görev1 : 2. elemanı gösteriniz.
//// görev2 : 2. indexteki elemanı gösteriniz
//// görev3 : for döngüsü ile bütün elemanları ekrana yazdır
//// görev4 : foreach döngüsü ile bütün elemanları ekrana yazdır.

//string[] countries = { "Uganda", "Arabistan", "Germanya", "Türkiye", "Kanada" };
//Console.WriteLine(countries[1]);
//Console.WriteLine(countries[2]);

//for (int i = 0; i<countries.Length; i++)
//{
//    Console.WriteLine($"{i+1}. Şehir : {countries[i]}");
//}

int[] numbers = { 9, 3, 5, 11, 2, 1, 4, 3, 7, 88, 100 };
Array.Sort(numbers);

foreach (int number in numbers)
{
    Console.WriteLine(number);
}
Console.WriteLine("Büyükten küçüğe : ");
Array.Reverse(numbers);
foreach (int number in numbers)
{
    Console.WriteLine(number);
}

// numbers dizisinden 4 ten büyük olanları ekran çıktısı olarak veren kodu yazınız.

Console.WriteLine("4 ten büyük sayılar.");
foreach (int number in numbers)
{
    if (number > 4)
    {
        Console.WriteLine(number);
    }
}

// lambda yöntemi
Console.WriteLine("Lambda expression yöntemi");
int[] filteredNumbers = Array.FindAll(numbers, x => x > 4);

//foreach (int item in filteredNumbers)
//{
//    Console.WriteLine(item);
//}
Array.ForEach(filteredNumbers, x => Console.WriteLine(x));

// Şehirler adında bir dizi oluşturunuz 
// İstanbul , Malatya, Ankara,Eskişehir, Nevşehir, Erzurum

// Bu şehirler dizisinde Şehir adlarında a veya A harfi geçen şehirleri ekrana
// bastıran kodu yazınız.

string[] sehirler = { "İstanbul", "Malatya", "Ankara", "Eskişehir", "Nevşehir", "Erzurum" };

//foreach (string sehir in sehirler)
//{

//    // 1. Yöntem : sehir.ToLower().Contains("a")
//    // 2. Yöntem : sehir.Contains("A") || sehir.Contains("a")
//    // 3. Yöntem: 
//    if (sehir.Contains("a",StringComparison.InvariantCultureIgnoreCase))
//    {
//        Console.WriteLine(sehir);
//    }
//}

//2. Yöntem 
//string[] filteredCities = Array.FindAll(sehirler , x=> x.Contains("a",StringComparison.InvariantCultureIgnoreCase));
//Array.ForEach(filteredCities, x => Console.WriteLine(x));

//Array.ForEach(sehirler, x =>
//{
//    if (x.Contains("a", StringComparison.InvariantCultureIgnoreCase))
//    {
//        Console.WriteLine(x);
//    }
//});

int[] sayilar = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//int[] tekSayilar = Array.FindAll(sayilar, x=> x%2==1);
//int[] ciftSayilar = Array.FindAll(sayilar, x => x % 2 == 0);

//Console.WriteLine("Çift sayılar: ");
//Array.ForEach(ciftSayilar, x => Console.WriteLine(x));

//Console.WriteLine("Tek sayılar: ");
//Array.ForEach(tekSayilar, x => Console.WriteLine(x));

Console.WriteLine("While döngüsü");
int i = 0;
while (i<sayilar.Length)
{
    Console.WriteLine(sayilar[i]);
    i++;
}




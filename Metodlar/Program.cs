
// Ekran Çıktısı olarak bana Merhaba dünya yazsın;
// Değer döndürmeyen metodlar;
// Kullanıcıdan 3 tane sınav notu alınız bu sınav notunun
// ortalamasını ekrana yazdıran fonksiyonu yazınız.

Console.WriteLine("Lütfen 1. Notu giriniz: ");
int sinav1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Lütfen 2. Notu giriniz: ");
int sinav2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Lütfen 3. Notu giriniz: ");
int sinav3 = Convert.ToInt32(Console.ReadLine());

Print(sinav1,sinav2,sinav3);


void Print(int not1, int not2, int not3)
{
    // ortalama hesapla

    double ortalama = OrtalamaHesapla(not1,not2,not3);
    ShowToAverage(not1,not2,not3,ortalama);
}

void ShowToAverage(int not1, int not2, int not3, double ortalama)
{
    Console.WriteLine($"1. Sınavınız : {not1}");
    Console.WriteLine($"2. Sınavınız : {not2}");
    Console.WriteLine($"3. Sınavınız : {not3}");
    Console.WriteLine($"Ortalamanız : {ortalama}");
}

double OrtalamaHesapla(int not1, int not2, int not3)
{
    double ortalama = (not1+ not2+not3)/3;
    return ortalama;
}

void SayHello()
{
    Console.WriteLine("Merhaba Dünya");

}

void Info(string name)
{
    Console.WriteLine($"Merhaba : {name}");
}

void Info2(string name, string surname, int age)
{
    Console.WriteLine($"isim : {name}, soyisim: {surname}, yaş : {age}");
}

int Topla(int sayi1, int sayi2)
{
    return sayi1 + sayi2;
}

void PrintResult(int a, int b)
{

    int toplam = Topla(a,b);
    EkranaYazdir(a,b, toplam);
}

void EkranaYazdir(int sayi1, int sayi2, int toplam)
{
    Console.WriteLine($"{sayi1} + {sayi2} = {toplam}");
}


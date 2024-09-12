
Console.WriteLine(Topla(2,55,10,35,45,88));



Console.WriteLine(Carpma(1,2,3,4,5));

Print(5, 3);

int bolumSonuc;
int kalanSonuc;

Bolme(10,3, out bolumSonuc, out kalanSonuc);

Console.WriteLine($"10 / 3 = {bolumSonuc}");
Console.WriteLine($"10 % 3 = {kalanSonuc}");

string buyuk;
string kucuk;

Donustur("MeRhaBaLaR HeRkEzE", out buyuk, out kucuk);

Console.WriteLine($"{buyuk} -> {kucuk}");


// Kombinasyon



void Donustur(string metin, out string buyuk, out string kucuk)
{
    buyuk = metin.ToUpper();
    kucuk = metin.ToLower();
}

int Topla(params int[] sayilar)
{
    int total=0;

    foreach (int sayi in sayilar)
    {
        total = total + sayi;
    }
    return total;
}

// params keywordunu kullanarak çarpma işlemini yapınız

void Print(int sayi1, int sayi2)
{
    double permutasyon = Permutasyon(sayi1, sayi2);
    double kombinasyon = Kombinasyon(sayi1, sayi2);
    Ekran(sayi1, sayi2, permutasyon, kombinasyon);
}

void Ekran(int sayi1, int sayi2, double permutasyon, double kombinasyon)
{
    Console.WriteLine($"1. Sayı : {sayi1}");
    Console.WriteLine($"2. Sayı : {sayi2}");
    Console.WriteLine($"Permutasyon => P({sayi1},{sayi2}) : {permutasyon}");
    Console.WriteLine($"Kombinasyon => C({sayi1},{sayi2}) : {kombinasyon}");
}

void Bolme(int bolunen, int bolen, out int bolum, out int kalan)
{
    bolum = bolunen / bolen;
    kalan = bolunen % bolen;
}


double Permutasyon(int n, int r)
{
    return Faktoriyel(n) / Faktoriyel(n-r);
}

double Kombinasyon(int n, int r)
{
    return Faktoriyel(n) / (Faktoriyel(n - r) * Faktoriyel(r));
}

double Faktoriyel(int n)
{
    double result = 1;

    for (int i = 1; i<=n; i++)
    {
        result = result *i;
    }
    return result;
}
double Carpma(params int[] sayilar)
{
    int i = 1;
    foreach (int sayi in sayilar)
    {
        i = i * sayi;
    }
    return i;
}

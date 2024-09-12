// Car adında bir class oluşturunuz 
// Marka, Model, MotorGücü, Renk, VitesTipi



//  Ev -> Kaçıncı kat, Apartman adı, kiralık ücreti, oda sayısı
// salon sayısı

 

//Console.WriteLine();
//Car car = new Car();
//car.Marka = "Mercedes";
//car.Renk = "Siyah";
//car.Model = 2022;
//car.VitesTipi = "Manuel";
//car.MotorGucu = 180;

//Car car2 = new Car();
//car2.Marka = "BMW";
//car2.Renk = "Beyaz";
//car2.Model = 2024;
//car2.VitesTipi = "Otomatik";
//car2.MotorGucu = 200;

////2. Yöntem
//Car car3 = new();
//car3.Marka = "Ferrari";
//car3.Model = 1978;
//car3.Renk = "Kırmızı";
//car3.VitesTipi = "Manuel";
//car3.MotorGucu = 571;
//Car car4 = new()
//{
//    Marka= "Lotus elise",
//    Model = 2009,
//    MotorGucu = 400,
//    Renk = "Sarı",
//    VitesTipi= "Manuel"
//};

//Console.WriteLine("-----------------------------------");
//car3.EkranaYaz();
//Console.WriteLine("-----------------------------------");


//Console.WriteLine("-----------------------------------");
//car4.EkranaYaz();
//Console.WriteLine("-----------------------------------");

//car.EkranaYaz();
//Console.WriteLine("---------------------------");
//car2.EkranaYaz();
//Console.WriteLine("---------------------------");

Car car5 = new Car(string.Empty,2000,200,"Kırmızı","Otomatik");
Car car6 = new Car("Renault", 2018, 200, "Kırmızı", "Otomatik");

//Console.WriteLine(car5.Marka == car6.Marka);

//car5.EkranaYaz();
//Console.WriteLine("---------------------------------");
//CarManager carManager = new CarManager(car6);
//carManager.Add();
//carManager.Update();
//carManager.Remove();
Console.WriteLine(car5);

CarManager carManager = new CarManager(car5);
carManager.Add();


class Car
{
    public Car()
    {
        
    }

    public Car(string marka, int model, int motorGucu, string renk, string vitesTipi)
    {
        Marka = marka;
        Model = model;
        MotorGucu=motorGucu;
        Renk=renk;
        VitesTipi=vitesTipi;
    }


   public string Marka;
   public int Model;
   public int MotorGucu;
   public string Renk;
   public string VitesTipi;

    public void EkranaYaz()
    {
        Console.WriteLine($"Aracın markası : {Marka}");
        Console.WriteLine($"Aracın Rengi : {Renk}");
        Console.WriteLine($"Aracın modeli : {Model}");
        Console.WriteLine($"Aracın Vites Tipi : {VitesTipi}");
        Console.WriteLine($"Aracın Motor Gücü : {MotorGucu}");
    }

    public override string ToString()
    {
        return $"Marka : {Marka}, Renk: {Renk}, Model: {Model}" +
            $"Vites : {VitesTipi}, Motor Gücü : {MotorGucu}";
           
    }
}

class CarManager
{
    Car car1;


    public CarManager(Car car)
    {
        car1 = car;
    }
    public void Add()
    {

        if (car1.Model <1900)
        {
            Console.WriteLine("Araç minimum 1900 model olmalıdır.");
            return;
        }
         //   
        if(car1.Marka.Length<1 || string.IsNullOrWhiteSpace(car1.Marka))
        {
            Console.WriteLine("Marka adı Boş olamaz veya minimum 1 haneli olmalıdır.");
            return;
        }

        // Motor gücü negatif değer alamaz
        // Renk minimum 2 karakterli olacak ve null olmayacak

        Console.WriteLine("******************************");
        Console.WriteLine("Araç eklendi....");
        car1.EkranaYaz();
        Console.WriteLine("******************************");
    }

    public void Remove()
    {
        Console.WriteLine("******************************");
        Console.WriteLine("Araç silindi....");
        car1.EkranaYaz();
        Console.WriteLine("******************************");
    }

    public void Update()
    {
        Console.WriteLine("******************************");
        Console.WriteLine("Araç güncellendi....");
        car1.EkranaYaz();
        Console.WriteLine("******************************");
    }
}
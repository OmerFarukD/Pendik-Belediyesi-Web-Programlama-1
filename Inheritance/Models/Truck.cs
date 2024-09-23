namespace Inheritance.Models;

public sealed class Truck :  MotorVehicle
{
 
  

    public bool Dorse { get; set; }

    public override string ToString()
    {
        return $"Id: {Id},Kapı Sayısı: {NumberOfDoor}, Yakıt Tipi :" +
            $"{FuelType}, Vites Tipi: {TransmissionType} Renk: {Color}" +
            $"Kilometre: {Kilometer}, Dorse : {Dorse}";
    }
}

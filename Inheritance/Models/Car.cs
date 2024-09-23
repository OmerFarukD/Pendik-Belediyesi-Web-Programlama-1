
namespace Inheritance.Models;

public sealed class Car : MotorVehicle
{
    


    public override string ToString()
    {
        return $"Id: {Id},Kapı Sayısı: {NumberOfDoor}, Yakıt Tipi :" +
            $"{FuelType}, Vites Tipi: {TransmissionType} Renk: {Color}" +
            $"Kilometre: {Kilometer}";
    }
}

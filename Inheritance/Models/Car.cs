
namespace Inheritance.Models;

public class Car
{
    public int Id { get; set; }
    public int NumberOfDoor { get; set; }

    public string FuelType { get; set; }
    public string TransmissionType { get; set; }

    public string Color { get; set; }

    public int  Kilometer { get; set; }

    public override string ToString()
    {
        return $"Id: {Id},Kapı Sayısı: {NumberOfDoor}, Yakıt Tipi :" +
            $"{FuelType}, Vites Tipi: {TransmissionType} Renk: {Color}" +
            $"Kilometre: {Kilometer}";
    }
}

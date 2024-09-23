
namespace Inheritance.Models;

public abstract class MotorVehicle : Vehicle
{
    public int NumberOfDoor { get; set; }

    public string FuelType { get; set; }


    public int Kilometer { get; set; }
    public string UpdatedDate { get; set; }
}


using Inheritance.Models;

Car car = new Car()
{
    Id = 1,
    Color ="red",
    CreatedDate = "23-09-2024",
    FuelType = "Benzin",
    Kilometer = 15000,
    NumberOfDoor = 4,
    TransmissionType = "Otomatik",
    UpdatedDate =null,
};

Vehicle vehicle = new Vehicle();
MotorVehicle vehicleMotor = new MotorVehicle();

Console.WriteLine(car);

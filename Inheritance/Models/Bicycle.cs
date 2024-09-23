using Microsoft.VisualBasic.FileIO;

namespace Inheritance.Models;

public sealed class Bicycle : Vehicle
{
  

    public bool IsAmortisor { get; set; }

    public override string ToString()
    {
        return $"Id: {Id}," +
            $" Vites Tipi: {TransmissionType} Renk: {Color}" +
            $"Amortisor: {IsAmortisor}";
    }
}

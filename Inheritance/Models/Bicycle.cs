﻿using Microsoft.VisualBasic.FileIO;

namespace Inheritance.Models;

public class Bicycle
{
    public int Id { get; set; }
    public string TransmissionType { get; set; }
    public string Color { get; set; }

    public bool IsAmortisor { get; set; }

    public override string ToString()
    {
        return $"Id: {Id}," +
            $" Vites Tipi: {TransmissionType} Renk: {Color}" +
            $"Amortisor: {IsAmortisor}";
    }
}
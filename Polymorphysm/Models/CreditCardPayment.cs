using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphysm.Models;

public class CreditCardPayment : BasePayment
{
    public string CardNumber { get; set; }
    public string CVV { get; set; }
    public string FullName { get; set; }
    public string EndDate { get; set; }

    public override void Payment()
    {
        Console.WriteLine($"Kart Sahibi : {FullName}, Tutar : {Amount}");
    }
}


namespace Polymorphysm.Models;

public class PaypalPayment : BasePayment
{
    public string Email { get; set; }

    public override void Payment()
    {
        Console.WriteLine($"Email : {Email} , hesabından Tutar : {Amount}");
    }
}

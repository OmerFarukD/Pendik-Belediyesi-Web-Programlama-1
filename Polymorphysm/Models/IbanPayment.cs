namespace Polymorphysm.Models;

public class IbanPayment : BasePayment
{

    public string IbanNo { get; set; }
    public string FullName { get; set; }
    public override void Payment()
    {
        Console.WriteLine($"Alıcı Hesap : {FullName}, Tutar : {Amount}");
    }
}

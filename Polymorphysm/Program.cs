using Polymorphysm.Models;
// Çalışan-> Maaş , Adı , soyadı , yaş
// BilgiVer();
// ZamYap(int zamOrani);

// Yazılımcı -> Maaş , Adı , soyadı , yaş , Programlama Dili(string)
// Yönetici -> Maaş , Adı , soyadı , yaş, Ekip sayısı


BasePayment Pay = new IbanPayment()
{
    Amount = 100,
    FullName = "deneme",
    IbanNo = "TR0005554658863"
};

if (Pay.GetType() == typeof(CreditCardPayment))
{
    Console.WriteLine("Kredi kartı ile ödendi");
    Pay.Payment();
}else if(Pay.GetType()  == typeof(PaypalPayment))
{
    Console.WriteLine("Paypal ile ödendi");
    Pay.Payment();
}
else
{
    Console.WriteLine("Iban ile ödendi");
    Pay.Payment();
}


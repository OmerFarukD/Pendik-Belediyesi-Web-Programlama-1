// Kullanıcının sisteme giriş yapılması isteniyor
// User -> FirstName, LastName, Email ,UserName, Password, FullName

using Encapsulation;

User user = new User()
{
    FirstName="Ömer Faruk ",
    LastName = "Doğan",
    Email = "omerdogan_cezaevi@gmail.com",
    Password = "123456",
    UserName = "qubitfaruk"
};

Book book = new Book()
{
    AuthorName = "Sait Faik",
    AuthorSurname= "Abası Yanık",
    Description = "En sevdiğim harikaa Sütlacı çok severim arkadaşlar.",
    PublishDate = "25 Ocak 2004",
    Publisher = "ISKA yayın evi",
    Title = "ISKA da Trajikomik olaylar."
};

Console.WriteLine(book);


Console.WriteLine(user.LastName);


// kitap -> Başlığı , Açıklaması , Yazar Adı, Yazar Soyadı,
// Yayın evi ,Basım Tarihi ,
//Yazar Tam adı,  (Yayın evi - Basım Tarihi)
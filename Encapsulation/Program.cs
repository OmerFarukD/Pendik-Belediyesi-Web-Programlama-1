// Kullanıcının sisteme giriş yapılması isteniyor
// User -> FirstName, LastName, Email ,UserName, Password, FullName

using Encapsulation;

User user = new User()
{
    FirstName="Ömer Faruk ",
    LastName = "Doğan",
    Email = "omerdogan_cezaevi@gmail.com",
    Password = "123456",
    UserName = "qubitfaruk",
   
};

Console.WriteLine(user.LastName);



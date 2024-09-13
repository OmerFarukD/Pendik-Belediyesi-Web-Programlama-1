namespace Encapsulation;
// User -> FirstName, LastName, Email ,UserName, Password, FullName

// Firstname ve lastname minimum 2 haneli olmalıdır.
// Email @gmail.com ile bitmelidir.
// Password minimum 6 haneli olmalıdır
public class User
{
    private string firstname;
    private string email;
    private string password;
    private string fullName;


    public string FirstName 
    {
        get
        {
            return firstname;
        }

        set
        {

            firstname = value;

            if (firstname.Length < 2)
            {
                Console.WriteLine("İsim alanı minimum 2 haneli olmalıdır.");
                return;
            }

           
        }
    }
    public  string LastName { get; init; }
    public string Email 
    {
        get
        {
            return email;
        }
        set
        {

            email = value;
            if (!email.EndsWith("@gmail.com"))
            {
                Console.WriteLine("Düzgün email formatında değil.");
                return;
            }
        }
    }
    public string UserName { get; set; }
    public string Password {
        get
        {
            return password;
        }
        set
        {
            password = value;

            if (password.Length<6)
            {
                Console.WriteLine("Parola minimum 6 haneli olmalıdır.");
            }
        }
    }
    public string FullName {
        get
        {
            return $"{firstname} {LastName}";
        }

        private set
        {
            fullName = $"{firstname} {LastName}";
        }
    
    }

    public override string ToString()
    {
        return $"Ad: {FirstName}, Soyad: {LastName}, Email: {Email} " +
            $"Şifre : {Password}, Tam Ad: {FullName}";
    }
}

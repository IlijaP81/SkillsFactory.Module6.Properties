class Program
{
    static void Main(string[] args)
    {
        User user = new User();

        // Setter
        //user.Login = "ПА";
        //user.Mail = "123";

        user.Login = "ПАK";
        user.Mail = "123@";

        // Getter
        Console.WriteLine(user.Login + " " + user.Mail);

        Console.ReadKey();
    }
}

class User
{
    private string login;
    private string mail;

    public string Login
    {
        get
        {
            return login;
        }

        set
        {
            if (value.Length < 3) Console.WriteLine("Длина логина должна быть не меньше 3");
            else login = value;
        }
    }

    public string Mail
    {
        get
        {
            return mail;
        }
        set
        {
            if (!value.Contains("@")) Console.WriteLine("Отсутствует символ @");
            else mail = value;
        }
    }
}

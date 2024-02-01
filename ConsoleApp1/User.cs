
namespace ConsoleApp1;

public class User
{
    string _username;
    string _email;
    string _password;

    public string Username
    {
        get => _username;
        set
        {
            if (value.Length >= 1)
                _username = value;
            else
                throw new ArgumentException("Enter the name. NullReferenceError");
        }
    }
    public string Email
    {
        get => _email;
        set
        {
            if (value.Length > 1 && value.Contains('@'))
                _email = value;
            else
                throw new ArgumentException("Enter the email. NullReferenceError");
        }
    }
    public string Password
    {
        get => _password;
        set
        {
            if (value.Length > 5)
                _password = value;
            else
                throw new ArgumentException("Enter the min. 5 symbol.");
        }
    }

    public User(string password, string email, string username)
    {
        Password = password;
        Email = email;
        Username = username;
    }
    public User() { }

    void ChangePassword(string password) => Password = password;
    void ChangeEmail(string email) => Email = email;
    void ChangeUsername(string username) => Username = username;

    public override string ToString() => $"UserName: {Username}\nEmail: {Email}\nPassword: {Password}";
}

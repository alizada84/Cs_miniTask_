
namespace ConsoleApp1;

internal class Functions
{
    public static bool LoginUser(User user)
    {
        Console.Clear();
        while(true)
        {
            Console.WriteLine("Username(1) or Email(2) ?");
            byte result = byte.Parse(Console.ReadLine());

            if (result == 1)
            {
                Console.Write("Enter the UserName: ");
                string? username = Console.ReadLine();
                Console.WriteLine();

                Console.Write("Enter the Password: ");
                string? password = Console.ReadLine();

                if (user.Username == username && user.Password == password)
                {
                    return true;
                }
                else
                    return false;
            }
            else if (result == 2)
            {
                Console.Write("Enter the Email: ");
                string? email = Console.ReadLine();
                Console.WriteLine();

                Console.Write("Enter the Password: ");
                string? password = Console.ReadLine();

                if (user.Email == email && user.Password == password)
                {
                    return true;
                }
                else
                    return false;
            }
            else
                Console.WriteLine("Please Enter correct value");
        }
    }
    public static User EnterUser()
    {
        Console.Clear();

        Console.Write("Enter the UserName: ");
        string? username = Console.ReadLine();
        Console.WriteLine();

        Console.Write("Enter the Email: ");
        string? email = Console.ReadLine();
        Console.WriteLine();

        Console.Write("Enter the Password: ");
        string? password = Console.ReadLine();

        User newUser = new User(password, email, username);
        return newUser;
    }
}

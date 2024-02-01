using ConsoleApp1;

User user = new User();

bool IsCheck = true;

while(IsCheck)
{
    Console.WriteLine("Register => 1\nLogin => 2");
    Console.Write("Enter the Number: ");
    string? value = Console.ReadLine();
    Console.Clear();

    switch(value)
    {
        case "1":
            try
            {
                User newUser = Functions.EnterUser();
                user = newUser;
                Console.WriteLine(user);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Please Enter Correct Value..." + ex.Message);
            }
            break;
        case "2":
            try
            {
                bool check = Functions.LoginUser(user);
                if (check == false)
                {
                    Console.WriteLine("PLEASE ENTER CORRECT USER");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Please Enter Correct Value..." + ex.Message);
            }
            break;
        default:
            Console.WriteLine("Please Enter correct value... 1 or 2.");
            break;
    }
}
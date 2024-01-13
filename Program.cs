using OOP_Exercise_7;

while (true)
{
    try
    {
        Run();
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}
static void Run()
{
    Console.WriteLine("Choose An option:\n" +
        "1.Add User\n" +
        "2.Show Users\n" +
        "3.Show User Tuition & Expired MemberShip\n" +
        "0.Exit");
    var menu = int.Parse(Console.ReadLine());
    switch (menu)
    {
        case 0:
            {
                Environment.Exit(0); break;
            }
        case 1:
            {
                var userType = GetInt("Choose User Type:\n" +
                    "1. Normal 2. VIP");
                var userId = GetString("Enter User Id");
                var membershipDays = GetInt("Enter Number of Membership Days:");
                Gym.AddUser(userType, userId, membershipDays);

                break;
            }
            case 2:
            {
                Gym.ShowUser();
                break;
            }
            case 3:
            {
                var userId = GetString("Enter User ID:");
                Gym.ShowUserDetails(userId);
                break;
            }

    }
}
static string? GetString(string message)
{
    Console.WriteLine(message);
    var input = Console.ReadLine();
    return input;
}
static int GetInt(string message)
{
    Console.WriteLine(message);
    var input = int.Parse(Console.ReadLine());
    return input;
}
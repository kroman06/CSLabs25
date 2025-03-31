namespace Lab2;

class Program
{
	static void Main()
	{
        List<User> users =
        [
            new Admin("AdminUser", "admin@example.com"),
            new Moderator("ModUser", "mod@example.com"),
            new RegularUser("RegUser", "user@example.com")
        ];

        users[0].SetPassword("admin");
        users[1].SetPassword("mod");
        users[2].SetPassword("user");

        Console.WriteLine("=== Info about users ===");
        foreach (User user in users)
        {
            user.DisplayInfo();
        }
        Console.WriteLine("\n=== Testing methods ===");

        RegularUser? regUser = users[2] as RegularUser;
        if (users[0] is Admin adminUser && regUser != null)
        {
            adminUser.BlockUser(regUser);
        }

        if (users[1] is Moderator modUser)
        {
            modUser.ModerateContent();
        }

        if (regUser != null)
        {
            regUser.PostComment();
        }
        Console.WriteLine();

        Console.WriteLine("=== Auth checking ===");
        Console.Write("AdminUser: ");
        Console.WriteLine(users[0].Authenticate("admin")
            ? "Auth successful!"
            : "Invalid pass!");

        Console.Write("ModUser: ");
        Console.WriteLine(users[1].Authenticate("wrong-password")
            ? "Auth successful!"
            : "Invalid pass!");

        Console.Write("RegUser: ");
        Console.WriteLine(users[2].Authenticate("user")
            ? "Auth successful!"
            : "Invalid pass!");
    }
}
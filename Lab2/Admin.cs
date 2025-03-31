namespace Lab2;

public class Admin : User
{
	public Admin(string userName, string email) : base(userName, email)
	{
	}

	public void BlockUser(User user)
	{
		Console.WriteLine($"User {user.UserName} was banned.");
	}

	public override void DisplayInfo()
	{
		Console.WriteLine($"Name: {UserName} | Email: {Email} | Role: Admin");
	}
}
namespace Lab2;

public class Moderator : User
{
	public Moderator(string userName, string email) : base(userName, email)
	{
	}

	public void ModerateContent()
	{
		Console.WriteLine("Контент модеровано.");
	}

	public override void DisplayInfo()
	{
		Console.WriteLine($"Name: {UserName} | Email: {Email} | Role: Moderator");
	}
}
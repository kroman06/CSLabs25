namespace Lab2;

public class RegularUser : User
{
	public RegularUser(string userName, string email) : base(userName, email)
	{
	}

	public void PostComment()
	{
		Console.WriteLine("Successfully posted comment!");
	}

	public override void DisplayInfo()
	{
		Console.WriteLine($"Name: {UserName} | Email: {Email} | Role: User");
	}
}
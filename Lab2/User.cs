namespace Lab2;

public class User
{
	public string UserName { get; }
	public string Email { get; }
	private string _password;

	public User(string userName, string email)
	{
		UserName = userName;
		Email = email;
	}

	public void SetPassword(string newPassword)
	{
		_password = newPassword;
	}

	public bool Authenticate(string inputPassword)
	{
		return _password == inputPassword;
	}

	public virtual void DisplayInfo()
	{
		Console.WriteLine($"Name: {UserName} | Email: {Email}");
	}
}
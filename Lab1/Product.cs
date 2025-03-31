namespace Lab1;

public class Product
{
	private string _name;
	private decimal _price;
	private int _quantity;

	public Product(string name, decimal price, int quantity)
	{
		Name = name;
		Price = price;
		_quantity = quantity;
	}

	public int Quantity => _quantity;
	public decimal TotalValue => _price * _quantity;

	public string Name
	{
		get => _name;
		set
		{
			if (string.IsNullOrWhiteSpace(value))
			{
				throw new ArgumentException("Invalid product name.");
			}
			_name = value;
		}
	}

	public decimal Price
	{
		get => _price;
		set
		{
			if (value < 0)
			{
				throw new ArgumentException("Price can't be lower than 0.    #lol why we even allow to set 0? XD");
			}
			_price = value;
		}
	}

	public void Restock(int amount)
	{
		if (amount <= 0)
		{
			throw new ArgumentException("Amount can't be less or equal to 0.");	
		}
		_quantity += amount;
	}

	public bool Sell(int amount)
	{
		if (amount <= 0)
		{
			throw new ArgumentException("Amount can't be less or equal to 0.");	
		}

		if (amount > _quantity)
		{
			throw new InvalidOperationException("No more quantity to sell.");
		}

		_quantity -= amount;
		return true;
	}

	public string GetInfo()
	{
		return $"Product: {_name}, Price: {_price:C}, Quantity: {_quantity}, Total price: {TotalValue:C}";
	}
}
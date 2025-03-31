namespace Lab3.DamageableObjects;

public class BreakableWall(int durability) : IDamageable
{
	private int _durability = durability;

	public bool IsDead => _durability <= 0;

	public void TakeDamage(int damage)
	{
		_durability -= damage;
		Console.WriteLine(_durability > 0
			? $"Wall got {damage} damage. Durability left: {_durability}"
			: $"Wall got {damage} damage and was destroyed.");
	}
}
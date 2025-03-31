namespace Lab3.DamageableObjects;

public class Enemy(int health) : IDamageable
{
	private int _health = health;

	public bool IsDead => _health <= 0;

	public void TakeDamage(int damage)
	{
		_health -= damage;
		Console.WriteLine(_health > 0
			? $"Enemy got {damage} damage. HP Left: {_health}"
			: $"Enemy got {damage} damage and died.");
	}
}
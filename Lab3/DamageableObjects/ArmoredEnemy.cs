namespace Lab3.DamageableObjects;

public class ArmoredEnemy(int health, int armor) : IDamageable
{
	private int _health = health;
	private int _armor = armor;

	public bool IsDead => _health <= 0;

	public void TakeDamage(int damage)
	{
		var effectiveDamage = Math.Max(damage - _armor, 0);
		_health -= effectiveDamage;
		if (_armor > 0)
		{
			_armor = Math.Min(_armor - damage / 2, 0);
		}

		Console.WriteLine(_health > 0
			? $"ArmoredEnemy got {effectiveDamage} damage. HP Left: {_health}"
			: $"ArmoredEnemy got {effectiveDamage} damage and died.");
	}
}
namespace Lab3;

public interface IDamageable
{
	void TakeDamage(int damage);
	bool IsDead { get; }
}
